## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullWithDefaultValueFromNull()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+150]
       mov       rdx,27F782232F0
       call      qword ptr [7FFE383DC0A8]; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE38816970]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String, System.String)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE383BBEF0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       [rbp-10],rax
       xor       eax,eax
       cmp       eax,1
       jne       short M01_L01
       nop
M01_L01:
       cmp       qword ptr [rbp-10],0
       je        short M01_L02
       nop
       jmp       short M01_L04
M01_L02:
       cmp       qword ptr [rbp+18],0
       jne       short M01_L03
       nop
       jmp       short M01_L04
M01_L03:
       mov       rax,[rbp+18]
       mov       [rbp-8],rax
       nop
       jmp       short M01_L05
M01_L04:
       mov       rax,27F78210008
       mov       [rbp-8],rax
       nop
M01_L05:
       xor       eax,eax
       cmp       eax,1
       jne       short M01_L06
       nop
M01_L06:
       mov       rax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 122
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
       cmp       dword ptr [7FFE3838F990],0
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
       mov       rdx,7FFE387F8B88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388169A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullWithDefaultValue()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,2741E9932A0
       mov       rdx,2741E9932D8
       call      qword ptr [7FFE383E77C8]; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387BDED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String, System.String)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE383CB658],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       [rbp-10],rax
       xor       eax,eax
       cmp       eax,1
       jne       short M01_L01
       nop
M01_L01:
       cmp       qword ptr [rbp-10],0
       je        short M01_L02
       nop
       jmp       short M01_L04
M01_L02:
       cmp       qword ptr [rbp+18],0
       jne       short M01_L03
       nop
       jmp       short M01_L04
M01_L03:
       mov       rax,[rbp+18]
       mov       [rbp-8],rax
       nop
       jmp       short M01_L05
M01_L04:
       mov       rax,2741E980008
       mov       [rbp-8],rax
       nop
M01_L05:
       xor       eax,eax
       cmp       eax,1
       jne       short M01_L06
       nop
M01_L06:
       mov       rax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 122
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
       cmp       dword ptr [7FFE3839F438],0
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
       mov       rdx,7FFE3879E2F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387BDF08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmptyWithDefaultValueFromNull()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+150]
       mov       rdx,2F7330E32A0
       call      qword ptr [7FFE383BC0C0]; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387C5ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE3839B658],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rdx,2F7330DEA60
       mov       [rsp+20],rdx
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2F7330D0008
       call      qword ptr [7FFE38445E00]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38026670]; System.String.IsNullOrEmpty(System.String)
       mov       [rbp-14],eax
       cmp       dword ptr [rbp-14],0
       jne       short M01_L01
       mov       rax,[rbp+10]
       mov       [rbp-20],rax
       jmp       short M01_L02
M01_L01:
       mov       rax,[rbp+18]
       mov       [rbp-20],rax
M01_L02:
       mov       rax,[rbp-20]
       mov       [rbp-8],rax
       nop
       mov       rax,[rbp-8]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 163
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
       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE3878E250
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387C5F08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmptyWithDefaultValue()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,2310EC832F0
       mov       rdx,2310EC83328
       call      qword ptr [7FFE383F77E0]; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE38836970]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE383DB658],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rdx,2310EC7EAB0
       mov       [rsp+20],rdx
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2310EC70008
       call      qword ptr [7FFE38485D88]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38066670]; System.String.IsNullOrEmpty(System.String)
       mov       [rbp-14],eax
       cmp       dword ptr [rbp-14],0
       jne       short M01_L01
       mov       rax,[rbp+10]
       mov       [rbp-20],rax
       jmp       short M01_L02
M01_L01:
       mov       rax,[rbp+18]
       mov       [rbp-20],rax
M01_L02:
       mov       rax,[rbp-20]
       mov       [rbp-8],rax
       nop
       mov       rax,[rbp-8]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 163
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
       cmp       dword ptr [7FFE383AF488],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383F4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE38827B40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388369A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithLength()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFE383C4D20]; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
       mov       rcx,rax
       mov       edx,64
       call      qword ptr [7FFE383CC1C8]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387DE9D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
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
       mov       rax,[rax+28]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FFE383AB658],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       mov       [rsp+20],rcx
       mov       rcx,2CBAB250008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       mov       r9d,[rbp+18]
       mov       edx,1
       mov       r8,2CBAB2575F8
       call      qword ptr [7FFE383CC6A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-10],eax
       mov       edx,[rbp-10]
       mov       [rbp+18],edx
       cmp       qword ptr [rbp+10],0
       je        short M02_L01
       mov       rdx,2CBAB257D00
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2CBAB250008
       call      qword ptr [7FFE38455E00]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38037318]; System.String.Trim()
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380369E8]; System.String.get_Length()
       mov       [rbp-2C],eax
       mov       eax,[rbp-2C]
       cmp       eax,[rbp+18]
       sete      al
       movzx     eax,al
       mov       [rbp-14],eax
       jmp       short M02_L02
M02_L01:
       xor       eax,eax
       mov       [rbp-14],eax
M02_L02:
       mov       eax,[rbp-14]
       movzx     eax,al
       mov       [rbp-0C],eax
       nop
       mov       eax,[rbp-0C]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 250
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
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387DE9E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithMinMaxCount()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFE383B4798]; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
       mov       rcx,rax
       mov       edx,5
       mov       r8d,64
       call      qword ptr [7FFE383B7930]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32, Int32)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387F6970]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 53
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
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
       mov       rax,[rax+28]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32, Int32)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FFE3839B658],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       mov       [rsp+20],rcx
       mov       rcx,24DECF20008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       mov       r9d,[rbp+20]
       xor       edx,edx
       mov       r8,24DECF2A7A0
       call      qword ptr [7FFE383BC0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-10],eax
       mov       ecx,[rbp-10]
       mov       [rbp+18],ecx
       xor       ecx,ecx
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       mov       [rsp+20],rcx
       mov       rcx,24DECF20008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+20]
       mov       edx,[rbp+18]
       mov       r8,24DECF2A7C8
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFE383BC0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-14],eax
       mov       ecx,[rbp-14]
       mov       [rbp+20],ecx
       cmp       qword ptr [rbp+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380269E8]; System.String.get_Length()
       mov       [rbp-1C],eax
       mov       ecx,[rbp-1C]
       mov       edx,[rbp+18]
       mov       r8d,[rbp+20]
       call      qword ptr [7FFE3867CB88]; DotNetTips.Spargine.Extensions.NumericExtensions.IsInRange(Int32, Int32, Int32)
       mov       [rbp-20],eax
       mov       eax,[rbp-20]
       mov       [rbp-18],eax
       jmp       short M02_L02
M02_L01:
       xor       eax,eax
       mov       [rbp-18],eax
M02_L02:
       mov       eax,[rbp-18]
       movzx     eax,al
       mov       [rbp-0C],eax
       nop
       mov       eax,[rbp-0C]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 255
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
       cmp       dword ptr [7FFE3837F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387F6988]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithRegEx()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,176F66A32A0
       mov       rdx,176F66A32D8
       mov       r8d,1
       call      qword ptr [7FFE383FC1F8]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, System.String, System.Text.RegularExpressions.RegexOptions)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE3880E9D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, System.String, System.Text.RegularExpressions.RegexOptions)
       push      rbp
       push      rdi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FFE383DB658],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383FC1B0]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       mov       rcx,[rbp+18]
       call      qword ptr [7FFE383FC1B0]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       mov       [rbp-14],eax
       cmp       dword ptr [rbp-14],0
       je        short M01_L01
       mov       rcx,[rbp+18]
       mov       [rbp-20],rcx
       mov       ecx,[rbp+20]
       mov       rdx,176F6690008
       mov       r8,176F6698890
       call      qword ptr [7FFE3880E9E8]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[System.Text.RegularExpressions.RegexOptions, System.Text.RegularExpressions]](System.Text.RegularExpressions.RegexOptions, System.String, System.String)
       mov       [rbp-24],eax
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-20]
       mov       r8d,[rbp-24]
       call      qword ptr [7FFE386BC030]; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFE386BC558]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rbp-34],eax
       mov       eax,[rbp-34]
       mov       [rbp-10],eax
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
       mov       [rbp-10],eax
