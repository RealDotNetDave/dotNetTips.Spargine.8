```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4291/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.300-preview.24203.14
  [Host]     : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  Job-XJVIUY : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Reflection  

```
| Method           | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s        | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Gen0   | Code Size | Allocated |
|----------------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|-------:|----------:|----------:|
| **GetAllInterfaces** | **2,386.3 ns** | **12.84 ns** | **12.01 ns** | **3.10 ns** | **2,368.0 ns** | **2,376.3 ns** | **2,387.1 ns** | **2,398.2 ns** | **2,404.1 ns** |   **419,054.4** |      **12.842 ns** |      **15.00** |    **1.399** |  **2.000** |   **0.0106** |    **3** | *****            | **No**       |          **-** |                    **-** |                **-** | **0.0114** |     **889 B** |    **1080 B** |
| **GetAllTypes**      | **2,100.7 ns** | **13.30 ns** | **11.11 ns** | **3.08 ns** | **2,080.5 ns** | **2,091.5 ns** | **2,101.6 ns** | **2,105.2 ns** | **2,124.7 ns** |   **476,029.0** |      **13.303 ns** |      **13.00** |    **2.756** |  **2.000** |   **0.2181** |    **2** | *****            | **No**       |          **-** |                    **-** |                **-** | **0.0153** |   **1,009 B** |    **1592 B** |
| **GetInstances**     |   **578.8 ns** |  **1.95 ns** |  **1.83 ns** | **0.47 ns** |   **574.6 ns** |   **577.6 ns** |   **579.2 ns** |   **579.8 ns** |   **581.6 ns** | **1,727,579.9** |       **1.951 ns** |      **15.00** |    **2.649** |  **2.000** |  **-0.5649** |    **1** | *****            | **No**       |          **-** |                    **-** |                **-** |      **-** |     **137 B** |      **56 B** |
