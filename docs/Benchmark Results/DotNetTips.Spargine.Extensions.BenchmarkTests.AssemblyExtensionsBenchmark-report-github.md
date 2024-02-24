```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  Job-ISWGDN : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Reflection  

```
| Method           | Mean       | Error   | StdDev  | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s        | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Gen0   | Exceptions | Completed Work Items | Lock Contentions | Allocated |
|----------------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-------:|-----------:|---------------------:|-----------------:|----------:|
| **GetAllInterfaces** | **2,399.3 ns** | **7.86 ns** | **7.35 ns** | **1.90 ns** | **2,387.7 ns** | **2,394.7 ns** | **2,398.6 ns** | **2,404.5 ns** | **2,414.5 ns** |   **416,787.0** |       **7.858 ns** |      **15.00** |    **2.141** |  **2.000** |   **0.2174** |    **3** | *****            | **No**       |     **877 B** | **0.0114** |          **-** |                    **-** |                **-** |    **1080 B** |
| **GetAllTypes**      | **2,157.2 ns** | **8.37 ns** | **7.83 ns** | **2.02 ns** | **2,140.1 ns** | **2,153.2 ns** | **2,157.4 ns** | **2,162.2 ns** | **2,172.5 ns** |   **463,557.2** |       **8.367 ns** |      **15.00** |    **2.796** |  **2.000** |  **-0.2672** |    **2** | *****            | **No**       |   **1,009 B** | **0.0153** |          **-** |                    **-** |                **-** |    **1592 B** |
| **GetInstances**     |   **591.0 ns** | **4.32 ns** | **4.05 ns** | **1.04 ns** |   **583.0 ns** |   **590.3 ns** |   **591.9 ns** |   **593.7 ns** |   **595.6 ns** | **1,691,967.7** |       **4.324 ns** |      **15.00** |    **2.469** |  **2.000** |  **-0.9738** |    **1** | *****            | **No**       |     **137 B** |      **-** |          **-** |                    **-** |                **-** |      **56 B** |
