```

BenchmarkDotNet v0.15.2, Windows 10 (10.0.19045.6691/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.308
  [Host]     : .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
  Job-ZSLFFS : .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

```
| Method         | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max         | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Completed Work Items | Lock Contentions | Exceptions | Code Size | Gen0   | Allocated |
|--------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|------------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |---------------------:|-----------------:|-----------:|----------:|-------:|----------:|
| **GetDescription** |  **40.05 ns** | **0.322 ns** | **0.285 ns** | **0.076 ns** |  **39.55 ns** |  **39.95 ns** |  **40.12 ns** |  **40.22 ns** |    **40.48 ns** | **24,971,381.5** |       **6.962 ns** |      **14.00** |    **1.940** |  **2.000** |  **-0.3911** |    **1** | *****            | **No**       |                    **-** |                **-** |          **-** |     **750 B** | **0.0002** |      **24 B** |
| **GetItems**       | **989.94 ns** | **9.870 ns** | **9.232 ns** | **2.384 ns** | **977.24 ns** | **983.25 ns** | **985.69 ns** | **997.25 ns** | **1,008.68 ns** |  **1,010,162.1** |       **6.308 ns** |      **15.00** |    **1.860** |  **2.000** |   **0.4214** |    **2** | *****            | **No**       |                    **-** |                **-** |          **-** |        **NA** | **0.0095** |     **896 B** |
