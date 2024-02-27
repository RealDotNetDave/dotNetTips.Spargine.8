## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+188]
       mov       rcx,rbx
       call      qword ptr [7FF814E850C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
       mov       r8d,eax
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
       call      qword ptr [7FF8153B4060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF8153B4090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814E4F390],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF814FC3688],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-28],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815394C38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L02:
       mov       rcx,2869D8B5210
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-18]
       mov       r9,2869D8A0008
       call      qword ptr [7FF8153B40A8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-38],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815394C60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M02_L04:
       lea       rcx,[rbp-18]
       mov       rdx,[rbp-38]
       call      qword ptr [7FF814E86F40]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       je        short M02_L05
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M02_L08
M02_L05:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L06
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+18]
       mov       [rbp-48],rdx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815394C60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L07:
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-48]
       call      CORINFO_HELP_BOX
       mov       rcx,rax
       call      qword ptr [7FF814F9E088]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-4C],eax
       mov       eax,[rbp-4C]
       cmp       eax,[rbp+20]
       sete      al
       movzx     eax,al
       mov       [rbp-1C],eax
       nop
M02_L08:
       mov       eax,[rbp-1C]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 391
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
       cmp       dword ptr [7FF814E4F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8153B5308]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+188]
       mov       rcx,rbx
       call      qword ptr [7FF814E54BB8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
       mov       r8d,eax
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
       call      qword ptr [7FF815385F38]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF815385F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814E1F390],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF814F93688],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-28],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815366960
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L02:
       mov       rcx,3135EA55230
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-18]
       mov       r9,3135EA40008
       call      qword ptr [7FF815385F80]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-38],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815366988
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M02_L04:
       lea       rcx,[rbp-18]
       mov       rdx,[rbp-38]
       call      qword ptr [7FF814E56A30]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       je        short M02_L05
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M02_L08
M02_L05:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L06
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+18]
       mov       [rbp-48],rdx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815366988
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L07:
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-48]
       call      CORINFO_HELP_BOX
       mov       rcx,rax
       call      qword ptr [7FF814F6E088]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-4C],eax
       mov       eax,[rbp-4C]
       cmp       eax,[rbp+20]
       sete      al
       movzx     eax,al
       mov       [rbp-1C],eax
       nop
M02_L08:
       mov       eax,[rbp-1C]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 391
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
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8153871E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+188]
       mov       rcx,rbx
       call      qword ptr [7FF814E650C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
       mov       r8d,eax
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
       call      qword ptr [7FF815395F38]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF815395F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814E2F390],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF814FA3688],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-28],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815376960
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L02:
       mov       rcx,29D58795230
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-18]
       mov       r9,29D58780008
       call      qword ptr [7FF815395F80]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-38],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815376988
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M02_L04:
       lea       rcx,[rbp-18]
       mov       rdx,[rbp-38]
       call      qword ptr [7FF814E66F40]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       je        short M02_L05
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M02_L08
M02_L05:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L06
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+18]
       mov       [rbp-48],rdx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815376988
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L07:
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-48]
       call      CORINFO_HELP_BOX
       mov       rcx,rax
       call      qword ptr [7FF814F7E088]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-4C],eax
       mov       eax,[rbp-4C]
       cmp       eax,[rbp+20]
       sete      al
       movzx     eax,al
       mov       [rbp-1C],eax
       nop
M02_L08:
       mov       eax,[rbp-1C]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 391
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
       cmp       dword ptr [7FF814E2F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8153971E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+188]
       mov       rcx,rbx
       call      qword ptr [7FF814E54BB8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
       mov       r8d,eax
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
       call      qword ptr [7FF8153ACD50]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF8153ACD80]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814E1F390],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF814F93688],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-28],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815396690
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L02:
       mov       rcx,279F4EE5280
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-18]
       mov       r9,279F4ED0008
       call      qword ptr [7FF8153ACD98]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-38],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF8153966B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M02_L04:
       lea       rcx,[rbp-18]
       mov       rdx,[rbp-38]
       call      qword ptr [7FF814E56A30]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       je        short M02_L05
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M02_L08
M02_L05:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L06
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+18]
       mov       [rbp-48],rdx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF8153966B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L07:
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-48]
       call      CORINFO_HELP_BOX
       mov       rcx,rax
       call      qword ptr [7FF814F6E088]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-4C],eax
       mov       eax,[rbp-4C]
       cmp       eax,[rbp+20]
       sete      al
       movzx     eax,al
       mov       [rbp-1C],eax
       nop
