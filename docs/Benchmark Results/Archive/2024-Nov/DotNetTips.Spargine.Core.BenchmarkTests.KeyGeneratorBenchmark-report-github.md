```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5011/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.403
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  Job-BXAHQI : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  Categories=**NEW**  

```
| Method                     | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Code Size | Gen0   | Allocated |
|--------------------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|----------:|-------:|----------:|
| **&#39;GenerateKey: With Prefix&#39;** | **105.65 ns** | **0.592 ns** | **0.554 ns** | **0.143 ns** | **104.96 ns** | **105.27 ns** | **105.43 ns** | **106.01 ns** | **106.91 ns** |  **9,465,018.1** |       **7.428 ns** |      **15.00** |    **2.360** |  **2.000** |   **0.6130** |    **2** | *****            | **No**       |          **-** |                    **-** |                **-** |     **304 B** | **0.0019** |     **184 B** |
| **GenerateKey**                |  **86.30 ns** | **0.617 ns** | **0.577 ns** | **0.149 ns** |  **85.12 ns** |  **86.10 ns** |  **86.36 ns** |  **86.66 ns** |  **87.46 ns** | **11,588,037.5** |       **7.425 ns** |      **15.00** |    **2.862** |  **2.000** |  **-0.2778** |    **1** | *****            | **No**       |          **-** |                    **-** |                **-** |     **123 B** | **0.0010** |      **88 B** |
