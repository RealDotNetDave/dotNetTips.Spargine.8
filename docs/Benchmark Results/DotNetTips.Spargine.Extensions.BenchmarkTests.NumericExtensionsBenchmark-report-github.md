```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5371/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  Job-QFIUKL : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=**NEW**  

```
| Method  | Mean       | Error    | StdDev  | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Code Size | Completed Work Items | Lock Contentions | Gen0   | Allocated |
|-------- |-----------:|---------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|----------:|---------------------:|-----------------:|-------:|----------:|
| ToWords | 5,422.8 ns | 10.95 ns | 9.70 ns | 2.59 ns | 5,405.8 ns | 5,419.7 ns | 5,422.3 ns | 5,428.9 ns | 5,443.0 ns | 184,405.2 |       5.703 ns |      14.00 |    2.678 |  2.000 |   0.0008 |    1 | *            | No       |          - |   4,512 B |                    - |                - | 0.0076 |   1.04 KB |
