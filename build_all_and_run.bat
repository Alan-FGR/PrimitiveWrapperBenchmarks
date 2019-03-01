dotnet restore
FOR /L %%I IN (0,1,63) DO (
   echo "building %%I..."
   dotnet msbuild /t:Clean;Rebuild /p:Platform=x64 /p:Configuration=Release /p:DefineConstants=f%%I /p:OutDir=..\tests\%%I PrimitiveWrapperBenchmarks\PrimitiveWrapperBenchmarks.csproj
)
FOR /L %%I IN (0,1,63) DO (
   dotnet tests\%%I\PrimitiveWrapperBenchmarks.dll
)