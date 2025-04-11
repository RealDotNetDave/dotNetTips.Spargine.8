```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5737/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.203
  [Host]     : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  Job-KOMWZH : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests.Security  Categories=Encryption,**NEW**  

```
| Method           | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Allocated |
|----------------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|----------:|
| GeneratePassword | 871.0 ns | 2.86 ns | 2.39 ns | 0.66 ns | 866.4 ns | 869.5 ns | 871.1 ns | 871.7 ns | 875.2 ns | 1,148,076.6 |       6.169 ns |      13.00 |    2.455 |  2.000 |   0.1050 |    1 | *            | No       |          - |                    - |                - |      80 B |
