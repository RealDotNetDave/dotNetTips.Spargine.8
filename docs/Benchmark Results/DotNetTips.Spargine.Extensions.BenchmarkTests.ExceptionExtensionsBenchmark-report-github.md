```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5371/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  Job-TMHTGD : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

```
| Method                       | Mean     | Error    | StdDev   | StdErr   | Min      | Q1       | Median   | Q3       | Max      | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Gen0   | Code Size | Allocated |
|----------------------------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|-------:|----------:|----------:|
| **GetAllMessages**               | **78.02 ns** | **0.274 ns** | **0.243 ns** | **0.065 ns** | **77.63 ns** | **77.92 ns** | **78.00 ns** | **78.14 ns** | **78.52 ns** | **12,816,612.2** |       **6.968 ns** |      **14.00** |    **2.380** |  **2.000** |   **0.3643** |    **2** | *****            | **No**       |          **-** |                    **-** |                **-** | **0.0014** |     **854 B** |     **136 B** |
| **GetAllMessagesWithStackTrace** | **72.70 ns** | **0.229 ns** | **0.214 ns** | **0.055 ns** | **72.38 ns** | **72.54 ns** | **72.68 ns** | **72.89 ns** | **73.09 ns** | **13,754,552.3** |       **7.472 ns** |      **15.00** |    **1.658** |  **2.000** |   **0.1910** |    **1** | *****            | **No**       |          **-** |                    **-** |                **-** | **0.0024** |   **2,835 B** |     **224 B** |
