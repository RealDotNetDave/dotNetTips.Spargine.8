```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4651/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.302
  [Host]     : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  Job-ZSORKR : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

```
| Method         | Mean        | Error    | StdDev   | StdErr   | Min         | Q1          | Median      | Q3          | Max         | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Exceptions | Completed Work Items | Lock Contentions | Gen0   | Allocated |
|--------------- |------------:|---------:|---------:|---------:|------------:|------------:|------------:|------------:|------------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-----------:|---------------------:|-----------------:|-------:|----------:|
| **GetDescription** |    **45.20 ns** | **0.367 ns** | **0.326 ns** | **0.087 ns** |    **44.68 ns** |    **45.04 ns** |    **45.18 ns** |    **45.40 ns** |    **45.91 ns** | **22,124,854.1** |      **0.3675 ns** |      **14.00** |    **2.454** |  **2.000** |   **0.3841** |    **1** | *****            | **No**       |     **750 B** |          **-** |                    **-** |                **-** | **0.0002** |      **24 B** |
| **GetItems**       | **1,015.21 ns** | **9.773 ns** | **9.142 ns** | **2.360 ns** | **1,002.19 ns** | **1,008.87 ns** | **1,014.17 ns** | **1,024.49 ns** | **1,027.71 ns** |    **985,014.1** |      **9.7730 ns** |      **15.00** |    **1.362** |  **2.000** |   **0.1573** |    **2** | *****            | **No**       |     **462 B** |          **-** |                    **-** |                **-** | **0.0095** |     **896 B** |
