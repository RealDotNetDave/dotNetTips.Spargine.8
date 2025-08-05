```

BenchmarkDotNet v0.15.2, Windows 10 (10.0.19045.6093/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.302
  [Host]     : .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
  Job-ZSLFFS : .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  Categories=**NEW**  

```
| Method                     | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Exceptions | Code Size | Completed Work Items | Lock Contentions | Allocated |
|--------------------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|-----------:|----------:|---------------------:|-----------------:|----------:|
| **&#39;GenerateKey: With Prefix&#39;** | **107.97 ns** | **0.346 ns** | **0.324 ns** | **0.084 ns** | **107.53 ns** | **107.72 ns** | **107.93 ns** | **108.17 ns** | **108.65 ns** |  **9,261,568.6** |       **7.458 ns** |      **15.00** |    **2.090** |  **2.000** |   **0.5315** |    **2** | *****            | **No**       | **0.0019** |          **-** |     **304 B** |                    **-** |                **-** |     **184 B** |
| **GenerateKey**                |  **90.64 ns** | **0.512 ns** | **0.478 ns** | **0.124 ns** |  **89.69 ns** |  **90.30 ns** |  **90.63 ns** |  **90.88 ns** |  **91.38 ns** | **11,033,174.9** |       **7.438 ns** |      **15.00** |    **2.129** |  **2.000** |  **-0.0669** |    **1** | *****            | **No**       | **0.0010** |          **-** |     **123 B** |                    **-** |                **-** |      **88 B** |
