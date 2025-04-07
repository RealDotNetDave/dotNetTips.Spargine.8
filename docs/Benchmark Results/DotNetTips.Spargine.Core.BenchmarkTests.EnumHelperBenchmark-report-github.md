```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5608/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.201
  [Host]     : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  Job-CIJPPL : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

```
| Method    | Mean       | Error   | StdDev  | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Exceptions | Code Size | Completed Work Items | Lock Contentions | Allocated |
|---------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|-----------:|----------:|---------------------:|-----------------:|----------:|
| GetValues | 1,238.8 ns | 6.41 ns | 6.00 ns | 1.55 ns | 1,229.8 ns | 1,234.5 ns | 1,239.6 ns | 1,243.0 ns | 1,250.4 ns | 807,262.7 |       6.725 ns |      15.00 |    1.813 |  2.000 |   0.1958 |    1 | *            | No       | 0.0076 |          - |   1,889 B |                    - |                - |     840 B |
