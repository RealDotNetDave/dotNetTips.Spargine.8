## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.Remove_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1BF38001FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61CFDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbx+280]
       mov       edx,[rdi+10]
       mov       [rsp+20],edx
       mov       rdx,[rdi+8]
       mov       rcx,7FFE6269E5F8
       xor       r9d,r9d
       call      qword ptr [7FFE626AC1B0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rdi
       mov       edx,eax
       call      qword ptr [7FFE61D4DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
M00_L00:
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 171
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE628517C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C44348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62851808
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623D0310
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62851820
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623D0300
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE628517D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE628517F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61CFE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B010D8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F45B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623D0300
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B010E0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 687
```
```assembly
; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       ebp,[rsp+80]
       test      rsi,rsi
       je        near ptr M02_L09
       mov       r14d,[rsi+8]
       cmp       r14d,ebx
       jb        near ptr M02_L10
       mov       edx,r14d
       sub       edx,ebx
       cmp       edx,ebp
       jb        near ptr M02_L11
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M02_L04
M02_L00:
       mov       rcx,rdx
       call      qword ptr [7FFE61C4FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       cmp       [rax],rcx
       jne       near ptr M02_L16
       add       ebp,ebx
       test      rdi,rdi
       je        near ptr M02_L12
       cmp       ebx,ebp
       jge       short M02_L03
       mov       ecx,ebx
       or        ecx,ebp
       jl        short M02_L06
       cmp       r14d,ebp
       jl        short M02_L06
M02_L01:
       mov       ecx,ebx
       mov       rcx,[rsi+rcx*8+10]
       test      rcx,rcx
       je        short M02_L02
       mov       rdx,rdi
       mov       r11,7FFE61B010E8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L05
M02_L02:
       inc       ebx
       cmp       ebx,ebp
       jl        short M02_L01
M02_L03:
       mov       eax,0FFFFFFFF
       jmp       short M02_L08
M02_L04:
       mov       rdx,7FFE62851DC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M02_L00
M02_L05:
       mov       eax,ebx
       jmp       short M02_L08
M02_L06:
       cmp       ebx,r14d
       jae       near ptr M02_L17
       mov       ecx,ebx
       mov       rcx,[rsi+rcx*8+10]
       test      rcx,rcx
       je        short M02_L07
       mov       rdx,rdi
       mov       r11,7FFE61B010E8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L05
M02_L07:
       inc       ebx
       cmp       ebx,ebp
       jl        short M02_L06
       jmp       short M02_L03
M02_L08:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L09:
       mov       ecx,2
       call      qword ptr [7FFE61F45B18]
       int       3
M02_L10:
       call      qword ptr [7FFE61F45908]
       int       3
M02_L11:
       call      qword ptr [7FFE61F45938]
       int       3
M02_L12:
       mov       eax,ebx
       jmp       short M02_L15
M02_L13:
       cmp       eax,r14d
       jae       short M02_L17
       mov       ecx,eax
       cmp       qword ptr [rsi+rcx*8+10],0
       jne       short M02_L14
       jmp       short M02_L08
M02_L14:
       inc       eax
M02_L15:
       cmp       eax,ebp
       jl        short M02_L13
       jmp       near ptr M02_L03
M02_L16:
       mov       [rsp+20],ebp
       mov       rcx,rax
       mov       rdx,rsi
       mov       r8,rdi
       mov       r9d,ebx
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L08
M02_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 353
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M03_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M03_L02
M03_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M03_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M03_L01:
       call      qword ptr [7FFE61F45878]
       int       3
M03_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61B97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.Remove_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1425D001FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61D0DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbx+280]
       mov       edx,[rdi+10]
       mov       [rsp+20],edx
       mov       rdx,[rdi+8]
       mov       rcx,7FFE626AEA88
       xor       r9d,r9d
       call      qword ptr [7FFE626BC498]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rdi
       mov       edx,eax
       call      qword ptr [7FFE61D5DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
M00_L00:
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 171
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62865450
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62865490
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623E0340
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE628654A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623E0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62865460
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62865478
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61D0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B110D8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F55B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623E0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B110E0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 687
```
```assembly
; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       esi,r9d
       mov       ebp,[rsp+80]
       test      rbx,rbx
       je        near ptr M02_L09
       mov       r14d,[rbx+8]
       cmp       r14d,esi
       jb        near ptr M02_L10
       mov       edx,r14d
       sub       edx,esi
       cmp       edx,ebp
       jb        near ptr M02_L11
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M02_L04
M02_L00:
       mov       rcx,rdx
       call      qword ptr [7FFE61C5FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       cmp       [rax],rcx
       jne       near ptr M02_L16
       add       ebp,esi
       test      rdi,rdi
       je        near ptr M02_L12
       cmp       esi,ebp
       jge       short M02_L03
       mov       ecx,esi
       or        ecx,ebp
       jl        short M02_L06
       cmp       r14d,ebp
       jl        short M02_L06
M02_L01:
       mov       ecx,esi
       mov       rcx,[rbx+rcx*8+10]
       test      rcx,rcx
       je        short M02_L02
       mov       rdx,rdi
       mov       r11,7FFE61B110E8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L05
M02_L02:
       inc       esi
       cmp       esi,ebp
       jl        short M02_L01
M02_L03:
       mov       eax,0FFFFFFFF
       jmp       short M02_L08
M02_L04:
       mov       rdx,7FFE62865A50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M02_L00
M02_L05:
       mov       eax,esi
       jmp       short M02_L08
M02_L06:
       cmp       esi,r14d
       jae       near ptr M02_L17
       mov       ecx,esi
       mov       rcx,[rbx+rcx*8+10]
       test      rcx,rcx
       je        short M02_L07
       mov       rdx,rdi
       mov       r11,7FFE61B110E8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L05
M02_L07:
       inc       esi
       cmp       esi,ebp
       jl        short M02_L06
       jmp       short M02_L03
M02_L08:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L09:
       mov       ecx,2
       call      qword ptr [7FFE61F55B18]
       int       3
M02_L10:
       call      qword ptr [7FFE61F55908]
       int       3
M02_L11:
       call      qword ptr [7FFE61F55938]
       int       3
M02_L12:
       mov       eax,esi
       jmp       short M02_L15
M02_L13:
       cmp       eax,r14d
       jae       short M02_L17
       mov       ecx,eax
       cmp       qword ptr [rbx+rcx*8+10],0
       jne       short M02_L14
       jmp       short M02_L08
M02_L14:
       inc       eax
M02_L15:
       cmp       eax,ebp
       jl        short M02_L13
       jmp       near ptr M02_L03
M02_L16:
       mov       [rsp+20],ebp
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,rdi
       mov       r9d,esi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L08
M02_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 353
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M03_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M03_L02
M03_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M03_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M03_L01:
       call      qword ptr [7FFE61F55878]
       int       3
M03_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61BA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.Remove_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1FAEFC01FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61D0DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbx+280]
       mov       edx,[rdi+10]
       mov       [rsp+20],edx
       mov       rdx,[rdi+8]
       mov       rcx,7FFE626AEA88
       xor       r9d,r9d
       call      qword ptr [7FFE626BC498]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rdi
       mov       edx,eax
       call      qword ptr [7FFE61D5DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
M00_L00:
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 171
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE628666F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62866730
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623E0310
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62866748
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623E0300
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62866700
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62866718
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61D0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B110D8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F55B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623E0300
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B110E0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 687
```
```assembly
; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       esi,r9d
       mov       ebp,[rsp+80]
       test      rbx,rbx
       je        near ptr M02_L09
       mov       r14d,[rbx+8]
       cmp       r14d,esi
       jb        near ptr M02_L10
       mov       edx,r14d
       sub       edx,esi
       cmp       edx,ebp
       jb        near ptr M02_L11
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M02_L04
M02_L00:
       mov       rcx,rdx
       call      qword ptr [7FFE61C5FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       cmp       [rax],rcx
       jne       near ptr M02_L16
       add       ebp,esi
       test      rdi,rdi
       je        near ptr M02_L12
       cmp       esi,ebp
       jge       short M02_L03
       mov       ecx,esi
       or        ecx,ebp
       jl        short M02_L06
       cmp       r14d,ebp
       jl        short M02_L06
M02_L01:
       mov       ecx,esi
       mov       rcx,[rbx+rcx*8+10]
       test      rcx,rcx
       je        short M02_L02
       mov       rdx,rdi
       mov       r11,7FFE61B110E8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L05
M02_L02:
       inc       esi
       cmp       esi,ebp
       jl        short M02_L01
M02_L03:
       mov       eax,0FFFFFFFF
       jmp       short M02_L08
M02_L04:
       mov       rdx,7FFE62866CF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M02_L00
M02_L05:
       mov       eax,esi
       jmp       short M02_L08
M02_L06:
       cmp       esi,r14d
       jae       near ptr M02_L17
       mov       ecx,esi
       mov       rcx,[rbx+rcx*8+10]
       test      rcx,rcx
       je        short M02_L07
       mov       rdx,rdi
       mov       r11,7FFE61B110E8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L05
M02_L07:
       inc       esi
       cmp       esi,ebp
       jl        short M02_L06
       jmp       short M02_L03
M02_L08:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L09:
       mov       ecx,2
       call      qword ptr [7FFE61F55B18]
       int       3
M02_L10:
       call      qword ptr [7FFE61F55908]
       int       3
M02_L11:
       call      qword ptr [7FFE61F55938]
       int       3
M02_L12:
       mov       eax,esi
       jmp       short M02_L15
M02_L13:
       cmp       eax,r14d
       jae       short M02_L17
       mov       ecx,eax
       cmp       qword ptr [rbx+rcx*8+10],0
       jne       short M02_L14
       jmp       short M02_L08
M02_L14:
       inc       eax
M02_L15:
       cmp       eax,ebp
       jl        short M02_L13
       jmp       near ptr M02_L03
M02_L16:
       mov       [rsp+20],ebp
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,rdi
       mov       r9d,esi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L08
M02_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 353
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M03_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M03_L02
M03_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M03_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M03_L01:
       call      qword ptr [7FFE61F55878]
       int       3
M03_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61BA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.Remove_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,24491801FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61D0DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbx+280]
       mov       edx,[rdi+10]
       mov       [rsp+20],edx
       mov       rdx,[rdi+8]
       mov       rcx,7FFE626AEA88
       xor       r9d,r9d
       call      qword ptr [7FFE626BC498]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rdi
       mov       edx,eax
       call      qword ptr [7FFE61D5DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
M00_L00:
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 171
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62866500
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62866540
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623E0340
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62866558
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623E0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62866510
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62866528
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61D0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B110D8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F55B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623E0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B110E0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 687
```
```assembly
; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       esi,r9d
       mov       ebp,[rsp+80]
       test      rbx,rbx
       je        near ptr M02_L09
       mov       r14d,[rbx+8]
       cmp       r14d,esi
       jb        near ptr M02_L10
       mov       edx,r14d
       sub       edx,esi
       cmp       edx,ebp
       jb        near ptr M02_L11
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M02_L04
M02_L00:
       mov       rcx,rdx
       call      qword ptr [7FFE61C5FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       cmp       [rax],rcx
       jne       near ptr M02_L16
       add       ebp,esi
       test      rdi,rdi
       je        near ptr M02_L12
       cmp       esi,ebp
       jge       short M02_L03
       mov       ecx,esi
       or        ecx,ebp
       jl        short M02_L06
       cmp       r14d,ebp
       jl        short M02_L06
M02_L01:
       mov       ecx,esi
       mov       rcx,[rbx+rcx*8+10]
       test      rcx,rcx
       je        short M02_L02
       mov       rdx,rdi
       mov       r11,7FFE61B110E8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L05
M02_L02:
       inc       esi
       cmp       esi,ebp
       jl        short M02_L01
M02_L03:
       mov       eax,0FFFFFFFF
       jmp       short M02_L08
M02_L04:
       mov       rdx,7FFE62866B00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M02_L00
M02_L05:
       mov       eax,esi
       jmp       short M02_L08
M02_L06:
       cmp       esi,r14d
       jae       near ptr M02_L17
       mov       ecx,esi
       mov       rcx,[rbx+rcx*8+10]
       test      rcx,rcx
       je        short M02_L07
       mov       rdx,rdi
       mov       r11,7FFE61B110E8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L05
M02_L07:
       inc       esi
       cmp       esi,ebp
       jl        short M02_L06
       jmp       short M02_L03
M02_L08:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L09:
       mov       ecx,2
       call      qword ptr [7FFE61F55B18]
       int       3
M02_L10:
       call      qword ptr [7FFE61F55908]
       int       3
M02_L11:
       call      qword ptr [7FFE61F55938]
       int       3
M02_L12:
       mov       eax,esi
       jmp       short M02_L15
M02_L13:
       cmp       eax,r14d
       jae       short M02_L17
       mov       ecx,eax
       cmp       qword ptr [rbx+rcx*8+10],0
       jne       short M02_L14
       jmp       short M02_L08
M02_L14:
       inc       eax
M02_L15:
       cmp       eax,ebp
       jl        short M02_L13
       jmp       near ptr M02_L03
M02_L16:
       mov       [rsp+20],ebp
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,rdi
       mov       r9d,esi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L08
M02_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 353
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M03_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M03_L02
M03_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M03_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M03_L01:
       call      qword ptr [7FFE61F55878]
       int       3
M03_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61BA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.Remove_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,23DAF001FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61D0DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbx+280]
       mov       edx,[rdi+10]
       mov       [rsp+20],edx
       mov       rdx,[rdi+8]
       mov       rcx,7FFE626C3010
       xor       r9d,r9d
       call      qword ptr [7FFE626BDDA0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rdi
       mov       edx,eax
       call      qword ptr [7FFE61D5DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
M00_L00:
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 171
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62867AB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62867AF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623E0340
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62867B08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623E0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62867AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62867AD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61D0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B110D8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F55B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623E0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B110E0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 687
```
```assembly
; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       esi,r9d
       mov       ebp,[rsp+80]
       test      rbx,rbx
       je        near ptr M02_L13
       mov       r14d,[rbx+8]
       cmp       r14d,esi
       jb        near ptr M02_L14
       mov       edx,r14d
       sub       edx,esi
       cmp       edx,ebp
       jb        near ptr M02_L15
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M02_L08
M02_L00:
       mov       rcx,rdx
       call      qword ptr [7FFE61C5FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       cmp       [rax],rcx
       jne       near ptr M02_L12
       add       ebp,esi
       test      rdi,rdi
       je        near ptr M02_L16
       cmp       esi,ebp
       jge       short M02_L03
       mov       ecx,esi
       or        ecx,ebp
       jl        short M02_L06
       cmp       r14d,ebp
       jl        short M02_L06
M02_L01:
       mov       ecx,esi
       mov       rcx,[rbx+rcx*8+10]
       test      rcx,rcx
       je        short M02_L02
       mov       rdx,rdi
       mov       r11,7FFE61B110E8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L05
M02_L02:
       inc       esi
       cmp       esi,ebp
       jl        short M02_L01
M02_L03:
       mov       eax,0FFFFFFFF
M02_L04:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L05:
       mov       eax,esi
       jmp       short M02_L04
M02_L06:
       cmp       esi,r14d
       jae       near ptr M02_L17
       mov       ecx,esi
       mov       rcx,[rbx+rcx*8+10]
       test      rcx,rcx
       je        short M02_L07
       mov       rdx,rdi
       mov       r11,7FFE61B110E8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L05
M02_L07:
       inc       esi
       cmp       esi,ebp
       jl        short M02_L06
       jmp       short M02_L03
M02_L08:
       mov       rdx,7FFE628680B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L00
M02_L09:
       cmp       eax,r14d
       jae       short M02_L17
       mov       ecx,eax
       cmp       qword ptr [rbx+rcx*8+10],0
       jne       short M02_L10
       jmp       short M02_L04
M02_L10:
       inc       eax
M02_L11:
       cmp       eax,ebp
       jl        short M02_L09
       jmp       short M02_L03
M02_L12:
       mov       [rsp+20],ebp
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,rdi
       mov       r9d,esi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       near ptr M02_L04
M02_L13:
       mov       ecx,2
       call      qword ptr [7FFE61F55B18]
       int       3
M02_L14:
       call      qword ptr [7FFE61F55908]
       int       3
M02_L15:
       call      qword ptr [7FFE61F55938]
       int       3
M02_L16:
       mov       eax,esi
       jmp       short M02_L11
M02_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 358
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M03_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M03_L02
M03_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M03_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M03_L01:
       call      qword ptr [7FFE61F55878]
       int       3
M03_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61BA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.Remove_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,24EAA401FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61CFDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbx+280]
       mov       edx,[rdi+10]
       mov       [rsp+20],edx
       mov       rdx,[rdi+8]
       mov       rcx,7FFE626B3010
       xor       r9d,r9d
       call      qword ptr [7FFE626ADDA0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rdi
       mov       edx,eax
       call      qword ptr [7FFE61D4DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
M00_L00:
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 171
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62858448
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C44348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62858488
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE6236F4D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE628584A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE6236F4C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62858458
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62858470
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61CFE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B010E0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F45B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE6236F4C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B010E8
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 687
```
```assembly
; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       esi,r9d
       mov       ebp,[rsp+80]
       test      rbx,rbx
       je        near ptr M02_L09
       mov       r14d,[rbx+8]
       cmp       r14d,esi
       jb        near ptr M02_L10
       mov       edx,r14d
       sub       edx,esi
       cmp       edx,ebp
       jb        near ptr M02_L11
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M02_L04
M02_L00:
       mov       rcx,rdx
       call      qword ptr [7FFE61C4FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       cmp       [rax],rcx
       jne       near ptr M02_L16
       add       ebp,esi
       test      rdi,rdi
       je        near ptr M02_L12
       cmp       esi,ebp
       jge       short M02_L03
       mov       ecx,esi
       or        ecx,ebp
       jl        short M02_L06
       cmp       r14d,ebp
       jl        short M02_L06
M02_L01:
       mov       ecx,esi
       mov       rcx,[rbx+rcx*8+10]
       test      rcx,rcx
       je        short M02_L02
       mov       rdx,rdi
       mov       r11,7FFE61B010F0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L05
M02_L02:
       inc       esi
       cmp       esi,ebp
       jl        short M02_L01
M02_L03:
       mov       eax,0FFFFFFFF
       jmp       short M02_L08
M02_L04:
       mov       rdx,7FFE62858A48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M02_L00
M02_L05:
       mov       eax,esi
       jmp       short M02_L08
M02_L06:
       cmp       esi,r14d
       jae       near ptr M02_L17
       mov       ecx,esi
       mov       rcx,[rbx+rcx*8+10]
       test      rcx,rcx
       je        short M02_L07
       mov       rdx,rdi
       mov       r11,7FFE61B010F0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L05
M02_L07:
       inc       esi
       cmp       esi,ebp
       jl        short M02_L06
       jmp       short M02_L03
M02_L08:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L09:
       mov       ecx,2
       call      qword ptr [7FFE61F45B18]
       int       3
M02_L10:
       call      qword ptr [7FFE61F45908]
       int       3
M02_L11:
       call      qword ptr [7FFE61F45938]
       int       3
M02_L12:
       mov       eax,esi
       jmp       short M02_L15
M02_L13:
       cmp       eax,r14d
       jae       short M02_L17
       mov       ecx,eax
       cmp       qword ptr [rbx+rcx*8+10],0
       jne       short M02_L14
       jmp       short M02_L08
M02_L14:
       inc       eax
M02_L15:
       cmp       eax,ebp
       jl        short M02_L13
       jmp       near ptr M02_L03
M02_L16:
       mov       [rsp+20],ebp
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,rdi
       mov       r9d,esi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L08
M02_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 353
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M03_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M03_L02
M03_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M03_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M03_L01:
       call      qword ptr [7FFE61F45878]
       int       3
M03_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61B97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.Remove_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,22CBD001FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61CFDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbx+280]
       mov       edx,[rdi+10]
       mov       [rsp+20],edx
       mov       rdx,[rdi+8]
       mov       rcx,7FFE626B3010
       xor       r9d,r9d
       call      qword ptr [7FFE626ADDA0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rdi
       mov       edx,eax
       call      qword ptr [7FFE61D4DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
M00_L00:
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 171
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62858978
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C44348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE628589B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE6236D0A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE628589D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE6236D090
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62858988
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE628589A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61CFE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B010D8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F45B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE6236D090
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B010E0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 687
```
```assembly
; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       esi,r9d
       mov       ebp,[rsp+80]
       test      rbx,rbx
       je        near ptr M02_L09
       mov       r14d,[rbx+8]
       cmp       r14d,esi
       jb        near ptr M02_L10
       mov       edx,r14d
       sub       edx,esi
       cmp       edx,ebp
       jb        near ptr M02_L11
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M02_L04
M02_L00:
       mov       rcx,rdx
       call      qword ptr [7FFE61C4FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       cmp       [rax],rcx
       jne       near ptr M02_L16
       add       ebp,esi
       test      rdi,rdi
       je        near ptr M02_L12
       cmp       esi,ebp
       jge       short M02_L03
       mov       ecx,esi
       or        ecx,ebp
       jl        short M02_L05
       cmp       r14d,ebp
       jl        short M02_L05
M02_L01:
       mov       ecx,esi
       mov       rcx,[rbx+rcx*8+10]
       test      rcx,rcx
       je        short M02_L02
       mov       rdx,rdi
       mov       r11,7FFE61B010E8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L07
M02_L02:
       inc       esi
       cmp       esi,ebp
       jl        short M02_L01
M02_L03:
       mov       eax,0FFFFFFFF
       jmp       short M02_L08
M02_L04:
       mov       rdx,7FFE62858F78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M02_L00
M02_L05:
       cmp       esi,r14d
       jae       near ptr M02_L17
       mov       ecx,esi
       mov       rcx,[rbx+rcx*8+10]
       test      rcx,rcx
       je        short M02_L06
       mov       rdx,rdi
       mov       r11,7FFE61B010E8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L07
M02_L06:
       inc       esi
       cmp       esi,ebp
       jl        short M02_L05
       jmp       short M02_L03
M02_L07:
       mov       eax,esi
M02_L08:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L09:
       mov       ecx,2
       call      qword ptr [7FFE61F45B18]
       int       3
M02_L10:
       call      qword ptr [7FFE61F45908]
       int       3
M02_L11:
       call      qword ptr [7FFE61F45938]
       int       3
M02_L12:
       mov       eax,esi
       jmp       short M02_L15
M02_L13:
       cmp       eax,r14d
       jae       short M02_L17
       mov       ecx,eax
       cmp       qword ptr [rbx+rcx*8+10],0
       jne       short M02_L14
       jmp       short M02_L08
M02_L14:
       inc       eax
M02_L15:
       cmp       eax,ebp
       jl        short M02_L13
       jmp       near ptr M02_L03
M02_L16:
       mov       [rsp+20],ebp
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,rdi
       mov       r9d,esi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L08
M02_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 351
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M03_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M03_L02
M03_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M03_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M03_L01:
       call      qword ptr [7FFE61F45878]
       int       3
M03_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61B97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.Remove_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,20887401FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61CEDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbx+280]
       mov       edx,[rdi+10]
       mov       [rsp+20],edx
       mov       rdx,[rdi+8]
       mov       rcx,7FFE626A3010
       xor       r9d,r9d
       call      qword ptr [7FFE6269DDA0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rdi
       mov       edx,eax
       call      qword ptr [7FFE61D3DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
M00_L00:
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 171
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62847D58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C34348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62847D98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE6235CB90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62847DB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE6235CB80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62847D68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62847D80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61CEE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AF10D8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F35B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE6235CB80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AF10E0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 687
```
```assembly
; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       esi,r9d
       mov       ebp,[rsp+80]
       test      rbx,rbx
       je        near ptr M02_L09
       mov       r14d,[rbx+8]
       cmp       r14d,esi
       jb        near ptr M02_L10
       mov       edx,r14d
       sub       edx,esi
       cmp       edx,ebp
       jb        near ptr M02_L11
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M02_L04
M02_L00:
       mov       rcx,rdx
       call      qword ptr [7FFE61C3FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       cmp       [rax],rcx
       jne       near ptr M02_L16
       add       ebp,esi
       test      rdi,rdi
       je        near ptr M02_L12
       cmp       esi,ebp
       jge       short M02_L03
       mov       ecx,esi
       or        ecx,ebp
       jl        short M02_L05
       cmp       r14d,ebp
       jl        short M02_L05
M02_L01:
       mov       ecx,esi
       mov       rcx,[rbx+rcx*8+10]
       test      rcx,rcx
       je        short M02_L02
       mov       rdx,rdi
       mov       r11,7FFE61AF10E8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L07
M02_L02:
       inc       esi
       cmp       esi,ebp
       jl        short M02_L01
M02_L03:
       mov       eax,0FFFFFFFF
       jmp       short M02_L08
M02_L04:
       mov       rdx,7FFE62848358
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M02_L00
M02_L05:
       cmp       esi,r14d
       jae       near ptr M02_L17
       mov       ecx,esi
       mov       rcx,[rbx+rcx*8+10]
       test      rcx,rcx
       je        short M02_L06
       mov       rdx,rdi
       mov       r11,7FFE61AF10E8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L07
M02_L06:
       inc       esi
       cmp       esi,ebp
       jl        short M02_L05
       jmp       short M02_L03
M02_L07:
       mov       eax,esi
M02_L08:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L09:
       mov       ecx,2
       call      qword ptr [7FFE61F35B18]
       int       3
M02_L10:
       call      qword ptr [7FFE61F35908]
       int       3
M02_L11:
       call      qword ptr [7FFE61F35938]
       int       3
M02_L12:
       mov       eax,esi
       jmp       short M02_L15
M02_L13:
       cmp       eax,r14d
       jae       short M02_L17
       mov       ecx,eax
       cmp       qword ptr [rbx+rcx*8+10],0
       jne       short M02_L14
       jmp       short M02_L08
M02_L14:
       inc       eax
M02_L15:
       cmp       eax,ebp
       jl        short M02_L13
       jmp       near ptr M02_L03
M02_L16:
       mov       [rsp+20],ebp
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,rdi
       mov       r9d,esi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L08
M02_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 351
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M03_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M03_L02
M03_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M03_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M03_L01:
       call      qword ptr [7FFE61F35878]
       int       3
M03_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61B87750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.Remove_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+290]
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE62624078]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rbx+2A0]
       mov       rdx,[rcx+28]
       mov       rcx,rsi
       call      qword ptr [7FFE62624480]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].IndexOfKey(System.__Canon)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rsi
       mov       edx,eax
       call      qword ptr [7FFE626244E0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
M00_L00:
       mov       eax,[rsi+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 98
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       rcx,rbx
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+0A8]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62852280
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E0]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE62852810
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6207E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E8]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE62852848
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6207E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0F0]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE62852900
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61E8E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M01_L08
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rbx
       mov       edx,r15d
       call      qword ptr [7FFE62624108]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        near ptr M01_L21
       mov       r14,[rbx+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0B0]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE628522A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0B8]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE628522B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0C0]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE62852420
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0C8]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE62852438
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rbx+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       esi,1
       jle       near ptr M01_L21
       mov       rcx,[rbx+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0D0]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE628525D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rbx+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE62627AE0]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0D8]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE628525F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rbx+30],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE623BC870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623BC7B0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE61C4F708]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F353F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DD66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 880
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].IndexOfKey(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+118]
       test      rax,rax
       je        short M02_L00
       mov       rcx,rax
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFE62854848
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rsi
       mov       rdx,[rbx+18]
       mov       [rsp+28],rdx
       mov       rdx,[rbx+8]
       mov       r9d,[rbx+30]
       xor       r8d,r8d
       call      qword ptr [7FFE626ACB58]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       ecx,0FFFFFFFF
       test      eax,eax
       cmovl     eax,ecx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       ecx,899
       mov       rdx,7FFE61F353F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE61DD6790]
       int       3
