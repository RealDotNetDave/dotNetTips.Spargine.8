```

BenchmarkDotNet v0.15.2, Windows 10 (10.0.19045.6216/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.304
  [Host]     : .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
  Job-ZSLFFS : .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

```
| Method                       | Categories | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Completed Work Items | Lock Contentions | Exceptions | Code Size | Gen0   | Allocated |
|----------------------------- |----------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |---------------------:|-----------------:|-----------:|----------:|-------:|----------:|
| **&#39;GetAllMessages: Separator&#39;**  | ****NEW****    | **167.11 ns** | **1.166 ns** | **1.090 ns** | **0.281 ns** | **165.00 ns** | **166.52 ns** | **167.32 ns** | **167.67 ns** | **169.37 ns** |  **5,984,022.6** |       **7.359 ns** |      **15.00** |    **2.640** |  **2.000** |   **0.0760** |    **2** | *****            | **No**       |                    **-** |                **-** |          **-** |     **809 B** | **0.0029** |     **280 B** |
| **GetAllMessages**               | ****           | **163.56 ns** | **1.367 ns** | **1.279 ns** | **0.330 ns** | **161.43 ns** | **162.75 ns** | **163.25 ns** | **164.31 ns** | **166.31 ns** |  **6,114,000.7** |       **7.335 ns** |      **15.00** |    **2.403** |  **2.000** |   **0.4717** |    **2** | *****            | **No**       |                    **-** |                **-** |          **-** |     **809 B** | **0.0029** |     **280 B** |
| **GetAllMessagesWithStackTrace** | ****           |  **70.95 ns** | **0.792 ns** | **0.702 ns** | **0.188 ns** |  **69.63 ns** |  **70.72 ns** |  **71.04 ns** |  **71.36 ns** |  **71.96 ns** | **14,094,848.5** |       **6.906 ns** |      **14.00** |    **2.281** |  **2.000** |  **-0.4590** |    **1** | *****            | **No**       |                    **-** |                **-** |          **-** |        **NA** | **0.0024** |     **224 B** |
