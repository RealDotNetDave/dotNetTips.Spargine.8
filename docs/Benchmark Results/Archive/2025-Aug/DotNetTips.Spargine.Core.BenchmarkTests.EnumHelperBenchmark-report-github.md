```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5737/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.203
  [Host]     : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  Job-FORZLD : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

```
| Method    | Mean       | Error    | StdDev  | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Completed Work Items | Lock Contentions | Exceptions | Code Size | Allocated |
|---------- |-----------:|---------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|---------------------:|-----------------:|-----------:|----------:|----------:|
| GetValues | 1,205.9 ns | 10.13 ns | 9.47 ns | 2.45 ns | 1,189.4 ns | 1,200.0 ns | 1,204.5 ns | 1,213.1 ns | 1,221.9 ns | 829,248.7 |       6.277 ns |      15.00 |    1.740 |  2.000 |  -0.1276 |    1 | *            | No       | 0.0076 |                    - |                - |          - |   1,889 B |     840 B |
