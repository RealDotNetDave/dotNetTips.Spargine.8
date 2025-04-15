```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5737/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.203
  [Host]     : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  Job-BJZEEE : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=**NEW**  

```
| Method  | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Code Size | Exceptions | Completed Work Items | Lock Contentions | Allocated |
|-------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|----------:|-----------:|---------------------:|-----------------:|----------:|
| ToWords | 5,435.3 ns | 39.35 ns | 36.81 ns | 9.50 ns | 5,373.4 ns | 5,408.6 ns | 5,428.9 ns | 5,468.3 ns | 5,494.4 ns | 183,981.4 |       2.748 ns |      15.00 |    1.684 |  2.000 |   0.0222 |    1 | *            | No       | 0.0076 |   4,516 B |          - |                    - |                - |   1.04 KB |