M01_L02:
       mov       eax,[rbp-10]
       movzx     eax,al
       add       rsp,58
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 205
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
       call      qword ptr [7FFE383F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3883EB80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithString()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFE383E4D20]; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
       mov       rcx,rax
       mov       rdx,191DD4E32A0
       call      qword ptr [7FFE383EC1E0]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, System.String)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387FDF80]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 52
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
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
       mov       rax,[rax+28]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, System.String)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE383CB658],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383EC1B0]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8d,4
       call      qword ptr [7FFE380561D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       [rbp-14],eax
       mov       eax,[rbp-14]
       mov       [rbp-10],eax
       jmp       short M02_L02
M02_L01:
       xor       eax,eax
       mov       [rbp-10],eax
M02_L02:
       mov       eax,[rbp-10]
       movzx     eax,al
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 101
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
       cmp       dword ptr [7FFE383AF390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387FDF98]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_ASCII()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFE383B4D20]; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
       mov       rcx,rax
       mov       rdx,1F893400970
       mov       rdx,[rdx]
       call      qword ptr [7FFE383BC540]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Byte[], System.Private.CoreLib]](Byte[])
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE3879DD28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
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
       mov       rax,[rax+28]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE3839B658],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       rcx,23925267D00
       mov       [rsp+20],rcx
       mov       rcx,[rbp+10]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,23925260008
       call      qword ptr [7FFE383BC8A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+18],0
       jne       short M02_L01
       xor       ecx,ecx
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+10]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+10]
       mov       [rbp-18],rax
M02_L02:
       mov       rax,[rbp-18]
       mov       [rbp-8],rax
       nop
       mov       rax,[rbp-8]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 163
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
       mov       rdx,7FFE3877E208
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3879DD70]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_BigEndianUnicode()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFE383D4D20]; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
       mov       rcx,rax
       mov       rdx,206CE4009C8
       mov       rdx,[rdx]
       call      qword ptr [7FFE383DC540]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Byte[], System.Private.CoreLib]](Byte[])
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387EDF80]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
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
       mov       rax,[rax+28]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE383BB658],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       rcx,2475C2A7D00
       mov       [rsp+20],rcx
       mov       rcx,[rbp+10]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,2475C2A0008
       call      qword ptr [7FFE383DC8A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+18],0
       jne       short M02_L01
       xor       ecx,ecx
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+10]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+10]
       mov       [rbp-18],rax
M02_L02:
       mov       rax,[rbp-18]
       mov       [rbp-8],rax
       nop
       mov       rax,[rbp-8]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 163
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
       mov       rdx,7FFE38800130
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387EDFB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Default()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFE383B4D20]; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
       mov       rcx,rax
       mov       rdx,274040009A0
       mov       rdx,[rdx]
       call      qword ptr [7FFE383BC540]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Byte[], System.Private.CoreLib]](Byte[])
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387CE970]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
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
       mov       rax,[rax+28]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE3839B658],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       rcx,27383267D00
       mov       [rsp+20],rcx
       mov       rcx,[rbp+10]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,27383260008
       call      qword ptr [7FFE383BC8A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+18],0
       jne       short M02_L01
       xor       ecx,ecx
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+10]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+10]
       mov       [rbp-18],rax
M02_L02:
       mov       rax,[rbp-18]
       mov       [rbp-8],rax
       nop
       mov       rax,[rbp-8]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 163
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
       mov       rdx,7FFE387E0130
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387CE9B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Latin1()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFE383E4D20]; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
       mov       rcx,rax
       mov       rdx,2775F0009C0
       mov       rdx,[rdx]
       call      qword ptr [7FFE383EC540]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Byte[], System.Private.CoreLib]](Byte[])
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387FD380]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
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
       mov       rax,[rax+28]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE383CB658],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       rcx,2B7F0E27D00
       mov       [rsp+20],rcx
       mov       rcx,[rbp+10]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,2B7F0E20008
       call      qword ptr [7FFE383EC8A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+18],0
       jne       short M02_L01
       xor       ecx,ecx
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+10]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+10]
       mov       [rbp-18],rax
M02_L02:
       mov       rax,[rbp-18]
       mov       [rbp-8],rax
       nop
       mov       rax,[rbp-8]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 163
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
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE387DEB18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387FDC80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Unicode()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFE383E4D20]; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
       mov       rcx,rax
       mov       rdx,194EC4009D0
       mov       rdx,[rdx]
       call      qword ptr [7FFE383EC540]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Byte[], System.Private.CoreLib]](Byte[])
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387FE820]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
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
       mov       rax,[rax+28]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE383CB658],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       rcx,1D57A117D00
       mov       [rsp+20],rcx
       mov       rcx,[rbp+10]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,1D57A110008
       call      qword ptr [7FFE383EC8A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+18],0
       jne       short M02_L01
       xor       ecx,ecx
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+10]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+10]
       mov       [rbp-18],rax
M02_L02:
       mov       rax,[rbp-18]
       mov       [rbp-8],rax
       nop
       mov       rax,[rbp-8]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 163
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
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE387DE1F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387FE850]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_UTF32()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFE383F4D20]; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
       mov       rcx,rax
       mov       rdx,1E2770009D8
       mov       rdx,[rdx]
       call      qword ptr [7FFE383FC540]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Byte[], System.Private.CoreLib]](Byte[])
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE388369D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
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
       mov       rax,[rax+28]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE383DB658],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       rcx,22308F57D00
       mov       [rsp+20],rcx
       mov       rcx,[rbp+10]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,22308F50008
       call      qword ptr [7FFE383FC8A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+18],0
       jne       short M02_L01
       xor       ecx,ecx
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+10]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+10]
       mov       [rbp-18],rax
M02_L02:
       mov       rax,[rbp-18]
       mov       [rbp-8],rax
       nop
       mov       rax,[rbp-8]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 163
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
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE38818D00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38836D00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_UTF8()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFE383B4D20]; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
       mov       rcx,rax
       mov       rdx,218C58009F0
       mov       rdx,[rdx]
       call      qword ptr [7FFE383BC540]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Byte[], System.Private.CoreLib]](Byte[])
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE3878DED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
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
       mov       rax,[rax+28]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE3839B658],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       rcx,259575D7D00
       mov       [rsp+20],rcx
       mov       rcx,[rbp+10]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,259575D0008
       call      qword ptr [7FFE383BC8A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+18],0
       jne       short M02_L01
       xor       ecx,ecx
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+10]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+10]
       mov       [rbp-18],rax
M02_L02:
       mov       rax,[rbp-18]
       mov       [rbp-8],rax
       nop
       mov       rax,[rbp-8]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 163
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
       mov       rdx,7FFE3876E410
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3878DF20]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.CombineToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFE383E4D20]; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.String, System.Private.CoreLib]](System.Object)
       call      qword ptr [7FFE387FE970]; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rsi,rax
       mov       rcx,rbx
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFE383E4B88]; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE383EC018]; DotNetTips.Spargine.Extensions.StringExtensions.CombineToString(System.String, System.String[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE387FE9A0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 106
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
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
       mov       rax,[rax+28]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rbp
       push      rdi
       sub       rsp,58
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE383CB658],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rdx,215A9CE2730
       mov       [rsp+20],rdx
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
       xor       r8d,r8d
       mov       r9,215A9CE0008
       call      qword ptr [7FFE38475E00]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FFE3867FEB8]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       [rbp-20],rax
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
       mov       rdx,7FFE387DFFB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L02:
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      qword ptr [7FFE387FE9E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rbp-30],rax
       mov       rax,[rbp-30]
       add       rsp,58
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 202
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M03_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M03_L00
       mov       [rbp-0D0],rsp
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       cmp       dword ptr [7FFE383AF390],0
       je        short M03_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L01:
       nop
       mov       ecx,[rbp+20]
       mov       edx,1
       call      qword ptr [7FFE386A40A8]; DotNetTips.Spargine.Extensions.NumericExtensions.EnsureMinimum(Int32, Int32)
       mov       [rbp-7C],eax
       mov       edx,[rbp-7C]
       mov       [rbp+20],edx
       mov       edx,[rbp+20]
       add       edx,1
       jno       short M03_L02
       call      CORINFO_HELP_OVERFLOW
