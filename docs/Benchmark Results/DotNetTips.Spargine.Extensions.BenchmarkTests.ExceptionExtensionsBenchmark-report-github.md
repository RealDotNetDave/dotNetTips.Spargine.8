```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5608/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.201
  [Host]     : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  Job-QFNFJQ : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

```
| Method                       | Categories | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Code Size | Gen0   | Completed Work Items | Lock Contentions | Allocated |
|----------------------------- |----------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|----------:|-------:|---------------------:|-----------------:|----------:|
| **&#39;GetAllMessages: Separator&#39;**  | ****NEW****    | **161.44 ns** | **0.608 ns** | **0.539 ns** | **0.144 ns** | **160.58 ns** | **161.25 ns** | **161.39 ns** | **161.59 ns** | **162.57 ns** |  **6,194,208.2** |       **6.928 ns** |      **14.00** |    **2.447** |  **2.000** |   **0.3101** |    **3** | *****            | **No**       |          **-** |     **809 B** | **0.0029** |                    **-** |                **-** |     **280 B** |
| **GetAllMessages**               | ****           | **155.11 ns** | **0.682 ns** | **0.638 ns** | **0.165 ns** | **154.18 ns** | **154.75 ns** | **154.89 ns** | **155.53 ns** | **156.47 ns** |  **6,447,030.3** |       **7.418 ns** |      **15.00** |    **2.268** |  **2.000** |   **0.3946** |    **2** | *****            | **No**       |          **-** |     **809 B** | **0.0029** |                    **-** |                **-** |     **280 B** |
| **GetAllMessagesWithStackTrace** | ****           |  **68.04 ns** | **0.305 ns** | **0.286 ns** | **0.074 ns** |  **67.58 ns** |  **67.78 ns** |  **68.11 ns** |  **68.14 ns** |  **68.67 ns** | **14,697,858.1** |       **7.463 ns** |      **15.00** |    **2.482** |  **2.000** |   **0.2314** |    **1** | *****            | **No**       |          **-** |        **NA** | **0.0024** |                    **-** |                **-** |     **224 B** |
