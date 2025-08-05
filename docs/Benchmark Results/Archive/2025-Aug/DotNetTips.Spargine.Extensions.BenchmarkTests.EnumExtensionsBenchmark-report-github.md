```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5737/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.203
  [Host]     : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  Job-TAWJXX : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

```
| Method         | Mean        | Error    | StdDev   | StdErr   | Min         | Q1          | Median      | Q3          | Max         | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Completed Work Items | Lock Contentions | Exceptions | Code Size | Gen0   | Allocated |
|--------------- |------------:|---------:|---------:|---------:|------------:|------------:|------------:|------------:|------------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |---------------------:|-----------------:|-----------:|----------:|-------:|----------:|
| **GetDescription** |    **45.61 ns** | **0.173 ns** | **0.162 ns** | **0.042 ns** |    **45.33 ns** |    **45.49 ns** |    **45.58 ns** |    **45.69 ns** |    **45.92 ns** | **21,924,340.7** |       **7.479 ns** |      **15.00** |    **2.207** |  **2.000** |   **0.1992** |    **1** | *****            | **No**       |                    **-** |                **-** |          **-** |     **750 B** | **0.0002** |      **24 B** |
| **GetItems**       | **1,013.56 ns** | **4.153 ns** | **3.885 ns** | **1.003 ns** | **1,007.46 ns** | **1,011.11 ns** | **1,013.53 ns** | **1,015.23 ns** | **1,020.57 ns** |    **986,617.7** |       **6.998 ns** |      **15.00** |    **1.993** |  **2.000** |   **0.1875** |    **2** | *****            | **No**       |                    **-** |                **-** |          **-** |        **NA** | **0.0095** |     **896 B** |