; Total bytes of code 145
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M03_L01
       mov       eax,[rbx+30]
       cmp       esi,eax
       jge       short M03_L01
       dec       eax
       mov       [rbx+30],eax
       cmp       esi,eax
       jl        near ptr M03_L02
M03_L00:
       mov       rcx,[rbx+8]
       movsxd    rax,dword ptr [rbx+30]
       mov       rdx,rax
       mov       r8d,[rcx+8]
       cmp       rdx,r8
       jae       near ptr M03_L03
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       rcx,[rbx+10]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M03_L03
       mov       [rcx+rax*8+10],r8
       inc       dword ptr [rbx+34]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L01:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,7CB
       mov       rdx,7FFE61F353F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFE623BC9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFE61CFD4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61B97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61B97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.Remove_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+290]
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE62644078]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rbx+2A0]
       mov       rdx,[rcx+28]
       mov       rcx,rsi
       call      qword ptr [7FFE62644480]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].IndexOfKey(System.__Canon)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rsi
       mov       edx,eax
       call      qword ptr [7FFE626444E0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
M00_L00:
       mov       eax,[rsi+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 98
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       rcx,rbx
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+0A8]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62875F00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E0]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE62876490
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6209E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E8]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE628764C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6209E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0F0]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE62876580
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61EAE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M01_L08
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rbx
       mov       edx,r15d
       call      qword ptr [7FFE62644108]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        near ptr M01_L21
       mov       r14,[rbx+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0B0]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE62875F20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0B8]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE62875F38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0C0]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE628760A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0C8]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE628760B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rbx+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       esi,1
       jle       near ptr M01_L21
       mov       rcx,[rbx+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0D0]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE62876250
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rbx+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE62647AE0]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0D8]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE62876270
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rbx+30],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE623DC870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623DC7B0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE61C6F708]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F553F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DF66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 880
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].IndexOfKey(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+118]
       test      rax,rax
       je        short M02_L00
       mov       rcx,rax
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFE62878430
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rsi
       mov       rdx,[rbx+18]
       mov       [rsp+28],rdx
       mov       rdx,[rbx+8]
       mov       r9d,[rbx+30]
       xor       r8d,r8d
       call      qword ptr [7FFE626CC870]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       ecx,0FFFFFFFF
       test      eax,eax
       cmovl     eax,ecx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       ecx,899
       mov       rdx,7FFE61F553F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE61DF6790]
       int       3
