## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.AppInfo()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,1C3AE805C80
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M00_L01
       mov       rsi,[rcx+18]
M00_L00:
       mov       [rsp+20],rsi
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      qword ptr [7FFF3A72DE78]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M00_L00
; Total bytes of code 87
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
       mov       rbx,rcx
M01_L00:
       mov       rsi,[rbx+8]
M01_L00:
       mov       rsi,[rbx+8]
M01_L00:
       mov       rsi,[rbx+8]
M01_L00:
       mov       rsi,[rbx+8]
M01_L00:
       mov       rsi,[rbx+8]
M01_L00:
       mov       rsi,[rbx+8]
M01_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       test      rsi,rsi
       je        short M01_L01
       je        short M01_L01
       je        short M01_L01
       je        short M01_L01
       je        short M01_L01
       je        short M01_L01
       je        short M01_L01
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       mov       edi,[rsi+10]
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       cmp       edi,8
       jne       short M01_L03
       jne       short M01_L03
       jne       short M01_L03
       jne       short M01_L03
       jne       short M01_L03
       jne       short M01_L03
       jne       short M01_L03
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FFF99CF2C48]
       call      qword ptr [7FFF99CF2C48]
       call      qword ptr [7FFF99CF2C48]
       call      qword ptr [7FFF99CF2C48]
       call      qword ptr [7FFF99CF2C48]
       call      qword ptr [7FFF99CF2C48]
       call      qword ptr [7FFF99CF2C48]
M01_L01:
       cmp       qword ptr [rbx+8],0
M01_L01:
       cmp       qword ptr [rbx+8],0
M01_L01:
       cmp       qword ptr [rbx+8],0
M01_L01:
       cmp       qword ptr [rbx+8],0
M01_L01:
       cmp       qword ptr [rbx+8],0
M01_L01:
       cmp       qword ptr [rbx+8],0
M01_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M01_L02
       jne       short M01_L02
       jne       short M01_L02
       jne       short M01_L02
       jne       short M01_L02
       jne       short M01_L02
       jne       short M01_L02
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       mov       rax,[rbx+18]
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       ret
       ret
       ret
       ret
       ret
       ret
       ret
M01_L02:
       mov       rcx,rbx
M01_L02:
       mov       rcx,rbx
M01_L02:
       mov       rcx,rbx
M01_L02:
       mov       rcx,rbx
M01_L02:
       mov       rcx,rbx
M01_L02:
       mov       rcx,rbx
M01_L02:
       mov       rcx,rbx
       lea       rax,[7FFF99CF2C78]
       lea       rax,[7FFF99CF2C78]
       lea       rax,[7FFF99CF2C78]
       lea       rax,[7FFF99CF2C78]
       lea       rax,[7FFF99CF2C78]
       lea       rax,[7FFF99CF2C78]
       lea       rax,[7FFF99CF2C78]
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
M01_L03:
       cmp       edi,8
M01_L03:
       cmp       edi,8
M01_L03:
       cmp       edi,8
M01_L03:
       cmp       edi,8
M01_L03:
       cmp       edi,8
M01_L03:
       cmp       edi,8
M01_L03:
       cmp       edi,8
       ja        short M01_L04
       ja        short M01_L04
       ja        short M01_L04
       ja        short M01_L04
       ja        short M01_L04
       ja        short M01_L04
       ja        short M01_L04
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       mov       ecx,edi
       lea       rdx,[7FFF99B732D8]
       lea       rdx,[7FFF99B732D8]
       lea       rdx,[7FFF99B732D8]
       lea       rdx,[7FFF99B732D8]
       lea       rdx,[7FFF99B732D8]
       lea       rdx,[7FFF99B732D8]
       lea       rdx,[7FFF99B732D8]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M01_L00]
       lea       rax,[M01_L00]
       lea       rax,[M01_L00]
       lea       rax,[M01_L00]
       lea       rax,[M01_L00]
       lea       rax,[M01_L00]
       lea       rax,[M01_L00]
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       call      qword ptr [7FFF99CF2C40]
       call      qword ptr [7FFF99CF2C40]
       call      qword ptr [7FFF99CF2C40]
       call      qword ptr [7FFF99CF2C40]
       call      qword ptr [7FFF99CF2C40]
       call      qword ptr [7FFF99CF2C40]
       call      qword ptr [7FFF99CF2C40]
       jmp       short M01_L01
       jmp       short M01_L01
       jmp       short M01_L01
       jmp       short M01_L01
       jmp       short M01_L01
       jmp       short M01_L01
       jmp       short M01_L01
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       call      qword ptr [7FFF99CF2C48]
       call      qword ptr [7FFF99CF2C48]
       call      qword ptr [7FFF99CF2C48]
       call      qword ptr [7FFF99CF2C48]
       call      qword ptr [7FFF99CF2C48]
       call      qword ptr [7FFF99CF2C48]
       call      qword ptr [7FFF99CF2C48]
       jmp       short M01_L01
       jmp       short M01_L01
       jmp       short M01_L01
       jmp       short M01_L01
       jmp       short M01_L01
       jmp       short M01_L01
       jmp       short M01_L01
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       mov       rax,[rbx+10]
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       je        short M01_L05
       je        short M01_L05
       je        short M01_L05
       je        short M01_L05
       je        short M01_L05
       je        short M01_L05
       je        short M01_L05
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFF99CF2C50]
       call      qword ptr [7FFF99CF2C50]
       call      qword ptr [7FFF99CF2C50]
       call      qword ptr [7FFF99CF2C50]
       call      qword ptr [7FFF99CF2C50]
       call      qword ptr [7FFF99CF2C50]
       call      qword ptr [7FFF99CF2C50]
       jmp       near ptr M01_L01
       jmp       near ptr M01_L01
       jmp       near ptr M01_L01
       jmp       near ptr M01_L01
       jmp       near ptr M01_L01
       jmp       near ptr M01_L01
       jmp       near ptr M01_L01
