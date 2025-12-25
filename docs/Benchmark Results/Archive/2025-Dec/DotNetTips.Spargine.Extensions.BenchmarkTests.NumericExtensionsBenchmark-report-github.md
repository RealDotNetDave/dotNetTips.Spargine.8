```

BenchmarkDotNet v0.15.2, Windows 10 (10.0.19045.6216/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.304
  [Host]     : .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
  Job-ZSLFFS : .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=**NEW**  

```
| Method  | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Gen0   | Completed Work Items | Lock Contentions | Exceptions | Allocated |
|-------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-------:|---------------------:|-----------------:|-----------:|----------:|
| ToWords | 5,543.6 ns | 31.51 ns | 29.48 ns | 7.61 ns | 5,503.7 ns | 5,523.2 ns | 5,542.5 ns | 5,556.9 ns | 5,605.6 ns | 180,387.0 |       3.695 ns |      15.00 |    2.231 |  2.000 |   0.3508 |    1 | *            | No       |   4,551 B | 0.0076 |                    - |                - |          - |   1.04 KB |
