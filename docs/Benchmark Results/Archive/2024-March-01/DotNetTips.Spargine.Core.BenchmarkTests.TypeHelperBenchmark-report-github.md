```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  Job-WWXGEI : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

```
| Method                                     | Categories | Mean         | Error       | StdDev      | StdErr    | Min          | Q1           | Median       | Q3           | Max          | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Exceptions | Code Size | Completed Work Items | Lock Contentions | Allocated |
|------------------------------------------- |----------- |-------------:|------------:|------------:|----------:|-------------:|-------------:|-------------:|-------------:|-------------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|-----------:|----------:|---------------------:|-----------------:|----------:|
| **&#39;Looping Collection: Normal StringBuilder&#39;** | **Strings**    |   **4,230.6 ns** |    **28.23 ns** |    **26.41 ns** |   **6.82 ns** |   **4,194.8 ns** |   **4,206.7 ns** |   **4,232.1 ns** |   **4,249.5 ns** |   **4,275.4 ns** | **236,375.8** |       **28.23 ns** |      **15.00** |    **1.638** |  **2.000** |   **0.3099** |    **1** | *****            | **No**       | **0.1602** |          **-** |   **3,038 B** |                    **-** |                **-** |  **14.83 KB** |
| **GetPropertyValues**                          | **Reflection** | **438,622.4 ns** | **1,460.82 ns** | **1,366.45 ns** | **352.82 ns** | **435,296.0 ns** | **438,041.3 ns** | **438,640.2 ns** | **439,513.1 ns** | **440,888.5 ns** |   **2,279.9** |    **1,460.82 ns** |      **15.00** |    **3.139** |  **2.000** |  **-0.5967** |    **2** | *****            | **No**       |      **-** |          **-** |   **3,050 B** |                    **-** |                **-** |    **6.7 KB** |
