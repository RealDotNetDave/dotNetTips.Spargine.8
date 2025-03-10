```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5487/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.200
  [Host]     : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  Job-THQNBF : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests.Security  Categories=**NEW**,Encryption  

```
| Method            | Mean | Error | StdErr | StdDev | Min | Q1 | Median | Q3 | Max | Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline |
|------------------ |-----:|------:|-------:|-------:|----:|---:|-------:|---:|----:|-----:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |
| GenerateRandomKey |   NA |    NA |     NA |     NA |  NA | NA |     NA | NA |  NA |   NA |             NA |         NA |       NA |     NA |       NA |    ? | *            | No       |

Benchmarks with issues:
  EncryptionHelperBenchmark.GenerateRandomKey: Job-THQNBF(EvaluateOverhead=True, Runtime=.NET 8.0, Server=True)
