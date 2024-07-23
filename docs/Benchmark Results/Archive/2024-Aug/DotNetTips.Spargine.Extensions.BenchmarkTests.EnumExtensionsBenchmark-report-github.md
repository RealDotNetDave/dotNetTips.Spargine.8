```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4291/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.300-preview.24203.14
  [Host]     : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  Job-XJVIUY : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

```
| Method         | Mean     | Error    | StdDev   | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Gen0   | Code Size | Allocated |
|--------------- |---------:|---------:|---------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|-------:|----------:|----------:|
| **GetDescription** | **131.2 ns** |  **0.27 ns** |  **0.22 ns** | **0.06 ns** | **130.8 ns** | **131.0 ns** | **131.2 ns** | **131.3 ns** | **131.6 ns** | **7,624,157.1** |      **0.2661 ns** |      **13.00** |    **1.863** |  **2.000** |   **0.4123** |    **1** | *****            | **No**       |          **-** |                    **-** |                **-** | **0.0002** |     **880 B** |      **24 B** |
| **GetItems**       | **961.0 ns** | **15.17 ns** | **12.67 ns** | **3.51 ns** | **942.6 ns** | **947.6 ns** | **964.5 ns** | **968.4 ns** | **985.3 ns** | **1,040,632.8** |     **15.1744 ns** |      **13.00** |    **1.843** |  **2.000** |   **0.0949** |    **2** | *****            | **No**       |          **-** |                    **-** |                **-** | **0.0153** |     **854 B** |    **1400 B** |