M03_L02:
       mov       ecx,[rbp+28]
       call      qword ptr [7FFE386A40A8]; DotNetTips.Spargine.Extensions.NumericExtensions.EnsureMinimum(Int32, Int32)
       mov       [rbp-80],eax
       mov       ecx,[rbp-80]
       mov       [rbp+28],ecx
       lea       rcx,[rbp-30]
       mov       edx,2
       mov       r8d,3
       call      qword ptr [7FFE382056B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-30]
       mov       edx,[rbp+18]
       call      qword ptr [7FFE3820C7C8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       lea       rcx,[rbp-30]
       mov       rdx,215A9CE0C30
       call      qword ptr [7FFE38205788]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       nop
       lea       rcx,[rbp-30]
       mov       edx,[rbp+20]
       call      qword ptr [7FFE3820C7C8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       lea       rcx,[rbp-30]
       mov       rdx,215A9CE0C30
       call      qword ptr [7FFE38205788]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       nop
       lea       rcx,[rbp-30]
       mov       edx,[rbp+28]
       call      qword ptr [7FFE3820C7C8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       lea       rcx,[rbp-30]
       call      qword ptr [7FFE38205740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       [rbp-88],rax
       mov       rcx,[rbp-88]
       mov       [rbp-8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rdx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380E4608]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ContainsKey(System.__Canon)
       mov       [rbp-8C],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-8C],0
       sete      cl
       mov       [rbp-34],ecx
       cmp       dword ptr [rbp-34],0
       je        near ptr M03_L05
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-8]
       mov       [rbp-48],rcx
       mov       ecx,[rbp+18]
       mov       edx,[rbp+20]
       mov       r8d,[rbp+28]
       call      qword ptr [7FFE383E7C78]; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-54],ecx
       mov       rcx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38443160]; Precode of System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-0A4],eax
       mov       edx,[rbp-0A4]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-0B0]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38443180]; Precode of System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       [rbp-68],rcx
       nop
       jmp       short M03_L04
M03_L03:
       mov       rcx,[rbp-68]
       mov       r11,7FFE37F107B0
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
       mov       rdx,[rbp-0C8]
       mov       [rbp-70],rdx
       mov       edx,[rbp-54]
       movsxd    rdx,edx
       mov       rcx,[rbp-60]
       mov       r8,[rbp-70]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-54]
       inc       ecx
       mov       [rbp-54],ecx
M03_L04:
       mov       rcx,[rbp-68]
       mov       r11,7FFE37F107A8
       call      qword ptr [r11]
       mov       [rbp-0BC],eax
       cmp       dword ptr [rbp-0BC],0
       jne       short M03_L03
       nop
       mov       rcx,rsp
       call      M03_L06
       nop
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-60]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380E45E0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon)
       nop
       nop
M03_L05:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rdx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380E45D0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       mov       [rbp-98],rax
       mov       rax,[rbp-98]
       mov       [rbp-78],rax
       nop
       mov       rax,[rbp-78]
       add       rsp,0F0
       pop       rbp
       ret
M03_L06:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0F0]
       cmp       qword ptr [rbp-68],0
       je        short M03_L07
       mov       rcx,[rbp-68]
       mov       r11,7FFE37F107B8
       call      qword ptr [r11]
       nop
M03_L07:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 721
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.CombineToString(System.String, System.String[])
       push      rbp
       push      rdi
       sub       rsp,58
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE383CB658],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       xor       edx,edx
       mov       [rbp-0C],edx
       mov       rdx,215A9CF4140
       mov       [rsp+20],rdx
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String[], System.Private.CoreLib]](System.String[], System.String[], System.String, System.String)
       xor       r8d,r8d
       mov       r9,215A9CE0008
       call      qword ptr [7FFE38475E00]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rdx,215A9CE7D00
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,215A9CE0008
       call      qword ptr [7FFE38475E00]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       r8,[rbp-20]
       mov       rdx,[rbp-18]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.String, System.Private.CoreLib]](System.String[], System.String)
       call      qword ptr [7FFE3882FA68]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       [rbp-28],rax
       mov       ecx,[rbp-0C]
       mov       rdx,[rbp-28]
       call      qword ptr [7FFE3882FAB0]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
       mov       [rbp-30],rax
       mov       rax,[rbp-30]
       add       rsp,58
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 212
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
       je        short M05_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M05_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M05_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M05_L02
M05_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE3881C9B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M05_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388455F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Concat()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFE383C4D20]; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.String, System.Private.CoreLib]](System.Object)
       call      qword ptr [7FFE387DE970]; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rsi,rax
       mov       rcx,rbx
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFE383C4B88]; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       r9,rax
       mov       rcx,rsi
       mov       rdx,27C1B770C60
       mov       r8d,1
       call      qword ptr [7FFE383CC060]; DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, Boolean, System.String[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE387DE9A0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 122
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
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
       mov       rax,[rax+28]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rbp
       push      rdi
       sub       rsp,58
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE383AB658],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rdx,27C1B772730
       mov       [rsp+20],rdx
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
       xor       r8d,r8d
       mov       r9,27C1B770008
       call      qword ptr [7FFE38455E00]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FFE3865FEB8]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       [rbp-20],rax
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
       mov       rdx,7FFE387BFFB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L02:
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      qword ptr [7FFE387DE9E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rbp-30],rax
       mov       rax,[rbp-30]
       add       rsp,58
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 202
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M03_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M03_L00
       mov       [rbp-0D0],rsp
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       cmp       dword ptr [7FFE3838F390],0
       je        short M03_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L01:
       nop
       mov       ecx,[rbp+20]
       mov       edx,1
       call      qword ptr [7FFE386840A8]; DotNetTips.Spargine.Extensions.NumericExtensions.EnsureMinimum(Int32, Int32)
       mov       [rbp-7C],eax
       mov       edx,[rbp-7C]
       mov       [rbp+20],edx
       mov       edx,[rbp+20]
       add       edx,1
       jno       short M03_L02
       call      CORINFO_HELP_OVERFLOW
M03_L02:
       mov       ecx,[rbp+28]
       call      qword ptr [7FFE386840A8]; DotNetTips.Spargine.Extensions.NumericExtensions.EnsureMinimum(Int32, Int32)
       mov       [rbp-80],eax
       mov       ecx,[rbp-80]
       mov       [rbp+28],ecx
       lea       rcx,[rbp-30]
       mov       edx,2
       mov       r8d,3
       call      qword ptr [7FFE381E56B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-30]
       mov       edx,[rbp+18]
       call      qword ptr [7FFE381EC7C8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       lea       rcx,[rbp-30]
       mov       rdx,27C1B770C30
       call      qword ptr [7FFE381E5788]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       nop
       lea       rcx,[rbp-30]
       mov       edx,[rbp+20]
       call      qword ptr [7FFE381EC7C8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       lea       rcx,[rbp-30]
       mov       rdx,27C1B770C30
       call      qword ptr [7FFE381E5788]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       nop
       lea       rcx,[rbp-30]
       mov       edx,[rbp+28]
       call      qword ptr [7FFE381EC7C8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       lea       rcx,[rbp-30]
       call      qword ptr [7FFE381E5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       [rbp-88],rax
       mov       rcx,[rbp-88]
       mov       [rbp-8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rdx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380C4608]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ContainsKey(System.__Canon)
       mov       [rbp-8C],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-8C],0
       sete      cl
       mov       [rbp-34],ecx
       cmp       dword ptr [rbp-34],0
       je        near ptr M03_L05
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-8]
       mov       [rbp-48],rcx
       mov       ecx,[rbp+18]
       mov       edx,[rbp+20]
       mov       r8d,[rbp+28]
       call      qword ptr [7FFE383C7C78]; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-54],ecx
       mov       rcx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38423160]; Precode of System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-0A4],eax
       mov       edx,[rbp-0A4]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-0B0]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38423180]; Precode of System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       [rbp-68],rcx
       nop
       jmp       short M03_L04
M03_L03:
       mov       rcx,[rbp-68]
       mov       r11,7FFE37EF07B0
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
       mov       rdx,[rbp-0C8]
       mov       [rbp-70],rdx
       mov       edx,[rbp-54]
       movsxd    rdx,edx
       mov       rcx,[rbp-60]
       mov       r8,[rbp-70]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-54]
       inc       ecx
       mov       [rbp-54],ecx
