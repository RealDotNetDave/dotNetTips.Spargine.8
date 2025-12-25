```

BenchmarkDotNet v0.15.2, Windows 10 (10.0.19045.6691/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.308
  [Host]     : .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
  Job-ZSLFFS : .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

```
| Method    | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Completed Work Items | Lock Contentions | Gen0   | Exceptions | Code Size | Allocated |
|---------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |---------------------:|-----------------:|-------:|-----------:|----------:|----------:|
| GetValues | 1,262.8 ns | 15.02 ns | 14.05 ns | 3.63 ns | 1,236.3 ns | 1,253.8 ns | 1,265.4 ns | 1,271.1 ns | 1,288.1 ns | 791,918.4 |       5.687 ns |      15.00 |    2.122 |  2.000 |  -0.0276 |    1 | *            | No       |                    - |                - | 0.0076 |          - |   1,889 B |     840 B |
