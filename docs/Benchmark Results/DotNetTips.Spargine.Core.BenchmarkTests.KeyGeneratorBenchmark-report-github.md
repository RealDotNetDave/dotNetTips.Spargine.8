```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5737/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.203
  [Host]     : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  Job-KOMWZH : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  Categories=**NEW**  

```
| Method                     | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Code Size | Gen0   | Allocated |
|--------------------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|----------:|-------:|----------:|
| **&#39;GenerateKey: With Prefix&#39;** | **107.67 ns** | **0.769 ns** | **0.719 ns** | **0.186 ns** | **106.49 ns** | **107.22 ns** | **107.85 ns** | **107.93 ns** | **108.84 ns** |  **9,287,238.1** |       **7.407 ns** |      **15.00** |    **2.016** |  **2.000** |  **-0.1290** |    **2** | *****            | **No**       |          **-** |                    **-** |                **-** |     **304 B** | **0.0019** |     **184 B** |
| **GenerateKey**                |  **87.14 ns** | **0.683 ns** | **0.639 ns** | **0.165 ns** |  **86.12 ns** |  **86.60 ns** |  **87.19 ns** |  **87.62 ns** |  **88.07 ns** | **11,476,256.2** |       **7.417 ns** |      **15.00** |    **1.573** |  **2.000** |  **-0.2291** |    **1** | *****            | **No**       |          **-** |                    **-** |                **-** |     **123 B** | **0.0010** |      **88 B** |
