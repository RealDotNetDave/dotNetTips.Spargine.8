```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5011/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.403
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  Job-QYBNOF : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

```
| Method         | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Code Size | Completed Work Items | Lock Contentions | Gen0   | Allocated |
|--------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|----------:|---------------------:|-----------------:|-------:|----------:|
| **GetDescription** |  **41.04 ns** | **0.798 ns** | **0.666 ns** | **0.185 ns** |  **39.49 ns** |  **41.20 ns** |  **41.26 ns** |  **41.36 ns** |  **41.57 ns** | **24,365,589.4** |       **6.408 ns** |      **13.00** |    **3.848** |  **2.000** |  **-1.6096** |    **1** | *****            | **No**       |          **-** |     **750 B** |                    **-** |                **-** | **0.0002** |      **24 B** |
| **GetItems**       | **968.64 ns** | **7.579 ns** | **7.089 ns** | **1.830 ns** | **961.17 ns** | **962.88 ns** | **967.84 ns** | **971.48 ns** | **983.24 ns** |  **1,032,374.2** |       **6.585 ns** |      **15.00** |    **2.423** |  **2.000** |   **0.8359** |    **2** | *****            | **No**       |          **-** |     **462 B** |                    **-** |                **-** | **0.0095** |     **896 B** |