; Total bytes of code 145
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M03_L01
       mov       eax,[rbx+30]
       cmp       esi,eax
       jge       short M03_L01
       dec       eax
       mov       [rbx+30],eax
       cmp       esi,eax
       jl        near ptr M03_L02
M03_L00:
       mov       rcx,[rbx+8]
       movsxd    rax,dword ptr [rbx+30]
       mov       rdx,rax
       mov       r8d,[rcx+8]
       cmp       rdx,r8
       jae       near ptr M03_L03
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       rcx,[rbx+10]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M03_L03
       mov       [rcx+rax*8+10],r8
       inc       dword ptr [rbx+34]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L01:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,7CB
       mov       rdx,7FFE61F553F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFE623DC9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFE61D1D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61BB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61BB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.Remove_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+290]
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE625EF468]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rbx+2A0]
       mov       rdx,[rcx+28]
       mov       rcx,rsi
       call      qword ptr [7FFE625EF870]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].IndexOfKey(System.__Canon)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rsi
       mov       edx,eax
       call      qword ptr [7FFE625EF8D0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
M00_L00:
       mov       eax,[rsi+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 98
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       rcx,rbx
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+0C0]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62857108
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0F8]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE62857698
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6207E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+100]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE628576D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6207E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+108]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE62857788
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61E8E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M01_L08
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rbx
       mov       edx,r15d
       call      qword ptr [7FFE625EF4F8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        near ptr M01_L21
       mov       r14,[rbx+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0C8]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE62857128
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0D0]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE62857140
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0D8]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE628572A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0E0]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE628572C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rbx+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       esi,1
       jle       near ptr M01_L21
       mov       rcx,[rbx+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E8]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE62857458
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rbx+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE62636F88]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0F0]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE62857478
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rbx+30],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE623BC870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623BC7B0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE61C4F708]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F353F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DD66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 880
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].IndexOfKey(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A8]
       test      rax,rax
       je        short M02_L00
       mov       rcx,rax
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFE62856520
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rsi
       mov       rdx,[rbx+18]
       mov       [rsp+28],rdx
       mov       rdx,[rbx+8]
       mov       r9d,[rbx+30]
       xor       r8d,r8d
       call      qword ptr [7FFE626AC510]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       ecx,0FFFFFFFF
       test      eax,eax
       cmovl     eax,ecx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       ecx,899
       mov       rdx,7FFE61F353F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE61DD6790]
       int       3
