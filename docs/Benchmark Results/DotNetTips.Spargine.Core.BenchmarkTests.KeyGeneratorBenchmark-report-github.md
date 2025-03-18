```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5608/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.201
  [Host]     : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  Job-HFQNPD : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  Categories=**NEW**  

```
| Method                     | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Code Size | Gen0   | Allocated |
|--------------------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|----------:|-------:|----------:|
| **&#39;GenerateKey: With Prefix&#39;** | **104.71 ns** | **0.420 ns** | **0.373 ns** | **0.100 ns** | **104.20 ns** | **104.47 ns** | **104.68 ns** | **104.88 ns** | **105.43 ns** |  **9,550,445.6** |       **6.950 ns** |      **14.00** |    **1.982** |  **2.000** |   **0.3376** |    **2** | *****            | **No**       |          **-** |                    **-** |                **-** |     **304 B** | **0.0019** |     **184 B** |
| **GenerateKey**                |  **86.42 ns** | **0.595 ns** | **0.557 ns** | **0.144 ns** |  **85.50 ns** |  **86.09 ns** |  **86.63 ns** |  **86.72 ns** |  **87.48 ns** | **11,571,634.9** |       **7.428 ns** |      **15.00** |    **2.127** |  **2.000** |  **-0.2027** |    **1** | *****            | **No**       |          **-** |                    **-** |                **-** |     **123 B** | **0.0010** |      **88 B** |
