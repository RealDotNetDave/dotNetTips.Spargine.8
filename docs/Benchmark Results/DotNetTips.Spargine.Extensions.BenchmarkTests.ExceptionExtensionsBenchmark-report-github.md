```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5487/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.200
  [Host]     : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  Job-JHXHAM : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

```
| Method                       | Categories | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Code Size | Completed Work Items | Lock Contentions | Exceptions | Allocated |
|----------------------------- |----------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|----------:|---------------------:|-----------------:|-----------:|----------:|
| **&#39;GetAllMessages: Separator&#39;**  | ****NEW****    | **159.39 ns** | **1.195 ns** | **1.059 ns** | **0.283 ns** | **157.95 ns** | **158.74 ns** | **159.43 ns** | **160.07 ns** | **161.41 ns** |  **6,273,925.7** |       **6.858 ns** |      **14.00** |    **1.943** |  **2.000** |   **0.2232** |    **2** | *****            | **No**       | **0.0029** |     **804 B** |                    **-** |                **-** |          **-** |     **280 B** |
| **GetAllMessages**               | ****           | **159.57 ns** | **0.906 ns** | **0.847 ns** | **0.219 ns** | **158.20 ns** | **159.04 ns** | **159.50 ns** | **160.14 ns** | **161.38 ns** |  **6,266,724.9** |       **7.391 ns** |      **15.00** |    **2.325** |  **2.000** |   **0.3076** |    **2** | *****            | **No**       | **0.0029** |     **804 B** |                    **-** |                **-** |          **-** |     **280 B** |
| **GetAllMessagesWithStackTrace** | ****           |  **69.30 ns** | **0.465 ns** | **0.435 ns** | **0.112 ns** |  **68.71 ns** |  **68.95 ns** |  **69.26 ns** |  **69.52 ns** |  **70.15 ns** | **14,429,902.4** |       **7.444 ns** |      **15.00** |    **1.992** |  **2.000** |   **0.5115** |    **1** | *****            | **No**       | **0.0024** |        **NA** |                    **-** |                **-** |          **-** |     **224 B** |