; Total bytes of code 145
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M03_L01
       mov       eax,[rbx+30]
       cmp       esi,eax
       jge       short M03_L01
       dec       eax
       mov       [rbx+30],eax
       cmp       esi,eax
       jl        near ptr M03_L02
M03_L00:
       mov       rcx,[rbx+8]
       movsxd    rax,dword ptr [rbx+30]
       mov       rdx,rax
       mov       r8d,[rcx+8]
       cmp       rdx,r8
       jae       near ptr M03_L03
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       rcx,[rbx+10]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M03_L03
       mov       [rcx+rax*8+10],r8
       inc       dword ptr [rbx+34]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L01:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,7CB
       mov       rdx,7FFE61F353F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFE623BC9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFE61CFD4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61B97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61B97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.Remove_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+290]
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE62614078]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rbx+2A0]
       mov       rdx,[rcx+28]
       mov       rcx,rsi
       call      qword ptr [7FFE62614480]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].IndexOfKey(System.__Canon)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rsi
       mov       edx,eax
       call      qword ptr [7FFE626144E0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
M00_L00:
       mov       eax,[rsi+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 98
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+0A8]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62846C88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E0]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE62847218
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6206E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E8]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE62847250
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6206E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0F0]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE62847308
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61E7E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M01_L08
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFE62614108]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L21
       mov       r14,[rsi+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0B0]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE62846CA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0B8]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE62846CC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0C0]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE62846E28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0C8]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE62846E40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rsi+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       ebx,1
       jle       near ptr M01_L21
       mov       rcx,[rsi+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0D0]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE62846FD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE62617AE0]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0D8]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE62846FF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rsi+30],ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623AC870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623AC7B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C3F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DC66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 880
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].IndexOfKey(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+118]
       test      rax,rax
       je        short M02_L00
       mov       rcx,rax
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFE628491B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rsi
       mov       rdx,[rbx+18]
       mov       [rsp+28],rdx
       mov       rdx,[rbx+8]
       mov       r9d,[rbx+30]
       xor       r8d,r8d
       call      qword ptr [7FFE6269CB58]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       ecx,0FFFFFFFF
       test      eax,eax
       cmovl     eax,ecx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       ecx,899
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE61DC6790]
       int       3