M02_L08:
       mov       eax,[rbp-1C]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 391
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
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8153ADFF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+188]
       mov       rcx,rbx
       call      qword ptr [7FF814E650C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
       mov       r8d,eax
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
       call      qword ptr [7FF815455E30]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF815455E60]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814E2F390],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF814FA3688],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-28],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815446EC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L02:
       mov       rcx,249B4805258
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-18]
       mov       r9,249B47F0008
       call      qword ptr [7FF815455E78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-38],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815446EF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M02_L04:
       lea       rcx,[rbp-18]
       mov       rdx,[rbp-38]
       call      qword ptr [7FF814E66F40]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       je        short M02_L05
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M02_L08
M02_L05:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L06
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+18]
       mov       [rbp-48],rdx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815446EF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L07:
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-48]
       call      CORINFO_HELP_BOX
       mov       rcx,rax
       call      qword ptr [7FF814F7E088]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-4C],eax
       mov       eax,[rbp-4C]
       cmp       eax,[rbp+20]
       sete      al
       movzx     eax,al
       mov       [rbp-1C],eax
       nop
M02_L08:
       mov       eax,[rbp-1C]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 391
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
       cmp       dword ptr [7FF814E2F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154570D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+188]
       mov       rcx,rbx
       call      qword ptr [7FF814E750C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
       mov       r8d,eax
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
       call      qword ptr [7FF8154B7E28]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF8154B7E58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814E3F390],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF814FB3688],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-28],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815496248
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L02:
       mov       rcx,21810D75280
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-18]
       mov       r9,21810D60008
       call      qword ptr [7FF8154B7E70]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-38],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815496270
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M02_L04:
       lea       rcx,[rbp-18]
       mov       rdx,[rbp-38]
       call      qword ptr [7FF814E76F40]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       je        short M02_L05
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M02_L08
M02_L05:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L06
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+18]
       mov       [rbp-48],rdx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815496270
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L07:
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-48]
       call      CORINFO_HELP_BOX
       mov       rcx,rax
       call      qword ptr [7FF814F8E088]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-4C],eax
       mov       eax,[rbp-4C]
       cmp       eax,[rbp+20]
       sete      al
       movzx     eax,al
       mov       [rbp-1C],eax
       nop
M02_L08:
       mov       eax,[rbp-1C]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 391
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
       cmp       dword ptr [7FF814E3F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154BD230]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+188]
       mov       rcx,rbx
       call      qword ptr [7FF814E750C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
       mov       r8d,eax
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
       call      qword ptr [7FF8154B7948]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF8154B7978]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814E3F390],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF814FB3688],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-28],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815495720
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L02:
       mov       rcx,2B65C315258
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-18]
       mov       r9,2B65C300008
       call      qword ptr [7FF8154B7990]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-38],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815495748
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M02_L04:
       lea       rcx,[rbp-18]
       mov       rdx,[rbp-38]
       call      qword ptr [7FF814E76F40]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       je        short M02_L05
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M02_L08
M02_L05:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L06
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+18]
       mov       [rbp-48],rdx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815495748
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L07:
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-48]
       call      CORINFO_HELP_BOX
       mov       rcx,rax
       call      qword ptr [7FF814F8E088]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-4C],eax
       mov       eax,[rbp-4C]
       cmp       eax,[rbp+20]
       sete      al
       movzx     eax,al
       mov       [rbp-1C],eax
       nop
