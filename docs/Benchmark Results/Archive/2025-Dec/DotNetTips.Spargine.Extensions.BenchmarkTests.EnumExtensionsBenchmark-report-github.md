```

BenchmarkDotNet v0.15.2, Windows 10 (10.0.19045.6216/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.304
  [Host]     : .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
  Job-ZSLFFS : .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

```
| Method         | Mean        | Error    | StdDev   | StdErr   | Min         | Q1          | Median      | Q3          | Max         | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Exceptions | Completed Work Items | Lock Contentions | Gen0   | Allocated |
|--------------- |------------:|---------:|---------:|---------:|------------:|------------:|------------:|------------:|------------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-----------:|---------------------:|-----------------:|-------:|----------:|
| **GetDescription** |    **46.25 ns** | **0.467 ns** | **0.436 ns** | **0.113 ns** |    **45.60 ns** |    **46.05 ns** |    **46.21 ns** |    **46.71 ns** |    **46.84 ns** | **21,619,720.7** |       **7.444 ns** |      **15.00** |    **1.607** |  **2.000** |  **-0.1032** |    **1** | *****            | **No**       |     **750 B** |          **-** |                    **-** |                **-** | **0.0002** |      **24 B** |
| **GetItems**       | **1,071.62 ns** | **8.447 ns** | **7.488 ns** | **2.001 ns** | **1,059.84 ns** | **1,067.05 ns** | **1,071.07 ns** | **1,074.59 ns** | **1,087.52 ns** |    **933,168.3** |       **5.999 ns** |      **14.00** |    **2.493** |  **2.000** |   **0.5154** |    **2** | *****            | **No**       |        **NA** |          **-** |                    **-** |                **-** | **0.0095** |     **896 B** |
