```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4651/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.302
  [Host]     : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  Job-ZSORKR : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

```
| Method                       | Mean     | Error    | StdDev   | StdErr   | Median   | Min      | Q1       | Q3       | Max      | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Exceptions | Completed Work Items | Lock Contentions | Gen0   | Allocated |
|----------------------------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-----------:|---------------------:|-----------------:|-------:|----------:|
| **GetAllMessages**               | **79.85 ns** | **1.592 ns** | **1.833 ns** | **0.410 ns** | **78.96 ns** | **77.52 ns** | **78.49 ns** | **81.47 ns** | **83.10 ns** | **12,523,104.9** |       **1.592 ns** |      **20.00** |    **1.517** |  **2.000** |   **0.4231** |    **2** | *****            | **No**       |     **842 B** |          **-** |                    **-** |                **-** | **0.0014** |     **136 B** |
| **GetAllMessagesWithStackTrace** | **69.95 ns** | **1.419 ns** | **2.332 ns** | **0.394 ns** | **68.68 ns** | **67.61 ns** | **67.90 ns** | **72.71 ns** | **73.79 ns** | **14,295,939.3** |       **1.419 ns** |      **35.00** |    **1.439** |  **2.700** |   **0.5182** |    **1** | *****            | **No**       |   **2,836 B** |          **-** |                    **-** |                **-** | **0.0024** |     **224 B** |
