```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5487/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.200
  [Host]     : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  Job-JHXHAM : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=**NEW**  

```
| Method  | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Completed Work Items | Lock Contentions | Exceptions | Gen0   | Allocated |
|-------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|---------------------:|-----------------:|-----------:|-------:|----------:|
| ToWords | 5,412.2 ns | 24.59 ns | 23.00 ns | 5.94 ns | 5,360.2 ns | 5,399.7 ns | 5,409.0 ns | 5,425.1 ns | 5,455.4 ns | 184,769.0 |       4.530 ns |      15.00 |    2.836 |  2.000 |  -0.2759 |    1 | *            | No       |   4,544 B |                    - |                - |          - | 0.0076 |   1.04 KB |
