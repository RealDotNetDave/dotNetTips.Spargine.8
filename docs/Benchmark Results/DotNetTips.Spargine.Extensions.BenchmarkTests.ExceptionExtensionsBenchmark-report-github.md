```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5371/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  Job-AVPYBY : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

```
| Method                       | Mean     | Error    | StdDev   | StdErr   | Min      | Q1       | Median   | Q3       | Max      | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Gen0   | Code Size | Allocated |
|----------------------------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|-------:|----------:|----------:|
| **GetAllMessages**               | **77.34 ns** | **0.359 ns** | **0.318 ns** | **0.085 ns** | **76.88 ns** | **77.18 ns** | **77.29 ns** | **77.54 ns** | **78.00 ns** | **12,930,033.3** |       **6.957 ns** |      **14.00** |    **2.250** |  **2.000** |   **0.3974** |    **2** | *****            | **No**       |          **-** |                    **-** |                **-** | **0.0014** |     **854 B** |     **136 B** |
| **GetAllMessagesWithStackTrace** | **66.47 ns** | **0.415 ns** | **0.368 ns** | **0.098 ns** | **65.66 ns** | **66.29 ns** | **66.43 ns** | **66.60 ns** | **67.04 ns** | **15,045,490.4** |       **6.951 ns** |      **14.00** |    **2.639** |  **2.000** |  **-0.2587** |    **1** | *****            | **No**       |          **-** |                    **-** |                **-** | **0.0024** |   **2,847 B** |     **224 B** |