M01_L04:
       mov       rcx,[rsi+8]
M01_L04:
       mov       rcx,[rsi+8]
M01_L04:
       mov       rcx,[rsi+8]
M01_L04:
       mov       rcx,[rsi+8]
M01_L04:
       mov       rcx,[rsi+8]
M01_L04:
       mov       rcx,[rsi+8]
M01_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFF99CEA0A0]
       call      qword ptr [7FFF99CEA0A0]
       call      qword ptr [7FFF99CEA0A0]
       call      qword ptr [7FFF99CEA0A0]
       call      qword ptr [7FFF99CEA0A0]
       call      qword ptr [7FFF99CEA0A0]
       call      qword ptr [7FFF99CEA0A0]
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFF99CF2C38]
       call      qword ptr [7FFF99CF2C38]
       call      qword ptr [7FFF99CF2C38]
       call      qword ptr [7FFF99CF2C38]
       call      qword ptr [7FFF99CF2C38]
       call      qword ptr [7FFF99CF2C38]
       call      qword ptr [7FFF99CF2C38]
       jmp       near ptr M01_L01
       jmp       near ptr M01_L01
       jmp       near ptr M01_L01
       jmp       near ptr M01_L01
       jmp       near ptr M01_L01
       jmp       near ptr M01_L01
       jmp       near ptr M01_L01
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       mov       rcx,[rbx]
       call      qword ptr [7FFF99CD5908]
       call      qword ptr [7FFF99CD5908]
       call      qword ptr [7FFF99CD5908]
       call      qword ptr [7FFF99CD5908]
       call      qword ptr [7FFF99CD5908]
       call      qword ptr [7FFF99CD5908]
       call      qword ptr [7FFF99CD5908]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFF99CF8580]
       call      qword ptr [7FFF99CF8580]
       call      qword ptr [7FFF99CF8580]
       call      qword ptr [7FFF99CF8580]
       call      qword ptr [7FFF99CF8580]
       call      qword ptr [7FFF99CF8580]
       call      qword ptr [7FFF99CF8580]
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       rcx,rbx
       call      qword ptr [7FFF99CF2C50]
       call      qword ptr [7FFF99CF2C50]
       call      qword ptr [7FFF99CF2C50]
       call      qword ptr [7FFF99CF2C50]
       call      qword ptr [7FFF99CF2C50]
       call      qword ptr [7FFF99CF2C50]
       call      qword ptr [7FFF99CF2C50]
       jmp       near ptr M01_L01
       jmp       near ptr M01_L01
       jmp       near ptr M01_L01
       jmp       near ptr M01_L01
       jmp       near ptr M01_L01
       jmp       near ptr M01_L01
       jmp       near ptr M01_L01
M01_L05:
       mov       rcx,rbx
M01_L05:
       mov       rcx,rbx
M01_L05:
       mov       rcx,rbx
M01_L05:
       mov       rcx,rbx
M01_L05:
       mov       rcx,rbx
M01_L05:
       mov       rcx,rbx
M01_L05:
       mov       rcx,rbx
       call      qword ptr [7FFF99CF2C60]
       call      qword ptr [7FFF99CF2C60]
       call      qword ptr [7FFF99CF2C60]
       call      qword ptr [7FFF99CF2C60]
       call      qword ptr [7FFF99CF2C60]
       call      qword ptr [7FFF99CF2C60]
       call      qword ptr [7FFF99CF2C60]
       jmp       near ptr M01_L01
       jmp       near ptr M01_L01
       jmp       near ptr M01_L01
       jmp       near ptr M01_L01
       jmp       near ptr M01_L01
       jmp       near ptr M01_L01
       jmp       near ptr M01_L01
; Total bytes of code 1841
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.CurrentCulture()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFF3A4A4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 56
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       sub       rsp,28
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],3
       jl        short M01_L02
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M01_L02
       mov       rdx,[rax]
       add       rdx,10
