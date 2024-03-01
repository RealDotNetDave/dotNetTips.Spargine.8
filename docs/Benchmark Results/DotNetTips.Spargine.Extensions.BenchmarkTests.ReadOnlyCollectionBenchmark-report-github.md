```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  Job-LNCZTW : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

```
| Method           | Count | Mean        | Error    | StdDev   | StdErr   | Min         | Q1          | Median      | Q3          | Max         | Op/s        | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Completed Work Items | Lock Contentions | Code Size | Exceptions | Allocated |
|----------------- |------ |------------:|---------:|---------:|---------:|------------:|------------:|------------:|------------:|------------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|---------------------:|-----------------:|----------:|-----------:|----------:|
| DoesNotHaveItems | 16    |    125.1 ns |  0.54 ns |  0.48 ns |  0.13 ns |    123.9 ns |    125.0 ns |    125.2 ns |    125.4 ns |    125.6 ns | 7,993,113.6 |      0.5429 ns |      14.00 |    3.703 |  2.000 |  -1.1762 |    1 | *            | No       | 0.0002 |                    - |                - |     231 B |          - |      40 B |
| DoesNotHaveItems | 32    |    218.1 ns |  0.87 ns |  0.82 ns |  0.21 ns |    216.4 ns |    217.7 ns |    218.0 ns |    218.7 ns |    219.2 ns | 4,586,089.1 |      0.8724 ns |      15.00 |    2.160 |  2.000 |  -0.3818 |    2 | *            | No       | 0.0002 |                    - |                - |     231 B |          - |      40 B |
| DoesNotHaveItems | 64    |    381.0 ns |  2.56 ns |  2.40 ns |  0.62 ns |    377.1 ns |    379.5 ns |    381.8 ns |    382.9 ns |    383.5 ns | 2,624,341.1 |      2.5616 ns |      15.00 |    1.679 |  2.000 |  -0.6143 |    3 | *            | No       |      - |                    - |                - |     231 B |          - |      40 B |
| DoesNotHaveItems | 128   |    782.0 ns |  3.79 ns |  3.55 ns |  0.92 ns |    772.6 ns |    781.0 ns |    782.8 ns |    783.9 ns |    786.7 ns | 1,278,838.3 |      3.7930 ns |      15.00 |    3.916 |  2.000 |  -1.1896 |    4 | *            | No       |      - |                    - |                - |     231 B |          - |      40 B |
| DoesNotHaveItems | 256   |  1,405.3 ns | 12.31 ns | 11.51 ns |  2.97 ns |  1,389.8 ns |  1,394.7 ns |  1,407.5 ns |  1,410.8 ns |  1,431.4 ns |   711,580.8 |     12.3092 ns |      15.00 |    2.459 |  2.000 |   0.4838 |    5 | *            | No       |      - |                    - |                - |     231 B |          - |      40 B |
| DoesNotHaveItems | 512   |  3,038.2 ns |  7.82 ns |  7.31 ns |  1.89 ns |  3,024.4 ns |  3,033.6 ns |  3,038.1 ns |  3,044.9 ns |  3,048.7 ns |   329,145.7 |      7.8191 ns |      15.00 |    1.753 |  2.000 |  -0.1661 |    6 | *            | No       |      - |                    - |                - |     231 B |          - |      40 B |
| DoesNotHaveItems | 1024  |  6,044.8 ns | 22.36 ns | 20.92 ns |  5.40 ns |  5,987.1 ns |  6,036.5 ns |  6,046.5 ns |  6,058.8 ns |  6,071.5 ns |   165,431.7 |     22.3597 ns |      15.00 |    4.289 |  2.000 |  -1.1356 |    7 | *            | No       |      - |                    - |                - |     231 B |          - |      40 B |
| DoesNotHaveItems | 2048  | 12,032.7 ns | 58.29 ns | 54.53 ns | 14.08 ns | 11,931.3 ns | 12,010.4 ns | 12,040.6 ns | 12,061.9 ns | 12,101.8 ns |    83,106.8 |     58.2933 ns |      15.00 |    2.059 |  2.000 |  -0.5985 |    8 | *            | No       |      - |                    - |                - |     231 B |          - |      40 B |
