```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5011/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.403
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  Job-QYBNOF : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

```
| Method                       | Mean     | Error    | StdDev   | StdErr   | Min      | Q1       | Median   | Q3       | Max      | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Code Size | Gen0   | Allocated |
|----------------------------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|----------:|-------:|----------:|
| **GetAllMessages**               | **75.79 ns** | **0.572 ns** | **0.507 ns** | **0.135 ns** | **75.12 ns** | **75.42 ns** | **75.64 ns** | **76.06 ns** | **76.80 ns** | **13,194,988.3** |       **6.932 ns** |      **14.00** |    **2.012** |  **2.000** |   **0.6018** |    **2** | *****            | **No**       |          **-** |                    **-** |                **-** |     **842 B** | **0.0014** |     **136 B** |
| **GetAllMessagesWithStackTrace** | **66.67 ns** | **0.202 ns** | **0.179 ns** | **0.048 ns** | **66.34 ns** | **66.62 ns** | **66.69 ns** | **66.77 ns** | **66.93 ns** | **15,000,093.4** |       **6.976 ns** |      **14.00** |    **2.140** |  **2.000** |  **-0.4712** |    **1** | *****            | **No**       |          **-** |                    **-** |                **-** |   **2,100 B** | **0.0024** |     **224 B** |
