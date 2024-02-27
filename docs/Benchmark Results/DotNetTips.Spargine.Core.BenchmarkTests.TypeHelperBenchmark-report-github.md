```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  Job-VVETEA : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

```
| Method                                     | Categories | Mean         | Error       | StdDev      | StdErr    | Min          | Q1           | Median       | Q3           | Max          | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Exceptions | Code Size | Completed Work Items | Lock Contentions | Allocated |
|------------------------------------------- |----------- |-------------:|------------:|------------:|----------:|-------------:|-------------:|-------------:|-------------:|-------------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|-----------:|----------:|---------------------:|-----------------:|----------:|
| **&#39;Looping Collection: Normal StringBuilder&#39;** | **Strings**    |   **3,930.6 ns** |    **20.21 ns** |    **17.92 ns** |   **4.79 ns** |   **3,900.7 ns** |   **3,915.7 ns** |   **3,934.3 ns** |   **3,938.1 ns** |   **3,960.1 ns** | **254,415.2** |       **20.21 ns** |      **14.00** |    **1.881** |  **2.000** |  **-0.0222** |    **1** | *****            | **No**       | **0.1602** |          **-** |   **2,613 B** |                    **-** |                **-** |  **14.75 KB** |
| **GetPropertyValues**                          | **Reflection** | **398,225.9 ns** | **1,660.97 ns** | **1,472.41 ns** | **393.52 ns** | **395,908.9 ns** | **397,376.0 ns** | **398,025.6 ns** | **399,500.6 ns** | **400,608.3 ns** |   **2,511.1** |    **1,660.97 ns** |      **14.00** |    **1.614** |  **2.000** |   **0.0590** |    **2** | *****            | **No**       |      **-** |          **-** |   **4,148 B** |                    **-** |                **-** |   **6.67 KB** |
