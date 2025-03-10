```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5487/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.200
  [Host]     : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  Job-THQNBF : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  Categories=**NEW**  

```
| Method                     | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Completed Work Items | Lock Contentions | Gen0   | Code Size | Exceptions | Allocated |
|--------------------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |---------------------:|-----------------:|-------:|----------:|-----------:|----------:|
| **&#39;GenerateKey: With Prefix&#39;** | **108.92 ns** | **0.492 ns** | **0.460 ns** | **0.119 ns** | **108.29 ns** | **108.63 ns** | **108.92 ns** | **109.15 ns** | **109.86 ns** |  **9,181,270.1** |       **7.441 ns** |      **15.00** |    **2.101** |  **2.000** |   **0.3648** |    **2** | *****            | **No**       |                    **-** |                **-** | **0.0019** |     **314 B** |          **-** |     **184 B** |
| **GenerateKey**                |  **86.37 ns** | **0.543 ns** | **0.453 ns** | **0.126 ns** |  **85.63 ns** |  **86.20 ns** |  **86.30 ns** |  **86.57 ns** |  **87.24 ns** | **11,577,531.8** |       **6.437 ns** |      **13.00** |    **2.153** |  **2.000** |   **0.2409** |    **1** | *****            | **No**       |                    **-** |                **-** | **0.0010** |     **123 B** |          **-** |      **88 B** |
