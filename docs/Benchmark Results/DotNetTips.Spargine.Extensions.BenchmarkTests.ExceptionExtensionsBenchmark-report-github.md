```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5487/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.200
  [Host]     : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  Job-XKIKDN : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

```
| Method                       | Categories | Mean     | Error    | StdDev   | StdErr   | Min      | Q1       | Median   | Q3       | Max      | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Exceptions | Completed Work Items | Lock Contentions | Code Size | Allocated |
|----------------------------- |----------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|-----------:|---------------------:|-----------------:|----------:|----------:|
| **&#39;GetAllMessages: Separator&#39;**  | ****NEW****    | **82.69 ns** | **1.654 ns** | **2.319 ns** | **0.446 ns** | **80.41 ns** | **80.78 ns** | **81.69 ns** | **84.16 ns** | **88.24 ns** | **12,092,630.6** |      **13.277 ns** |      **27.00** |    **2.741** |  **2.125** |   **0.9620** |    **2** | *****            | **No**       | **0.0014** |          **-** |                    **-** |                **-** |     **854 B** |     **136 B** |
| **GetAllMessages**               | ****           | **90.44 ns** | **1.722 ns** | **1.526 ns** | **0.408 ns** | **89.26 ns** | **89.48 ns** | **89.73 ns** | **91.08 ns** | **94.71 ns** | **11,056,486.6** |       **6.796 ns** |      **14.00** |    **4.563** |  **2.000** |   **1.5247** |    **3** | *****            | **No**       | **0.0014** |          **-** |                    **-** |                **-** |     **854 B** |     **136 B** |
| **GetAllMessagesWithStackTrace** | ****           | **74.99 ns** | **0.999 ns** | **0.780 ns** | **0.225 ns** | **74.03 ns** | **74.25 ns** | **74.82 ns** | **75.55 ns** | **76.36 ns** | **13,335,723.1** |       **5.887 ns** |      **12.00** |    **1.587** |  **2.000** |   **0.2871** |    **1** | *****            | **No**       | **0.0024** |          **-** |                    **-** |                **-** |   **2,124 B** |     **224 B** |
