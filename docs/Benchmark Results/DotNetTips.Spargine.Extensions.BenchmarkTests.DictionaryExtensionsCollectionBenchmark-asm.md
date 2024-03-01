## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       rcx,rbx
       call      qword ptr [7FFE383B4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE384BCAE0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE383B4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       r9,rax
       mov       r8,rdi
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE388E6070]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE388E60A0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 103
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE3837F390],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+40]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,28
       sub       rsp,28
       lea       rbp,[rsp+30]
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE3837FDD0],0
       cmp       dword ptr [7FFE3837FDD0],0
       je        short M02_L00
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rax,[rbp+10]
M02_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+30]
       mov       rax,[rax+30]
       add       rsp,28
       add       rsp,28
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0C0
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FFE384BDD78],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M03_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-38],rcx
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388AE520
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M03_L02:
       mov       rcx,2627E350390
       mov       [rsp+20],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-18]
       mov       r9,2627E350008
       call      qword ptr [7FFE3850C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M03_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M03_L04
M03_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388AE558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M03_L04:
       mov       rcx,2627E359D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-20]
       mov       r9,2627E350008
       call      qword ptr [7FFE3850C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M03_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M03_L06
M03_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388AE818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M03_L06:
       mov       rcx,2627E35B6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2627E350008
       call      qword ptr [7FFE3850C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M03_L07
       mov       r8,[rbp+10]
       mov       r8,[r8+10]
       mov       r8,[r8+30]
       mov       [rbp-68],r8
       jmp       short M03_L08
M03_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388AE840
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M03_L08:
       mov       r8,[rbp-68]
       mov       [rbp-70],r8
       lea       r8,[rbp-10]
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       xor       eax,eax
       cmp       dword ptr [rbp-74],0
       sete      al
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       je        near ptr M03_L11
       nop
       mov       rax,[rbp+10]
       mov       rax,[rax+10]
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L09
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+38],0
       je        short M03_L09
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+38]
       mov       [rbp-80],rcx
       jmp       short M03_L10
M03_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388AE8E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-80],rax
M03_L10:
       mov       rcx,[rbp-80]
       mov       [rbp-88],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-88]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-88]
       call      qword ptr [rax]
       nop
       mov       rax,[rbp+28]
       mov       [rbp-10],rax
       nop
M03_L11:
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,0C0
       pop       rbp
       ret
; Total bytes of code 696
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE3837F390],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE388AEAF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388E61F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       rcx,rbx
       call      qword ptr [7FFE383E4858]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE384ECAE0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE383E4858]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       r9,rax
       mov       r8,rdi
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE38916838]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE38916868]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 103
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383AF3F0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+40]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,28
       sub       rsp,28
       lea       rbp,[rsp+30]
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383AFE30],0
       cmp       dword ptr [7FFE383AFE30],0
       je        short M02_L00
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rax,[rbp+10]
M02_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+30]
       mov       rax,[rax+30]
       add       rsp,28
       add       rsp,28
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0C0
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FFE384EDD78],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M03_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-38],rcx
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388DE520
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M03_L02:
       mov       rcx,24FE66E0390
       mov       [rsp+20],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-18]
       mov       r9,24FE66E0008
       call      qword ptr [7FFE38567C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M03_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M03_L04
M03_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388DE558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M03_L04:
       mov       rcx,24FE66E9D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-20]
       mov       r9,24FE66E0008
       call      qword ptr [7FFE38567C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M03_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M03_L06
M03_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388DE818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M03_L06:
       mov       rcx,24FE66EB6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,24FE66E0008
       call      qword ptr [7FFE38567C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M03_L07
       mov       r8,[rbp+10]
       mov       r8,[r8+10]
       mov       r8,[r8+30]
       mov       [rbp-68],r8
       jmp       short M03_L08
M03_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388DE840
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M03_L08:
       mov       r8,[rbp-68]
       mov       [rbp-70],r8
       lea       r8,[rbp-10]
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       xor       eax,eax
       cmp       dword ptr [rbp-74],0
       sete      al
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       je        near ptr M03_L11
       nop
       mov       rax,[rbp+10]
       mov       rax,[rax+10]
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L09
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+38],0
       je        short M03_L09
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+38]
       mov       [rbp-80],rcx
       jmp       short M03_L10
M03_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388DE8E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-80],rax
M03_L10:
       mov       rcx,[rbp-80]
       mov       [rbp-88],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-88]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-88]
       call      qword ptr [rax]
       nop
       mov       rax,[rbp+28]
       mov       [rbp-10],rax
       nop
M03_L11:
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,0C0
       pop       rbp
       ret
; Total bytes of code 696
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE383AF3F0],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE388DEAF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE389169B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       rcx,rbx
       call      qword ptr [7FFE383E4858]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE384ECAE0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE383E4858]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       r9,rax
       mov       r8,rdi
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE38916838]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE38916868]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 103
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383AF390],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+40]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,28
       sub       rsp,28
       lea       rbp,[rsp+30]
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383AFDD0],0
       cmp       dword ptr [7FFE383AFDD0],0
       je        short M02_L00
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rax,[rbp+10]
M02_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+30]
       mov       rax,[rax+30]
       add       rsp,28
       add       rsp,28
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0C0
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FFE384EDD78],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M03_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-38],rcx
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388DE520
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M03_L02:
       mov       rcx,1B730740390
       mov       [rsp+20],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-18]
       mov       r9,1B730740008
       call      qword ptr [7FFE38567C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M03_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M03_L04
M03_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388DE558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M03_L04:
       mov       rcx,1B730749D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-20]
       mov       r9,1B730740008
       call      qword ptr [7FFE38567C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M03_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M03_L06
M03_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388DE818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M03_L06:
       mov       rcx,1B73074B6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,1B730740008
       call      qword ptr [7FFE38567C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M03_L07
       mov       r8,[rbp+10]
       mov       r8,[r8+10]
       mov       r8,[r8+30]
       mov       [rbp-68],r8
       jmp       short M03_L08
M03_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388DE840
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M03_L08:
       mov       r8,[rbp-68]
       mov       [rbp-70],r8
       lea       r8,[rbp-10]
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       xor       eax,eax
       cmp       dword ptr [rbp-74],0
       sete      al
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       je        near ptr M03_L11
       nop
       mov       rax,[rbp+10]
       mov       rax,[rax+10]
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L09
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+38],0
       je        short M03_L09
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+38]
       mov       [rbp-80],rcx
       jmp       short M03_L10
M03_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388DE8E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-80],rax
M03_L10:
       mov       rcx,[rbp-80]
       mov       [rbp-88],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-88]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-88]
       call      qword ptr [rax]
       nop
       mov       rax,[rbp+28]
       mov       [rbp-10],rax
       nop
M03_L11:
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,0C0
       pop       rbp
       ret
; Total bytes of code 696
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE383AF390],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE388DEAF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE389169B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       rcx,rbx
       call      qword ptr [7FFE383F4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE384FCAE0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE383F4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       r9,rax
       mov       r8,rdi
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE38926838]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE38926868]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 103
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383BF390],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+40]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,28
       sub       rsp,28
       lea       rbp,[rsp+30]
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383BFDD0],0
       cmp       dword ptr [7FFE383BFDD0],0
       je        short M02_L00
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rax,[rbp+10]
M02_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+30]
       mov       rax,[rax+30]
       add       rsp,28
       add       rsp,28
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0C0
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FFE384FDD78],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M03_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-38],rcx
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388EE520
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M03_L02:
       mov       rcx,1F3DF640390
       mov       [rsp+20],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-18]
       mov       r9,1F3DF640008
       call      qword ptr [7FFE3854C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M03_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M03_L04
M03_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388EE558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M03_L04:
       mov       rcx,1F3DF649D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-20]
       mov       r9,1F3DF640008
       call      qword ptr [7FFE3854C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M03_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M03_L06
M03_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388EE818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M03_L06:
       mov       rcx,1F3DF64B6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,1F3DF640008
       call      qword ptr [7FFE3854C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M03_L07
       mov       r8,[rbp+10]
       mov       r8,[r8+10]
       mov       r8,[r8+30]
       mov       [rbp-68],r8
       jmp       short M03_L08
M03_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388EE840
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M03_L08:
       mov       r8,[rbp-68]
       mov       [rbp-70],r8
       lea       r8,[rbp-10]
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       xor       eax,eax
       cmp       dword ptr [rbp-74],0
       sete      al
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       je        near ptr M03_L11
       nop
       mov       rax,[rbp+10]
       mov       rax,[rax+10]
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L09
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+38],0
       je        short M03_L09
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+38]
       mov       [rbp-80],rcx
       jmp       short M03_L10
M03_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388EE8E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-80],rax
M03_L10:
       mov       rcx,[rbp-80]
       mov       [rbp-88],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-88]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-88]
       call      qword ptr [rax]
       nop
       mov       rax,[rbp+28]
       mov       [rbp-10],rax
       nop
M03_L11:
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,0C0
       pop       rbp
       ret
; Total bytes of code 696
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE383BF390],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE388EEAF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE389269B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       rcx,rbx
       call      qword ptr [7FFE383C4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE384CCAE0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE383C4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       r9,rax
       mov       r8,rdi
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE389EC9C0]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE389EC9F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 103
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE3838F390],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+40]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,28
       sub       rsp,28
       lea       rbp,[rsp+30]
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE3838FDD0],0
       cmp       dword ptr [7FFE3838FDD0],0
       je        short M02_L00
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rax,[rbp+10]
M02_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+30]
       mov       rax,[rax+30]
       add       rsp,28
       add       rsp,28
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0C0
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FFE384CDD78],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M03_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-38],rcx
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389DB4A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M03_L02:
       mov       rcx,1FB803B0390
       mov       [rsp+20],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-18]
       mov       r9,1FB803B0008
       call      qword ptr [7FFE3851C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M03_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M03_L04
M03_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389DB4D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M03_L04:
       mov       rcx,1FB803B9D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-20]
       mov       r9,1FB803B0008
       call      qword ptr [7FFE3851C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M03_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M03_L06
M03_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389DB798
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M03_L06:
       mov       rcx,1FB803BB6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,1FB803B0008
       call      qword ptr [7FFE3851C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M03_L07
       mov       r8,[rbp+10]
       mov       r8,[r8+10]
       mov       r8,[r8+30]
       mov       [rbp-68],r8
       jmp       short M03_L08
M03_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389DB7C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M03_L08:
       mov       r8,[rbp-68]
       mov       [rbp-70],r8
       lea       r8,[rbp-10]
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       xor       eax,eax
       cmp       dword ptr [rbp-74],0
       sete      al
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       je        near ptr M03_L11
       nop
       mov       rax,[rbp+10]
       mov       rax,[rax+10]
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L09
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+38],0
       je        short M03_L09
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+38]
       mov       [rbp-80],rcx
       jmp       short M03_L10
M03_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389DB860
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-80],rax
M03_L10:
       mov       rcx,[rbp-80]
       mov       [rbp-88],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-88]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-88]
       call      qword ptr [rax]
       nop
       mov       rax,[rbp+28]
       mov       [rbp-10],rax
       nop
M03_L11:
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,0C0
       pop       rbp
       ret
