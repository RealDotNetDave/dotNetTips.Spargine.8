## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.As()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+130]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.As[[DotNetTips.Spargine.Tester.Models.RefTypes.IPerson`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Object)
       call      qword ptr [7FF8154B4828]; DotNetTips.Spargine.Extensions.ObjectExtensions.As[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.IPerson`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.IPerson`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF8154B4858]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.As[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F85110],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rdx,1A409272730
       mov       [rsp+20],rdx
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1A409270008
       call      qword ptr [7FF814FD7ED0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx]
       mov       rdx,[rbp-18]
       call      qword ptr [7FF814AF4390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 124
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
       cmp       dword ptr [7FF814E3F438],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E84528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF81547A428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154B4888]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePersonArray()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+138]
       test      rsi,rsi
       je        short M00_L01
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FF814AC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       short M00_L02
       mov       rdx,rsi
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF8154748B8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](System.Object)
       call      qword ptr [7FF815474858]; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[])
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF815474888]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF814D24F30]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FF814980C50
       call      qword ptr [r11]
       jmp       short M00_L00
; Total bytes of code 141
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L01
       mov       r8,[rdx]
       movzx     r10d,word ptr [r8+0E]
       test      r10,r10
       je        short M01_L04
       mov       r9,[r8+38]
       cmp       r10,4
       jl        short M01_L03
M01_L00:
       cmp       [r9],rcx
       jne       short M01_L02
M01_L01:
       mov       rax,rdx
       ret
M01_L02:
       cmp       [r9+8],rcx
       je        short M01_L01
       cmp       [r9+10],rcx
       je        short M01_L01
       cmp       [r9+18],rcx
       je        short M01_L01
       add       r9,20
       add       r10,0FFFFFFFFFFFFFFFC
       cmp       r10,4
       jge       short M01_L00
       test      r10,r10
       je        short M01_L04
M01_L03:
       cmp       [r9],rcx
       je        short M01_L01
       add       r9,8
       dec       r10
       test      r10,r10
       jg        short M01_L03
M01_L04:
       test      dword ptr [r8],406C0000
       jne       short M01_L05
       xor       edx,edx
       jmp       short M01_L01
M01_L05:
       jmp       qword ptr [7FF814AC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 110
```
```assembly
; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+58],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L00
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rbx
       mov       rdx,7FF815534B58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rsi
       call      qword ptr [7FF814AC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L08
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbx
       mov       rdx,7FF815534D58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        near ptr M02_L15
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M02_L04
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rbx
       mov       rdx,7FF815534D70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],50
       jle       short M02_L06
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       rdx,7FF815534E80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,rsi
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L08:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L09
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rbx
       mov       rdx,7FF815534D48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L10:
       lea       rcx,[rsp+28]
       call      qword ptr [7FF81551D7B8]
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L11
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rbx
       mov       rdx,7FF815534D48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L12:
       lea       rcx,[rsp+28]
       mov       r8,rsi
       call      qword ptr [7FF81551D830]
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L13
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rbx
       mov       rdx,7FF815534D48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L14:
       lea       rcx,[rsp+28]
       call      qword ptr [7FF81551D8C0]
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L15:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],58
       jle       short M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M02_L16
       jmp       short M02_L17
M02_L16:
       mov       rcx,rbx
       mov       rdx,7FF815534EB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L17:
       call      qword ptr [7FF814F24750]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 521
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
       cmp       dword ptr [7FF814F54F00],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rdx,1591C252730
       mov       [rsp+20],rdx
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1591C250008
       call      qword ptr [7FF814FAC9F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FF814F75308]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-28],rcx
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF81542DF48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M03_L02:
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      qword ptr [7FF8154748E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rbp-30],rax
       mov       rax,[rbp-30]
       add       rsp,58
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 202
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
       cmp       dword ptr [7FF814E1F390],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF815492660
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF815476160]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePersonCollection()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+138]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Object)
       call      qword ptr [7FF8154940A8]; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF8154940D8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 58
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
       cmp       dword ptr [7FF814F75110],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rdx,1F936982730
       mov       [rsp+20],rdx
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1F936980008
       call      qword ptr [7FF814FC7ED0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FF814F94A38]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       [rbp-20],rax
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
       mov       rdx,7FF81545ACC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M01_L02:
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      qword ptr [7FF815494108]; DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rbp-30],rax
       mov       rax,[rbp-30]
       add       rsp,58
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 202
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
       cmp       dword ptr [7FF814E3F3E0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E74528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF81545F138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF815495920]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePerson()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+130]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Object)
       call      qword ptr [7FF815404D08]; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815404D38]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 58
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
       cmp       dword ptr [7FF814F44F00],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rdx,16B94022730
       mov       [rsp+20],rdx
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
       xor       r8d,r8d
       mov       r9,16B94020008
       call      qword ptr [7FF814F9C9F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FF814F65308]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       [rbp-20],rax
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
       mov       rdx,7FF8153DEEB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M01_L02:
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      qword ptr [7FF815404D68]; DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rbp-30],rax
       mov       rax,[rbp-30]
       add       rsp,58
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 202
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
       cmp       dword ptr [7FF814E0F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF8153DF810
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF815404FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePersonRecord()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+140]
       cmp       [rcx],ecx
       call      qword ptr [7FF814F75188]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.<Clone>$()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF81545FDE0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.<Clone>$()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814E1FE88],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+10]
       call      qword ptr [7FF814F751A0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord..ctor(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       rax,[rbp-10]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 79
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
       cmp       dword ptr [7FF814E1F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF81542DEE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81545FE10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ComputeSha256Hash01()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       call      qword ptr [7FF814F75218]; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF81535D920]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      rbp
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
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
       mov       [rbp-0A8],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814F54F00],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rdx,1F4C4712730
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1F4C4710008
       call      qword ptr [7FF814FAC9F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rax,[rbp-28]
       mov       [rbp+10],rax
       call      qword ptr [7FF814ACC720]; System.Text.Encoding.get_UTF8()
       mov       [rbp-30],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814F75308]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       [rbp-38],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-38]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+10]
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      qword ptr [7FF81535DC20]; System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-8],rcx
       mov       rcx,1B43280BAB0
       mov       rcx,[rcx]
       mov       [rbp-90],rcx
       mov       rcx,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-50],rax
       mov       rax,[rbp-50]
       mov       [rbp-10],rax
       nop
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L05
M01_L02:
       nop
       mov       rax,[rbp-8]
       mov       ecx,[rbp-14]
       cmp       ecx,[rax+8]
       jb        short M01_L03
       call      CORINFO_HELP_RNGCHKFAIL
M01_L03:
       mov       edx,ecx
       lea       rax,[rax+rdx+10]
       mov       [rbp-58],rax
       mov       rax,[rbp-10]
       mov       [rbp-60],rax
       mov       rax,1F4C47241E8
       mov       [rbp-68],rax
       call      qword ptr [7FF814CA4270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-70],rax
       mov       rcx,[rbp-58]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       call      qword ptr [7FF814A5D398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-78],rax
       mov       rcx,[rbp-60]
       mov       rdx,[rbp-78]
       cmp       [rcx],ecx
       call      qword ptr [7FF814D9C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-80],rax
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L04
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       mov       [rbp-14],ecx
M01_L05:
       mov       eax,[rbp-14]
       mov       rcx,[rbp-8]
       cmp       eax,[rcx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       near ptr M01_L02
       mov       rcx,[rbp-10]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-88],rax
       mov       rcx,[rbp-88]
       mov       [rbp-20],rcx
       nop
       mov       rcx,rsp
       call      M01_L06
       nop
       mov       rax,[rbp-20]
       add       rsp,0D0
       pop       rbp
       ret
M01_L06:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0D0]
       nop
       mov       rcx,1B43280BAB0
       mov       rcx,[rcx]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       mov       rdx,[rbp-10]
       mov       rax,[rbp-98]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 573
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
       cmp       dword ptr [7FF814E1F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF8153720C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81535DE18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ComputeSha256Hash02()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+140]
       call      qword ptr [7FF814F74948]; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815474990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      rbp
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
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
       mov       [rbp-0A8],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814F55110],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rdx,2A1C42F2730
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2A1C42F0008
       call      qword ptr [7FF814FA7ED0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rax,[rbp-28]
       mov       [rbp+10],rax
       call      qword ptr [7FF814ACC720]; System.Text.Encoding.get_UTF8()
       mov       [rbp-30],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814F74A38]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       [rbp-38],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-38]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+10]
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      qword ptr [7FF815474C90]; System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-8],rcx
       mov       rcx,2613240BAB0
       mov       rcx,[rcx]
       mov       [rbp-90],rcx
       mov       rcx,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-50],rax
       mov       rax,[rbp-50]
       mov       [rbp-10],rax
       nop
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L05
M01_L02:
       nop
       mov       rax,[rbp-8]
       mov       ecx,[rbp-14]
       cmp       ecx,[rax+8]
       jb        short M01_L03
       call      CORINFO_HELP_RNGCHKFAIL
M01_L03:
       mov       edx,ecx
       lea       rax,[rax+rdx+10]
       mov       [rbp-58],rax
       mov       rax,[rbp-10]
       mov       [rbp-60],rax
       mov       rax,2A1C4304210
       mov       [rbp-68],rax
       call      qword ptr [7FF814CA4270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-70],rax
       mov       rcx,[rbp-58]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       call      qword ptr [7FF814A5D398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-78],rax
       mov       rcx,[rbp-60]
       mov       rdx,[rbp-78]
       cmp       [rcx],ecx
       call      qword ptr [7FF814D9C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-80],rax
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L04
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       mov       [rbp-14],ecx
M01_L05:
       mov       eax,[rbp-14]
       mov       rcx,[rbp-8]
       cmp       eax,[rcx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       near ptr M01_L02
       mov       rcx,[rbp-10]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-88],rax
       mov       rcx,[rbp-88]
       mov       [rbp-20],rcx
       nop
       mov       rcx,rsp
       call      M01_L06
       nop
       mov       rax,[rbp-20]
       add       rsp,0D0
       pop       rbp
       ret
M01_L06:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0D0]
       nop
       mov       rcx,2613240BAB0
       mov       rcx,[rcx]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       mov       rdx,[rbp-10]
       mov       rax,[rbp-98]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 573
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
       cmp       dword ptr [7FF814E1F3E0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF8154910C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF815476C10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.DisposeFields()
       push      rbx
       sub       rsp,20
       mov       rcx,offset MT_System.Data.DataTable
       call      CORINFO_HELP_NEWFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8154A4990]; System.Data.DataTable..ctor()
       mov       rcx,17801484210
       mov       [rbx+70],rcx
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF814FA5230]; DotNetTips.Spargine.Extensions.ObjectExtensions.DisposeFields(System.IDisposable)
; Total bytes of code 60
```
```assembly
; System.Data.DataTable..ctor()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       lea       rcx,[rbx+70]
       mov       rsi,17801470008
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+80]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+1C4],1
       mov       dword ptr [rbx+1B0],19
       mov       rcx,178014842B0
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1D8],xmm0
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1E8],xmm0
       mov       rcx,17801484388
       mov       [rbx+0D8],rcx
       mov       byte ptr [rbx+1CC],1
       mov       rcx,178014843A0
       mov       [rbx+110],rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataView, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,178014843B8
       mov       [rax+8],rcx
       lea       rcx,[rbx+180]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataViewListener, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,178014843D0
       mov       [rax+8],rcx
       lea       rcx,[rbx+188]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.ReaderWriterLockSlim
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+40],0FFFFFFFF
       mov       dword ptr [rax+44],0FFFFFFFF
       mov       byte ptr [rax+4D],1
       mov       rcx,7FF814A35C48
       mov       edx,1
       lock xadd [rcx],rdx
       inc       rdx
       mov       [rax+28],rdx
       lea       rcx,[rbx+198]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+1B8],0FFFFFFFF
       mov       rcx,7FF81549D7F8
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rbx+1C0],eax
       mov       rcx,rbx
       call      qword ptr [7FF814D7C2E8]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,1376F40F210
       mov       rcx,[rcx]
       mov       rsi,rcx
       mov       edi,[rbx+1C0]
       cmp       byte ptr [rcx+9D],0
       je        short M01_L00
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       [rsp+38],rax
       lea       r8,[rsp+38]
       mov       [rsp+28],r8
       mov       dword ptr [rsp+30],1
       lea       r8,[rsp+28]
       xor       ecx,ecx
       mov       rdx,17801484230
       call      qword ptr [7FF814AF6C88]
       mov       r8,rax
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FF814BA76D8]
M01_L00:
       mov       qword ptr [rbx+1A0],1
       mov       rcx,offset MT_System.Data.RecordManager
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8154ACF00]; System.Data.RecordManager..ctor(System.Data.DataTable)
       lea       rcx,[rbx+50]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF814CD4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       lea       rcx,[rbx+90]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataColumnCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8154A7240]; System.Data.DataColumnCollection..ctor(System.Data.DataTable)
       lea       rcx,[rbx+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.ConstraintCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Collections.ArrayList
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,1780147C760
       mov       [rax+8],rcx
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+28],1
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+38]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataRowCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Data.DataRowCollection+DataRowTree
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+30],2
       mov       rcx,rdi
       call      qword ptr [7FF8154AC048]; System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].InitTree()
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.Index, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,17801484460
       mov       [rax+8],rcx
       lea       rcx,[rbx+58]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataRowBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+10],0FFFFFFFF
       lea       rcx,[rbx+178]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 876
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.DisposeFields(System.IDisposable)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-0B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814F84F00],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L02
       nop
       nop
       jmp       near ptr M02_L11
