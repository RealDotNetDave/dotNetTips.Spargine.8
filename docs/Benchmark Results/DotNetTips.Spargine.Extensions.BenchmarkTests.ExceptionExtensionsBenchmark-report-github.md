```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5371/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  Job-QFIUKL : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

```
| Method                       | Mean     | Error    | StdDev   | StdErr   | Min      | Q1       | Median   | Q3       | Max      | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Gen0   | Code Size | Allocated |
|----------------------------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|-------:|----------:|----------:|
| **GetAllMessages**               | **79.12 ns** | **0.454 ns** | **0.379 ns** | **0.105 ns** | **78.20 ns** | **79.03 ns** | **79.12 ns** | **79.36 ns** | **79.77 ns** | **12,638,496.8** |       **6.447 ns** |      **13.00** |    **3.525** |  **2.000** |  **-0.7185** |    **2** | *****            | **No**       |          **-** |                    **-** |                **-** | **0.0014** |     **854 B** |     **136 B** |
| **GetAllMessagesWithStackTrace** | **66.84 ns** | **0.368 ns** | **0.326 ns** | **0.087 ns** | **66.39 ns** | **66.60 ns** | **66.83 ns** | **66.96 ns** | **67.42 ns** | **14,960,213.3** |       **6.956 ns** |      **14.00** |    **1.817** |  **2.000** |   **0.3191** |    **1** | *****            | **No**       |          **-** |                    **-** |                **-** | **0.0024** |   **2,847 B** |     **224 B** |
