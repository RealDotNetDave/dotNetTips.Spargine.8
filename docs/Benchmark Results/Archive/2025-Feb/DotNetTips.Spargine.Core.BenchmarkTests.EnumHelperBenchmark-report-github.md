```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5371/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  Job-FLPXNP : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

```
| Method    | Mean       | Error   | StdDev  | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Gen0   | Completed Work Items | Lock Contentions | Code Size | Allocated |
|---------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|-------:|---------------------:|-----------------:|----------:|----------:|
| GetValues | 1,192.7 ns | 5.20 ns | 4.86 ns | 1.26 ns | 1,185.8 ns | 1,189.7 ns | 1,191.8 ns | 1,195.5 ns | 1,203.2 ns | 838,409.4 |       6.872 ns |      15.00 |    2.300 |  2.000 |   0.4133 |    1 | *            | No       |          - | 0.0076 |                    - |                - |   1,889 B |     840 B |
