
set fdir="C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\15.0\Bin"

::if not exist %fdir% (
::	set fdir=%WINDIR%\Microsoft.NET\Framework
::)

set msbuild=%fdir%\msbuild.exe
%msbuild% ../src/Raven.Rpc.Tracing.Record.Kafka/Raven.Rpc.Tracing.Record.Kafka.csproj /t:Clean;Rebuild /p:Configuration=Release;OutputPath="..\..\output\net46\Raven.Rpc.Tracing.Record.Kafka"

pause