M03_L04:
       mov       rcx,[rbp-68]
       mov       r11,7FFE37EF07A8
       call      qword ptr [r11]
       mov       [rbp-0BC],eax
       cmp       dword ptr [rbp-0BC],0
       jne       short M03_L03
       nop
       mov       rcx,rsp
       call      M03_L06
       nop
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-60]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380C45E0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon)
       nop
       nop
M03_L05:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rdx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380C45D0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       mov       [rbp-98],rax
       mov       rax,[rbp-98]
       mov       [rbp-78],rax
       nop
       mov       rax,[rbp-78]
       add       rsp,0F0
       pop       rbp
       ret
M03_L06:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0F0]
       cmp       qword ptr [rbp-68],0
       je        short M03_L07
       mov       rcx,[rbp-68]
       mov       r11,7FFE37EF07B8
       call      qword ptr [r11]
       nop
M03_L07:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 721
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, Boolean, System.String[])
       push      rbp
       sub       rsp,0C0
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M04_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M04_L00
       mov       [rbp-0A0],rsp
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       cmp       dword ptr [7FFE383AB658],0
       je        short M04_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L01:
       nop
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383CE1C0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       mov       [rbp-38],eax
       mov       ecx,[rbp-38]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M04_L02
       nop
       mov       rcx,27C1B770008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M04_L12
M04_L02:
       mov       rcx,[rbp+18]
       call      qword ptr [7FFE383CE1C0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       mov       [rbp-3C],eax
       mov       ecx,[rbp-3C]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        short M04_L03
       nop
       mov       rcx,27C1B770008
       mov       [rbp+18],rcx
       nop
M04_L03:
       xor       ecx,ecx
       cmp       qword ptr [rbp+28],0
       sete      cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       je        short M04_L04
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M04_L12
M04_L04:
       mov       rcx,7FFE383ABB40
       mov       edx,29
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23B8980B560
       mov       rcx,[rcx]
       mov       [rbp-88],rcx
       mov       rcx,[rbp-88]
       mov       rax,[rbp-88]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp-8]
       mov       rdx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       mov       rdx,[rbp-50]
       mov       [rbp-8],rdx
       mov       rdx,[rbp+28]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.HasItems[[System.String, System.Private.CoreLib]](System.String[])
       call      qword ptr [7FFE38737C00]; DotNetTips.Spargine.Extensions.ArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       [rbp-54],eax
       mov       ecx,[rbp-54]
       movzx     ecx,cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       je        near ptr M04_L11
       nop
       xor       ecx,ecx
       mov       [rbp-28],ecx
       nop
       jmp       near ptr M04_L10
M04_L05:
       nop
       mov       rcx,[rbp+28]
       mov       edx,[rbp-28]
       cmp       edx,[rcx+8]
       jb        short M04_L06
       call      CORINFO_HELP_RNGCHKFAIL
M04_L06:
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       ecx,[rbp+20]
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M04_L07
       mov       rcx,[rbp-8]
       mov       [rbp-70],rcx
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFE38036B08]; System.String.Concat(System.String, System.String)
       mov       [rbp-78],rax
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-78]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-80],rax
       nop
       nop
       jmp       short M04_L08
M04_L07:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C330]; System.Text.StringBuilder.AppendLine(System.String)
       mov       [rbp-68],rax
       nop
M04_L08:
       nop
       mov       ecx,[rbp-28]
       add       ecx,1
       jno       short M04_L09
       call      CORINFO_HELP_OVERFLOW
M04_L09:
       mov       [rbp-28],ecx
M04_L10:
       mov       ecx,[rbp-28]
       mov       rdx,[rbp+28]
       cmp       ecx,[rdx+8]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-34],ecx
       cmp       dword ptr [rbp-34],0
       jne       near ptr M04_L05
       nop
M04_L11:
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M04_L13
       nop
M04_L12:
       mov       rax,[rbp-18]
       add       rsp,0C0
       pop       rbp
       ret
M04_L13:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       nop
       mov       rcx,7FFE383ABB40
       mov       edx,29
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23B8980B560
       mov       rcx,[rcx]
       mov       [rbp-90],rcx
       mov       rcx,[rbp-90]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-90]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 689
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
       je        short M05_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M05_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M05_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M05_L02
M05_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE3884A730
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M05_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388A7330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNull()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,2E6EAE332A0
       call      qword ptr [7FFE383C77B0]; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387D5ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383ABA10],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       [rbp-10],rax
       mov       rax,[rbp-10]
       mov       [rbp-18],rax
       cmp       qword ptr [rbp+10],0
       jne       short M01_L01
       mov       rax,2E6EAE20008
       mov       [rbp-18],rax
M01_L01:
       mov       rax,[rbp-18]
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 87
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
       cmp       dword ptr [7FFE3837F648],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383C4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE3879E2B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387D5F08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,328C1EC32A0
       mov       rdx,328C1EC32D8
       call      qword ptr [7FFE383CC0C0]; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387DE9D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE383AB658],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rdx,328C1EBEA60
       mov       [rsp+20],rdx
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,328C1EB0008
       call      qword ptr [7FFE38455E00]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38036670]; System.String.IsNullOrEmpty(System.String)
       mov       [rbp-14],eax
       cmp       dword ptr [rbp-14],0
       jne       short M01_L01
       mov       rax,[rbp+10]
       mov       [rbp-20],rax
       jmp       short M01_L02
M01_L01:
       mov       rax,[rbp+18]
       mov       [rbp-20],rax
M01_L02:
       mov       rax,[rbp-20]
       mov       [rbp-8],rax
       nop
       mov       rax,[rbp-8]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 163
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
       mov       rdx,7FFE387BFF20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387DEA00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Extract()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFE383C4D20]; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
       mov       rcx,rax
       mov       rdx,2A7207532A0
       mov       r8,2A7207532C0
       call      qword ptr [7FFE383CC120]; DotNetTips.Spargine.Extensions.StringExtensions.Extract(System.String, System.String, System.String)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387DE970]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
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
       mov       rax,[rax+28]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Extract(System.String, System.String, System.String)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE383AB658],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       rcx,2A720747D00
       mov       [rsp+20],rcx
       mov       rcx,[rbp+10]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,2A720740008
       call      qword ptr [7FFE383CC8A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       [rbp+10],rcx
       mov       rcx,2A7207532E0
       mov       [rsp+20],rcx
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,2A720740008
       call      qword ptr [7FFE383CC8A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+18],rcx
       mov       rcx,2A720753300
       mov       [rsp+20],rcx
       mov       rcx,[rbp+20]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,2A720740008
       call      qword ptr [7FFE383CC8A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8d,4
       cmp       [rcx],ecx
       call      qword ptr [7FFE380375A0]; System.String.IndexOf(System.String, System.StringComparison)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp-4],ecx
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       mov       r8d,4
       cmp       [rcx],ecx
       call      qword ptr [7FFE380375A0]; System.String.IndexOf(System.String, System.StringComparison)
       mov       [rbp-38],eax
       mov       r8d,[rbp-38]
       mov       [rbp-8],r8d
       mov       r8d,[rbp-4]
       mov       [rbp-0C],r8d
       mov       r8d,[rbp-8]
       sub       r8d,[rbp-0C]
       mov       rcx,[rbp+10]
       mov       edx,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38037240]; System.String.Substring(Int32, Int32)
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       mov       [rbp-18],rax
       nop
       mov       rax,[rbp-18]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 344
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
       mov       rdx,7FFE387F0130
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387DE9A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.FromDeflateStringAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE38826DA8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromDeflateStringAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromDeflateStringAsync>d__23 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE387B52F0]
       jmp       short M00_L00
; Total bytes of code 85
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFE38826A90]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromDeflateStringAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromDeflateStringAsync>d__23 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFE3805D1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE38826C70]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromDeflateStringAsync>d__23.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFE3878FCC0]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFE3878FCC0]
M03_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 254
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE38284B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFE382842E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFE38826AA8]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE38284768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.FromZLibStringAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE387C62B0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromZLibStringAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromZLibStringAsync>d__24 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE38764720]
       jmp       short M00_L00
