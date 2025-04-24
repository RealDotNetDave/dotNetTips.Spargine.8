```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5737/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.203
  [Host]     : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  Job-TAWJXX : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=**FOR COMPARISON**  

```
| Method         | Mean      | Error     | StdDev    | StdErr    | Min    | Q1        | Median    | Q3        | Max       | Op/s              | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Completed Work Items | Lock Contentions | Exceptions | Code Size | Allocated |
|--------------- |----------:|----------:|----------:|----------:|-------:|----------:|----------:|----------:|----------:|------------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |---------------------:|-----------------:|-----------:|----------:|----------:|
| &#39;Equals: Guid&#39; | 0.0030 ns | 0.0030 ns | 0.0028 ns | 0.0007 ns | 0.0 ns | 0.0000 ns | 0.0033 ns | 0.0046 ns | 0.0081 ns | 328,654,891,830.0 |       7.500 ns |      15.00 |    1.688 |  2.000 |   0.3698 |    1 | *            | No       |                    - |                - |          - |      42 B |         - |
