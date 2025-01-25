```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5371/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  Job-VPTVLS : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

```
| Method    | Mean       | Error   | StdDev  | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Gen0   | Completed Work Items | Lock Contentions | Code Size | Allocated |
|---------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|-------:|---------------------:|-----------------:|----------:|----------:|
| GetValues | 1,189.5 ns | 7.55 ns | 7.06 ns | 1.82 ns | 1,180.1 ns | 1,182.5 ns | 1,191.5 ns | 1,193.7 ns | 1,201.7 ns | 840,690.4 |       6.589 ns |      15.00 |    1.588 |  2.000 |  -0.0170 |    1 | *            | No       |          - | 0.0076 |                    - |                - |   1,884 B |     840 B |
