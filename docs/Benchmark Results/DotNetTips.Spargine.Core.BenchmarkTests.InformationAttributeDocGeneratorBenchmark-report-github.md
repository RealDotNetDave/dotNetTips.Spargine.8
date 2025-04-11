```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5737/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.203
  [Host]     : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  Job-KOMWZH : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

```
| Method    | Mean         | Error      | StdDev     | StdErr   | Min          | Q1           | Median       | Q3           | Max          | Op/s    | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Allocated |
|---------- |-------------:|-----------:|-----------:|---------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|----------:|
| GetValues | 349,078.6 ns | 2,088.1 ns | 1,953.2 ns | 504.3 ns | 346,375.6 ns | 347,803.6 ns | 349,001.9 ns | 349,963.6 ns | 352,926.8 ns | 2,864.7 |      -244.7 ns |      15.00 |    1.989 |  2.000 |   0.3166 |    1 | *            | No       |          - |                    - |                - |  72.56 KB |
