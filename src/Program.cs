using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Net;
using System.Xml;
using MarcoWagner.StockWinner;
 
public class HelloWorld
{
    static public void Main ()
    {
        Console.WriteLine ("Hello Mono World");
		
		// https://forums.xamarin.com/discussion/10405/the-authentication-or-decryption-has-failed-in-the-web-request
		System.Net.ServicePointManager.ServerCertificateValidationCallback += (o, certificate, chain, errors) => true;
		
		var urlBase = "https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20yahoo.finance.quotes%20where%20symbol%20in%20({0})%20&diagnostics=false&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys";
		var symbolsByCountry = new [] {
				new {c = "GSX", s = Gsx.Symbols}, 
				new {c = "ASX", s = Asx.Symbols}, 
//				new {c = "NYSE", s = Nyse.Symbols}
			};
		var symbolsCount = symbolsByCountry.SelectMany(s => s.s).Count();
		var outputs = new List<Tuple<decimal, string>>();
		var resultDtos = new List<ResultDto>();
		
		var actualSymbolIndex = 0;
		foreach(var symbolsOfCountry in symbolsByCountry)
		{
			var country = symbolsOfCountry.c;
			var blocks = symbolsOfCountry.s.SplitToIntoBlocksOf(30);
			foreach(var block in blocks)
			{
				var blockTuples = new List<string>();
				foreach(var b in block)
				{
					// "b","b.DE"
					blockTuples.Add(string.Format("%22{0}%22%2C%22{0}.DE%22", b));
				}
				var url = string.Format(urlBase, string.Join("%2C", blockTuples));
				//string down = new WebClient().DownloadString("https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20yahoo.finance.quotes%20where%20symbol%20in%20(%22YHOO.DE%22%2C%22YHOO%22%2C%22AAPL%22%2C%22FOO%22%2C%22MSFT%22)%20&diagnostics=false&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys");
				var down = new WebClient().DownloadString(url);
				//Console.WriteLine(down);
				var test = down.DeserializeFromXml<query>();
				if(test == null)
				{
					Console.WriteLine("keine Daten");
					continue;
				}
			
				foreach(var result in test.results)
				{
					var prevClose = result.PreviousClose.ToDecimal();
					var open = result.Open.ToDecimal();
					var ask = result.Ask.ToDecimal();
					var bid = result.Bid.ToDecimal();
					var currency = result.Currency;
					var changePrevToBid = prevClose == 0 ? new decimal?() : (bid/prevClose - 1);
					// if(!changePrevToBid.HasValue)
					// {
						// continue;
					// }
					
					var lastTradePrice = result.LastTradePriceOnly.ToDecimal();
					var lastTradeDate = result.LastTradeDate.ToDateTime();
					var lastTradeTime = result.LastTradeTime.ToTime();
					if(lastTradeDate.HasValue && lastTradeTime.HasValue)
					{
						lastTradeDate = lastTradeDate.Value.AddSeconds(lastTradeTime.Value.TimeOfDay.TotalSeconds);
					}
					// if(!lastTrade.HasValue
						// || (DateTime.Now.Date - lastTrade.Value).TotalDays > 5)
					// {
						// continue;
					// }
					var tradedToday = lastTradeDate.HasValue && lastTradeDate.Value == DateTime.Now.Date;
					var symbolName = result.Name;
					if(string.IsNullOrEmpty(symbolName))
					{
						// leer? Dann Symbol wahrscheinlich ungültig.
						continue;
					}
					
					resultDtos.Add(
						new ResultDto
						{
							Symbol = result.Symbol, 
							Name = symbolName, 
							IsTradedToday = tradedToday,
							LastTradeDate = lastTradeDate,
							LastTradePrice = lastTradePrice,
							Ask = ask,
							Bid = bid,
							Currency = currency
						});
					
					var output = string.Format("{0} {1} {2} {3} {4} {5} {6} {7:###.000%}", 
						country,
						result.Symbol, 
						result.Name, 
						prevClose, 
						open, 
						ask, 
						bid, 
						changePrevToBid);
					
					if(changePrevToBid.HasValue)
					{
						outputs.Add(new Tuple<decimal, string>(changePrevToBid.Value, output));
					}
				}
				
				actualSymbolIndex += block.Length;
				ConsoleWriteProgress(actualSymbolIndex, symbolsCount);
//				break;
			}
		}
		
		//var outFileName = DateTime.Now.ToString("yyyyMMdd HHmmss") + ".txt";
		var outFileName = "_out.txt";
		var jsonOutFileName = "_out.json";
		outputs = outputs.OrderBy(o => o.Item1).ToList();
		File.WriteAllLines(outFileName, outputs.Select(o => o.Item2));
		SaveResultsToJsonFile(resultDtos, jsonOutFileName);
		UploadFile(jsonOutFileName);
		Calculate();
    }
	
