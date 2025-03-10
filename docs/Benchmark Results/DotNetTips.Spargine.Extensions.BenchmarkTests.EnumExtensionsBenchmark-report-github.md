```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5487/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.200
  [Host]     : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  Job-JHXHAM : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

```
| Method         | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3          | Max         | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Completed Work Items | Lock Contentions | Exceptions | Code Size | Gen0   | Allocated |
|--------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|------------:|------------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |---------------------:|-----------------:|-----------:|----------:|-------:|----------:|
| **GetDescription** |  **38.50 ns** | **0.381 ns** | **0.357 ns** | **0.092 ns** |  **37.80 ns** |  **38.29 ns** |  **38.47 ns** |    **38.73 ns** |    **39.09 ns** | **25,975,073.5** |       **7.454 ns** |      **15.00** |    **2.246** |  **2.000** |  **-0.2461** |    **1** | *****            | **No**       |                    **-** |                **-** |          **-** |     **750 B** | **0.0002** |      **24 B** |
| **GetItems**       | **999.06 ns** | **6.202 ns** | **5.802 ns** | **1.498 ns** | **991.21 ns** | **994.32 ns** | **999.06 ns** | **1,003.02 ns** | **1,009.58 ns** |  **1,000,939.4** |       **6.751 ns** |      **15.00** |    **1.731** |  **2.000** |   **0.3575** |    **2** | *****            | **No**       |                    **-** |                **-** |          **-** |        **NA** | **0.0095** |     **896 B** |
