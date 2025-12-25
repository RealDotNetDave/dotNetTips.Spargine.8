```

BenchmarkDotNet v0.15.2, Windows 10 (10.0.19045.6691/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.308
  [Host]     : .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
  Job-ZSLFFS : .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests.Security  Categories=Encryption,**NEW**  

```
| Method           | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Allocated |
|----------------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|----------:|
| GeneratePassword | 873.9 ns | 6.66 ns | 6.23 ns | 1.61 ns | 865.5 ns | 868.9 ns | 872.9 ns | 877.6 ns | 885.7 ns | 1,144,325.3 |       6.696 ns |      15.00 |    1.914 |  2.000 |   0.4286 |    1 | *            | No       |          - |                    - |                - |      80 B |
