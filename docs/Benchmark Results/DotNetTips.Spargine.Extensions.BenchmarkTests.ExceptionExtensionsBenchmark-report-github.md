```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5737/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.203
  [Host]     : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  Job-BJZEEE : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

```
| Method                       | Categories | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Exceptions | Gen0   | Completed Work Items | Lock Contentions | Allocated |
|----------------------------- |----------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-----------:|-------:|---------------------:|-----------------:|----------:|
| **&#39;GetAllMessages: Separator&#39;**  | ****NEW****    | **155.81 ns** | **0.723 ns** | **0.641 ns** | **0.171 ns** | **154.78 ns** | **155.44 ns** | **155.70 ns** | **156.17 ns** | **156.94 ns** |  **6,418,124.3** |       **6.914 ns** |      **14.00** |    **1.978** |  **2.000** |   **0.2587** |    **2** | *****            | **No**       |     **809 B** |          **-** | **0.0029** |                    **-** |                **-** |     **280 B** |
| **GetAllMessages**               | ****           | **160.23 ns** | **0.941 ns** | **0.835 ns** | **0.223 ns** | **158.39 ns** | **159.75 ns** | **160.29 ns** | **160.68 ns** | **161.83 ns** |  **6,240,907.5** |       **6.888 ns** |      **14.00** |    **2.895** |  **2.000** |  **-0.2251** |    **2** | *****            | **No**       |     **809 B** |          **-** | **0.0029** |                    **-** |                **-** |     **280 B** |
| **GetAllMessagesWithStackTrace** | ****           |  **68.85 ns** | **0.341 ns** | **0.319 ns** | **0.082 ns** |  **68.03 ns** |  **68.65 ns** |  **68.94 ns** |  **69.06 ns** |  **69.25 ns** | **14,524,167.8** |       **7.459 ns** |      **15.00** |    **3.349** |  **2.000** |  **-0.9436** |    **1** | *****            | **No**       |        **NA** |          **-** | **0.0024** |                    **-** |                **-** |     **224 B** |
