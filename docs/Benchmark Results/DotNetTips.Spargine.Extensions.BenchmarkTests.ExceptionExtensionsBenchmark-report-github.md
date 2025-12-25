```

BenchmarkDotNet v0.15.2, Windows 10 (10.0.19045.6691/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.308
  [Host]     : .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
  Job-ZSLFFS : .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

```
| Method                       | Categories | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Code Size | Completed Work Items | Lock Contentions | Gen0   | Allocated |
|----------------------------- |----------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|----------:|---------------------:|-----------------:|-------:|----------:|
| **&#39;GetAllMessages: Separator&#39;**  | ****NEW****    | **160.12 ns** | **0.696 ns** | **0.617 ns** | **0.165 ns** | **159.18 ns** | **159.63 ns** | **160.23 ns** | **160.51 ns** | **161.23 ns** |  **6,245,186.6** |       **6.918 ns** |      **14.00** |    **1.769** |  **2.000** |   **0.0681** |    **2** | *****            | **No**       |          **-** |     **809 B** |                    **-** |                **-** | **0.0029** |     **280 B** |
| **GetAllMessages**               | ****           | **158.37 ns** | **0.897 ns** | **0.839 ns** | **0.217 ns** | **156.62 ns** | **157.79 ns** | **158.56 ns** | **159.00 ns** | **159.68 ns** |  **6,314,176.7** |       **7.392 ns** |      **15.00** |    **2.179** |  **2.000** |  **-0.5001** |    **2** | *****            | **No**       |          **-** |     **809 B** |                    **-** |                **-** | **0.0029** |     **280 B** |
| **GetAllMessagesWithStackTrace** | ****           |  **66.74 ns** | **0.429 ns** | **0.402 ns** | **0.104 ns** |  **65.96 ns** |  **66.52 ns** |  **66.76 ns** |  **67.04 ns** |  **67.38 ns** | **14,984,608.1** |       **7.448 ns** |      **15.00** |    **2.040** |  **2.000** |  **-0.2851** |    **1** | *****            | **No**       |          **-** |        **NA** |                    **-** |                **-** | **0.0024** |     **224 B** |