M02_L02:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      System.Object.GetType()
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       call      qword ptr [7FF8154F4000]; System.Reflection.RuntimeReflectionExtensions.GetRuntimeFields(System.Type)
       mov       [rbp-58],rax
       mov       rcx,7FF814F853E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1376F40BBC8
       mov       rcx,[rcx]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-58]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       jne       near ptr M02_L03
       mov       rcx,offset MT_System.Func`2[[System.Reflection.FieldInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0B0],rax
       mov       rcx,7FF814F853E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1376F40BBC0
       mov       rdx,[rdx]
       mov       [rbp-0B8],rdx
       mov       rdx,[rbp-0B8]
       mov       rcx,[rbp-0B0]
       mov       r8,7FF8154F0138
       call      qword ptr [7FF814AF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF814F853E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-0B0]
       mov       rcx,1376F40BBC8
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-0B0]
       mov       [rbp-70],r8
M02_L03:
       mov       r8,[rbp-70]
       mov       rdx,[rbp-68]
       mov       rcx,offset MD_System.Linq.Enumerable.Where[[System.Reflection.FieldInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.FieldInfo>, System.Func`2<System.Reflection.FieldInfo,Boolean>)
       call      qword ptr [7FF814F17138]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-78],rax
       mov       rdx,[rbp-78]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList[[System.Reflection.FieldInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.FieldInfo>)
       call      qword ptr [7FF8151E4150]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-80],rax
       mov       rdx,[rbp-80]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.DoesNotHaveItems[[System.Reflection.FieldInfo, System.Private.CoreLib]](System.Collections.Generic.List`1<System.Reflection.FieldInfo>)
       call      qword ptr [7FF8154F41C8]; DotNetTips.Spargine.Extensions.ListExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       [rbp-84],eax
       mov       edx,[rbp-84]
       movzx     edx,dl
       mov       [rbp-10],edx
       cmp       dword ptr [rbp-10],0
       je        short M02_L04
       nop
       nop
       jmp       near ptr M02_L11
M02_L04:
       xor       edx,edx
       mov       [rbp-14],edx
       nop
       jmp       near ptr M02_L10
M02_L05:
       nop
       mov       rcx,[rbp-8]
       mov       edx,[rbp-14]
       cmp       [rcx],ecx
       call      qword ptr [7FF814C61B98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Item(Int32)
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       rdx,[rbp+10]
       mov       rax,[rbp-0A0]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       [rbp-0A8],rax
       mov       rdx,[rbp-0A8]
       mov       [rbp-20],rdx
       xor       edx,edx
       cmp       qword ptr [rbp-20],0
       setne     dl
       mov       [rbp-24],edx
       cmp       dword ptr [rbp-24],0
       je        short M02_L08
       nop
       mov       rdx,[rbp-20]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF814AF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       [rbp-30],rax
       xor       ecx,ecx
       cmp       qword ptr [rbp-30],0
       setne     cl
       mov       [rbp-34],ecx
       cmp       dword ptr [rbp-34],0
       je        short M02_L06
       nop
       mov       rcx,[rbp-30]
       call      qword ptr [7FF814FA5350]; DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable)
       nop
       nop
       nop
       jmp       short M02_L07
M02_L06:
       mov       rdx,[rbp-20]
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FF814AF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       [rbp-40],rax
       xor       ecx,ecx
       cmp       qword ptr [rbp-40],0
       setne     cl
       mov       [rbp-44],ecx
       cmp       dword ptr [rbp-44],0
       je        short M02_L07
       nop
       mov       rcx,[rbp-40]
       call      qword ptr [7FF814FA51B8]; DotNetTips.Spargine.Extensions.ObjectExtensions.DisposeCollection(System.Collections.IEnumerable)
       nop
       nop
M02_L07:
       nop
M02_L08:
       nop
       mov       eax,[rbp-14]
       add       eax,1
       jno       short M02_L09
       call      CORINFO_HELP_OVERFLOW
M02_L09:
       mov       [rbp-14],eax
M02_L10:
       mov       edx,[rbp-14]
       movsxd    rdx,edx
       mov       [rbp-90],rdx
       mov       rdx,[rbp-8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.Reflection.FieldInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.FieldInfo>)
       call      qword ptr [7FF8154F41F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-98],rax
       mov       rcx,[rbp-90]
       cmp       rcx,[rbp-98]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-48],ecx
       cmp       dword ptr [rbp-48],0
       jne       near ptr M02_L05
M02_L11:
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 787
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.HasProperty01()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       mov       rdx,22F70B04210
       call      qword ptr [7FF814F65260]; DotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF81543FFC0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F45110],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass9_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       call      qword ptr [7FF815464000]; DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass9_0..ctor()
       mov       rcx,[rbp-20]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-14],ecx
       cmp       dword ptr [rbp-14],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-18],ecx
       nop
       jmp       near ptr M01_L02
M01_L01:
       mov       rcx,[rbp-8]
       mov       [rbp-28],rcx
       mov       rcx,22F70AFDD08
       mov       [rsp+20],rcx
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,22F70AF0008
       call      qword ptr [7FF814F9C7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-28]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      System.Object.GetType()
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      qword ptr [7FF815464060]; System.Reflection.RuntimeReflectionExtensions.GetRuntimeProperties(System.Type)
       mov       [rbp-40],rax
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       rdx,[rbp-8]
       mov       r8,7FF815460018
       call      qword ptr [7FF814AB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r8,[rbp-48]
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_System.Linq.Enumerable.FirstOrDefault[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,Boolean>)
       call      qword ptr [7FF8153E4F30]; System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-50],rax
       mov       rax,[rbp-50]
       mov       [rbp-10],rax
       xor       eax,eax
       cmp       qword ptr [rbp-10],0
       setne     al
       mov       [rbp-18],eax
       nop
M01_L02:
       mov       eax,[rbp-18]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 363
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
       cmp       dword ptr [7FF814E0F460],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF815464180]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.HasProperty02()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+140]
       mov       rdx,253F21B4210
       call      qword ptr [7FF814F65260]; DotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815464840]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F45110],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass9_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       call      qword ptr [7FF815464858]; DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass9_0..ctor()
       mov       rcx,[rbp-20]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-14],ecx
       cmp       dword ptr [rbp-14],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-18],ecx
       nop
       jmp       near ptr M01_L02
M01_L01:
       mov       rcx,[rbp-8]
       mov       [rbp-28],rcx
       mov       rcx,253F21ADD08
       mov       [rsp+20],rcx
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,253F21A0008
       call      qword ptr [7FF814F9C7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-28]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      System.Object.GetType()
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8154648B8]; System.Reflection.RuntimeReflectionExtensions.GetRuntimeProperties(System.Type)
       mov       [rbp-40],rax
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       rdx,[rbp-8]
       mov       r8,7FF815460870
       call      qword ptr [7FF814AB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r8,[rbp-48]
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_System.Linq.Enumerable.FirstOrDefault[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,Boolean>)
       call      qword ptr [7FF8153F5698]; System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-50],rax
       mov       rax,[rbp-50]
       mov       [rbp-10],rax
       xor       eax,eax
       cmp       qword ptr [rbp-10],0
       setne     al
       mov       [rbp-18],eax
       nop
M01_L02:
       mov       eax,[rbp-18]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 363
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
       cmp       dword ptr [7FF814DFF6A0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154649D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNotNull01()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       call      qword ptr [7FF814F85290]; DotNetTips.Spargine.Extensions.ObjectExtensions.IsNotNull(System.Object)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF8154847C8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.IsNotNull(System.Object)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814F64F00],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       xor       eax,eax
       cmp       qword ptr [rbp+10],0
       setne     al
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
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
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154847E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNotNull02()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+140]
       call      qword ptr [7FF814F95290]; DotNetTips.Spargine.Extensions.ObjectExtensions.IsNotNull(System.Object)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815494840]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.IsNotNull(System.Object)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814F74F00],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       xor       eax,eax
       cmp       qword ptr [rbp+10],0
       setne     al
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
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
       call      qword ptr [7FF815494858]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNull01()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       call      qword ptr [7FF814F652A8]; DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815324828]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814F44F00],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       xor       eax,eax
       cmp       qword ptr [rbp+10],0
       sete      al
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
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
       call      qword ptr [7FF815324840]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNull02()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+140]
       call      qword ptr [7FF814FA52A8]; DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF8154A4840]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814F84F00],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       xor       eax,eax
       cmp       qword ptr [rbp+10],0
       sete      al
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 46
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
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154A4858]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.Duplicate01()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+140]
       cmp       [rcx],ecx
       call      qword ptr [7FF814F65188]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.<Clone>$()
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C792B64210
       cmp       [rcx],ecx
       call      qword ptr [7FF814F44AD0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Id(System.String)
       mov       rcx,rbx
       mov       r8,rsi
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF815464840]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.<Clone>$()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814E0FE88],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+10]
       call      qword ptr [7FF814F651A0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord..ctor(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       rax,[rbp-10]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Id(System.String)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814E0FE88],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rdx,[rbp+18]
       mov       r8d,4
       call      qword ptr [7FF814AB61D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M02_L01
       nop
       nop
       jmp       near ptr M02_L04
M02_L01:
       mov       rcx,[rbp+10]
       mov       [rbp-10],rcx
       mov       rcx,[rbp+18]
       mov       edx,1
       mov       r8d,32
       call      qword ptr [7FF814F66718]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32, Int32)
       mov       [rbp-14],eax
       mov       rcx,[rbp-10]
       mov       [rbp-20],rcx
       cmp       dword ptr [rbp-14],0
       je        short M02_L02
       mov       rcx,[rbp-20]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+18]
       mov       [rbp-48],rcx
       jmp       short M02_L03
M02_L02:
       mov       ecx,0AD5
       mov       rdx,7FF814E0FC00
       call      CORINFO_HELP_STRCNS
       mov       [rbp-28],rax
       call      qword ptr [7FF814F945D0]
       mov       [rbp-30],rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-28]
       mov       r8,[rbp-30]
       call      qword ptr [7FF814B6D470]
       mov       rcx,[rbp-38]
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rcx,[rbp-40]
       lea       rcx,[rcx+30]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
M02_L04:
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 280
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
       cmp       dword ptr [7FF814E0F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF81542A740
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF815464870]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PersonRecordToString01()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+140]
       cmp       [rcx],ecx
       call      qword ptr [7FF814F74AA8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815494678]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToString()
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814E3FE88],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       rcx,[rbp+10]
       mov       rdx,209B6BD0008
       mov       r8d,3A
       mov       r9,209B6BD8DF0
       call      qword ptr [7FF814F952D8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       mov       [rbp-10],rax
       mov       rax,[rbp-10]
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 102
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
       cmp       dword ptr [7FF814E3F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF8154B7788
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154D4B10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary01()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       mov       rdx,1C33F6A0008
       mov       r8d,1
       call      qword ptr [7FF814F652C0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.String,System.String>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815464840]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
M01_L00:
       push      rbp
       sub       rsp,2D0
       lea       rbp,[rsp+2D0]
       xor       eax,eax
       mov       [rbp-298],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-290],xmm4
       vmovdqa   xmmword ptr [rbp-280],xmm4
       mov       rax,0FFFFFFFFFFFFFD90
M01_L01:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L01
       mov       [rbp-2A8],rsp
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF814F44F00],0
       je        short M01_L02
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L02:
       nop
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       call      qword ptr [7FF814ABEB80]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdx,[rbp-0D0]
       mov       [rbp-8],rdx
       mov       rdx,1C33F6B4210
       mov       [rsp+20],rdx
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1C33F6A0008
       call      qword ptr [7FF814F9C9F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-0D8],rax
       mov       rdx,[rbp-0D8]
       mov       [rbp+18],rdx
       mov       rdx,1C33F6A2730
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1C33F6A0008
       call      qword ptr [7FF814F9C9F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-0E0],rax
       mov       rcx,[rbp-0E0]
       cmp       [rcx],ecx
       call      System.Object.GetType()
       mov       [rbp-0E8],rax
       mov       rax,[rbp-0E8]
       mov       [rbp-10],rax
       call      qword ptr [7FF815464A20]; DotNetTips.Spargine.Core.TypeHelper.get_BuiltInTypeNames()
       mov       [rbp-0F0],rax
       mov       rcx,[rbp-0F0]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF814B44608]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ContainsKey(System.__Canon)
       mov       [rbp-0F4],eax
       mov       ecx,[rbp-0F4]
       movzx     ecx,cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       je        short M01_L03
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-260],rcx
       mov       rcx,[rbp+18]
       mov       [rbp-268],rcx
       mov       rcx,[rbp+10]
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-270],rax
       mov       rcx,[rbp-260]
       mov       rdx,[rbp-268]
       mov       r8,[rbp-270]
       cmp       [rcx],ecx
       call      qword ptr [7FF814B445E0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon)
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-30],rcx
       nop
       jmp       near ptr M01_L22
M01_L03:
       mov       rcx,[rbp-10]
       call      qword ptr [7FF815464C30]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       mov       [rbp-0F8],eax
       mov       edx,[rbp-0F8]
       movzx     edx,dl
       mov       [rbp-34],edx
       cmp       dword ptr [rbp-34],0
       je        near ptr M01_L09
       nop
       xor       edx,edx
       mov       [rbp-38],edx
       nop
       mov       rdx,[rbp+10]
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FF814AB43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       [rbp-278],rax
       mov       rcx,[rbp-278]
       mov       r11,7FF814970950
       call      qword ptr [r11]
       mov       [rbp-1C0],rax
       mov       rcx,[rbp-1C0]
       mov       [rbp-40],rcx
       nop
       jmp       near ptr M01_L08
M01_L04:
       mov       rcx,[rbp-40]
       mov       r11,7FF814970960
       call      qword ptr [r11]
       mov       [rbp-1D0],rax
       mov       rax,[rbp-1D0]
       mov       [rbp-48],rax
       nop
       mov       eax,[rbp-38]
       mov       [rbp-1D4],eax
       mov       eax,[rbp-38]
       add       eax,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-38],eax
       mov       eax,[rbp-1D4]
       mov       [rbp-4C],eax
       call      qword ptr [7FF814C94180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp-1E0],rax
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-1E8],rax
       mov       r9,[rbp-1E8]
       mov       ecx,[rbp-4C]
       mov       [r9+8],ecx
       mov       r9,[rbp-1E8]
       mov       rcx,[rbp-1E0]
       mov       r8,[rbp+18]
       mov       rdx,1C33F6B4240
       call      qword ptr [7FF814AB6C40]; System.String.Format(System.IFormatProvider, System.String, System.Object, System.Object)
       mov       [rbp-1F0],rax
       mov       rcx,[rbp-1F0]
       mov       [rbp-58],rcx
       mov       rcx,[rbp-8]
       mov       [rbp-1F8],rcx
       mov       rcx,[rbp-48]
       mov       rdx,[rbp-58]
       mov       r8d,1
       call      qword ptr [7FF814F652C0]
       mov       [rbp-200],rax
       mov       r8,[rbp-200]
       mov       rdx,[rbp-1F8]
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF815464CC0]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-208],rax
       mov       rcx,7FF814F453E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,182AD80BBD0
       mov       rcx,[rcx]
       mov       [rbp-210],rcx
       mov       rcx,[rbp-208]
       mov       [rbp-218],rcx
       mov       rcx,[rbp-210]
       mov       [rbp-220],rcx
       cmp       qword ptr [rbp-210],0
       jne       near ptr M01_L06
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-258],rax
       mov       rcx,7FF814F453E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,182AD80BBC0
       mov       rdx,[rdx]
       mov       [rbp-280],rdx
       mov       rdx,[rbp-280]
       mov       rcx,[rbp-258]
       mov       r8,7FF815460D38
       call      qword ptr [7FF814AB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF814F453E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-258]
       mov       rcx,182AD80BBD0
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-258]
       mov       [rbp-220],rcx
M01_L06:
       mov       rcx,7FF814F453E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,182AD80BBD8
       mov       rcx,[rcx]
       mov       [rbp-228],rcx
       mov       rcx,[rbp-218]
       mov       [rbp-230],rcx
       mov       rcx,[rbp-220]
       mov       [rbp-238],rcx
       mov       rcx,[rbp-228]
       mov       [rbp-240],rcx
       cmp       qword ptr [rbp-228],0
       jne       near ptr M01_L07
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-250],rax
       mov       rcx,7FF814F453E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,182AD80BBC0
       mov       rdx,[rdx]
       mov       [rbp-288],rdx
       mov       rdx,[rbp-288]
       mov       rcx,[rbp-250]
       mov       r8,7FF815460D50
       call      qword ptr [7FF814AB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF814F453E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-250]
       mov       rcx,182AD80BBD8
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-250]
       mov       [rbp-240],r9
M01_L07:
       mov       r9,[rbp-240]
       mov       rdx,[rbp-230]
       mov       r8,[rbp-238]
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FF815464DF8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       [rbp-248],rax
       mov       rdx,[rbp-248]
       mov       [rbp-8],rdx
       nop
M01_L08:
       mov       rcx,[rbp-40]
       mov       r11,7FF814970958
       call      qword ptr [r11]
       mov       [rbp-1C4],eax
       cmp       dword ptr [rbp-1C4],0
       jne       near ptr M01_L04
       nop
       mov       rcx,rsp
       call      M01_L23
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-30],rcx
       nop
       jmp       near ptr M01_L22
M01_L09:
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF814A05B78]; System.Type.GetProperties()
       mov       [rbp-100],rax
       mov       rcx,[rbp-100]
       mov       [rbp-18],rcx
       mov       rcx,1C33F6A0008
       mov       [rbp-20],rcx
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF814AB69E8]; System.String.get_Length()
       mov       [rbp-104],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-104],0
       setg      cl
       mov       [rbp-64],ecx
       cmp       dword ptr [rbp-64],0
       je        short M01_L10
       nop
       lea       rcx,[rbp-90]
       xor       edx,edx
       mov       r8d,2
       call      qword ptr [7FF814C656B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-90]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF814C65830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       nop
       lea       rcx,[rbp-90]
       mov       edx,2E
       call      qword ptr [7FF815464E28]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       nop
       lea       rcx,[rbp-90]
       call      qword ptr [7FF814C65740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       [rbp-1B8],rax
       mov       rdx,[rbp-1B8]
       mov       [rbp-20],rdx
       nop
M01_L10:
       xor       edx,edx
       mov       [rbp-94],edx
       nop
       jmp       near ptr M01_L21
M01_L11:
       nop
       mov       rdx,[rbp-18]
       mov       ecx,[rbp-94]
       cmp       ecx,[rdx+8]
       jb        short M01_L12
       call      CORINFO_HELP_RNGCHKFAIL
M01_L12:
       mov       eax,ecx
       lea       rdx,[rdx+rax*8+10]
       mov       rdx,[rdx]
       mov       [rbp-0A0],rdx
       mov       rdx,[rbp-0A0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.TypeExtensions.GetAttribute[[System.Text.Json.Serialization.JsonIgnoreAttribute, System.Text.Json]](System.Reflection.PropertyInfo)
       call      qword ptr [7FF815464C90]; DotNetTips.Spargine.Extensions.TypeExtensions.GetAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.PropertyInfo)
       mov       [rbp-110],rax
       mov       rcx,[rbp-110]
       mov       [rbp-0A8],rcx
       xor       ecx,ecx
       cmp       qword ptr [rbp-0A8],0
       sete      cl
       mov       [rbp-0AC],ecx
       cmp       dword ptr [rbp-0AC],0
       je        near ptr M01_L18
       nop
       mov       rcx,[rbp-0A0]
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       mov       rax,[rbp-0A0]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+38]
       mov       [rbp-118],rax
       mov       rax,[rbp-118]
       mov       [rbp-0B8],rax
       mov       eax,[rbp+20]
       movzx     eax,al
       test      eax,eax
       je        short M01_L13
       xor       eax,eax
       cmp       qword ptr [rbp-0B8],0
       sete      al
       mov       [rbp-11C],eax
       jmp       short M01_L14
M01_L13:
       xor       eax,eax
       mov       [rbp-11C],eax
M01_L14:
       mov       eax,[rbp-11C]
       movzx     eax,al
       mov       [rbp-0C4],eax
       cmp       dword ptr [rbp-0C4],0
       je        short M01_L15
       nop
       nop
       jmp       near ptr M01_L19
M01_L15:
       call      qword ptr [7FF814C94180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp-128],rax
       mov       rcx,1C33F6B4268
       mov       [rbp-130],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-138],rcx
       mov       rcx,[rbp-0A0]
       mov       rax,[rbp-0A0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-140],rax
       mov       rcx,[rbp-128]
       mov       rdx,[rbp-130]
       mov       r8,[rbp-138]
       mov       r9,[rbp-140]
       call      qword ptr [7FF814AB6C40]; System.String.Format(System.IFormatProvider, System.String, System.Object, System.Object)
       mov       [rbp-148],rax
       mov       rcx,[rbp-148]
       mov       [rbp-0C0],rcx
       mov       rcx,[rbp-8]
       mov       [rbp-150],rcx
       mov       rcx,[rbp-0B8]
       mov       rdx,[rbp-0C0]
       mov       r8d,1
       call      qword ptr [7FF814F652C0]
       mov       [rbp-158],rax
       mov       r8,[rbp-158]
       mov       rdx,[rbp-150]
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF815464CC0]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-160],rax
       mov       rcx,7FF814F453E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,182AD80BBE0
       mov       rcx,[rcx]
       mov       [rbp-168],rcx
       mov       rcx,[rbp-160]
       mov       [rbp-170],rcx
       mov       rcx,[rbp-168]
       mov       [rbp-178],rcx
       cmp       qword ptr [rbp-168],0
       jne       near ptr M01_L16
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-1B0],rax
       mov       rcx,7FF814F453E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,182AD80BBC0
       mov       rdx,[rdx]
       mov       [rbp-290],rdx
       mov       rdx,[rbp-290]
       mov       rcx,[rbp-1B0]
       mov       r8,7FF815460D68
       call      qword ptr [7FF814AB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF814F453E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-1B0]
       mov       rcx,182AD80BBE0
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-1B0]
       mov       [rbp-178],rcx
M01_L16:
       mov       rcx,7FF814F453E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,182AD80BBE8
       mov       rcx,[rcx]
       mov       [rbp-180],rcx
       mov       rcx,[rbp-170]
       mov       [rbp-188],rcx
       mov       rcx,[rbp-178]
       mov       [rbp-190],rcx
       mov       rcx,[rbp-180]
       mov       [rbp-198],rcx
       cmp       qword ptr [rbp-180],0
       jne       near ptr M01_L17
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-1A8],rax
       mov       rcx,7FF814F453E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,182AD80BBC0
       mov       rdx,[rdx]
       mov       [rbp-298],rdx
       mov       rdx,[rbp-298]
       mov       rcx,[rbp-1A8]
       mov       r8,7FF815460D80
       call      qword ptr [7FF814AB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF814F453E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-1A8]
       mov       rcx,182AD80BBE8
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-1A8]
       mov       [rbp-198],r9
M01_L17:
       mov       r9,[rbp-198]
       mov       rdx,[rbp-188]
       mov       r8,[rbp-190]
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FF815464DF8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       [rbp-1A0],rax
       mov       rax,[rbp-1A0]
       mov       [rbp-8],rax
       nop
M01_L18:
       nop
M01_L19:
       mov       eax,[rbp-94]
       add       eax,1
       jno       short M01_L20
       call      CORINFO_HELP_OVERFLOW
M01_L20:
       mov       [rbp-94],eax
M01_L21:
       mov       edx,[rbp-94]
       mov       rcx,[rbp-18]
       cmp       edx,[rcx+8]
       setl      dl
       movzx     edx,dl
       mov       [rbp-0C8],edx
       cmp       dword ptr [rbp-0C8],0
       jne       near ptr M01_L11
       mov       rax,[rbp-8]
       mov       [rbp-30],rax
       nop
M01_L22:
       mov       rax,[rbp-30]
       add       rsp,2D0
       pop       rbp
       ret
M01_L23:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+2D0]
       mov       rdx,[rbp-40]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF814AB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       [rbp-60],rax
       cmp       qword ptr [rbp-60],0
       je        short M01_L24
       mov       rcx,[rbp-60]
       mov       r11,7FF814970968
       call      qword ptr [r11]
       nop
M01_L24:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 2734
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
       cmp       dword ptr [7FF814E0F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF815483870
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154A4AB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary02()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       mov       rdx,22CE8EF0008
       xor       r8d,r8d
       call      qword ptr [7FF814F752C0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.String,System.String>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815474840]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
M01_L00:
       push      rbp
       sub       rsp,2D0
       lea       rbp,[rsp+2D0]
       xor       eax,eax
       mov       [rbp-298],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-290],xmm4
       vmovdqa   xmmword ptr [rbp-280],xmm4
       mov       rax,0FFFFFFFFFFFFFD90
M01_L01:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L01
       mov       [rbp-2A8],rsp
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF814F54F00],0
       je        short M01_L02
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L02:
       nop
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       call      qword ptr [7FF814ACEB80]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdx,[rbp-0D0]
       mov       [rbp-8],rdx
       mov       rdx,22CE8F04210
       mov       [rsp+20],rdx
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,22CE8EF0008
       call      qword ptr [7FF814FAC9F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-0D8],rax
       mov       rdx,[rbp-0D8]
       mov       [rbp+18],rdx
       mov       rdx,22CE8EF2730
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
       xor       r8d,r8d
       mov       r9,22CE8EF0008
       call      qword ptr [7FF814FAC9F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-0E0],rax
       mov       rcx,[rbp-0E0]
       cmp       [rcx],ecx
       call      System.Object.GetType()
       mov       [rbp-0E8],rax
       mov       rax,[rbp-0E8]
       mov       [rbp-10],rax
       call      qword ptr [7FF815474A20]; DotNetTips.Spargine.Core.TypeHelper.get_BuiltInTypeNames()
       mov       [rbp-0F0],rax
       mov       rcx,[rbp-0F0]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF814B54608]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ContainsKey(System.__Canon)
       mov       [rbp-0F4],eax
       mov       ecx,[rbp-0F4]
       movzx     ecx,cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       je        short M01_L03
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-260],rcx
       mov       rcx,[rbp+18]
       mov       [rbp-268],rcx
       mov       rcx,[rbp+10]
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-270],rax
       mov       rcx,[rbp-260]
       mov       rdx,[rbp-268]
       mov       r8,[rbp-270]
       cmp       [rcx],ecx
       call      qword ptr [7FF814B545E0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon)
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-30],rcx
       nop
       jmp       near ptr M01_L22
M01_L03:
       mov       rcx,[rbp-10]
       call      qword ptr [7FF815474C30]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       mov       [rbp-0F8],eax
       mov       edx,[rbp-0F8]
       movzx     edx,dl
       mov       [rbp-34],edx
       cmp       dword ptr [rbp-34],0
       je        near ptr M01_L09
       nop
       xor       edx,edx
       mov       [rbp-38],edx
       nop
       mov       rdx,[rbp+10]
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FF814AC43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       [rbp-278],rax
       mov       rcx,[rbp-278]
       mov       r11,7FF814980930
       call      qword ptr [r11]
       mov       [rbp-1C0],rax
       mov       rcx,[rbp-1C0]
       mov       [rbp-40],rcx
       nop
       jmp       near ptr M01_L08
M01_L04:
       mov       rcx,[rbp-40]
       mov       r11,7FF814980940
       call      qword ptr [r11]
       mov       [rbp-1D0],rax
       mov       rax,[rbp-1D0]
       mov       [rbp-48],rax
       nop
       mov       eax,[rbp-38]
       mov       [rbp-1D4],eax
       mov       eax,[rbp-38]
       add       eax,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-38],eax
       mov       eax,[rbp-1D4]
       mov       [rbp-4C],eax
       call      qword ptr [7FF814CA4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp-1E0],rax
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-1E8],rax
       mov       r9,[rbp-1E8]
       mov       ecx,[rbp-4C]
       mov       [r9+8],ecx
       mov       r9,[rbp-1E8]
       mov       rcx,[rbp-1E0]
       mov       r8,[rbp+18]
       mov       rdx,22CE8F04240
       call      qword ptr [7FF814AC6C40]; System.String.Format(System.IFormatProvider, System.String, System.Object, System.Object)
       mov       [rbp-1F0],rax
       mov       rcx,[rbp-1F0]
       mov       [rbp-58],rcx
       mov       rcx,[rbp-8]
       mov       [rbp-1F8],rcx
       mov       rcx,[rbp-48]
       mov       rdx,[rbp-58]
       mov       r8d,1
       call      qword ptr [7FF814F752C0]
       mov       [rbp-200],rax
       mov       r8,[rbp-200]
       mov       rdx,[rbp-1F8]
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF815474CC0]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-208],rax
       mov       rcx,7FF814F553E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1EC5700BBD0
       mov       rcx,[rcx]
       mov       [rbp-210],rcx
       mov       rcx,[rbp-208]
       mov       [rbp-218],rcx
       mov       rcx,[rbp-210]
       mov       [rbp-220],rcx
       cmp       qword ptr [rbp-210],0
       jne       near ptr M01_L06
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-258],rax
       mov       rcx,7FF814F553E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1EC5700BBC0
       mov       rdx,[rdx]
       mov       [rbp-280],rdx
       mov       rdx,[rbp-280]
       mov       rcx,[rbp-258]
       mov       r8,7FF815470D38
       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF814F553E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-258]
       mov       rcx,1EC5700BBD0
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-258]
       mov       [rbp-220],rcx
M01_L06:
       mov       rcx,7FF814F553E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1EC5700BBD8
       mov       rcx,[rcx]
       mov       [rbp-228],rcx
       mov       rcx,[rbp-218]
       mov       [rbp-230],rcx
       mov       rcx,[rbp-220]
       mov       [rbp-238],rcx
       mov       rcx,[rbp-228]
       mov       [rbp-240],rcx
       cmp       qword ptr [rbp-228],0
       jne       near ptr M01_L07
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-250],rax
       mov       rcx,7FF814F553E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1EC5700BBC0
       mov       rdx,[rdx]
       mov       [rbp-288],rdx
       mov       rdx,[rbp-288]
       mov       rcx,[rbp-250]
       mov       r8,7FF815470D50
       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF814F553E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-250]
       mov       rcx,1EC5700BBD8
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-250]
       mov       [rbp-240],r9
M01_L07:
       mov       r9,[rbp-240]
       mov       rdx,[rbp-230]
       mov       r8,[rbp-238]
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FF815474DF8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       [rbp-248],rax
       mov       rdx,[rbp-248]
       mov       [rbp-8],rdx
       nop
M01_L08:
       mov       rcx,[rbp-40]
       mov       r11,7FF814980938
       call      qword ptr [r11]
       mov       [rbp-1C4],eax
       cmp       dword ptr [rbp-1C4],0
       jne       near ptr M01_L04
       nop
       mov       rcx,rsp
       call      M01_L23
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-30],rcx
       nop
       jmp       near ptr M01_L22
M01_L09:
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF814A15B78]; System.Type.GetProperties()
       mov       [rbp-100],rax
       mov       rcx,[rbp-100]
       mov       [rbp-18],rcx
       mov       rcx,22CE8EF0008
       mov       [rbp-20],rcx
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF814AC69E8]; System.String.get_Length()
       mov       [rbp-104],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-104],0
       setg      cl
       mov       [rbp-64],ecx
       cmp       dword ptr [rbp-64],0
       je        short M01_L10
       nop
       lea       rcx,[rbp-90]
       xor       edx,edx
       mov       r8d,2
       call      qword ptr [7FF814C756B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-90]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF814C75830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       nop
       lea       rcx,[rbp-90]
       mov       edx,2E
       call      qword ptr [7FF815474E28]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       nop
       lea       rcx,[rbp-90]
       call      qword ptr [7FF814C75740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       [rbp-1B8],rax
       mov       rdx,[rbp-1B8]
       mov       [rbp-20],rdx
       nop
M01_L10:
       xor       edx,edx
       mov       [rbp-94],edx
       nop
       jmp       near ptr M01_L21
M01_L11:
       nop
       mov       rdx,[rbp-18]
       mov       ecx,[rbp-94]
       cmp       ecx,[rdx+8]
       jb        short M01_L12
       call      CORINFO_HELP_RNGCHKFAIL
M01_L12:
       mov       eax,ecx
       lea       rdx,[rdx+rax*8+10]
       mov       rdx,[rdx]
       mov       [rbp-0A0],rdx
       mov       rdx,[rbp-0A0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.TypeExtensions.GetAttribute[[System.Text.Json.Serialization.JsonIgnoreAttribute, System.Text.Json]](System.Reflection.PropertyInfo)
       call      qword ptr [7FF815474C90]; DotNetTips.Spargine.Extensions.TypeExtensions.GetAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.PropertyInfo)
       mov       [rbp-110],rax
       mov       rcx,[rbp-110]
       mov       [rbp-0A8],rcx
       xor       ecx,ecx
       cmp       qword ptr [rbp-0A8],0
       sete      cl
       mov       [rbp-0AC],ecx
       cmp       dword ptr [rbp-0AC],0
       je        near ptr M01_L18
       nop
       mov       rcx,[rbp-0A0]
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       mov       rax,[rbp-0A0]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+38]
       mov       [rbp-118],rax
       mov       rax,[rbp-118]
       mov       [rbp-0B8],rax
       mov       eax,[rbp+20]
       movzx     eax,al
       test      eax,eax
       je        short M01_L13
       xor       eax,eax
       cmp       qword ptr [rbp-0B8],0
       sete      al
       mov       [rbp-11C],eax
       jmp       short M01_L14
M01_L13:
       xor       eax,eax
       mov       [rbp-11C],eax
M01_L14:
       mov       eax,[rbp-11C]
       movzx     eax,al
       mov       [rbp-0C4],eax
       cmp       dword ptr [rbp-0C4],0
       je        short M01_L15
       nop
       nop
       jmp       near ptr M01_L19
M01_L15:
       call      qword ptr [7FF814CA4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp-128],rax
       mov       rcx,22CE8F04268
       mov       [rbp-130],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-138],rcx
       mov       rcx,[rbp-0A0]
       mov       rax,[rbp-0A0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-140],rax
       mov       rcx,[rbp-128]
       mov       rdx,[rbp-130]
       mov       r8,[rbp-138]
       mov       r9,[rbp-140]
       call      qword ptr [7FF814AC6C40]; System.String.Format(System.IFormatProvider, System.String, System.Object, System.Object)
       mov       [rbp-148],rax
       mov       rcx,[rbp-148]
       mov       [rbp-0C0],rcx
       mov       rcx,[rbp-8]
       mov       [rbp-150],rcx
       mov       rcx,[rbp-0B8]
       mov       rdx,[rbp-0C0]
       mov       r8d,1
       call      qword ptr [7FF814F752C0]
       mov       [rbp-158],rax
       mov       r8,[rbp-158]
       mov       rdx,[rbp-150]
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF815474CC0]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-160],rax
       mov       rcx,7FF814F553E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1EC5700BBE0
       mov       rcx,[rcx]
       mov       [rbp-168],rcx
       mov       rcx,[rbp-160]
       mov       [rbp-170],rcx
       mov       rcx,[rbp-168]
       mov       [rbp-178],rcx
       cmp       qword ptr [rbp-168],0
       jne       near ptr M01_L16
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-1B0],rax
       mov       rcx,7FF814F553E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1EC5700BBC0
       mov       rdx,[rdx]
       mov       [rbp-290],rdx
       mov       rdx,[rbp-290]
       mov       rcx,[rbp-1B0]
       mov       r8,7FF815470D68
       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF814F553E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-1B0]
       mov       rcx,1EC5700BBE0
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-1B0]
       mov       [rbp-178],rcx
M01_L16:
       mov       rcx,7FF814F553E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1EC5700BBE8
       mov       rcx,[rcx]
       mov       [rbp-180],rcx
       mov       rcx,[rbp-170]
       mov       [rbp-188],rcx
       mov       rcx,[rbp-178]
       mov       [rbp-190],rcx
       mov       rcx,[rbp-180]
       mov       [rbp-198],rcx
       cmp       qword ptr [rbp-180],0
       jne       near ptr M01_L17
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-1A8],rax
       mov       rcx,7FF814F553E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1EC5700BBC0
       mov       rdx,[rdx]
       mov       [rbp-298],rdx
       mov       rdx,[rbp-298]
       mov       rcx,[rbp-1A8]
       mov       r8,7FF815470D80
       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF814F553E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-1A8]
       mov       rcx,1EC5700BBE8
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-1A8]
       mov       [rbp-198],r9
M01_L17:
       mov       r9,[rbp-198]
       mov       rdx,[rbp-188]
       mov       r8,[rbp-190]
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FF815474DF8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       [rbp-1A0],rax
       mov       rax,[rbp-1A0]
       mov       [rbp-8],rax
       nop
M01_L18:
       nop
M01_L19:
       mov       eax,[rbp-94]
       add       eax,1
       jno       short M01_L20
       call      CORINFO_HELP_OVERFLOW
M01_L20:
       mov       [rbp-94],eax
M01_L21:
       mov       edx,[rbp-94]
       mov       rcx,[rbp-18]
       cmp       edx,[rcx+8]
       setl      dl
       movzx     edx,dl
       mov       [rbp-0C8],edx
       cmp       dword ptr [rbp-0C8],0
       jne       near ptr M01_L11
       mov       rax,[rbp-8]
       mov       [rbp-30],rax
       nop
M01_L22:
       mov       rax,[rbp-30]
       add       rsp,2D0
       pop       rbp
       ret
M01_L23:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+2D0]
       mov       rdx,[rbp-40]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF814AC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       [rbp-60],rax
       cmp       qword ptr [rbp-60],0
       je        short M01_L24
       mov       rcx,[rbp-60]
       mov       r11,7FF814980948
       call      qword ptr [r11]
       nop
M01_L24:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 2734
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
       cmp       dword ptr [7FF814E1F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF815492288
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154A4AB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary05()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+140]
       mov       rdx,1EB57BC0008
       mov       r8d,1
       call      qword ptr [7FF814F952C0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.String,System.String>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815494678]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
M01_L00:
       push      rbp
       sub       rsp,2D0
       lea       rbp,[rsp+2D0]
       xor       eax,eax
       mov       [rbp-298],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-290],xmm4
       vmovdqa   xmmword ptr [rbp-280],xmm4
       mov       rax,0FFFFFFFFFFFFFD90
M01_L01:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L01
       mov       [rbp-2A8],rsp
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF814F74F00],0
       je        short M01_L02
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L02:
       nop
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       call      qword ptr [7FF814AEEB80]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdx,[rbp-0D0]
       mov       [rbp-8],rdx
       mov       rdx,1EB57BD41E8
       mov       [rsp+20],rdx
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1EB57BC0008
       call      qword ptr [7FF814FCC9F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-0D8],rax
       mov       rdx,[rbp-0D8]
       mov       [rbp+18],rdx
       mov       rdx,1EB57BC2730
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1EB57BC0008
       call      qword ptr [7FF814FCC9F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-0E0],rax
       mov       rcx,[rbp-0E0]
       cmp       [rcx],ecx
       call      System.Object.GetType()
       mov       [rbp-0E8],rax
       mov       rax,[rbp-0E8]
       mov       [rbp-10],rax
       call      qword ptr [7FF815494858]; DotNetTips.Spargine.Core.TypeHelper.get_BuiltInTypeNames()
       mov       [rbp-0F0],rax
       mov       rcx,[rbp-0F0]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF814B74608]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ContainsKey(System.__Canon)
       mov       [rbp-0F4],eax
       mov       ecx,[rbp-0F4]
       movzx     ecx,cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       je        short M01_L03
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-260],rcx
       mov       rcx,[rbp+18]
       mov       [rbp-268],rcx
       mov       rcx,[rbp+10]
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-270],rax
       mov       rcx,[rbp-260]
       mov       rdx,[rbp-268]
       mov       r8,[rbp-270]
       cmp       [rcx],ecx
       call      qword ptr [7FF814B745E0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon)
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-30],rcx
       nop
       jmp       near ptr M01_L22
M01_L03:
       mov       rcx,[rbp-10]
       call      qword ptr [7FF815494A68]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       mov       [rbp-0F8],eax
       mov       edx,[rbp-0F8]
       movzx     edx,dl
       mov       [rbp-34],edx
       cmp       dword ptr [rbp-34],0
       je        near ptr M01_L09
       nop
       xor       edx,edx
       mov       [rbp-38],edx
       nop
       mov       rdx,[rbp+10]
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FF814AE43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       [rbp-278],rax
       mov       rcx,[rbp-278]
       mov       r11,7FF8149A0950
       call      qword ptr [r11]
       mov       [rbp-1C0],rax
       mov       rcx,[rbp-1C0]
       mov       [rbp-40],rcx
       nop
       jmp       near ptr M01_L08
M01_L04:
       mov       rcx,[rbp-40]
       mov       r11,7FF8149A0960
       call      qword ptr [r11]
       mov       [rbp-1D0],rax
       mov       rax,[rbp-1D0]
       mov       [rbp-48],rax
       nop
       mov       eax,[rbp-38]
       mov       [rbp-1D4],eax
       mov       eax,[rbp-38]
       add       eax,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-38],eax
       mov       eax,[rbp-1D4]
       mov       [rbp-4C],eax
       call      qword ptr [7FF814CC4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp-1E0],rax
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-1E8],rax
       mov       r9,[rbp-1E8]
       mov       ecx,[rbp-4C]
       mov       [r9+8],ecx
       mov       r9,[rbp-1E8]
       mov       rcx,[rbp-1E0]
       mov       r8,[rbp+18]
       mov       rdx,1EB57BD4218
       call      qword ptr [7FF814AE6C40]; System.String.Format(System.IFormatProvider, System.String, System.Object, System.Object)
       mov       [rbp-1F0],rax
       mov       rcx,[rbp-1F0]
       mov       [rbp-58],rcx
       mov       rcx,[rbp-8]
       mov       [rbp-1F8],rcx
       mov       rcx,[rbp-48]
       mov       rdx,[rbp-58]
       mov       r8d,1
       call      qword ptr [7FF814F952C0]
       mov       [rbp-200],rax
       mov       r8,[rbp-200]
       mov       rdx,[rbp-1F8]
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF815494AF8]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-208],rax
       mov       rcx,7FF814F753E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1AAC5C0BBD0
       mov       rcx,[rcx]
       mov       [rbp-210],rcx
       mov       rcx,[rbp-208]
       mov       [rbp-218],rcx
       mov       rcx,[rbp-210]
       mov       [rbp-220],rcx
       cmp       qword ptr [rbp-210],0
       jne       near ptr M01_L06
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-258],rax
       mov       rcx,7FF814F753E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1AAC5C0BBC0
       mov       rdx,[rdx]
       mov       [rbp-280],rdx
       mov       rdx,[rbp-280]
       mov       rcx,[rbp-258]
       mov       r8,7FF815490B70
       call      qword ptr [7FF814AE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF814F753E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-258]
       mov       rcx,1AAC5C0BBD0
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-258]
       mov       [rbp-220],rcx
M01_L06:
       mov       rcx,7FF814F753E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1AAC5C0BBD8
       mov       rcx,[rcx]
       mov       [rbp-228],rcx
       mov       rcx,[rbp-218]
       mov       [rbp-230],rcx
       mov       rcx,[rbp-220]
       mov       [rbp-238],rcx
       mov       rcx,[rbp-228]
       mov       [rbp-240],rcx
       cmp       qword ptr [rbp-228],0
       jne       near ptr M01_L07
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-250],rax
       mov       rcx,7FF814F753E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1AAC5C0BBC0
       mov       rdx,[rdx]
       mov       [rbp-288],rdx
       mov       rdx,[rbp-288]
       mov       rcx,[rbp-250]
       mov       r8,7FF815490B88
       call      qword ptr [7FF814AE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF814F753E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-250]
       mov       rcx,1AAC5C0BBD8
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-250]
       mov       [rbp-240],r9
M01_L07:
       mov       r9,[rbp-240]
       mov       rdx,[rbp-230]
       mov       r8,[rbp-238]
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FF815494C30]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       [rbp-248],rax
       mov       rdx,[rbp-248]
       mov       [rbp-8],rdx
       nop
M01_L08:
       mov       rcx,[rbp-40]
       mov       r11,7FF8149A0958
       call      qword ptr [r11]
       mov       [rbp-1C4],eax
       cmp       dword ptr [rbp-1C4],0
       jne       near ptr M01_L04
       nop
       mov       rcx,rsp
       call      M01_L23
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-30],rcx
       nop
       jmp       near ptr M01_L22
M01_L09:
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF814A35B78]; System.Type.GetProperties()
       mov       [rbp-100],rax
       mov       rcx,[rbp-100]
       mov       [rbp-18],rcx
       mov       rcx,1EB57BC0008
       mov       [rbp-20],rcx
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF814AE69E8]; System.String.get_Length()
       mov       [rbp-104],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-104],0
       setg      cl
       mov       [rbp-64],ecx
       cmp       dword ptr [rbp-64],0
       je        short M01_L10
       nop
       lea       rcx,[rbp-90]
       xor       edx,edx
       mov       r8d,2
       call      qword ptr [7FF814C956B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-90]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF814C95830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       nop
       lea       rcx,[rbp-90]
       mov       edx,2E
       call      qword ptr [7FF815494C60]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       nop
       lea       rcx,[rbp-90]
       call      qword ptr [7FF814C95740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       [rbp-1B8],rax
       mov       rdx,[rbp-1B8]
       mov       [rbp-20],rdx
       nop
M01_L10:
       xor       edx,edx
       mov       [rbp-94],edx
       nop
       jmp       near ptr M01_L21
M01_L11:
       nop
       mov       rdx,[rbp-18]
       mov       ecx,[rbp-94]
       cmp       ecx,[rdx+8]
       jb        short M01_L12
       call      CORINFO_HELP_RNGCHKFAIL
M01_L12:
       mov       eax,ecx
       lea       rdx,[rdx+rax*8+10]
       mov       rdx,[rdx]
       mov       [rbp-0A0],rdx
       mov       rdx,[rbp-0A0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.TypeExtensions.GetAttribute[[System.Text.Json.Serialization.JsonIgnoreAttribute, System.Text.Json]](System.Reflection.PropertyInfo)
       call      qword ptr [7FF815494AC8]; DotNetTips.Spargine.Extensions.TypeExtensions.GetAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.PropertyInfo)
       mov       [rbp-110],rax
       mov       rcx,[rbp-110]
       mov       [rbp-0A8],rcx
       xor       ecx,ecx
       cmp       qword ptr [rbp-0A8],0
       sete      cl
       mov       [rbp-0AC],ecx
       cmp       dword ptr [rbp-0AC],0
       je        near ptr M01_L18
       nop
       mov       rcx,[rbp-0A0]
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       mov       rax,[rbp-0A0]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+38]
       mov       [rbp-118],rax
       mov       rax,[rbp-118]
       mov       [rbp-0B8],rax
       mov       eax,[rbp+20]
       movzx     eax,al
       test      eax,eax
       je        short M01_L13
       xor       eax,eax
       cmp       qword ptr [rbp-0B8],0
       sete      al
       mov       [rbp-11C],eax
       jmp       short M01_L14
M01_L13:
       xor       eax,eax
       mov       [rbp-11C],eax
M01_L14:
       mov       eax,[rbp-11C]
       movzx     eax,al
       mov       [rbp-0C4],eax
       cmp       dword ptr [rbp-0C4],0
       je        short M01_L15
       nop
       nop
       jmp       near ptr M01_L19
M01_L15:
       call      qword ptr [7FF814CC4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp-128],rax
       mov       rcx,1EB57BD4240
       mov       [rbp-130],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-138],rcx
       mov       rcx,[rbp-0A0]
       mov       rax,[rbp-0A0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-140],rax
       mov       rcx,[rbp-128]
       mov       rdx,[rbp-130]
       mov       r8,[rbp-138]
       mov       r9,[rbp-140]
       call      qword ptr [7FF814AE6C40]; System.String.Format(System.IFormatProvider, System.String, System.Object, System.Object)
       mov       [rbp-148],rax
       mov       rcx,[rbp-148]
       mov       [rbp-0C0],rcx
       mov       rcx,[rbp-8]
       mov       [rbp-150],rcx
       mov       rcx,[rbp-0B8]
       mov       rdx,[rbp-0C0]
       mov       r8d,1
       call      qword ptr [7FF814F952C0]
       mov       [rbp-158],rax
       mov       r8,[rbp-158]
       mov       rdx,[rbp-150]
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF815494AF8]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-160],rax
       mov       rcx,7FF814F753E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1AAC5C0BBE0
       mov       rcx,[rcx]
       mov       [rbp-168],rcx
       mov       rcx,[rbp-160]
       mov       [rbp-170],rcx
       mov       rcx,[rbp-168]
       mov       [rbp-178],rcx
       cmp       qword ptr [rbp-168],0
       jne       near ptr M01_L16
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-1B0],rax
       mov       rcx,7FF814F753E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1AAC5C0BBC0
       mov       rdx,[rdx]
       mov       [rbp-290],rdx
       mov       rdx,[rbp-290]
       mov       rcx,[rbp-1B0]
       mov       r8,7FF815490BA0
       call      qword ptr [7FF814AE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF814F753E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-1B0]
       mov       rcx,1AAC5C0BBE0
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-1B0]
       mov       [rbp-178],rcx
M01_L16:
       mov       rcx,7FF814F753E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1AAC5C0BBE8
       mov       rcx,[rcx]
       mov       [rbp-180],rcx
       mov       rcx,[rbp-170]
       mov       [rbp-188],rcx
       mov       rcx,[rbp-178]
       mov       [rbp-190],rcx
       mov       rcx,[rbp-180]
       mov       [rbp-198],rcx
       cmp       qword ptr [rbp-180],0
       jne       near ptr M01_L17
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-1A8],rax
       mov       rcx,7FF814F753E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1AAC5C0BBC0
       mov       rdx,[rdx]
       mov       [rbp-298],rdx
       mov       rdx,[rbp-298]
       mov       rcx,[rbp-1A8]
       mov       r8,7FF815490BB8
       call      qword ptr [7FF814AE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF814F753E8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-1A8]
       mov       rcx,1AAC5C0BBE8
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-1A8]
       mov       [rbp-198],r9
M01_L17:
       mov       r9,[rbp-198]
       mov       rdx,[rbp-188]
       mov       r8,[rbp-190]
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FF815494C30]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       [rbp-1A0],rax
       mov       rax,[rbp-1A0]
       mov       [rbp-8],rax
       nop
M01_L18:
       nop
M01_L19:
       mov       eax,[rbp-94]
       add       eax,1
       jno       short M01_L20
       call      CORINFO_HELP_OVERFLOW
M01_L20:
       mov       [rbp-94],eax
M01_L21:
       mov       edx,[rbp-94]
       mov       rcx,[rbp-18]
       cmp       edx,[rcx+8]
       setl      dl
       movzx     edx,dl
       mov       [rbp-0C8],edx
       cmp       dword ptr [rbp-0C8],0
       jne       near ptr M01_L11
       mov       rax,[rbp-8]
       mov       [rbp-30],rax
       nop
M01_L22:
       mov       rax,[rbp-30]
       add       rsp,2D0
       pop       rbp
       ret
M01_L23:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+2D0]
       mov       rdx,[rbp-40]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF814AE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       [rbp-60],rax
       cmp       qword ptr [rbp-60],0
       je        short M01_L24
       mov       rcx,[rbp-60]
       mov       r11,7FF8149A0968
       call      qword ptr [r11]
       nop
M01_L24:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 2734
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
       cmp       dword ptr [7FF814E3F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF8154B36A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154D4AB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary04()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+140]
       mov       rdx,1CA22480008
       xor       r8d,r8d
       call      qword ptr [7FF814FA49F0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.String,System.String>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF81536DED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
M01_L00:
       push      rbp
       sub       rsp,2D0
       lea       rbp,[rsp+2D0]
       xor       eax,eax
       mov       [rbp-298],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-290],xmm4
       vmovdqa   xmmword ptr [rbp-280],xmm4
       mov       rax,0FFFFFFFFFFFFFD90
M01_L01:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L01
       mov       [rbp-2A8],rsp
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF814F85110],0
       je        short M01_L02
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L02:
       nop
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       call      qword ptr [7FF814AFEB80]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdx,[rbp-0D0]
       mov       [rbp-8],rdx
       mov       rdx,1CA224941E8
       mov       [rsp+20],rdx
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1CA22480008
       call      qword ptr [7FF814FD7ED0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-0D8],rax
       mov       rdx,[rbp-0D8]
       mov       [rbp+18],rdx
       mov       rdx,1CA22482730
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1CA22480008
       call      qword ptr [7FF814FD7ED0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-0E0],rax
       mov       rcx,[rbp-0E0]
       cmp       [rcx],ecx
       call      System.Object.GetType()
       mov       [rbp-0E8],rax
       mov       rax,[rbp-0E8]
       mov       [rbp-10],rax
       call      qword ptr [7FF81536E0B8]; DotNetTips.Spargine.Core.TypeHelper.get_BuiltInTypeNames()
       mov       [rbp-0F0],rax
       mov       rcx,[rbp-0F0]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF814B84608]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ContainsKey(System.__Canon)
       mov       [rbp-0F4],eax
       mov       ecx,[rbp-0F4]
       movzx     ecx,cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       je        short M01_L03
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-260],rcx
       mov       rcx,[rbp+18]
       mov       [rbp-268],rcx
       mov       rcx,[rbp+10]
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-270],rax
       mov       rcx,[rbp-260]
       mov       rdx,[rbp-268]
       mov       r8,[rbp-270]
       cmp       [rcx],ecx
       call      qword ptr [7FF814B845E0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon)
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-30],rcx
       nop
       jmp       near ptr M01_L22
M01_L03:
       mov       rcx,[rbp-10]
       call      qword ptr [7FF81536E2C8]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       mov       [rbp-0F8],eax
       mov       edx,[rbp-0F8]
       movzx     edx,dl
       mov       [rbp-34],edx
       cmp       dword ptr [rbp-34],0
       je        near ptr M01_L09
       nop
       xor       edx,edx
       mov       [rbp-38],edx
       nop
       mov       rdx,[rbp+10]
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FF814AF43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       [rbp-278],rax
       mov       rcx,[rbp-278]
       mov       r11,7FF8149B07F0
       call      qword ptr [r11]
       mov       [rbp-1C0],rax
       mov       rcx,[rbp-1C0]
       mov       [rbp-40],rcx
       nop
       jmp       near ptr M01_L08
M01_L04:
       mov       rcx,[rbp-40]
       mov       r11,7FF8149B0800
       call      qword ptr [r11]
       mov       [rbp-1D0],rax
       mov       rax,[rbp-1D0]
       mov       [rbp-48],rax
       nop
       mov       eax,[rbp-38]
       mov       [rbp-1D4],eax
       mov       eax,[rbp-38]
       add       eax,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-38],eax
       mov       eax,[rbp-1D4]
       mov       [rbp-4C],eax
       call      qword ptr [7FF814CD4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp-1E0],rax
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-1E8],rax
       mov       r9,[rbp-1E8]
       mov       ecx,[rbp-4C]
       mov       [r9+8],ecx
       mov       r9,[rbp-1E8]
       mov       rcx,[rbp-1E0]
       mov       r8,[rbp+18]
       mov       rdx,1CA22494218
       call      qword ptr [7FF814AF6C40]; System.String.Format(System.IFormatProvider, System.String, System.Object, System.Object)
       mov       [rbp-1F0],rax
       mov       rcx,[rbp-1F0]
       mov       [rbp-58],rcx
       mov       rcx,[rbp-8]
       mov       [rbp-1F8],rcx
       mov       rcx,[rbp-48]
       mov       rdx,[rbp-58]
       mov       r8d,1
       call      qword ptr [7FF814FA49F0]
       mov       [rbp-200],rax
       mov       r8,[rbp-200]
       mov       rdx,[rbp-1F8]
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF81536E358]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-208],rax
       mov       rcx,7FF814F855F8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1899040BBD0
       mov       rcx,[rcx]
       mov       [rbp-210],rcx
       mov       rcx,[rbp-208]
       mov       [rbp-218],rcx
       mov       rcx,[rbp-210]
       mov       [rbp-220],rcx
       cmp       qword ptr [rbp-210],0
       jne       near ptr M01_L06
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-258],rax
       mov       rcx,7FF814F855F8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1899040BBC0
       mov       rdx,[rdx]
       mov       [rbp-280],rdx
       mov       rdx,[rbp-280]
       mov       rcx,[rbp-258]
       mov       r8,7FF81536A3D0
       call      qword ptr [7FF814AF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF814F855F8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-258]
       mov       rcx,1899040BBD0
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-258]
       mov       [rbp-220],rcx
M01_L06:
       mov       rcx,7FF814F855F8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1899040BBD8
       mov       rcx,[rcx]
       mov       [rbp-228],rcx
       mov       rcx,[rbp-218]
       mov       [rbp-230],rcx
       mov       rcx,[rbp-220]
       mov       [rbp-238],rcx
       mov       rcx,[rbp-228]
       mov       [rbp-240],rcx
       cmp       qword ptr [rbp-228],0
       jne       near ptr M01_L07
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-250],rax
       mov       rcx,7FF814F855F8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1899040BBC0
       mov       rdx,[rdx]
       mov       [rbp-288],rdx
       mov       rdx,[rbp-288]
       mov       rcx,[rbp-250]
       mov       r8,7FF81536A3E8
       call      qword ptr [7FF814AF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF814F855F8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-250]
       mov       rcx,1899040BBD8
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-250]
       mov       [rbp-240],r9
M01_L07:
       mov       r9,[rbp-240]
       mov       rdx,[rbp-230]
       mov       r8,[rbp-238]
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FF81536E490]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       [rbp-248],rax
       mov       rdx,[rbp-248]
       mov       [rbp-8],rdx
       nop
M01_L08:
       mov       rcx,[rbp-40]
       mov       r11,7FF8149B07F8
       call      qword ptr [r11]
       mov       [rbp-1C4],eax
       cmp       dword ptr [rbp-1C4],0
       jne       near ptr M01_L04
       nop
       mov       rcx,rsp
       call      M01_L23
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-30],rcx
       nop
       jmp       near ptr M01_L22
M01_L09:
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF814A45B78]; System.Type.GetProperties()
       mov       [rbp-100],rax
       mov       rcx,[rbp-100]
       mov       [rbp-18],rcx
       mov       rcx,1CA22480008
       mov       [rbp-20],rcx
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF814AF69E8]; System.String.get_Length()
       mov       [rbp-104],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-104],0
       setg      cl
       mov       [rbp-64],ecx
       cmp       dword ptr [rbp-64],0
       je        short M01_L10
       nop
       lea       rcx,[rbp-90]
       xor       edx,edx
       mov       r8d,2
       call      qword ptr [7FF814CA56B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-90]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF814CA5830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       nop
       lea       rcx,[rbp-90]
       mov       edx,2E
       call      qword ptr [7FF81536E4C0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       nop
       lea       rcx,[rbp-90]
       call      qword ptr [7FF814CA5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       [rbp-1B8],rax
       mov       rdx,[rbp-1B8]
       mov       [rbp-20],rdx
       nop
M01_L10:
       xor       edx,edx
       mov       [rbp-94],edx
       nop
       jmp       near ptr M01_L21
M01_L11:
       nop
       mov       rdx,[rbp-18]
       mov       ecx,[rbp-94]
       cmp       ecx,[rdx+8]
       jb        short M01_L12
       call      CORINFO_HELP_RNGCHKFAIL
M01_L12:
       mov       eax,ecx
       lea       rdx,[rdx+rax*8+10]
       mov       rdx,[rdx]
       mov       [rbp-0A0],rdx
       mov       rdx,[rbp-0A0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.TypeExtensions.GetAttribute[[System.Text.Json.Serialization.JsonIgnoreAttribute, System.Text.Json]](System.Reflection.PropertyInfo)
       call      qword ptr [7FF81536E328]; DotNetTips.Spargine.Extensions.TypeExtensions.GetAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.PropertyInfo)
       mov       [rbp-110],rax
       mov       rcx,[rbp-110]
       mov       [rbp-0A8],rcx
       xor       ecx,ecx
       cmp       qword ptr [rbp-0A8],0
       sete      cl
       mov       [rbp-0AC],ecx
       cmp       dword ptr [rbp-0AC],0
       je        near ptr M01_L18
       nop
       mov       rcx,[rbp-0A0]
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       mov       rax,[rbp-0A0]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+38]
       mov       [rbp-118],rax
       mov       rax,[rbp-118]
       mov       [rbp-0B8],rax
       mov       eax,[rbp+20]
       movzx     eax,al
       test      eax,eax
       je        short M01_L13
       xor       eax,eax
       cmp       qword ptr [rbp-0B8],0
       sete      al
       mov       [rbp-11C],eax
       jmp       short M01_L14
M01_L13:
       xor       eax,eax
       mov       [rbp-11C],eax
M01_L14:
       mov       eax,[rbp-11C]
       movzx     eax,al
       mov       [rbp-0C4],eax
       cmp       dword ptr [rbp-0C4],0
       je        short M01_L15
       nop
       nop
       jmp       near ptr M01_L19
M01_L15:
       call      qword ptr [7FF814CD4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp-128],rax
       mov       rcx,1CA22494240
       mov       [rbp-130],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-138],rcx
       mov       rcx,[rbp-0A0]
       mov       rax,[rbp-0A0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-140],rax
       mov       rcx,[rbp-128]
       mov       rdx,[rbp-130]
       mov       r8,[rbp-138]
       mov       r9,[rbp-140]
       call      qword ptr [7FF814AF6C40]; System.String.Format(System.IFormatProvider, System.String, System.Object, System.Object)
       mov       [rbp-148],rax
       mov       rcx,[rbp-148]
       mov       [rbp-0C0],rcx
       mov       rcx,[rbp-8]
       mov       [rbp-150],rcx
       mov       rcx,[rbp-0B8]
       mov       rdx,[rbp-0C0]
       mov       r8d,1
       call      qword ptr [7FF814FA49F0]
       mov       [rbp-158],rax
       mov       r8,[rbp-158]
       mov       rdx,[rbp-150]
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF81536E358]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-160],rax
       mov       rcx,7FF814F855F8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1899040BBE0
       mov       rcx,[rcx]
       mov       [rbp-168],rcx
       mov       rcx,[rbp-160]
       mov       [rbp-170],rcx
       mov       rcx,[rbp-168]
       mov       [rbp-178],rcx
       cmp       qword ptr [rbp-168],0
       jne       near ptr M01_L16
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-1B0],rax
       mov       rcx,7FF814F855F8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1899040BBC0
       mov       rdx,[rdx]
       mov       [rbp-290],rdx
       mov       rdx,[rbp-290]
       mov       rcx,[rbp-1B0]
       mov       r8,7FF81536A400
       call      qword ptr [7FF814AF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF814F855F8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-1B0]
       mov       rcx,1899040BBE0
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-1B0]
       mov       [rbp-178],rcx
M01_L16:
       mov       rcx,7FF814F855F8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1899040BBE8
       mov       rcx,[rcx]
       mov       [rbp-180],rcx
       mov       rcx,[rbp-170]
       mov       [rbp-188],rcx
       mov       rcx,[rbp-178]
       mov       [rbp-190],rcx
       mov       rcx,[rbp-180]
       mov       [rbp-198],rcx
       cmp       qword ptr [rbp-180],0
       jne       near ptr M01_L17
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-1A8],rax
       mov       rcx,7FF814F855F8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1899040BBC0
       mov       rdx,[rdx]
       mov       [rbp-298],rdx
       mov       rdx,[rbp-298]
       mov       rcx,[rbp-1A8]
       mov       r8,7FF81536A418
       call      qword ptr [7FF814AF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF814F855F8
       mov       edx,58
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-1A8]
       mov       rcx,1899040BBE8
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-1A8]
       mov       [rbp-198],r9
M01_L17:
       mov       r9,[rbp-198]
       mov       rdx,[rbp-188]
       mov       r8,[rbp-190]
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FF81536E490]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       [rbp-1A0],rax
       mov       rax,[rbp-1A0]
       mov       [rbp-8],rax
       nop
M01_L18:
       nop
M01_L19:
       mov       eax,[rbp-94]
       add       eax,1
       jno       short M01_L20
       call      CORINFO_HELP_OVERFLOW
M01_L20:
       mov       [rbp-94],eax
M01_L21:
       mov       edx,[rbp-94]
       mov       rcx,[rbp-18]
       cmp       edx,[rcx+8]
       setl      dl
       movzx     edx,dl
       mov       [rbp-0C8],edx
       cmp       dword ptr [rbp-0C8],0
       jne       near ptr M01_L11
       mov       rax,[rbp-8]
       mov       [rbp-30],rax
       nop
M01_L22:
       mov       rax,[rbp-30]
       add       rsp,2D0
       pop       rbp
       ret
M01_L23:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+2D0]
       mov       rdx,[rbp-40]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF814AF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       [rbp-60],rax
       cmp       qword ptr [rbp-60],0
       je        short M01_L24
       mov       rcx,[rbp-60]
       mov       r11,7FF8149B0808
       call      qword ptr [r11]
       nop
M01_L24:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 2734
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
       cmp       dword ptr [7FF814E3F438],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E84528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF8153A5460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81539DE78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString01()
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       rcx,[rbx+130]
       mov       rdx,2F653610008
       mov       r8d,3A
       mov       r9,2F653618DF0
       call      qword ptr [7FF814F852D8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,30
       pop       rbx
       jmp       qword ptr [7FF815484990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 90
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       cmp       dword ptr [7FF814F64F00],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      qword ptr [7FF8154849C0]; DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-8]
       mov       ecx,[rbp+20]
       mov       [rdx+10],cx
       nop
       xor       edx,edx
       cmp       qword ptr [rbp+10],0
       sete      dl
       mov       [rbp-24],edx
       cmp       dword ptr [rbp-24],0
       je        short M01_L02
       nop
       mov       rdx,2F653610008
       mov       [rbp-30],rdx
       nop
       jmp       near ptr M01_L07
M01_L02:
       mov       rdx,[rbp-8]
       mov       [rbp-48],rdx
       mov       rdx,2F653624210
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2F653610008
       call      qword ptr [7FF814FBC9F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-48]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      System.Object.GetType()
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       rax,[rbp-58]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp-10],rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       [rbp-68],rax
       mov       rcx,[rbp-10]
       mov       [rbp-70],rcx
       mov       rcx,[rbp-68]
       call      qword ptr [7FF814A24ED0]; System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)
       mov       [rbp-78],rax
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-80],rax
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-80]
       mov       r8d,4
       call      qword ptr [7FF814AD61D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       [rbp-84],eax
       mov       r8d,[rbp-84]
       movzx     r8d,r8b
       mov       [rbp-34],r8d
       cmp       dword ptr [rbp-34],0
       je        short M01_L03
       nop
       mov       r8,2F653615FA0
       mov       [rbp-10],r8
       nop
       nop
       jmp       short M01_L04
M01_L03:
       mov       r8d,[rbp+38]
       movzx     r8d,r8b
       test      r8d,r8d
       sete      r8b
       movzx     r8d,r8b
       mov       [rbp-38],r8d
       cmp       dword ptr [rbp-38],0
       je        short M01_L04
       nop
       mov       r8,2F653610008
       mov       [rbp-10],r8
       nop
M01_L04:
       mov       r8d,[rbp+30]
       movzx     r8d,r8b
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-10]
       call      qword ptr [7FF814F852C0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       mov       [rbp-18],rcx
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rdx,[rbp-8]
       mov       r8,7FF8154809D8
       call      qword ptr [7FF814AD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r9,[rbp-98]
       mov       rdx,[rbp-18]
       mov       r8,[rbp+18]
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FF815484A50]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       [rbp-0A0],rax
       mov       rdx,[rbp-0A0]
       mov       [rbp-20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,[rbp-20]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF814AD62F8]; System.String.StartsWith(System.String, System.StringComparison)
       mov       [rbp-0A4],eax
       cmp       dword ptr [rbp-0A4],0
       jne       short M01_L05
       mov       rcx,[rbp-20]
       mov       [rbp-0C0],rcx
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp-20]
       mov       [rbp-0B0],rcx
       xor       ecx,ecx
       mov       [rbp-0B4],ecx
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF814AD69E8]; System.String.get_Length()
       mov       [rbp-0B8],eax
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0B4]
       mov       r8d,[rbp-0B8]
       cmp       [rcx],ecx
       call      qword ptr [7FF814AD6EE0]; System.String.Remove(Int32, Int32)
       mov       [rbp-0C0],rax
M01_L06:
       mov       rax,[rbp-0C0]
       mov       [rbp-30],rax
       nop
M01_L07:
       mov       rax,[rbp-30]
       add       rsp,0F0
       pop       rbp
       ret
; Total bytes of code 779
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
       cmp       dword ptr [7FF814E2F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF81549A510
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154C4B10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString02()
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],1
       mov       rcx,[rbx+130]
       mov       rdx,2F28A190008
       mov       r8d,3A
       mov       r9,2F28A198DF0
       call      qword ptr [7FF814F74A08]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,30
       pop       rbx
       jmp       qword ptr [7FF81543F390]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       cmp       dword ptr [7FF814F54F00],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      qword ptr [7FF81543F3C0]; DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-8]
       mov       ecx,[rbp+20]
       mov       [rdx+10],cx
       nop
       xor       edx,edx
       cmp       qword ptr [rbp+10],0
       sete      dl
       mov       [rbp-24],edx
       cmp       dword ptr [rbp-24],0
       je        short M01_L02
       nop
       mov       rdx,2F28A190008
       mov       [rbp-30],rdx
       nop
       jmp       near ptr M01_L07
M01_L02:
       mov       rdx,[rbp-8]
       mov       [rbp-48],rdx
       mov       rdx,2F28A1A4210
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2F28A190008
       call      qword ptr [7FF814FA7ED0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-48]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      System.Object.GetType()
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       rax,[rbp-58]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp-10],rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       [rbp-68],rax
       mov       rcx,[rbp-10]
       mov       [rbp-70],rcx
       mov       rcx,[rbp-68]
       call      qword ptr [7FF814A14ED0]; System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)
       mov       [rbp-78],rax
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-80],rax
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-80]
       mov       r8d,4
       call      qword ptr [7FF814AC61D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       [rbp-84],eax
       mov       r8d,[rbp-84]
       movzx     r8d,r8b
       mov       [rbp-34],r8d
       cmp       dword ptr [rbp-34],0
       je        short M01_L03
       nop
       mov       r8,2F28A195FA0
       mov       [rbp-10],r8
       nop
       nop
       jmp       short M01_L04
M01_L03:
       mov       r8d,[rbp+38]
       movzx     r8d,r8b
       test      r8d,r8d
       sete      r8b
       movzx     r8d,r8b
       mov       [rbp-38],r8d
       cmp       dword ptr [rbp-38],0
       je        short M01_L04
       nop
       mov       r8,2F28A190008
       mov       [rbp-10],r8
       nop
M01_L04:
       mov       r8d,[rbp+30]
       movzx     r8d,r8b
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-10]
       call      qword ptr [7FF814F749F0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       mov       [rbp-18],rcx
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rdx,[rbp-8]
       mov       r8,7FF81543B3D8
       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r9,[rbp-98]
       mov       rdx,[rbp-18]
       mov       r8,[rbp+18]
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FF81543F450]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       [rbp-0A0],rax
       mov       rdx,[rbp-0A0]
       mov       [rbp-20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,[rbp-20]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF814AC62F8]; System.String.StartsWith(System.String, System.StringComparison)
       mov       [rbp-0A4],eax
       cmp       dword ptr [rbp-0A4],0
       jne       short M01_L05
       mov       rcx,[rbp-20]
       mov       [rbp-0C0],rcx
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp-20]
       mov       [rbp-0B0],rcx
       xor       ecx,ecx
       mov       [rbp-0B4],ecx
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF814AC69E8]; System.String.get_Length()
       mov       [rbp-0B8],eax
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0B4]
       mov       r8d,[rbp-0B8]
       cmp       [rcx],ecx
       call      qword ptr [7FF814AC6EE0]; System.String.Remove(Int32, Int32)
       mov       [rbp-0C0],rax
M01_L06:
       mov       rax,[rbp-0C0]
       mov       [rbp-30],rax
       nop
M01_L07:
       mov       rax,[rbp-30]
       add       rsp,0F0
       pop       rbp
       ret
; Total bytes of code 779
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
       cmp       dword ptr [7FF814E1F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF81545FBA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81547F438]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString03()
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       rcx,[rbx+140]
       mov       rdx,2638C710008
       mov       r8d,3A
       mov       r9,2638C718DF0
       call      qword ptr [7FF814F952D8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,30
       pop       rbx
       jmp       qword ptr [7FF815494840]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 90
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       cmp       dword ptr [7FF814F74F00],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      qword ptr [7FF815494870]; DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-8]
       mov       ecx,[rbp+20]
       mov       [rdx+10],cx
       nop
       xor       edx,edx
       cmp       qword ptr [rbp+10],0
       sete      dl
       mov       [rbp-24],edx
       cmp       dword ptr [rbp-24],0
       je        short M01_L02
       nop
       mov       rdx,2638C710008
       mov       [rbp-30],rdx
       nop
       jmp       near ptr M01_L07
M01_L02:
       mov       rdx,[rbp-8]
       mov       [rbp-48],rdx
       mov       rdx,2638C724210
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2638C710008
       call      qword ptr [7FF814FCC9F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-48]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      System.Object.GetType()
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       rax,[rbp-58]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp-10],rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       [rbp-68],rax
       mov       rcx,[rbp-10]
       mov       [rbp-70],rcx
       mov       rcx,[rbp-68]
       call      qword ptr [7FF814A34ED0]; System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)
       mov       [rbp-78],rax
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-80],rax
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-80]
       mov       r8d,4
       call      qword ptr [7FF814AE61D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       [rbp-84],eax
       mov       r8d,[rbp-84]
       movzx     r8d,r8b
       mov       [rbp-34],r8d
       cmp       dword ptr [rbp-34],0
       je        short M01_L03
       nop
       mov       r8,2638C715FA0
       mov       [rbp-10],r8
       nop
       nop
       jmp       short M01_L04
M01_L03:
       mov       r8d,[rbp+38]
       movzx     r8d,r8b
       test      r8d,r8d
       sete      r8b
       movzx     r8d,r8b
       mov       [rbp-38],r8d
       cmp       dword ptr [rbp-38],0
       je        short M01_L04
       nop
       mov       r8,2638C710008
       mov       [rbp-10],r8
       nop
M01_L04:
       mov       r8d,[rbp+30]
       movzx     r8d,r8b
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-10]
       call      qword ptr [7FF814F952C0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       mov       [rbp-18],rcx
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rdx,[rbp-8]
       mov       r8,7FF815490888
       call      qword ptr [7FF814AE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r9,[rbp-98]
       mov       rdx,[rbp-18]
       mov       r8,[rbp+18]
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FF815494900]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       [rbp-0A0],rax
       mov       rdx,[rbp-0A0]
       mov       [rbp-20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,[rbp-20]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF814AE62F8]; System.String.StartsWith(System.String, System.StringComparison)
       mov       [rbp-0A4],eax
       cmp       dword ptr [rbp-0A4],0
       jne       short M01_L05
       mov       rcx,[rbp-20]
       mov       [rbp-0C0],rcx
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp-20]
       mov       [rbp-0B0],rcx
       xor       ecx,ecx
       mov       [rbp-0B4],ecx
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF814AE69E8]; System.String.get_Length()
       mov       [rbp-0B8],eax
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0B4]
       mov       r8d,[rbp-0B8]
       cmp       [rcx],ecx
       call      qword ptr [7FF814AE6EE0]; System.String.Remove(Int32, Int32)
       mov       [rbp-0C0],rax
M01_L06:
       mov       rax,[rbp-0C0]
       mov       [rbp-30],rax
       nop
M01_L07:
       mov       rax,[rbp-30]
       add       rsp,0F0
       pop       rbp
       ret
; Total bytes of code 779
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
       cmp       dword ptr [7FF814E3F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF8154B5FF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154D4B10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString04()
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],1
       mov       rcx,[rbx+140]
       mov       rdx,267A3340008
       mov       r8d,3A
       mov       r9,267A3348DF0
       call      qword ptr [7FF814FA52D8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,30
       pop       rbx
       jmp       qword ptr [7FF8154A4840]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       cmp       dword ptr [7FF814F84F00],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      qword ptr [7FF8154A4870]; DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-8]
       mov       ecx,[rbp+20]
       mov       [rdx+10],cx
       nop
       xor       edx,edx
       cmp       qword ptr [rbp+10],0
       sete      dl
       mov       [rbp-24],edx
       cmp       dword ptr [rbp-24],0
       je        short M01_L02
       nop
       mov       rdx,267A3340008
       mov       [rbp-30],rdx
       nop
       jmp       near ptr M01_L07
M01_L02:
       mov       rdx,[rbp-8]
       mov       [rbp-48],rdx
       mov       rdx,267A3354210
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       mov       r9,267A3340008
       call      qword ptr [7FF814FDC9F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-48]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      System.Object.GetType()
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       rax,[rbp-58]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp-10],rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       [rbp-68],rax
       mov       rcx,[rbp-10]
       mov       [rbp-70],rcx
       mov       rcx,[rbp-68]
       call      qword ptr [7FF814A44ED0]; System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)
       mov       [rbp-78],rax
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-80],rax
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-80]
       mov       r8d,4
       call      qword ptr [7FF814AF61D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       [rbp-84],eax
       mov       r8d,[rbp-84]
       movzx     r8d,r8b
       mov       [rbp-34],r8d
       cmp       dword ptr [rbp-34],0
       je        short M01_L03
       nop
       mov       r8,267A3345FA0
       mov       [rbp-10],r8
       nop
       nop
       jmp       short M01_L04
M01_L03:
       mov       r8d,[rbp+38]
       movzx     r8d,r8b
       test      r8d,r8d
       sete      r8b
       movzx     r8d,r8b
       mov       [rbp-38],r8d
       cmp       dword ptr [rbp-38],0
       je        short M01_L04
       nop
       mov       r8,267A3340008
       mov       [rbp-10],r8
       nop
M01_L04:
       mov       r8d,[rbp+30]
       movzx     r8d,r8b
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-10]
       call      qword ptr [7FF814FA52C0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       mov       [rbp-18],rcx
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rdx,[rbp-8]
       mov       r8,7FF8154A0888
       call      qword ptr [7FF814AF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r9,[rbp-98]
       mov       rdx,[rbp-18]
       mov       r8,[rbp+18]
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FF8154A4900]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       [rbp-0A0],rax
       mov       rdx,[rbp-0A0]
       mov       [rbp-20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,[rbp-20]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF814AF62F8]; System.String.StartsWith(System.String, System.StringComparison)
       mov       [rbp-0A4],eax
       cmp       dword ptr [rbp-0A4],0
       jne       short M01_L05
       mov       rcx,[rbp-20]
       mov       [rbp-0C0],rcx
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp-20]
       mov       [rbp-0B0],rcx
       xor       ecx,ecx
       mov       [rbp-0B4],ecx
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF814AF69E8]; System.String.get_Length()
       mov       [rbp-0B8],eax
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0B4]
       mov       r8d,[rbp-0B8]
       cmp       [rcx],ecx
       call      qword ptr [7FF814AF6EE0]; System.String.Remove(Int32, Int32)
       mov       [rbp-0C0],rax
M01_L06:
       mov       rax,[rbp-0C0]
       mov       [rbp-30],rax
       nop
M01_L07:
       mov       rax,[rbp-30]
       add       rsp,0F0
       pop       rbp
       ret
; Total bytes of code 779
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
       cmp       dword ptr [7FF814E4F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF8154CBE38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154E4B10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.StripNull()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       call      qword ptr [7FF814FA52F0]; DotNetTips.Spargine.Extensions.ObjectExtensions.StripNull(System.Object)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF8154A4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.StripNull(System.Object)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814F84F00],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       cmp       qword ptr [rbp+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-18],rax
       mov       rax,[rbp-18]
       mov       [rbp-10],rax
       jmp       short M01_L02
M01_L01:
       mov       rax,1EC14100008
       mov       [rbp-10],rax
M01_L02:
       mov       rax,[rbp-10]
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 103
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
       cmp       dword ptr [7FF814E4F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF8154C9190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154E4B10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.TestingForNull01()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Object, System.Private.CoreLib]](System.Object)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815474840]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 50
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
       cmp       dword ptr [7FF814E1F390],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF81542EC38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF815474870]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.TestingForNull02()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Object, System.Private.CoreLib]](System.Object)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF8154740A8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 50
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
       cmp       dword ptr [7FF814E1F390],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF815455E50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154740D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson03()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+130]
       call      qword ptr [7FF814F94C30]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF814F65320]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object, System.Text.Json.JsonSerializerOptions)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF81534DC50]; DotNetTips.Spargine.Core.SimpleResult`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF81534DC80]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 73
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_Default()
       sub       rsp,28
       mov       rax,1D7C4C0C5B0
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L01
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FF814F951D0]; System.Text.Json.JsonSerializerOptions.GetOrCreateDefaultOptionsInstance()
       jmp       short M01_L00
