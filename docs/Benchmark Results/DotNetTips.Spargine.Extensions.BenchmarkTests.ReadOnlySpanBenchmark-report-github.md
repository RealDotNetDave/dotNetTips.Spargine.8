```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4651/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.302
  [Host]     : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  Job-ZSORKR : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

```
| Method     | Count | Mean     | Error    | StdDev   | StdErr   | Median   | Min      | Q1       | Q3       | Max      | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Code Size | Allocated |
|----------- |------ |---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|----------:|----------:|
| PickRandom | 16    | 79.89 ns | 0.265 ns | 0.248 ns | 0.064 ns | 79.89 ns | 79.57 ns | 79.69 ns | 80.02 ns | 80.49 ns | 12,517,838.9 |      0.2652 ns |      15.00 |    2.936 |  2.000 |   0.6117 |    2 | *            | No       |          - |                    - |                - |     561 B |         - |
| PickRandom | 32    | 76.69 ns | 0.809 ns | 0.675 ns | 0.187 ns | 77.08 ns | 75.70 ns | 75.88 ns | 77.23 ns | 77.33 ns | 13,039,922.5 |      0.8085 ns |      13.00 |    1.212 |  2.000 |  -0.4549 |    1 | *            | No       |          - |                    - |                - |     561 B |         - |
| PickRandom | 64    | 75.65 ns | 0.779 ns | 0.729 ns | 0.188 ns | 75.41 ns | 74.69 ns | 74.99 ns | 76.30 ns | 76.59 ns | 13,219,237.9 |      0.7789 ns |      15.00 |    1.224 |  2.000 |   0.0235 |    1 | *            | No       |          - |                    - |                - |     561 B |         - |
| PickRandom | 128   | 75.78 ns | 0.201 ns | 0.188 ns | 0.049 ns | 75.84 ns | 75.40 ns | 75.64 ns | 75.92 ns | 76.02 ns | 13,196,789.7 |      0.2011 ns |      15.00 |    1.863 |  2.000 |  -0.4335 |    1 | *            | No       |          - |                    - |                - |     561 B |         - |
| PickRandom | 256   | 77.03 ns | 1.539 ns | 2.441 ns | 0.425 ns | 75.65 ns | 74.21 ns | 75.53 ns | 79.27 ns | 82.78 ns | 12,981,248.6 |      1.5391 ns |      33.00 |    2.152 |  2.870 |   0.9024 |    1 | *            | No       |          - |                    - |                - |     561 B |         - |
| PickRandom | 512   | 75.36 ns | 0.326 ns | 0.289 ns | 0.077 ns | 75.47 ns | 74.50 ns | 75.34 ns | 75.50 ns | 75.60 ns | 13,269,525.4 |      0.3260 ns |      14.00 |    5.725 |  2.000 |  -1.8558 |    1 | *            | No       |          - |                    - |                - |     561 B |         - |
| PickRandom | 1024  | 75.64 ns | 0.592 ns | 0.553 ns | 0.143 ns | 75.77 ns | 74.38 ns | 75.51 ns | 75.97 ns | 76.24 ns | 13,220,421.5 |      0.5916 ns |      15.00 |    3.588 |  2.000 |  -1.3282 |    1 | *            | No       |          - |                    - |                - |     561 B |         - |
| PickRandom | 2048  | 75.29 ns | 0.595 ns | 0.556 ns | 0.144 ns | 75.35 ns | 73.94 ns | 75.17 ns | 75.69 ns | 75.78 ns | 13,281,726.5 |      0.5948 ns |      15.00 |    3.497 |  2.000 |  -1.2647 |    1 | *            | No       |          - |                    - |                - |     561 B |         - |