; Total bytes of code 85
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFE387C5F98]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromZLibStringAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromZLibStringAsync>d__24 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFE3802D1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE387C6178]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromZLibStringAsync>d__24.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFE3873EF28]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFE3873EF28]
M03_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 254
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE38254B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFE382542E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFE387C5FB0]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE38254768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValue()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFE383B4D20]; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
       mov       rcx,rax
       call      qword ptr [7FFE383BC1B0]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387CE970]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
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
       mov       rax,[rax+28]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE3839B658],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       cmp       qword ptr [rbp+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38027318]; System.String.Trim()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380269E8]; System.String.get_Length()
       mov       [rbp-1C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-1C],0
       setg      al
       mov       [rbp-0C],eax
       jmp       short M02_L02
M02_L01:
       xor       eax,eax
       mov       [rbp-0C],eax
M02_L02:
       mov       eax,[rbp-0C]
       movzx     eax,al
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 105
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
       cmp       dword ptr [7FFE3837F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387CE988]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasWhitespace()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFE383B4D20]; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
       mov       rcx,rax
       call      qword ptr [7FFE383BC228]; DotNetTips.Spargine.Extensions.StringExtensions.HasWhitespace(System.String)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387F69D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE3837F380],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+28]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasWhitespace(System.String)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE3839B658],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       rcx,309862B7D00
       mov       [rsp+20],rcx
       mov       rcx,[rbp+10]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,309862B0008
       call      qword ptr [7FFE383BC8A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       [rbp+10],rcx
       xor       ecx,ecx
       mov       [rbp-4],ecx
       nop
       jmp       short M02_L04
M02_L01:
       nop
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380269D0]; System.String.get_Chars(Int32)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       call      qword ptr [7FFE383BC2A0]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiWhitespace(Char)
       mov       [rbp-28],eax
       xor       eax,eax
       cmp       dword ptr [rbp-28],0
       sete      al
       mov       [rbp-8],eax
       cmp       dword ptr [rbp-8],0
       je        short M02_L02
       nop
       xor       eax,eax
       mov       [rbp-0C],eax
       nop
       jmp       short M02_L05
M02_L02:
       nop
       mov       eax,[rbp-4]
       add       eax,1
       jno       short M02_L03
       call      CORINFO_HELP_OVERFLOW
M02_L03:
       mov       [rbp-4],eax
M02_L04:
       mov       ecx,[rbp-4]
       mov       [rbp-1C],ecx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380269E8]; System.String.get_Length()
       mov       [rbp-20],eax
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp-20]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-10],ecx
       cmp       dword ptr [rbp-10],0
       jne       short M02_L01
       mov       dword ptr [rbp-0C],1
       nop
M02_L05:
       mov       eax,[rbp-0C]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 241
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
       cmp       dword ptr [7FFE3837F380],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387F6A00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Indent()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFE383D4D20]; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
       mov       rcx,rax
       mov       edx,0A
       mov       r8d,3E
       call      qword ptr [7FFE383DC240]; DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387ADF80]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
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
       mov       rax,[rax+28]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-78],rsp
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FFE383BB658],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       mov       rcx,7FFE383BBB40
       mov       edx,29
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,11A18009568
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       rax,[rbp-68]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       xor       edx,edx
       cmp       dword ptr [rbp+18],0
       sete      dl
       mov       [rbp-0C],edx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L02
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-50],rdx
       mov       rdx,15AA9D37D00
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,15AA9D30008
       call      qword ptr [7FFE38465E00]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
M02_L02:
       mov       dword ptr [rbp-10],1
       nop
       jmp       short M02_L05
M02_L03:
       nop
       mov       edx,[rbp+20]
       movzx     edx,dx
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-38],rax
       nop
       nop
       mov       ecx,[rbp-10]
       add       ecx,1
       jno       short M02_L04
       call      CORINFO_HELP_OVERFLOW
M02_L04:
       mov       [rbp-10],ecx
M02_L05:
       mov       ecx,[rbp-10]
       mov       [rbp-2C],ecx
       mov       ecx,[rbp+18]
       call      qword ptr [7FFE385D5080]; System.Math.Abs(Int32)
       mov       [rbp-30],eax
       mov       edx,[rbp-2C]
       cmp       edx,[rbp-30]
       setle     dl
       movzx     edx,dl
       mov       [rbp-14],edx
       cmp       dword ptr [rbp-14],0
       jne       short M02_L03
       xor       ecx,ecx
       cmp       dword ptr [rbp+18],0
       setg      cl
       mov       [rbp-18],ecx
       cmp       dword ptr [rbp-18],0
       je        short M02_L06
       nop
       mov       rcx,[rbp-8]
       mov       rdx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-48],rax
       nop
       nop
M02_L06:
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp-20],rcx
       nop
       mov       rcx,rsp
       call      M02_L07
       nop
       mov       rax,[rbp-20]
       add       rsp,0A0
       pop       rbp
       ret