M01_L00:
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M01_L01
       mov       rax,16403800438
       mov       rax,[rax]
       test      rax,rax
       jne       short M01_L01
       mov       rax,16403800418
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L03
M01_L01:
       add       rsp,28
       ret
M01_L02:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rdx,rax
       jmp       short M01_L00
M01_L03:
       add       rsp,28
       jmp       qword ptr [7FFF3A4A4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
; Total bytes of code 124
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.CurrentThreadId()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 26
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.CurrentUICulture()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFF3A4A41B0]; System.Globalization.CultureInfo.get_CurrentUICulture()
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 56
```
```assembly
; System.Globalization.CultureInfo.get_CurrentUICulture()
       push      rbx
       sub       rsp,20
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       cmp       dword ptr [rax+190],3
       jl        short M01_L02
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M01_L02
       mov       rax,[rax]
       add       rax,10
M01_L00:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M01_L01
       mov       rax,20464800430
       mov       rax,[rax]
       test      rax,rax
       jne       short M01_L01
       mov       rbx,20464800420
       mov       rax,[rbx]
       test      rax,rax
       jne       short M01_L01
       call      qword ptr [7FFF3A4A46D8]; System.Globalization.CultureInfo.GetUserDefaultUICulture()
       mov       rdx,rax
       mov       rcx,20464800420
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rax,[rbx]
M01_L01:
       add       rsp,20
       pop       rbx
       ret
M01_L02:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M01_L00
; Total bytes of code 143
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.ExecutingFolder()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,182FC403888
       mov       rax,[rcx]
       test      rax,rax
       je        short M00_L01
