```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  Job-LNCZTW : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

```
| Method                                               | Categories         | Mean             | Error           | StdDev          | StdErr         | Min              | Q1               | Median           | Q3               | Max              | Op/s          | CI99.9% Margin  | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0    | Code Size | Completed Work Items | Lock Contentions | Exceptions | Gen1    | Gen2    | Allocated |
|----------------------------------------------------- |------------------- |-----------------:|----------------:|----------------:|---------------:|-----------------:|-----------------:|-----------------:|-----------------:|-----------------:|--------------:|----------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |--------:|----------:|---------------------:|-----------------:|-----------:|--------:|--------:|----------:|
| **&#39;As: IPerson&#39;**                                        | ****                   |        **15.049 ns** |       **0.1005 ns** |       **0.0785 ns** |      **0.0227 ns** |        **14.809 ns** |        **15.062 ns** |        **15.075 ns** |        **15.084 ns** |        **15.090 ns** |  **66,449,574.6** |       **0.1005 ns** |      **12.00** |    **7.287** |  **2.000** |  **-2.3337** |    **6** | *****            | **No**       |       **-** |     **328 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |         **-** |
| **&#39;Clone: Person Array&#39;**                                | ****                   | **8,681,763.578 ns** | **167,822.3987 ns** | **245,991.8960 ns** | **45,679.5483 ns** | **8,315,807.812 ns** | **8,482,501.562 ns** | **8,646,631.250 ns** | **8,822,729.688 ns** | **9,267,350.000 ns** |         **115.2** | **167,822.3987 ns** |      **29.00** |    **2.460** |  **2.000** |   **0.5199** |   **25** | *****            | **No**       | **78.1250** |   **1,131 B** |                    **-** |                **-** |          **-** | **62.5000** | **62.5000** | **4501742 B** |
| **&#39;Clone: Person Collection&#39;**                           | ****                   | **8,298,928.676 ns** | **164,694.8831 ns** | **169,129.5194 ns** | **41,019.9337 ns** | **8,017,693.750 ns** | **8,161,506.250 ns** | **8,278,357.812 ns** | **8,393,643.750 ns** | **8,604,293.750 ns** |         **120.5** | **164,694.8831 ns** |      **17.00** |    **1.979** |  **2.000** |   **0.2360** |   **24** | *****            | **No**       | **78.1250** |     **406 B** |                    **-** |                **-** |          **-** | **62.5000** | **62.5000** | **4490065 B** |
| **&#39;Clone: Person&#39;**                                      | ****                   |     **7,210.155 ns** |     **113.0246 ns** |     **105.7233 ns** |     **27.2976 ns** |     **7,045.865 ns** |     **7,136.902 ns** |     **7,188.195 ns** |     **7,271.346 ns** |     **7,428.939 ns** |     **138,693.3** |     **113.0246 ns** |      **15.00** |    **2.150** |  **2.000** |   **0.2428** |   **18** | *****            | **No**       |  **0.0458** |     **406 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |    **4312 B** |
| **&#39;Clone: PersonRecord*&#39;**                               | ****                   |        **33.053 ns** |       **0.6688 ns** |       **0.7433 ns** |      **0.1705 ns** |        **32.138 ns** |        **32.379 ns** |        **33.043 ns** |        **33.690 ns** |        **34.255 ns** |  **30,254,313.2** |       **0.6688 ns** |      **19.00** |    **1.259** |  **3.333** |   **0.1506** |    **7** | *****            | **No**       |  **0.0010** |     **275 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |      **88 B** |
| **&#39;ComputeSha256Hash: Person&#39;**                          | ****                   |     **6,576.558 ns** |      **21.4396 ns** |      **20.0546 ns** |      **5.1781 ns** |     **6,541.094 ns** |     **6,561.894 ns** |     **6,578.202 ns** |     **6,587.608 ns** |     **6,611.773 ns** |     **152,055.2** |      **21.4396 ns** |      **15.00** |    **1.995** |  **2.000** |  **-0.1386** |   **16** | *****            | **No**       |  **0.0381** |     **767 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |    **3880 B** |
| **&#39;ComputeSha256Hash: PersonRecord&#39;**                    | ****                   |     **6,655.529 ns** |      **19.6156 ns** |      **18.3485 ns** |      **4.7376 ns** |     **6,615.398 ns** |     **6,644.046 ns** |     **6,654.936 ns** |     **6,664.756 ns** |     **6,682.085 ns** |     **150,251.0** |      **19.6156 ns** |      **15.00** |    **2.430** |  **2.000** |  **-0.3243** |   **17** | *****            | **No**       |  **0.0381** |     **767 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |    **3840 B** |
| **&#39;DisposeFields: DataTable&#39;**                           | **Ref Type**           |    **43,183.063 ns** |     **178.6571 ns** |     **167.1159 ns** |     **43.1491 ns** |    **42,901.019 ns** |    **43,064.813 ns** |    **43,173.792 ns** |    **43,344.824 ns** |    **43,394.659 ns** |      **23,157.2** |     **178.6571 ns** |      **15.00** |    **1.406** |  **2.000** |  **-0.2059** |   **19** | *****            | **No**       |  **0.0610** |   **1,723 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |    **9770 B** |
| **&#39;HasProperty: Person&#39;**                                | ****                   |       **264.675 ns** |       **1.0201 ns** |       **0.9542 ns** |      **0.2464 ns** |       **263.080 ns** |       **264.048 ns** |       **264.747 ns** |       **265.314 ns** |       **266.300 ns** |   **3,778,216.4** |       **1.0201 ns** |      **15.00** |    **1.867** |  **2.000** |  **-0.0647** |    **9** | *****            | **No**       |  **0.0024** |     **487 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |     **232 B** |
| **&#39;HasProperty: PersonRecord&#39;**                          | ****                   |       **285.588 ns** |       **1.4885 ns** |       **1.3195 ns** |      **0.3527 ns** |       **283.700 ns** |       **284.740 ns** |       **285.390 ns** |       **286.631 ns** |       **288.343 ns** |   **3,501,548.6** |       **1.4885 ns** |      **14.00** |    **2.108** |  **2.000** |   **0.4185** |   **10** | *****            | **No**       |  **0.0024** |     **487 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |     **240 B** |
| **&#39;IsNotNull: Person&#39;**                                  | ****                   |         **5.471 ns** |       **0.0637 ns** |       **0.0532 ns** |      **0.0148 ns** |         **5.363 ns** |         **5.479 ns** |         **5.493 ns** |         **5.499 ns** |         **5.528 ns** | **182,780,853.0** |       **0.0637 ns** |      **13.00** |    **2.335** |  **2.000** |  **-1.0271** |    **3** | *****            | **No**       |       **-** |     **160 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |         **-** |
| **&#39;IsNotNull: PersonRecord&#39;**                            | ****                   |         **4.907 ns** |       **0.0861 ns** |       **0.0806 ns** |      **0.0208 ns** |         **4.703 ns** |         **4.863 ns** |         **4.942 ns** |         **4.953 ns** |         **4.996 ns** | **203,805,166.5** |       **0.0861 ns** |      **15.00** |    **3.258** |  **2.000** |  **-1.1510** |    **2** | *****            | **No**       |       **-** |     **160 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |         **-** |
| **&#39;IsNull: Person&#39;**                                     | ****                   |         **4.944 ns** |       **0.0446 ns** |       **0.0395 ns** |      **0.0106 ns** |         **4.850 ns** |         **4.938 ns** |         **4.944 ns** |         **4.962 ns** |         **5.004 ns** | **202,278,087.2** |       **0.0446 ns** |      **14.00** |    **3.092** |  **2.000** |  **-0.6309** |    **2** | *****            | **No**       |       **-** |     **160 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |         **-** |
| **&#39;IsNull: PersonRecord&#39;**                               | ****                   |         **4.574 ns** |       **0.0196 ns** |       **0.0183 ns** |      **0.0047 ns** |         **4.553 ns** |         **4.560 ns** |         **4.572 ns** |         **4.585 ns** |         **4.619 ns** | **218,607,010.6** |       **0.0196 ns** |      **15.00** |    **2.917** |  **2.000** |   **0.8538** |    **1** | *****            | **No**       |       **-** |     **160 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |         **-** |
| **&#39;PersonRecord: Duplication with new ID&#39;**              | ****                   |        **63.462 ns** |       **0.5287 ns** |       **0.4946 ns** |      **0.1277 ns** |        **62.736 ns** |        **63.019 ns** |        **63.597 ns** |        **63.731 ns** |        **64.350 ns** |  **15,757,456.8** |       **0.5287 ns** |      **15.00** |    **1.844** |  **2.000** |   **0.1635** |    **8** | *****            | **No**       |  **0.0010** |     **581 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |      **88 B** |
| **&#39;PersonRecord: ToString()&#39;**                           | ****                   |    **58,938.094 ns** |     **254.8425 ns** |     **212.8051 ns** |     **59.0215 ns** |    **58,541.956 ns** |    **58,909.412 ns** |    **58,973.425 ns** |    **59,061.511 ns** |    **59,245.374 ns** |      **16,967.0** |     **254.8425 ns** |      **13.00** |    **2.146** |  **2.000** |  **-0.6635** |   **23** | *****            | **No**       |  **0.7324** |     **298 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |   **84540 B** |
| **&#39;PropertiesToDictionary: Person-Ignore Nulls&#39;**        | ****                   |    **47,335.624 ns** |     **423.6406 ns** |     **396.2737 ns** |    **102.3174 ns** |    **46,833.124 ns** |    **47,010.397 ns** |    **47,390.973 ns** |    **47,655.273 ns** |    **47,925.439 ns** |      **21,125.7** |     **423.6406 ns** |      **15.00** |    **1.281** |  **2.000** |   **0.1239** |   **21** | *****            | **No**       |  **0.4272** |   **2,944 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |   **44608 B** |
| **&#39;PropertiesToDictionary: Person-With Nulls&#39;**          | ****                   |    **46,486.764 ns** |     **411.8542 ns** |     **385.2487 ns** |     **99.4708 ns** |    **45,915.778 ns** |    **46,181.656 ns** |    **46,675.012 ns** |    **46,764.615 ns** |    **47,095.850 ns** |      **21,511.5** |     **411.8542 ns** |      **15.00** |    **1.416** |  **2.000** |  **-0.1087** |   **20** | *****            | **No**       |  **0.4272** |   **2,941 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |   **44608 B** |
| **&#39;PropertiesToDictionary: PersonRecord-Ignore Nulls&#39;**  | ****                   |    **46,429.695 ns** |     **346.3832 ns** |     **324.0070 ns** |     **83.6583 ns** |    **46,021.906 ns** |    **46,192.828 ns** |    **46,383.099 ns** |    **46,661.044 ns** |    **47,095.953 ns** |      **21,537.9** |     **346.3832 ns** |      **15.00** |    **2.000** |  **2.000** |   **0.4955** |   **20** | *****            | **No**       |  **0.4883** |   **2,944 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |   **44835 B** |
| **&#39;PropertiesToDictionary: PersonRecord-With Nulls&#39;**    | ****                   |    **47,674.412 ns** |     **462.6889 ns** |     **432.7995 ns** |    **111.7483 ns** |    **47,059.338 ns** |    **47,320.892 ns** |    **47,664.331 ns** |    **47,999.487 ns** |    **48,591.626 ns** |      **20,975.6** |     **462.6889 ns** |      **15.00** |    **2.119** |  **2.000** |   **0.3187** |   **21** | *****            | **No**       |  **0.4883** |   **2,941 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |   **44838 B** |
| **&#39;PropertiesToString: Person-Ignore Nulls&#39;**            | ****                   |    **57,316.815 ns** |     **267.6239 ns** |     **250.3355 ns** |     **64.6364 ns** |    **56,757.413 ns** |    **57,124.329 ns** |    **57,394.882 ns** |    **57,481.503 ns** |    **57,665.536 ns** |      **17,446.9** |     **267.6239 ns** |      **15.00** |    **2.351** |  **2.000** |  **-0.5490** |   **22** | *****            | **No**       |  **0.8545** |   **1,015 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |   **81848 B** |
| **&#39;PropertiesToString: Person-With Nulls&#39;**              | ****                   |    **56,938.368 ns** |     **179.5133 ns** |     **167.9169 ns** |     **43.3559 ns** |    **56,705.798 ns** |    **56,798.041 ns** |    **56,926.721 ns** |    **57,077.859 ns** |    **57,206.458 ns** |      **17,562.8** |     **179.5133 ns** |      **15.00** |    **1.441** |  **2.000** |   **0.1655** |   **22** | *****            | **No**       |  **0.8545** |   **1,013 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |   **80256 B** |
| **&#39;PropertiesToString: PersonRecord-Ignore Nulls&#39;**      | ****                   |    **58,007.269 ns** |     **242.2284 ns** |     **226.5806 ns** |     **58.5029 ns** |    **57,686.349 ns** |    **57,815.131 ns** |    **58,034.665 ns** |    **58,122.293 ns** |    **58,401.895 ns** |      **17,239.2** |     **242.2284 ns** |      **15.00** |    **1.702** |  **2.000** |   **0.1213** |   **22** | *****            | **No**       |  **0.9155** |   **1,015 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |   **83900 B** |
| **&#39;PropertiesToString: PersonRecord-With Nulls&#39;**        | ****                   |    **58,065.620 ns** |     **199.6870 ns** |     **186.7873 ns** |     **48.2283 ns** |    **57,695.001 ns** |    **57,954.367 ns** |    **58,122.986 ns** |    **58,196.249 ns** |    **58,351.025 ns** |      **17,221.9** |     **199.6870 ns** |      **15.00** |    **2.034** |  **2.000** |  **-0.3852** |   **22** | *****            | **No**       |  **0.9155** |   **1,013 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |   **84108 B** |
| **&#39;StripNull: Person&#39;**                                  | ****                   |    **57,172.923 ns** |     **200.6123 ns** |     **187.6529 ns** |     **48.4518 ns** |    **56,760.391 ns** |    **57,064.648 ns** |    **57,255.222 ns** |    **57,309.158 ns** |    **57,384.415 ns** |      **17,490.8** |     **200.6123 ns** |      **15.00** |    **2.239** |  **2.000** |  **-0.6777** |   **22** | *****            | **No**       |  **0.8545** |     **297 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |   **81456 B** |
| **&#39;Testing Param for Null: != null&#39;**                    | **Ref Type**           |        **10.312 ns** |       **0.1475 ns** |       **0.1380 ns** |      **0.0356 ns** |        **10.146 ns** |        **10.206 ns** |        **10.264 ns** |        **10.450 ns** |        **10.539 ns** |  **96,970,236.0** |       **0.1475 ns** |      **15.00** |    **1.441** |  **2.000** |   **0.4468** |    **5** | *****            | **No**       |  **0.0003** |     **196 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |      **24 B** |
| **&#39;Testing Param for Null: Validate.TryValidateNull()&#39;** | **Ref Type**           |        **10.028 ns** |       **0.0327 ns** |       **0.0290 ns** |      **0.0077 ns** |         **9.936 ns** |        **10.024 ns** |        **10.034 ns** |        **10.042 ns** |        **10.056 ns** |  **99,719,335.3** |       **0.0327 ns** |      **14.00** |    **7.412** |  **2.000** |  **-2.1504** |    **4** | *****            | **No**       |  **0.0003** |     **196 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |      **24 B** |
| **&#39;ToJson: Person - JsonSerializerOptions&#39;**             | **Serialization,JSON** |     **2,295.911 ns** |      **10.7503 ns** |      **10.0558 ns** |      **2.5964 ns** |     **2,278.699 ns** |     **2,290.388 ns** |     **2,296.568 ns** |     **2,302.461 ns** |     **2,312.220 ns** |     **435,557.0** |      **10.7503 ns** |      **15.00** |    **1.837** |  **2.000** |  **-0.0332** |   **14** | *****            | **No**       |  **0.0191** |     **613 B** |                    **-** |                **-** |          **-** |  **0.0153** |       **-** |    **2072 B** |
| **&#39;ToJson: Person&#39;**                                     | **Serialization,JSON** |     **2,012.154 ns** |      **12.9997 ns** |      **12.1599 ns** |      **3.1397 ns** |     **1,994.581 ns** |     **2,003.523 ns** |     **2,013.669 ns** |     **2,023.271 ns** |     **2,031.499 ns** |     **496,979.8** |      **12.9997 ns** |      **15.00** |    **1.455** |  **2.000** |  **-0.0042** |   **12** | *****            | **No**       |  **0.0191** |     **366 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |    **1880 B** |
| **&#39;ToJson: PersonRecord&#39;**                               | **Serialization,JSON** |     **2,130.090 ns** |       **9.0858 ns** |       **8.4988 ns** |      **2.1944 ns** |     **2,112.628 ns** |     **2,124.738 ns** |     **2,131.822 ns** |     **2,137.223 ns** |     **2,144.880 ns** |     **469,463.8** |       **9.0858 ns** |      **15.00** |    **2.170** |  **2.000** |  **-0.2529** |   **13** | *****            | **No**       |  **0.0191** |     **366 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |    **2016 B** |
| **&#39;TryDispose: Person&#39;**                                 | **Ref Type**           |       **531.534 ns** |       **5.8258 ns** |       **5.1644 ns** |      **1.3802 ns** |       **522.911 ns** |       **527.139 ns** |       **532.591 ns** |       **535.713 ns** |       **539.863 ns** |   **1,881,347.7** |       **5.8258 ns** |      **14.00** |    **1.452** |  **2.000** |  **-0.0838** |   **11** | *****            | **No**       |  **0.0315** |   **1,044 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |    **2920 B** |
| **FromJson**                                             | ****                   |     **4,803.825 ns** |      **35.6242 ns** |      **33.3229 ns** |      **8.6039 ns** |     **4,759.765 ns** |     **4,778.202 ns** |     **4,796.198 ns** |     **4,826.101 ns** |     **4,877.212 ns** |     **208,167.4** |      **35.6242 ns** |      **15.00** |    **2.252** |  **2.000** |   **0.5741** |   **15** | *****            | **No**       |  **0.0229** |     **383 B** |                    **-** |                **-** |          **-** |       **-** |       **-** |    **2672 B** |