```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5737/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.203
  [Host]     : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  Job-WAULDK : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=**NEW**  

```
| Method  | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Code Size | Exceptions | Completed Work Items | Lock Contentions | Allocated |
|-------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|----------:|-----------:|---------------------:|-----------------:|----------:|
| ToWords | 5,395.9 ns | 12.84 ns | 10.72 ns | 2.97 ns | 5,374.1 ns | 5,396.0 ns | 5,397.8 ns | 5,402.3 ns | 5,414.2 ns | 185,326.9 |       5.013 ns |      13.00 |    2.458 |  2.000 |  -0.5117 |    1 | *            | No       | 0.0076 |   4,544 B |          - |                    - |                - |   1.04 KB |
