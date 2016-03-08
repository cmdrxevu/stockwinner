using System;

namespace MarcoWagner.StockWinner
{
	public class ResultDto
	{
		public string Symbol { get; set; }
		public string Name { get; set; }
		public bool IsTradedToday { get; set; }
		public DateTime? LastTradeDate { get; set; }
		public decimal? LastTradePrice { get; set; }
		public decimal? Ask { get; set; }
		public decimal? Bid { get; set; }
		public string Currency { get; set; }
	}
}