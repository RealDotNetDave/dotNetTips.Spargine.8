## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.GeneralBenchmark.GuidEqualsTest()
       sub       rsp,28
       vzeroupper
       vmovups   xmm0,[rcx+128]
       vpcmpeqb  xmm0,xmm0,[rcx+138]
       vpmovmskb edx,xmm0
       cmp       edx,0FFFF
       sete      dl
       movzx     edx,dl
       call      qword ptr [7FF815265ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,28
       ret
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF814E1F390],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF815265EF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

