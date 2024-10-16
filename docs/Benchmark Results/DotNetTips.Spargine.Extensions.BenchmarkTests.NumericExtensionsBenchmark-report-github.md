```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5011/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.403
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  Job-QYBNOF : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=**NEW**  

```
| Method  | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Code Size | Gen0   | Allocated |
|-------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|----------:|-------:|----------:|
| ToWords | 5,320.1 ns | 22.66 ns | 21.20 ns | 5.47 ns | 5,287.8 ns | 5,305.2 ns | 5,312.8 ns | 5,335.1 ns | 5,356.6 ns | 187,966.1 |       4.764 ns |      15.00 |    1.782 |  2.000 |   0.4006 |    1 | *            | No       |          - |                    - |                - |   4,587 B | 0.0076 |   1.04 KB |
