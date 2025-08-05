```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5737/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.203
  [Host]     : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  Job-TAWJXX : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=**NEW**  

```
| Method  | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Completed Work Items | Lock Contentions | Exceptions | Code Size | Allocated |
|-------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|---------------------:|-----------------:|-----------:|----------:|----------:|
| ToWords | 5,494.3 ns | 39.63 ns | 37.07 ns | 9.57 ns | 5,413.5 ns | 5,469.8 ns | 5,497.5 ns | 5,524.3 ns | 5,535.8 ns | 182,006.9 |       2.715 ns |      15.00 |    2.185 |  2.000 |  -0.6457 |    1 | *            | No       | 0.0076 |                    - |                - |          - |   4,546 B |   1.04 KB |
