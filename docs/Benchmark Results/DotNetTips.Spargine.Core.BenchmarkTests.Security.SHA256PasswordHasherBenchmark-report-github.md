```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5011/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.403
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  Job-BXAHQI : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests.Security  Categories=Encryption  

```
| Method               | Mean        | Error    | StdDev   | StdErr   | Min         | Q1          | Median      | Q3          | Max         | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Exceptions | Code Size | Completed Work Items | Lock Contentions | Allocated |
|--------------------- |------------:|---------:|---------:|---------:|------------:|------------:|------------:|------------:|------------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|-----------:|----------:|---------------------:|-----------------:|----------:|
| **FixedTimeEquals**      |    **49.96 ns** | **0.188 ns** | **0.157 ns** | **0.044 ns** |    **49.79 ns** |    **49.81 ns** |    **49.92 ns** |    **50.04 ns** |    **50.33 ns** | **20,017,412.7** |       **6.478 ns** |      **13.00** |    **2.961** |  **2.000** |   **0.9133** |    **1** | *****            | **No**       | **0.0007** |          **-** |     **632 B** |                    **-** |                **-** |      **64 B** |
| **HashPassword**         |   **713.53 ns** | **3.973 ns** | **3.522 ns** | **0.941 ns** |   **707.96 ns** |   **710.20 ns** |   **714.51 ns** |   **716.35 ns** |   **717.96 ns** |  **1,401,480.2** |       **6.529 ns** |      **14.00** |    **1.491** |  **2.000** |  **-0.4525** |    **2** | *****            | **No**       | **0.0038** |          **-** |     **358 B** |                    **-** |                **-** |     **432 B** |
| **VerifyHashedPassword** | **1,912.94 ns** | **4.254 ns** | **3.552 ns** | **0.985 ns** | **1,907.33 ns** | **1,909.89 ns** | **1,912.92 ns** | **1,915.03 ns** | **1,918.94 ns** |    **522,755.2** |       **6.007 ns** |      **13.00** |    **1.761** |  **2.000** |   **0.0239** |    **3** | *****            | **No**       | **0.0114** |          **-** |   **2,905 B** |                    **-** |                **-** |    **1080 B** |
