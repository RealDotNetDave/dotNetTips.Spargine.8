```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5737/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.203
  [Host]     : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  Job-FORZLD : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  Categories=**NEW**  

```
| Method                     | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Completed Work Items | Lock Contentions | Exceptions | Gen0   | Allocated |
|--------------------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|---------------------:|-----------------:|-----------:|-------:|----------:|
| **&#39;GenerateKey: With Prefix&#39;** | **104.91 ns** | **0.542 ns** | **0.507 ns** | **0.131 ns** | **103.96 ns** | **104.51 ns** | **105.00 ns** | **105.21 ns** | **105.78 ns** |  **9,531,800.0** |       **7.435 ns** |      **15.00** |    **1.920** |  **2.000** |  **-0.1502** |    **2** | *****            | **No**       |     **304 B** |                    **-** |                **-** |          **-** | **0.0019** |     **184 B** |
| **GenerateKey**                |  **86.37 ns** | **0.401 ns** | **0.356 ns** | **0.095 ns** |  **85.74 ns** |  **86.17 ns** |  **86.41 ns** |  **86.52 ns** |  **87.10 ns** | **11,577,559.2** |       **6.952 ns** |      **14.00** |    **2.384** |  **2.000** |   **0.0969** |    **1** | *****            | **No**       |     **123 B** |                    **-** |                **-** |          **-** | **0.0010** |      **88 B** |