M02_L07:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       nop
       mov       rcx,7FFE383BBB40
       mov       edx,29
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,11A18009568
       mov       rcx,[rcx]
       mov       [rbp-70],rcx
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-70]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 531
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
       mov       rdx,7FFE387EFED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388460A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiDigit()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       movzx     ecx,word ptr [rbx+178]
       call      qword ptr [7FFE383BC258]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387CE9D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],ecx
       cmp       dword ptr [7FFE3839B658],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       ecx,[rbp+10]
       movzx     ecx,cx
       xor       edx,edx
       mov       r8,221CA400008
       mov       r9,221CA4132A0
       call      qword ptr [7FFE387CE9E8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Char, System.Private.CoreLib]](Char, Char, System.String, System.String)
       mov       [rbp-0C],eax
       mov       ecx,[rbp-0C]
       call      qword ptr [7FFE37FB5C50]; System.Char.IsDigit(Char)
       mov       [rbp-10],eax
       mov       eax,[rbp-10]
       movzx     eax,al
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 90
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
       cmp       dword ptr [7FFE3837F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387CEA00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiLetter()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       movzx     ecx,word ptr [rbx+178]
       call      qword ptr [7FFE383CC270]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387DE970]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],ecx
       cmp       dword ptr [7FFE383AB658],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       ecx,[rbp+10]
       movzx     ecx,cx
       xor       edx,edx
       mov       r8,1D811B20008
       mov       r9,1D811B332A0
       call      qword ptr [7FFE387DE988]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Char, System.Private.CoreLib]](Char, Char, System.String, System.String)
       mov       [rbp-0C],eax
       mov       ecx,[rbp-0C]
       call      qword ptr [7FFE37FC5CB0]; System.Char.IsLetter(Char)
       mov       [rbp-10],eax
       mov       eax,[rbp-10]
       movzx     eax,al
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 90
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
       call      qword ptr [7FFE387DE9A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiLetterOrDigit()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       movzx     ecx,word ptr [rbx+178]
       call      qword ptr [7FFE383EC288]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387FE970]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],ecx
       cmp       dword ptr [7FFE383CB658],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       ecx,[rbp+10]
       movzx     ecx,cx
       xor       edx,edx
       mov       r8,2BC197C0008
       mov       r9,2BC197D32A0
       call      qword ptr [7FFE387FE988]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Char, System.Private.CoreLib]](Char, Char, System.String, System.String)
       mov       [rbp-0C],eax
       mov       ecx,[rbp-0C]
       call      qword ptr [7FFE37FE5D70]; System.Char.IsLetterOrDigit(Char)
       mov       [rbp-10],eax
       mov       eax,[rbp-10]
       movzx     eax,al
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 90
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
       cmp       dword ptr [7FFE383AF390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387FE9A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiWhitespace()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       movzx     ecx,word ptr [rbx+178]
       call      qword ptr [7FFE383FC2A0]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiWhitespace(Char)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE3880E9D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiWhitespace(Char)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],ecx
       cmp       dword ptr [7FFE383DB658],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       ecx,[rbp+10]
       movzx     ecx,cx
       xor       edx,edx
       mov       r8,294AA9B0008
       mov       r9,294AA9C32A0
       call      qword ptr [7FFE3880E9E8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Char, System.Private.CoreLib]](Char, Char, System.String, System.String)
       mov       [rbp-0C],eax
       mov       ecx,[rbp-0C]
       call      qword ptr [7FFE37FF5CE0]; System.Char.IsWhiteSpace(Char)
       mov       [rbp-10],eax
       mov       eax,[rbp-10]
       movzx     eax,al
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 90
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
       call      qword ptr [7FFE383F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3880EA00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsCreditCardNumber()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+120]
       call      qword ptr [7FFE383E79D8]; DotNetTips.Spargine.Extensions.StringExtensions.IsCreditCardNumber(System.String)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE38826970]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsCreditCardNumber(System.String)
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383CB658],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,7FFE383CBB40
       mov       edx,29
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,22315409508
       mov       rdx,[rdx]
       mov       [rbp-10],rdx
       mov       rdx,263A73B7D00
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,263A73B0008
       call      qword ptr [7FFE38475D88]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE386E48E8]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rbp-1C],eax
       mov       eax,[rbp-1C]
       movzx     eax,al
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 160
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
       cmp       dword ptr [7FFE383AF390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388C54A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsCurrencyCode()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+128]
       call      qword ptr [7FFE383CC2D0]; DotNetTips.Spargine.Extensions.StringExtensions.IsCurrencyCode(System.String)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387DCED0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsCurrencyCode(System.String)
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383AB658],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,7FFE383ABB40
       mov       edx,29
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,11C5A40B508
       mov       rdx,[rdx]
       mov       [rbp-10],rdx
       mov       rdx,15CEC487D00
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,15CEC480008
       call      qword ptr [7FFE38455E00]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE386861A8]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rbp-1C],eax
       mov       eax,[rbp-1C]
       movzx     eax,al
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 160
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
       call      qword ptr [7FFE38875A88]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsDomainAddress()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       call      qword ptr [7FFE383DC2E8]; DotNetTips.Spargine.Extensions.StringExtensions.IsDomainAddress(System.String)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387ADED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsDomainAddress(System.String)
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383BB658],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,7FFE383BBB40
       mov       edx,29
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1591A80B510
       mov       rdx,[rdx]
       mov       [rbp-10],rdx
       mov       rdx,199A87C7D00
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,199A87C0008
       call      qword ptr [7FFE38465E00]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE386673D8]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rbp-1C],eax
       mov       eax,[rbp-1C]
       movzx     eax,al
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 160
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
       cmp       dword ptr [7FFE3839F3E0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38846DC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsEmailAddress()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+138]
       call      qword ptr [7FFE383C7A20]; DotNetTips.Spargine.Extensions.StringExtensions.IsEmailAddress(System.String)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE3879DED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsEmailAddress(System.String)
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383AB658],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,7FFE383ABB40
       mov       edx,29
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,259BD40B518
       mov       rdx,[rdx]
       mov       [rbp-10],rdx
       mov       rdx,29A4B1C7D00
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,29A4B1C0008
       call      qword ptr [7FFE38455D88]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE386573D8]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rbp-1C],eax
       mov       eax,[rbp-1C]
       movzx     eax,al
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 160
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
       cmp       dword ptr [7FFE3837F438],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383C4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3883DD10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,1B49CB932C8
       call      qword ptr [7FFE383D7A38]; DotNetTips.Spargine.Extensions.StringExtensions.IsEmpty(System.String)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE388167C0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsEmpty(System.String)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383BB658],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38046670]; System.String.IsNullOrEmpty(System.String)
       mov       [rbp-0C],eax
       mov       eax,[rbp-0C]
       movzx     eax,al
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 55
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
       cmp       dword ptr [7FFE3838F438],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383D4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388167D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsFirstLastName()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+160]
       call      qword ptr [7FFE383C7A50]; DotNetTips.Spargine.Extensions.StringExtensions.IsFirstLastName(System.String)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE3879DED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsFirstLastName(System.String)
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383AB658],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,7FFE383ABB40
       mov       edx,29
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1C61C80B520
       mov       rdx,[rdx]
       mov       [rbp-10],rdx
       mov       rdx,206AE627D00
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,206AE620008
       call      qword ptr [7FFE38455D88]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE386573D8]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rbp-1C],eax
       mov       eax,[rbp-1C]
       movzx     eax,al
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 160
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
       call      qword ptr [7FFE383C4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38836178]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsGuid()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       lea       rdx,[rsp+20]
       mov       rcx,rbx
       call      qword ptr [7FFE383E4960]; DotNetTips.Spargine.Benchmarking.Benchmark.get_TestGuid()
       lea       rcx,[rsp+20]
       mov       rdx,21F56C71F10
       xor       r8d,r8d
       call      qword ptr [7FFE38107180]; System.Guid.ToString(System.String, System.IFormatProvider)
       mov       rcx,rax
       call      qword ptr [7FFE383E7A68]; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       edx,eax
       mov       rcx,rbx
       call      qword ptr [7FFE38826970]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 85
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_TestGuid()
       push      rbp
       push      rdi
       sub       rsp,28
       vzeroupper
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE383AF3E0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rcx,[rbp+18]
       vmovdqu   xmm0,xmmword ptr [rax+108]
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rax,[rbp+18]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 67
```
```assembly
; System.Guid.ToString(System.String, System.IFormatProvider)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        short M02_L00
       mov       edi,[rbx+8]
       test      edi,edi
       je        short M02_L00
       cmp       edi,1
       jne       near ptr M02_L04
       movzx     eax,word ptr [rbx+0C]
       or        eax,20
       cmp       eax,64
       jg        short M02_L05
       cmp       eax,62
       je        near ptr M02_L07
       cmp       eax,64
       jne       near ptr M02_L08
M02_L00:
       mov       ecx,24
M02_L01:
       call      System.String.FastAllocateString(Int32)
       mov       rbp,rax
       lea       rcx,[rbp+0C]
       mov       edx,[rbp+8]
       test      rbx,rbx
       jne       short M02_L03
       xor       r9d,r9d
       xor       r8d,r8d
M02_L02:
       mov       [rsp+30],rcx
       mov       [rsp+38],edx
       mov       [rsp+20],r9
       mov       [rsp+28],r8d
       mov       rcx,rsi
       lea       rdx,[rsp+30]
       lea       r9,[rsp+20]
       lea       r8,[rsp+40]
       call      qword ptr [7FFE382BCF48]; System.Guid.TryFormatCore[[System.Char, System.Private.CoreLib]](System.Span`1<Char>, Int32 ByRef, System.ReadOnlySpan`1<Char>)
       mov       rax,rbp
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       lea       r9,[rbx+0C]
       mov       edi,[rbx+8]
       mov       r8d,edi
       jmp       short M02_L02
M02_L04:
       call      qword ptr [7FFE38107348]
       int       3
M02_L05:
       cmp       eax,6E
       je        short M02_L06
       cmp       eax,70
       je        short M02_L07
       cmp       eax,78
       jne       short M02_L08
       mov       ecx,44
       jmp       short M02_L01
M02_L06:
       mov       ecx,20
       jmp       near ptr M02_L01
M02_L07:
       mov       ecx,26
       jmp       near ptr M02_L01
M02_L08:
       call      qword ptr [7FFE38107348]
       int       3
