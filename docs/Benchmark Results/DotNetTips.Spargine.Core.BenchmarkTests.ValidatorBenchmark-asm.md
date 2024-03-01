## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.CheckItemsExists_NoValidation()
       sub       rsp,28
       mov       r8,[rcx+118]
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFDF05D7DF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,28
       ret
; Total bytes of code 33
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
       cmp       dword ptr [7FFDF01B6848],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF05E20E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF05D7E58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.CheckItemsExists_Validation_Inlining()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+118]
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.CheckItemsExists[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean, System.String)
       xor       r8d,r8d
       mov       r9,1548B140008
       call      qword ptr [7FFDF04DD188]; DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean, System.String)
       mov       rcx,rbx
       mov       r8,rsi
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFDF062CD38]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 78
```
```assembly
; DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean, System.String)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       cmp       dword ptr [7FFDF01D7F60],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       jne       short M01_L01
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       call      qword ptr [7FFDF04D7240]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       mov       [rbp-18],eax
       xor       eax,eax
       cmp       dword ptr [rbp-18],0
       setg      al
       mov       [rbp-1C],eax
M01_L02:
       mov       eax,[rbp-1C]
       movzx     eax,al
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       sete      al
       mov       ecx,[rbp+20]
       movzx     ecx,cl
       and       eax,ecx
       mov       [rbp-10],eax
       cmp       dword ptr [rbp-10],0
       je        short M01_L05
       nop
       mov       rax,[rbp+28]
       mov       [rbp-28],rax
       call      qword ptr [7FFDF02A6430]
       mov       [rbp-30],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-30]
       call      qword ptr [7FFDF020CED0]
       mov       [rbp-38],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF04F3028
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L04:
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-38]
       mov       r8,[rbp+18]
       call      qword ptr [7FFDF04DD1E8]
       nop
       nop
M01_L05:
       mov       eax,[rbp-0C]
       mov       [rbp-14],eax
       nop
       mov       eax,[rbp-14]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 272
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
       cmp       dword ptr [7FFDF01D68C0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0204B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFDF060D870
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF062CDB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.CheckItemsExists_Validation()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+118]
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.CheckItemsExists[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Boolean, System.String)
       xor       r8d,r8d
       mov       r9,21CEED50008
       call      qword ptr [7FFDF04E4780]; DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean, System.String)
       mov       rcx,rbx
       mov       r8,rsi
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFDF0624870]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 78
```
```assembly
; DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean, System.String)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       cmp       dword ptr [7FFDF01E7FB8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       jne       short M01_L01
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       call      qword ptr [7FFDF04BE718]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       mov       [rbp-18],eax
       xor       eax,eax
       cmp       dword ptr [rbp-18],0
       setg      al
       mov       [rbp-1C],eax
M01_L02:
       mov       eax,[rbp-1C]
       movzx     eax,al
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       sete      al
       mov       ecx,[rbp+20]
       movzx     ecx,cl
       and       eax,ecx
       mov       [rbp-10],eax
       cmp       dword ptr [rbp-10],0
       je        short M01_L05
       nop
       mov       rax,[rbp+28]
       mov       [rbp-28],rax
       call      qword ptr [7FFDF02B6430]
       mov       [rbp-30],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-30]
       call      qword ptr [7FFDF021CED0]
       mov       [rbp-38],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF04CB8F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L04:
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-38]
       mov       r8,[rbp+18]
       call      qword ptr [7FFDF04E47E0]
       nop
       nop
