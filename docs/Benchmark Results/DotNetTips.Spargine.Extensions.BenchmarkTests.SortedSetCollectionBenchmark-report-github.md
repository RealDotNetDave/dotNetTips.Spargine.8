```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4651/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.302
  [Host]     : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  Job-ZSORKR : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

```
| Method                     | Count | Mean            | Error       | StdDev      | StdErr      | Median          | Min             | Q1              | Q3              | Max             | Op/s            | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Code Size | Exceptions | Completed Work Items | Lock Contentions | Allocated |
|--------------------------- |------ |----------------:|------------:|------------:|------------:|----------------:|----------------:|----------------:|----------------:|----------------:|----------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|----------:|-----------:|---------------------:|-----------------:|----------:|
| **&#39;HasItems: With Predicate&#39;** | **16**    |      **68.2882 ns** |   **0.3683 ns** |   **0.3075 ns** |   **0.0853 ns** |      **68.3053 ns** |      **67.7372 ns** |      **68.1671 ns** |      **68.3887 ns** |      **68.9451 ns** |    **14,643,817.3** |      **0.3683 ns** |      **13.00** |    **2.688** |  **2.000** |   **0.3228** |    **6** | *****            | **No**       | **0.0018** |     **810 B** |          **-** |                    **-** |                **-** |     **168 B** |
| &#39;HasItems: With Predicate&#39; | 32    |      78.1587 ns |   1.5601 ns |   2.4745 ns |   0.4308 ns |      77.0841 ns |      75.6438 ns |      76.5416 ns |      78.8828 ns |      85.2699 ns |    12,794,478.4 |      1.5601 ns |      33.00 |    3.581 |  2.000 |   1.3014 |    7 | *            | No       | 0.0019 |     810 B |          - |                    - |                - |     184 B |
| &#39;HasItems: With Predicate&#39; | 64    |      83.4052 ns |   0.6892 ns |   0.5755 ns |   0.1596 ns |      83.2370 ns |      82.8179 ns |      82.9282 ns |      83.7803 ns |      84.8620 ns |    11,989,659.0 |      0.6892 ns |      13.00 |    3.467 |  2.000 |   1.1021 |    8 | *            | No       | 0.0021 |     807 B |          - |                    - |                - |     200 B |
| &#39;HasItems: With Predicate&#39; | 128   |      82.9226 ns |   0.4958 ns |   0.4396 ns |   0.1175 ns |      82.9681 ns |      81.8904 ns |      82.7876 ns |      83.2178 ns |      83.4665 ns |    12,059,444.0 |      0.4958 ns |      14.00 |    3.063 |  2.000 |  -0.8871 |    8 | *            | No       | 0.0023 |     807 B |          - |                    - |                - |     216 B |
| &#39;HasItems: With Predicate&#39; | 256   |      93.4149 ns |   0.5266 ns |   0.4668 ns |   0.1248 ns |      93.3870 ns |      92.5679 ns |      93.1644 ns |      93.8090 ns |      94.0371 ns |    10,704,930.8 |      0.5266 ns |      14.00 |    1.822 |  2.000 |  -0.2378 |    9 | *            | No       | 0.0025 |     810 B |          - |                    - |                - |     232 B |
| &#39;HasItems: With Predicate&#39; | 512   |      97.6861 ns |   0.2623 ns |   0.2326 ns |   0.0622 ns |      97.7124 ns |      97.2471 ns |      97.5534 ns |      97.8554 ns |      98.0286 ns |    10,236,870.7 |      0.2623 ns |      14.00 |    2.234 |  2.000 |  -0.5761 |   10 | *            | No       | 0.0026 |     811 B |          - |                    - |                - |     248 B |
| &#39;HasItems: With Predicate&#39; | 1024  |      98.3001 ns |   0.5581 ns |   0.5221 ns |   0.1348 ns |      98.1466 ns |      97.6679 ns |      97.8874 ns |      98.6230 ns |      99.4357 ns |    10,172,928.6 |      0.5581 ns |      15.00 |    2.273 |  2.000 |   0.6642 |   10 | *            | No       | 0.0029 |     807 B |          - |                    - |                - |     264 B |
| &#39;HasItems: With Predicate&#39; | 2048  |     102.3316 ns |   0.6392 ns |   0.5979 ns |   0.1544 ns |     102.2759 ns |     101.2945 ns |     101.9281 ns |     102.6507 ns |     103.5995 ns |     9,772,150.8 |      0.6392 ns |      15.00 |    2.442 |  2.000 |   0.3622 |   11 | *            | No       | 0.0030 |     807 B |          - |                    - |                - |     280 B |
| **DoesNotHaveItems**           | **16**    |       **0.2748 ns** |   **0.0017 ns** |   **0.0016 ns** |   **0.0004 ns** |       **0.2750 ns** |       **0.2721 ns** |       **0.2733 ns** |       **0.2761 ns** |       **0.2768 ns** | **3,639,656,384.4** |      **0.0017 ns** |      **15.00** |    **1.339** |  **2.000** |  **-0.0945** |    **3** | *****            | **No**       |      **-** |      **86 B** |          **-** |                    **-** |                **-** |         **-** |
| DoesNotHaveItems           | 32    |       0.3372 ns |   0.0355 ns |   0.0613 ns |   0.0099 ns |       0.2997 ns |       0.2911 ns |       0.2966 ns |       0.4251 ns |       0.4406 ns | 2,965,925,044.3 |      0.0355 ns |      38.00 |    1.787 |  2.815 |   0.8791 |    4 | *            | No       |      - |      86 B |          - |                    - |                - |         - |
| DoesNotHaveItems           | 64    |       0.2594 ns |   0.0052 ns |   0.0046 ns |   0.0012 ns |       0.2593 ns |       0.2482 ns |       0.2573 ns |       0.2630 ns |       0.2654 ns | 3,855,417,334.4 |      0.0052 ns |      14.00 |    3.075 |  2.000 |  -0.8341 |    1 | *            | No       |      - |      86 B |          - |                    - |                - |         - |
| DoesNotHaveItems           | 128   |       0.3079 ns |   0.0144 ns |   0.0127 ns |   0.0034 ns |       0.3044 ns |       0.2936 ns |       0.2987 ns |       0.3129 ns |       0.3338 ns | 3,247,407,041.8 |      0.0144 ns |      14.00 |    2.507 |  2.000 |   0.9226 |    4 | *            | No       |      - |      86 B |          - |                    - |                - |         - |
| DoesNotHaveItems           | 256   |       0.3006 ns |   0.0039 ns |   0.0037 ns |   0.0009 ns |       0.2994 ns |       0.2934 ns |       0.2984 ns |       0.3032 ns |       0.3076 ns | 3,326,931,397.9 |      0.0039 ns |      15.00 |    2.253 |  2.000 |   0.1033 |    4 | *            | No       |      - |      86 B |          - |                    - |                - |         - |
| DoesNotHaveItems           | 512   |       0.2549 ns |   0.0035 ns |   0.0031 ns |   0.0008 ns |       0.2550 ns |       0.2486 ns |       0.2533 ns |       0.2573 ns |       0.2600 ns | 3,923,247,242.1 |      0.0035 ns |      14.00 |    2.362 |  2.000 |  -0.4045 |    1 | *            | No       |      - |      86 B |          - |                    - |                - |         - |
| DoesNotHaveItems           | 1024  |       0.2973 ns |   0.0034 ns |   0.0028 ns |   0.0008 ns |       0.2961 ns |       0.2935 ns |       0.2956 ns |       0.3004 ns |       0.3016 ns | 3,364,169,499.9 |      0.0034 ns |      13.00 |    1.382 |  2.000 |   0.2231 |    4 | *            | No       |      - |      86 B |          - |                    - |                - |         - |
| DoesNotHaveItems           | 2048  |       0.2533 ns |   0.0050 ns |   0.0047 ns |   0.0012 ns |       0.2516 ns |       0.2474 ns |       0.2494 ns |       0.2567 ns |       0.2625 ns | 3,948,167,815.6 |      0.0050 ns |      15.00 |    1.784 |  2.000 |   0.4629 |    1 | *            | No       |      - |      86 B |          - |                    - |                - |         - |
| **HasItems**                   | **16**    |       **0.2581 ns** |   **0.0055 ns** |   **0.0049 ns** |   **0.0013 ns** |       **0.2577 ns** |       **0.2521 ns** |       **0.2534 ns** |       **0.2616 ns** |       **0.2671 ns** | **3,875,157,130.6** |      **0.0055 ns** |      **14.00** |    **1.717** |  **2.000** |   **0.3539** |    **1** | *****            | **No**       |      **-** |      **83 B** |          **-** |                    **-** |                **-** |         **-** |
| HasItems                   | 32    |       0.3034 ns |   0.0048 ns |   0.0037 ns |   0.0011 ns |       0.3026 ns |       0.2997 ns |       0.3010 ns |       0.3035 ns |       0.3124 ns | 3,296,102,370.3 |      0.0048 ns |      12.00 |    3.460 |  2.000 |   1.2958 |    4 | *            | No       |      - |      83 B |          - |                    - |                - |         - |
| HasItems                   | 64    |       0.2670 ns |   0.0098 ns |   0.0082 ns |   0.0023 ns |       0.2663 ns |       0.2547 ns |       0.2614 ns |       0.2728 ns |       0.2817 ns | 3,745,344,149.8 |      0.0098 ns |      13.00 |    1.830 |  2.000 |   0.2226 |    2 | *            | No       |      - |      83 B |          - |                    - |                - |         - |
| HasItems                   | 128   |       0.7260 ns |   0.0554 ns |   0.1489 ns |   0.0162 ns |       0.7729 ns |       0.2560 ns |       0.7703 ns |       0.7757 ns |       0.7865 ns | 1,377,391,932.2 |      0.0554 ns |      84.00 |    8.422 |  2.000 |  -2.7095 |    5 | *            | No       |      - |      83 B |          - |                    - |                - |         - |
| HasItems                   | 256   |       0.2574 ns |   0.0067 ns |   0.0056 ns |   0.0016 ns |       0.2592 ns |       0.2484 ns |       0.2524 ns |       0.2606 ns |       0.2655 ns | 3,885,111,250.2 |      0.0067 ns |      13.00 |    1.572 |  2.000 |  -0.1189 |    1 | *            | No       |      - |      83 B |          - |                    - |                - |         - |
| HasItems                   | 512   |       0.2546 ns |   0.0042 ns |   0.0037 ns |   0.0010 ns |       0.2551 ns |       0.2439 ns |       0.2543 ns |       0.2565 ns |       0.2602 ns | 3,927,666,307.0 |      0.0042 ns |      14.00 |    5.238 |  2.000 |  -1.4139 |    1 | *            | No       |      - |      83 B |          - |                    - |                - |         - |
| HasItems                   | 1024  |       0.3018 ns |   0.0042 ns |   0.0037 ns |   0.0010 ns |       0.3014 ns |       0.2949 ns |       0.2989 ns |       0.3056 ns |       0.3073 ns | 3,312,956,894.2 |      0.0042 ns |      14.00 |    1.693 |  2.000 |  -0.1067 |    4 | *            | No       |      - |      83 B |          - |                    - |                - |         - |
| HasItems                   | 2048  |       0.3011 ns |   0.0060 ns |   0.0056 ns |   0.0014 ns |       0.3027 ns |       0.2917 ns |       0.2974 ns |       0.3042 ns |       0.3112 ns | 3,320,885,238.0 |      0.0060 ns |      15.00 |    2.018 |  2.000 |  -0.1331 |    4 | *            | No       |      - |      83 B |          - |                    - |                - |         - |
| **ToImmutableSortedSet**       | **16**    |     **866.7862 ns** |   **3.9941 ns** |   **3.7361 ns** |   **0.9646 ns** |     **866.5646 ns** |     **860.7146 ns** |     **864.3161 ns** |     **868.7449 ns** |     **874.0747 ns** |     **1,153,687.1** |      **3.9941 ns** |      **15.00** |    **2.095** |  **2.000** |   **0.2499** |   **12** | *****            | **No**       | **0.0134** |     **432 B** |          **-** |                    **-** |                **-** |    **1224 B** |
| ToImmutableSortedSet       | 32    |   1,886.8333 ns |  11.5684 ns |  10.8211 ns |   2.7940 ns |   1,888.0363 ns |   1,870.4800 ns |   1,876.9468 ns |   1,893.8112 ns |   1,902.2514 ns |       529,988.5 |     11.5684 ns |      15.00 |    1.546 |  2.000 |  -0.1736 |   13 | *            | No       | 0.0229 |     432 B |          - |                    - |                - |    2136 B |
| ToImmutableSortedSet       | 64    |   4,490.4673 ns |  48.3759 ns |  42.8840 ns |  11.4612 ns |   4,473.9765 ns |   4,436.0435 ns |   4,462.3039 ns |   4,511.1649 ns |   4,593.8278 ns |       222,694.0 |     48.3759 ns |      14.00 |    2.914 |  2.000 |   0.8472 |   14 | *            | No       | 0.0381 |     432 B |          - |                    - |                - |    3944 B |
| ToImmutableSortedSet       | 128   |   8,492.4497 ns |  33.1222 ns |  29.3619 ns |   7.8473 ns |   8,489.4463 ns |   8,438.4369 ns |   8,479.3045 ns |   8,507.8915 ns |   8,553.7201 ns |       117,751.7 |     33.1222 ns |      14.00 |    2.514 |  2.000 |   0.2223 |   15 | *            | No       | 0.0763 |     432 B |          - |                    - |                - |    7544 B |
| ToImmutableSortedSet       | 256   |  18,807.7775 ns |  82.7606 ns |  77.4144 ns |  19.9883 ns |  18,800.4761 ns |  18,699.4110 ns |  18,748.3627 ns |  18,848.5764 ns |  18,971.4935 ns |        53,169.5 |     82.7606 ns |      15.00 |    2.191 |  2.000 |   0.5248 |   16 | *            | No       | 0.1526 |     432 B |          - |                    - |                - |   14728 B |
| ToImmutableSortedSet       | 512   |  43,027.6038 ns | 239.3389 ns | 223.8777 ns |  57.8050 ns |  42,933.5388 ns |  42,787.8357 ns |  42,868.5089 ns |  43,156.3416 ns |  43,514.2639 ns |        23,240.9 |    239.3389 ns |      15.00 |    2.504 |  2.000 |   0.8564 |   17 | *            | No       | 0.3052 |     432 B |          - |                    - |                - |   29080 B |
| ToImmutableSortedSet       | 1024  |  97,585.2572 ns | 398.8740 ns | 373.1070 ns |  96.3358 ns |  97,490.3076 ns |  97,115.5151 ns |  97,351.8555 ns |  97,854.1321 ns |  98,322.7783 ns |        10,247.4 |    398.8740 ns |      15.00 |    1.972 |  2.000 |   0.4863 |   18 | *            | No       | 0.6104 |     432 B |          - |                    - |                - |   57768 B |
| ToImmutableSortedSet       | 2048  | 219,371.6675 ns | 909.5549 ns | 850.7982 ns | 219.6752 ns | 219,411.2183 ns | 218,023.0103 ns | 218,716.0767 ns | 220,078.0518 ns | 220,651.4771 ns |         4,558.5 |    909.5549 ns |      15.00 |    1.500 |  2.000 |   0.1187 |   19 | *            | No       | 1.2207 |     442 B |          - |                    - |                - |  115128 B |