; Total bytes of code 235
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383CB658],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,7FFE383CBB40
       mov       edx,29
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1DEC4C0B528
       mov       rdx,[rdx]
       mov       [rbp-10],rdx
       mov       rdx,21F56C77D00
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,21F56C70008
       call      qword ptr [7FFE38475D88]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE386E48E8]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rbp-1C],eax
       mov       eax,[rbp-1C]
       movzx     eax,al
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 160
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
       cmp       dword ptr [7FFE383AF3E0],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3889F258]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsISBN()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+148]
       call      qword ptr [7FFE383BC360]; DotNetTips.Spargine.Extensions.StringExtensions.IsISBN(System.String)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387CD380]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsISBN(System.String)
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE3839B658],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,7FFE3839BB40
       mov       edx,29
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,26D5740B530
       mov       rdx,[rdx]
       mov       [rbp-10],rdx
       mov       rdx,2ADE9347D00
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2ADE9340008
       call      qword ptr [7FFE38445E00]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE386761A8]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rbp-1C],eax
       mov       eax,[rbp-1C]
       movzx     eax,al
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 160
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
       cmp       dword ptr [7FFE3837F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38856250]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsMacAddress()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,28701A83278
       call      qword ptr [7FFE383D7A98]; DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387ADDD0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383BB658],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,7FFE383BBB40
       mov       edx,29
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,2466FC0B538
       mov       rdx,[rdx]
       mov       [rbp-10],rdx
       mov       rdx,28701A77D00
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,28701A70008
       call      qword ptr [7FFE38465D88]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE386673D8]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rbp-1C],eax
       mov       eax,[rbp-1C]
       movzx     eax,al
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 160
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
       cmp       dword ptr [7FFE3838F438],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383D4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38846148]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsNotEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,16E8F5432F0
       call      qword ptr [7FFE383CC390]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE388069D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383AB658],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383CC318]; DotNetTips.Spargine.Extensions.StringExtensions.IsEmpty(System.String)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       sete      al
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 58
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
       call      qword ptr [7FFE388069E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsOneToSevenAlpha()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+158]
       call      qword ptr [7FFE383FC3A8]; DotNetTips.Spargine.Extensions.StringExtensions.IsOneToSevenAlpha(System.String)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE3880E820]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsOneToSevenAlpha(System.String)
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383DB658],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,7FFE383DBB40
       mov       edx,29
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1DEBDC09548
       mov       rdx,[rdx]
       mov       [rbp-10],rdx
       mov       rdx,21F4F937D00
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,21F4F930008
       call      qword ptr [7FFE38485E00]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE386BC558]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rbp-1C],eax
       mov       eax,[rbp-1C]
       movzx     eax,al
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 160
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
       call      qword ptr [7FFE383F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38896898]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsScientific()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,3210BCB32F0
       call      qword ptr [7FFE383E7AE0]; DotNetTips.Spargine.Extensions.StringExtensions.IsScientific(System.String)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE38827A98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsScientific(System.String)
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383CB658],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,7FFE383CBB40
       mov       edx,29
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,2E07A00B550
       mov       rdx,[rdx]
       mov       [rbp-10],rdx
       mov       rdx,3210BCA7D00
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,3210BCA0008
       call      qword ptr [7FFE38475D88]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE386E4CF0]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rbp-1C],eax
       mov       eax,[rbp-1C]
       movzx     eax,al
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 160
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
       cmp       dword ptr [7FFE383AF400],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388C4BE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsString()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFE383E4798]; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
       mov       rcx,rax
       call      qword ptr [7FFE383E7AF8]; DotNetTips.Spargine.Extensions.StringExtensions.IsString(System.String)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE38826970]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_LongTestString()
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
       mov       rax,[rax+28]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsString(System.String)
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383CB658],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,7FFE383CBB40
       mov       edx,29
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1B2CF80B568
       mov       rdx,[rdx]
       mov       [rbp-10],rdx
       mov       rdx,1F3615B7D00
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1F3615B0008
       call      qword ptr [7FFE38475D88]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE386E48E8]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rbp-1C],eax
       mov       eax,[rbp-1C]
       movzx     eax,al
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 160
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
       cmp       dword ptr [7FFE383AF390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3889F660]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsStringSHA1Hash()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+140]
       call      qword ptr [7FFE383E7B10]; DotNetTips.Spargine.Extensions.StringExtensions.IsStringSHA1Hash(System.String)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387BDF80]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsStringSHA1Hash(System.String)
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383CB658],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,7FFE383CBB40
       mov       edx,29
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,187D7C09560
       mov       rdx,[rdx]
       mov       [rbp-10],rdx
       mov       rdx,1C8699D7D00
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1C8699D0008
       call      qword ptr [7FFE38475D88]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE386773D8]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rbp-1C],eax
       mov       eax,[rbp-1C]
       movzx     eax,al
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 160
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
       cmp       dword ptr [7FFE383AF3F0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3885E160]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsUrl()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       call      qword ptr [7FFE383DC408]; DotNetTips.Spargine.Extensions.StringExtensions.IsUrl(System.String)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387EE970]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsUrl(System.String)
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383BB658],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,7FFE383BBB40
       mov       edx,29
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,18564C09578
       mov       rdx,[rdx]
       mov       [rbp-10],rdx
       mov       rdx,1C5F6C07D00
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1C5F6C00008
       call      qword ptr [7FFE38465E00]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3869C600]; System.Text.RegularExpressions.Regex.Match(System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387EEAC0]; System.Text.RegularExpressions.Group.get_Success()
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       movzx     eax,al
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 181
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
       call      qword ptr [7FFE388B5B60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ReplaceEllipsisWithPeriod()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+168]
       call      qword ptr [7FFE383CC438]; DotNetTips.Spargine.Extensions.StringExtensions.ReplaceEllipsisWithPeriod(System.String)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387DDF80]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ReplaceEllipsisWithPeriod(System.String)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383AB658],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,239ED1B7D00
       mov       [rsp+20],rcx
       mov       rcx,[rbp+10]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,239ED1B0008
       call      qword ptr [7FFE383CC8A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rdx,239ED1B75D8
       mov       r8d,5
       cmp       [rcx],ecx
       call      qword ptr [7FFE38036130]; System.String.EndsWith(System.String, System.StringComparison)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-30],rcx
       xor       ecx,ecx
       mov       [rbp-34],ecx
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380369E8]; System.String.get_Length()
       mov       [rbp-38],eax
       mov       r8d,[rbp-38]
       add       r8d,0FFFFFFFE
       mov       rcx,[rbp-30]
       mov       edx,[rbp-34]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38037240]; System.String.Substring(Int32, Int32)
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       mov       [rbp+10],rax
       nop
M01_L01:
       mov       rax,[rbp+10]
       mov       [rbp-18],rax
       nop
       mov       rax,[rbp-18]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 246
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
       mov       rdx,7FFE387F0130
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387DDFB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.StartsWithOrdinal()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,273A00E32F0
       mov       rdx,273A00E3320
       call      qword ptr [7FFE383C7BE8]; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE38806970]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE383AB658],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+10],0
       je        short M01_L01
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       jmp       short M01_L02
M01_L01:
       mov       dword ptr [rbp-0C],1
M01_L02:
       mov       ecx,[rbp-0C]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L03
       nop
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       mov       rcx,[rbp+18]
       mov       [rbp-28],rcx
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380369E8]; System.String.get_Length()
       mov       [rbp-30],eax
       mov       ecx,[rbp-30]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],4
       mov       rcx,[rbp-18]
       mov       edx,[rbp-1C]
       mov       r8,[rbp-28]
       mov       r9d,[rbp-2C]
       call      qword ptr [7FFE38036088]; System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       mov       [rbp-34],eax
       xor       eax,eax
       cmp       dword ptr [rbp-34],0
       sete      al
       mov       [rbp-8],eax
       nop
M01_L04:
       mov       eax,[rbp-8]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 208
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
       cmp       dword ptr [7FFE3837F488],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383C4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388069D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.StartsWithOrdinalIgnoreCase()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,16B7CC132F0
       mov       rdx,16B7CC13320
       call      qword ptr [7FFE383C7C00]; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE388069D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE383AB658],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+10],0
       je        short M01_L01
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       jmp       short M01_L02
M01_L01:
       mov       dword ptr [rbp-0C],1
M01_L02:
       mov       ecx,[rbp-0C]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L03
       nop
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       mov       rcx,[rbp+18]
       mov       [rbp-28],rcx
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380369E8]; System.String.get_Length()
       mov       [rbp-30],eax
       mov       ecx,[rbp-30]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],5
       mov       rcx,[rbp-18]
       mov       edx,[rbp-1C]
       mov       r8,[rbp-28]
       mov       r9d,[rbp-2C]
       call      qword ptr [7FFE38036088]; System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       mov       [rbp-34],eax
       xor       eax,eax
       cmp       dword ptr [rbp-34],0
       sete      al
       mov       [rbp-8],eax
       nop
M01_L04:
       mov       eax,[rbp-8]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 208
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
       call      qword ptr [7FFE383C4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388069E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.SubstringTrim()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       mov       edx,19
       mov       r8d,19
       call      qword ptr [7FFE383BC4F8]; DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387C5ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 68
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       push      rbp
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FFE3839B658],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383BE1C0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       mov       [rbp-3C],eax
       mov       ecx,[rbp-3C]
       movzx     ecx,cl
       mov       [rbp-14],ecx
       cmp       dword ptr [rbp-14],0
       je        short M01_L02
       nop
       mov       rcx,1BE15220008
       mov       [rbp-20],rcx
       nop
       jmp       near ptr M01_L26
