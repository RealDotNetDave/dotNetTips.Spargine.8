## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,1235E801FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEDD86DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbx+280]
       mov       edx,[rdi+10]
       mov       [rsp+20],edx
       mov       rdx,[rdi+8]
       mov       rcx,7FFEDE1AE7E8
       xor       r9d,r9d
       call      qword ptr [7FFEDE1BC1B0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rdi
       mov       edx,eax
       call      qword ptr [7FFEDD876DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE361F50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD7B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE361F90
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
       mov       rdx,7FFEDDE7D650
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
       mov       rdx,7FFEDE361FA8
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
       mov       rdx,7FFEDDE7D640
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
       mov       rdx,7FFEDE361F60
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
       mov       rdx,7FFEDE361F78
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
       call      qword ptr [7FFEDD86E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6710D8
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
       call      qword ptr [7FFEDDA55B18]
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
       mov       rdx,7FFEDDE7D640
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
       mov       r11,7FFEDD6710E0
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
       call      qword ptr [7FFEDD7BFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       mov       r11,7FFEDD6710E8
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
       mov       rdx,7FFEDE3625E8
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
       mov       r11,7FFEDD6710E8
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
       call      qword ptr [7FFEDDA55B18]
       int       3
M02_L10:
       call      qword ptr [7FFEDDA55908]
       int       3
M02_L11:
       call      qword ptr [7FFEDDA55938]
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
       call      qword ptr [7FFEDDA55878]
       int       3
M03_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD707750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,1CA71801FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEDD86DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbx+280]
       mov       edx,[rdi+10]
       mov       [rsp+20],edx
       mov       rdx,[rdi+8]
       mov       rcx,7FFEDE1AE7E8
       xor       r9d,r9d
       call      qword ptr [7FFEDE1BC1B0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rdi
       mov       edx,eax
       call      qword ptr [7FFEDD876DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE364F50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD7B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE364F90
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
       mov       rdx,7FFEDDE7F7A8
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
       mov       rdx,7FFEDE364FA8
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
       mov       rdx,7FFEDDE7F798
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
       mov       rdx,7FFEDE364F60
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
       mov       rdx,7FFEDE364F78
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
       call      qword ptr [7FFEDD86E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6710D8
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
       call      qword ptr [7FFEDDA55B18]
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
       mov       rdx,7FFEDDE7F798
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
       mov       r11,7FFEDD6710E0
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
       je        near ptr M02_L10
       mov       r14d,[rbx+8]
       cmp       r14d,esi
       jb        near ptr M02_L11
       mov       edx,r14d
       sub       edx,esi
       cmp       edx,ebp
       jb        near ptr M02_L12
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M02_L06
M02_L00:
       mov       rcx,rdx
       call      qword ptr [7FFEDD7BFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       cmp       [rax],rcx
       jne       near ptr M02_L09
       add       ebp,esi
       test      rdi,rdi
       je        near ptr M02_L13
       cmp       esi,ebp
       jge       short M02_L03
       mov       ecx,esi
       or        ecx,ebp
       jl        short M02_L07
       cmp       r14d,ebp
       jl        short M02_L07
M02_L01:
       mov       ecx,esi
       mov       rcx,[rbx+rcx*8+10]
       test      rcx,rcx
       je        short M02_L02
       mov       rdx,rdi
       mov       r11,7FFEDD6710E8
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
       mov       rdx,7FFEDE365550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L00
M02_L07:
       cmp       esi,r14d
       jae       near ptr M02_L17
       mov       ecx,esi
       mov       rcx,[rbx+rcx*8+10]
       test      rcx,rcx
       je        short M02_L08
       mov       rdx,rdi
       mov       r11,7FFEDD6710E8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L05
M02_L08:
       inc       esi
       cmp       esi,ebp
       jl        short M02_L07
       jmp       short M02_L03
M02_L09:
       mov       [rsp+20],ebp
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,rdi
       mov       r9d,esi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L04
M02_L10:
       mov       ecx,2
       call      qword ptr [7FFEDDA55B18]
       int       3
M02_L11:
       call      qword ptr [7FFEDDA55908]
       int       3
M02_L12:
       call      qword ptr [7FFEDDA55938]
       int       3
M02_L13:
       mov       eax,esi
       jmp       short M02_L16
M02_L14:
       cmp       eax,r14d
       jae       short M02_L17
       mov       ecx,eax
       cmp       qword ptr [rbx+rcx*8+10],0
       jne       short M02_L15
       jmp       near ptr M02_L04
M02_L15:
       inc       eax
M02_L16:
       cmp       eax,ebp
       jl        short M02_L14
       jmp       near ptr M02_L03
M02_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 357
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
       call      qword ptr [7FFEDDA55878]
       int       3
M03_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD707750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,180ED801FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEDD86DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbx+280]
       mov       edx,[rdi+10]
       mov       [rsp+20],edx
       mov       rdx,[rdi+8]
       mov       rcx,7FFEDE1AE7E8
       xor       r9d,r9d
       call      qword ptr [7FFEDE1B7D50]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rdi
       mov       edx,eax
       call      qword ptr [7FFEDD876DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE365F78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD7B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE365FB8
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
       mov       rdx,7FFEDDE7D808
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
       mov       rdx,7FFEDE365FD0
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
       mov       rdx,7FFEDDE7D7F8
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
       mov       rdx,7FFEDE365F88
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
       mov       rdx,7FFEDE365FA0
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
       call      qword ptr [7FFEDD86E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6710D8
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
       call      qword ptr [7FFEDDA55B18]
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
       mov       rdx,7FFEDDE7D7F8
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
       mov       r11,7FFEDD6710E0
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
       call      qword ptr [7FFEDD7BFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       mov       r11,7FFEDD6710E8
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
       mov       rdx,7FFEDE366578
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
       mov       r11,7FFEDD6710E8
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
       call      qword ptr [7FFEDDA55B18]
       int       3
M02_L10:
       call      qword ptr [7FFEDDA55908]
       int       3
M02_L11:
       call      qword ptr [7FFEDDA55938]
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
       call      qword ptr [7FFEDDA55878]
       int       3
M03_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD707750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,2582A801FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEDD84DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbx+280]
       mov       edx,[rdi+10]
       mov       [rsp+20],edx
       mov       rdx,[rdi+8]
       mov       rcx,7FFEDE18E7E8
       xor       r9d,r9d
       call      qword ptr [7FFEDE19C1B0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rdi
       mov       edx,eax
       call      qword ptr [7FFEDD856DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE346740
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD794348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE346780
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
       mov       rdx,7FFEDDE5FE48
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
       mov       rdx,7FFEDE346798
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
       mov       rdx,7FFEDDE5FE38
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
       mov       rdx,7FFEDE346750
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
       mov       rdx,7FFEDE346768
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
       call      qword ptr [7FFEDD84E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6510D8
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
       call      qword ptr [7FFEDDA35B18]
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
       mov       rdx,7FFEDDE5FE38
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
       mov       r11,7FFEDD6510E0
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
       call      qword ptr [7FFEDD79FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       mov       r11,7FFEDD6510E8
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
       mov       rdx,7FFEDE346D40
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
       mov       r11,7FFEDD6510E8
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
       call      qword ptr [7FFEDDA35B18]
       int       3
M02_L10:
       call      qword ptr [7FFEDDA35908]
       int       3
M02_L11:
       call      qword ptr [7FFEDDA35938]
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
       call      qword ptr [7FFEDDA35878]
       int       3
M03_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD6E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,241B4C01FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEDD85DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbx+280]
       mov       edx,[rdi+10]
       mov       [rsp+20],edx
       mov       rdx,[rdi+8]
       mov       rcx,7FFEDE1B3010
       xor       r9d,r9d
       call      qword ptr [7FFEDE1AD1E8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rdi
       mov       edx,eax
       call      qword ptr [7FFEDD866DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE357980
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD7A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE3579C0
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
       mov       rdx,7FFEDDE6FE98
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
       mov       rdx,7FFEDE3579D8
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
       mov       rdx,7FFEDDE6FE88
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
       mov       rdx,7FFEDE357990
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
       mov       rdx,7FFEDE3579A8
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
       call      qword ptr [7FFEDD85E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6610D8
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
       call      qword ptr [7FFEDDA45B18]
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
       mov       rdx,7FFEDDE6FE88
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
       mov       r11,7FFEDD6610E0
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
       call      qword ptr [7FFEDD7AFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       mov       r11,7FFEDD6610E8
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
       mov       rdx,7FFEDE357F80
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
       mov       r11,7FFEDD6610E8
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
       call      qword ptr [7FFEDDA45B18]
       int       3
M02_L10:
       call      qword ptr [7FFEDDA45908]
       int       3
M02_L11:
       call      qword ptr [7FFEDDA45938]
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
       call      qword ptr [7FFEDDA45878]
       int       3
M03_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD6F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,2DCFF801FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEDD84DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbx+280]
       mov       edx,[rdi+10]
       mov       [rsp+20],edx
       mov       rdx,[rdi+8]
       mov       rcx,7FFEDE1A3010
       xor       r9d,r9d
       call      qword ptr [7FFEDE19D1E8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rdi
       mov       edx,eax
       call      qword ptr [7FFEDD856DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE347F80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD794348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE347FC0
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
       mov       rdx,7FFEDDE5CAA8
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
       mov       rdx,7FFEDE347FD8
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
       mov       rdx,7FFEDDE5CA98
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
       mov       rdx,7FFEDE347F90
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
       mov       rdx,7FFEDE347FA8
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
       call      qword ptr [7FFEDD84E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6510D8
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
       call      qword ptr [7FFEDDA35B18]
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
       mov       rdx,7FFEDDE5CA98
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
       mov       r11,7FFEDD6510E0
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
       call      qword ptr [7FFEDD79FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       mov       r11,7FFEDD6510E8
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
       mov       rdx,7FFEDE348580
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
       mov       r11,7FFEDD6510E8
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
       call      qword ptr [7FFEDDA35B18]
       int       3
M02_L10:
       call      qword ptr [7FFEDDA35908]
       int       3
M02_L11:
       call      qword ptr [7FFEDDA35938]
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
       call      qword ptr [7FFEDDA35878]
       int       3
M03_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD6E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,21795C01FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEDD84DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbx+280]
       mov       edx,[rdi+10]
       mov       [rsp+20],edx
       mov       rdx,[rdi+8]
       mov       rcx,7FFEDE1A3158
       xor       r9d,r9d
       call      qword ptr [7FFEDE19DDA0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rdi
       mov       edx,eax
       call      qword ptr [7FFEDD856DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE3488B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD794348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE3488F0
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
       mov       rdx,7FFEDDE5FE90
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
       mov       rdx,7FFEDE348908
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
       mov       rdx,7FFEDDE5FE80
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
       mov       rdx,7FFEDE3488C0
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
       mov       rdx,7FFEDE3488D8
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
       call      qword ptr [7FFEDD84E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6510D8
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
       call      qword ptr [7FFEDDA35B18]
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
       mov       rdx,7FFEDDE5FE80
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
       mov       r11,7FFEDD6510E0
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
       je        near ptr M02_L10
       mov       r14d,[rbx+8]
       cmp       r14d,esi
       jb        near ptr M02_L11
       mov       edx,r14d
       sub       edx,esi
       cmp       edx,ebp
       jb        near ptr M02_L12
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M02_L07
M02_L00:
       mov       rcx,rdx
       call      qword ptr [7FFEDD79FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       cmp       [rax],rcx
       jne       near ptr M02_L09
       add       ebp,esi
       test      rdi,rdi
       je        near ptr M02_L13
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
       mov       r11,7FFEDD6510E8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L08
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
       cmp       esi,r14d
       jae       near ptr M02_L17
       mov       ecx,esi
       mov       rcx,[rbx+rcx*8+10]
       test      rcx,rcx
       je        short M02_L06
       mov       rdx,rdi
       mov       r11,7FFEDD6510E8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L08
M02_L06:
       inc       esi
       cmp       esi,ebp
       jl        short M02_L05
       jmp       short M02_L03
M02_L07:
       mov       rdx,7FFEDE348EB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L00
M02_L08:
       mov       eax,esi
       jmp       short M02_L04
M02_L09:
       mov       [rsp+20],ebp
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,rdi
       mov       r9d,esi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L04
M02_L10:
       mov       ecx,2
       call      qword ptr [7FFEDDA35B18]
       int       3
M02_L11:
       call      qword ptr [7FFEDDA35908]
       int       3
M02_L12:
       call      qword ptr [7FFEDDA35938]
       int       3
M02_L13:
       mov       eax,esi
       jmp       short M02_L16
M02_L14:
       cmp       eax,r14d
       jae       short M02_L17
       mov       ecx,eax
       cmp       qword ptr [rbx+rcx*8+10],0
       jne       short M02_L15
       jmp       near ptr M02_L04
M02_L15:
       inc       eax
M02_L16:
       cmp       eax,ebp
       jl        short M02_L14
       jmp       near ptr M02_L03
M02_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 361
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
       call      qword ptr [7FFEDDA35878]
       int       3
M03_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD6E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,1662DC01FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEDD85DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbx+280]
       mov       edx,[rdi+10]
       mov       [rsp+20],edx
       mov       rdx,[rdi+8]
       mov       rcx,7FFEDE1B3010
       xor       r9d,r9d
       call      qword ptr [7FFEDE1AD890]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rdi
       mov       edx,eax
       call      qword ptr [7FFEDD866DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE358588
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD7A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE3585C8
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
       mov       rdx,7FFEDDE6CDA0
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
       mov       rdx,7FFEDE3585E0
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
       mov       rdx,7FFEDDE6CD90
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
       mov       rdx,7FFEDE358598
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
       mov       rdx,7FFEDE3585B0
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
       call      qword ptr [7FFEDD85E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6610D8
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
       call      qword ptr [7FFEDDA45B18]
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
       mov       rdx,7FFEDDE6CD90
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
       mov       r11,7FFEDD6610E0
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
       call      qword ptr [7FFEDD7AFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       mov       r11,7FFEDD6610E8
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
       mov       rdx,7FFEDE358B88
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
       mov       r11,7FFEDD6610E8
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
       call      qword ptr [7FFEDDA45B18]
       int       3
M02_L10:
       call      qword ptr [7FFEDDA45908]
       int       3
M02_L11:
       call      qword ptr [7FFEDDA45938]
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
       call      qword ptr [7FFEDDA45878]
       int       3
M03_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD6F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FFEDE0DF300]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rbx+2A0]
       mov       rdx,[rcx+28]
       mov       rcx,rsi
       call      qword ptr [7FFEDE0DF708]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].IndexOfKey(System.__Canon)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rsi
       mov       edx,eax
       call      qword ptr [7FFEDE0DF768]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,rbx
       test      rsi,rsi
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
       mov       rdx,7FFEDE341848
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rsi
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
       mov       rdx,7FFEDE341DD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFEDDB6E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE341E10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFEDDB6E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE341EC8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFEDD96E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M01_L08
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rbx
       mov       edx,r15d
       call      qword ptr [7FFEDE0DF390]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
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
       mov       rdx,7FFEDE341868
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
       mov       rdx,7FFEDE341880
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rsi
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
       mov       rdx,7FFEDE3419E8
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
       mov       rdx,7FFEDE341A00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rsi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rbx+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       edi,1
       jle       near ptr M01_L21
       mov       rcx,[rbx+18]
       mov       rsi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0D0]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFEDE341B98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rbx+10]
       mov       rdx,r14
       mov       r9,rsi
       call      qword ptr [7FFEDE126F88]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFEDE341BB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       lea       edx,[r15-1]
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rbx+30],edi
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
       call      qword ptr [7FFEDDEAC870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFEDDEAC7B0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFEDD79F708]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFEDDA209E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFEDD8B66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 884
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
       mov       rdx,7FFEDE343E10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rsi
       mov       rdx,[rbx+18]
       mov       [rsp+28],rdx
       mov       rdx,[rbx+8]
       mov       r9d,[rbx+30]
       xor       r8d,r8d
       call      qword ptr [7FFEDE19C510]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       ecx,0FFFFFFFF
       test      eax,eax
       cmovl     eax,ecx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       ecx,899
       mov       rdx,7FFEDDA209E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFEDD8B6790]
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
       mov       rdx,7FFEDDA209E8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFEDDEAC9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFEDD84D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FFEDE0CF300]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rbx+2A0]
       mov       rdx,[rcx+28]
       mov       rcx,rsi
       call      qword ptr [7FFEDE0CF708]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].IndexOfKey(System.__Canon)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rsi
       mov       edx,eax
       call      qword ptr [7FFEDE0CF768]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE335730
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
       mov       rdx,7FFEDE335CC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFEDDB5E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE335CF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFEDDB5E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE335DB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFEDD95E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FFEDE0CF390]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FFEDE335750
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
       mov       rdx,7FFEDE335768
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
       mov       rdx,7FFEDE3358D0
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
       mov       rdx,7FFEDE3358E8
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
       mov       rdx,7FFEDE335A80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rbx+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFEDE116F88]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFEDE335AA0
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
       call      qword ptr [7FFEDDE9C870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFEDDE9C7B0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFEDD78F708]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFEDDA109E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFEDD8A66E8]
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
       mov       rdx,7FFEDE337C60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rsi
       mov       rdx,[rbx+18]
       mov       [rsp+28],rdx
       mov       rdx,[rbx+8]
       mov       r9d,[rbx+30]
       xor       r8d,r8d
       call      qword ptr [7FFEDE18C510]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       ecx,0FFFFFFFF
       test      eax,eax
       cmovl     eax,ecx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       ecx,899
       mov       rdx,7FFEDDA109E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFEDD8A6790]
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
       mov       rdx,7FFEDDA109E8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFEDDE9C9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFEDD83D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FFEDE0CF9F0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rbx+2A0]
       mov       rdx,[rcx+28]
       mov       rcx,rsi
       call      qword ptr [7FFEDE0CFDF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].IndexOfKey(System.__Canon)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rsi
       mov       edx,eax
       call      qword ptr [7FFEDE0CFE58]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE346160
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
       mov       rdx,7FFEDE3466F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFEDDB6E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE346728
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFEDDB6E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE3467E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFEDD96E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FFEDE0CFA80]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FFEDE346180
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
       mov       rdx,7FFEDE346198
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
       mov       rdx,7FFEDE346300
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
       mov       rdx,7FFEDE346318
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
       mov       rdx,7FFEDE3464B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rbx+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFEDE117468]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFEDE3464D0
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
       call      qword ptr [7FFEDDEAC870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFEDDEAC7B0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFEDD79F708]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFEDDA209E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFEDD8B66E8]
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
       mov       rdx,7FFEDE348690
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rsi
       mov       rdx,[rbx+18]
       mov       [rsp+28],rdx
       mov       rdx,[rbx+8]
       mov       r9d,[rbx+30]
       xor       r8d,r8d
       call      qword ptr [7FFEDE19C870]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       ecx,0FFFFFFFF
       test      eax,eax
       cmovl     eax,ecx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       ecx,899
       mov       rdx,7FFEDDA209E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFEDD8B6790]
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
       mov       rdx,7FFEDDA209E8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFEDDEAC9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFEDD84D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FFEDE0CF9F0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rbx+2A0]
       mov       rdx,[rcx+28]
       mov       rcx,rsi
       call      qword ptr [7FFEDE0CFDF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].IndexOfKey(System.__Canon)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rsi
       mov       edx,eax
       call      qword ptr [7FFEDE0CFE58]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE346218
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
       mov       rdx,7FFEDE3467A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFEDDB6E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE3467E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFEDDB6E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE346898
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFEDD96E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FFEDE0CFA80]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FFEDE346238
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
       mov       rdx,7FFEDE346250
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
       mov       rdx,7FFEDE3463B8
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
       mov       rdx,7FFEDE3463D0
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
       mov       rdx,7FFEDE346568
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFEDE117468]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFEDE346588
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
       call      qword ptr [7FFEDDEAC870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFEDDEAC7B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEDD79F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFEDDA209E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFEDD8B66E8]
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
       mov       rdx,7FFEDE348748
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rsi
       mov       rdx,[rbx+18]
       mov       [rsp+28],rdx
       mov       rdx,[rbx+8]
       mov       r9d,[rbx+30]
       xor       r8d,r8d
       call      qword ptr [7FFEDE19C510]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       ecx,0FFFFFFFF
       test      eax,eax
       cmovl     eax,ecx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       ecx,899
       mov       rdx,7FFEDDA209E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFEDD8B6790]
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
       mov       rdx,7FFEDDA209E8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFEDDEAC9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFEDD84D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FFEDE125230]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rbx+2A0]
       mov       rdx,[rcx+28]
       mov       rcx,rsi
       call      qword ptr [7FFEDE125638]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].IndexOfKey(System.__Canon)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rsi
       mov       edx,eax
       call      qword ptr [7FFEDE125698]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE358548
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
       mov       rdx,7FFEDE358AD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFEDDB7E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE358B10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFEDDB7E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE358BC8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFEDD97E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FFEDE1252C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FFEDE358568
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
       mov       rdx,7FFEDE358580
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
       mov       rdx,7FFEDE3586E8
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
       mov       rdx,7FFEDE358700
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
       mov       rdx,7FFEDE358898
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFEDE12CE88]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFEDE3588B8
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
       call      qword ptr [7FFEDDEBC870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFEDDEBC7B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEDD7AF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFEDDA309E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFEDD8C66E8]
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
       mov       rdx,7FFEDE35A7C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rsi
       mov       rdx,[rbx+18]
       mov       [rsp+28],rdx
       mov       rdx,[rbx+8]
       mov       r9d,[rbx+30]
       xor       r8d,r8d
       call      qword ptr [7FFEDE1AE460]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       ecx,0FFFFFFFF
       test      eax,eax
       cmovl     eax,ecx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       ecx,899
       mov       rdx,7FFEDDA309E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFEDD8C6790]
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
       mov       rdx,7FFEDDA309E8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFEDDEBC9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFEDD85D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FFEDE105230]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rbx+2A0]
       mov       rdx,[rcx+28]
       mov       rcx,rsi
       call      qword ptr [7FFEDE105638]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].IndexOfKey(System.__Canon)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rsi
       mov       edx,eax
       call      qword ptr [7FFEDE105698]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE3382D8
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
       mov       rdx,7FFEDE338868
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFEDDB5E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE3388A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFEDDB5E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE338958
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFEDD95E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FFEDE1052C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FFEDE3382F8
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
       mov       rdx,7FFEDE338310
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
       mov       rdx,7FFEDE338478
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
       mov       rdx,7FFEDE338490
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
       mov       rdx,7FFEDE338628
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFEDE10CE88]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFEDE338648
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
       call      qword ptr [7FFEDDE9C870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFEDDE9C7B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEDD78F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFEDDA109E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFEDD8A66E8]
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
       mov       rdx,7FFEDE33A370
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rsi
       mov       rdx,[rbx+18]
       mov       [rsp+28],rdx
       mov       rdx,[rbx+8]
       mov       r9d,[rbx+30]
       xor       r8d,r8d
       call      qword ptr [7FFEDE18E460]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       ecx,0FFFFFFFF
       test      eax,eax
       cmovl     eax,ecx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       ecx,899
       mov       rdx,7FFEDDA109E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFEDD8A6790]
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
       mov       rdx,7FFEDDA109E8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFEDDE9C9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFEDD83D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FFEDE115230]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rbx+2A0]
       mov       rdx,[rcx+28]
       mov       rcx,rsi
       call      qword ptr [7FFEDE115638]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].IndexOfKey(System.__Canon)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rsi
       mov       edx,eax
       call      qword ptr [7FFEDE115698]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE348F48
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
       mov       rdx,7FFEDE3494D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFEDDB6E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE349510
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFEDDB6E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE3495C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFEDD96E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FFEDE1152C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FFEDE348F68
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
       mov       rdx,7FFEDE348F80
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
       mov       rdx,7FFEDE3490E8
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
       mov       rdx,7FFEDE349100
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
       mov       rdx,7FFEDE349298
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFEDE11CE88]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFEDE3492B8
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
       call      qword ptr [7FFEDDEAC870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFEDDEAC7B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEDD79F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFEDDA209E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFEDD8B66E8]
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
       mov       rdx,7FFEDE34AFE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rsi
       mov       rdx,[rbx+18]
       mov       [rsp+28],rdx
       mov       rdx,[rbx+8]
       mov       r9d,[rbx+30]
       xor       r8d,r8d
       call      qword ptr [7FFEDE19E460]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       ecx,0FFFFFFFF
       test      eax,eax
       cmovl     eax,ecx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       ecx,899
       mov       rdx,7FFEDDA209E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFEDD8B6790]
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
       mov       rdx,7FFEDDA209E8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFEDDEAC9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFEDD84D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FFEDE115230]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,[rbx+2A0]
       mov       rdx,[rcx+28]
       mov       rcx,rsi
       call      qword ptr [7FFEDE115638]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].IndexOfKey(System.__Canon)
       test      eax,eax
       jl        short M00_L00
       mov       rcx,rsi
       mov       edx,eax
       call      qword ptr [7FFEDE115698]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE348A50
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
       mov       rdx,7FFEDE348FE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFEDDB6E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE349018
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFEDDB6E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE3490D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFEDD96E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FFEDE1152C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FFEDE348A70
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
       mov       rdx,7FFEDE348A88
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
       mov       rdx,7FFEDE348BF0
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
       mov       rdx,7FFEDE348C08
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
       mov       rdx,7FFEDE348DA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFEDE11CE88]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFEDE348DC0
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
       call      qword ptr [7FFEDDEAC870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFEDDEAC7B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEDD79F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFEDDA209E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFEDD8B66E8]
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
       mov       rdx,7FFEDE34AAE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L01:
       mov       [rsp+20],rsi
       mov       rdx,[rbx+18]
       mov       [rsp+28],rdx
       mov       rdx,[rbx+8]
       mov       r9d,[rbx+30]
       xor       r8d,r8d
       call      qword ptr [7FFEDE19DF50]; System.Array.BinarySearch[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.__Canon, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       ecx,0FFFFFFFF
       test      eax,eax
       cmovl     eax,ecx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       ecx,899
       mov       rdx,7FFEDDA209E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFEDD8B6790]
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
       mov       rdx,7FFEDDA209E8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFEDDEAC9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFEDD84D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M03_L00
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FFEDD83DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp+10]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFEDD846DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE331BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD784348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE331C28
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
       mov       rdx,7FFEDDE4E2F0
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
       mov       rdx,7FFEDE331C40
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
       mov       rdx,7FFEDDE4E2E0
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
       mov       rdx,7FFEDE331BF8
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
       mov       rdx,7FFEDE331C10
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
       call      qword ptr [7FFEDD83E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6410C8
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
       call      qword ptr [7FFEDDA25B18]
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
       mov       rdx,7FFEDDE4E2E0
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
       mov       r11,7FFEDD6410D0
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
       call      qword ptr [7FFEDDA25878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD6D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FFEDD85DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp+10]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFEDD866DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE354D70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD7A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE354DB0
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
       mov       rdx,7FFEDDE6CC20
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
       mov       rdx,7FFEDE354DC8
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
       mov       rdx,7FFEDDE6CC10
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
       mov       rdx,7FFEDE354D80
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
       mov       rdx,7FFEDE354D98
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
       call      qword ptr [7FFEDD85E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6610C8
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
       call      qword ptr [7FFEDDA45B18]
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
       mov       rdx,7FFEDDE6CC10
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
       mov       r11,7FFEDD6610D0
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
       call      qword ptr [7FFEDDA45878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD6F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FFEDD86DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp+10]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFEDD876DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE366740
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD7B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE366780
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
       mov       rdx,7FFEDDE7F960
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
       mov       rdx,7FFEDE366798
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
       mov       rdx,7FFEDDE7F950
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
       mov       rdx,7FFEDE366750
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
       mov       rdx,7FFEDE366768
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
       call      qword ptr [7FFEDD86E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6710C8
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
       call      qword ptr [7FFEDDA55B18]
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
       mov       rdx,7FFEDDE7F950
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
       mov       r11,7FFEDD6710D0
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
       call      qword ptr [7FFEDDA55878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD707750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FFEDD83DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp+10]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFEDD846DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE336270
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD784348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE3362B0
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
       mov       rdx,7FFEDDEB0E80
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
       mov       rdx,7FFEDE3362C8
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
       mov       rdx,7FFEDDEB0E70
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
       mov       rdx,7FFEDE336280
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
       mov       rdx,7FFEDE336298
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
       call      qword ptr [7FFEDD83E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6410C8
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
       call      qword ptr [7FFEDDA25B18]
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
       mov       rdx,7FFEDDEB0E70
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
       mov       r11,7FFEDD6410D0
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
       call      qword ptr [7FFEDDA25878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD6D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FFEDD86DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp+10]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFEDD876DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE367708
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD7B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE367748
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
       mov       rdx,7FFEDDEE0EC0
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
       mov       rdx,7FFEDE367760
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
       mov       rdx,7FFEDDEE0EB0
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
       mov       rdx,7FFEDE367718
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
       mov       rdx,7FFEDE367730
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
       call      qword ptr [7FFEDD86E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6710C8
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
       call      qword ptr [7FFEDDA55B18]
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
       mov       rdx,7FFEDDEE0EB0
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
       mov       r11,7FFEDD6710D0
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
       call      qword ptr [7FFEDDA55878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD707750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FFEDD83DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp+10]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFEDD846DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE337218
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD784348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE337258
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
       mov       rdx,7FFEDDE4DC80
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
       mov       rdx,7FFEDE337270
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
       mov       rdx,7FFEDDE4DC70
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
       mov       rdx,7FFEDE337228
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
       mov       rdx,7FFEDE337240
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
       call      qword ptr [7FFEDD83E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6410C8
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
       call      qword ptr [7FFEDDA25B18]
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
       mov       rdx,7FFEDDE4DC70
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
       mov       r11,7FFEDD6410D0
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
       call      qword ptr [7FFEDDA25878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD6D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FFEDD85DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp+10]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFEDD866DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE3576E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD7A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE357720
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
       mov       rdx,7FFEDDE6CFC8
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
       mov       rdx,7FFEDE357738
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
       mov       rdx,7FFEDDE6CFB8
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
       mov       rdx,7FFEDE3576F0
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
       mov       rdx,7FFEDE357708
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
       call      qword ptr [7FFEDD85E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6610C8
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
       call      qword ptr [7FFEDDA45B18]
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
       mov       rdx,7FFEDDE6CFB8
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
       mov       r11,7FFEDD6610D0
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
       call      qword ptr [7FFEDDA45878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD6F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FFEDD84DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp+10]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFEDD856DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE348778
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD794348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE3487B8
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
       mov       rdx,7FFEDDE5D288
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
       mov       rdx,7FFEDE3487D0
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
       mov       rdx,7FFEDDE5D278
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
       mov       rdx,7FFEDE348788
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
       mov       rdx,7FFEDE3487A0
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
       call      qword ptr [7FFEDD84E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6510C8
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
       call      qword ptr [7FFEDDA35B18]
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
       mov       rdx,7FFEDDE5D278
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
       mov       r11,7FFEDD6510D0
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
       call      qword ptr [7FFEDDA35878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD6E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,11AF2C01FD0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEDD83DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFEDD856DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE30EEA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD784348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE30EEE8
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
       mov       rdx,7FFEDDE7B4D0
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
       mov       rdx,7FFEDE30EF00
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
       mov       rdx,7FFEDDE7B4C0
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
       mov       rdx,7FFEDE30EEB8
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
       mov       rdx,7FFEDE30EED0
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
       call      qword ptr [7FFEDD83E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6411A8
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
       call      qword ptr [7FFEDDA35B18]
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
       mov       rdx,7FFEDDE7B4C0
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
       mov       r11,7FFEDD6411B0
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
       call      qword ptr [7FFEDDA35878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD6D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,23668401FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEDD85DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFEDD866DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE354CE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD7A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE354D20
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
       mov       rdx,7FFEDDE6D108
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
       mov       rdx,7FFEDE354D38
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
       mov       rdx,7FFEDDE6D0F8
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
       mov       rdx,7FFEDE354CF0
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
       mov       rdx,7FFEDE354D08
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
       call      qword ptr [7FFEDD85E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6610C8
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
       call      qword ptr [7FFEDDA45B18]
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
       mov       rdx,7FFEDDE6D0F8
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
       mov       r11,7FFEDD6610D0
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
       call      qword ptr [7FFEDDA45878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD6F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,1BF61C01FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEDD85DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFEDD866DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE355B90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD7A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE355BD0
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
       mov       rdx,7FFEDDE6CAA8
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
       mov       rdx,7FFEDE355BE8
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
       mov       rdx,7FFEDDE6CA98
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
       mov       rdx,7FFEDE355BA0
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
       mov       rdx,7FFEDE355BB8
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
       call      qword ptr [7FFEDD85E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6610D0
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
       call      qword ptr [7FFEDDA45B18]
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
       mov       rdx,7FFEDDE6CA98
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
       mov       r11,7FFEDD6610D8
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
       call      qword ptr [7FFEDDA45878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD6F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,211D9001FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEDD84DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFEDD856DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE3472D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD794348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE347318
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
       mov       rdx,7FFEDDE5CDA0
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
       mov       rdx,7FFEDE347330
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
       mov       rdx,7FFEDDE5CD90
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
       mov       rdx,7FFEDE3472E8
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
       mov       rdx,7FFEDE347300
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
       call      qword ptr [7FFEDD84E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6510C8
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
       call      qword ptr [7FFEDDA35B18]
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
       mov       rdx,7FFEDDE5CD90
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
       mov       r11,7FFEDD6510D0
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
       call      qword ptr [7FFEDDA35878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD6E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,159F0801FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEDD86DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFEDD876DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE3679F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD7B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE367A30
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
       mov       rdx,7FFEDDE7FB90
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
       mov       rdx,7FFEDE367A48
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
       mov       rdx,7FFEDDE7FB80
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
       mov       rdx,7FFEDE367A00
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
       mov       rdx,7FFEDE367A18
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
       call      qword ptr [7FFEDD86E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6710C8
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
       call      qword ptr [7FFEDDA55B18]
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
       mov       rdx,7FFEDDE7FB80
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
       mov       r11,7FFEDD6710D0
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
       call      qword ptr [7FFEDDA55878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD707750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,21DB8401FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEDD83DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFEDD846DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE3379D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD784348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE337A10
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
       mov       rdx,7FFEDDE4CDA0
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
       mov       rdx,7FFEDE337A28
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
       mov       rdx,7FFEDDE4CD90
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
       mov       rdx,7FFEDE3379E0
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
       mov       rdx,7FFEDE3379F8
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
       call      qword ptr [7FFEDD83E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6410C8
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
       call      qword ptr [7FFEDDA25B18]
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
       mov       rdx,7FFEDDE4CD90
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
       mov       r11,7FFEDD6410D0
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
       call      qword ptr [7FFEDDA25878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD6D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,1E8DE801FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEDD86DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFEDD876DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE3683F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD7B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE368430
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
       mov       rdx,7FFEDDE7FEA0
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
       mov       rdx,7FFEDE368448
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
       mov       rdx,7FFEDDE7FE90
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
       mov       rdx,7FFEDE368400
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
       mov       rdx,7FFEDE368418
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
       call      qword ptr [7FFEDD86E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6710C8
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
       call      qword ptr [7FFEDDA55B18]
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
       mov       rdx,7FFEDDE7FE90
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
       mov       r11,7FFEDD6710D0
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
       call      qword ptr [7FFEDDA55878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD707750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,2FC78C01FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEDD86DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFEDD876DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE368058
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD7B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE368098
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
       mov       rdx,7FFEDDE7D288
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
       mov       rdx,7FFEDE3680B0
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
       mov       rdx,7FFEDDE7D278
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
       mov       rdx,7FFEDE368068
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
       mov       rdx,7FFEDE368080
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
       call      qword ptr [7FFEDD86E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6710D0
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
       call      qword ptr [7FFEDDA55B18]
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
       mov       rdx,7FFEDDE7D278
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
       mov       r11,7FFEDD6710D8
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
       call      qword ptr [7FFEDDA55878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD707750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,1BB3E401FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEDD83DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFEDD846DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE331BE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD784348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE331C20
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
       mov       rdx,7FFEDDE4D108
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
       mov       rdx,7FFEDE331C38
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
       mov       rdx,7FFEDDE4D0F8
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
       mov       rdx,7FFEDE331BF0
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
       mov       rdx,7FFEDE331C08
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
       call      qword ptr [7FFEDD83E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6410C8
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
       call      qword ptr [7FFEDDA25B18]
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
       mov       rdx,7FFEDDE4D0F8
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
       mov       r11,7FFEDD6410D0
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
       call      qword ptr [7FFEDDA25878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD6D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,2AFF6801FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEDD85DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFEDD866DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE3545C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD7A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE354608
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
       mov       rdx,7FFEDDE6CF78
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
       mov       rdx,7FFEDE354620
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
       mov       rdx,7FFEDDE6CF68
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
       mov       rdx,7FFEDE3545D8
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
       mov       rdx,7FFEDE3545F0
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
       call      qword ptr [7FFEDD85E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6610C8
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
       call      qword ptr [7FFEDDA45B18]
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
       mov       rdx,7FFEDDE6CF68
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
       mov       r11,7FFEDD6610D0
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
       call      qword ptr [7FFEDDA45878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD6F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,17CBBC01FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEDD83DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFEDD846DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE335C20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD784348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE335C60
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
       mov       rdx,7FFEDDEB0430
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
       mov       rdx,7FFEDE335C78
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
       mov       rdx,7FFEDDEB0420
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
       mov       rdx,7FFEDE335C30
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
       mov       rdx,7FFEDE335C48
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
       call      qword ptr [7FFEDD83E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6410C8
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
       call      qword ptr [7FFEDDA25B18]
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
       mov       rdx,7FFEDDEB0420
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
       mov       r11,7FFEDD6410D0
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
       call      qword ptr [7FFEDDA25878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD6D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,189BE801FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEDD83DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFEDD846DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE3365A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD784348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE3365E0
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
       mov       rdx,7FFEDDE4D378
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
       mov       rdx,7FFEDE3365F8
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
       mov       rdx,7FFEDDE4D368
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
       mov       rdx,7FFEDE3365B0
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
       mov       rdx,7FFEDE3365C8
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
       call      qword ptr [7FFEDD83E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6410C8
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
       call      qword ptr [7FFEDDA25B18]
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
       mov       rdx,7FFEDDE4D368
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
       mov       r11,7FFEDD6410D0
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
       call      qword ptr [7FFEDDA25878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD6D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,205F7401FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEDD83DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFEDD846DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE337C78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD784348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE337CB8
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
       mov       rdx,7FFEDDEB0340
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
       mov       rdx,7FFEDE337CD0
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
       mov       rdx,7FFEDDEB0330
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
       mov       rdx,7FFEDE337C88
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
       mov       rdx,7FFEDE337CA0
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
       call      qword ptr [7FFEDD83E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6410C8
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
       call      qword ptr [7FFEDDA25B18]
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
       mov       rdx,7FFEDDEB0330
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
       mov       r11,7FFEDD6410D0
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
       call      qword ptr [7FFEDDA25878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD6D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,172B5C01FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEDD86DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFEDD876DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE3671F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD7B4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE367230
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
       mov       rdx,7FFEDDE7D328
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
       mov       rdx,7FFEDE367248
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
       mov       rdx,7FFEDDE7D318
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
       mov       rdx,7FFEDE367200
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
       mov       rdx,7FFEDE367218
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
       call      qword ptr [7FFEDD86E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6710C8
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
       call      qword ptr [7FFEDDA55B18]
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
       mov       rdx,7FFEDDE7D318
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
       mov       r11,7FFEDD6710D0
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
       call      qword ptr [7FFEDDA55878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD707750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,2314F801FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEDD84DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFEDD856DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE348148
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD794348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE348188
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
       mov       rdx,7FFEDDE5FE38
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
       mov       rdx,7FFEDE3481A0
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
       mov       rdx,7FFEDDE5FE28
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
       mov       rdx,7FFEDE348158
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
       mov       rdx,7FFEDE348170
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
       call      qword ptr [7FFEDD84E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6510C8
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
       call      qword ptr [7FFEDDA35B18]
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
       mov       rdx,7FFEDDE5FE28
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
       mov       r11,7FFEDD6510D0
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
       call      qword ptr [7FFEDDA35878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD6E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       rcx,15363001FC8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFEDD83DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+10]
       dec       edx
       mov       rcx,rdi
       call      qword ptr [7FFEDD846DB8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE337E50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEDD784348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFEDE337E90
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
       mov       rdx,7FFEDDE4D288
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
       mov       rdx,7FFEDE337EA8
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
       mov       rdx,7FFEDDE4D278
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
       mov       rdx,7FFEDE337E60
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
       mov       rdx,7FFEDE337E78
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
       call      qword ptr [7FFEDD83E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFEDD6410C8
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
       call      qword ptr [7FFEDDA25B18]
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
       mov       rdx,7FFEDDE4D278
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
       mov       r11,7FFEDD6410D0
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
       call      qword ptr [7FFEDDA25878]
       int       3
M02_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFEDD6D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FFEDE0BF9F0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       edx,[rbp+30]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFEDE0BFE58]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,rbx
       test      rsi,rsi
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
       mov       rdx,7FFEDE3325D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r14,rax
M01_L01:
       mov       r11,r14
       mov       rcx,rsi
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
       mov       rdx,7FFEDE332B60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFEDDB5E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE332B98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFEDDB5E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE332C50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFEDD95E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M01_L08
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,rbx
       mov       edx,r15d
       call      qword ptr [7FFEDE0BFA80]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r11,r14
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
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
       mov       rdx,7FFEDE3325F0
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
       mov       rdx,7FFEDE332608
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L12:
       mov       rcx,rsi
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
       mov       rdx,7FFEDE332770
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
       mov       rdx,7FFEDE332788
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r13,rax
M01_L16:
       mov       rcx,rsi
       mov       r11,r15
       call      qword ptr [r15]
       mov       rcx,rax
       mov       rdx,[rbx+10]
       mov       r11,r13
       xor       r8d,r8d
       call      qword ptr [r13]
       cmp       edi,1
       jle       near ptr M01_L21
       mov       rcx,[rbx+18]
       mov       rsi,rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C8]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,7FFEDE332920
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rbx+10]
       mov       rdx,r14
       mov       r9,rsi
       call      qword ptr [7FFEDE107468]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFEDE332940
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r12,rax
M01_L20:
       mov       r11,r12
       lea       edx,[r15-1]
       cmp       edx,r13d
       jae       near ptr M01_L24
       lea       edx,[r15-1]
       mov       rdx,[r14+rdx*8+10]
       mov       r8d,r15d
       mov       r8,[r14+r8*8+10]
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L22
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L20
M01_L21:
       mov       [rbx+30],edi
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
       call      qword ptr [7FFEDDE9C870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFEDDE9C7B0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFEDD78F708]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFEDDA109E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFEDD8A66E8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 884
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
       mov       rdx,7FFEDDA109E8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFEDDE9C9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFEDD83D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FFEDE0BF9F0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       edx,[rbp+30]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFEDE0BFE58]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE335388
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
       mov       rdx,7FFEDE335918
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFEDDB5E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE335950
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFEDDB5E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE335A08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFEDD95E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FFEDE0BFA80]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,offset System.Buffers.Utilities.GetMaxSizeForBucket(Int32)
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
       mov       rdx,7FFEDE3353C0
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
       mov       rdx,7FFEDE335528
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
       mov       rdx,7FFEDE335540
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
       mov       rdx,7FFEDE3356D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rbx+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFEDE107468]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFEDE3356F8
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
       call      qword ptr [7FFEDDE9C888]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFEDDE9C7C8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFEDD78F708]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFEDDA109E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFEDD8A66E8]
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
       mov       rdx,7FFEDDA109E8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFEDDE9CA08]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFEDD83D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FFEDE0CF9F0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       edx,[rbp+30]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFEDE0CFE58]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE345EB0
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
       mov       rdx,7FFEDE346440
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFEDDB6E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE346478
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFEDDB6E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE346530
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFEDD96E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FFEDE0CFA80]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FFEDE345ED0
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
       mov       rdx,7FFEDE345EE8
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
       mov       rdx,7FFEDE346050
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
       mov       rdx,7FFEDE346068
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
       mov       rdx,7FFEDE346200
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rbx+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFEDE117468]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFEDE346220
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
       call      qword ptr [7FFEDDEAC870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFEDDEAC7B0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFEDD79F708]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFEDDA209E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFEDD8B66E8]
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
       mov       rdx,7FFEDDA209E8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFEDDEAC9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFEDD84D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FFEDE0DF9F0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       edx,[rbp+30]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFEDE0DFE58]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE356600
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
       mov       rdx,7FFEDE356B90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFEDDB7E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE356BC8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFEDDB7E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE356C80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFEDD97E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FFEDE0DFA80]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FFEDE356620
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
       mov       rdx,7FFEDE356638
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
       mov       rdx,7FFEDE3567A0
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
       mov       rdx,7FFEDE3567B8
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
       mov       rdx,7FFEDE356950
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFEDE127468]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFEDE356970
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
       call      qword ptr [7FFEDDEBC870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFEDDEBC7B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEDD7AF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFEDDA309E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFEDD8C66E8]
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
       mov       rdx,7FFEDDA309E8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFEDDEBC9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFEDD85D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FFEDE115230]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       edx,[rbp+30]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFEDE115698]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE347E10
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
       mov       rdx,7FFEDE3483A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFEDDB6E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE3483D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFEDDB6E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE348490
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFEDD96E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FFEDE1152C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FFEDE347E30
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
       mov       rdx,7FFEDE347E48
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
       mov       rdx,7FFEDE347FB0
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
       mov       rdx,7FFEDE347FC8
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
       mov       rdx,7FFEDE348160
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFEDE11CE88]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFEDE348180
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
       call      qword ptr [7FFEDDEAC888]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFEDDEAC7C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEDD79F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFEDDA209E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFEDD8B66E8]
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
       mov       rdx,7FFEDDA209E8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFEDDEACA08]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFEDD84D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FFEDE105230]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       edx,[rbp+30]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFEDE105698]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE338750
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
       mov       rdx,7FFEDE338CE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFEDDB5E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE338D18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFEDDB5E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE338DD0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFEDD95E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FFEDE1052C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FFEDE338770
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
       mov       rdx,7FFEDE338788
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
       mov       rdx,7FFEDE3388F0
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
       mov       rdx,7FFEDE338908
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
       mov       rdx,7FFEDE338AA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFEDE10CE88]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFEDE338AC0
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
       call      qword ptr [7FFEDDE9C870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFEDDE9C7B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEDD78F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFEDDA109E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFEDD8A66E8]
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
       mov       rdx,7FFEDDA109E8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFEDDE9C9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFEDD83D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FFEDE105230]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       edx,[rbp+30]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFEDE105698]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE3383F8
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
       mov       rdx,7FFEDE338988
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFEDDB5E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE3389C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFEDDB5E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE338A78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFEDD95E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FFEDE1052C0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FFEDE338418
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
       mov       rdx,7FFEDE338430
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
       mov       rdx,7FFEDE338598
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
       mov       rdx,7FFEDE3385B0
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
       mov       rdx,7FFEDE338748
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFEDE10CE88]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFEDE338768
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
       call      qword ptr [7FFEDDE9CB88]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFEDDE9CAC8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEDD78F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFEDDA109E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFEDD8A66E8]
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
       mov       rdx,7FFEDDA109E8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFEDDE9CD08]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFEDD83D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FFEDE1259B0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       edx,[rbp+30]
       dec       edx
       mov       rcx,rbp
       call      qword ptr [7FFEDE125E18]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FFEDE358A78
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
       mov       rdx,7FFEDE359008
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      qword ptr [7FFEDDB7E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE359040
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      qword ptr [7FFEDDB7E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rdx,7FFEDE3590F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      qword ptr [7FFEDD97E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FFEDE125A40]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rdx,7FFEDE358A98
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
       mov       rdx,7FFEDE358AB0
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
       mov       rdx,7FFEDE358C18
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
       mov       rdx,7FFEDE358C30
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
       mov       rdx,7FFEDE358DC8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L18:
       mov       r8,[rsi+10]
       mov       rdx,r14
       mov       r9,rdi
       call      qword ptr [7FFEDE12D470]; System.Array.Sort[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[], System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFEDE358DE8
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
       call      qword ptr [7FFEDDEBC870]
       mov       rcx,rax
       mov       edx,r15d
       mov       rdx,[r14+rdx*8+10]
       call      qword ptr [7FFEDDEBC7B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEDD7AF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,7ED
       mov       rdx,7FFEDDA309E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFEDD8C66E8]
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
       mov       rdx,7FFEDDA309E8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFEDDEBC9F0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FFEDD85D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FFEDD6F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M02_L00
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

