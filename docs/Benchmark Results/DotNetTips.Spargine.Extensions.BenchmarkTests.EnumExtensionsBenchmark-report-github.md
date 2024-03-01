```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  Job-LNCZTW : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

```
| Method         | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Completed Work Items | Lock Contentions | Exceptions | Code Size | Allocated |
|--------------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|---------------------:|-----------------:|-----------:|----------:|----------:|
| **GetDescription** | **151.2 ns** | **0.26 ns** | **0.23 ns** | **0.06 ns** | **150.9 ns** | **151.1 ns** | **151.2 ns** | **151.4 ns** | **151.7 ns** | **6,612,699.5** |      **0.2581 ns** |      **14.00** |    **1.844** |  **2.000** |   **0.4137** |    **1** | *****            | **No**       | **0.0002** |                    **-** |                **-** |          **-** |     **605 B** |      **24 B** |
| **GetItems**       | **728.0 ns** | **6.45 ns** | **5.71 ns** | **1.53 ns** | **711.5 ns** | **727.9 ns** | **729.0 ns** | **730.7 ns** | **734.8 ns** | **1,373,543.6** |      **6.4468 ns** |      **14.00** |    **5.374** |  **2.000** |  **-1.6853** |    **2** | *****            | **No**       | **0.0057** |                    **-** |                **-** |          **-** |     **639 B** |     **536 B** |