; Total bytes of code 696
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE3838F390],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE389DBA70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE389ECB40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       rcx,rbx
       call      qword ptr [7FFE383D4858]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE384DCAE0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE383D4858]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       r9,rax
       mov       r8,rdi
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE38A0C9C0]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE38A0C9F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 103
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE3839F3E0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+40]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,28
       sub       rsp,28
       lea       rbp,[rsp+30]
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE3839FE20],0
       cmp       dword ptr [7FFE3839FE20],0
       je        short M02_L00
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rax,[rbp+10]
M02_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+30]
       mov       rax,[rax+30]
       add       rsp,28
       add       rsp,28
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0C0
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FFE384DDD78],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M03_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-38],rcx
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389FB540
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M03_L02:
       mov       rcx,2EBBA290390
       mov       [rsp+20],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-18]
       mov       r9,2EBBA290008
       call      qword ptr [7FFE38557C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M03_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M03_L04
M03_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389FB578
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M03_L04:
       mov       rcx,2EBBA299D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-20]
       mov       r9,2EBBA290008
       call      qword ptr [7FFE38557C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M03_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M03_L06
M03_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389FB838
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M03_L06:
       mov       rcx,2EBBA29B6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2EBBA290008
       call      qword ptr [7FFE38557C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M03_L07
       mov       r8,[rbp+10]
       mov       r8,[r8+10]
       mov       r8,[r8+30]
       mov       [rbp-68],r8
       jmp       short M03_L08
M03_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389FB860
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M03_L08:
       mov       r8,[rbp-68]
       mov       [rbp-70],r8
       lea       r8,[rbp-10]
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       xor       eax,eax
       cmp       dword ptr [rbp-74],0
       sete      al
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       je        near ptr M03_L11
       nop
       mov       rax,[rbp+10]
       mov       rax,[rax+10]
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L09
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+38],0
       je        short M03_L09
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+38]
       mov       [rbp-80],rcx
       jmp       short M03_L10
M03_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389FB900
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-80],rax
M03_L10:
       mov       rcx,[rbp-80]
       mov       [rbp-88],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-88]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-88]
       call      qword ptr [rax]
       nop
       mov       rax,[rbp+28]
       mov       [rbp-10],rax
       nop
M03_L11:
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,0C0
       pop       rbp
       ret
; Total bytes of code 696
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE3839F3E0],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383D4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE389FBB10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38A0CB40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       rcx,rbx
       call      qword ptr [7FFE383F4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE384FCAE0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE383F4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       r9,rax
       mov       r8,rdi
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE38A3C9C0]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE38A3C9F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 103
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383BF390],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+40]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,28
       sub       rsp,28
       lea       rbp,[rsp+30]
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383BFDD0],0
       cmp       dword ptr [7FFE383BFDD0],0
       je        short M02_L00
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rax,[rbp+10]
M02_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+30]
       mov       rax,[rax+30]
       add       rsp,28
       add       rsp,28
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0C0
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FFE384FDD78],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M03_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-38],rcx
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE38A1B570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M03_L02:
       mov       rcx,2A258090390
       mov       [rsp+20],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-18]
       mov       r9,2A258090008
       call      qword ptr [7FFE3854C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M03_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M03_L04
M03_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE38A1B5A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M03_L04:
       mov       rcx,2A258099D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-20]
       mov       r9,2A258090008
       call      qword ptr [7FFE3854C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M03_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M03_L06
M03_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE38A1B868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M03_L06:
       mov       rcx,2A25809B6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2A258090008
       call      qword ptr [7FFE3854C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M03_L07
       mov       r8,[rbp+10]
       mov       r8,[r8+10]
       mov       r8,[r8+30]
       mov       [rbp-68],r8
       jmp       short M03_L08
M03_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE38A1B890
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M03_L08:
       mov       r8,[rbp-68]
       mov       [rbp-70],r8
       lea       r8,[rbp-10]
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       xor       eax,eax
       cmp       dword ptr [rbp-74],0
       sete      al
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       je        near ptr M03_L11
       nop
       mov       rax,[rbp+10]
       mov       rax,[rax+10]
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L09
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+38],0
       je        short M03_L09
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+38]
       mov       [rbp-80],rcx
       jmp       short M03_L10
M03_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE38A1B930
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-80],rax
M03_L10:
       mov       rcx,[rbp-80]
       mov       [rbp-88],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-88]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-88]
       call      qword ptr [rax]
       nop
       mov       rax,[rbp+28]
       mov       [rbp-10],rax
       nop
M03_L11:
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,0C0
       pop       rbp
       ret
; Total bytes of code 696
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE383BF390],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE38A1BB40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38A3CB40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       rcx,rbx
       call      qword ptr [7FFE383D4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE384DCAE0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE383D4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       r9,rax
       mov       r8,rdi
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE38A1C9C0]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE38A1C9F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 103
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE3839F390],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+40]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,28
       sub       rsp,28
       lea       rbp,[rsp+30]
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE3839FDD0],0
       cmp       dword ptr [7FFE3839FDD0],0
       je        short M02_L00
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rax,[rbp+10]
M02_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+30]
       mov       rax,[rax+30]
       add       rsp,28
       add       rsp,28
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0C0
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FFE384DDD78],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M03_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-38],rcx
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389FB8D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M03_L02:
       mov       rcx,25B2B320390
       mov       [rsp+20],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-18]
       mov       r9,25B2B320008
       call      qword ptr [7FFE3852C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M03_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M03_L04
M03_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389FB910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M03_L04:
       mov       rcx,25B2B329D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-20]
       mov       r9,25B2B320008
       call      qword ptr [7FFE3852C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M03_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M03_L06
M03_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389FBBD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M03_L06:
       mov       rcx,25B2B32B6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,25B2B320008
       call      qword ptr [7FFE3852C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M03_L07
       mov       r8,[rbp+10]
       mov       r8,[r8+10]
       mov       r8,[r8+30]
       mov       [rbp-68],r8
       jmp       short M03_L08
M03_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389FBBF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M03_L08:
       mov       r8,[rbp-68]
       mov       [rbp-70],r8
       lea       r8,[rbp-10]
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       xor       eax,eax
       cmp       dword ptr [rbp-74],0
       sete      al
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       je        near ptr M03_L11
       nop
       mov       rax,[rbp+10]
       mov       rax,[rax+10]
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L09
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+38],0
       je        short M03_L09
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+38]
       mov       [rbp-80],rcx
       jmp       short M03_L10
M03_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389FBC98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-80],rax
M03_L10:
       mov       rcx,[rbp-80]
       mov       [rbp-88],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-88]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-88]
       call      qword ptr [rax]
       nop
       mov       rax,[rbp+28]
       mov       [rbp-10],rax
       nop
M03_L11:
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,0C0
       pop       rbp
       ret
; Total bytes of code 696
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE3839F390],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE389FBEA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38A1CB40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,18E48008BD8
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
       call      qword ptr [7FFE38906118]; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE38906148]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,18E48008BD0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE38044210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,18E48008BD8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M00_L00
; Total bytes of code 145
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE384DDD78],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       cmp       qword ptr [rbp+18],0
       je        short M01_L03
       cmp       qword ptr [rbp+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-20],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388CE7E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FFE38906160]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       mov       [rbp-14],eax
       jmp       short M01_L04
M01_L03:
       xor       eax,eax
       mov       [rbp-14],eax
M01_L04:
       mov       eax,[rbp-14]
       movzx     eax,al
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 158
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
       cmp       dword ptr [7FFE3839F400],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383D4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE389062B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384E6F40]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFE389827F8]
       vxorps    xmm1,xmm1,xmm1
       xor       eax,eax
       vucomisd  xmm0,xmm1
       seta      al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFE380441F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,25B10C0ABD0
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
       call      qword ptr [7FFE38916730]; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE38916760]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,25B10C0ABC8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE38054210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,25B10C0ABD0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M00_L00
; Total bytes of code 145
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE384EDD78],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       cmp       qword ptr [rbp+18],0
       je        short M01_L03
       cmp       qword ptr [rbp+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-20],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388DE5E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FFE38916778]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       mov       [rbp-14],eax
       jmp       short M01_L04
M01_L03:
       xor       eax,eax
       mov       [rbp-14],eax
M01_L04:
       mov       eax,[rbp-14]
       movzx     eax,al
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 158
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
       cmp       dword ptr [7FFE3839F438],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE389168C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384F6F40]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFE38992738]
       vxorps    xmm1,xmm1,xmm1
       xor       eax,eax
       vucomisd  xmm0,xmm1
       seta      al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFE380541F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,2781900ABD0
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
       call      qword ptr [7FFE388F6118]; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE388F6148]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2781900ABC8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE38034210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2781900ABD0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M00_L00
; Total bytes of code 145
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE384CDD78],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       cmp       qword ptr [rbp+18],0
       je        short M01_L03
       cmp       qword ptr [rbp+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-20],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388BE7E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FFE388F6160]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       mov       [rbp-14],eax
       jmp       short M01_L04
M01_L03:
       xor       eax,eax
       mov       [rbp-14],eax
M01_L04:
       mov       eax,[rbp-14]
       movzx     eax,al
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 158
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
       cmp       dword ptr [7FFE3838F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388F62B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384D7870]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFE389727D8]
       vxorps    xmm1,xmm1,xmm1
       xor       eax,eax
       vucomisd  xmm0,xmm1
       seta      al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFE380341F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,2513F80ABD0
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
       call      qword ptr [7FFE38916E68]; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE38916E98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2513F80ABC8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE38044210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2513F80ABD0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M00_L00
; Total bytes of code 145
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE384DDD78],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       cmp       qword ptr [rbp+18],0
       je        short M01_L03
       cmp       qword ptr [rbp+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-20],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388CE298
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FFE38916EB0]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       mov       [rbp-14],eax
       jmp       short M01_L04
M01_L03:
       xor       eax,eax
       mov       [rbp-14],eax
M01_L04:
       mov       eax,[rbp-14]
       movzx     eax,al
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 158
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
       cmp       dword ptr [7FFE3839F3E8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383D4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38917000]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE384E6F40]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFE3898A618]
       vxorps    xmm1,xmm1,xmm1
       xor       eax,eax
       vucomisd  xmm0,xmm1
       seta      al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFE380441F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,20A0340ABD0
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
       call      qword ptr [7FFE38A0CA68]; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE38A0CA98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,20A0340ABC8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFE38A08858
       call      qword ptr [7FFE38044210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20A0340ABD0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M00_L00
; Total bytes of code 145
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE384DDD78],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       cmp       qword ptr [rbp+18],0
       je        short M01_L03
       cmp       qword ptr [rbp+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-20],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389FB7D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FFE38A0CAB0]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       mov       [rbp-14],eax
       jmp       short M01_L04
M01_L03:
       xor       eax,eax
       mov       [rbp-14],eax
M01_L04:
       mov       eax,[rbp-14]
       movzx     eax,al
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 158
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
       cmp       dword ptr [7FFE3838F4B8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383D4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38A0CC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFE380441F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,16981008BD8
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
       call      qword ptr [7FFE38A3CA68]; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE38A3CA98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,16981008BD0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFE38A38858
       call      qword ptr [7FFE38064210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,16981008BD8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M00_L00
; Total bytes of code 145
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE384FDD78],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       cmp       qword ptr [rbp+18],0
       je        short M01_L03
       cmp       qword ptr [rbp+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-20],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE38A1CFF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FFE38A3CAB0]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       mov       [rbp-14],eax
       jmp       short M01_L04
M01_L03:
       xor       eax,eax
       mov       [rbp-14],eax
M01_L04:
       mov       eax,[rbp-14]
       movzx     eax,al
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 158
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
       cmp       dword ptr [7FFE383BF390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383F4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38A3CC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFE380641F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,26ACF008BD8
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
       call      qword ptr [7FFE38A1C8B8]; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE38A1C8E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,26ACF008BD0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFE38A186A8
       call      qword ptr [7FFE38044210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,26ACF008BD8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M00_L00
; Total bytes of code 145
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE384DDD78],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       cmp       qword ptr [rbp+18],0
       je        short M01_L03
       cmp       qword ptr [rbp+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-20],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389FB630
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FFE38A1C900]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       mov       [rbp-14],eax
       jmp       short M01_L04
M01_L03:
       xor       eax,eax
       mov       [rbp-14],eax
M01_L04:
       mov       eax,[rbp-14]
       movzx     eax,al
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 158
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
       cmp       dword ptr [7FFE3839F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38A1CA50]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFE380441F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,1C9BB80ABD0
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
       call      qword ptr [7FFE38A0E118]; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE38A0E148]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1C9BB80ABC8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFE38A09F08
       call      qword ptr [7FFE38044210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1C9BB80ABD0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M00_L00
; Total bytes of code 145
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE384DDD78],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       cmp       qword ptr [rbp+18],0
       je        short M01_L03
       cmp       qword ptr [rbp+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-20],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389FC018
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FFE38A0E160]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       mov       [rbp-14],eax
       jmp       short M01_L04
