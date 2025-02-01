```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5371/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  Job-FLPXNP : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

```
| Method    | Mean         | Error    | StdDev   | StdErr   | Min          | Q1           | Median       | Q3           | Max          | Op/s    | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Gen0   | Code Size | Allocated |
|---------- |-------------:|---------:|---------:|---------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|-------:|----------:|----------:|
| GetValues | 293,805.2 ns | 798.8 ns | 623.6 ns | 180.0 ns | 292,286.0 ns | 293,640.5 ns | 293,850.1 ns | 294,172.4 ns | 294,546.3 ns | 3,403.6 |      -84.01 ns |      12.00 |    3.349 |  2.000 |  -0.9685 |    1 | *            | No       |          - |                    - |                - | 0.4883 |   3,263 B |  57.73 KB |
