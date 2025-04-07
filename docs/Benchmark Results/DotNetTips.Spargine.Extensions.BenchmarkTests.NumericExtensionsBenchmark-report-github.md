```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5608/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.201
  [Host]     : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  Job-QFNFJQ : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=**NEW**  

```
| Method  | Mean       | Error    | StdDev  | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Code Size | Gen0   | Allocated |
|-------- |-----------:|---------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|----------:|-------:|----------:|
| ToWords | 5,393.0 ns | 11.56 ns | 9.65 ns | 2.68 ns | 5,381.0 ns | 5,387.7 ns | 5,390.6 ns | 5,396.9 ns | 5,416.6 ns | 185,427.2 |       5.161 ns |      13.00 |    3.258 |  2.000 |   0.9511 |    1 | *            | No       |          - |                    - |                - |   4,551 B | 0.0076 |   1.04 KB |