M01_L05:
       mov       eax,[rbp-0C]
       mov       [rbp-14],eax
       nop
       mov       eax,[rbp-14]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 272
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
       cmp       dword ptr [7FFDF01E6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFDF0614E08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF06248E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.ArgumentNotNullOrEmpty_NoValidation()
       sub       rsp,28
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       mov       r8,2DFBADA2F30
       call      qword ptr [7FFDF0617D08]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,28
       ret
; Total bytes of code 36
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
       cmp       dword ptr [7FFDF01D6918],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0204B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF05FD670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0617D38]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.ArgumentNotNullOrEmpty_Validation_Inlining()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,287E86A7C18
       mov       [rsp+20],rcx
       mov       rsi,287E86B2EE0
       mov       rcx,rsi
       mov       edx,1
       xor       r8d,r8d
       mov       r9,287E86A0008
       call      qword ptr [7FFDF01ECAF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       mov       r8,rsi
       call      qword ptr [7FFDF05AFFA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 91
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FFDF01B7F60],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDEFED6670]; System.String.IsNullOrEmpty(System.String)
       mov       [rbp-1C],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-1C],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M01_L01
       mov       rcx,[rbp+20]
       call      qword ptr [7FFDEFED6670]; System.String.IsNullOrEmpty(System.String)
       mov       [rbp-44],eax
       xor       eax,eax
       cmp       dword ptr [rbp-44],0
       sete      al
       mov       [rbp-20],eax
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
       mov       [rbp-20],eax
M01_L02:
       mov       eax,[rbp-20]
       movzx     eax,al
       mov       [rbp-8],eax
       cmp       dword ptr [rbp-8],0
       je        short M01_L03
       nop
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       nop
       nop
       jmp       short M01_L04
M01_L03:
       xor       eax,eax
       cmp       dword ptr [rbp-4],0
       sete      al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       je        short M01_L04
       nop
       mov       rax,[rbp+28]
       mov       [rbp-30],rax
       call      qword ptr [7FFDF0286430]
       mov       [rbp-38],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-38]
       call      qword ptr [7FFDF01ECB40]
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFDF0286640]
       nop
       nop
M01_L04:
       mov       ecx,[rbp+18]
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L05
       mov       rcx,[rbp+10]
       mov       [rbp-28],rcx
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFED7318]; System.String.Trim()
       mov       [rbp-28],rax
M01_L06:
       mov       rax,[rbp-28]
       mov       [rbp-18],rax
       nop
       mov       rax,[rbp-18]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 281
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
       cmp       dword ptr [7FFDF01B68C0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFDF05C2060
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF05AFFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.ArgumentNotNullOrEmpty_Validation()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,2638D447C18
       mov       [rsp+20],rcx
       mov       rsi,2638D452EE0
       mov       rcx,rsi
       mov       edx,1
       xor       r8d,r8d
       mov       r9,2638D440008
       call      qword ptr [7FFDF01ECE88]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       mov       r8,rsi
       call      qword ptr [7FFDF05CC0A8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 91
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FFDF01B7FB8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDEFED6670]; System.String.IsNullOrEmpty(System.String)
       mov       [rbp-1C],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-1C],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       jne       short M01_L01
       mov       rcx,[rbp+20]
       call      qword ptr [7FFDEFED6670]; System.String.IsNullOrEmpty(System.String)
       mov       [rbp-44],eax
       xor       eax,eax
       cmp       dword ptr [rbp-44],0
       sete      al
       mov       [rbp-20],eax
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
       mov       [rbp-20],eax
M01_L02:
       mov       eax,[rbp-20]
       movzx     eax,al
       mov       [rbp-8],eax
       cmp       dword ptr [rbp-8],0
       je        short M01_L03
       nop
       mov       rax,[rbp+20]
       mov       [rbp+10],rax
       nop
       nop
       jmp       short M01_L04
M01_L03:
       xor       eax,eax
       cmp       dword ptr [rbp-4],0
       sete      al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       je        short M01_L04
       nop
       mov       rax,[rbp+28]
       mov       [rbp-30],rax
       call      qword ptr [7FFDF02867D8]
       mov       [rbp-38],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-38]
       call      qword ptr [7FFDF01ECED0]
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFDF02869E8]
       nop
       nop
M01_L04:
       mov       ecx,[rbp+18]
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L05
       mov       rcx,[rbp+10]
       mov       [rbp-28],rcx
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFED7318]; System.String.Trim()
       mov       [rbp-28],rax
M01_L06:
       mov       rax,[rbp-28]
       mov       [rbp-18],rax
       nop
       mov       rax,[rbp-18]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 281
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
       cmp       dword ptr [7FFDF01B6918],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFDF05E2050
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF05CC0D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

