```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5011/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.403
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  Job-BXAHQI : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

```
| Method    | Mean       | Error   | StdDev  | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Exceptions | Code Size | Completed Work Items | Lock Contentions | Allocated |
|---------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|-----------:|----------:|---------------------:|-----------------:|----------:|
| GetValues | 1,187.3 ns | 4.86 ns | 4.31 ns | 1.15 ns | 1,180.9 ns | 1,183.9 ns | 1,188.1 ns | 1,190.9 ns | 1,193.1 ns | 842,256.8 |       6.424 ns |      14.00 |    1.424 |  2.000 |  -0.1439 |    1 | *            | No       | 0.0076 |          - |   1,907 B |                    - |                - |     840 B |