; Total bytes of code 145
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M03_L01
       mov       eax,[rbx+30]
       cmp       esi,eax
       jge       short M03_L01
       dec       eax
       mov       [rbx+30],eax
       cmp       esi,eax
       jl        near ptr M03_L02
M03_L00:
       mov       rcx,[rbx+8]
       movsxd    rax,dword ptr [rbx+30]
       mov       rdx,rax
       mov       r8d,[rcx+8]
       cmp       rdx,r8
       jae       near ptr M03_L03
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       rcx,[rbx+10]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M03_L03
       mov       [rcx+rax*8+10],r8
       inc       dword ptr [rbx+34]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L01:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,7CB
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFE623AC9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFE61CED4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61B87750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61B87750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.Remove_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+290]
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE62645068]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rbx+2A0]
       mov       rdx,[rcx+28]
       mov       rcx,rsi
       call      qword ptr [7FFE62645470]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].IndexOfKey(System.__Canon)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rsi
       mov       edx,eax
       call      qword ptr [7FFE626454D0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
M00_L00:
       mov       eax,[rsi+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 98
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+0A8]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62878DD0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E0]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE62879360
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6209E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E8]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE62879398
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6209E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0F0]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE62879450
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61EAE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M01_L08
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFE626450F8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L21
       mov       r14,[rsi+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0B0]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE62878DF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0B8]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE62878E08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0C0]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE62878F70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0C8]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE62878F88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rsi+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       ebx,1
       jle       near ptr M01_L21
       mov       rcx,[rsi+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0D0]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE62879120
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE6264CAE0]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0D8]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE62879140
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rsi+30],ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623DC870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623DC7B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C6F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F553F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DF66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 880
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].IndexOfKey(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+118]
       test      rax,rax
       je        short M02_L00
       mov       rcx,rax
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFE6287B050
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rsi
       mov       rdx,[rbx+18]
       mov       [rsp+28],rdx
       mov       rdx,[rbx+8]
       mov       r9d,[rbx+30]
       xor       r8d,r8d
       call      qword ptr [7FFE626CDF50]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       ecx,0FFFFFFFF
       test      eax,eax
       cmovl     eax,ecx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       ecx,899
       mov       rdx,7FFE61F553F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE61DF6790]
       int       3
; Total bytes of code 145
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M03_L01
       mov       eax,[rbx+30]
       cmp       esi,eax
       jge       short M03_L01
       dec       eax
       mov       [rbx+30],eax
       cmp       esi,eax
       jl        near ptr M03_L02
M03_L00:
       mov       rcx,[rbx+8]
       movsxd    rax,dword ptr [rbx+30]
       mov       rdx,rax
       mov       r8d,[rcx+8]
       cmp       rdx,r8
       jae       near ptr M03_L03
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       rcx,[rbx+10]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M03_L03
       mov       [rcx+rax*8+10],r8
       inc       dword ptr [rbx+34]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L01:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,7CB
       mov       rdx,7FFE61F553F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFE623DC9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFE61D1D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61BB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61BB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.Remove_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+290]
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE626259B0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rbx+2A0]
       mov       rdx,[rcx+28]
       mov       rcx,rsi
       call      qword ptr [7FFE62625DB8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].IndexOfKey(System.__Canon)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rsi
       mov       edx,eax
       call      qword ptr [7FFE62625E18]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
M00_L00:
       mov       eax,[rsi+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 98
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+0A8]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62858598
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E0]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE62858B28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6207E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E8]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE62858B60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6207E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0F0]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE62858C18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61E8E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M01_L08
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFE62625A40]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L21
       mov       r14,[rsi+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0B0]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE628585B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0B8]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE628585D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0C0]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE62858738
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0C8]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE62858750
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rsi+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       ebx,1
       jle       near ptr M01_L21
       mov       rcx,[rsi+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0D0]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE628588E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE6262D470]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0D8]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE62858908
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rsi+30],ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623BC870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623BC7B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C4F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F353F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DD66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 880
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].IndexOfKey(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+118]
       test      rax,rax
       je        short M02_L00
       mov       rcx,rax
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFE6285A630
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rsi
       mov       rdx,[rbx+18]
       mov       [rsp+28],rdx
       mov       rdx,[rbx+8]
       mov       r9d,[rbx+30]
       xor       r8d,r8d
       call      qword ptr [7FFE626AE460]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       ecx,0FFFFFFFF
       test      eax,eax
       cmovl     eax,ecx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       ecx,899
       mov       rdx,7FFE61F353F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE61DD6790]
       int       3
; Total bytes of code 145
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M03_L01
       mov       eax,[rbx+30]
       cmp       esi,eax
       jge       short M03_L01
       dec       eax
       mov       [rbx+30],eax
       cmp       esi,eax
       jl        near ptr M03_L02
M03_L00:
       mov       rcx,[rbx+8]
       movsxd    rax,dword ptr [rbx+30]
       mov       rdx,rax
       mov       r8d,[rcx+8]
       cmp       rdx,r8
       jae       near ptr M03_L03
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       rcx,[rbx+10]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M03_L03
       mov       [rcx+rax*8+10],r8
       inc       dword ptr [rbx+34]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L01:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,7CB
       mov       rdx,7FFE61F353F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFE623BC9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFE61CFD4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61B97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61B97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.Remove_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+290]
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE626359B0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rbx+2A0]
       mov       rdx,[rcx+28]
       mov       rcx,rsi
       call      qword ptr [7FFE62635DB8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].IndexOfKey(System.__Canon)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rsi
       mov       edx,eax
       call      qword ptr [7FFE62635E18]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