M01_L03:
       xor       eax,eax
       mov       [rbp-14],eax
M01_L04:
       mov       eax,[rbp-14]
       movzx     eax,al
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 158
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
       cmp       dword ptr [7FFE3838F388],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383D4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38A0E2B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFE380441F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       rcx,rbx
       call      qword ptr [7FFE383F4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE384FCAE0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE383F4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       r9,rax
       mov       r8,rdi
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE38926070]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,rbx
       mov       r8,rsi
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE389260A0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 103
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383BF3A8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+40]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,28
       sub       rsp,28
       lea       rbp,[rsp+30]
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383BFDE8],0
       cmp       dword ptr [7FFE383BFDE8],0
       je        short M02_L00
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rax,[rbp+10]
M02_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+30]
       mov       rax,[rax+30]
       add       rsp,28
       add       rsp,28
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FFE384FDD78],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+28],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M03_L01
       nop
       nop
       jmp       near ptr M03_L13
M03_L01:
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M03_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M03_L03
M03_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388EE520
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M03_L03:
       mov       rcx,2A7D6989D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-18]
       mov       r9,2A7D6980008
       call      qword ptr [7FFE3854C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M03_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-38],rcx
       jmp       short M03_L05
M03_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388EE7E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M03_L05:
       mov       rcx,2A7D698B6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2A7D6980008
       call      qword ptr [7FFE3854C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M03_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-48],rcx
       jmp       short M03_L07
M03_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388EE808
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M03_L07:
       mov       rcx,[rbp-48]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-50]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-50]
       call      qword ptr [rax]
       mov       [rbp-54],eax
       mov       ecx,[rbp-54]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        short M03_L10
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-88],rcx
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L08
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+38],0
       je        short M03_L08
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+38]
       mov       [rbp-70],rcx
       jmp       short M03_L09
M03_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388EE8C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-70],rax
M03_L09:
       mov       rcx,[rbp-70]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-78]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-78]
       call      qword ptr [rax]
       mov       [rbp-7C],eax
       nop
       nop
M03_L10:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M03_L11
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-60],rcx
       jmp       short M03_L12
M03_L11:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388EE820
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M03_L12:
       mov       rcx,[rbp-60]
       mov       [rbp-68],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-68]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-68]
       call      qword ptr [rax]
       nop
M03_L13:
       nop
       add       rsp,0B0
       pop       rbp
       ret
; Total bytes of code 641
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE383BF3A8],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE388EEAA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE389261D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       rcx,rbx
       call      qword ptr [7FFE383B4858]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE384BCAE0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE383B4858]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       r9,rax
       mov       r8,rdi
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE388E6538]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,rbx
       mov       r8,rsi
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE388E6568]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 103
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE3837F390],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+40]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,28
       sub       rsp,28
       lea       rbp,[rsp+30]
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE3837FDD0],0
       cmp       dword ptr [7FFE3837FDD0],0
       je        short M02_L00
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rax,[rbp+10]
M02_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+30]
       mov       rax,[rax+30]
       add       rsp,28
       add       rsp,28
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FFE384BDD78],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+28],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M03_L01
       nop
       nop
       jmp       near ptr M03_L13
M03_L01:
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M03_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M03_L03
M03_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388AE520
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M03_L03:
       mov       rcx,2B61FD09D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-18]
       mov       r9,2B61FD00008
       call      qword ptr [7FFE38537C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M03_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-38],rcx
       jmp       short M03_L05
M03_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388AE7E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M03_L05:
       mov       rcx,2B61FD0B6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2B61FD00008
       call      qword ptr [7FFE38537C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M03_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-48],rcx
       jmp       short M03_L07
M03_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388AE808
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M03_L07:
       mov       rcx,[rbp-48]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-50]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-50]
       call      qword ptr [rax]
       mov       [rbp-54],eax
       mov       ecx,[rbp-54]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        short M03_L10
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-88],rcx
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L08
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+38],0
       je        short M03_L08
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+38]
       mov       [rbp-70],rcx
       jmp       short M03_L09
M03_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388AE8C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-70],rax
M03_L09:
       mov       rcx,[rbp-70]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-78]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-78]
       call      qword ptr [rax]
       mov       [rbp-7C],eax
       nop
       nop
M03_L10:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M03_L11
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-60],rcx
       jmp       short M03_L12
M03_L11:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388AE820
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M03_L12:
       mov       rcx,[rbp-60]
       mov       [rbp-68],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-68]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-68]
       call      qword ptr [rax]
       nop
M03_L13:
       nop
       add       rsp,0B0
       pop       rbp
       ret
; Total bytes of code 641
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE3837F390],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE388AEAA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388E66A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       rcx,rbx
       call      qword ptr [7FFE383F4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE384FCAE0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE383F4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       r9,rax
       mov       r8,rdi
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE38926070]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,rbx
       mov       r8,rsi
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE389260A0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 103
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383BF390],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+40]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,28
       sub       rsp,28
       lea       rbp,[rsp+30]
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383BFDD0],0
       cmp       dword ptr [7FFE383BFDD0],0
       je        short M02_L00
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rax,[rbp+10]
M02_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+30]
       mov       rax,[rax+30]
       add       rsp,28
       add       rsp,28
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FFE384FDD78],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+28],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M03_L01
       nop
       nop
       jmp       near ptr M03_L13
M03_L01:
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M03_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M03_L03
M03_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388EE520
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M03_L03:
       mov       rcx,2990B379D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-18]
       mov       r9,2990B370008
       call      qword ptr [7FFE3854C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M03_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-38],rcx
       jmp       short M03_L05
M03_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388EE7E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M03_L05:
       mov       rcx,2990B37B6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2990B370008
       call      qword ptr [7FFE3854C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M03_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-48],rcx
       jmp       short M03_L07
M03_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388EE808
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M03_L07:
       mov       rcx,[rbp-48]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-50]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-50]
       call      qword ptr [rax]
       mov       [rbp-54],eax
       mov       ecx,[rbp-54]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        short M03_L10
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-88],rcx
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L08
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+38],0
       je        short M03_L08
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+38]
       mov       [rbp-70],rcx
       jmp       short M03_L09
M03_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388EE8C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-70],rax
M03_L09:
       mov       rcx,[rbp-70]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-78]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-78]
       call      qword ptr [rax]
       mov       [rbp-7C],eax
       nop
       nop
M03_L10:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M03_L11
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-60],rcx
       jmp       short M03_L12
M03_L11:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388EE820
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M03_L12:
       mov       rcx,[rbp-60]
       mov       [rbp-68],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-68]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-68]
       call      qword ptr [rax]
       nop
M03_L13:
       nop
       add       rsp,0B0
       pop       rbp
       ret
; Total bytes of code 641
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE383BF390],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE388EEAA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE389261D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       rcx,rbx
       call      qword ptr [7FFE383E4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE384ECAE0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE383E4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       r9,rax
       mov       r8,rdi
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE38926DC0]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,rbx
       mov       r8,rsi
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE38926DF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 103
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383AF390],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+40]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,28
       sub       rsp,28
       lea       rbp,[rsp+30]
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383AFDD0],0
       cmp       dword ptr [7FFE383AFDD0],0
       je        short M02_L00
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rax,[rbp+10]
M02_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+30]
       mov       rax,[rax+30]
       add       rsp,28
       add       rsp,28
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FFE384EDD78],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+28],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M03_L01
       nop
       nop
       jmp       near ptr M03_L13
M03_L01:
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M03_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M03_L03
M03_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388DDFD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M03_L03:
       mov       rcx,2F71EA59D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-18]
       mov       r9,2F71EA50008
       call      qword ptr [7FFE3853C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M03_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-38],rcx
       jmp       short M03_L05
M03_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388DE290
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M03_L05:
       mov       rcx,2F71EA5B6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2F71EA50008
       call      qword ptr [7FFE3853C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M03_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-48],rcx
       jmp       short M03_L07
M03_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388DE2B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M03_L07:
       mov       rcx,[rbp-48]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-50]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-50]
       call      qword ptr [rax]
       mov       [rbp-54],eax
       mov       ecx,[rbp-54]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        short M03_L10
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-88],rcx
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L08
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+38],0
       je        short M03_L08
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+38]
       mov       [rbp-70],rcx
       jmp       short M03_L09
M03_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388DE370
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-70],rax
M03_L09:
       mov       rcx,[rbp-70]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-78]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-78]
       call      qword ptr [rax]
       mov       [rbp-7C],eax
       nop
       nop
M03_L10:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M03_L11
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-60],rcx
       jmp       short M03_L12
M03_L11:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388DE2D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M03_L12:
       mov       rcx,[rbp-60]
       mov       [rbp-68],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-68]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-68]
       call      qword ptr [rax]
       nop
M03_L13:
       nop
       add       rsp,0B0
       pop       rbp
       ret
; Total bytes of code 641
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE383AF390],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE388DE558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38926F28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       rcx,rbx
       call      qword ptr [7FFE383E4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE384ECAE0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE383E4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       r9,rax
       mov       r8,rdi
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE38A1C9C0]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,rbx
       mov       r8,rsi
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE38A1C9F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 103
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383AF390],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+40]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,28
       sub       rsp,28
       lea       rbp,[rsp+30]
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383AFDD0],0
       cmp       dword ptr [7FFE383AFDD0],0
       je        short M02_L00
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rax,[rbp+10]
M02_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+30]
       mov       rax,[rax+30]
       add       rsp,28
       add       rsp,28
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FFE384EDD78],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+28],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M03_L01
       nop
       nop
       jmp       near ptr M03_L13
M03_L01:
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M03_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M03_L03
M03_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE38A0B4A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M03_L03:
       mov       rcx,2ABB8F49D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-18]
       mov       r9,2ABB8F40008
       call      qword ptr [7FFE3853C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M03_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-38],rcx
       jmp       short M03_L05
M03_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE38A0B760
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M03_L05:
       mov       rcx,2ABB8F4B6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2ABB8F40008
       call      qword ptr [7FFE3853C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M03_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-48],rcx
       jmp       short M03_L07
M03_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE38A0B788
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M03_L07:
       mov       rcx,[rbp-48]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-50]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-50]
       call      qword ptr [rax]
       mov       [rbp-54],eax
       mov       ecx,[rbp-54]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        short M03_L10
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-88],rcx
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L08
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+38],0
       je        short M03_L08
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+38]
       mov       [rbp-70],rcx
       jmp       short M03_L09
M03_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE38A0B840
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-70],rax
M03_L09:
       mov       rcx,[rbp-70]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-78]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-78]
       call      qword ptr [rax]
       mov       [rbp-7C],eax
       nop
       nop
M03_L10:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M03_L11
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-60],rcx
       jmp       short M03_L12
M03_L11:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE38A0B7A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M03_L12:
       mov       rcx,[rbp-60]
       mov       [rbp-68],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-68]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-68]
       call      qword ptr [rax]
       nop
M03_L13:
       nop
       add       rsp,0B0
       pop       rbp
       ret
; Total bytes of code 641
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE383AF390],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE38A0BA28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38A1CB28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       rcx,rbx
       call      qword ptr [7FFE383C4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE384CCAE0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE383C4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       r9,rax
       mov       r8,rdi
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE38A0C9C0]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,rbx
       mov       r8,rsi
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE38A0C9F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 103
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE3838F390],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+40]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,28
       sub       rsp,28
       lea       rbp,[rsp+30]
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE3838FDD0],0
       cmp       dword ptr [7FFE3838FDD0],0
       je        short M02_L00
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rax,[rbp+10]
M02_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+30]
       mov       rax,[rax+30]
       add       rsp,28
       add       rsp,28
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FFE384CDD78],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+28],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M03_L01
       nop
       nop
       jmp       near ptr M03_L13
