```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4291/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.300-preview.24203.14
  [Host]     : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  Job-XJVIUY : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

```
| Method                 | Count | Mean             | Error          | StdDev         | StdErr         | Median           | Min              | Q1               | Q3               | Max              | Op/s          | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Code Size | Completed Work Items | Lock Contentions | Gen0   | Allocated |
|----------------------- |------ |-----------------:|---------------:|---------------:|---------------:|-----------------:|-----------------:|-----------------:|-----------------:|-----------------:|--------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|----------:|---------------------:|-----------------:|-------:|----------:|
| **&#39;AddRange: List&#39;**       | **16**    |     **1,811.444 ns** |      **8.2832 ns** |      **7.7481 ns** |      **2.0006 ns** |     **1,809.564 ns** |     **1,800.731 ns** |     **1,805.908 ns** |     **1,818.296 ns** |     **1,824.401 ns** |     **552,045.6** |      **8.2832 ns** |      **15.00** |    **1.671** |  **2.000** |   **0.3567** |    **6** | *****            | **No**       |          **-** |   **2,943 B** |                    **-** |                **-** | **0.0095** |     **896 B** |
| &#39;AddRange: List&#39;       | 32    |     3,925.830 ns |     19.0393 ns |     17.8093 ns |      4.5984 ns |     3,922.876 ns |     3,894.132 ns |     3,916.221 ns |     3,937.972 ns |     3,961.367 ns |     254,723.2 |     19.0393 ns |      15.00 |    2.282 |  2.000 |   0.2391 |    7 | *            | No       |          - |   2,948 B |                    - |                - | 0.0076 |     896 B |
| &#39;AddRange: List&#39;       | 64    |    10,757.768 ns |     85.2121 ns |     79.7075 ns |     20.5804 ns |    10,734.650 ns |    10,686.807 ns |    10,692.188 ns |    10,780.015 ns |    10,911.739 ns |      92,956.1 |     85.2121 ns |      15.00 |    2.273 |  2.000 |   0.9254 |    8 | *            | No       |          - |   2,943 B |                    - |                - | 0.0153 |    1688 B |
| &#39;AddRange: List&#39;       | 128   |    31,410.925 ns |     98.3098 ns |     82.0931 ns |     22.7685 ns |    31,408.926 ns |    31,305.374 ns |    31,353.629 ns |    31,467.319 ns |    31,575.211 ns |      31,836.1 |     98.3098 ns |      13.00 |    1.996 |  2.000 |   0.3931 |    9 | *            | No       |          - |   2,948 B |                    - |                - |      - |    3520 B |
| &#39;AddRange: List&#39;       | 256   |   105,321.418 ns |    521.2037 ns |    487.5343 ns |    125.8808 ns |   105,157.983 ns |   104,659.570 ns |   105,039.197 ns |   105,647.668 ns |   106,410.107 ns |       9,494.7 |    521.2037 ns |      15.00 |    2.400 |  2.000 |   0.6691 |   10 | *            | No       |          - |   2,948 B |                    - |                - |      - |    7512 B |
| &#39;AddRange: List&#39;       | 512   |   377,560.713 ns |  2,178.4853 ns |  2,037.7565 ns |    526.1465 ns |   377,170.801 ns |   375,324.463 ns |   375,887.085 ns |   378,788.867 ns |   382,574.023 ns |       2,648.6 |  2,178.4853 ns |      15.00 |    2.904 |  2.000 |   0.8671 |   11 | *            | No       |          - |   2,970 B |                    - |                - |      - |   16184 B |
| &#39;AddRange: List&#39;       | 1024  | 1,311,178.118 ns | 13,136.1151 ns | 12,287.5302 ns |  3,172.6267 ns | 1,307,287.012 ns | 1,292,315.137 ns | 1,304,677.832 ns | 1,322,139.551 ns | 1,330,208.301 ns |         762.7 | 13,136.1151 ns |      15.00 |    1.630 |  2.000 |   0.0915 |   12 | *            | No       |          - |   2,972 B |                    - |                - |      - |   34616 B |
| &#39;AddRange: List&#39;       | 2048  | 5,829,184.609 ns | 96,582.6855 ns | 90,343.5039 ns | 23,326.5924 ns | 5,829,083.984 ns | 5,706,580.078 ns | 5,756,605.078 ns | 5,885,152.734 ns | 5,984,216.797 ns |         171.6 | 96,582.6855 ns |      15.00 |    1.724 |  2.000 |   0.1208 |   13 | *            | No       |          - |   2,972 B |                    - |                - |      - |   73294 B |
| **&#39;HasItems: With Count&#39;** | **16**    |         **1.898 ns** |      **0.0114 ns** |      **0.0101 ns** |      **0.0027 ns** |         **1.899 ns** |         **1.876 ns** |         **1.892 ns** |         **1.906 ns** |         **1.911 ns** | **526,847,325.5** |      **0.0114 ns** |      **14.00** |    **2.285** |  **2.000** |  **-0.5939** |    **2** | *****            | **No**       |          **-** |      **93 B** |                    **-** |                **-** |      **-** |         **-** |
| &#39;HasItems: With Count&#39; | 32    |         1.671 ns |      0.0105 ns |      0.0098 ns |      0.0025 ns |         1.668 ns |         1.660 ns |         1.664 ns |         1.677 ns |         1.691 ns | 598,343,245.0 |      0.0105 ns |      15.00 |    2.026 |  2.000 |   0.7109 |    1 | *            | No       |          - |      93 B |                    - |                - |      - |         - |
| &#39;HasItems: With Count&#39; | 64    |         1.652 ns |      0.0183 ns |      0.0171 ns |      0.0044 ns |         1.648 ns |         1.630 ns |         1.636 ns |         1.666 ns |         1.678 ns | 605,383,466.5 |      0.0183 ns |      15.00 |    1.352 |  2.000 |   0.1545 |    1 | *            | No       |          - |      93 B |                    - |                - |      - |         - |
| &#39;HasItems: With Count&#39; | 128   |         1.651 ns |      0.0071 ns |      0.0063 ns |      0.0017 ns |         1.650 ns |         1.642 ns |         1.647 ns |         1.652 ns |         1.665 ns | 605,627,089.3 |      0.0071 ns |      14.00 |    2.589 |  2.000 |   0.8357 |    1 | *            | No       |          - |      93 B |                    - |                - |      - |         - |
| &#39;HasItems: With Count&#39; | 256   |         2.258 ns |      0.0742 ns |      0.0854 ns |      0.0191 ns |         2.282 ns |         2.078 ns |         2.211 ns |         2.311 ns |         2.375 ns | 442,782,149.4 |      0.0742 ns |      20.00 |    2.529 |  2.000 |  -0.8178 |    3 | *            | No       |          - |      93 B |                    - |                - |      - |         - |
| &#39;HasItems: With Count&#39; | 512   |         1.651 ns |      0.0089 ns |      0.0079 ns |      0.0021 ns |         1.649 ns |         1.642 ns |         1.645 ns |         1.657 ns |         1.667 ns | 605,566,291.6 |      0.0089 ns |      14.00 |    1.803 |  2.000 |   0.4955 |    1 | *            | No       |          - |      93 B |                    - |                - |      - |         - |
| &#39;HasItems: With Count&#39; | 1024  |         1.652 ns |      0.0119 ns |      0.0111 ns |      0.0029 ns |         1.648 ns |         1.637 ns |         1.644 ns |         1.663 ns |         1.669 ns | 605,271,734.6 |      0.0119 ns |      15.00 |    1.285 |  2.000 |   0.1777 |    1 | *            | No       |          - |      93 B |                    - |                - |      - |         - |
| &#39;HasItems: With Count&#39; | 2048  |         1.885 ns |      0.0091 ns |      0.0080 ns |      0.0022 ns |         1.884 ns |         1.871 ns |         1.881 ns |         1.891 ns |         1.900 ns | 530,369,543.6 |      0.0091 ns |      14.00 |    1.983 |  2.000 |   0.1202 |    2 | *            | No       |          - |      93 B |                    - |                - |      - |         - |
| **HasItems**               | **16**    |         **1.668 ns** |      **0.0135 ns** |      **0.0112 ns** |      **0.0031 ns** |         **1.664 ns** |         **1.655 ns** |         **1.660 ns** |         **1.670 ns** |         **1.697 ns** | **599,655,219.4** |      **0.0135 ns** |      **13.00** |    **4.067** |  **2.000** |   **1.2650** |    **1** | *****            | **No**       |          **-** |      **92 B** |                    **-** |                **-** |      **-** |         **-** |
| HasItems               | 32    |         1.649 ns |      0.0104 ns |      0.0092 ns |      0.0025 ns |         1.648 ns |         1.635 ns |         1.640 ns |         1.657 ns |         1.664 ns | 606,465,975.7 |      0.0104 ns |      14.00 |    1.372 |  2.000 |   0.0750 |    1 | *            | No       |          - |      92 B |                    - |                - |      - |         - |
| HasItems               | 64    |         1.679 ns |      0.0151 ns |      0.0141 ns |      0.0036 ns |         1.675 ns |         1.660 ns |         1.668 ns |         1.690 ns |         1.703 ns | 595,479,118.1 |      0.0151 ns |      15.00 |    1.583 |  2.000 |   0.3687 |    1 | *            | No       |          - |      92 B |                    - |                - |      - |         - |
| HasItems               | 128   |         1.892 ns |      0.0164 ns |      0.0145 ns |      0.0039 ns |         1.893 ns |         1.870 ns |         1.880 ns |         1.901 ns |         1.916 ns | 528,579,820.4 |      0.0164 ns |      14.00 |    1.761 |  2.000 |   0.0667 |    2 | *            | No       |          - |      92 B |                    - |                - |      - |         - |
| HasItems               | 256   |         1.671 ns |      0.0142 ns |      0.0133 ns |      0.0034 ns |         1.669 ns |         1.655 ns |         1.661 ns |         1.679 ns |         1.703 ns | 598,319,808.2 |      0.0142 ns |      15.00 |    2.732 |  2.000 |   0.7255 |    1 | *            | No       |          - |      92 B |                    - |                - |      - |         - |
| HasItems               | 512   |         1.649 ns |      0.0086 ns |      0.0076 ns |      0.0020 ns |         1.648 ns |         1.641 ns |         1.645 ns |         1.651 ns |         1.665 ns | 606,251,082.7 |      0.0086 ns |      14.00 |    2.183 |  2.000 |   0.8172 |    1 | *            | No       |          - |      92 B |                    - |                - |      - |         - |
| HasItems               | 1024  |         3.556 ns |      0.0223 ns |      0.0198 ns |      0.0053 ns |         3.546 ns |         3.530 ns |         3.544 ns |         3.571 ns |         3.597 ns | 281,225,848.6 |      0.0223 ns |      14.00 |    2.128 |  2.000 |   0.7020 |    5 | *            | No       |          - |      92 B |                    - |                - |      - |         - |
| HasItems               | 2048  |         3.472 ns |      0.1002 ns |      0.2401 ns |      0.0291 ns |         3.345 ns |         3.295 ns |         3.310 ns |         3.569 ns |         4.073 ns | 288,023,614.2 |      0.1002 ns |      68.00 |    3.564 |  2.133 |   1.3863 |    4 | *            | No       |          - |      92 B |                    - |                - |      - |         - |