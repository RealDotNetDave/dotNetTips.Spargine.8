```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  Job-TLMPGC : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Reflection  

```
| Method           | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s        | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Gen0   | Code Size | Allocated |
|----------------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|-------:|----------:|----------:|
| **GetAllInterfaces** | **2,594.0 ns** |  **7.64 ns** |  **7.14 ns** | **1.84 ns** | **2,583.0 ns** | **2,590.2 ns** | **2,593.0 ns** | **2,598.3 ns** | **2,609.1 ns** |   **385,504.2** |       **7.637 ns** |      **15.00** |    **2.320** |  **2.000** |   **0.4445** |    **3** | *****            | **No**       |          **-** |                    **-** |                **-** | **0.0114** |     **877 B** |    **1080 B** |
| **GetAllTypes**      | **2,160.5 ns** | **11.49 ns** | **10.74 ns** | **2.77 ns** | **2,142.0 ns** | **2,155.3 ns** | **2,157.3 ns** | **2,170.0 ns** | **2,177.5 ns** |   **462,847.0** |      **11.486 ns** |      **15.00** |    **1.865** |  **2.000** |   **0.0912** |    **2** | *****            | **No**       |          **-** |                    **-** |                **-** | **0.0153** |   **1,009 B** |    **1592 B** |
| **GetInstances**     |   **600.5 ns** |  **2.77 ns** |  **2.59 ns** | **0.67 ns** |   **595.9 ns** |   **599.1 ns** |   **600.4 ns** |   **602.6 ns** |   **604.1 ns** | **1,665,304.9** |       **2.770 ns** |      **15.00** |    **1.786** |  **2.000** |  **-0.2211** |    **1** | *****            | **No**       |          **-** |                    **-** |                **-** |      **-** |     **137 B** |      **56 B** |
