```

BenchmarkDotNet v0.15.2, Windows 10 (10.0.19045.6691/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.308
  [Host]     : .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
  Job-ZSLFFS : .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  Categories=**NEW**  

```
| Method                     | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Exceptions | Code Size | Completed Work Items | Lock Contentions | Allocated |
|--------------------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|-----------:|----------:|---------------------:|-----------------:|----------:|
| **&#39;GenerateKey: With Prefix&#39;** | **104.78 ns** | **0.629 ns** | **0.558 ns** | **0.149 ns** | **103.51 ns** | **104.50 ns** | **104.85 ns** | **105.11 ns** | **105.66 ns** |  **9,544,051.0** |       **6.925 ns** |      **14.00** |    **2.734** |  **2.000** |  **-0.4810** |    **2** | *****            | **No**       | **0.0019** |          **-** |     **304 B** |                    **-** |                **-** |     **184 B** |
| **GenerateKey**                |  **86.64 ns** | **0.635 ns** | **0.530 ns** | **0.147 ns** |  **85.79 ns** |  **86.40 ns** |  **86.62 ns** |  **86.79 ns** |  **87.75 ns** | **11,542,577.5** |       **6.427 ns** |      **13.00** |    **2.659** |  **2.000** |   **0.3112** |    **1** | *****            | **No**       | **0.0010** |          **-** |     **123 B** |                    **-** |                **-** |      **88 B** |
