```

BenchmarkDotNet v0.15.2, Windows 10 (10.0.19045.6093/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.302
  [Host]     : .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
  Job-ZSLFFS : .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

```
| Method                       | Categories | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Completed Work Items | Lock Contentions | Exceptions | Code Size | Gen0   | Allocated |
|----------------------------- |----------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |---------------------:|-----------------:|-----------:|----------:|-------:|----------:|
| **&#39;GetAllMessages: Separator&#39;**  | ****NEW****    | **166.22 ns** | **0.761 ns** | **0.675 ns** | **0.180 ns** | **165.08 ns** | **165.80 ns** | **166.17 ns** | **166.79 ns** | **167.57 ns** |  **6,015,979.6** |       **6.910 ns** |      **14.00** |    **2.106** |  **2.000** |   **0.2196** |    **2** | *****            | **No**       |                    **-** |                **-** |          **-** |     **809 B** | **0.0029** |     **280 B** |
| **GetAllMessages**               | ****           | **166.86 ns** | **0.739 ns** | **0.655 ns** | **0.175 ns** | **164.82 ns** | **166.76 ns** | **167.03 ns** | **167.27 ns** | **167.37 ns** |  **5,993,161.5** |       **6.912 ns** |      **14.00** |    **6.761** |  **2.000** |  **-2.0362** |    **2** | *****            | **No**       |                    **-** |                **-** |          **-** |     **809 B** | **0.0029** |     **280 B** |
| **GetAllMessagesWithStackTrace** | ****           |  **69.52 ns** | **0.449 ns** | **0.420 ns** | **0.108 ns** |  **68.77 ns** |  **69.27 ns** |  **69.51 ns** |  **69.78 ns** |  **70.32 ns** | **14,385,160.3** |       **7.446 ns** |      **15.00** |    **2.249** |  **2.000** |   **0.2422** |    **1** | *****            | **No**       |                    **-** |                **-** |          **-** |        **NA** | **0.0024** |     **224 B** |
