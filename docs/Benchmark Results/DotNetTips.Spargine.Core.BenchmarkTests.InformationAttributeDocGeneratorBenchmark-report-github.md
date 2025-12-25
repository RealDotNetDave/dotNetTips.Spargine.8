```

BenchmarkDotNet v0.15.2, Windows 10 (10.0.19045.6691/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.308
  [Host]     : .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
  Job-ZSLFFS : .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

```
| Method    | Mean         | Error      | StdDev     | StdErr   | Min          | Q1           | Median       | Q3           | Max          | Op/s    | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Completed Work Items | Lock Contentions | Exceptions | Allocated |
|---------- |-------------:|-----------:|-----------:|---------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |---------------------:|-----------------:|-----------:|----------:|
| GetValues | 346,875.1 ns | 3,914.0 ns | 3,268.4 ns | 906.5 ns | 340,907.2 ns | 344,661.9 ns | 346,272.9 ns | 349,360.2 ns | 352,766.5 ns | 2,882.9 |      -446.7 ns |      13.00 |    2.155 |  2.000 |   0.1675 |    1 | *            | No       |                    - |                - |          - |  72.47 KB |