M00_L00:
       mov       eax,[rsi+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 98
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+0A8]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62868D80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E0]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE62869310
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6208E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E8]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE62869348
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6208E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0F0]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE62869400
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61E9E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M01_L08
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFE62635A40]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L21
       mov       r14,[rsi+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0B0]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE62868DA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0B8]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE62868DB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0C0]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE62868F20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0C8]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE62868F38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rsi+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       ebx,1
       jle       near ptr M01_L21
       mov       rcx,[rsi+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0D0]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE628690D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE6263D470]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0D8]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE628690F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rsi+30],ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623CC870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623CC7B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C5F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F453F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DE66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 880
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].IndexOfKey(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+118]
       test      rax,rax
       je        short M02_L00
       mov       rcx,rax
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFE6286AE18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rsi
       mov       rdx,[rbx+18]
       mov       [rsp+28],rdx
       mov       rdx,[rbx+8]
       mov       r9d,[rbx+30]
       xor       r8d,r8d
       call      qword ptr [7FFE626BE460]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       ecx,0FFFFFFFF
       test      eax,eax
       cmovl     eax,ecx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       ecx,899
       mov       rdx,7FFE61F453F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE61DE6790]
       int       3
; Total bytes of code 145
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M03_L01
       mov       eax,[rbx+30]
       cmp       esi,eax
       jge       short M03_L01
       dec       eax
       mov       [rbx+30],eax
       cmp       esi,eax
       jl        near ptr M03_L02
M03_L00:
       mov       rcx,[rbx+8]
       movsxd    rax,dword ptr [rbx+30]
       mov       rdx,rax
       mov       r8d,[rcx+8]
       cmp       rdx,r8
       jae       near ptr M03_L03
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       rcx,[rbx+10]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M03_L03
       mov       [rcx+rax*8+10],r8
       inc       dword ptr [rbx+34]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L01:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,7CB
       mov       rdx,7FFE61F453F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFE623CC9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFE61D0D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61BA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61BA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.Remove_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+290]
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE626159B0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rbx+2A0]
       mov       rdx,[rcx+28]
       mov       rcx,rsi
       call      qword ptr [7FFE62615DB8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].IndexOfKey(System.__Canon)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rsi
       mov       edx,eax
       call      qword ptr [7FFE62615E18]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
M00_L00:
       mov       eax,[rsi+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 98
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+0A8]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62848D70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E0]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE62849300
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6206E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E8]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE62849338
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6206E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0F0]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE628493F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61E7E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M01_L08
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFE62615A40]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L21
       mov       r14,[rsi+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0B0]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE62848D90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0B8]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE62848DA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0C0]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE62848F10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0C8]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE62848F28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rsi+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       ebx,1
       jle       near ptr M01_L21
       mov       rcx,[rsi+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0D0]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE628490C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE6261D470]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0D8]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE628490E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rsi+30],ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623AC870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623AC7B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C3F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DC66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 880
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].IndexOfKey(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+118]
       test      rax,rax
       je        short M02_L00
       mov       rcx,rax
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFE6284AE08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rsi
       mov       rdx,[rbx+18]
       mov       [rsp+28],rdx
       mov       rdx,[rbx+8]
       mov       r9d,[rbx+30]
       xor       r8d,r8d
       call      qword ptr [7FFE6269E460]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       ecx,0FFFFFFFF
       test      eax,eax
       cmovl     eax,ecx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       ecx,899
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE61DC6790]
       int       3
; Total bytes of code 145
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M03_L01
       mov       eax,[rbx+30]
       cmp       esi,eax
       jge       short M03_L01
       dec       eax
       mov       [rbx+30],eax
       cmp       esi,eax
       jl        near ptr M03_L02
