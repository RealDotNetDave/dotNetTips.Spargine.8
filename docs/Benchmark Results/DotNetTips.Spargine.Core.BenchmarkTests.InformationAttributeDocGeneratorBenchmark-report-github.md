```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5371/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  Job-VPTVLS : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

```
| Method    | Mean         | Error      | StdDev     | StdErr   | Min          | Q1           | Median       | Q3           | Max          | Op/s    | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Code Size | Allocated |
|---------- |-------------:|-----------:|-----------:|---------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|----------:|----------:|
| GetValues | 307,582.7 ns | 2,660.5 ns | 2,488.7 ns | 642.6 ns | 304,329.6 ns | 305,625.8 ns | 307,407.1 ns | 308,756.4 ns | 312,090.2 ns | 3,251.2 |      -313.8 ns |      15.00 |    1.859 |  2.000 |   0.3812 |    1 | *            | No       |          - |                    - |                - |   3,291 B |  57.82 KB |
