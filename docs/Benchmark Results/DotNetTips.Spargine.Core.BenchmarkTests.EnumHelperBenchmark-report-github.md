```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5737/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.203
  [Host]     : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  Job-KOMWZH : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

```
| Method    | Mean       | Error   | StdDev  | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Exceptions | Code Size | Completed Work Items | Lock Contentions | Allocated |
|---------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|-----------:|----------:|---------------------:|-----------------:|----------:|
| GetValues | 1,206.4 ns | 8.76 ns | 8.19 ns | 2.12 ns | 1,193.1 ns | 1,200.3 ns | 1,207.1 ns | 1,209.9 ns | 1,222.5 ns | 828,946.5 |       6.442 ns |      15.00 |    2.101 |  2.000 |   0.1467 |    1 | *            | No       | 0.0076 |          - |   1,889 B |                    - |                - |     840 B |
