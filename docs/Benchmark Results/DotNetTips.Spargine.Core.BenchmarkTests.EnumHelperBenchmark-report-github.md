```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4651/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.302
  [Host]     : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  Job-PIGZLB : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

```
| Method    | Mean       | Error   | StdDev  | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Gen0   | Completed Work Items | Lock Contentions | Code Size | Allocated |
|---------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|-------:|---------------------:|-----------------:|----------:|----------:|
| GetValues | 1,239.6 ns | 5.43 ns | 4.81 ns | 1.29 ns | 1,234.6 ns | 1,236.2 ns | 1,238.0 ns | 1,241.0 ns | 1,250.1 ns | 806,710.5 |       5.427 ns |      14.00 |    2.665 |  2.000 |   0.9988 |    1 | *            | No       |          - | 0.0095 |                    - |                - |   1,950 B |     904 B |
