```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5371/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  Job-AVPYBY : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

```
| Method         | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Code Size | Gen0   | Completed Work Items | Lock Contentions | Allocated |
|--------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|----------:|-------:|---------------------:|-----------------:|----------:|
| **GetDescription** |  **42.87 ns** | **0.386 ns** | **0.361 ns** | **0.093 ns** |  **42.31 ns** |  **42.62 ns** |  **42.88 ns** |  **43.15 ns** |  **43.41 ns** | **23,326,950.0** |       **7.453 ns** |      **15.00** |    **1.629** |  **2.000** |  **-0.0938** |    **1** | *****            | **No**       |          **-** |     **750 B** | **0.0002** |                    **-** |                **-** |      **24 B** |
| **GetItems**       | **968.05 ns** | **4.786 ns** | **4.242 ns** | **1.134 ns** | **962.06 ns** | **965.38 ns** | **967.28 ns** | **970.88 ns** | **975.42 ns** |  **1,033,007.0** |       **6.433 ns** |      **14.00** |    **1.682** |  **2.000** |   **0.2119** |    **2** | *****            | **No**       |          **-** |     **462 B** | **0.0095** |                    **-** |                **-** |     **896 B** |
