```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5737/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.203
  [Host]     : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  Job-FORZLD : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests.Security  Categories=Encryption  

```
| Method               | Mean             | Error          | StdDev         | StdErr        | Min              | Q1               | Median           | Q3               | Max              | Op/s          | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Completed Work Items | Lock Contentions | Exceptions | Code Size | Allocated |
|--------------------- |-----------------:|---------------:|---------------:|--------------:|-----------------:|-----------------:|-----------------:|-----------------:|-----------------:|--------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|---------------------:|-----------------:|-----------:|----------:|----------:|
| **FixedTimeEquals**      |         **68.06 ns** |       **0.351 ns** |       **0.328 ns** |      **0.085 ns** |         **67.53 ns** |         **67.84 ns** |         **67.99 ns** |         **68.27 ns** |         **68.70 ns** | **14,692,769.45** |       **7.458 ns** |      **15.00** |    **1.973** |  **2.000** |   **0.2024** |    **1** | *****            | **No**       | **0.0006** |                    **-** |                **-** |          **-** |     **578 B** |      **64 B** |
| **HashPassword**         | **31,762,589.58 ns** | **209,281.979 ns** | **195,762.493 ns** | **50,545.658 ns** | **31,536,731.25 ns** | **31,608,353.12 ns** | **31,693,175.00 ns** | **31,869,159.38 ns** | **32,192,337.50 ns** |         **31.48** | **-25,265.329 ns** |      **15.00** |    **2.386** |  **2.000** |   **0.7404** |    **2** | *****            | **No**       |      **-** |                    **-** |                **-** |          **-** |        **NA** |     **859 B** |
| **VerifyHashedPassword** | **31,795,143.75 ns** | **125,485.823 ns** | **117,379.517 ns** | **30,307.261 ns** | **31,605,975.00 ns** | **31,700,668.75 ns** | **31,791,775.00 ns** | **31,908,606.25 ns** | **31,964,106.25 ns** |         **31.45** | **-15,146.131 ns** |      **15.00** |    **1.511** |  **2.000** |   **0.1434** |    **2** | *****            | **No**       |      **-** |                    **-** |                **-** |          **-** |        **NA** |     **835 B** |
