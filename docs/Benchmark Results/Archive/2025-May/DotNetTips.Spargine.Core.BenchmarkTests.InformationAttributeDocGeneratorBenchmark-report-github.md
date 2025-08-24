```

BenchmarkDotNet v0.15.2, Windows 10 (10.0.19045.6093/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.302
  [Host]     : .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
  Job-ZSLFFS : .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

```
| Method    | Mean         | Error      | StdDev     | StdErr   | Min          | Q1           | Median       | Q3           | Max          | Op/s    | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Allocated |
|---------- |-------------:|-----------:|-----------:|---------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|----------:|
| GetValues | 357,065.6 ns | 2,504.6 ns | 2,091.4 ns | 580.1 ns | 354,244.2 ns | 355,541.6 ns | 356,875.7 ns | 358,465.4 ns | 360,878.8 ns | 2,800.6 |      -283.5 ns |      13.00 |    1.796 |  2.000 |   0.4287 |    1 | *            | No       |          - |                    - |                - |  72.46 KB |
