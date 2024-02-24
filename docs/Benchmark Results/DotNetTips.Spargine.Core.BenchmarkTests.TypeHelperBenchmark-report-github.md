```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  Job-YSGQDR : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

```
| Method                                     | Categories | Mean         | Error       | StdDev      | StdErr    | Min          | Q1           | Median       | Q3           | Max          | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Completed Work Items | Lock Contentions | Gen0   | Exceptions | Code Size | Allocated |
|------------------------------------------- |----------- |-------------:|------------:|------------:|----------:|-------------:|-------------:|-------------:|-------------:|-------------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |---------------------:|-----------------:|-------:|-----------:|----------:|----------:|
| **&#39;Looping Collection: Normal StringBuilder&#39;** | **Strings**    |   **4,034.8 ns** |    **19.64 ns** |    **18.37 ns** |   **4.74 ns** |   **4,004.6 ns** |   **4,021.6 ns** |   **4,039.2 ns** |   **4,049.1 ns** |   **4,065.5 ns** | **247,845.7** |       **19.64 ns** |      **15.00** |    **1.610** |  **2.000** |  **-0.0551** |    **1** | *****            | **No**       |                    **-** |                **-** | **0.1602** |          **-** |   **2,614 B** |  **14.68 KB** |
| **GetPropertyValues**                          | **Reflection** | **372,656.7 ns** | **1,452.55 ns** | **1,287.65 ns** | **344.14 ns** | **370,239.3 ns** | **371,968.7 ns** | **372,804.6 ns** | **373,092.2 ns** | **375,157.4 ns** |   **2,683.4** |    **1,452.55 ns** |      **14.00** |    **2.494** |  **2.000** |   **0.2161** |    **2** | *****            | **No**       |                    **-** |                **-** |      **-** |          **-** |   **4,065 B** |   **6.69 KB** |