; Total bytes of code 35
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object, System.Text.Json.JsonSerializerOptions)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-48],rsp
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F44F00],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       rdx,21856982730
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
       xor       r8d,r8d
       mov       r9,21856980008
       call      qword ptr [7FF814F9C9F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       r8,[rbp-18]
       mov       [rbp+10],r8
       nop
       mov       r8,[rbp+18]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.Serialize[[System.Object, System.Private.CoreLib]](System.Object, System.Text.Json.JsonSerializerOptions)
       call      qword ptr [7FF8151E5950]; System.Text.Json.JsonSerializer.Serialize[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Text.Json.JsonSerializerOptions)
       mov       [rbp-20],rax
       mov       rdx,[rbp-20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.SimpleResult.FromValue[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FF81534DCF8]; DotNetTips.Spargine.Core.SimpleResult.FromValue[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       [rbp-28],rax
       mov       rax,[rbp-28]
       mov       [rbp-8],rax
       nop
M02_L01:
       mov       rax,[rbp-8]
       add       rsp,70
       pop       rbp
       ret
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+70]
       mov       [rbp-30],rdx
       mov       rdx,[rbp-30]
       mov       [rbp-10],rdx
       nop
       mov       rdx,[rbp-10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.SimpleResult.FromException[[System.String, System.Private.CoreLib]](System.Exception)
       call      qword ptr [7FF81534DD28]
       mov       [rbp-38],rax
       mov       rax,[rbp-38]
       mov       [rbp-8],rax
       nop
       lea       rax,[M02_L01]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 271
```
```assembly
; DotNetTips.Spargine.Core.SimpleResult`1[[System.__Canon, System.Private.CoreLib]].get_Value()
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
       cmp       dword ptr [7FF814E20B30],0
       cmp       dword ptr [7FF814E20B30],0
       je        short M03_L00
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rax,[rbp+10]
M03_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+10]
       mov       rax,[rax+10]
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
       cmp       dword ptr [7FF814E0F390],0
       je        short M04_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M04_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF8153615A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M04_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81534F1F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson01()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       call      qword ptr [7FF814F75308]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815474840]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814F54F00],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rdx,21781332730
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
       xor       r8d,r8d
       mov       r9,21781330008
       call      qword ptr [7FF814FAC9F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-10],rax
       mov       rcx,7FF814F553E8
       mov       edx,1F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       r8,1D6EF40BAA8
       mov       r8,[r8]
       mov       [rbp-20],r8
       mov       r8,[rbp-20]
       mov       rdx,[rbp-10]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.Serialize[[System.Object, System.Private.CoreLib]](System.Object, System.Text.Json.JsonSerializerOptions)
       call      qword ptr [7FF8151F5C20]; System.Text.Json.JsonSerializer.Serialize[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Text.Json.JsonSerializerOptions)
       mov       [rbp-18],rax
       mov       rax,[rbp-18]
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 172
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
       cmp       dword ptr [7FF814E1F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF815459090
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF815474870]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson02()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+140]
       call      qword ptr [7FF814F65308]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815464840]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814F44F00],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rdx,2780B8D2730
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2780B8D0008
       call      qword ptr [7FF814F9C9F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-10],rax
       mov       rcx,7FF814F453E8
       mov       edx,1F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       r8,23779C0BAA8
       mov       r8,[r8]
       mov       [rbp-20],r8
       mov       r8,[rbp-20]
       mov       rdx,[rbp-10]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.Serialize[[System.Object, System.Private.CoreLib]](System.Object, System.Text.Json.JsonSerializerOptions)
       call      qword ptr [7FF8151E58F0]; System.Text.Json.JsonSerializer.Serialize[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Text.Json.JsonSerializerOptions)
       mov       [rbp-18],rax
       mov       rax,[rbp-18]
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 172
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
       cmp       dword ptr [7FF814E0F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF815480BF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF815466610]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.TryDispose()
       push      rbx
       sub       rsp,20
       mov       rcx,offset MT_System.Data.DataTable
       call      CORINFO_HELP_NEWFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF815476040]; System.Data.DataTable..ctor()
       mov       rcx,23280D74230
       mov       [rbx+70],rcx
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF814F75350]; DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable)
; Total bytes of code 60
```
```assembly
; System.Data.DataTable..ctor()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       lea       rcx,[rbx+70]
       mov       rsi,23280D60008
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+80]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+1C4],1
       mov       dword ptr [rbx+1B0],19
       mov       rcx,23280D742D0
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1D8],xmm0
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1E8],xmm0
       mov       rcx,23280D743A8
       mov       [rbx+0D8],rcx
       mov       byte ptr [rbx+1CC],1
       mov       rcx,23280D743C0
       mov       [rbx+110],rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataView, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,23280D743D8
       mov       [rax+8],rcx
       lea       rcx,[rbx+180]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataViewListener, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,23280D743F0
       mov       [rax+8],rcx
       lea       rcx,[rbx+188]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.ReaderWriterLockSlim
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+40],0FFFFFFFF
       mov       dword ptr [rax+44],0FFFFFFFF
       mov       byte ptr [rax+4D],1
       mov       rcx,7FF814A05C48
       mov       edx,1
       lock xadd [rcx],rdx
       inc       rdx
       mov       [rax+28],rdx
       lea       rcx,[rbx+198]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+1B8],0FFFFFFFF
       mov       rcx,7FF815482C80
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rbx+1C0],eax
       mov       rcx,rbx
       call      qword ptr [7FF814D4C2E8]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,1F1F2C0D218
       mov       rcx,[rcx]
       mov       rsi,rcx
       mov       edi,[rbx+1C0]
       cmp       byte ptr [rcx+9D],0
       je        short M01_L00
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       [rsp+38],rax
       lea       r8,[rsp+38]
       mov       [rsp+28],r8
       mov       dword ptr [rsp+30],1
       lea       r8,[rsp+28]
       xor       ecx,ecx
       mov       rdx,23280D74250
       call      qword ptr [7FF814AC6C88]
       mov       r8,rax
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FF814B776D8]
M01_L00:
       mov       qword ptr [rbx+1A0],1
       mov       rcx,offset MT_System.Data.RecordManager
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF81547E5E0]; System.Data.RecordManager..ctor(System.Data.DataTable)
       lea       rcx,[rbx+50]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF814CA4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       lea       rcx,[rbx+90]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataColumnCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF81547C9A8]; System.Data.DataColumnCollection..ctor(System.Data.DataTable)
       lea       rcx,[rbx+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.ConstraintCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Collections.ArrayList
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,23280D6C760
       mov       [rax+8],rcx
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+28],1
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+38]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataRowCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Data.DataRowCollection+DataRowTree
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+30],2
       mov       rcx,rdi
       call      qword ptr [7FF81547D728]; System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].InitTree()
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.Index, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,23280D74480
       mov       [rax+8],rcx
       lea       rcx,[rbx+58]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataRowBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+10],0FFFFFFFF
       lea       rcx,[rbx+178]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 876
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814F54F00],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rdx,23280D62730
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.IDisposable, System.Private.CoreLib]](System.IDisposable, System.IDisposable, System.String, System.String)
       xor       r8d,r8d
       mov       r9,23280D60008
       call      qword ptr [7FF814FAC9F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       xor       edx,edx
       call      qword ptr [7FF814F75368]; DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 108
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.FromJson()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+128]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.String)
       call      qword ptr [7FF815474840]; DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815474870]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-28],rax
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F54F00],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,1E251FC4210
       mov       [rsp+20],rcx
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,1E251FB0008
       call      qword ptr [7FF814FAC7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF81543D868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L02:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-18]
       call      qword ptr [7FF815474948]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rbp-28],rax
       mov       rax,[rbp-28]
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 179
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
       cmp       dword ptr [7FF814E1F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF81543DF78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF815474A98]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

