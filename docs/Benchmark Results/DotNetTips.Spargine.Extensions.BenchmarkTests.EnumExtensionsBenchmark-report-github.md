```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5371/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  Job-TMHTGD : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

```
| Method         | Mean        | Error    | StdDev   | StdErr   | Min         | Q1          | Median      | Q3          | Max         | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Code Size | Gen0   | Completed Work Items | Lock Contentions | Allocated |
|--------------- |------------:|---------:|---------:|---------:|------------:|------------:|------------:|------------:|------------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|----------:|-------:|---------------------:|-----------------:|----------:|
| **GetDescription** |    **39.97 ns** | **0.195 ns** | **0.172 ns** | **0.046 ns** |    **39.67 ns** |    **39.86 ns** |    **39.96 ns** |    **40.07 ns** |    **40.30 ns** | **25,021,764.7** |       **6.977 ns** |      **14.00** |    **2.170** |  **2.000** |   **0.2217** |    **1** | *****            | **No**       |          **-** |     **750 B** | **0.0002** |                    **-** |                **-** |      **24 B** |
| **GetItems**       | **1,046.06 ns** | **5.202 ns** | **4.612 ns** | **1.233 ns** | **1,039.99 ns** | **1,043.18 ns** | **1,045.28 ns** | **1,048.34 ns** | **1,057.17 ns** |    **955,967.8** |       **6.384 ns** |      **14.00** |    **2.943** |  **2.000** |   **0.8033** |    **2** | *****            | **No**       |          **-** |     **462 B** | **0.0095** |                    **-** |                **-** |     **896 B** |
