```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  Job-QMVMBA : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

```
| Method         | Mean     | Error    | StdDev   | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Completed Work Items | Lock Contentions | Exceptions | Code Size | Allocated |
|--------------- |---------:|---------:|---------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|---------------------:|-----------------:|-----------:|----------:|----------:|
| **GetDescription** | **149.8 ns** |  **1.53 ns** |  **1.19 ns** | **0.34 ns** | **147.6 ns** | **149.1 ns** | **150.4 ns** | **150.5 ns** | **151.1 ns** | **6,674,529.5** |       **1.529 ns** |      **12.00** |    **1.875** |  **2.000** |  **-0.7250** |    **1** | *****            | **No**       | **0.0002** |                    **-** |                **-** |          **-** |     **605 B** |      **24 B** |
| **GetItems**       | **757.2 ns** | **13.07 ns** | **15.56 ns** | **3.39 ns** | **736.5 ns** | **743.8 ns** | **755.5 ns** | **767.2 ns** | **796.2 ns** | **1,320,656.4** |      **13.069 ns** |      **21.00** |    **2.677** |  **2.000** |   **0.5780** |    **2** | *****            | **No**       | **0.0057** |                    **-** |                **-** |          **-** |     **639 B** |     **536 B** |