	private static void SaveResultsToJsonFile(IEnumerable<ResultDto> results, string path)
	{
		var sb = new StringBuilder();
		//sb.AppendLine("\"results\":[");
		sb.AppendLine("{");
		var lines = results.Select((r,i)=>
		{
			var jsonEntries = new []
			{
				new Tuple<string, object> ("symbolCode", r.Symbol ),
				new Tuple<string, object> ("symbolName", r.Name ),
				new Tuple<string, object> ("isTradedToday", r.IsTradedToday ),
				new Tuple<string, object> ("lastTradeDate", r.LastTradeDate ),
				new Tuple<string, object> ("lastTradePrice", r.LastTradePrice ),
				new Tuple<string, object> ("ask", r.Ask ),
				new Tuple<string, object> ("bid", r.Bid ),
				new Tuple<string, object> ("currency", r.Currency ),
			};
			
			var entryParts = jsonEntries.Select(j=>
			{
				string valueFormat;
				if(j.Item2 is string
					|| j.Item2 is DateTime)
				{
					valueFormat = "\"{0}\"";
				}
				else
				{
					valueFormat = "{0}";
				}
				
				string valueString;
				if(j.Item2 == null)
				{
					valueString = "null";
				}
				else
				{
					//default
					valueString = string.Format(CultureInfo.InvariantCulture, "{0}", j.Item2);
					
					if(j.Item2 is bool)
					{
						valueString = (bool)j.Item2 ? "true" : "false";
					}
					if(j.Item2 is DateTime)
					{
						valueString = ((DateTime)j.Item2).ToString("o");
					}
				}
				
				return string.Concat(
					string.Format("\"{0}\":", j.Item1),
					string.Format(valueFormat, valueString));
			});
			
			//return string.Format("\"{0}\":{{\"symbolCode\":\"{1}\", \"symbolName\":\"{2}\", \"isTradedToday\":\"{3}\"}}", i, r.Symbol, r.Name, r.IsTradedToday);
			return string.Format("\"{0}\":{{{1}}}", i, string.Join(", ", entryParts));
		});
		sb.AppendLine(string.Join("," + Environment.NewLine, lines));
		//sb.AppendLine("]");
		sb.AppendLine("}");
		
		File.WriteAllText(path, sb.ToString());
	}
	
	private static void ConsoleWriteProgress(int actual, int expected)
	{
		var current = (decimal)actual/(decimal)expected;
		
		var consolePositionTop = Console.CursorTop;
		
		if(Console.CursorLeft > 0)
		{
			consolePositionTop++;
		}
		
		Console.SetCursorPosition(0, consolePositionTop);
		
		Console.Write("{0:###.##%}", current);
		
		Console.SetCursorPosition(0, consolePositionTop);
	}
	
	private static void UploadFile(string path)
	{
		// var url = string.Format(
			// "http://www.raumwolken.de/sw/ws_save.php?symbol={0}&name={1}",
			// WebUtility.UrlEncode(symbol),
			// WebUtility.UrlEncode(name));
		var url = "http://www.raumwolken.de/sw/ws_upload.php";

		try
		{
			var webClient = new WebClient();
			webClient.Headers.Add("user-agent", "Only a test!");
			byte[] responseArray = webClient.UploadFile(url, path);
			Console.WriteLine(
				"\nResponse Received.The contents of the file uploaded are:\n{0}", 
				System.Text.Encoding.ASCII.GetString(responseArray));
//			Console.ReadLine();

		}
		catch(Exception ex)
		{
			Console.WriteLine(url);
			Console.WriteLine(ex);
			throw;
		}
	}
	
	private static void Calculate()
	{
		var url = "http://www.raumwolken.de/sw/ws_calculate.php?daysInPast=1";

		try
		{
			var webClient = new WebClient();
			var result = webClient.DownloadString(url);
			Console.WriteLine("\nRecalculation requested: \n{0}", result);
		}
		catch(Exception ex)
		{
			Console.WriteLine(url);
			Console.WriteLine(ex);
			throw;
		}
	}
}