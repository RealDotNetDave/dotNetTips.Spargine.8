```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  Job-LNCZTW : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

```
| Method                     | Count | Mean         | Error      | StdDev     | StdErr     | Min          | Q1           | Median       | Q3           | Max          | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Code Size | Completed Work Items | Lock Contentions | Exceptions | Allocated |
|--------------------------- |------ |-------------:|-----------:|-----------:|-----------:|-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|----------:|---------------------:|-----------------:|-----------:|----------:|
| **&#39;HasItems: With Predicate&#39;** | **16**    |     **86.87 ns** |   **0.211 ns** |   **0.165 ns** |   **0.048 ns** |     **86.44 ns** |     **86.84 ns** |     **86.92 ns** |     **86.97 ns** |     **87.01 ns** | **11,511,564.1** |      **0.2108 ns** |      **12.00** |    **4.215** |  **2.000** |  **-1.4430** |    **1** | *****            | **No**       | **0.0018** |     **450 B** |                    **-** |                **-** |          **-** |     **168 B** |
| &#39;HasItems: With Predicate&#39; | 32    |     89.85 ns |   0.360 ns |   0.336 ns |   0.087 ns |     89.16 ns |     89.70 ns |     89.83 ns |     90.09 ns |     90.45 ns | 11,129,614.5 |      0.3597 ns |      15.00 |    2.551 |  2.000 |  -0.3430 |    2 | *            | No       | 0.0019 |     450 B |                    - |                - |          - |     184 B |
| &#39;HasItems: With Predicate&#39; | 64    |     97.74 ns |   0.260 ns |   0.243 ns |   0.063 ns |     97.38 ns |     97.56 ns |     97.71 ns |     97.98 ns |     98.15 ns | 10,230,964.4 |      0.2603 ns |      15.00 |    1.548 |  2.000 |   0.3160 |    3 | *            | No       | 0.0021 |     450 B |                    - |                - |          - |     200 B |
| &#39;HasItems: With Predicate&#39; | 128   |    104.29 ns |   0.366 ns |   0.342 ns |   0.088 ns |    103.73 ns |    104.07 ns |    104.24 ns |    104.60 ns |    104.85 ns |  9,588,765.0 |      0.3658 ns |      15.00 |    1.705 |  2.000 |   0.2021 |    4 | *            | No       | 0.0023 |     422 B |                    - |                - |          - |     216 B |
| &#39;HasItems: With Predicate&#39; | 256   |    110.20 ns |   0.256 ns |   0.227 ns |   0.061 ns |    109.81 ns |    110.11 ns |    110.19 ns |    110.29 ns |    110.62 ns |  9,074,239.7 |      0.2555 ns |      14.00 |    2.367 |  2.000 |  -0.0114 |    5 | *            | No       | 0.0025 |     422 B |                    - |                - |          - |     232 B |
| &#39;HasItems: With Predicate&#39; | 512   |    112.87 ns |   0.240 ns |   0.200 ns |   0.056 ns |    112.38 ns |    112.85 ns |    112.91 ns |    112.99 ns |    113.15 ns |  8,859,483.8 |      0.2398 ns |      13.00 |    3.337 |  2.000 |  -0.9363 |    6 | *            | No       | 0.0026 |     422 B |                    - |                - |          - |     248 B |
| &#39;HasItems: With Predicate&#39; | 1024  |    119.37 ns |   0.551 ns |   0.488 ns |   0.130 ns |    118.67 ns |    118.98 ns |    119.41 ns |    119.60 ns |    120.48 ns |  8,377,542.9 |      0.5506 ns |      14.00 |    2.652 |  2.000 |   0.5846 |    7 | *            | No       | 0.0029 |     422 B |                    - |                - |          - |     264 B |
| &#39;HasItems: With Predicate&#39; | 2048  |    120.74 ns |   0.815 ns |   0.680 ns |   0.189 ns |    119.97 ns |    120.17 ns |    120.58 ns |    120.99 ns |    122.23 ns |  8,282,155.9 |      0.8146 ns |      13.00 |    2.374 |  2.000 |   0.6921 |    7 | *            | No       | 0.0029 |     422 B |                    - |                - |          - |     280 B |
| **DoesNotHaveItems**           | **16**    |    **618.05 ns** |   **3.271 ns** |   **3.060 ns** |   **0.790 ns** |    **613.53 ns** |    **615.53 ns** |    **617.03 ns** |    **620.84 ns** |    **623.07 ns** |  **1,617,981.7** |      **3.2708 ns** |      **15.00** |    **1.507** |  **2.000** |   **0.1662** |   **10** | *****            | **No**       | **0.0124** |   **1,109 B** |                    **-** |                **-** |          **-** |    **1200 B** |
| DoesNotHaveItems           | 32    |  1,141.20 ns |   6.722 ns |   6.288 ns |   1.623 ns |  1,131.06 ns |  1,138.05 ns |  1,139.88 ns |  1,145.81 ns |  1,151.62 ns |    876,271.4 |      6.7217 ns |      15.00 |    1.862 |  2.000 |   0.1883 |   12 | *            | No       | 0.0210 |   1,103 B |                    - |                - |          - |    2016 B |
| DoesNotHaveItems           | 64    |  2,206.74 ns |  10.407 ns |   9.225 ns |   2.466 ns |  2,194.98 ns |  2,199.44 ns |  2,205.34 ns |  2,210.94 ns |  2,225.68 ns |    453,158.1 |     10.4066 ns |      14.00 |    2.341 |  2.000 |   0.6431 |   14 | *            | No       | 0.0381 |   1,103 B |                    - |                - |          - |    3600 B |
| DoesNotHaveItems           | 128   |  4,310.79 ns |  30.014 ns |  26.606 ns |   7.111 ns |  4,282.20 ns |  4,289.66 ns |  4,304.28 ns |  4,322.61 ns |  4,379.78 ns |    231,976.0 |     30.0136 ns |      14.00 |    3.603 |  2.000 |   1.1218 |   16 | *            | No       | 0.0687 |   1,103 B |                    - |                - |          - |    6720 B |
| DoesNotHaveItems           | 256   |  8,536.33 ns |  39.878 ns |  37.302 ns |   9.631 ns |  8,447.78 ns |  8,509.93 ns |  8,543.69 ns |  8,569.40 ns |  8,582.60 ns |    117,146.4 |     39.8780 ns |      15.00 |    2.678 |  2.000 |  -0.6925 |   18 | *            | No       | 0.1373 |   1,103 B |                    - |                - |          - |   12912 B |
| DoesNotHaveItems           | 512   | 17,352.17 ns |  95.907 ns |  85.019 ns |  22.722 ns | 17,222.61 ns | 17,286.07 ns | 17,352.89 ns | 17,414.31 ns | 17,511.64 ns |     57,629.7 |     95.9074 ns |      14.00 |    1.746 |  2.000 |   0.1060 |   20 | *            | No       | 0.2747 |   1,106 B |                    - |                - |          - |   25248 B |
| DoesNotHaveItems           | 1024  | 34,365.51 ns | 243.352 ns | 227.631 ns |  58.774 ns | 33,996.67 ns | 34,177.85 ns | 34,380.42 ns | 34,528.22 ns | 34,681.33 ns |     29,098.9 |    243.3517 ns |      15.00 |    1.524 |  2.000 |  -0.1466 |   22 | *            | No       | 0.4883 |   1,106 B |                    - |                - |          - |   49872 B |
| DoesNotHaveItems           | 2048  | 67,340.85 ns | 517.260 ns | 483.845 ns | 124.928 ns | 66,598.28 ns | 66,972.51 ns | 67,240.00 ns | 67,765.84 ns | 67,977.25 ns |     14,849.8 |    517.2597 ns |      15.00 |    1.339 |  2.000 |  -0.0579 |   23 | *            | No       | 0.9766 |   1,103 B |                    - |                - |          - |   99072 B |
| **HasItems**                   | **16**    |    **260.61 ns** |   **0.753 ns** |   **0.704 ns** |   **0.182 ns** |    **259.12 ns** |    **260.14 ns** |    **260.83 ns** |    **260.96 ns** |    **261.93 ns** |  **3,837,119.4** |      **0.7529 ns** |      **15.00** |    **2.524** |  **2.000** |  **-0.3235** |    **8** | *****            | **No**       | **0.0014** |     **229 B** |                    **-** |                **-** |          **-** |     **168 B** |
| HasItems                   | 32    |    456.91 ns |   3.945 ns |   3.691 ns |   0.953 ns |    449.25 ns |    454.45 ns |    456.35 ns |    458.78 ns |    463.28 ns |  2,188,620.2 |      3.9454 ns |      15.00 |    2.331 |  2.000 |  -0.0373 |    9 | *            | No       | 0.0019 |     229 B |                    - |                - |          - |     184 B |
| HasItems                   | 64    |    880.45 ns |   2.312 ns |   2.163 ns |   0.558 ns |    877.30 ns |    878.86 ns |    880.08 ns |    881.78 ns |    885.38 ns |  1,135,786.7 |      2.3123 ns |      15.00 |    2.446 |  2.000 |   0.5780 |   11 | *            | No       | 0.0019 |     229 B |                    - |                - |          - |     200 B |
| HasItems                   | 128   |  1,689.76 ns |   4.138 ns |   3.871 ns |   0.999 ns |  1,682.29 ns |  1,687.57 ns |  1,689.71 ns |  1,691.76 ns |  1,696.34 ns |    591,800.5 |      4.1384 ns |      15.00 |    2.208 |  2.000 |  -0.0503 |   13 | *            | No       | 0.0019 |     229 B |                    - |                - |          - |     216 B |
| HasItems                   | 256   |  3,366.38 ns |  25.910 ns |  24.236 ns |   6.258 ns |  3,328.40 ns |  3,340.99 ns |  3,379.25 ns |  3,383.69 ns |  3,390.88 ns |    297,054.9 |     25.9097 ns |      15.00 |    1.474 |  2.000 |  -0.6226 |   15 | *            | No       |      - |     229 B |                    - |                - |          - |     232 B |
| HasItems                   | 512   |  6,749.25 ns |  15.760 ns |  13.160 ns |   3.650 ns |  6,730.11 ns |  6,741.16 ns |  6,745.32 ns |  6,758.54 ns |  6,777.81 ns |    148,164.7 |     15.7602 ns |      13.00 |    2.465 |  2.000 |   0.5568 |   17 | *            | No       |      - |     229 B |                    - |                - |          - |     248 B |
| HasItems                   | 1024  | 13,351.17 ns |  24.655 ns |  21.856 ns |   5.841 ns | 13,322.53 ns | 13,331.94 ns | 13,351.59 ns | 13,363.48 ns | 13,391.64 ns |     74,899.8 |     24.6552 ns |      14.00 |    1.838 |  2.000 |   0.2405 |   19 | *            | No       |      - |     229 B |                    - |                - |          - |     264 B |
| HasItems                   | 2048  | 26,992.61 ns | 193.332 ns | 180.843 ns |  46.693 ns | 26,587.83 ns | 26,964.10 ns | 27,052.15 ns | 27,088.77 ns | 27,233.91 ns |     37,047.2 |    193.3317 ns |      15.00 |    3.395 |  2.000 |  -1.1550 |   21 | *            | No       |      - |     229 B |                    - |                - |          - |     280 B |