```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5608/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.201
  [Host]     : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  Job-CIJPPL : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  Categories=**NEW**  

```
| Method                     | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Code Size | Gen0   | Allocated |
|--------------------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|----------:|-------:|----------:|
| **&#39;GenerateKey: With Prefix&#39;** | **105.71 ns** | **0.619 ns** | **0.579 ns** | **0.150 ns** | **104.55 ns** | **105.40 ns** | **105.76 ns** | **106.05 ns** | **106.95 ns** |  **9,459,589.8** |       **7.425 ns** |      **15.00** |    **2.728** |  **2.000** |   **0.0544** |    **2** | *****            | **No**       |          **-** |                    **-** |                **-** |     **304 B** | **0.0019** |     **184 B** |
| **GenerateKey**                |  **87.43 ns** | **0.720 ns** | **0.673 ns** | **0.174 ns** |  **86.28 ns** |  **86.81 ns** |  **87.73 ns** |  **87.97 ns** |  **88.17 ns** | **11,437,159.8** |       **7.413 ns** |      **15.00** |    **1.544** |  **2.000** |  **-0.5215** |    **1** | *****            | **No**       |          **-** |                    **-** |                **-** |     **123 B** | **0.0010** |      **88 B** |
