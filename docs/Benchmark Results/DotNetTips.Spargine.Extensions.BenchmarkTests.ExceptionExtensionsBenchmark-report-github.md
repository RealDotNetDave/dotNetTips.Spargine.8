```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5737/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.203
  [Host]     : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  Job-WAULDK : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

```
| Method                       | Categories | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Exceptions | Gen0   | Completed Work Items | Lock Contentions | Allocated |
|----------------------------- |----------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-----------:|-------:|---------------------:|-----------------:|----------:|
| **&#39;GetAllMessages: Separator&#39;**  | ****NEW****    | **162.53 ns** | **0.812 ns** | **0.760 ns** | **0.196 ns** | **161.18 ns** | **162.23 ns** | **162.48 ns** | **162.90 ns** | **163.71 ns** |  **6,152,818.0** |       **7.402 ns** |      **15.00** |    **2.123** |  **2.000** |  **-0.1153** |    **3** | *****            | **No**       |     **809 B** |          **-** | **0.0029** |                    **-** |                **-** |     **280 B** |
| **GetAllMessages**               | ****           | **157.13 ns** | **1.214 ns** | **1.136 ns** | **0.293 ns** | **155.76 ns** | **156.32 ns** | **156.73 ns** | **157.91 ns** | **159.67 ns** |  **6,364,207.0** |       **7.353 ns** |      **15.00** |    **2.446** |  **2.000** |   **0.8155** |    **2** | *****            | **No**       |     **809 B** |          **-** | **0.0029** |                    **-** |                **-** |     **280 B** |
| **GetAllMessagesWithStackTrace** | ****           |  **69.31 ns** | **0.180 ns** | **0.160 ns** | **0.043 ns** |  **68.97 ns** |  **69.26 ns** |  **69.31 ns** |  **69.38 ns** |  **69.59 ns** | **14,427,424.3** |       **6.979 ns** |      **14.00** |    **2.719** |  **2.000** |  **-0.3955** |    **1** | *****            | **No**       |        **NA** |          **-** | **0.0024** |                    **-** |                **-** |     **224 B** |
