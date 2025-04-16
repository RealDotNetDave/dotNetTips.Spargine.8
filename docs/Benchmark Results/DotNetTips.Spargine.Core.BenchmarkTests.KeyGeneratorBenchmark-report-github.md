```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5737/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.203
  [Host]     : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  Job-JJEKCF : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  Categories=**NEW**  

```
| Method                     | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Completed Work Items | Lock Contentions | Exceptions | Gen0   | Allocated |
|--------------------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|---------------------:|-----------------:|-----------:|-------:|----------:|
| **&#39;GenerateKey: With Prefix&#39;** | **105.12 ns** | **0.411 ns** | **0.384 ns** | **0.099 ns** | **104.65 ns** | **104.79 ns** | **105.20 ns** | **105.30 ns** | **105.97 ns** |  **9,512,670.1** |       **7.450 ns** |      **15.00** |    **2.367** |  **2.000** |   **0.5275** |    **2** | *****            | **No**       |     **304 B** |                    **-** |                **-** |          **-** | **0.0019** |     **184 B** |
| **GenerateKey**                |  **86.75 ns** | **0.710 ns** | **0.664 ns** | **0.171 ns** |  **85.87 ns** |  **86.29 ns** |  **86.53 ns** |  **87.17 ns** |  **87.80 ns** | **11,527,291.8** |       **7.414 ns** |      **15.00** |    **1.613** |  **2.000** |   **0.3438** |    **1** | *****            | **No**       |     **123 B** |                    **-** |                **-** |          **-** | **0.0010** |      **88 B** |
