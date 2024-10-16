```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4291/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.300-preview.24203.14
  [Host]     : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  Job-NYUPWT : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

```
| Method                                     | Categories | Mean         | Error       | StdDev      | StdErr      | Min          | Q1           | Median       | Q3           | Max          | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Code Size | Completed Work Items | Lock Contentions | Exceptions | Allocated |
|------------------------------------------- |----------- |-------------:|------------:|------------:|------------:|-------------:|-------------:|-------------:|-------------:|-------------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|----------:|---------------------:|-----------------:|-----------:|----------:|
| **&#39;Looping Collection: Normal StringBuilder&#39;** | **Strings**    |   **4,000.6 ns** |    **24.51 ns** |    **21.73 ns** |     **5.81 ns** |   **3,950.2 ns** |   **3,993.2 ns** |   **4,005.2 ns** |   **4,012.6 ns** |   **4,028.3 ns** | **249,961.1** |       **24.51 ns** |      **14.00** |    **2.751** |  **2.000** |  **-0.7612** |    **1** | *****            | **No**       | **0.1602** |   **2,613 B** |                    **-** |                **-** |          **-** |  **14.84 KB** |
| **GetPropertyValues**                          | **Reflection** | **398,927.7 ns** | **7,705.76 ns** | **8,564.93 ns** | **1,964.93 ns** | **391,283.4 ns** | **393,326.0 ns** | **394,139.1 ns** | **404,904.2 ns** | **413,300.1 ns** |   **2,506.7** |    **7,705.76 ns** |      **19.00** |    **1.879** |  **2.714** |   **0.9029** |    **2** | *****            | **No**       |      **-** |   **4,076 B** |                    **-** |                **-** |          **-** |   **6.39 KB** |
