```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  Job-WWXGEI : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading  Categories=Async  

```
| Method                            | Count | Mean           | Error        | StdDev       | StdErr       | Min            | Q1             | Median         | Q3             | Max            | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Gen0    | Code Size | Completed Work Items | Lock Contentions | Gen1   | Allocated  |
|---------------------------------- |------ |---------------:|-------------:|-------------:|-------------:|---------------:|---------------:|---------------:|---------------:|---------------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|--------:|----------:|---------------------:|-----------------:|-------:|-----------:|
| **&#39;Write &amp; Listen Async&#39;**            | **16**    |    **65,192.5 ns** |    **236.53 ns** |    **221.25 ns** |     **57.13 ns** |    **64,672.1 ns** |    **65,052.9 ns** |    **65,207.9 ns** |    **65,324.2 ns** |    **65,645.7 ns** |  **15,339.2** |      **236.53 ns** |      **15.00** |    **3.349** |  **2.000** |  **-0.2917** |   **19** | *****            | **No**       |          **-** |       **-** |   **2,904 B** |                    **-** |                **-** |      **-** |    **5.06 KB** |
| &#39;Write &amp; Listen Async&#39;            | 32    |   128,874.1 ns |    657.69 ns |    615.20 ns |    158.84 ns |   127,123.3 ns |   128,614.1 ns |   128,902.6 ns |   129,114.1 ns |   129,744.2 ns |   7,759.5 |      657.69 ns |      15.00 |    4.884 |  2.000 |  -1.1734 |   24 | *            | No       |          - |       - |   2,904 B |                    - |                - |      - |    8.23 KB |
| &#39;Write &amp; Listen Async&#39;            | 64    |   254,326.9 ns |  1,191.98 ns |  1,114.98 ns |    287.89 ns |   251,750.9 ns |   253,717.4 ns |   254,500.7 ns |   255,063.8 ns |   255,911.5 ns |   3,931.9 |    1,191.98 ns |      15.00 |    2.607 |  2.000 |  -0.6795 |   28 | *            | No       |          - |       - |   2,904 B |                    - |                - |      - |   15.72 KB |
| &#39;Write &amp; Listen Async&#39;            | 128   |   509,428.4 ns |  2,036.11 ns |  1,904.58 ns |    491.76 ns |   505,323.6 ns |   508,825.9 ns |   509,472.6 ns |   510,391.7 ns |   512,193.9 ns |   1,963.0 |    2,036.11 ns |      15.00 |    2.451 |  2.000 |  -0.3437 |   31 | *            | No       |          - |       - |   2,908 B |                    - |                - |      - |   30.37 KB |
| &#39;Write &amp; Listen Async&#39;            | 256   | 1,018,166.6 ns |  9,067.73 ns |  8,481.96 ns |  2,190.03 ns | 1,003,039.0 ns | 1,012,982.9 ns | 1,022,490.5 ns | 1,024,386.2 ns | 1,030,214.7 ns |     982.2 |    9,067.73 ns |      15.00 |    1.758 |  2.000 |  -0.4967 |   34 | *            | No       |          - |       - |   2,908 B |                    - |                - |      - |   59.65 KB |
| &#39;Write &amp; Listen Async&#39;            | 512   | 2,031,052.3 ns | 12,095.64 ns | 11,314.27 ns |  2,921.33 ns | 2,001,546.9 ns | 2,026,111.9 ns | 2,032,967.2 ns | 2,037,211.7 ns | 2,049,082.8 ns |     492.4 |   12,095.64 ns |      15.00 |    3.738 |  2.000 |  -0.8677 |   37 | *            | No       |          - |       - |   2,902 B |                    - |                - |      - |  117.49 KB |
| &#39;Write &amp; Listen Async&#39;            | 1024  | 4,100,617.4 ns | 24,732.80 ns | 23,135.07 ns |  5,973.45 ns | 4,060,225.8 ns | 4,090,761.3 ns | 4,097,915.6 ns | 4,116,723.0 ns | 4,144,680.5 ns |     243.9 |   24,732.80 ns |      15.00 |    2.153 |  2.000 |   0.0283 |   38 | *            | No       |          - |       - |   2,902 B |                    - |                - |      - |  233.96 KB |
| &#39;Write &amp; Listen Async&#39;            | 2048  | 8,224,183.1 ns | 63,534.31 ns | 59,430.04 ns | 15,344.77 ns | 8,086,295.3 ns | 8,200,357.8 ns | 8,240,231.2 ns | 8,259,301.6 ns | 8,322,785.9 ns |     121.6 |   63,534.31 ns |      15.00 |    2.974 |  2.000 |  -0.7449 |   39 | *            | No       |          - |       - |   2,902 B |                    - |                - |      - |   465.9 KB |
| **&#39;Write &amp; Read Async: IEnumerable&#39;** | **16**    |    **16,915.9 ns** |     **71.60 ns** |     **66.97 ns** |     **17.29 ns** |    **16,805.6 ns** |    **16,861.9 ns** |    **16,915.6 ns** |    **16,964.8 ns** |    **17,036.2 ns** |  **59,116.0** |       **71.60 ns** |      **15.00** |    **1.785** |  **2.000** |  **-0.0149** |    **9** | *****            | **No**       |          **-** |  **0.0916** |     **516 B** |              **16.2115** |           **0.0008** |      **-** |    **8.91 KB** |
| &#39;Write &amp; Read Async: IEnumerable&#39; | 32    |    29,475.6 ns |    127.78 ns |    119.52 ns |     30.86 ns |    29,271.4 ns |    29,394.7 ns |    29,417.2 ns |    29,561.8 ns |    29,695.3 ns |  33,926.4 |      127.78 ns |      15.00 |    1.862 |  2.000 |   0.2448 |   13 | *            | No       |          - |  0.1221 |     516 B |              32.4658 |           0.0001 |      - |   16.15 KB |
| &#39;Write &amp; Read Async: IEnumerable&#39; | 64    |    54,621.9 ns |    117.90 ns |    104.52 ns |     27.93 ns |    54,453.1 ns |    54,542.9 ns |    54,633.4 ns |    54,684.2 ns |    54,822.0 ns |  18,307.7 |      117.90 ns |      14.00 |    1.948 |  2.000 |   0.1370 |   17 | *            | No       |          - |  0.3052 |     516 B |              64.7784 |           0.0001 |      - |    31.9 KB |
| &#39;Write &amp; Read Async: IEnumerable&#39; | 128   |   104,193.0 ns |    301.81 ns |    267.55 ns |     71.51 ns |   103,548.5 ns |   104,144.1 ns |   104,182.5 ns |   104,370.8 ns |   104,602.2 ns |   9,597.6 |      301.81 ns |      14.00 |    3.190 |  2.000 |  -0.6563 |   22 | *            | No       |          - |  0.6104 |     516 B |             129.2216 |                - |      - |   63.08 KB |
| &#39;Write &amp; Read Async: IEnumerable&#39; | 256   |   207,169.7 ns |    897.32 ns |    839.35 ns |    216.72 ns |   205,178.9 ns |   206,762.0 ns |   207,274.1 ns |   207,653.7 ns |   208,331.5 ns |   4,827.0 |      897.32 ns |      15.00 |    2.830 |  2.000 |  -0.6107 |   26 | *            | No       |          - |  0.9766 |     516 B |             258.9429 |                - |      - |  125.28 KB |
| &#39;Write &amp; Read Async: IEnumerable&#39; | 512   |   402,294.9 ns |  1,125.90 ns |    998.08 ns |    266.75 ns |   399,784.1 ns |   401,878.5 ns |   402,384.0 ns |   402,801.9 ns |   403,946.0 ns |   2,485.7 |    1,125.90 ns |      14.00 |    3.572 |  2.000 |  -0.7852 |   29 | *            | No       |          - |  2.4414 |     516 B |             517.8696 |                - |      - |  249.49 KB |
| &#39;Write &amp; Read Async: IEnumerable&#39; | 1024  |   804,424.2 ns |  2,997.09 ns |  2,803.48 ns |    723.86 ns |   799,662.1 ns |   802,636.4 ns |   804,375.6 ns |   806,300.5 ns |   808,540.6 ns |   1,243.1 |    2,997.09 ns |      15.00 |    1.668 |  2.000 |  -0.1243 |   32 | *            | No       |          - |  3.9063 |     516 B |            1036.4043 |                - |      - |  497.64 KB |
| &#39;Write &amp; Read Async: IEnumerable&#39; | 2048  | 1,599,970.2 ns |  8,523.15 ns |  7,555.55 ns |  2,019.31 ns | 1,583,689.6 ns | 1,597,786.4 ns | 1,600,677.0 ns | 1,602,364.7 ns | 1,612,960.7 ns |     625.0 |    8,523.15 ns |      14.00 |    2.639 |  2.000 |  -0.3641 |   35 | *            | No       |          - |  7.8125 |     516 B |            2071.9531 |                - |      - |  993.82 KB |
| **&#39;Write &amp; Read Async&#39;**              | **16**    |    **17,214.6 ns** |     **63.01 ns** |     **58.94 ns** |     **15.22 ns** |    **17,122.1 ns** |    **17,169.6 ns** |    **17,214.6 ns** |    **17,255.3 ns** |    **17,307.0 ns** |  **58,090.1** |       **63.01 ns** |      **15.00** |    **1.603** |  **2.000** |   **0.0641** |   **10** | *****            | **No**       |          **-** |  **0.0916** |     **517 B** |              **16.2261** |           **0.0005** |      **-** |    **9.91 KB** |
| &#39;Write &amp; Read Async&#39;              | 32    |    30,800.6 ns |     65.01 ns |     60.81 ns |     15.70 ns |    30,702.8 ns |    30,770.9 ns |    30,799.5 ns |    30,840.1 ns |    30,927.2 ns |  32,466.9 |       65.01 ns |      15.00 |    2.349 |  2.000 |   0.1254 |   14 | *            | No       |          - |  0.1831 |     517 B |              32.3966 |                - |      - |   18.28 KB |
| &#39;Write &amp; Read Async&#39;              | 64    |    55,924.7 ns |    116.82 ns |     97.55 ns |     27.06 ns |    55,707.6 ns |    55,898.3 ns |    55,922.3 ns |    55,976.8 ns |    56,116.8 ns |  17,881.2 |      116.82 ns |      13.00 |    3.224 |  2.000 |  -0.2341 |   18 | *            | No       |          - |  0.3662 |     517 B |              64.6714 |           0.0001 |      - |   36.26 KB |
| &#39;Write &amp; Read Async&#39;              | 128   |   112,751.7 ns |    284.74 ns |    266.35 ns |     68.77 ns |   112,172.5 ns |   112,587.1 ns |   112,763.9 ns |   112,920.4 ns |   113,184.9 ns |   8,869.0 |      284.74 ns |      15.00 |    2.393 |  2.000 |  -0.2323 |   23 | *            | No       |          - |  0.7324 |     517 B |             129.1337 |           0.0001 |      - |   71.96 KB |
| &#39;Write &amp; Read Async&#39;              | 256   |   219,062.3 ns |    526.72 ns |    492.70 ns |    127.21 ns |   218,327.5 ns |   218,680.4 ns |   219,053.6 ns |   219,421.0 ns |   219,944.5 ns |   4,564.9 |      526.72 ns |      15.00 |    1.728 |  2.000 |   0.1828 |   27 | *            | No       |          - |  1.4648 |     517 B |             259.2976 |                - |      - |  143.14 KB |
| &#39;Write &amp; Read Async&#39;              | 512   |   421,477.9 ns |  1,313.12 ns |  1,164.04 ns |    311.10 ns |   420,071.8 ns |   420,537.6 ns |   421,103.3 ns |   422,036.7 ns |   424,091.0 ns |   2,372.6 |    1,313.12 ns |      14.00 |    2.463 |  2.000 |   0.7915 |   30 | *            | No       |          - |  2.9297 |     517 B |             518.5332 |                - |      - |  285.35 KB |
| &#39;Write &amp; Read Async&#39;              | 1024  |   815,247.1 ns |  2,578.18 ns |  2,285.49 ns |    610.82 ns |   810,082.4 ns |   814,145.0 ns |   815,339.4 ns |   816,131.1 ns |   819,013.3 ns |   1,226.6 |    2,578.18 ns |      14.00 |    2.824 |  2.000 |  -0.3746 |   33 | *            | No       |          - |  5.8594 |     517 B |            1035.7520 |                - |      - |  569.56 KB |
| &#39;Write &amp; Read Async&#39;              | 2048  | 1,671,541.1 ns |  5,586.66 ns |  5,225.76 ns |  1,349.29 ns | 1,663,762.4 ns | 1,666,400.3 ns | 1,671,548.9 ns | 1,676,053.2 ns | 1,678,745.6 ns |     598.3 |    5,586.66 ns |      15.00 |    1.376 |  2.000 |  -0.0736 |   36 | *            | No       |          - | 11.7188 |     517 B |            2073.7539 |                - |      - | 1137.64 KB |
| **&#39;WriteAsync: IEnumerable&#39;**         | **16**    |     **2,297.3 ns** |     **11.26 ns** |      **9.98 ns** |      **2.67 ns** |     **2,284.4 ns** |     **2,289.6 ns** |     **2,293.2 ns** |     **2,304.0 ns** |     **2,318.9 ns** | **435,293.8** |       **11.26 ns** |      **14.00** |    **2.127** |  **2.000** |   **0.5737** |    **1** | *****            | **No**       |          **-** |  **0.0191** |     **510 B** |               **1.0229** |           **0.0000** |      **-** |    **1.88 KB** |
| &#39;WriteAsync: IEnumerable&#39;         | 32    |     3,171.0 ns |     16.77 ns |     15.68 ns |      4.05 ns |     3,147.0 ns |     3,157.5 ns |     3,170.6 ns |     3,181.0 ns |     3,202.5 ns | 315,361.5 |       16.77 ns |      15.00 |    1.981 |  2.000 |   0.3185 |    3 | *            | No       |          - |  0.0191 |     510 B |               1.0226 |                - |      - |    1.88 KB |
| &#39;WriteAsync: IEnumerable&#39;         | 64    |     5,246.0 ns |     31.76 ns |     29.70 ns |      7.67 ns |     5,192.2 ns |     5,225.6 ns |     5,240.8 ns |     5,266.0 ns |     5,303.1 ns | 190,622.8 |       31.76 ns |      15.00 |    2.101 |  2.000 |   0.0875 |    5 | *            | No       |          - |  0.0305 |     510 B |               1.0211 |           0.0000 |      - |    3.13 KB |
| &#39;WriteAsync: IEnumerable&#39;         | 128   |     9,635.4 ns |     50.25 ns |     47.00 ns |     12.14 ns |     9,516.8 ns |     9,610.0 ns |     9,644.2 ns |     9,657.7 ns |     9,702.1 ns | 103,783.8 |       50.25 ns |      15.00 |    3.373 |  2.000 |  -0.7135 |    7 | *            | No       |          - |  0.0458 |     510 B |               1.0098 |                - |      - |    5.38 KB |
| &#39;WriteAsync: IEnumerable&#39;         | 256   |    20,845.3 ns |    185.76 ns |    164.67 ns |     44.01 ns |    20,533.3 ns |    20,759.6 ns |    20,828.4 ns |    20,959.5 ns |    21,162.1 ns |  47,972.4 |      185.76 ns |      14.00 |    2.220 |  2.000 |  -0.0233 |   11 | *            | No       |          - |  0.0916 |     510 B |               1.0003 |           0.0003 |      - |    9.63 KB |
| &#39;WriteAsync: IEnumerable&#39;         | 512   |    37,077.9 ns |    197.48 ns |    184.72 ns |     47.70 ns |    36,807.3 ns |    36,972.9 ns |    37,017.6 ns |    37,169.3 ns |    37,437.4 ns |  26,970.3 |      197.48 ns |      15.00 |    2.002 |  2.000 |   0.3725 |   15 | *            | No       |          - |  0.1831 |     510 B |               1.0001 |                - |      - |   17.88 KB |
| &#39;WriteAsync: IEnumerable&#39;         | 1024  |    67,455.4 ns |    255.59 ns |    239.08 ns |     61.73 ns |    67,029.1 ns |    67,301.3 ns |    67,504.4 ns |    67,624.5 ns |    67,793.9 ns |  14,824.6 |      255.59 ns |      15.00 |    1.711 |  2.000 |  -0.2546 |   20 | *            | No       |          - |  0.3662 |     510 B |               1.0002 |                - |      - |   34.13 KB |
| &#39;WriteAsync: IEnumerable&#39;         | 2048  |   129,219.2 ns |    519.88 ns |    460.86 ns |    123.17 ns |   128,188.2 ns |   128,948.3 ns |   129,292.9 ns |   129,448.8 ns |   129,986.7 ns |   7,738.8 |      519.88 ns |      14.00 |    2.731 |  2.000 |  -0.4431 |   24 | *            | No       |          - |  0.7324 |     510 B |               1.0000 |                - |      - |   66.38 KB |
| **WriteAsync**                        | **16**    |     **2,805.6 ns** |     **23.53 ns** |     **22.01 ns** |      **5.68 ns** |     **2,767.6 ns** |     **2,788.2 ns** |     **2,809.5 ns** |     **2,819.3 ns** |     **2,845.7 ns** | **356,435.5** |       **23.53 ns** |      **15.00** |    **1.896** |  **2.000** |   **0.1242** |    **2** | *****            | **No**       |          **-** |  **0.0305** |     **511 B** |               **1.0121** |                **-** |      **-** |    **2.88 KB** |
| WriteAsync                        | 32    |     4,124.5 ns |     28.83 ns |     26.97 ns |      6.96 ns |     4,082.3 ns |     4,103.5 ns |     4,123.9 ns |     4,141.3 ns |     4,170.0 ns | 242,456.3 |       28.83 ns |      15.00 |    1.650 |  2.000 |  -0.0481 |    4 | *            | No       |          - |  0.0381 |     511 B |               1.0260 |           0.0000 |      - |    4.01 KB |
| WriteAsync                        | 64    |     7,614.8 ns |     26.23 ns |     23.25 ns |      6.21 ns |     7,583.1 ns |     7,599.1 ns |     7,612.5 ns |     7,624.3 ns |     7,661.6 ns | 131,324.0 |       26.23 ns |      14.00 |    2.224 |  2.000 |   0.5059 |    6 | *            | No       |          - |  0.0839 |     511 B |               1.0480 |           0.0000 |      - |    7.51 KB |
| WriteAsync                        | 128   |    14,405.3 ns |     74.96 ns |     70.12 ns |     18.10 ns |    14,308.3 ns |    14,339.8 ns |    14,407.8 ns |    14,461.8 ns |    14,516.2 ns |  69,418.8 |       74.96 ns |      15.00 |    1.335 |  2.000 |   0.1121 |    8 | *            | No       |          - |  0.1526 |     511 B |               1.0044 |           0.0000 |      - |   14.26 KB |
| WriteAsync                        | 256   |    28,931.1 ns |    179.82 ns |    168.20 ns |     43.43 ns |    28,620.6 ns |    28,829.1 ns |    28,909.1 ns |    29,012.8 ns |    29,232.9 ns |  34,564.8 |      179.82 ns |      15.00 |    2.234 |  2.000 |   0.3344 |   12 | *            | No       |          - |  0.3052 |     511 B |               1.0003 |           0.0000 |      - |   27.51 KB |
| WriteAsync                        | 512   |    53,601.9 ns |    172.92 ns |    161.75 ns |     41.76 ns |    53,368.7 ns |    53,491.7 ns |    53,573.3 ns |    53,694.4 ns |    53,969.8 ns |  18,656.0 |      172.92 ns |      15.00 |    2.495 |  2.000 |   0.5429 |   16 | *            | No       |          - |  0.5493 |     511 B |               1.0003 |           0.0001 |      - |   53.76 KB |
| WriteAsync                        | 1024  |    99,718.9 ns |    397.30 ns |    371.64 ns |     95.96 ns |    99,242.4 ns |    99,433.0 ns |    99,716.2 ns |    99,887.5 ns |   100,500.2 ns |  10,028.2 |      397.30 ns |      15.00 |    2.381 |  2.000 |   0.6774 |   21 | *            | No       |          - |  1.0986 |     511 B |               1.0001 |                - |      - |  106.01 KB |
| WriteAsync                        | 2048  |   195,154.2 ns |    693.32 ns |    648.53 ns |    167.45 ns |   193,794.1 ns |   194,919.2 ns |   195,125.8 ns |   195,593.4 ns |   196,307.1 ns |   5,124.2 |      693.32 ns |      15.00 |    2.436 |  2.000 |  -0.3794 |   25 | *            | No       |          - |  2.1973 |     511 B |               1.0000 |                - | 0.2441 |  210.26 KB |