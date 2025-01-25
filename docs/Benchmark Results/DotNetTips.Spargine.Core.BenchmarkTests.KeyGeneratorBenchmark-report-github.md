```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5371/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  Job-VPTVLS : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  Categories=**NEW**  

```
| Method                     | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Gen0   | Code Size | Allocated |
|--------------------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|-------:|----------:|----------:|
| **&#39;GenerateKey: With Prefix&#39;** | **103.57 ns** | **0.219 ns** | **0.205 ns** | **0.053 ns** | **103.15 ns** | **103.45 ns** | **103.59 ns** | **103.74 ns** | **103.87 ns** |  **9,654,996.5** |       **7.474 ns** |      **15.00** |    **2.167** |  **2.000** |  **-0.2963** |    **2** | *****            | **No**       |          **-** |                    **-** |                **-** | **0.0019** |     **314 B** |     **184 B** |
| **GenerateKey**                |  **86.94 ns** | **0.889 ns** | **0.831 ns** | **0.215 ns** |  **84.90 ns** |  **86.55 ns** |  **87.09 ns** |  **87.57 ns** |  **87.93 ns** | **11,502,791.0** |       **7.393 ns** |      **15.00** |    **2.962** |  **2.000** |  **-0.8689** |    **1** | *****            | **No**       |          **-** |                    **-** |                **-** | **0.0010** |     **123 B** |      **88 B** |
