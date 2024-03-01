## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumExtensionsBenchmark.GetDescription01()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_System.StringComparison
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[rbx+118]
       mov       [rax+8],ecx
       mov       rcx,rax
       call      qword ptr [7FFE387BF6A8]; DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387BF6F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 68
```
```assembly
; DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE384C2150],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rdx,2A7697981E0
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Enum, System.Private.CoreLib]](System.Enum, System.Enum, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2A769790008
       call      qword ptr [7FFE38547C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      System.Object.GetType()
       mov       [rbp-28],rax
       mov       rcx,[rbp+10]
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-30],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFE37F857A0]; System.Type.GetField(System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       mov       rcx,offset MT_System.Runtime.Serialization.EnumMemberAttribute
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       [rbp-40],rax
       mov       rcx,[rbp-8]
       mov       [rbp-48],rcx
       mov       rcx,[rbp-40]
       call      qword ptr [7FFE37F84ED0]; System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)
       mov       [rbp-50],rax
       mov       rcx,[rbp-48]
       mov       rdx,[rbp-50]
       xor       r8d,r8d
       mov       rax,[rbp-48]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       [rbp-58],rax
       mov       rdx,[rbp-58]
       mov       rcx,offset MT_System.Runtime.Serialization.EnumMemberAttribute[]
       call      qword ptr [7FFE38034390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       cmp       dword ptr [rcx+8],0
       jne       short M01_L02
       mov       rcx,[rbp+10]
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp-60],rcx
       jmp       short M01_L04
M01_L02:
       mov       rcx,[rbp-10]
       xor       eax,eax
       cmp       eax,[rcx+8]
       jb        short M01_L03
       call      CORINFO_HELP_RNGCHKFAIL
M01_L03:
       mov       edx,eax
       lea       rcx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387BF738]
       mov       [rbp-60],rax
M01_L04:
       mov       rax,[rbp-60]
       mov       [rbp-18],rax
       nop
       mov       rax,[rbp-18]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 391
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
       mov       rdx,7FFE387D76D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387BF798]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumExtensionsBenchmark.GetItems01()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_System.StringComparison
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[rbx+118]
       mov       [rax+8],ecx
       mov       rcx,rax
       call      qword ptr [7FFE387E6430]; DotNetTips.Spargine.Extensions.EnumExtensions.GetItems(System.Enum)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.ValueTuple`2<System.String,Int32>>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE387E6460]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 68
```
```assembly
; DotNetTips.Spargine.Extensions.EnumExtensions.GetItems(System.Enum)
       push      rbp
       sub       rsp,0C0
       vzeroupper
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE384D2150],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       call      qword ptr [7FFE387E6490]; System.Collections.Generic.List`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-30]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      System.Object.GetType()
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE37F94900]; System.Enum.GetNames(System.Type)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       jmp       near ptr M01_L04
M01_L02:
       mov       rcx,[rbp-10]
       mov       eax,[rbp-14]
       cmp       eax,[rcx+8]
       jb        short M01_L03
       call      CORINFO_HELP_RNGCHKFAIL
M01_L03:
       mov       edx,eax
       lea       rcx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       [rbp-20],rcx
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-48],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      System.Object.GetType()
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       rdx,[rbp-20]
       call      qword ptr [7FFE37F949D8]; System.Enum.Parse(System.Type, System.String)
       mov       [rbp-60],rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rdx,[rbp-60]
       mov       rcx,offset MT_System.Int32
       call      qword ptr [7FFE38044408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       mov       r9d,[rax]
       mov       [rbp-7C],r9d
       mov       r9d,[rbp-7C]
       lea       rcx,[rbp-70]
       mov       r8,[rbp-50]
       mov       rdx,offset MT_System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      qword ptr [7FFE386A4000]; System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]..ctor(System.__Canon, Int32)
       mov       rcx,[rbp-48]
       mov       [rbp-98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-70]
       vmovdqu   xmmword ptr [rbp-90],xmm0
       mov       rcx,[rbp-98]
       lea       rdx,[rbp-90]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387D7838]; System.Collections.Generic.List`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]].Add(System.ValueTuple`2<System.__Canon,Int32>)
       nop
       nop
       mov       ecx,[rbp-14]
       inc       ecx
       mov       [rbp-14],ecx
M01_L04:
       mov       ecx,[rbp-14]
       mov       rax,[rbp-10]
       cmp       ecx,[rax+8]
       jl        near ptr M01_L02
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387E6670]; System.Collections.Generic.List`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]].AsReadOnly()
       mov       [rbp-78],rax
       mov       rax,[rbp-78]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,0C0
       pop       rbp
       ret
; Total bytes of code 425
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
       cmp       dword ptr [7FFE3838F438],0
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
       mov       rdx,7FFE387F1568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE387ED5A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

