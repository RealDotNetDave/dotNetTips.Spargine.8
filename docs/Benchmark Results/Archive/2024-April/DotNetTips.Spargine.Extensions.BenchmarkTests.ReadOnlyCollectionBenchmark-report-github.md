```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4291/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.300-preview.24203.14
  [Host]     : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  Job-XJVIUY : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

```
| Method           | Count | Mean     | Error     | StdDev    | StdErr    | Median   | Min      | Q1       | Q3       | Max      | Op/s          | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Code Size | Allocated |
|----------------- |------ |---------:|----------:|----------:|----------:|---------:|---------:|---------:|---------:|---------:|--------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|----------:|----------:|
| DoesNotHaveItems | 16    | 1.423 ns | 0.0111 ns | 0.0103 ns | 0.0027 ns | 1.422 ns | 1.409 ns | 1.414 ns | 1.430 ns | 1.442 ns | 702,750,599.8 |      0.0111 ns |      15.00 |    1.683 |  2.000 |   0.2570 |    1 | *            | No       |          - |                    - |                - |      65 B |         - |
| DoesNotHaveItems | 32    | 1.676 ns | 0.0129 ns | 0.0121 ns | 0.0031 ns | 1.671 ns | 1.663 ns | 1.667 ns | 1.687 ns | 1.702 ns | 596,717,668.3 |      0.0129 ns |      15.00 |    2.052 |  2.000 |   0.7128 |    2 | *            | No       |          - |                    - |                - |      65 B |         - |
| DoesNotHaveItems | 64    | 1.433 ns | 0.0111 ns | 0.0099 ns | 0.0026 ns | 1.433 ns | 1.418 ns | 1.428 ns | 1.438 ns | 1.450 ns | 697,724,976.2 |      0.0111 ns |      14.00 |    1.816 |  2.000 |   0.0303 |    1 | *            | No       |          - |                    - |                - |      65 B |         - |
| DoesNotHaveItems | 128   | 1.899 ns | 0.0157 ns | 0.0147 ns | 0.0038 ns | 1.897 ns | 1.878 ns | 1.888 ns | 1.906 ns | 1.930 ns | 526,715,651.6 |      0.0157 ns |      15.00 |    2.324 |  2.000 |   0.5378 |    3 | *            | No       |          - |                    - |                - |      65 B |         - |
| DoesNotHaveItems | 256   | 1.433 ns | 0.0128 ns | 0.0107 ns | 0.0030 ns | 1.431 ns | 1.420 ns | 1.425 ns | 1.442 ns | 1.453 ns | 697,782,595.0 |      0.0128 ns |      13.00 |    1.660 |  2.000 |   0.4501 |    1 | *            | No       |          - |                    - |                - |      65 B |         - |
| DoesNotHaveItems | 512   | 1.687 ns | 0.0486 ns | 0.0431 ns | 0.0115 ns | 1.675 ns | 1.645 ns | 1.650 ns | 1.711 ns | 1.771 ns | 592,890,800.7 |      0.0486 ns |      14.00 |    2.027 |  2.000 |   0.6807 |    2 | *            | No       |          - |                    - |                - |      65 B |         - |
| DoesNotHaveItems | 1024  | 2.329 ns | 0.0808 ns | 0.2383 ns | 0.0238 ns | 2.458 ns | 1.882 ns | 2.199 ns | 2.501 ns | 2.555 ns | 429,322,943.8 |      0.0808 ns |     100.00 |    2.240 |  2.551 |  -0.9576 |    4 | *            | No       |          - |                    - |                - |      65 B |         - |
| DoesNotHaveItems | 2048  | 1.673 ns | 0.0103 ns | 0.0096 ns | 0.0025 ns | 1.673 ns | 1.661 ns | 1.664 ns | 1.680 ns | 1.691 ns | 597,772,571.4 |      0.0103 ns |      15.00 |    1.746 |  2.000 |   0.4618 |    2 | *            | No       |          - |                    - |                - |      65 B |         - |