M02_L08:
       mov       eax,[rbp-1C]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 391
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
       cmp       dword ptr [7FF814E3F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154BD230]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+188]
       mov       rcx,rbx
       call      qword ptr [7FF814E44BB8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
       mov       r8d,eax
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
       call      qword ptr [7FF815487AF8]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF815487B28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814E0F390],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       eax,[rax+184]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF814F83688],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-28],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815465D00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L02:
       mov       rcx,1AFF0A35280
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-18]
       mov       r9,1AFF0A20008
       call      qword ptr [7FF815487B40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-38],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815465D28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M02_L04:
       lea       rcx,[rbp-18]
       mov       rdx,[rbp-38]
       call      qword ptr [7FF814E46A30]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       je        short M02_L05
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M02_L08
M02_L05:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L06
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+18]
       mov       [rbp-48],rdx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815465D28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L07:
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-48]
       call      CORINFO_HELP_BOX
       mov       rcx,rax
       call      qword ptr [7FF814F5E088]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-4C],eax
       mov       eax,[rbp-4C]
       cmp       eax,[rbp+20]
       sete      al
       movzx     eax,al
       mov       [rbp-1C],eax
       nop
M02_L08:
       mov       eax,[rbp-1C]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 391
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
       cmp       dword ptr [7FF814E0F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E44528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF81548D230]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+188]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF8153859E0]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815385A10]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F93688],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-28],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF8153669C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M01_L02:
       mov       rcx,19C2A2AB6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-18]
       mov       r9,19C2A2A0008
       call      qword ptr [7FF815385A28]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-38],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF8153669F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M01_L04:
       lea       rcx,[rbp-18]
       mov       rdx,[rbp-38]
       call      qword ptr [7FF814E56F40]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       je        short M01_L05
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L08
M01_L05:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+18]
       mov       [rbp-48],rdx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF8153669F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L07:
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-48]
       call      CORINFO_HELP_BOX
       mov       rcx,rax
       call      qword ptr [7FF814F6E088]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-4C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-4C],0
       setg      al
       mov       [rbp-1C],eax
       nop
M01_L08:
       mov       eax,[rbp-1C]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 384
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
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF815386C88]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+188]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF815385F38]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815385F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F93688],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-28],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815366960
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M01_L02:
       mov       rcx,23651ECB6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-18]
       mov       r9,23651EC0008
       call      qword ptr [7FF815385F80]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-38],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815366988
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M01_L04:
       lea       rcx,[rbp-18]
       mov       rdx,[rbp-38]
       call      qword ptr [7FF814E56F40]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       je        short M01_L05
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L08
M01_L05:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+18]
       mov       [rbp-48],rdx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815366988
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L07:
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-48]
       call      CORINFO_HELP_BOX
       mov       rcx,rax
       call      qword ptr [7FF814F6E088]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-4C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-4C],0
       setg      al
       mov       [rbp-1C],eax
       nop
M01_L08:
       mov       eax,[rbp-1C]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 384
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
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8153871E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+188]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF815385F38]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815385F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F93688],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-28],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815366960
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M01_L02:
       mov       rcx,24B0DE8B6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-18]
       mov       r9,24B0DE80008
       call      qword ptr [7FF815385F80]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-38],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815366988
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M01_L04:
       lea       rcx,[rbp-18]
       mov       rdx,[rbp-38]
       call      qword ptr [7FF814E56F40]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       je        short M01_L05
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L08
M01_L05:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+18]
       mov       [rbp-48],rdx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815366988
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L07:
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-48]
       call      CORINFO_HELP_BOX
       mov       rcx,rax
       call      qword ptr [7FF814F6E088]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-4C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-4C],0
       setg      al
       mov       [rbp-1C],eax
       nop
M01_L08:
       mov       eax,[rbp-1C]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 384
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
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8153871E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+188]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF815396400]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815396430]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F93688],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-28],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF8153782A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M01_L02:
       mov       rcx,218DEADB6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-18]
       mov       r9,218DEAD0008
       call      qword ptr [7FF815396448]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-38],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF8153782D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M01_L04:
       lea       rcx,[rbp-18]
       mov       rdx,[rbp-38]
       call      qword ptr [7FF814E56F40]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       je        short M01_L05
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L08
M01_L05:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+18]
       mov       [rbp-48],rdx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF8153782D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L07:
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-48]
       call      CORINFO_HELP_BOX
       mov       rcx,rax
       call      qword ptr [7FF814F6E088]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-4C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-4C],0
       setg      al
       mov       [rbp-1C],eax
       nop
