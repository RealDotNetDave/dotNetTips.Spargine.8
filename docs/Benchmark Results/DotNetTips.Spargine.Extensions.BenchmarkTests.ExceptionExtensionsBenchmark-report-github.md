```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5737/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.203
  [Host]     : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  Job-TAWJXX : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

```
| Method                       | Categories | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Completed Work Items | Lock Contentions | Code Size | Exceptions | Gen0   | Allocated |
|----------------------------- |----------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |---------------------:|-----------------:|----------:|-----------:|-------:|----------:|
| **&#39;GetAllMessages: Separator&#39;**  | ****NEW****    | **163.52 ns** | **0.646 ns** | **0.572 ns** | **0.153 ns** | **162.24 ns** | **163.26 ns** | **163.72 ns** | **163.88 ns** | **164.24 ns** |  **6,115,464.0** |       **6.924 ns** |      **14.00** |    **2.694** |  **2.000** |  **-0.8636** |    **2** | *****            | **No**       |                    **-** |                **-** |     **809 B** |          **-** | **0.0029** |     **280 B** |
| **GetAllMessages**               | ****           | **164.93 ns** | **0.746 ns** | **0.698 ns** | **0.180 ns** | **163.84 ns** | **164.44 ns** | **164.72 ns** | **165.27 ns** | **166.44 ns** |  **6,063,134.1** |       **7.410 ns** |      **15.00** |    **2.502** |  **2.000** |   **0.5769** |    **2** | *****            | **No**       |                    **-** |                **-** |     **809 B** |          **-** | **0.0029** |     **280 B** |
| **GetAllMessagesWithStackTrace** | ****           |  **69.90 ns** | **0.293 ns** | **0.245 ns** | **0.068 ns** |  **69.43 ns** |  **69.76 ns** |  **69.94 ns** |  **70.06 ns** |  **70.24 ns** | **14,305,163.6** |       **6.466 ns** |      **13.00** |    **1.896** |  **2.000** |  **-0.2787** |    **1** | *****            | **No**       |                    **-** |                **-** |        **NA** |          **-** | **0.0024** |     **224 B** |
