```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5737/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.203
  [Host]     : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  Job-WAULDK : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

```
| Method         | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Exceptions | Completed Work Items | Lock Contentions | Gen0   | Allocated |
|--------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-----------:|---------------------:|-----------------:|-------:|----------:|
| **GetDescription** |  **44.25 ns** | **0.406 ns** | **0.360 ns** | **0.096 ns** |  **43.57 ns** |  **44.07 ns** |  **44.23 ns** |  **44.47 ns** |  **44.95 ns** | **22,600,250.9** |       **6.952 ns** |      **14.00** |    **2.469** |  **2.000** |  **-0.1154** |    **1** | *****            | **No**       |     **750 B** |          **-** |                    **-** |                **-** | **0.0002** |      **24 B** |
| **GetItems**       | **968.84 ns** | **6.397 ns** | **5.984 ns** | **1.545 ns** | **960.17 ns** | **965.13 ns** | **967.18 ns** | **972.79 ns** | **981.50 ns** |  **1,032,161.6** |       **6.727 ns** |      **15.00** |    **2.260** |  **2.000** |   **0.5017** |    **2** | *****            | **No**       |        **NA** |          **-** |                    **-** |                **-** | **0.0095** |     **896 B** |