M03_L01:
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M03_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M03_L03
M03_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389ECD28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M03_L03:
       mov       rcx,2277E639D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-18]
       mov       r9,2277E630008
       call      qword ptr [7FFE3851C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M03_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-38],rcx
       jmp       short M03_L05
M03_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389ECFE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M03_L05:
       mov       rcx,2277E63B6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2277E630008
       call      qword ptr [7FFE3851C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M03_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-48],rcx
       jmp       short M03_L07
M03_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389ED010
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M03_L07:
       mov       rcx,[rbp-48]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-50]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-50]
       call      qword ptr [rax]
       mov       [rbp-54],eax
       mov       ecx,[rbp-54]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        short M03_L10
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-88],rcx
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L08
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+38],0
       je        short M03_L08
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+38]
       mov       [rbp-70],rcx
       jmp       short M03_L09
M03_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389ED0C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-70],rax
M03_L09:
       mov       rcx,[rbp-70]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-78]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-78]
       call      qword ptr [rax]
       mov       [rbp-7C],eax
       nop
       nop
M03_L10:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M03_L11
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-60],rcx
       jmp       short M03_L12
M03_L11:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389ED028
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M03_L12:
       mov       rcx,[rbp-60]
       mov       [rbp-68],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-68]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-68]
       call      qword ptr [rax]
       nop
M03_L13:
       nop
       add       rsp,0B0
       pop       rbp
       ret
; Total bytes of code 641
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE3838F390],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE389ED2B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38A0CB28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       rcx,rbx
       call      qword ptr [7FFE383E4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE384ECAE0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE383E4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       r9,rax
       mov       r8,rdi
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE38A2C9C0]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,rbx
       mov       r8,rsi
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE38A2C9F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 103
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383AF390],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+40]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,28
       sub       rsp,28
       lea       rbp,[rsp+30]
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383AFDD0],0
       cmp       dword ptr [7FFE383AFDD0],0
       je        short M02_L00
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rax,[rbp+10]
M02_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+30]
       mov       rax,[rax+30]
       add       rsp,28
       add       rsp,28
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FFE384EDD78],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+28],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M03_L01
       nop
       nop
       jmp       near ptr M03_L13
M03_L01:
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M03_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M03_L03
M03_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE38A0B510
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M03_L03:
       mov       rcx,2B3B1809D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-18]
       mov       r9,2B3B1800008
       call      qword ptr [7FFE3853C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M03_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-38],rcx
       jmp       short M03_L05
M03_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE38A0B7D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M03_L05:
       mov       rcx,2B3B180B6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2B3B1800008
       call      qword ptr [7FFE3853C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M03_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-48],rcx
       jmp       short M03_L07
M03_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE38A0B7F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M03_L07:
       mov       rcx,[rbp-48]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-50]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-50]
       call      qword ptr [rax]
       mov       [rbp-54],eax
       mov       ecx,[rbp-54]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        short M03_L10
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-88],rcx
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L08
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+38],0
       je        short M03_L08
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+38]
       mov       [rbp-70],rcx
       jmp       short M03_L09
