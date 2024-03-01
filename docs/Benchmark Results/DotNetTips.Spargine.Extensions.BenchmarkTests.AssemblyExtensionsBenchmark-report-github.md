```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  Job-LNCZTW : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Reflection  

```
| Method           | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s        | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Gen0   | Completed Work Items | Lock Contentions | Exceptions | Allocated |
|----------------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-------:|---------------------:|-----------------:|-----------:|----------:|
| **GetAllInterfaces** | **2,631.7 ns** | **11.94 ns** | **10.59 ns** | **2.83 ns** | **2,611.3 ns** | **2,627.7 ns** | **2,629.9 ns** | **2,635.2 ns** | **2,655.0 ns** |   **379,979.0** |      **11.942 ns** |      **14.00** |    **3.010** |  **2.000** |   **0.3926** |    **3** | *****            | **No**       |     **572 B** | **0.0114** |                    **-** |                **-** |          **-** |    **1080 B** |
| **GetAllTypes**      | **2,290.2 ns** | **16.27 ns** | **15.22 ns** | **3.93 ns** | **2,266.8 ns** | **2,275.1 ns** | **2,293.4 ns** | **2,301.2 ns** | **2,315.6 ns** |   **436,641.2** |      **16.275 ns** |      **15.00** |    **1.511** |  **2.000** |  **-0.1542** |    **2** | *****            | **No**       |     **658 B** | **0.0153** |                    **-** |                **-** |          **-** |    **1592 B** |
| **GetInstances**     |   **610.3 ns** |  **3.39 ns** |  **3.17 ns** | **0.82 ns** |   **603.4 ns** |   **609.2 ns** |   **610.8 ns** |   **612.2 ns** |   **615.4 ns** | **1,638,636.3** |       **3.387 ns** |      **15.00** |    **2.843** |  **2.000** |  **-0.7278** |    **1** | *****            | **No**       |     **390 B** |      **-** |                    **-** |                **-** |          **-** |      **80 B** |
