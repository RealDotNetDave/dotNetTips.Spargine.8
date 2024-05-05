```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4291/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.300-preview.24203.14
  [Host]     : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  Job-XJVIUY : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

```
| Method         | Mean     | Error    | StdDev   | StdErr   | Min      | Q1       | Median   | Q3       | Max      | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Exceptions | Completed Work Items | Lock Contentions | Code Size | Allocated |
|--------------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|-----------:|---------------------:|-----------------:|----------:|----------:|
| GetAllMessages | 77.77 ns | 0.331 ns | 0.294 ns | 0.079 ns | 77.26 ns | 77.56 ns | 77.86 ns | 77.96 ns | 78.19 ns | 12,858,449.4 |      0.3314 ns |      14.00 |    1.624 |  2.000 |  -0.3390 |    1 | *            | No       | 0.0015 |          - |                    - |                - |   1,126 B |     144 B |
