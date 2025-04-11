```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5737/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.203
  [Host]     : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  Job-KOMWZH : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests.Security  Categories=Encryption  

```
| Method               | Mean             | Error          | StdDev         | StdErr        | Min              | Q1               | Median           | Q3               | Max              | Op/s          | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Code Size | Completed Work Items | Lock Contentions | Gen0   | Allocated |
|--------------------- |-----------------:|---------------:|---------------:|--------------:|-----------------:|-----------------:|-----------------:|-----------------:|-----------------:|--------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|----------:|---------------------:|-----------------:|-------:|----------:|
| **FixedTimeEquals**      |         **69.41 ns** |       **0.522 ns** |       **0.489 ns** |      **0.126 ns** |         **68.73 ns** |         **69.05 ns** |         **69.38 ns** |         **69.82 ns** |         **70.30 ns** | **14,406,627.20** |       **7.437 ns** |      **15.00** |    **1.715** |  **2.000** |   **0.1689** |    **1** | *****            | **No**       |          **-** |     **578 B** |                    **-** |                **-** | **0.0006** |      **64 B** |
| **HashPassword**         | **32,198,507.59 ns** | **121,309.096 ns** | **107,537.354 ns** | **28,740.567 ns** | **32,036,743.75 ns** | **32,132,596.88 ns** | **32,187,659.38 ns** | **32,261,587.50 ns** | **32,436,475.00 ns** |         **31.06** | **-14,363.283 ns** |      **14.00** |    **2.478** |  **2.000** |   **0.4509** |    **2** | *****            | **No**       |          **-** |        **NA** |                    **-** |                **-** |      **-** |     **859 B** |
| **VerifyHashedPassword** |               **NA** |             **NA** |             **NA** |            **NA** |               **NA** |               **NA** |               **NA** |               **NA** |               **NA** |            **NA** |             **NA** |         **NA** |       **NA** |     **NA** |       **NA** |    **?** | *****            | **No**       |         **NA** |        **NA** |                   **NA** |               **NA** |     **NA** |        **NA** |

Benchmarks with issues:
  PBKDF2PasswordHasherBenchmark.VerifyHashedPassword: Job-KOMWZH(EvaluateOverhead=True, Runtime=.NET 8.0, Server=True)
