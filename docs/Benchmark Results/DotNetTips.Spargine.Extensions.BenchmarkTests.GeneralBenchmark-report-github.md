```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5737/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.203
  [Host]     : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  Job-BJZEEE : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=**FOR COMPARISON**  

```
| Method         | Mean      | Error     | StdDev    | StdErr    | Median    | Min    | Q1     | Q3        | Max       | Op/s              | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Exceptions | Completed Work Items | Lock Contentions | Allocated |
|--------------- |----------:|----------:|----------:|----------:|----------:|-------:|-------:|----------:|----------:|------------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-----------:|---------------------:|-----------------:|----------:|
| &#39;Equals: Guid&#39; | 0.0027 ns | 0.0040 ns | 0.0036 ns | 0.0010 ns | 0.0013 ns | 0.0 ns | 0.0 ns | 0.0037 ns | 0.0110 ns | 368,686,613,036.1 |       7.000 ns |      14.00 |    2.829 |  2.200 |    1.077 |    1 | *            | No       |      42 B |          - |                    - |                - |         - |