M01_L02:
       mov       ecx,[rbp+18]
       call      qword ptr [7FFE38646A30]; DotNetTips.Spargine.Extensions.NumericExtensions.IsNegative(Int32)
       mov       [rbp-40],eax
       mov       ecx,[rbp-40]
       movzx     ecx,cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       je        short M01_L03
       nop
       mov       rcx,1BE152243D0
       call      qword ptr [7FFE38446670]
       nop
       nop
M01_L03:
       mov       ecx,[rbp+20]
       call      qword ptr [7FFE38646A30]; DotNetTips.Spargine.Extensions.NumericExtensions.IsNegative(Int32)
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       movzx     ecx,cl
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       je        short M01_L04
       nop
       mov       rcx,1BE152275F8
       call      qword ptr [7FFE38446670]
       nop
       nop
M01_L04:
       mov       ecx,[rbp+18]
       mov       [rbp-48],ecx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380269E8]; System.String.get_Length()
       mov       [rbp-4C],eax
       mov       eax,[rbp-4C]
       sub       eax,[rbp+20]
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       cmp       eax,[rbp-48]
       setle     al
       movzx     eax,al
       mov       [rbp-2C],eax
       cmp       dword ptr [rbp-2C],0
       je        short M01_L06
       nop
       call      qword ptr [7FFE38204180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp-90],rax
       call      qword ptr [7FFE387C65E0]
       mov       [rbp-98],rax
       mov       rcx,1BE152332A0
       mov       [rsp+20],rcx
       mov       rcx,[rbp-90]
       mov       rdx,[rbp-98]
       mov       r8,1BE152243D0
       mov       r9,1BE152275F8
       call      qword ptr [7FFE38026C58]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       rdx,1BE152243D0
       call      qword ptr [7FFE38446688]
       nop
       nop
M01_L06:
       xor       ecx,ecx
       cmp       dword ptr [rbp+20],0
       sete      cl
       mov       [rbp-30],ecx
       cmp       dword ptr [rbp-30],0
       je        short M01_L07
       nop
       mov       rcx,1BE15220008
       mov       [rbp-20],rcx
       nop
       jmp       near ptr M01_L26
M01_L07:
       mov       ecx,[rbp+18]
       add       ecx,[rbp+20]
       jno       short M01_L08
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       sub       ecx,1
       jno       short M01_L09
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       mov       [rbp-4],ecx
       nop
       jmp       short M01_L12
M01_L10:
       nop
       mov       ecx,[rbp+18]
       add       ecx,1
       jno       short M01_L11
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       mov       [rbp+18],ecx
       nop
M01_L12:
       mov       ecx,[rbp+18]
       cmp       ecx,[rbp-4]
       jg        short M01_L13
       mov       rcx,[rbp+10]
       mov       edx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380269D0]; System.String.get_Chars(Int32)
       mov       [rbp-84],eax
       mov       ecx,[rbp-84]
       call      qword ptr [7FFE37FB5CE0]; System.Char.IsWhiteSpace(Char)
       mov       [rbp-88],eax
       mov       ecx,[rbp-88]
       mov       [rbp-50],ecx
       jmp       short M01_L14
M01_L13:
       xor       ecx,ecx
       mov       [rbp-50],ecx
M01_L14:
       mov       ecx,[rbp-50]
       movzx     ecx,cl
       mov       [rbp-34],ecx
       cmp       dword ptr [rbp-34],0
       jne       short M01_L10
       nop
       jmp       short M01_L17
M01_L15:
       nop
       mov       ecx,[rbp-4]
       sub       ecx,1
       jno       short M01_L16
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       mov       [rbp-4],ecx
       nop
M01_L17:
       mov       ecx,[rbp-4]
       cmp       ecx,[rbp+18]
       jl        short M01_L18
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380269D0]; System.String.get_Chars(Int32)
       mov       [rbp-7C],eax
       mov       ecx,[rbp-7C]
       call      qword ptr [7FFE37FB5CE0]; System.Char.IsWhiteSpace(Char)
       mov       [rbp-80],eax
       mov       ecx,[rbp-80]
       mov       [rbp-54],ecx
       jmp       short M01_L19
M01_L18:
       xor       ecx,ecx
       mov       [rbp-54],ecx
M01_L19:
       mov       ecx,[rbp-54]
       movzx     ecx,cl
       mov       [rbp-38],ecx
       cmp       dword ptr [rbp-38],0
       jne       short M01_L15
       mov       ecx,[rbp-4]
       sub       ecx,[rbp+18]
       jno       short M01_L20
       call      CORINFO_HELP_OVERFLOW
M01_L20:
       add       ecx,1
       jno       short M01_L21
       call      CORINFO_HELP_OVERFLOW
M01_L21:
       mov       [rbp-8],ecx
       mov       ecx,[rbp-8]
       mov       [rbp-58],ecx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380269E8]; System.String.get_Length()
       mov       [rbp-5C],eax
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-5C]
       je        short M01_L22
       mov       rcx,[rbp+10]
       mov       edx,[rbp+18]
       mov       r8d,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38027240]; System.String.Substring(Int32, Int32)
       mov       [rbp-78],rax
       mov       rax,[rbp-78]
       mov       [rbp-68],rax
       jmp       short M01_L23
M01_L22:
       mov       rax,[rbp+10]
       mov       [rbp-68],rax
M01_L23:
       mov       rax,[rbp-68]
       mov       [rbp-10],rax
       cmp       dword ptr [rbp-8],0
       je        short M01_L24
       mov       rax,[rbp-10]
       mov       [rbp-70],rax
       jmp       short M01_L25
M01_L24:
       mov       rax,1BE15220008
       mov       [rbp-70],rax
M01_L25:
       mov       rax,[rbp-70]
       mov       [rbp-20],rax
       nop
M01_L26:
       mov       rax,[rbp-20]
       add       rsp,0D0
       pop       rbp
       ret
; Total bytes of code 801
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
       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE3878E568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387C6718]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToDeflateStringAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE38826D48]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToDeflateStringAsync>d__63, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToDeflateStringAsync>d__63 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE387C52F0]
       jmp       short M00_L00
; Total bytes of code 85
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFE38826A30]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToDeflateStringAsync>d__63, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToDeflateStringAsync>d__63 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFE3805D1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE38826C10]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToDeflateStringAsync>d__63.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFE3878FCC0]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFE3878FCC0]
M03_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 254
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE38284B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFE382842E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFE38826A48]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE38284768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToTitleCase()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,1EC745732A0
       call      qword ptr [7FFE383EC588]; DotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387FE310]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383CB658],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383EE1C0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       mov       [rbp-14],eax
       mov       eax,[rbp-14]
       movzx     eax,al
       mov       [rbp-4],eax
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       rax,[rbp+10]
       mov       [rbp-10],rax
       nop
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FFE38234180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3823C378]; System.Globalization.TextInfo.ToTitleCase(System.String)
       mov       [rbp-30],rax
       mov       rax,[rbp-30]
       mov       [rbp-10],rax
       nop
M01_L02:
       mov       rax,[rbp-10]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 159
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
       mov       rdx,7FFE38810130
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387FE730]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToTrimmedString()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       call      qword ptr [7FFE383BC5A0]; DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387CE970]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE3839B658],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383BE1C0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       mov       [rbp-14],eax
       mov       ecx,[rbp-14]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-10],rcx
       nop
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380273A8]; System.String.TrimEnd()
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38027360]; System.String.TrimStart()
       mov       [rbp-28],rax
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       nop
M01_L02:
       mov       rax,[rbp-10]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 140
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
       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE387AFF78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387CE9A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToZLibStringAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE38806D48]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToZLibStringAsync>d__66, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToZLibStringAsync>d__66 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE387952F0]
       jmp       short M00_L00
; Total bytes of code 85
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFE38806A30]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToZLibStringAsync>d__66, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToZLibStringAsync>d__66 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFE3803D1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE38806C10]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToZLibStringAsync>d__66.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFE3876FCC0]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFE3876FCC0]
M03_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 254
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE38264B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFE382642E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFE38806A48]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE38264768]
       jmp       short M04_L02
; Total bytes of code 139
```

