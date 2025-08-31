```

BenchmarkDotNet v0.15.2, Windows 10 (10.0.19045.6216/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.304
  [Host]     : .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
  Job-ZSLFFS : .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  Categories=**NEW**  

```
| Method                     | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Completed Work Items | Lock Contentions | Code Size | Exceptions | Allocated |
|--------------------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|---------------------:|-----------------:|----------:|-----------:|----------:|
| **&#39;GenerateKey: With Prefix&#39;** | **107.92 ns** | **0.469 ns** | **0.438 ns** | **0.113 ns** | **106.99 ns** | **107.61 ns** | **107.93 ns** | **108.27 ns** | **108.61 ns** |  **9,266,220.9** |       **7.443 ns** |      **15.00** |    **2.174** |  **2.000** |  **-0.3210** |    **2** | *****            | **No**       | **0.0019** |                    **-** |                **-** |     **304 B** |          **-** |     **184 B** |
| **GenerateKey**                |  **90.66 ns** | **0.580 ns** | **0.542 ns** | **0.140 ns** |  **89.88 ns** |  **90.26 ns** |  **90.71 ns** |  **91.06 ns** |  **91.56 ns** | **11,030,640.6** |       **7.430 ns** |      **15.00** |    **1.640** |  **2.000** |  **-0.0165** |    **1** | *****            | **No**       | **0.0010** |                    **-** |                **-** |     **123 B** |          **-** |      **88 B** |
