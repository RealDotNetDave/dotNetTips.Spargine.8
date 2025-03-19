```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5608/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.201
  [Host]     : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  Job-FRJBZZ : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

```
| Method         | Mean        | Error    | StdDev   | StdErr   | Min       | Q1        | Median      | Q3          | Max         | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Completed Work Items | Lock Contentions | Code Size | Gen0   | Exceptions | Allocated |
|--------------- |------------:|---------:|---------:|---------:|----------:|----------:|------------:|------------:|------------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |---------------------:|-----------------:|----------:|-------:|-----------:|----------:|
| **GetDescription** |    **39.94 ns** | **0.814 ns** | **0.761 ns** | **0.197 ns** |  **38.28 ns** |  **40.01 ns** |    **40.25 ns** |    **40.39 ns** |    **40.62 ns** | **25,040,011.2** |       **7.402 ns** |      **15.00** |    **2.736** |  **2.000** |  **-1.1781** |    **1** | *****            | **No**       |                    **-** |                **-** |     **750 B** | **0.0002** |          **-** |      **24 B** |
| **GetItems**       | **1,003.47 ns** | **5.574 ns** | **5.214 ns** | **1.346 ns** | **996.29 ns** | **999.65 ns** | **1,002.12 ns** | **1,006.16 ns** | **1,015.18 ns** |    **996,546.9** |       **6.827 ns** |      **15.00** |    **2.561** |  **2.000** |   **0.7073** |    **2** | *****            | **No**       |                    **-** |                **-** |     **462 B** | **0.0095** |          **-** |     **896 B** |
