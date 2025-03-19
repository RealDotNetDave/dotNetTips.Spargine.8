```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5608/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.201
  [Host]     : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  Job-FRJBZZ : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=**NEW**  

```
| Method  | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Completed Work Items | Lock Contentions | Gen0   | Code Size | Exceptions | Allocated |
|-------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |---------------------:|-----------------:|-------:|----------:|-----------:|----------:|
| ToWords | 5,615.2 ns | 20.46 ns | 18.14 ns | 4.85 ns | 5,588.2 ns | 5,603.6 ns | 5,608.2 ns | 5,624.2 ns | 5,648.5 ns | 178,087.9 |       4.576 ns |      14.00 |    2.091 |  2.000 |   0.6105 |    1 | *            | No       |                    - |                - | 0.0076 |   4,538 B |          - |   1.04 KB |
