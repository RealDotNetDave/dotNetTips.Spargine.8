```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  Job-TLMPGC : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

```
| Method         | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Gen0   | Code Size | Allocated |
|--------------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|-------:|----------:|----------:|
| **GetDescription** | **128.9 ns** | **0.93 ns** | **0.87 ns** | **0.22 ns** | **128.1 ns** | **128.4 ns** | **128.5 ns** | **129.6 ns** | **130.6 ns** | **7,755,772.2** |      **0.9251 ns** |      **15.00** |    **1.869** |  **2.000** |   **0.8163** |    **1** | *****            | **No**       |          **-** |                    **-** |                **-** | **0.0002** |     **880 B** |      **24 B** |
| **GetItems**       | **650.9 ns** | **3.17 ns** | **2.97 ns** | **0.77 ns** | **644.0 ns** | **648.9 ns** | **651.3 ns** | **652.5 ns** | **655.4 ns** | **1,536,307.2** |      **3.1732 ns** |      **15.00** |    **2.710** |  **2.000** |  **-0.4805** |    **2** | *****            | **No**       |          **-** |                    **-** |                **-** | **0.0057** |     **641 B** |     **536 B** |
