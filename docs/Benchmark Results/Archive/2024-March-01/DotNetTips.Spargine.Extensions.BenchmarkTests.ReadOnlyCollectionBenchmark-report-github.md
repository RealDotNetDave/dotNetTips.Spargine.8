```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  Job-TLMPGC : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

```
| Method           | Count | Mean         | Error     | StdDev    | StdErr    | Min          | Q1           | Median       | Q3           | Max          | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Gen0   | Code Size | Allocated |
|----------------- |------ |-------------:|----------:|----------:|----------:|-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|-------:|----------:|----------:|
| DoesNotHaveItems | 16    |     48.93 ns |  0.296 ns |  0.277 ns |  0.072 ns |     48.42 ns |     48.73 ns |     48.92 ns |     49.14 ns |     49.37 ns | 20,438,004.6 |      0.2961 ns |      15.00 |    1.774 |  2.000 |  -0.0916 |    1 | *            | No       |          - |                    - |                - | 0.0004 |     447 B |      40 B |
| DoesNotHaveItems | 32    |     92.35 ns |  0.249 ns |  0.233 ns |  0.060 ns |     91.94 ns |     92.14 ns |     92.42 ns |     92.56 ns |     92.65 ns | 10,827,898.4 |      0.2488 ns |      15.00 |    1.561 |  2.000 |  -0.2690 |    2 | *            | No       |          - |                    - |                - | 0.0004 |     447 B |      40 B |
| DoesNotHaveItems | 64    |    163.71 ns |  0.588 ns |  0.521 ns |  0.139 ns |    162.76 ns |    163.35 ns |    163.71 ns |    164.13 ns |    164.43 ns |  6,108,543.3 |      0.5875 ns |      14.00 |    1.735 |  2.000 |  -0.2377 |    3 | *            | No       |          - |                    - |                - | 0.0002 |     447 B |      40 B |
| DoesNotHaveItems | 128   |    303.31 ns |  1.302 ns |  1.217 ns |  0.314 ns |    301.20 ns |    302.49 ns |    303.12 ns |    303.87 ns |    305.43 ns |  3,296,989.4 |      1.3015 ns |      15.00 |    2.073 |  2.000 |   0.2761 |    4 | *            | No       |          - |                    - |                - |      - |     447 B |      40 B |
| DoesNotHaveItems | 256   |    589.63 ns |  2.489 ns |  2.328 ns |  0.601 ns |    586.22 ns |    587.69 ns |    589.71 ns |    590.60 ns |    593.81 ns |  1,695,987.4 |      2.4886 ns |      15.00 |    1.812 |  2.000 |   0.1611 |    5 | *            | No       |          - |                    - |                - |      - |     451 B |      40 B |
| DoesNotHaveItems | 512   |  2,664.24 ns | 12.142 ns | 11.357 ns |  2.932 ns |  2,630.05 ns |  2,661.41 ns |  2,665.19 ns |  2,669.16 ns |  2,678.78 ns |    375,341.0 |     12.1417 ns |      15.00 |    5.804 |  2.000 |  -1.5855 |    6 | *            | No       |          - |                    - |                - |      - |     331 B |      40 B |
| DoesNotHaveItems | 1024  |  5,792.39 ns | 20.353 ns | 19.039 ns |  4.916 ns |  5,755.49 ns |  5,782.23 ns |  5,795.24 ns |  5,808.20 ns |  5,813.61 ns |    172,640.3 |     20.3534 ns |      15.00 |    1.930 |  2.000 |  -0.5605 |    7 | *            | No       |          - |                    - |                - |      - |     331 B |      40 B |
| DoesNotHaveItems | 2048  | 11,548.60 ns | 60.982 ns | 57.043 ns | 14.728 ns | 11,424.53 ns | 11,522.95 ns | 11,566.34 ns | 11,584.97 ns | 11,623.57 ns |     86,590.6 |     60.9822 ns |      15.00 |    2.649 |  2.000 |  -0.9030 |    8 | *            | No       |          - |                    - |                - |      - |     331 B |      40 B |