M03_L08:
       mov       rcx,[rbp+10]
       mov       rdx,offset System.Threading.Interlocked.CompareExchange[[System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[T], System.Private.CoreLib]](MemberInfoCache`1<!!0> ByRef, MemberInfoCache`1<!!0>, MemberInfoCache`1<!!0>)
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-70],rax
M03_L09:
       mov       rcx,[rbp-70]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-78]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-78]
       call      qword ptr [rax]
       mov       [rbp-7C],eax
       nop
       nop
M03_L10:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M03_L11
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-60],rcx
       jmp       short M03_L12
M03_L11:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE38A0B810
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M03_L12:
       mov       rcx,[rbp-60]
       mov       [rbp-68],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-68]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-68]
       call      qword ptr [rax]
       nop
M03_L13:
       nop
       add       rsp,0B0
       pop       rbp
       ret
; Total bytes of code 641
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE383AF390],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE38A0BA98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38A2CB28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       rcx,rbx
       call      qword ptr [7FFE383C4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE384CCAE0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE383C4DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       r9,rax
       mov       r8,rdi
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE389FC9C0]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,rbx
       mov       r8,rsi
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE389FC9F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 103
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE3837F6A0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+40]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,28
       sub       rsp,28
       lea       rbp,[rsp+30]
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383A0288],0
       cmp       dword ptr [7FFE383A0288],0
       je        short M02_L00
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rax,[rbp+10]
M02_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+30]
       mov       rax,[rax+30]
       add       rsp,28
       add       rsp,28
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FFE384CDD78],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+28],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M03_L01
       nop
       nop
       jmp       near ptr M03_L13
M03_L01:
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M03_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M03_L03
M03_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389EBA58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M03_L03:
       mov       rcx,2C5EDC89D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-18]
       mov       r9,2C5EDC80008
       call      qword ptr [7FFE3851C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M03_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-38],rcx
       jmp       short M03_L05
M03_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389EBD18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M03_L05:
       mov       rcx,2C5EDC8B6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2C5EDC80008
       call      qword ptr [7FFE3851C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M03_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-48],rcx
       jmp       short M03_L07
M03_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389EBD40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M03_L07:
       mov       rcx,[rbp-48]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-50]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-50]
       call      qword ptr [rax]
       mov       [rbp-54],eax
       mov       ecx,[rbp-54]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        short M03_L10
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-88],rcx
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L08
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+38],0
       je        short M03_L08
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+38]
       mov       [rbp-70],rcx
       jmp       short M03_L09
M03_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389EBDF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-70],rax
M03_L09:
       mov       rcx,[rbp-70]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-78]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-78]
       call      qword ptr [rax]
       mov       [rbp-7C],eax
       nop
       nop
M03_L10:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M03_L11
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-60],rcx
       jmp       short M03_L12
M03_L11:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389EBD58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M03_L12:
       mov       rcx,[rbp-60]
       mov       [rbp-68],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-68]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-68]
       call      qword ptr [rax]
       nop
M03_L13:
       nop
       add       rsp,0B0
       pop       rbp
       ret
; Total bytes of code 641
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE3837F6A0],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE389EBFE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE389FCB28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE389267D8]; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE38926808]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       push      rdi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-28],rax
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE384FDD78],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388EEFD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L02:
       mov       rcx,245F0A5B6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,245F0A50008
       call      qword ptr [7FFE3854C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-30],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388EF0C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M01_L04:
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      qword ptr [7FFE38926268]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-28]
       add       rsp,58
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 243
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE383BF390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE38941880
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3892D8F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE389070A8]; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE389070D8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       push      rdi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-28],rax
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE384DDD78],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388CF1D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L02:
       mov       rcx,1FCBB0FB6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,1FCBB0F0008
       call      qword ptr [7FFE38557C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-30],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388CF2C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M01_L04:
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      qword ptr [7FFE38906B38]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-28]
       add       rsp,58
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 243
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE3838F650],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383D4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE38921AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3890DFB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE388E6DA8]; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE388E6DD8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       push      rdi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-28],rax
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE384BDD78],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388AF1D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L02:
       mov       rcx,15CABCEB6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,15CABCE0008
       call      qword ptr [7FFE38537C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-30],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388AF2C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M01_L04:
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      qword ptr [7FFE388E6838]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-28]
       add       rsp,58
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 243
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE3837F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE38901AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388EDFB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE388E70A8]; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE388E70D8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       push      rdi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-28],rax
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE384BDD78],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388AF1D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L02:
       mov       rcx,1C3329AB6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,1C3329A0008
       call      qword ptr [7FFE38537C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-30],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388AF2C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M01_L04:
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      qword ptr [7FFE388E6B38]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-28]
       add       rsp,58
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 243
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE3837F4E8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE38901AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388EDFB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE389F5D88]; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE389F5DB8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       push      rdi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-28],rax
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE384DDD78],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389CD6A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L02:
       mov       rcx,2C13EB8B6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2C13EB80008
       call      qword ptr [7FFE3852C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-30],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389CD790
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M01_L04:
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      qword ptr [7FFE389F5818]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-28]
       add       rsp,58
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 243
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE3839F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE389CFF40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE389FCAF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE38A1D080]; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE38A1D0B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       push      rdi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-28],rax
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE384EDD78],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE38A0BFC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L02:
       mov       rcx,2420255B6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,24202550008
       call      qword ptr [7FFE38567C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-30],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE38A0C0B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M01_L04:
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      qword ptr [7FFE38A1CB10]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-28]
       add       rsp,58
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 243
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE383AF380],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE38A0E860
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38A1FDC8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE38A0D230]; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE38A0D260]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       push      rdi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-28],rax
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE384CDD78],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389EC228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L02:
       mov       rcx,1E65A8DB6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,1E65A8D0008
       call      qword ptr [7FFE3851C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-30],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389EC318
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M01_L04:
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      qword ptr [7FFE38A0CCC0]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-28]
       add       rsp,58
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 243
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE3838F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE389EEAC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38A0FF78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE38A2D230]; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE38A2D260]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       push      rdi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-28],rax
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE384EDD78],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE38A0C650
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L02:
       mov       rcx,22A09B8B6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,22A09B80008
       call      qword ptr [7FFE3853C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-30],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE38A0C740
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M01_L04:
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      qword ptr [7FFE38A2CCC0]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-28]
       add       rsp,58
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 243
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE383AF390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE38A0EEF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38A2FF78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rsi
       push      rbx
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       lea       rcx,[rsp+20]
       lea       r9,[rsp+30]
       mov       r8,rsi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, Boolean ByRef)
       call      qword ptr [7FFE389068C8]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+30],0
       je        short M00_L00
       mov       r8,[rsp+20]
       mov       r9,[rsp+28]
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE38906868]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,rbx
       mov       r8,rsi
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE38906898]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FFE382A4F90]
       int       3
; Total bytes of code 135
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       [rbp+28],r9
       mov       rbx,rdx
       mov       rsi,r8
       test      rsi,rsi
       je        near ptr M01_L21
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FFE38044348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L22
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L04
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE38044348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L25
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M01_L05
M01_L02:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       jmp       short M01_L06
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FFE388CE788
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFE388CE978
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L01
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFE388CEAA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L06:
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       jne       short M01_L09
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L14
M01_L07:
       mov       rax,[rbp-48]
       mov       ecx,[rdi+0C]
       mov       r14,[rdi]
       cmp       ecx,[r14+38]
       jae       near ptr M01_L17
       mov       rdx,[r14+10]
       lea       r8d,[rcx+1]
       mov       [rdi+0C],r8d
       cmp       ecx,[rdx+8]
       jae       short M01_L08
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rdx+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L07
       mov       rdx,[rcx]
       mov       r14,[rcx+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       short M01_L11
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L09:
       mov       rcx,rax
       mov       r11,7FFE37F00D50
       call      qword ptr [r11]
       mov       ecx,eax
       mov       rax,[rbp-48]
M01_L10:
       test      ecx,ecx
       je        near ptr M01_L31
M01_L11:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L15
M01_L12:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       call      qword ptr [r11]
       cmp       rsi,r15
       jne       short M01_L16
       mov       rcx,[rbp-48]
       lea       rdi,[rcx+8]
       mov       edx,[rdi+8]
       mov       rax,[rdi]
       cmp       edx,[rax+44]
       jne       short M01_L14
M01_L13:
       mov       edx,[rdi+0C]
       mov       rax,[rdi]
       mov       r14d,[rax+38]
       cmp       edx,r14d
       jb        short M01_L18
       inc       r14d
       mov       [rdi+0C],r14d
       xor       r11d,r11d
       mov       [rdi+18],r11
       mov       [rdi+20],r11
       mov       rcx,[rbp-48]
       jmp       near ptr M01_L19
M01_L14:
       call      qword ptr [7FFE3827EFB8]
       int       3
M01_L15:
       mov       rcx,rbx
       mov       rdx,7FFE388CEAC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       mov       rax,[rbp-48]
       jmp       short M01_L12
M01_L16:
       mov       rcx,[rbp-48]
       mov       r11,7FFE37F00D58
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-48]
       jne       near ptr M01_L11
       mov       rcx,rax
       jmp       short M01_L19
M01_L17:
       mov       ecx,[r14+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       near ptr M01_L10
M01_L18:
       mov       rax,[rax+10]
       lea       r8d,[rdx+1]
       mov       [rdi+0C],r8d
       cmp       edx,[rax+8]
       jae       near ptr M01_L08
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rax+rdx*8+10]
       cmp       dword ptr [rdx+14],0FFFFFFFF
       jl        near ptr M01_L13
       mov       rax,[rdx]
       mov       r14,[rdx+8]
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       near ptr M01_L11
M01_L19:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rdi,[rbp-40]
       mov       r14,[rbp-38]
       cmp       rsi,r15
       jne       near ptr M01_L30
M01_L20:
       mov       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       mov       ecx,10
       call      qword ptr [7FFE382A4F30]
       int       3
M01_L22:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L23
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rcx,rbx
       mov       rdx,7FFE388CEC50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L24:
       mov       rcx,rdi
       mov       rdx,[rbp+10]
       mov       r8,[rbp+28]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L25:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L26
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L26
       jmp       short M01_L27
M01_L26:
       mov       rcx,rbx
       mov       rdx,7FFE388CEC20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L27:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jle       short M01_L32
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L28
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L28
       jmp       short M01_L29
M01_L28:
       mov       rcx,rbx
       mov       rdx,7FFE388CEC38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L29:
       lea       r8d,[rsi-1]
       mov       rcx,r14
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L30:
       mov       r11,7FFE37F00D60
       call      qword ptr [r11]
       jmp       near ptr M01_L20
M01_L31:
       mov       rcx,rsp
       call      M01_L33
       nop
M01_L32:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],0
       xor       eax,eax
       mov       rdx,[rbp+10]
       mov       [rdx],rax
       mov       [rdx+8],rax
       mov       rax,rdx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L33:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-48],0
       je        short M01_L34
       mov       rax,[rbp-48]
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       je        short M01_L34
       mov       rcx,rax
       mov       r11,7FFE37F00D60
       call      qword ptr [r11]
M01_L34:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1084
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FFE384DDD78],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+28],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       nop
       jmp       near ptr M02_L13
M02_L01:
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388CEF50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L03:
       mov       rcx,22843539D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-18]
       mov       r9,22843530008
       call      qword ptr [7FFE38557C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-38],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388CF210
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M02_L05:
       mov       rcx,2284353B6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,22843530008
       call      qword ptr [7FFE38557C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-48],rcx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388CF238
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L07:
       mov       rcx,[rbp-48]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-50]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-50]
       call      qword ptr [rax]
       mov       [rbp-54],eax
       mov       ecx,[rbp-54]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        short M02_L10
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-88],rcx
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L08
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+38],0
       je        short M02_L08
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+38]
       mov       [rbp-70],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388CF2F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-70],rax
M02_L09:
       mov       rcx,[rbp-70]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-78]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-78]
       call      qword ptr [rax]
       mov       [rbp-7C],eax
       nop
       nop
M02_L10:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L11
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-60],rcx
       jmp       short M02_L12
M02_L11:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388CF250
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M02_L12:
       mov       rcx,[rbp-60]
       mov       [rbp-68],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-68]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-68]
       call      qword ptr [rax]
       nop
M02_L13:
       nop
       add       rsp,0B0
       pop       rbp
       ret
; Total bytes of code 641
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE3839F380],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383D4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE388CF4D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38906AF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rsi
       push      rbx
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       lea       rcx,[rsp+20]
       lea       r9,[rsp+30]
       mov       r8,rsi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, Boolean ByRef)
       call      qword ptr [7FFE389168C8]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+30],0
       je        short M00_L00
       mov       r8,[rsp+20]
       mov       r9,[rsp+28]
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE38916868]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,rbx
       mov       r8,rsi
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE38916898]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FFE382B4F90]
       int       3
; Total bytes of code 135
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       [rbp+28],r9
       mov       rbx,rdx
       mov       rsi,r8
       test      rsi,rsi
       je        near ptr M01_L21
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FFE38054348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L22
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L04
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE38054348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L25
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M01_L05
M01_L02:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       jmp       short M01_L06
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FFE388DE788
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFE388DE978
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L01
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFE388DEAA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L06:
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       jne       short M01_L09
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L14
M01_L07:
       mov       rax,[rbp-48]
       mov       ecx,[rdi+0C]
       mov       r14,[rdi]
       cmp       ecx,[r14+38]
       jae       near ptr M01_L17
       mov       rdx,[r14+10]
       lea       r8d,[rcx+1]
       mov       [rdi+0C],r8d
       cmp       ecx,[rdx+8]
       jae       short M01_L08
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rdx+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L07
       mov       rdx,[rcx]
       mov       r14,[rcx+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       short M01_L11
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L09:
       mov       rcx,rax
       mov       r11,7FFE37F10D50
       call      qword ptr [r11]
       mov       ecx,eax
       mov       rax,[rbp-48]
M01_L10:
       test      ecx,ecx
       je        near ptr M01_L31
M01_L11:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L15
M01_L12:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       call      qword ptr [r11]
       cmp       rsi,r15
       jne       short M01_L16
       mov       rcx,[rbp-48]
       lea       rdi,[rcx+8]
       mov       edx,[rdi+8]
       mov       rax,[rdi]
       cmp       edx,[rax+44]
       jne       short M01_L14
M01_L13:
       mov       edx,[rdi+0C]
       mov       rax,[rdi]
       mov       r14d,[rax+38]
       cmp       edx,r14d
       jb        short M01_L18
       inc       r14d
       mov       [rdi+0C],r14d
       xor       r11d,r11d
       mov       [rdi+18],r11
       mov       [rdi+20],r11
       mov       rcx,[rbp-48]
       jmp       near ptr M01_L19
M01_L14:
       call      qword ptr [7FFE3828EFB8]
       int       3
M01_L15:
       mov       rcx,rbx
       mov       rdx,7FFE388DEAC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       mov       rax,[rbp-48]
       jmp       short M01_L12
M01_L16:
       mov       rcx,[rbp-48]
       mov       r11,7FFE37F10D58
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-48]
       jne       near ptr M01_L11
       mov       rcx,rax
       jmp       short M01_L19
M01_L17:
       mov       ecx,[r14+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       near ptr M01_L10
M01_L18:
       mov       rax,[rax+10]
       lea       r8d,[rdx+1]
       mov       [rdi+0C],r8d
       cmp       edx,[rax+8]
       jae       near ptr M01_L08
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rax+rdx*8+10]
       cmp       dword ptr [rdx+14],0FFFFFFFF
       jl        near ptr M01_L13
       mov       rax,[rdx]
       mov       r14,[rdx+8]
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       near ptr M01_L11
M01_L19:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rdi,[rbp-40]
       mov       r14,[rbp-38]
       cmp       rsi,r15
       jne       near ptr M01_L30
M01_L20:
       mov       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       mov       ecx,10
       call      qword ptr [7FFE382B4F30]
       int       3
M01_L22:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L23
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rcx,rbx
       mov       rdx,7FFE388DEC50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L24:
       mov       rcx,rdi
       mov       rdx,[rbp+10]
       mov       r8,[rbp+28]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L25:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L26
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L26
       jmp       short M01_L27
M01_L26:
       mov       rcx,rbx
       mov       rdx,7FFE388DEC20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L27:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jle       short M01_L32
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L28
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L28
       jmp       short M01_L29
M01_L28:
       mov       rcx,rbx
       mov       rdx,7FFE388DEC38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L29:
       lea       r8d,[rsi-1]
       mov       rcx,r14
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L30:
       mov       r11,7FFE37F10D60
       call      qword ptr [r11]
       jmp       near ptr M01_L20
M01_L31:
       mov       rcx,rsp
       call      M01_L33
       nop
M01_L32:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],0
       xor       eax,eax
       mov       rdx,[rbp+10]
       mov       [rdx],rax
       mov       [rdx+8],rax
       mov       rax,rdx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L33:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-48],0
       je        short M01_L34
       mov       rax,[rbp-48]
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       je        short M01_L34
       mov       rcx,rax
       mov       r11,7FFE37F10D60
       call      qword ptr [r11]
M01_L34:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1084
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FFE384EDD78],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+28],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       nop
       jmp       near ptr M02_L13
M02_L01:
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388DEF50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L03:
       mov       rcx,298924B9D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-18]
       mov       r9,298924B0008
       call      qword ptr [7FFE38567C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-38],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388DF210
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M02_L05:
       mov       rcx,298924BB6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,298924B0008
       call      qword ptr [7FFE38567C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-48],rcx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388DF238
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L07:
       mov       rcx,[rbp-48]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-50]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-50]
       call      qword ptr [rax]
       mov       [rbp-54],eax
       mov       ecx,[rbp-54]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        short M02_L10
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-88],rcx
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L08
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+38],0
       je        short M02_L08
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+38]
       mov       [rbp-70],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388DF2F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-70],rax
M02_L09:
       mov       rcx,[rbp-70]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-78]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-78]
       call      qword ptr [rax]
       mov       [rbp-7C],eax
       nop
       nop
M02_L10:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L11
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-60],rcx
       jmp       short M02_L12
M02_L11:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388DF250
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M02_L12:
       mov       rcx,[rbp-60]
       mov       [rbp-68],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-68]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-68]
       call      qword ptr [rax]
       nop
M02_L13:
       nop
       add       rsp,0B0
       pop       rbp
       ret
; Total bytes of code 641
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE383AF3E0],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE388DF4D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38916AF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rsi
       push      rbx
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       lea       rcx,[rsp+20]
       lea       r9,[rsp+30]
       mov       r8,rsi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, Boolean ByRef)
       call      qword ptr [7FFE388E68C8]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+30],0
       je        short M00_L00
       mov       r8,[rsp+20]
       mov       r9,[rsp+28]
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE388E6868]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,rbx
       mov       r8,rsi
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE388E6898]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FFE38284F90]
       int       3
; Total bytes of code 135
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       [rbp+28],r9
       mov       rbx,rdx
       mov       rsi,r8
       test      rsi,rsi
       je        near ptr M01_L22
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FFE38024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L23
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L04
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE38024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L26
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M01_L05
M01_L02:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       jmp       short M01_L06
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FFE388AE788
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFE388AE978
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L01
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFE388AEAA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L06:
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       jne       short M01_L09
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L16
M01_L07:
       mov       rax,[rbp-48]
       mov       ecx,[rdi+0C]
       mov       r14,[rdi]
       cmp       ecx,[r14+38]
       jae       near ptr M01_L19
       mov       rdx,[r14+10]
       lea       r8d,[rcx+1]
       mov       [rdi+0C],r8d
       cmp       ecx,[rdx+8]
       jae       short M01_L08
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rdx+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L07
       mov       rdx,[rcx]
       mov       r14,[rcx+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       short M01_L11
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L09:
       mov       rcx,rax
       mov       r11,7FFE37EE0D50
       call      qword ptr [r11]
       mov       ecx,eax
       mov       rax,[rbp-48]
M01_L10:
       test      ecx,ecx
       je        near ptr M01_L32
M01_L11:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L17
M01_L12:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       call      qword ptr [r11]
       cmp       rsi,r15
       jne       short M01_L14
       mov       rcx,[rbp-48]
       lea       rdi,[rcx+8]
       mov       edx,[rdi+8]
       mov       rax,[rdi]
       cmp       edx,[rax+44]
       jne       near ptr M01_L16
M01_L13:
       mov       edx,[rdi+0C]
       mov       r14,[rdi]
       cmp       edx,[r14+38]
       jae       short M01_L15
       mov       rax,[r14+10]
       lea       r8d,[rdx+1]
       mov       [rdi+0C],r8d
       cmp       edx,[rax+8]
       jae       short M01_L08
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rax+rdx*8+10]
       cmp       dword ptr [rdx+14],0FFFFFFFF
       jl        short M01_L13
       mov       rax,[rdx]
       mov       r14,[rdx+8]
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       near ptr M01_L11
M01_L14:
       mov       rcx,[rbp-48]
       mov       r11,7FFE37EE0D58
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-48]
       jne       near ptr M01_L11
       mov       rcx,rax
       jmp       short M01_L18
M01_L15:
       mov       r11d,[r14+38]
       inc       r11d
       mov       [rdi+0C],r11d
       xor       r11d,r11d
       mov       [rdi+18],r11
       mov       [rdi+20],r11
       mov       rcx,[rbp-48]
       jmp       short M01_L18
M01_L16:
       call      qword ptr [7FFE3825EFB8]
       int       3
M01_L17:
       mov       rcx,rbx
       mov       rdx,7FFE388AEAC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       mov       rax,[rbp-48]
       jmp       near ptr M01_L12
M01_L18:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rdi,[rbp-40]
       mov       r14,[rbp-38]
       jmp       short M01_L20
M01_L19:
       mov       ecx,[r14+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       near ptr M01_L10
M01_L20:
       cmp       rsi,r15
       jne       near ptr M01_L31
M01_L21:
       mov       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,10
       call      qword ptr [7FFE38284F30]
       int       3
M01_L23:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L24
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L24
       jmp       short M01_L25
M01_L24:
       mov       rcx,rbx
       mov       rdx,7FFE388AEC50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L25:
       mov       rcx,rdi
       mov       rdx,[rbp+10]
       mov       r8,[rbp+28]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L26:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L27
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L27
       jmp       short M01_L28
M01_L27:
       mov       rcx,rbx
       mov       rdx,7FFE388AEC20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L28:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jle       short M01_L33
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L29
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L29
       jmp       short M01_L30
M01_L29:
       mov       rcx,rbx
       mov       rdx,7FFE388AEC38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L30:
       lea       r8d,[rsi-1]
       mov       rcx,r14
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L31:
       mov       r11,7FFE37EE0D60
       call      qword ptr [r11]
       jmp       near ptr M01_L21
M01_L32:
       mov       rcx,rsp
       call      M01_L34
       nop
M01_L33:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],0
       xor       eax,eax
       mov       rdx,[rbp+10]
       mov       [rdx],rax
       mov       [rdx+8],rax
       mov       rax,rdx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L34:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-48],0
       je        short M01_L35
       mov       rax,[rbp-48]
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       je        short M01_L35
       mov       rcx,rax
       mov       r11,7FFE37EE0D60
       call      qword ptr [r11]
M01_L35:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1087
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FFE384BDD78],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+28],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       nop
       jmp       near ptr M02_L13
M02_L01:
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388AEF50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L03:
       mov       rcx,269F5229D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-18]
       mov       r9,269F5220008
       call      qword ptr [7FFE3850C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-38],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388AF210
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M02_L05:
       mov       rcx,269F522B6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,269F5220008
       call      qword ptr [7FFE3850C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-48],rcx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388AF238
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L07:
       mov       rcx,[rbp-48]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-50]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-50]
       call      qword ptr [rax]
       mov       [rbp-54],eax
       mov       ecx,[rbp-54]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        short M02_L10
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-88],rcx
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L08
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+38],0
       je        short M02_L08
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+38]
       mov       [rbp-70],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388AF2F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-70],rax
M02_L09:
       mov       rcx,[rbp-70]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-78]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-78]
       call      qword ptr [rax]
       mov       [rbp-7C],eax
       nop
       nop
M02_L10:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L11
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-60],rcx
       jmp       short M02_L12
M02_L11:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388AF250
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M02_L12:
       mov       rcx,[rbp-60]
       mov       [rbp-68],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-68]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-68]
       call      qword ptr [rax]
       nop
M02_L13:
       nop
       add       rsp,0B0
       pop       rbp
       ret
; Total bytes of code 641
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE3837F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE388AF4D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388E6AF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rsi
       push      rbx
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       lea       rcx,[rsp+20]
       lea       r9,[rsp+30]
       mov       r8,rsi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, Boolean ByRef)
       call      qword ptr [7FFE3899D5A8]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+30],0
       je        short M00_L00
       mov       r8,[rsp+20]
       mov       r9,[rsp+28]
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE3899D548]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,rbx
       mov       r8,rsi
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE3899D578]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FFE38294F90]
       int       3
; Total bytes of code 135
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       [rbp+28],r9
       mov       rbx,rdx
       mov       rsi,r8
       test      rsi,rsi
       je        near ptr M01_L22
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FFE38034348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L23
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L04
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE38034348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L26
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M01_L05
M01_L02:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       jmp       short M01_L06
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FFE388EE320
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFE388EE510
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L01
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFE388EE640
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L06:
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       jne       short M01_L09
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L16
M01_L07:
       mov       rax,[rbp-48]
       mov       ecx,[rdi+0C]
       mov       r14,[rdi]
       cmp       ecx,[r14+38]
       jae       near ptr M01_L19
       mov       rdx,[r14+10]
       lea       r8d,[rcx+1]
       mov       [rdi+0C],r8d
       cmp       ecx,[rdx+8]
       jae       short M01_L08
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rdx+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L07
       mov       rdx,[rcx]
       mov       r14,[rcx+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       short M01_L11
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L09:
       mov       rcx,rax
       mov       r11,7FFE37EF0DA0
       call      qword ptr [r11]
       mov       ecx,eax
       mov       rax,[rbp-48]
M01_L10:
       test      ecx,ecx
       je        near ptr M01_L32
M01_L11:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L17
M01_L12:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       call      qword ptr [r11]
       cmp       rsi,r15
       jne       short M01_L14
       mov       rcx,[rbp-48]
       lea       rdi,[rcx+8]
       mov       edx,[rdi+8]
       mov       rax,[rdi]
       cmp       edx,[rax+44]
       jne       near ptr M01_L16
M01_L13:
       mov       edx,[rdi+0C]
       mov       r14,[rdi]
       cmp       edx,[r14+38]
       jae       short M01_L15
       mov       rax,[r14+10]
       lea       r8d,[rdx+1]
       mov       [rdi+0C],r8d
       cmp       edx,[rax+8]
       jae       short M01_L08
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rax+rdx*8+10]
       cmp       dword ptr [rdx+14],0FFFFFFFF
       jl        short M01_L13
       mov       rax,[rdx]
       mov       r14,[rdx+8]
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       near ptr M01_L11
M01_L14:
       mov       rcx,[rbp-48]
       mov       r11,7FFE37EF0DA8
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-48]
       jne       near ptr M01_L11
       mov       rcx,rax
       jmp       short M01_L18
M01_L15:
       mov       r11d,[r14+38]
       inc       r11d
       mov       [rdi+0C],r11d
       xor       r11d,r11d
       mov       [rdi+18],r11
       mov       [rdi+20],r11
       mov       rcx,[rbp-48]
       jmp       short M01_L18
M01_L16:
       call      qword ptr [7FFE3826EFB8]
       int       3
M01_L17:
       mov       rcx,rbx
       mov       rdx,7FFE388EE658
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       mov       rax,[rbp-48]
       jmp       near ptr M01_L12
M01_L18:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rdi,[rbp-40]
       mov       r14,[rbp-38]
       jmp       short M01_L20
M01_L19:
       mov       ecx,[r14+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       near ptr M01_L10
M01_L20:
       cmp       rsi,r15
       jne       near ptr M01_L31
M01_L21:
       mov       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,10
       call      qword ptr [7FFE38294F30]
       int       3
M01_L23:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L24
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L24
       jmp       short M01_L25
M01_L24:
       mov       rcx,rbx
       mov       rdx,7FFE388EE7E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L25:
       mov       rcx,rdi
       mov       rdx,[rbp+10]
       mov       r8,[rbp+28]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L26:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L27
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L27
       jmp       short M01_L28
M01_L27:
       mov       rcx,rbx
       mov       rdx,7FFE388EE7B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L28:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jle       short M01_L33
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L29
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L29
       jmp       short M01_L30
M01_L29:
       mov       rcx,rbx
       mov       rdx,7FFE388EE7D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L30:
       lea       r8d,[rsi-1]
       mov       rcx,r14
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L31:
       mov       r11,7FFE37EF0DB0
       call      qword ptr [r11]
       jmp       near ptr M01_L21
M01_L32:
       mov       rcx,rsp
       call      M01_L34
       nop
M01_L33:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],0
       xor       eax,eax
       mov       rdx,[rbp+10]
       mov       [rdx],rax
       mov       [rdx+8],rax
       mov       rax,rdx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L34:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-48],0
       je        short M01_L35
       mov       rax,[rbp-48]
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       je        short M01_L35
       mov       rcx,rax
       mov       r11,7FFE37EF0DB0
       call      qword ptr [r11]
M01_L35:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1087
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FFE384CDD78],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+28],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       nop
       jmp       near ptr M02_L13
M02_L01:
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388EEAE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L03:
       mov       rcx,2B70DE19D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-18]
       mov       r9,2B70DE10008
       call      qword ptr [7FFE3851C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-38],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388EEDA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M02_L05:
       mov       rcx,2B70DE1B6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2B70DE10008
       call      qword ptr [7FFE3851C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-48],rcx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388EEDD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L07:
       mov       rcx,[rbp-48]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-50]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-50]
       call      qword ptr [rax]
       mov       [rbp-54],eax
       mov       ecx,[rbp-54]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        short M02_L10
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-88],rcx
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L08
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+38],0
       je        short M02_L08
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+38]
       mov       [rbp-70],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388EEE88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-70],rax
M02_L09:
       mov       rcx,[rbp-70]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-78]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-78]
       call      qword ptr [rax]
       mov       [rbp-7C],eax
       nop
       nop
M02_L10:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L11
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-60],rcx
       jmp       short M02_L12
M02_L11:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE388EEDE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M02_L12:
       mov       rcx,[rbp-60]
       mov       [rbp-68],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-68]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-68]
       call      qword ptr [rax]
       nop
M02_L13:
       nop
       add       rsp,0B0
       pop       rbp
       ret
; Total bytes of code 641
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE3838F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE388EF070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3899D7D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rsi
       push      rbx
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       lea       rcx,[rsp+20]
       lea       r9,[rsp+30]
       mov       r8,rsi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, Boolean ByRef)
       call      qword ptr [7FFE389EC8A0]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+30],0
       je        short M00_L00
       mov       r8,[rsp+20]
       mov       r9,[rsp+28]
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE389EC840]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,rbx
       mov       r8,rsi
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE389EC870]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FFE38284F90]
       int       3
; Total bytes of code 135
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       [rbp+28],r9
       mov       rbx,rdx
       mov       rsi,r8
       test      rsi,rsi
       je        near ptr M01_L24
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FFE38024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L25
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L05
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE38024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L28
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M01_L06
M01_L02:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       jmp       short M01_L07
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FFE389DB500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFE389DBE80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FFE389DBFB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L07:
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       jne       short M01_L10
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L20
M01_L08:
       mov       rax,[rbp-48]
       mov       ecx,[rdi+0C]
       mov       r14,[rdi]
       cmp       ecx,[r14+38]
       jae       near ptr M01_L19
       mov       rdx,[r14+10]
       lea       r8d,[rcx+1]
       mov       [rdi+0C],r8d
       cmp       ecx,[rdx+8]
       jae       short M01_L09
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rdx+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L08
       mov       rdx,[rcx]
       mov       r14,[rcx+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       short M01_L12
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L10:
       mov       rcx,rax
       mov       r11,7FFE37EE0E88
       call      qword ptr [r11]
       mov       ecx,eax
       mov       rax,[rbp-48]
M01_L11:
       test      ecx,ecx
       je        near ptr M01_L22
M01_L12:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L18
M01_L13:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       call      qword ptr [r11]
       cmp       rsi,r15
       jne       short M01_L15
       mov       rcx,[rbp-48]
       lea       rdi,[rcx+8]
       mov       edx,[rdi+8]
       mov       rax,[rdi]
       cmp       edx,[rax+44]
       jne       near ptr M01_L20
M01_L14:
       mov       edx,[rdi+0C]
       mov       r14,[rdi]
       cmp       edx,[r14+38]
       jae       short M01_L16
       mov       rax,[r14+10]
       lea       r8d,[rdx+1]
       mov       [rdi+0C],r8d
       cmp       edx,[rax+8]
       jae       short M01_L09
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rax+rdx*8+10]
       cmp       dword ptr [rdx+14],0FFFFFFFF
       jl        short M01_L14
       mov       rax,[rdx]
       mov       r14,[rdx+8]
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       near ptr M01_L12
M01_L15:
       mov       rcx,[rbp-48]
       mov       r11,7FFE37EE0E90
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-48]
       jne       near ptr M01_L12
       mov       rcx,rax
       jmp       short M01_L17
M01_L16:
       mov       r11d,[r14+38]
       inc       r11d
       mov       [rdi+0C],r11d
       xor       r11d,r11d
       mov       [rdi+18],r11
       mov       [rdi+20],r11
       mov       rcx,[rbp-48]
M01_L17:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rdi,[rbp-40]
       mov       r14,[rbp-38]
       jmp       short M01_L21
M01_L18:
       mov       rcx,rbx
       mov       rdx,7FFE389DBFC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       mov       rax,[rbp-48]
       jmp       near ptr M01_L13
M01_L19:
       mov       ecx,[r14+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       near ptr M01_L11
M01_L20:
       call      qword ptr [7FFE3825EFB8]
       int       3
M01_L21:
       cmp       rsi,r15
       je        near ptr M01_L04
       mov       r11,7FFE37EE0E98
       call      qword ptr [r11]
       jmp       near ptr M01_L04
M01_L22:
       mov       rcx,rsp
       call      M01_L33
       nop
M01_L23:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],0
       xor       eax,eax
       mov       rdx,[rbp+10]
       mov       [rdx],rax
       mov       [rdx+8],rax
       mov       rax,rdx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L24:
       mov       ecx,10
       call      qword ptr [7FFE38284F30]
       int       3
M01_L25:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L26
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L26
       jmp       short M01_L27
M01_L26:
       mov       rcx,rbx
       mov       rdx,7FFE389DC158
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L27:
       mov       rcx,rdi
       mov       rdx,[rbp+10]
       mov       r8,[rbp+28]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L28:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L29
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L29
       jmp       short M01_L30
M01_L29:
       mov       rcx,rbx
       mov       rdx,7FFE389DC128
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L30:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jle       near ptr M01_L23
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L31
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L31
       jmp       short M01_L32
M01_L31:
       mov       rcx,rbx
       mov       rdx,7FFE389DC140
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L32:
       lea       r8d,[rsi-1]
       mov       rcx,r14
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L33:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-48],0
       je        short M01_L34
       mov       rax,[rbp-48]
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       je        short M01_L34
       mov       rcx,rax
       mov       r11,7FFE37EE0E98
       call      qword ptr [r11]
M01_L34:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1095
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FFE384BDD78],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+28],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       nop
       jmp       near ptr M02_L13
M02_L01:
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389DC458
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L03:
       mov       rcx,1E49C7A9D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-18]
       mov       r9,1E49C7A0008
       call      qword ptr [7FFE38537C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-38],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389DC718
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M02_L05:
       mov       rcx,1E49C7AB6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,1E49C7A0008
       call      qword ptr [7FFE38537C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-48],rcx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389DC740
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L07:
       mov       rcx,[rbp-48]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-50]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-50]
       call      qword ptr [rax]
       mov       [rbp-54],eax
       mov       ecx,[rbp-54]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        short M02_L10
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-88],rcx
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L08
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+38],0
       je        short M02_L08
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+38]
       mov       [rbp-70],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389DC7F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-70],rax
M02_L09:
       mov       rcx,[rbp-70]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-78]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-78]
       call      qword ptr [rax]
       mov       [rbp-7C],eax
       nop
       nop
M02_L10:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L11
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-60],rcx
       jmp       short M02_L12
M02_L11:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389DC758
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M02_L12:
       mov       rcx,[rbp-60]
       mov       [rbp-68],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-68]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-68]
       call      qword ptr [rax]
       nop
M02_L13:
       nop
       add       rsp,0B0
       pop       rbp
       ret
; Total bytes of code 641
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE3837F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE389DC9E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE389ECAC8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rsi
       push      rbx
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       lea       rcx,[rsp+20]
       lea       r9,[rsp+30]
       mov       r8,rsi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, Boolean ByRef)
       call      qword ptr [7FFE38A0CA50]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+30],0
       je        short M00_L00
       mov       r8,[rsp+20]
       mov       r9,[rsp+28]
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE38A0C9F0]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,rbx
       mov       r8,rsi
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE38A0CA20]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FFE38294F90]
       int       3
; Total bytes of code 135
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       [rbp+28],r9
       mov       rbx,rdx
       mov       rsi,r8
       test      rsi,rsi
       je        near ptr M01_L22
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FFE38034348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L23
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L04
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE38034348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L26
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M01_L05
M01_L02:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       jmp       short M01_L06
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FFE389ED008
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFE389ED988
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L01
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFE389EDAB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L06:
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       jne       short M01_L09
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L16
M01_L07:
       mov       rax,[rbp-48]
       mov       ecx,[rdi+0C]
       mov       r14,[rdi]
       cmp       ecx,[r14+38]
       jae       near ptr M01_L19
       mov       rdx,[r14+10]
       lea       r8d,[rcx+1]
       mov       [rdi+0C],r8d
       cmp       ecx,[rdx+8]
       jae       short M01_L08
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rdx+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L07
       mov       rdx,[rcx]
       mov       r14,[rcx+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       short M01_L11
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L09:
       mov       rcx,rax
       mov       r11,7FFE37EF0F70
       call      qword ptr [r11]
       mov       ecx,eax
       mov       rax,[rbp-48]
M01_L10:
       test      ecx,ecx
       je        near ptr M01_L32
M01_L11:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L17
M01_L12:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       call      qword ptr [r11]
       cmp       rsi,r15
       jne       short M01_L14
       mov       rcx,[rbp-48]
       lea       rdi,[rcx+8]
       mov       edx,[rdi+8]
       mov       rax,[rdi]
       cmp       edx,[rax+44]
       jne       near ptr M01_L16
M01_L13:
       mov       edx,[rdi+0C]
       mov       r14,[rdi]
       cmp       edx,[r14+38]
       jae       short M01_L15
       mov       rax,[r14+10]
       lea       r8d,[rdx+1]
       mov       [rdi+0C],r8d
       cmp       edx,[rax+8]
       jae       short M01_L08
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rax+rdx*8+10]
       cmp       dword ptr [rdx+14],0FFFFFFFF
       jl        short M01_L13
       mov       rax,[rdx]
       mov       r14,[rdx+8]
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       near ptr M01_L11
M01_L14:
       mov       rcx,[rbp-48]
       mov       r11,7FFE37EF0F78
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-48]
       jne       near ptr M01_L11
       mov       rcx,rax
       jmp       short M01_L18
M01_L15:
       mov       r11d,[r14+38]
       inc       r11d
       mov       [rdi+0C],r11d
       xor       r11d,r11d
       mov       [rdi+18],r11
       mov       [rdi+20],r11
       mov       rcx,[rbp-48]
       jmp       short M01_L18
M01_L16:
       call      qword ptr [7FFE3826EFB8]
       int       3
M01_L17:
       mov       rcx,rbx
       mov       rdx,7FFE389EDAD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       mov       rax,[rbp-48]
       jmp       near ptr M01_L12
M01_L18:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rdi,[rbp-40]
       mov       r14,[rbp-38]
       jmp       short M01_L20
M01_L19:
       mov       ecx,[r14+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       near ptr M01_L10
M01_L20:
       cmp       rsi,r15
       jne       near ptr M01_L31
M01_L21:
       mov       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,10
       call      qword ptr [7FFE38294F30]
       int       3
M01_L23:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L24
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L24
       jmp       short M01_L25
M01_L24:
       mov       rcx,rbx
       mov       rdx,7FFE389EDC60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L25:
       mov       rcx,rdi
       mov       rdx,[rbp+10]
       mov       r8,[rbp+28]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L26:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L27
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L27
       jmp       short M01_L28
M01_L27:
       mov       rcx,rbx
       mov       rdx,7FFE389EDC30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L28:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jle       short M01_L33
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L29
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L29
       jmp       short M01_L30
M01_L29:
       mov       rcx,rbx
       mov       rdx,7FFE389EDC48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L30:
       lea       r8d,[rsi-1]
       mov       rcx,r14
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L31:
       mov       r11,7FFE37EF0F80
       call      qword ptr [r11]
       jmp       near ptr M01_L21
M01_L32:
       mov       rcx,rsp
       call      M01_L34
       nop
M01_L33:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],0
       xor       eax,eax
       mov       rdx,[rbp+10]
       mov       [rdx],rax
       mov       [rdx+8],rax
       mov       rax,rdx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L34:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-48],0
       je        short M01_L35
       mov       rax,[rbp-48]
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       je        short M01_L35
       mov       rcx,rax
       mov       r11,7FFE37EF0F80
       call      qword ptr [r11]
M01_L35:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1087
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FFE384CDD78],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+28],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       nop
       jmp       near ptr M02_L13
M02_L01:
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389EDF60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L03:
       mov       rcx,2CFADD59D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-18]
       mov       r9,2CFADD50008
       call      qword ptr [7FFE38547C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-38],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389EE220
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M02_L05:
       mov       rcx,2CFADD5B6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2CFADD50008
       call      qword ptr [7FFE38547C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-48],rcx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389EE248
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L07:
       mov       rcx,[rbp-48]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-50]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-50]
       call      qword ptr [rax]
       mov       [rbp-54],eax
       mov       ecx,[rbp-54]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        short M02_L10
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-88],rcx
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L08
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+38],0
       je        short M02_L08
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+38]
       mov       [rbp-70],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389EE300
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-70],rax
M02_L09:
       mov       rcx,[rbp-70]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-78]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-78]
       call      qword ptr [rax]
       mov       [rbp-7C],eax
       nop
       nop
M02_L10:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L11
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-60],rcx
       jmp       short M02_L12
M02_L11:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389EE260
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M02_L12:
       mov       rcx,[rbp-60]
       mov       [rbp-68],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-68]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-68]
       call      qword ptr [rax]
       nop
M02_L13:
       nop
       add       rsp,0B0
       pop       rbp
       ret
; Total bytes of code 641
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE3838F4A8],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383C4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE389EE4E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38A0CC78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rsi
       push      rbx
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       lea       rcx,[rsp+20]
       lea       r9,[rsp+30]
       mov       r8,rsi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, Boolean ByRef)
       call      qword ptr [7FFE38A1CA50]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+30],0
       je        short M00_L00
       mov       r8,[rsp+20]
       mov       r9,[rsp+28]
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE38A1C9F0]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,rbx
       mov       r8,rsi
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE38A1CA20]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FFE382A4F90]
       int       3
; Total bytes of code 135
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       [rbp+28],r9
       mov       rbx,rdx
       mov       rsi,r8
       test      rsi,rsi
       je        near ptr M01_L22
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FFE38044348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L23
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L04
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE38044348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L26
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M01_L05
M01_L02:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       jmp       short M01_L06
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FFE389FB7D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFE389FC158
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L01
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFE389FC288
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L06:
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       jne       short M01_L09
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L19
M01_L07:
       mov       rax,[rbp-48]
       mov       ecx,[rdi+0C]
       mov       r14,[rdi]
       cmp       ecx,[r14+38]
       jae       near ptr M01_L18
       mov       rdx,[r14+10]
       lea       r8d,[rcx+1]
       mov       [rdi+0C],r8d
       cmp       ecx,[rdx+8]
       jae       short M01_L08
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rdx+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L07
       mov       rdx,[rcx]
       mov       r14,[rcx+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       short M01_L11
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L09:
       mov       rcx,rax
       mov       r11,7FFE37F00F90
       call      qword ptr [r11]
       mov       ecx,eax
       mov       rax,[rbp-48]
M01_L10:
       test      ecx,ecx
       je        near ptr M01_L32
M01_L11:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L17
M01_L12:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       call      qword ptr [r11]
       cmp       rsi,r15
       jne       short M01_L14
       mov       rcx,[rbp-48]
       lea       rdi,[rcx+8]
       mov       edx,[rdi+8]
       mov       rax,[rdi]
       cmp       edx,[rax+44]
       jne       near ptr M01_L19
M01_L13:
       mov       edx,[rdi+0C]
       mov       r14,[rdi]
       cmp       edx,[r14+38]
       jae       short M01_L15
       mov       rax,[r14+10]
       lea       r8d,[rdx+1]
       mov       [rdi+0C],r8d
       cmp       edx,[rax+8]
       jae       short M01_L08
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rax+rdx*8+10]
       cmp       dword ptr [rdx+14],0FFFFFFFF
       jl        short M01_L13
       mov       rax,[rdx]
       mov       r14,[rdx+8]
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       near ptr M01_L11
M01_L14:
       mov       rcx,[rbp-48]
       mov       r11,7FFE37F00F98
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-48]
       jne       near ptr M01_L11
       mov       rcx,rax
       jmp       short M01_L16
M01_L15:
       mov       r11d,[r14+38]
       inc       r11d
       mov       [rdi+0C],r11d
       xor       r11d,r11d
       mov       [rdi+18],r11
       mov       [rdi+20],r11
       mov       rcx,[rbp-48]
M01_L16:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rdi,[rbp-40]
       mov       r14,[rbp-38]
       jmp       short M01_L20
M01_L17:
       mov       rcx,rbx
       mov       rdx,7FFE389FC2A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       mov       rax,[rbp-48]
       jmp       near ptr M01_L12
M01_L18:
       mov       ecx,[r14+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       near ptr M01_L10
M01_L19:
       call      qword ptr [7FFE3827EFB8]
       int       3
M01_L20:
       cmp       rsi,r15
       jne       near ptr M01_L31
M01_L21:
       mov       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,10
       call      qword ptr [7FFE382A4F30]
       int       3
M01_L23:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L24
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L24
       jmp       short M01_L25
M01_L24:
       mov       rcx,rbx
       mov       rdx,7FFE389FC430
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L25:
       mov       rcx,rdi
       mov       rdx,[rbp+10]
       mov       r8,[rbp+28]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L26:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L27
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L27
       jmp       short M01_L28
M01_L27:
       mov       rcx,rbx
       mov       rdx,7FFE389FC400
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L28:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jle       short M01_L33
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L29
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L29
       jmp       short M01_L30
M01_L29:
       mov       rcx,rbx
       mov       rdx,7FFE389FC418
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L30:
       lea       r8d,[rsi-1]
       mov       rcx,r14
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L31:
       mov       r11,7FFE37F00FA0
       call      qword ptr [r11]
       jmp       near ptr M01_L21
M01_L32:
       mov       rcx,rsp
       call      M01_L34
       nop
M01_L33:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],0
       xor       eax,eax
       mov       rdx,[rbp+10]
       mov       [rdx],rax
       mov       [rdx+8],rax
       mov       rax,rdx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L34:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-48],0
       je        short M01_L35
       mov       rax,[rbp-48]
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       je        short M01_L35
       mov       rcx,rax
       mov       r11,7FFE37F00FA0
       call      qword ptr [r11]
M01_L35:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1085
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FFE384DDD78],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+28],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       nop
       jmp       near ptr M02_L13
M02_L01:
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389FC740
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L03:
       mov       rcx,262EA4C9D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-18]
       mov       r9,262EA4C0008
       call      qword ptr [7FFE3852C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-38],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389FCA00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M02_L05:
       mov       rcx,262EA4CB6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,262EA4C0008
       call      qword ptr [7FFE3852C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-48],rcx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389FCA28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L07:
       mov       rcx,[rbp-48]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-50]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-50]
       call      qword ptr [rax]
       mov       [rbp-54],eax
       mov       ecx,[rbp-54]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        short M02_L10
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-88],rcx
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L08
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+38],0
       je        short M02_L08
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+38]
       mov       [rbp-70],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389FCAE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-70],rax
M02_L09:
       mov       rcx,[rbp-70]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-78]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-78]
       call      qword ptr [rax]
       mov       [rbp-7C],eax
       nop
       nop
M02_L10:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L11
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-60],rcx
       jmp       short M02_L12
M02_L11:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE389FCA40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M02_L12:
       mov       rcx,[rbp-60]
       mov       [rbp-68],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-68]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-68]
       call      qword ptr [rax]
       nop
M02_L13:
       nop
       add       rsp,0B0
       pop       rbp
       ret
; Total bytes of code 641
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE3839F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE389FCCC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38A1CC78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rsi
       push      rbx
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       lea       rcx,[rsp+20]
       lea       r9,[rsp+30]
       mov       r8,rsi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>, Boolean ByRef)
       call      qword ptr [7FFE38A3CA50]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+30],0
       je        short M00_L00
       mov       r8,[rsp+20]
       mov       r9,[rsp+28]
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE38A3C9F0]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,rbx
       mov       r8,rsi
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE38A3CA20]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FFE382C4F90]
       int       3
; Total bytes of code 135
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       [rbp+28],r9
       mov       rbx,rdx
       mov       rsi,r8
       test      rsi,rsi
       je        near ptr M01_L22
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FFE38064348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M01_L23
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L04
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE38064348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L26
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        short M01_L05
M01_L02:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       jmp       short M01_L06
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FFE38A1BC48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFE38A1C5C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L01
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFE38A1C6F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L06:
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       jne       short M01_L09
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M01_L19
M01_L07:
       mov       rax,[rbp-48]
       mov       ecx,[rdi+0C]
       mov       r14,[rdi]
       cmp       ecx,[r14+38]
       jae       near ptr M01_L18
       mov       rdx,[r14+10]
       lea       r8d,[rcx+1]
       mov       [rdi+0C],r8d
       cmp       ecx,[rdx+8]
       jae       short M01_L08
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rdx+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L07
       mov       rdx,[rcx]
       mov       r14,[rcx+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       short M01_L11
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L09:
       mov       rcx,rax
       mov       r11,7FFE37F20FB0
       call      qword ptr [r11]
       mov       ecx,eax
       mov       rax,[rbp-48]
M01_L10:
       test      ecx,ecx
       je        near ptr M01_L32
M01_L11:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L17
M01_L12:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       call      qword ptr [r11]
       cmp       rsi,r15
       jne       short M01_L14
       mov       rcx,[rbp-48]
       lea       rdi,[rcx+8]
       mov       edx,[rdi+8]
       mov       rax,[rdi]
       cmp       edx,[rax+44]
       jne       near ptr M01_L19
M01_L13:
       mov       edx,[rdi+0C]
       mov       r14,[rdi]
       cmp       edx,[r14+38]
       jae       short M01_L15
       mov       rax,[r14+10]
       lea       r8d,[rdx+1]
       mov       [rdi+0C],r8d
       cmp       edx,[rax+8]
       jae       short M01_L08
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rax+rdx*8+10]
       cmp       dword ptr [rdx+14],0FFFFFFFF
       jl        short M01_L13
       mov       rax,[rdx]
       mov       r14,[rdx+8]
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-48]
       jmp       near ptr M01_L11
M01_L14:
       mov       rcx,[rbp-48]
       mov       r11,7FFE37F20FB8
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-48]
       jne       near ptr M01_L11
       mov       rcx,rax
       jmp       short M01_L16
M01_L15:
       mov       r11d,[r14+38]
       inc       r11d
       mov       [rdi+0C],r11d
       xor       r11d,r11d
       mov       [rdi+18],r11
       mov       [rdi+20],r11
       mov       rcx,[rbp-48]
M01_L16:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rdi,[rbp-40]
       mov       r14,[rbp-38]
       jmp       short M01_L20
M01_L17:
       mov       rcx,rbx
       mov       rdx,7FFE38A1C710
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       mov       rax,[rbp-48]
       jmp       near ptr M01_L12
M01_L18:
       mov       ecx,[r14+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       near ptr M01_L10
M01_L19:
       call      qword ptr [7FFE3829EFB8]
       int       3
M01_L20:
       cmp       rsi,r15
       jne       near ptr M01_L31
M01_L21:
       mov       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,10
       call      qword ptr [7FFE382C4F30]
       int       3
M01_L23:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L24
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L24
       jmp       short M01_L25
M01_L24:
       mov       rcx,rbx
       mov       rdx,7FFE38A1C8A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L25:
       mov       rcx,rdi
       mov       rdx,[rbp+10]
       mov       r8,[rbp+28]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L26:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L27
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L27
       jmp       short M01_L28
M01_L27:
       mov       rcx,rbx
       mov       rdx,7FFE38A1C870
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L28:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jle       short M01_L33
       mov       r8,[rbp+28]
       mov       byte ptr [r8],1
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L29
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L29
       jmp       short M01_L30
M01_L29:
       mov       rcx,rbx
       mov       rdx,7FFE38A1C888
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L30:
       lea       r8d,[rsi-1]
       mov       rcx,r14
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L31:
       mov       r11,7FFE37F20FC0
       call      qword ptr [r11]
       jmp       near ptr M01_L21
M01_L32:
       mov       rcx,rsp
       call      M01_L34
       nop
M01_L33:
       mov       r8,[rbp+28]
       mov       byte ptr [r8],0
       xor       eax,eax
       mov       rdx,[rbp+10]
       mov       [rdx],rax
       mov       [rdx+8],rax
       mov       rax,rdx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L34:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-48],0
       je        short M01_L35
       mov       rax,[rbp-48]
       mov       rsi,[rax]
       mov       r15,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rsi,r15
       je        short M01_L35
       mov       rcx,rax
       mov       r11,7FFE37F20FC0
       call      qword ptr [r11]
M01_L35:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1085
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FFE384FDD78],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+28],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       nop
       jmp       near ptr M02_L13
M02_L01:
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE38A1CBB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L03:
       mov       rcx,2BF13169D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-18]
       mov       r9,2BF13160008
       call      qword ptr [7FFE38577C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-38],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE38A1CE70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M02_L05:
       mov       rcx,2BF1316B6E8
       mov       [rsp+20],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2BF13160008
       call      qword ptr [7FFE38577C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-48],rcx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE38A1CE98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L07:
       mov       rcx,[rbp-48]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-50]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-50]
       call      qword ptr [rax]
       mov       [rbp-54],eax
       mov       ecx,[rbp-54]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        short M02_L10
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-88],rcx
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L08
       mov       rcx,[rbp-88]
       cmp       qword ptr [rcx+38],0
       je        short M02_L08
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+38]
       mov       [rbp-70],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE38A1CF50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-70],rax
M02_L09:
       mov       rcx,[rbp-70]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-78]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-78]
       call      qword ptr [rax]
       mov       [rbp-7C],eax
       nop
       nop
M02_L10:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L11
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-60],rcx
       jmp       short M02_L12
M02_L11:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE38A1CEB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M02_L12:
       mov       rcx,[rbp-60]
       mov       [rbp-68],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-68]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-68]
       call      qword ptr [rax]
       nop
M02_L13:
       nop
       add       rsp,0B0
       pop       rbp
       ret
; Total bytes of code 641
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE383BF380],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383F4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE38A1D138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38A3CC78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