M03_L00:
       mov       rcx,[rbx+8]
       movsxd    rax,dword ptr [rbx+30]
       mov       rdx,rax
       mov       r8d,[rcx+8]
       cmp       rdx,r8
       jae       near ptr M03_L03
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       rcx,[rbx+10]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M03_L03
       mov       [rcx+rax*8+10],r8
       inc       dword ptr [rbx+34]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L01:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,7CB
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFE623AC9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFE61CED4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61B87750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61B87750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_FastSortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFE61D0DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp+10]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFE61D5DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rbp+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 138
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE628610A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE628610E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE6237E4F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62861100
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE6237E4E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE628610B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE628610D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61D0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B110C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F55B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE6237E4E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B110D0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M02_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M02_L02
M02_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M02_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFE61F55878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61BA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_FastSortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFE61D1DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp+10]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFE61D6DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rbp+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 138
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62875078
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE628750B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623F0340
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE628750D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623F0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62875088
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE628750A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61D1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B210C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F65B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623F0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B210D0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M02_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M02_L02
M02_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M02_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFE61F65878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61BB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_FastSortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFE61D1DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp+10]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFE61D6DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rbp+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 138
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62875CF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62875D30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623F0310
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62875D48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623F0300
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62875D00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62875D18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61D1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B210C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F65B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623F0300
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B210D0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M02_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M02_L02
M02_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M02_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFE61F65878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61BB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_FastSortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFE61D0DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp+10]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFE61D5DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rbp+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 138
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62866C20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62866C60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623E0308
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62866C78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623E02F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62866C30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62866C48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61D0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B110C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F55B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623E02F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B110D0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M02_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M02_L02
M02_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M02_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFE61F55878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61BA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_FastSortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFE61D1DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp+10]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFE61D6DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rbp+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 138
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62877B38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62877B78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623F0310
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62877B90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623F0300
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62877B48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62877B60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61D1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B210C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F65B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623F0300
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B210D0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M02_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M02_L02
M02_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M02_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFE61F65878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61BB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_FastSortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFE61CEDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp+10]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFE61D3DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rbp+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 138
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62847C60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C34348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62847CA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623C0EB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62847CB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623C0EA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62847C70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62847C88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61CEE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AF10C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F35B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623C0EA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AF10D0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M02_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M02_L02
M02_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M02_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFE61F35878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61B87750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_FastSortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFE61D0DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp+10]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFE61D5DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rbp+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 138
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62867CA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62867CE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE6237DC00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62867D00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE6237DBF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62867CB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62867CD0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61D0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B110C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F55B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE6237DBF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B110D0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M02_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M02_L02
M02_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M02_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFE61F55878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61BA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_FastSortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonComparerByLastName
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFE61CFDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp+10]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFE61D4DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rbp+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 138
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62857CA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C44348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62857CE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623D0310
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62857D00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623D0300
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62857CB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62857CD0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61CFE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B010C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F45B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623D0300
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B010D0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M02_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M02_L02
M02_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M02_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFE61F45878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61B97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_SortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,2646AC01FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61D0DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFE61D5DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 133
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62861E18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62861E58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623E0D18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62861E70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623E0D08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62861E28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62861E40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61D0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B110D0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F55B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623E0D08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B110D8
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M02_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M02_L02
M02_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M02_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFE61F55878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61BA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_SortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,2639E001FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61CFDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFE61D4DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 133
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62855280
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C44348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE628552C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623D0358
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE628552D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623D0348
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62855290
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE628552A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61CFE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B010C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F45B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623D0348
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B010D0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M02_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M02_L02
M02_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M02_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFE61F45878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61B97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_SortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,25797801FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61D0DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFE61D5DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 133
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62866420
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62866460
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE6237E200
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62866478
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE6237E1F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62866430
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62866448
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61D0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B110C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F55B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE6237E1F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B110D0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M02_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M02_L02
M02_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M02_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFE61F55878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61BA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_SortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1ECB7401FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61CDDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFE61D2DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 133
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE628364C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C24348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62836500
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE6234EA40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62836518
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE6234EA30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE628364D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE628364E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61CDE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AE10C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F25B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE6234EA30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AE10D0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M02_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M02_L02
M02_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M02_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFE61F25878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61B77750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_SortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,201FE001FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61CFDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFE61D4DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 133
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62858288
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C44348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE628582C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE6236E160
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE628582E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE6236E150
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62858298
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE628582B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61CFE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B010C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F45B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE6236E150
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B010D0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M02_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M02_L02
M02_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M02_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFE61F45878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61B97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_SortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1CA07801FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61D0DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFE61D5DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 133
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE628680E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62868120
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623E0340
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62868138
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623E0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE628680F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62868108
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61D0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B110C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F55B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623E0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B110D0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M02_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M02_L02
M02_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M02_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFE61F55878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61BA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_SortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1F483001FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61CFDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFE61D4DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 133
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE628581B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C44348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE628581F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE6236DB60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62858210
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE6236DB50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE628581C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE628581E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61CFE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B010C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F45B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE6236DB50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B010D0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M02_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M02_L02
M02_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M02_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFE61F45878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61B97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_SortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1FA9D801FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61CDDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFE61D2DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 133
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62837B80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C24348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62837BC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623B0310
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62837BD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623B0300
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62837B90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62837BA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61CDE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AE10C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F25B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623B0300
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AE10D0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M02_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M02_L02
M02_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M02_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFE61F25878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61B77750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,26712001FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61CDDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFE61D2DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 133
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62831A50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C24348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62831A90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623B0340
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62831AA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623B0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62831A60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62831A78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61CDE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AE10D0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F25B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623B0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AE10D8
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M02_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M02_L02
M02_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M02_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFE61F25878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61B77750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,2087C401FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61D0DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFE61D5DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 133
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62865790
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE628657D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE6237E160
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE628657E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE6237E150
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE628657A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE628657B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61D0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B110C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F55B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE6237E150
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B110D0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M02_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M02_L02
M02_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M02_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFE61F55878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61BA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,2180D401FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61CDDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFE61D2DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 133
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62836648
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C24348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62836688
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE6234CAA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE628366A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE6234CA98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62836658
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62836670
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61CDE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AE10C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F25B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE6234CA98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AE10D0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M02_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M02_L02
M02_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M02_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFE61F25878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61B77750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,28E62401FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61CEDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFE61D3DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 133
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62846AC8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C34348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62846B08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623C0310
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62846B20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623C0300
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62846AD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62846AF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61CEE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AF10C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F35B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623C0300
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AF10D0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M02_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M02_L02
M02_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M02_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFE61F35878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61B87750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,23901001FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61D0DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFE61D5DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 133
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62867A58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62867A98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623E0340
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62867AB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623E0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62867A68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62867A80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61D0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B110C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F55B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623E0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B110D0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M02_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M02_L02
M02_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M02_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFE61F55878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61BA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,2621F001FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61CDDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFE61D2DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 133
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62837CB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C24348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62837CF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE6234FEA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62837D10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE6234FE98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62837CC8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62837CE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61CDE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AE10C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F25B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE6234FE98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AE10D0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M02_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M02_L02
M02_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M02_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFE61F25878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61B77750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,179DC801FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61D0DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFE61D5DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 133
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62867D00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62867D40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE623E0340
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62867D58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE623E0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62867D10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62867D28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61D0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B110C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F55B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE623E0330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61B110D0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M02_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M02_L02
M02_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M02_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFE61F55878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61BA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_FastSortedList()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,24888001FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE61CEDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFE61D3DC58]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rdi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 133
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+68]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE62847D00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE61C34348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFE62847D40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFE6235D900
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFE62847D58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFE6235D8F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+70]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFE62847D10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M01_L17
M01_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFE62847D28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M01_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rdx,r8
       call      qword ptr [7FFE61CEE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AF10C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L13
       mov       rcx,rsp
       call      M01_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L18:
       mov       ecx,17
       call      qword ptr [7FFE61F35B18]
       int       3
M01_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFE6235D8F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M01_L23
       mov       rcx,[rbp-28]
       mov       r11,7FFE61AF10D0
       call      qword ptr [r11]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 684
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       eax,[rbx+10]
       cmp       r9d,eax
       jae       short M02_L01
       dec       eax
       mov       [rbx+10],eax
       cmp       r9d,eax
       jl        short M02_L02
M02_L00:
       mov       rax,[rbx+8]
       movsxd    rcx,dword ptr [rbx+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       short M02_L03
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFE61F35878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFE61B87750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_SortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.OrdinalStringComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+290]
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFE62614078]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       edx,[rbp+30]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFE626144E0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rbp+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       rcx,rbx
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+0A0]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62841E40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0D8]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE628423D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6206E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E0]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE62842408
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6206E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E8]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE628424C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61E7E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M01_L08
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rbx
       mov       edx,r15d
       call      qword ptr [7FFE62614108]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        near ptr M01_L21
       mov       r14,[rbx+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0A8]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE62841E60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0B0]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE62841E78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0B8]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE62841FE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0C0]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE62841FF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rbx+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       esi,1
       jle       near ptr M01_L21
       mov       rcx,[rbx+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C8]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE62842190
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rbx+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE62617AE0]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0D0]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE628421B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rbx+30],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE623AC870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623AC7B0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE61C3F708]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DC66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 880
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M02_L01
       mov       eax,[rbx+30]
       cmp       esi,eax
       jge       short M02_L01
       dec       eax
       mov       [rbx+30],eax
       cmp       esi,eax
       jl        near ptr M02_L02
M02_L00:
       mov       rcx,[rbx+8]
       movsxd    rax,dword ptr [rbx+30]
       mov       rdx,rax
       mov       r8d,[rcx+8]
       cmp       rdx,r8
       jae       near ptr M02_L03
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       rcx,[rbx+10]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M02_L03
       mov       [rcx+rax*8+10],r8
       inc       dword ptr [rbx+34]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,7CB
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFE623AC9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFE61CED4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61B87750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61B87750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_SortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.OrdinalStringComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+290]
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFE62634078]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       edx,[rbp+30]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFE626344E0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rbp+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       rcx,rbx
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+0A0]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62865968
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0D8]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE62865EF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6208E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E0]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE62865F30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6208E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E8]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE62865FE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61E9E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M01_L08
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rbx
       mov       edx,r15d
       call      qword ptr [7FFE62634108]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        near ptr M01_L21
       mov       r14,[rbx+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0A8]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE62865988
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0B0]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE628659A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0B8]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE62865B08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0C0]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE62865B20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rbx+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       esi,1
       jle       near ptr M01_L21
       mov       rcx,[rbx+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C8]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE62865CB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rbx+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE62637AE0]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0D0]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE62865CD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rbx+30],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE623CC870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623CC7B0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE61C5F708]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F453F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DE66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 880
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M02_L01
       mov       eax,[rbx+30]
       cmp       esi,eax
       jge       short M02_L01
       dec       eax
       mov       [rbx+30],eax
       cmp       esi,eax
       jl        near ptr M02_L02
M02_L00:
       mov       rcx,[rbx+8]
       movsxd    rax,dword ptr [rbx+30]
       mov       rdx,rax
       mov       r8d,[rcx+8]
       cmp       rdx,r8
       jae       near ptr M02_L03
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       rcx,[rbx+10]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M02_L03
       mov       [rcx+rax*8+10],r8
       inc       dword ptr [rbx+34]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,7CB
       mov       rdx,7FFE61F453F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFE623CC9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFE61D0D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61BA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61BA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_SortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.OrdinalStringComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+290]
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFE62614078]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       edx,[rbp+30]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFE626144E0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rbp+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       rcx,rbx
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+0A0]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE628467A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0D8]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE62846D38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6206E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E0]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE62846D70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6206E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E8]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE62846E28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61E7E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M01_L08
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rbx
       mov       edx,r15d
       call      qword ptr [7FFE62614108]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        near ptr M01_L21
       mov       r14,[rbx+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0A8]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE628467C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0B0]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE628467E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0B8]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE62846948
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0C0]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE62846960
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rbx+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       esi,1
       jle       near ptr M01_L21
       mov       rcx,[rbx+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C8]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE62846AF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rbx+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE62617AE0]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0D0]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE62846B18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rbx+30],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE623AC870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623AC7B0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE61C3F708]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DC66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 880
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M02_L01
       mov       eax,[rbx+30]
       cmp       esi,eax
       jge       short M02_L01
       dec       eax
       mov       [rbx+30],eax
       cmp       esi,eax
       jl        near ptr M02_L02