M00_L00:
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,offset DotNetTips.Spargine.Core.App.ExecutingFolder()
       mov       r9,7FFF3A20D3C0
       call      qword ptr [7FFF3A354258]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,182FC403888
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M00_L00
; Total bytes of code 142
```
```assembly
; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       push      rdi
       push      rsi
       push      rbx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,r9
       lea       rcx,[rbx+8]
       mov       rdx,rbx
       call      qword ptr [7FFF99CD2D30]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```
**Method was not JITted yet.**
DotNetTips.Spargine.Core.App.ExecutingFolder()

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.GetCultureNames()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,25BDE405888
       mov       rax,[rcx]
       test      rax,rax
       je        short M00_L01
M00_L00:
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,offset MT_<>f__AnonymousDelegate0`2[[System.Globalization.CultureTypes, System.Private.CoreLib],[System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,offset DotNetTips.Spargine.Core.App.GetCultureNames(System.Globalization.CultureTypes)
       mov       r9,7FFF3A1FD170
       call      qword ptr [7FFF3A344258]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,25BDE405888
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M00_L00
; Total bytes of code 142
```
```assembly
; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       push      rdi
       push      rsi
       push      rbx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,r9
       lea       rcx,[rbx+8]
       mov       rdx,rbx
       call      qword ptr [7FFF99CD2D30]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```
**Method was not JITted yet.**
DotNetTips.Spargine.Core.App.GetCultureNames(System.Globalization.CultureTypes)

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.GetEnvironmentVariables()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,21FCE405890
       mov       rax,[rcx]
       test      rax,rax
       je        short M00_L01
M00_L00:
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`1[[System.Collections.Immutable.IImmutableDictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Collections.Immutable]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,offset DotNetTips.Spargine.Core.App.GetEnvironmentVariables()
       mov       r9,7FFF3A1FD3C0
       call      qword ptr [7FFF3A344258]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,21FCE405890
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M00_L00
; Total bytes of code 142
```
```assembly
; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       push      rdi
       push      rsi
       push      rbx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,r9
       lea       rcx,[rbx+8]
       mov       rdx,rbx
       call      qword ptr [7FFF99CD2D30]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```
**Method was not JITted yet.**
DotNetTips.Spargine.Core.App.GetEnvironmentVariables()

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.GetProcessorInformation()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,19787405898
       mov       rax,[rcx]
       test      rax,rax
       je        short M00_L01
M00_L00:
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`1[[DotNetTips.Spargine.Core.ProcessorInformation, DotNetTips.Spargine.8.Core]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,offset DotNetTips.Spargine.Core.App.GetProcessorInformation()
       mov       r9,7FFF3A20D170
       call      qword ptr [7FFF3A354258]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,19787405898
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M00_L00
; Total bytes of code 142
```
```assembly
; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       push      rdi
       push      rsi
       push      rbx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,r9
       lea       rcx,[rbx+8]
       mov       rdx,rbx
       call      qword ptr [7FFF99CD2D30]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```
**Method was not JITted yet.**
DotNetTips.Spargine.Core.App.GetProcessorInformation()

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.InstalledUICulture()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFF3A4B41F8]; System.Globalization.CultureInfo.get_InstalledUICulture()
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 56
```
```assembly
; System.Globalization.CultureInfo.get_InstalledUICulture()
       mov       rax,1CB1A800418
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L00
       ret
M01_L00:
       jmp       qword ptr [7FFF3A4B4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
; Total bytes of code 25
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.IsRunning()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,25BC0C038A8
       mov       rax,[rcx]
       test      rax,rax
       je        short M00_L01
M00_L00:
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`1[[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,offset DotNetTips.Spargine.Core.App.IsRunning()
       mov       r9,7FFF3A20D3C0
       call      qword ptr [7FFF3A354258]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,25BC0C038A8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M00_L00
; Total bytes of code 142
```
```assembly
; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       push      rdi
       push      rsi
       push      rbx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,r9
       lea       rcx,[rbx+8]
       mov       rdx,rbx
       call      qword ptr [7FFF99CD2D30]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```
**Method was not JITted yet.**
DotNetTips.Spargine.Core.App.IsRunning()

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.IsRunningFromAspNet()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,1B49FC058A8
       mov       rax,[rcx]
       test      rax,rax
       je        short M00_L01
M00_L00:
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`1[[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,offset DotNetTips.Spargine.Core.App.IsRunningFromAspNet()
       mov       r9,7FFF3A1ED3C0
       call      qword ptr [7FFF3A334258]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,1B49FC058A8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M00_L00
; Total bytes of code 142
```
```assembly
; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       push      rdi
       push      rsi
       push      rbx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,r9
       lea       rcx,[rbx+8]
       mov       rdx,rbx
       call      qword ptr [7FFF99CD2D30]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```
**Method was not JITted yet.**
DotNetTips.Spargine.Core.App.IsRunningFromAspNet()

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.IsUserAdministrator()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,2465D4058B0
       mov       rax,[rcx]
       test      rax,rax
       je        short M00_L01
M00_L00:
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`1[[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,offset DotNetTips.Spargine.Core.App.IsUserAdministrator()
       mov       r9,7FFF3A1FD3C0
       call      qword ptr [7FFF3A344258]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,2465D4058B0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M00_L00
; Total bytes of code 142
```
```assembly
; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       push      rdi
       push      rsi
       push      rbx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,r9
       lea       rcx,[rbx+8]
       mov       rdx,rbx
       call      qword ptr [7FFF99CD2D30]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```
**Method was not JITted yet.**
DotNetTips.Spargine.Core.App.IsUserAdministrator()

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.MaxDegreeOfParallelism()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,1FC290058B8
       mov       rax,[rcx]
       test      rax,rax
       je        short M00_L01
M00_L00:
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,offset DotNetTips.Spargine.Core.App.MaxDegreeOfParallelism()
       mov       r9,7FFF3A21D3C0
       call      qword ptr [7FFF3A364258]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,1FC290058B8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M00_L00
; Total bytes of code 142
```
```assembly
; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       push      rdi
       push      rsi
       push      rbx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,r9
       lea       rcx,[rbx+8]
       mov       rdx,rbx
       call      qword ptr [7FFF99CD2D30]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```
**Method was not JITted yet.**
DotNetTips.Spargine.Core.App.MaxDegreeOfParallelism()

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.OSArchitecture()
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       call      qword ptr [7FFF3A647AB0]; System.Runtime.InteropServices.RuntimeInformation.get_OSArchitecture()
       mov       [rsp+28],eax
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+28]
       call      qword ptr [7FFF3AADE6E8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Runtime.InteropServices.Architecture, System.Private.CoreLib]](System.Runtime.InteropServices.Architecture ByRef)
       nop
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 42
```
```assembly
; System.Runtime.InteropServices.RuntimeInformation.get_OSArchitecture()
       push      rbp
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+70]
       mov       eax,[7FFF3A275CF8]
       dec       eax
       js        short M01_L01
M01_L00:
       add       rsp,68
       pop       rbx
       pop       rbp
       ret
M01_L01:
       mov       rcx,2C2DC2A4760
       xor       edx,edx
       mov       r8d,800
       call      qword ptr [7FFF3A4A5E60]; Interop+Kernel32.LoadLibraryEx(System.String, IntPtr, Int32)
       mov       rcx,rax
       lea       r8,[rbp-10]
       mov       rdx,2C2DC2AAAF0
       call      qword ptr [7FFF3A6C7990]
       test      eax,eax
       je        short M01_L03
       mov       rbx,[rbp-10]
       call      Interop+Kernel32.GetCurrentProcess()
       mov       rcx,rax
       lea       r8,[rbp-20]
       lea       rdx,[rbp-18]
       mov       r10,rbx
       mov       r11,2C2DC276B30
       call      CORINFO_HELP_PINVOKE_CALLI
       test      eax,eax
       je        short M01_L02
       movzx     ecx,word ptr [rbp-20]
       call      qword ptr [7FFF3A647AE0]; System.Runtime.InteropServices.RuntimeInformation.MapMachineConstant(UInt16)
       jmp       short M01_L04
M01_L02:
       mov       eax,1
       jmp       short M01_L04
M01_L03:
       lea       rcx,[rbp-50]
       call      Interop+Kernel32.GetNativeSystemInfo(SYSTEM_INFO*)
       movzx     ecx,word ptr [rbp-50]
       call      qword ptr [7FFF3A647AC8]
M01_L04:
       lea       ecx,[rax+1]
       mov       [7FFF3A275CF8],ecx
       jmp       near ptr M01_L00
; Total bytes of code 173
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Runtime.InteropServices.Architecture, System.Private.CoreLib]](System.Runtime.InteropServices.Architecture ByRef)
       ret
; Total bytes of code 1
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.OSDescription()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFF3A64C060]; System.Runtime.InteropServices.RuntimeInformation.get_OSDescription()
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 56
```
```assembly
; System.Runtime.InteropServices.RuntimeInformation.get_OSDescription()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,0A0
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+70],xmm4
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,68F2803BB053
       mov       [rbp+8],rax
       mov       rax,286FE400B00
       mov       rbx,[rax]
       test      rbx,rbx
       je        short M01_L03
M01_L01:
       mov       rax,rbx
       mov       rcx,68F2803BB053
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+70]
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFF3A3E6868]; System.Environment.get_OSVersion()
       mov       rbx,rax
       mov       rsi,[rbx+8]
       test      [rsp],esp
       sub       rsp,200
       lea       rax,[rsp+30]
       mov       rcx,[rbx+10]
       mov       rdx,2C790360008
       test      rcx,rcx
       cmove     rcx,rdx
       test      rcx,rcx
       je        near ptr M01_L12
       cmp       dword ptr [rcx+8],0
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L12
       mov       [rbp+10],rax
       mov       dword ptr [rbp+18],100
       lea       rcx,[rbp+10]
       mov       [rsp+20],rcx
       lea       rcx,[rbp+48]
       mov       edx,4
       mov       r8d,5
       xor       r9d,r9d
       call      qword ptr [7FFF3A4756E0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32, System.IFormatProvider, System.Span`1<Char>)
       lea       rcx,[rbp+48]
       mov       rdx,2C79037AAF0
       call      qword ptr [7FFF3A475830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp+58]
       cmp       ecx,[rbp+68]
       ja        near ptr M01_L17
       mov       rdx,[rbp+60]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp+68]
       sub       eax,ecx
       cmp       eax,1
       jb        short M01_L04
       mov       rcx,2C790367D44
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp+58]
       inc       ecx
       mov       [rbp+58],ecx
       jmp       short M01_L05
M01_L04:
       lea       rcx,[rbp+48]
       mov       rdx,2C790367D38
       call      qword ptr [7FFF3A4758F0]
M01_L05:
       mov       edx,[rsi+8]
       lea       rcx,[rbp+48]
       call      qword ptr [7FFF3A7C4B88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.UInt32, System.Private.CoreLib]](UInt32)
       mov       ecx,[rbp+58]
       cmp       ecx,[rbp+68]
       ja        near ptr M01_L17
       mov       rdx,[rbp+60]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp+68]
       sub       eax,ecx
       cmp       eax,1
       jb        short M01_L06
       mov       rcx,2C790360C54
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp+58]
       inc       ecx
       mov       [rbp+58],ecx
       jmp       short M01_L07
M01_L06:
       lea       rcx,[rbp+48]
       mov       rdx,2C790360C48
       call      qword ptr [7FFF3A4758F0]
M01_L07:
       mov       edx,[rsi+0C]
       lea       rcx,[rbp+48]
       call      qword ptr [7FFF3A7C4B88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.UInt32, System.Private.CoreLib]](UInt32)
       mov       ecx,[rbp+58]
       cmp       ecx,[rbp+68]
       ja        near ptr M01_L17
       mov       rdx,[rbp+60]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp+68]
       sub       eax,ecx
       cmp       eax,1
       jb        short M01_L08
       mov       rcx,2C790360C54
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp+58]
       inc       ecx
       mov       [rbp+58],ecx
       jmp       short M01_L09
M01_L08:
       lea       rcx,[rbp+48]
       mov       rdx,2C790360C48
       call      qword ptr [7FFF3A4758F0]
M01_L09:
       mov       edx,[rsi+10]
       lea       rcx,[rbp+48]
       call      qword ptr [7FFF3A7C4B88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.UInt32, System.Private.CoreLib]](UInt32)
       mov       ecx,[rbp+58]
       cmp       ecx,[rbp+68]
       ja        near ptr M01_L17
       mov       rdx,[rbp+60]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp+68]
       sub       eax,ecx
       cmp       eax,1
       jb        short M01_L10
       mov       rcx,2C790367D44
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp+58]
       inc       ecx
       mov       [rbp+58],ecx
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+48]
       mov       rdx,2C790367D38
       call      qword ptr [7FFF3A4758F0]
M01_L11:
       mov       rdx,[rbx+10]
       mov       rcx,2C790360008
       test      rdx,rdx
       cmove     rdx,rcx
       lea       rcx,[rbp+48]
       call      qword ptr [7FFF3A475830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp+48]
       call      qword ptr [7FFF3A475740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rbx,rax
       jmp       near ptr M01_L21
M01_L12:
       mov       [rbp+10],rax
       mov       dword ptr [rbp+18],100
       lea       rcx,[rbp+10]
       mov       [rsp+20],rcx
       lea       rcx,[rbp+20]
       mov       edx,3
       mov       r8d,4
       xor       r9d,r9d
       call      qword ptr [7FFF3A4756E0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32, System.IFormatProvider, System.Span`1<Char>)
       lea       rcx,[rbp+20]
       mov       rdx,2C79037AAF0
       call      qword ptr [7FFF3A475830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp+30]
       cmp       ecx,[rbp+40]
       ja        near ptr M01_L17
       mov       rdx,[rbp+38]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp+40]
       sub       eax,ecx
       cmp       eax,1
       jb        short M01_L13
       mov       rcx,2C790367D44
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp+30]
       inc       ecx
       mov       [rbp+30],ecx
       jmp       short M01_L14
