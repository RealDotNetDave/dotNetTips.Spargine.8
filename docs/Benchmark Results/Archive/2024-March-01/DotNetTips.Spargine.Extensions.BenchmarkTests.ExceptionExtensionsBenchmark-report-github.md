```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  Job-TLMPGC : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

```
| Method         | Mean     | Error    | StdDev   | StdErr   | Min      | Q1       | Median   | Q3       | Max      | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Exceptions | Completed Work Items | Lock Contentions | Code Size | Allocated |
|--------------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|-----------:|---------------------:|-----------------:|----------:|----------:|
| GetAllMessages | 79.47 ns | 0.472 ns | 0.394 ns | 0.109 ns | 78.82 ns | 79.20 ns | 79.41 ns | 79.60 ns | 80.20 ns | 12,582,680.2 |      0.4720 ns |      13.00 |    2.147 |  2.000 |   0.3038 |    1 | *            | No       | 0.0015 |          - |                    - |                - |   1,126 B |     144 B |
