## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.GeneralBenchmark.GuidEqualsTest()
       vzeroupper
       vmovups   xmm0,[rcx+118]
       vpcmpeqb  xmm0,xmm0,[rcx+128]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       sete      al
       movzx     eax,al
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 42
```

