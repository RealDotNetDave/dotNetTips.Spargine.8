```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5608/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.201
  [Host]     : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  Job-QFNFJQ : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

```
| Method         | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max         | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Code Size | Completed Work Items | Lock Contentions | Gen0   | Allocated |
|--------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|------------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|----------:|---------------------:|-----------------:|-------:|----------:|
| **GetDescription** |  **37.59 ns** | **0.205 ns** | **0.192 ns** | **0.050 ns** |  **37.14 ns** |  **37.50 ns** |  **37.60 ns** |  **37.68 ns** |    **37.91 ns** | **26,605,071.6** |       **7.475 ns** |      **15.00** |    **2.874** |  **2.000** |  **-0.3580** |    **1** | *****            | **No**       |          **-** |     **750 B** |                    **-** |                **-** | **0.0002** |      **24 B** |
| **GetItems**       | **989.01 ns** | **7.638 ns** | **6.771 ns** | **1.810 ns** | **978.20 ns** | **986.00 ns** | **987.68 ns** | **992.88 ns** | **1,001.05 ns** |  **1,011,113.4** |       **6.095 ns** |      **14.00** |    **2.199** |  **2.000** |   **0.2007** |    **2** | *****            | **No**       |          **-** |        **NA** |                    **-** |                **-** | **0.0095** |     **896 B** |
