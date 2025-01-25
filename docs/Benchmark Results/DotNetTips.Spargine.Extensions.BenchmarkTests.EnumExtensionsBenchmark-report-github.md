```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5371/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  Job-QFIUKL : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

```
| Method         | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Code Size | Gen0   | Completed Work Items | Lock Contentions | Allocated |
|--------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|----------:|-------:|---------------------:|-----------------:|----------:|
| **GetDescription** |  **39.99 ns** | **0.218 ns** | **0.204 ns** | **0.053 ns** |  **39.63 ns** |  **39.88 ns** |  **40.03 ns** |  **40.13 ns** |  **40.27 ns** | **25,003,591.4** |       **7.474 ns** |      **15.00** |    **1.882** |  **2.000** |  **-0.5812** |    **1** | *****            | **No**       |          **-** |     **750 B** | **0.0002** |                    **-** |                **-** |      **24 B** |
| **GetItems**       | **950.05 ns** | **4.121 ns** | **3.441 ns** | **0.954 ns** | **945.59 ns** | **948.10 ns** | **949.39 ns** | **951.70 ns** | **957.65 ns** |  **1,052,581.2** |       **6.023 ns** |      **13.00** |    **2.515** |  **2.000** |   **0.6341** |    **2** | *****            | **No**       |          **-** |     **462 B** | **0.0095** |                    **-** |                **-** |     **896 B** |
