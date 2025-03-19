## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.GeneralBenchmark.GuidEqualsTest()
       vzeroupper
       vmovups   xmm0,[rcx+128]
       vpcmpeqb  xmm0,xmm0,[rcx+138]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       sete      al
       movzx     eax,al
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 42
```