M01_L13:
       lea       rcx,[rbp+20]
       mov       rdx,2C790367D38
       call      qword ptr [7FFF3A4758F0]
M01_L14:
       mov       edx,[rsi+8]
       lea       rcx,[rbp+20]
       call      qword ptr [7FFF3A7C4B88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.UInt32, System.Private.CoreLib]](UInt32)
       mov       ecx,[rbp+30]
       cmp       ecx,[rbp+40]
       ja        short M01_L17
       mov       rdx,[rbp+38]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp+40]
       sub       eax,ecx
       cmp       eax,1
       jb        short M01_L15
       mov       rcx,2C790360C54
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp+30]
       inc       ecx
       mov       [rbp+30],ecx
       jmp       short M01_L16
M01_L15:
       lea       rcx,[rbp+20]
       mov       rdx,2C790360C48
       call      qword ptr [7FFF3A4758F0]
M01_L16:
       mov       edx,[rsi+0C]
       lea       rcx,[rbp+20]
       call      qword ptr [7FFF3A7C4B88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.UInt32, System.Private.CoreLib]](UInt32)
       mov       ebx,[rbp+30]
       cmp       ebx,[rbp+40]
       jbe       short M01_L18
M01_L17:
       call      qword ptr [7FFF3A4EE9A0]
       int       3