M02_L00:
       mov       rcx,[rbx+8]
       movsxd    rax,dword ptr [rbx+30]
       mov       rdx,rax
       mov       r8d,[rcx+8]
       cmp       rdx,r8
       jae       near ptr M02_L03
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       rcx,[rbx+10]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M02_L03
       mov       [rcx+rax*8+10],r8
       inc       dword ptr [rbx+34]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,7CB
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFE623AC9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFE61CED4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61B87750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61B87750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_SortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.OrdinalStringComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+290]
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFE62644078]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       edx,[rbp+30]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFE626444E0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rbp+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+0A0]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62876E40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0D8]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE628773D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6209E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E0]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE62877408
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6209E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E8]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE628774C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61EAE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M01_L08
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFE62644108]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L21
       mov       r14,[rsi+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0A8]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE62876E60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0B0]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE62876E78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0B8]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE62876FE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0C0]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE62876FF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rsi+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       ebx,1
       jle       near ptr M01_L21
       mov       rcx,[rsi+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C8]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE62877190
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE62647AE0]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0D0]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE628771B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rsi+30],ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623DC870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623DC7B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C6F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F553F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DF66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 880
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M02_L01
       mov       eax,[rbx+30]
       cmp       esi,eax
       jge       short M02_L01
       dec       eax
       mov       [rbx+30],eax
       cmp       esi,eax
       jl        near ptr M02_L02
M02_L00:
       mov       rcx,[rbx+8]
       movsxd    rax,dword ptr [rbx+30]
       mov       rdx,rax
       mov       r8d,[rcx+8]
       cmp       rdx,r8
       jae       near ptr M02_L03
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       rcx,[rbx+10]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M02_L03
       mov       [rcx+rax*8+10],r8
       inc       dword ptr [rbx+34]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,7CB
       mov       rdx,7FFE61F553F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFE623DC9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFE61D1D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61BB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61BB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_SortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.OrdinalStringComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+290]
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFE626159B0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       edx,[rbp+30]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFE62615E18]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rbp+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+0A0]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62848A50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0D8]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE62848FE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6206E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E0]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE62849018
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6206E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E8]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE628490D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61E7E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M01_L08
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFE62615A40]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L21
       mov       r14,[rsi+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0A8]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE62848A70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0B0]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE62848A88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0B8]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE62848BF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0C0]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE62848C08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rsi+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       ebx,1
       jle       near ptr M01_L21
       mov       rcx,[rsi+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C8]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE62848DA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE6261D470]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0D0]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE62848DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rsi+30],ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623AC870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623AC7B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C3F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DC66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 880
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M02_L01
       mov       eax,[rbx+30]
       cmp       esi,eax
       jge       short M02_L01
       dec       eax
       mov       [rbx+30],eax
       cmp       esi,eax
       jl        near ptr M02_L02
M02_L00:
       mov       rcx,[rbx+8]
       movsxd    rax,dword ptr [rbx+30]
       mov       rdx,rax
       mov       r8d,[rcx+8]
       cmp       rdx,r8
       jae       near ptr M02_L03
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       rcx,[rbx+10]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M02_L03
       mov       [rcx+rax*8+10],r8
       inc       dword ptr [rbx+34]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,7CB
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFE623AC9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFE61CED4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61B87750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61B87750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_SortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.OrdinalStringComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+290]
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFE626459B0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       edx,[rbp+30]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFE62645E18]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rbp+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+0A0]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62878568
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0D8]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE62878AF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6209E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E0]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE62878B30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6209E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E8]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE62878BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61EAE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M01_L08
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFE62645A40]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L21
       mov       r14,[rsi+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0A8]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE62878588
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0B0]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE628785A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0B8]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE62878708
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0C0]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE62878720
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rsi+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       ebx,1
       jle       near ptr M01_L21
       mov       rcx,[rsi+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C8]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE628788B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE6264D470]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0D0]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE628788D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rsi+30],ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623DC870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623DC7B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C6F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F553F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DF66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 880
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M02_L01
       mov       eax,[rbx+30]
       cmp       esi,eax
       jge       short M02_L01
       dec       eax
       mov       [rbx+30],eax
       cmp       esi,eax
       jl        near ptr M02_L02
M02_L00:
       mov       rcx,[rbx+8]
       movsxd    rax,dword ptr [rbx+30]
       mov       rdx,rax
       mov       r8d,[rcx+8]
       cmp       rdx,r8
       jae       near ptr M02_L03
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       rcx,[rbx+10]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M02_L03
       mov       [rcx+rax*8+10],r8
       inc       dword ptr [rbx+34]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,7CB
       mov       rdx,7FFE61F553F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFE623DC9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFE61D1D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61BB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61BB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_SortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.OrdinalStringComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+290]
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFE626459B0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       edx,[rbp+30]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFE62645E18]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rbp+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+0A0]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62878650
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0D8]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE62878BE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6209E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E0]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE62878C18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6209E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E8]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE62878CD0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61EAE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M01_L08
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFE62645A40]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L21
       mov       r14,[rsi+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0A8]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE62878670
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0B0]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE62878688
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0B8]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE628787F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0C0]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE62878808
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rsi+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       ebx,1
       jle       near ptr M01_L21
       mov       rcx,[rsi+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C8]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE628789A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE6264D470]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0D0]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE628789C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rsi+30],ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623DC870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623DC7B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C6F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F553F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DF66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 880
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M02_L01
       mov       eax,[rbx+30]
       cmp       esi,eax
       jge       short M02_L01
       dec       eax
       mov       [rbx+30],eax
       cmp       esi,eax
       jl        near ptr M02_L02
M02_L00:
       mov       rcx,[rbx+8]
       movsxd    rax,dword ptr [rbx+30]
       mov       rdx,rax
       mov       r8d,[rcx+8]
       cmp       rdx,r8
       jae       near ptr M02_L03
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       rcx,[rbx+10]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M02_L03
       mov       [rcx+rax*8+10],r8
       inc       dword ptr [rbx+34]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,7CB
       mov       rdx,7FFE61F553F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFE623DC9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFE61D1D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61BB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61BB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListRemoveBenchmark.RemoveAt_SortedList_Comparer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.OrdinalStringComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+290]
       mov       rcx,offset MT_System.Collections.Generic.SortedList<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFE626159B0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       edx,[rbp+30]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFE62615E18]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rbp+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rdi,rdi
       je        near ptr M01_L23
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r14,[rdx+0A0]
       test      r14,r14
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE62848D38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0D8]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FFE628492C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFE6206E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E0]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbp
       mov       rdx,7FFE62849300
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFE6206E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+30],ecx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0E8]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbp
       mov       rdx,7FFE628493B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFE61E7E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M01_L08
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFE62615A40]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L21
       mov       r14,[rsi+8]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0A8]
       test      r15,r15
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbp
       mov       rdx,7FFE62848D58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L10:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0B0]
       test      r13,r13
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbp
       mov       rdx,7FFE62848D70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       r11,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [r13]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+0B8]
       test      r15,r15
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,7FFE62848ED8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r15,rax
M01_L14:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r13,[rcx+0C0]
       test      r13,r13
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbp
       mov       rdx,7FFE62848EF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rdi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rsi+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       ebx,1
       jle       near ptr M01_L21
       mov       rcx,[rsi+18]
       mov       rdi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C8]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFE62849088
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFE6261D470]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       r13d,[r14+8]
       cmp       r13d,1
       jle       short M01_L21
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r12,[rcx+0D0]
       test      r12,r12
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbp
       mov       rdx,7FFE628490A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rsi+30],ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE623AC870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFE623AC7B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE61C3F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE61DC66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 880
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M02_L01
       mov       eax,[rbx+30]
       cmp       esi,eax
       jge       short M02_L01
       dec       eax
       mov       [rbx+30],eax
       cmp       esi,eax
       jl        near ptr M02_L02
M02_L00:
       mov       rcx,[rbx+8]
       movsxd    rax,dword ptr [rbx+30]
       mov       rdx,rax
       mov       r8d,[rcx+8]
       cmp       rdx,r8
       jae       near ptr M02_L03
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       rcx,[rbx+10]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M02_L03
       mov       [rcx+rax*8+10],r8
       inc       dword ptr [rbx+34]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,7CB
       mov       rdx,7FFE61F253F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFE623AC9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFE61CED4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61B87750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFE61B87750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

