call "C:\Program Files (x86)\Mono\\bin\setmonopath.bat"
rem C:\Progra~2\Mono\\bin\setmonopath.bat

rem cmd /c "mcs Program.cs -r:System.Data.dll -r:Mono.Data.Sqlite.dll"
rem cmd /c "sn -Vr Program.exe"
cmd /c "mcs Program.cs XmlSerializationExtensions.cs StringExtensions.cs yql-result_yql-result_app1.cs Asx.cs Gsx.cs Nyse.cs IEnumerableExtensions.cs ResultDto.cs -r:mscorlib.dll"
cmd /c "Program.exe"

pause