M01_L18:
       mov       rcx,[rbp+38]
       mov       edx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp+40]
       sub       edx,ebx
       cmp       edx,1
       jb        short M01_L19
       mov       rdx,2C790360C54
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       ecx,[rbp+30]
       inc       ecx
       mov       [rbp+30],ecx
       jmp       short M01_L20
M01_L19:
       lea       rcx,[rbp+20]
       mov       rdx,2C790360C48
       call      qword ptr [7FFF3A4758F0]
M01_L20:
       mov       edx,[rsi+10]
       lea       rcx,[rbp+20]
       call      qword ptr [7FFF3A7C4B88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.UInt32, System.Private.CoreLib]](UInt32)
       lea       rcx,[rbp+20]
       call      qword ptr [7FFF3A475740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rbx,rax
M01_L21:
       mov       rcx,286FE400B00
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L01
; Total bytes of code 1036
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.ProcessArchitecture()
       sub       rsp,28
       mov       dword ptr [rsp+20],1
       mov       rcx,[rcx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FFF3AAFECB8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Runtime.InteropServices.Architecture, System.Private.CoreLib]](System.Runtime.InteropServices.Architecture ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Runtime.InteropServices.Architecture, System.Private.CoreLib]](System.Runtime.InteropServices.Architecture ByRef)
       ret
; Total bytes of code 1
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.ProcessId()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       call      qword ptr [7FFF3A3F67F0]; System.Environment.get_ProcessId()
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 27
```
```assembly
; System.Environment.get_ProcessId()
       sub       rsp,28
       mov       eax,[7FFF3A285B78]
       test      eax,eax
       je        short M01_L01
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FFF3A3F6A78]; System.Environment.GetProcessId()
       mov       [7FFF3A285B78],eax
       jmp       short M01_L00
