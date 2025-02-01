```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5371/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  Job-FLPXNP : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  Categories=**NEW**  

```
| Method                     | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Gen0   | Code Size | Allocated |
|--------------------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|-------:|----------:|----------:|
| **&#39;GenerateKey: With Prefix&#39;** | **103.35 ns** | **0.375 ns** | **0.313 ns** | **0.087 ns** | **102.82 ns** | **103.04 ns** | **103.35 ns** | **103.59 ns** | **103.91 ns** |  **9,675,819.1** |       **6.457 ns** |      **13.00** |    **1.871** |  **2.000** |  **-0.0102** |    **2** | *****            | **No**       |          **-** |                    **-** |                **-** | **0.0019** |     **314 B** |     **184 B** |
| **GenerateKey**                |  **86.16 ns** | **0.858 ns** | **0.802 ns** | **0.207 ns** |  **85.07 ns** |  **85.60 ns** |  **86.07 ns** |  **86.73 ns** |  **87.63 ns** | **11,605,681.7** |       **7.396 ns** |      **15.00** |    **1.848** |  **2.000** |   **0.3566** |    **1** | *****            | **No**       |          **-** |                    **-** |                **-** | **0.0010** |     **123 B** |      **88 B** |
