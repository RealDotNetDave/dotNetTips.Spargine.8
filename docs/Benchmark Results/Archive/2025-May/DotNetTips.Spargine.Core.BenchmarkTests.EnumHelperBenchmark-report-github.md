```

BenchmarkDotNet v0.15.2, Windows 10 (10.0.19045.6093/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.302
  [Host]     : .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
  Job-ZSLFFS : .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

```
| Method    | Mean       | Error   | StdDev  | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Gen0   | Completed Work Items | Lock Contentions | Exceptions | Allocated |
|---------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-------:|---------------------:|-----------------:|-----------:|----------:|
| GetValues | 1,207.5 ns | 3.66 ns | 2.86 ns | 0.83 ns | 1,201.6 ns | 1,206.4 ns | 1,207.6 ns | 1,209.7 ns | 1,211.0 ns | 828,185.3 |       5.587 ns |      12.00 |    2.226 |  2.000 |  -0.5587 |    1 | *            | No       |   1,891 B | 0.0076 |                    - |                - |          - |     840 B |
