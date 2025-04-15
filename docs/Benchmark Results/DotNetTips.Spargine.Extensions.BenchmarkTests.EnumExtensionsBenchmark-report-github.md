```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5737/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.203
  [Host]     : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  Job-BJZEEE : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

```
| Method         | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Exceptions | Completed Work Items | Lock Contentions | Gen0   | Allocated |
|--------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-----------:|---------------------:|-----------------:|-------:|----------:|
| **GetDescription** |  **47.62 ns** | **0.170 ns** | **0.151 ns** | **0.040 ns** |  **47.26 ns** |  **47.57 ns** |  **47.66 ns** |  **47.69 ns** |  **47.82 ns** | **20,998,651.6** |       **6.980 ns** |      **14.00** |    **3.143** |  **2.000** |  **-0.9017** |    **1** | *****            | **No**       |     **750 B** |          **-** |                    **-** |                **-** | **0.0002** |      **24 B** |
| **GetItems**       | **984.50 ns** | **7.488 ns** | **7.004 ns** | **1.809 ns** | **973.76 ns** | **979.64 ns** | **984.83 ns** | **988.66 ns** | **996.89 ns** |  **1,015,745.9** |       **6.596 ns** |      **15.00** |    **1.784** |  **2.000** |   **0.0650** |    **2** | *****            | **No**       |        **NA** |          **-** |                    **-** |                **-** | **0.0095** |     **896 B** |