M01_L08:
       mov       eax,[rbp-1C]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 384
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
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8153976A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+188]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF815466A30]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815466A60]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F83688],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-28],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815456B78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M01_L02:
       mov       rcx,2D68103B6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-18]
       mov       r9,2D681030008
       call      qword ptr [7FF815466A78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-38],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815456BA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M01_L04:
       lea       rcx,[rbp-18]
       mov       rdx,[rbp-38]
       call      qword ptr [7FF814E46F40]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       je        short M01_L05
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L08
M01_L05:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+18]
       mov       [rbp-48],rdx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815456BA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L07:
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-48]
       call      CORINFO_HELP_BOX
       mov       rcx,rax
       call      qword ptr [7FF814F5E088]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-4C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-4C],0
       setg      al
       mov       [rbp-1C],eax
       nop
M01_L08:
       mov       eax,[rbp-1C]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 384
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
       cmp       dword ptr [7FF814E0F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF815467CD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+188]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF8154B7AF8]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF8154B7B28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814FB3688],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-28],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815495928
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M01_L02:
       mov       rcx,264F255B6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-18]
       mov       r9,264F2550008
       call      qword ptr [7FF8154B7B40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-38],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815495950
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M01_L04:
       lea       rcx,[rbp-18]
       mov       rdx,[rbp-38]
       call      qword ptr [7FF814E76F40]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       je        short M01_L05
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L08
M01_L05:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+18]
       mov       [rbp-48],rdx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815495950
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L07:
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-48]
       call      CORINFO_HELP_BOX
       mov       rcx,rax
       call      qword ptr [7FF814F8E088]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-4C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-4C],0
       setg      al
       mov       [rbp-1C],eax
       nop
M01_L08:
       mov       eax,[rbp-1C]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 384
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
       cmp       dword ptr [7FF814E3F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154BD230]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+188]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF815487E28]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815487E58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F83688],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-28],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815465990
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M01_L02:
       mov       rcx,2B76E06B6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-18]
       mov       r9,2B76E060008
       call      qword ptr [7FF815487E70]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-38],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF8154659B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M01_L04:
       lea       rcx,[rbp-18]
       mov       rdx,[rbp-38]
       call      qword ptr [7FF814E46F40]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       je        short M01_L05
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L08
M01_L05:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+18]
       mov       [rbp-48],rdx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF8154659B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L07:
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-48]
       call      CORINFO_HELP_BOX
       mov       rcx,rax
       call      qword ptr [7FF814F5E088]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-4C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-4C],0
       setg      al
       mov       [rbp-1C],eax
       nop
M01_L08:
       mov       eax,[rbp-1C]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 384
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
       cmp       dword ptr [7FF814E0F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF81548D230]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+188]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF815497E28]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815497E58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F93688],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-28],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF8154771F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M01_L02:
       mov       rcx,2237470B6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-18]
       mov       r9,22374700008
       call      qword ptr [7FF815497E70]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.Collections.Immutable.ImmutableArray`1<System.__Canon>, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-38],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815477218
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M01_L04:
       lea       rcx,[rbp-18]
       mov       rdx,[rbp-38]
       call      qword ptr [7FF814E56F40]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       je        short M01_L05
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L08
M01_L05:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+18]
       mov       [rbp-48],rdx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815477218
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L07:
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-48]
       call      CORINFO_HELP_BOX
       mov       rcx,rax
       call      qword ptr [7FF814F6E088]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-4C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-4C],0
       setg      al
       mov       [rbp-1C],eax
       nop
M01_L08:
       mov       eax,[rbp-1C]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 384
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
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF81549D230]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