; Total bytes of code 33
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.ProcessName()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFF3AB26058]; System.Diagnostics.Process.GetCurrentProcess()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF3AB26628]; System.Diagnostics.Process.get_ProcessName()
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 67
```
```assembly
; System.Diagnostics.Process.GetCurrentProcess()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF3A3F67F0]; System.Environment.get_ProcessId()
       mov       ebx,eax
       mov       rcx,offset MT_System.Diagnostics.Process
       call      CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.GC._SuppressFinalize(System.Object)
       xor       eax,eax
       mov       [rsi+28],rax
       mov       rax,1F64B310C48
       mov       [rsi+20],rax
       mov       byte ptr [rsi+0E6],0
       mov       [rsi+0D0],ebx
       mov       byte ptr [rsi+0E4],1
       xor       eax,eax
       mov       [rsi+0DC],eax
       mov       [rsi+0E0],eax
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 104
```
```assembly
; System.Diagnostics.Process.get_ProcessName()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rbx,rcx
       cmp       qword ptr [rbx+0A0],0
       jne       near ptr M02_L07
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M02_L00
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       near ptr M02_L16
M02_L00:
       mov       rcx,rbx
       mov       edx,5
       call      qword ptr [7FFF3AB25F98]; System.Diagnostics.Process.EnsureState(State)
       mov       esi,[rbx+0D0]
       mov       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M02_L17
       mov       ebp,[rdi+8]
       test      ebp,ebp
       je        near ptr M02_L17
       movzx     eax,word ptr [rdi+0C]
       cmp       eax,5C
       je        short M02_L01
       xor       eax,eax
       jmp       short M02_L02
M02_L01:
       mov       eax,2
M02_L02:
       cmp       ebp,eax
       jb        near ptr M02_L18
       mov       ecx,eax
       lea       r14,[rdi+rcx*2+0C]
       sub       ebp,eax
       cmp       ebp,1
       jne       near ptr M02_L08
       cmp       word ptr [r14],2E
       jne       near ptr M02_L08
M02_L03:
       mov       ecx,esi
       call      qword ptr [7FFF3AB26DD8]; Interop+Kernel32.GetProcessName(UInt32)
       mov       r15,rax
       test      r15,r15
       je        near ptr M02_L14
       lea       rsi,[r15+0C]
       mov       edi,[r15+8]
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,edi
       call      qword ptr [7FFF3A57F258]; System.SpanHelpers.LastIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       inc       eax
       cmp       eax,edi
       ja        near ptr M02_L19
       mov       ecx,eax
       lea       rsi,[rsi+rcx*2]
       sub       edi,eax
       mov       rdx,1F64B32ABB4
       cmp       edi,4
       jl        short M02_L04
       mov       ecx,edi
       sub       ecx,4
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2]
       mov       r8d,4
       call      qword ptr [7FFF3AA7E3D0]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
       test      eax,eax
       je        short M02_L04
       lea       r8d,[rdi-4]
       cmp       r8d,edi
       ja        near ptr M02_L19
       mov       edi,r8d
M02_L04:
       mov       [rsp+48],rsi
       mov       [rsp+50],edi
       mov       rcx,[rsp+48]
       mov       r8d,[rsp+50]
       lea       rdx,[r15+0C]
       mov       eax,[r15+8]
       cmp       r8d,eax
       jne       short M02_L05
       mov       r8d,eax
       add       r8,r8
       call      qword ptr [7FFF3A3F5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M02_L20
M02_L05:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFF3A3FC210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
M02_L06:
       lea       rcx,[rbx+0A0]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+0A0],0
       je        near ptr M02_L15
M02_L07:
       mov       rax,[rbx+0A0]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L08:
       call      qword ptr [7FFF3AB26DA8]
       test      rax,rax
       jne       short M02_L09
       xor       ecx,ecx
       xor       edx,edx
       jmp       short M02_L10
M02_L09:
       lea       rcx,[rax+0C]
       mov       edx,[rax+8]
M02_L10:
       mov       [rsp+38],r14
       mov       [rsp+40],ebp
       mov       [rsp+28],rcx
       mov       [rsp+30],edx
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       mov       r8d,5
       call      qword ptr [7FFF3A6D73A8]; System.MemoryExtensions.Equals(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.StringComparison)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       test      ecx,ecx
       je        near ptr M02_L03
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FFF3AB6CC30]
       xor       ecx,ecx
       jmp       short M02_L13
M02_L11:
       mov       edx,ecx
       mov       rdx,[rax+rdx*8+10]
       cmp       [rdx+64],esi
       jne       short M02_L12
       mov       rax,[rdx+10]
       jmp       near ptr M02_L06
M02_L12:
       inc       ecx
M02_L13:
       cmp       [rax+8],ecx
       jg        short M02_L11
M02_L14:
       xor       eax,eax
       jmp       near ptr M02_L06
M02_L15:
       mov       rcx,rbx
       mov       edx,8
       call      qword ptr [7FFF3AB25F98]; System.Diagnostics.Process.EnsureState(State)
M02_L16:
       mov       rcx,[rbx+28]
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+0A0]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L07
M02_L17:
       mov       ecx,0D0E
       mov       rdx,7FFF3AAFFAA8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF3A34F810]
       int       3
M02_L18:
       mov       ecx,21
       call      qword ptr [7FFF3A4FED00]
       int       3
M02_L19:
       call      qword ptr [7FFF3A4FE9A0]
       int       3
