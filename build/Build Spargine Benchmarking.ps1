dotnet clean D:\src\GitHub\dotNetTips.Spargine.8\dotNetTips.Spargine.8.Benchmarking.sln

dotnet build D:\src\GitHub\dotNetTips.Spargine.8\dotNetTips.Spargine.8.Benchmarking.sln --configuration Release

dotnet pack "D:\src\GitHub\dotNetTips.Spargine.8\source\Benchmarking\dotNetTips.Spargine.8.Benchmarking\DotNetTips.Spargine.8.Benchmarking.csproj" --include-source --include-symbols --output  "c:\dotNetTips.com\NuGet"

