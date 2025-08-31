```

BenchmarkDotNet v0.15.2, Windows 10 (10.0.19045.6216/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.304
  [Host]     : .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
  Job-ZSLFFS : .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests.Security  Categories=Encryption,**NEW**  

```
| Method           | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Completed Work Items | Lock Contentions | Exceptions | Allocated |
|----------------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |---------------------:|-----------------:|-----------:|----------:|
| GeneratePassword | 897.3 ns | 4.56 ns | 3.56 ns | 1.03 ns | 892.1 ns | 894.7 ns | 896.9 ns | 900.1 ns | 903.6 ns | 1,114,463.0 |       5.486 ns |      12.00 |    1.621 |  2.000 |   0.1694 |    1 | *            | No       |                    - |                - |          - |      80 B |