M02_L20:
       mov       rax,r15
       jmp       near ptr M02_L06
; Total bytes of code 643
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.ProcessPath()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFF3A416808]; System.Environment.get_ProcessPath()
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 56
```
```assembly
; System.Environment.get_ProcessPath()
       sub       rsp,28
       mov       rax,2A1284000B0
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L01
M01_L00:
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       cmove     rax,rcx
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FFF3A416A90]; System.Environment.GetProcessPath()
       mov       rdx,rax
       mov       rcx,2A1284000B0
       mov       r8,2E1BA4A0008
       test      rdx,rdx
       cmove     rdx,r8
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rax,2A1284000B0
       mov       rax,[rax]
       jmp       short M01_L00
; Total bytes of code 96
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.ReferencedAssemblies()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,277DFC058C0
       mov       rax,[rcx]
       test      rax,rax
       je        short M00_L01
M00_L00:
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func`1[[System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,offset DotNetTips.Spargine.Core.App.ReferencedAssemblies()
       mov       r9,7FFF3A1FD3C0
       call      qword ptr [7FFF3A344258]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,277DFC058C0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M00_L00
; Total bytes of code 142
```
```assembly
; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       push      rdi
       push      rsi
       push      rbx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,r9
       lea       rcx,[rbx+8]
       mov       rdx,rbx
       call      qword ptr [7FFF99CD2D30]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```
**Method was not JITted yet.**
DotNetTips.Spargine.Core.App.ReferencedAssemblies()

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.StackTrace()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFF3A406898]; System.Environment.get_StackTrace()
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 56
```
```assembly
; System.Environment.get_StackTrace()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rcx,offset MT_System.Diagnostics.StackTrace
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF3AAFE2E0]; System.Diagnostics.StackTrace..ctor(Boolean)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       edx,100
       mov       r8d,7FFFFFFF
       call      qword ptr [7FFF3A5BC0F0]; System.Text.StringBuilder..ctor(Int32, Int32)
       mov       rcx,rbx
       mov       r8,rsi
       xor       edx,edx
       call      qword ptr [7FFF3AAFE430]; System.Diagnostics.StackTrace.ToString(TraceFormat, System.Text.StringBuilder)
       mov       rcx,rsi
       call      qword ptr [7FFF3A5AB060]; System.Text.StringBuilder.ToString()
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 107
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.WorkingSet()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       call      qword ptr [7FFF3A3E6AF0]; System.Environment.get_WorkingSet()
       mov       rcx,[rbx+18]
       mov       [rcx+18],rax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 28
```
```assembly
; System.Environment.get_WorkingSet()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       vzeroupper
       lea       rbp,[rsp+0F0]
       lea       rcx,[rbp-0C0]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rax,rsp
       mov       [rbp-0A0],rax
       mov       rax,rbp
       mov       [rbp-90],rax
       vxorps    ymm1,ymm1,ymm1
       vmovdqu   ymmword ptr [rbp-80],ymm1
       vmovdqu   ymmword ptr [rbp-60],ymm1
       vmovdqu   xmmword ptr [rbp-48],xmm1
       mov       dword ptr [rbp-80],48
       mov       rax,offset MD_Interop+Kernel32.GetCurrentProcess()
       mov       [rbp-0B0],rax
       lea       rax,[M01_L00]
       mov       [rbp-98],rax
       lea       rax,[rbp-0C0]
       mov       [rbx+10],rax
       mov       byte ptr [rbx+0C],0
       mov       rax,7FF8199E4BC0
       call      rax
M01_L00:
       mov       byte ptr [rbx+0C],1
       cmp       dword ptr [7FFF9A1F1FDC],0
       je        short M01_L01
       call      qword ptr [7FFF9A1E2398]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rcx,[rbp-0B8]
       mov       [rbx+10],rcx
       mov       rcx,rax
       mov       r8d,[rbp-80]
       lea       rdx,[rbp-80]
       mov       rax,offset MD_Interop+Kernel32.<GetProcessMemoryInfo>g____PInvoke|149_0(IntPtr, PROCESS_MEMORY_COUNTERS*, UInt32)
       mov       [rbp-0B0],rax
       lea       rax,[M01_L02]
       mov       [rbp-98],rax
       lea       rax,[rbp-0C0]
       mov       [rbx+10],rax
       mov       byte ptr [rbx+0C],0
       mov       rax,7FF8199FD060
       call      rax
M01_L02:
       mov       byte ptr [rbx+0C],1
       cmp       dword ptr [7FFF9A1F1FDC],0
       je        short M01_L03
       call      qword ptr [7FFF9A1E2398]; CORINFO_HELP_STOP_FOR_GC
M01_L03:
       mov       rcx,[rbp-0B8]
       mov       [rbx+10],rcx
       xor       ecx,ecx
       test      eax,eax
       mov       rax,rcx
       cmovne    rax,[rbp-70]
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 313
```

