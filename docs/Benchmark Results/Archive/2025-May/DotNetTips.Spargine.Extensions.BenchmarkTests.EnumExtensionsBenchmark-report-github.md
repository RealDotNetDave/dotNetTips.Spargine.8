```

BenchmarkDotNet v0.15.2, Windows 10 (10.0.19045.6093/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.302
  [Host]     : .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
  Job-ZSLFFS : .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

```
| Method         | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max         | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Exceptions | Completed Work Items | Lock Contentions | Gen0   | Allocated |
|--------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|------------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-----------:|---------------------:|-----------------:|-------:|----------:|
| **GetDescription** |  **41.88 ns** | **0.270 ns** | **0.252 ns** | **0.065 ns** |  **41.42 ns** |  **41.72 ns** |  **41.80 ns** |  **42.07 ns** |    **42.35 ns** | **23,879,995.8** |       **7.467 ns** |      **15.00** |    **1.980** |  **2.000** |   **0.1568** |    **1** | *****            | **No**       |     **750 B** |          **-** |                    **-** |                **-** | **0.0002** |      **24 B** |
| **GetItems**       | **990.69 ns** | **6.652 ns** | **6.222 ns** | **1.607 ns** | **980.95 ns** | **986.63 ns** | **989.85 ns** | **994.40 ns** | **1,006.01 ns** |  **1,009,398.3** |       **6.697 ns** |      **15.00** |    **3.106** |  **2.000** |   **0.7585** |    **2** | *****            | **No**       |        **NA** |          **-** |                    **-** |                **-** | **0.0095** |     **896 B** |
