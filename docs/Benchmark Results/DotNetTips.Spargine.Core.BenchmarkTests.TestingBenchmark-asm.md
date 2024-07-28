## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       mov       rsi,rcx
       mov       rdi,[rbx+40]
       xor       ebp,ebp
       cmp       dword ptr [rcx+8],1
       setg      bpl
       test      rdi,rdi
       jne       short M00_L02
M00_L00:
       mov       [rsp+28],rsi
       mov       rbp,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbp+8],rax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       test      ebp,ebp
       je        short M00_L00
       mov       [rsp+30],rsi
       mov       rsi,[rsp+30]
       test      rsi,rsi
       jne       near ptr M00_L03
       call      qword ptr [7FFF3A7D6CE8]
       mov       ecx,3
       mov       rdx,7FFF3A76AFC0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFF3A607D70
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF3A326B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFF3A76AFC0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF3A326B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF3A7D6AD8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF3A506670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       [rsp+30],rsi
       mov       rdx,[rsp+30]
       mov       esi,[rdx+8]
       add       esi,1
       jo        near ptr M00_L01
       lea       rdx,[rsp+30]
       mov       r8d,esi
       mov       rcx,offset MD_System.Array.Resize[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[] ByRef, Int32)
       call      qword ptr [7FFF3A555908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,esi
       sub       ecx,1
       jo        near ptr M00_L01
       mov       rdx,[rsp+30]
       cmp       ecx,[rdx+8]
       jae       short M00_L04
       mov       rcx,[rsp+30]
       sub       esi,1
       jo        near ptr M00_L01
       mov       edx,esi
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rsp+30]
       jmp       near ptr M00_L00
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 376
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF3A3D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF3A3D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFF3A4DEF10]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,220E2E40008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```
```assembly
; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       test      ebx,ebx
       jl        near ptr M02_L02
       mov       rbp,[rdi]
       test      rbp,rbp
       je        short M02_L01
       mov       r14d,[rbp+8]
       cmp       r14d,ebx
       je        short M02_L00
       mov       rcx,rsi
       call      qword ptr [7FFF99CD7360]
       mov       rcx,rax
       movsxd    rdx,ebx
       call      qword ptr [7FFF99CD2DC0]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       r15,rax
       lea       r13,[r15+10]
       add       rbp,10
       cmp       ebx,r14d
       cmovg     ebx,r14d
       mov       rcx,rsi
       call      qword ptr [7FFF99CD7610]
       mov       rcx,rax
       mov       r9d,ebx
       mov       rdx,r13
       mov       r8,rbp
       call      qword ptr [7FFF99CF8420]; Precode of System.Buffer.Memmove[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFF99CD2D38]; CORINFO_HELP_CHECKED_ASSIGN_REF
M02_L00:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rsi
       call      qword ptr [7FFF99CD7360]
       mov       rcx,rax
       movsxd    rdx,ebx
       call      qword ptr [7FFF99CD2DC0]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF99CD2D38]; CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFF99CE58D8]
       int       3
; Total bytes of code 213
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       mov       rsi,rcx
       mov       rdi,[rbx+40]
       xor       ebp,ebp
       cmp       dword ptr [rcx+8],1
       setg      bpl
       test      rdi,rdi
       jne       short M00_L02
M00_L00:
       mov       [rsp+28],rsi
       mov       rbp,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbp+8],rax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       test      ebp,ebp
       je        short M00_L00
       mov       [rsp+30],rsi
       mov       rsi,[rsp+30]
       test      rsi,rsi
       jne       near ptr M00_L03
       call      qword ptr [7FFF3A7F7810]
       mov       ecx,3
       mov       rdx,7FFF3A79AFC0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFF3A637DC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF3A356B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFF3A79AFC0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF3A356B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF3A7F7600]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF3A536670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       [rsp+30],rsi
       mov       rdx,[rsp+30]
       mov       esi,[rdx+8]
       add       esi,1
       jo        near ptr M00_L01
       lea       rdx,[rsp+30]
       mov       r8d,esi
       mov       rcx,offset MD_System.Array.Resize[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[] ByRef, Int32)
       call      qword ptr [7FFF3A585908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,esi
       sub       ecx,1
       jo        near ptr M00_L01
       mov       rdx,[rsp+30]
       cmp       ecx,[rdx+8]
       jae       short M00_L04
       mov       rcx,[rsp+30]
       sub       esi,1
       jo        near ptr M00_L01
       mov       edx,esi
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rsp+30]
       jmp       near ptr M00_L00
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 376
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF3A405B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF3A405B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFF3A50EF10]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,1C441AE0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```
```assembly
; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       test      ebx,ebx
       jl        near ptr M02_L02
       mov       rbp,[rdi]
       test      rbp,rbp
       je        short M02_L01
       mov       r14d,[rbp+8]
       cmp       r14d,ebx
       je        short M02_L00
       mov       rcx,rsi
       call      qword ptr [7FFF99CD7360]
       mov       rcx,rax
       movsxd    rdx,ebx
       call      qword ptr [7FFF99CD2DC0]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       r15,rax
       lea       r13,[r15+10]
       add       rbp,10
       cmp       ebx,r14d
       cmovg     ebx,r14d
       mov       rcx,rsi
       call      qword ptr [7FFF99CD7610]
       mov       rcx,rax
       mov       r9d,ebx
       mov       rdx,r13
       mov       r8,rbp
       call      qword ptr [7FFF99CF8420]; Precode of System.Buffer.Memmove[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFF99CD2D38]; CORINFO_HELP_CHECKED_ASSIGN_REF
M02_L00:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rsi
       call      qword ptr [7FFF99CD7360]
       mov       rcx,rax
       movsxd    rdx,ebx
       call      qword ptr [7FFF99CD2DC0]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF99CD2D38]; CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFF99CE58D8]
       int       3
; Total bytes of code 213
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       mov       rsi,rcx
       mov       rdi,[rbx+40]
       xor       ebp,ebp
       cmp       dword ptr [rcx+8],1
       setg      bpl
       test      rdi,rdi
       jne       short M00_L02
M00_L00:
       mov       [rsp+28],rsi
       mov       rbp,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbp+8],rax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       test      ebp,ebp
       je        short M00_L00
       mov       [rsp+30],rsi
       mov       rsi,[rsp+30]
       test      rsi,rsi
       jne       near ptr M00_L03
       call      qword ptr [7FFF3A7E6CE8]
       mov       ecx,3
       mov       rdx,7FFF3A77AFC0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFF3A617D70
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF3A336B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFF3A77AFC0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF3A336B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF3A7E6AD8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF3A516670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       [rsp+30],rsi
       mov       rdx,[rsp+30]
       mov       esi,[rdx+8]
       add       esi,1
       jo        near ptr M00_L01
       lea       rdx,[rsp+30]
       mov       r8d,esi
       mov       rcx,offset MD_System.Array.Resize[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[] ByRef, Int32)
       call      qword ptr [7FFF3A565908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,esi
       sub       ecx,1
       jo        near ptr M00_L01
       mov       rdx,[rsp+30]
       cmp       ecx,[rdx+8]
       jae       short M00_L04
       mov       rcx,[rsp+30]
       sub       esi,1
       jo        near ptr M00_L01
       mov       edx,esi
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rsp+30]
       jmp       near ptr M00_L00
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 376
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF3A3E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF3A3E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFF3A4EEF10]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,1ADB9DA0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```
```assembly
; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       test      ebx,ebx
       jl        near ptr M02_L02
       mov       rbp,[rdi]
       test      rbp,rbp
       je        short M02_L01
       mov       r14d,[rbp+8]
       cmp       r14d,ebx
       je        short M02_L00
       mov       rcx,rsi
       call      qword ptr [7FFF99CD7360]
       mov       rcx,rax
       movsxd    rdx,ebx
       call      qword ptr [7FFF99CD2DC0]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       r15,rax
       lea       r13,[r15+10]
       add       rbp,10
       cmp       ebx,r14d
       cmovg     ebx,r14d
       mov       rcx,rsi
       call      qword ptr [7FFF99CD7610]
       mov       rcx,rax
       mov       r9d,ebx
       mov       rdx,r13
       mov       r8,rbp
       call      qword ptr [7FFF99CF8420]; Precode of System.Buffer.Memmove[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFF99CD2D38]; CORINFO_HELP_CHECKED_ASSIGN_REF
M02_L00:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rsi
       call      qword ptr [7FFF99CD7360]
       mov       rcx,rax
       movsxd    rdx,ebx
       call      qword ptr [7FFF99CD2DC0]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF99CD2D38]; CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFF99CE58D8]
       int       3
; Total bytes of code 213
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       mov       rsi,rcx
       mov       rdi,[rbx+40]
       xor       ebp,ebp
       cmp       dword ptr [rcx+8],1
       setg      bpl
       test      rdi,rdi
       jne       short M00_L02
M00_L00:
       mov       [rsp+28],rsi
       mov       rbp,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbp+8],rax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       test      ebp,ebp
       je        short M00_L00
       mov       [rsp+30],rsi
       mov       rsi,[rsp+30]
       test      rsi,rsi
       jne       near ptr M00_L03
       call      qword ptr [7FFF3A7D6CE8]
       mov       ecx,3
       mov       rdx,7FFF3A76AFC0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFF3A607D70
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF3A326B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFF3A76AFC0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF3A326B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF3A7D6AD8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF3A506670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       [rsp+30],rsi
       mov       rdx,[rsp+30]
       mov       esi,[rdx+8]
       add       esi,1
       jo        near ptr M00_L01
       lea       rdx,[rsp+30]
       mov       r8d,esi
       mov       rcx,offset MD_System.Array.Resize[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[] ByRef, Int32)
       call      qword ptr [7FFF3A555908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,esi
       sub       ecx,1
       jo        near ptr M00_L01
       mov       rdx,[rsp+30]
       cmp       ecx,[rdx+8]
       jae       short M00_L04
       mov       rcx,[rsp+30]
       sub       esi,1
       jo        near ptr M00_L01
       mov       edx,esi
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rsp+30]
       jmp       near ptr M00_L00
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 376
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF3A3D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF3A3D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFF3A4DEF10]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,2A834C50008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```
```assembly
; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       test      ebx,ebx
       jl        near ptr M02_L02
       mov       rbp,[rdi]
       test      rbp,rbp
       je        short M02_L01
       mov       r14d,[rbp+8]
       cmp       r14d,ebx
       je        short M02_L00
       mov       rcx,rsi
       call      qword ptr [7FFF99CD7360]
       mov       rcx,rax
       movsxd    rdx,ebx
       call      qword ptr [7FFF99CD2DC0]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       r15,rax
       lea       r13,[r15+10]
       add       rbp,10
       cmp       ebx,r14d
       cmovg     ebx,r14d
       mov       rcx,rsi
       call      qword ptr [7FFF99CD7610]
       mov       rcx,rax
       mov       r9d,ebx
       mov       rdx,r13
       mov       r8,rbp
       call      qword ptr [7FFF99CF8420]; Precode of System.Buffer.Memmove[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFF99CD2D38]; CORINFO_HELP_CHECKED_ASSIGN_REF
M02_L00:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rsi
       call      qword ptr [7FFF99CD7360]
       mov       rcx,rax
       movsxd    rdx,ebx
       call      qword ptr [7FFF99CD2DC0]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF99CD2D38]; CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFF99CE58D8]
       int       3
; Total bytes of code 213
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       mov       rsi,rcx
       mov       rdi,[rbx+40]
       xor       ebp,ebp
       cmp       dword ptr [rcx+8],1
       setg      bpl
       test      rdi,rdi
       jne       short M00_L02
M00_L00:
       mov       [rsp+28],rsi
       mov       rbp,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbp+8],rax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       test      ebp,ebp
       je        short M00_L00
       mov       [rsp+30],rsi
       mov       rsi,[rsp+30]
       test      rsi,rsi
       jne       near ptr M00_L03
       call      qword ptr [7FFF3A7D7810]
       mov       ecx,3
       mov       rdx,7FFF3A77AFC0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFF3A617DC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF3A336B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFF3A77AFC0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF3A336B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF3A7D7600]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF3A516670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       [rsp+30],rsi
       mov       rdx,[rsp+30]
       mov       esi,[rdx+8]
       add       esi,1
       jo        near ptr M00_L01
       lea       rdx,[rsp+30]
       mov       r8d,esi
       mov       rcx,offset MD_System.Array.Resize[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[] ByRef, Int32)
       call      qword ptr [7FFF3A565908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,esi
       sub       ecx,1
       jo        near ptr M00_L01
       mov       rdx,[rsp+30]
       cmp       ecx,[rdx+8]
       jae       short M00_L04
       mov       rcx,[rsp+30]
       sub       esi,1
       jo        near ptr M00_L01
       mov       edx,esi
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rsp+30]
       jmp       near ptr M00_L00
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 376
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF3A3E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF3A3E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFF3A4EEF10]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,31489AF0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```
```assembly
; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       test      ebx,ebx
       jl        near ptr M02_L02
       mov       rbp,[rdi]
       test      rbp,rbp
       je        short M02_L01
       mov       r14d,[rbp+8]
       cmp       r14d,ebx
       je        short M02_L00
       mov       rcx,rsi
       call      qword ptr [7FFF99CD7360]
       mov       rcx,rax
       movsxd    rdx,ebx
       call      qword ptr [7FFF99CD2DC0]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       r15,rax
       lea       r13,[r15+10]
       add       rbp,10
       cmp       ebx,r14d
       cmovg     ebx,r14d
       mov       rcx,rsi
       call      qword ptr [7FFF99CD7610]
       mov       rcx,rax
       mov       r9d,ebx
       mov       rdx,r13
       mov       r8,rbp
       call      qword ptr [7FFF99CF8420]; Precode of System.Buffer.Memmove[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFF99CD2D38]; CORINFO_HELP_CHECKED_ASSIGN_REF
M02_L00:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rsi
       call      qword ptr [7FFF99CD7360]
       mov       rcx,rax
       movsxd    rdx,ebx
       call      qword ptr [7FFF99CD2DC0]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF99CD2D38]; CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFF99CE58D8]
       int       3
; Total bytes of code 213
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       mov       rsi,rcx
       mov       rdi,[rbx+40]
       xor       ebp,ebp
       cmp       dword ptr [rcx+8],1
       setg      bpl
       test      rdi,rdi
       jne       short M00_L02
M00_L00:
       mov       [rsp+28],rsi
       mov       rbp,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbp+8],rax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       test      ebp,ebp
       je        short M00_L00
       mov       [rsp+30],rsi
       mov       rsi,[rsp+30]
       test      rsi,rsi
       jne       near ptr M00_L03
       call      qword ptr [7FFF3A7E7810]
       mov       ecx,3
       mov       rdx,7FFF3A78AFC0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFF3A627DC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF3A346B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFF3A78AFC0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF3A346B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF3A7E7600]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF3A526670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       [rsp+30],rsi
       mov       rdx,[rsp+30]
       mov       esi,[rdx+8]
       add       esi,1
       jo        near ptr M00_L01
       lea       rdx,[rsp+30]
       mov       r8d,esi
       mov       rcx,offset MD_System.Array.Resize[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[] ByRef, Int32)
       call      qword ptr [7FFF3A575908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,esi
       sub       ecx,1
       jo        near ptr M00_L01
       mov       rdx,[rsp+30]
       cmp       ecx,[rdx+8]
       jae       short M00_L04
       mov       rcx,[rsp+30]
       sub       esi,1
       jo        near ptr M00_L01
       mov       edx,esi
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rsp+30]
       jmp       near ptr M00_L00
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 376
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF3A3F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF3A3F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFF3A4FEF10]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,23025E30008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```
```assembly
; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       test      ebx,ebx
       jl        near ptr M02_L02
       mov       rbp,[rdi]
       test      rbp,rbp
       je        short M02_L01
       mov       r14d,[rbp+8]
       cmp       r14d,ebx
       je        short M02_L00
       mov       rcx,rsi
       call      qword ptr [7FFF99CD7360]
       mov       rcx,rax
       movsxd    rdx,ebx
       call      qword ptr [7FFF99CD2DC0]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       r15,rax
       lea       r13,[r15+10]
       add       rbp,10
       cmp       ebx,r14d
       cmovg     ebx,r14d
       mov       rcx,rsi
       call      qword ptr [7FFF99CD7610]
       mov       rcx,rax
       mov       r9d,ebx
       mov       rdx,r13
       mov       r8,rbp
       call      qword ptr [7FFF99CF8420]; Precode of System.Buffer.Memmove[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFF99CD2D38]; CORINFO_HELP_CHECKED_ASSIGN_REF
M02_L00:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rsi
       call      qword ptr [7FFF99CD7360]
       mov       rcx,rax
       movsxd    rdx,ebx
       call      qword ptr [7FFF99CD2DC0]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF99CD2D38]; CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFF99CE58D8]
       int       3
; Total bytes of code 213
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       mov       rsi,rcx
       mov       rdi,[rbx+40]
       xor       ebp,ebp
       cmp       dword ptr [rcx+8],1
       setg      bpl
       test      rdi,rdi
       jne       short M00_L02
M00_L00:
       mov       [rsp+28],rsi
       mov       rbp,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbp+8],rax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       test      ebp,ebp
       je        short M00_L00
       mov       [rsp+30],rsi
       mov       rsi,[rsp+30]
       test      rsi,rsi
       jne       near ptr M00_L03
       call      qword ptr [7FFF3A7F7810]
       mov       ecx,3
       mov       rdx,7FFF3A79AFC0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFF3A637DC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF3A356B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFF3A79AFC0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF3A356B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF3A7F7600]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF3A536670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       [rsp+30],rsi
       mov       rdx,[rsp+30]
       mov       esi,[rdx+8]
       add       esi,1
       jo        near ptr M00_L01
       lea       rdx,[rsp+30]
       mov       r8d,esi
       mov       rcx,offset MD_System.Array.Resize[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[] ByRef, Int32)
       call      qword ptr [7FFF3A585908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,esi
       sub       ecx,1
       jo        near ptr M00_L01
       mov       rdx,[rsp+30]
       cmp       ecx,[rdx+8]
       jae       short M00_L04
       mov       rcx,[rsp+30]
       sub       esi,1
       jo        near ptr M00_L01
       mov       edx,esi
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rsp+30]
       jmp       near ptr M00_L00
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 376
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF3A405B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF3A405B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFF3A50EF10]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,23651600008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```
```assembly
; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       test      ebx,ebx
       jl        near ptr M02_L02
       mov       rbp,[rdi]
       test      rbp,rbp
       je        short M02_L01
       mov       r14d,[rbp+8]
       cmp       r14d,ebx
       je        short M02_L00
       mov       rcx,rsi
       call      qword ptr [7FFF99CD7360]
       mov       rcx,rax
       movsxd    rdx,ebx
       call      qword ptr [7FFF99CD2DC0]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       r15,rax
       lea       r13,[r15+10]
       add       rbp,10
       cmp       ebx,r14d
       cmovg     ebx,r14d
       mov       rcx,rsi
       call      qword ptr [7FFF99CD7610]
       mov       rcx,rax
       mov       r9d,ebx
       mov       rdx,r13
       mov       r8,rbp
       call      qword ptr [7FFF99CF8420]; Precode of System.Buffer.Memmove[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFF99CD2D38]; CORINFO_HELP_CHECKED_ASSIGN_REF
M02_L00:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rsi
       call      qword ptr [7FFF99CD7360]
       mov       rcx,rax
       movsxd    rdx,ebx
       call      qword ptr [7FFF99CD2DC0]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF99CD2D38]; CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFF99CE58D8]
       int       3
; Total bytes of code 213
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       mov       rsi,rcx
       mov       rdi,[rbx+40]
       xor       ebp,ebp
       cmp       dword ptr [rcx+8],1
       setg      bpl
       test      rdi,rdi
       jne       short M00_L02
M00_L00:
       mov       [rsp+28],rsi
       mov       rbp,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbp+8],rax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       test      ebp,ebp
       je        short M00_L00
       mov       [rsp+30],rsi
       mov       rsi,[rsp+30]
       test      rsi,rsi
       jne       near ptr M00_L03
       call      qword ptr [7FFF3A806CE8]
       mov       ecx,3
       mov       rdx,7FFF3A79AFC0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFF3A637D70
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF3A356B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFF3A79AFC0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF3A356B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF3A806AD8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF3A536670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       [rsp+30],rsi
       mov       rdx,[rsp+30]
       mov       esi,[rdx+8]
       add       esi,1
       jo        near ptr M00_L01
       lea       rdx,[rsp+30]
       mov       r8d,esi
       mov       rcx,offset MD_System.Array.Resize[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[] ByRef, Int32)
       call      qword ptr [7FFF3A585908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,esi
       sub       ecx,1
       jo        near ptr M00_L01
       mov       rdx,[rsp+30]
       cmp       ecx,[rdx+8]
       jae       short M00_L04
       mov       rcx,[rsp+30]
       sub       esi,1
       jo        near ptr M00_L01
       mov       edx,esi
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rsp+30]
       jmp       near ptr M00_L00
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 376
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M01_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M01_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF3A405B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF3A405B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       call      qword ptr [7FFF3A50EF10]
       int       3
M01_L02:
       test      rbx,rbx
       je        short M01_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rax,295D2F90008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```
```assembly
; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       test      ebx,ebx
       jl        near ptr M02_L02
       mov       rbp,[rdi]
       test      rbp,rbp
       je        short M02_L01
       mov       r14d,[rbp+8]
       cmp       r14d,ebx
       je        short M02_L00
       mov       rcx,rsi
       call      qword ptr [7FFF99CD7360]
       mov       rcx,rax
       movsxd    rdx,ebx
       call      qword ptr [7FFF99CD2DC0]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       r15,rax
       lea       r13,[r15+10]
       add       rbp,10
       cmp       ebx,r14d
       cmovg     ebx,r14d
       mov       rcx,rsi
       call      qword ptr [7FFF99CD7610]
       mov       rcx,rax
       mov       r9d,ebx
       mov       rdx,r13
       mov       r8,rbp
       call      qword ptr [7FFF99CF8420]; Precode of System.Buffer.Memmove[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFF99CD2D38]; CORINFO_HELP_CHECKED_ASSIGN_REF
M02_L00:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rsi
       call      qword ptr [7FFF99CD7360]
       mov       rcx,rax
       movsxd    rdx,ebx
       call      qword ptr [7FFF99CD2DC0]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF99CD2D38]; CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFF99CE58D8]
       int       3
; Total bytes of code 213
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rbp,[rbx+198]
       mov       r14,rbp
       lea       rsi,[rbx+78]
       lea       rdi,[rsp+30]
       mov       ecx,9
       rep movsq
       xor       edx,edx
       cmp       dword ptr [rbp+8],1
       setg      dl
       test      edx,edx
       je        near ptr M00_L03
       mov       esi,[r14+8]
       mov       ebp,esi
       add       ebp,1
       jo        near ptr M00_L02
       test      ebp,ebp
       jl        near ptr M00_L04
       mov       r15,r14
       cmp       esi,ebp
       je        short M00_L00
       movsxd    rdx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       lea       rcx,[r14+10]
       lea       rdx,[r15+10]
       cmp       ebp,esi
       mov       r8d,esi
       cmovle    r8d,ebp
       lea       r8,[r8+r8*8]
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L05
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M00_L00:
       sub       ebp,1
       jo        short M00_L02
       cmp       ebp,[r14+8]
       jae       near ptr M00_L06
       mov       eax,ebp
       lea       rax,[rax+rax*8]
       lea       rdi,[r14+rax*8+10]
       lea       rsi,[rsp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
M00_L01:
       mov       [rsp+28],r14
       mov       r14,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+8],rcx
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L02:
       call      CORINFO_HELP_OVERFLOW
M00_L03:
       jmp       short M00_L01
M00_L04:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFF3A4FED18]
       int       3
M00_L05:
       call      qword ptr [7FFF3A3F5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L00
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 313
```
```assembly
; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M01_L02
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M01_L03
M01_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFF99CE0D08]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rbx,4000
       add       rsi,4000
       cmp       rdi,4000
       ja        short M01_L00
M01_L01:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFF99CE0D08]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFF99CE0D08]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       rdi,4000
       ja        short M01_L03
       jmp       short M01_L01
; Total bytes of code 150
```
**Extern method**
System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rbp,[rbx+198]
       mov       r14,rbp
       lea       rsi,[rbx+78]
       lea       rdi,[rsp+30]
       mov       ecx,9
       rep movsq
       xor       edx,edx
       cmp       dword ptr [rbp+8],1
       setg      dl
       test      edx,edx
       je        near ptr M00_L03
       mov       esi,[r14+8]
       mov       ebp,esi
       add       ebp,1
       jo        near ptr M00_L02
       test      ebp,ebp
       jl        near ptr M00_L04
       mov       r15,r14
       cmp       esi,ebp
       je        short M00_L00
       movsxd    rdx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       lea       rcx,[r14+10]
       lea       rdx,[r15+10]
       cmp       ebp,esi
       mov       r8d,esi
       cmovle    r8d,ebp
       lea       r8,[r8+r8*8]
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L05
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M00_L00:
       sub       ebp,1
       jo        short M00_L02
       cmp       ebp,[r14+8]
       jae       near ptr M00_L06
       mov       eax,ebp
       lea       rax,[rax+rax*8]
       lea       rdi,[r14+rax*8+10]
       lea       rsi,[rsp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
M00_L01:
       mov       [rsp+28],r14
       mov       r14,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+8],rcx
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L02:
       call      CORINFO_HELP_OVERFLOW
M00_L03:
       jmp       short M00_L01
M00_L04:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFF3A50ED18]
       int       3
M00_L05:
       call      qword ptr [7FFF3A405BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L00
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 313
```
```assembly
; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M01_L02
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M01_L03
M01_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFF99CE0D08]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rbx,4000
       add       rsi,4000
       cmp       rdi,4000
       ja        short M01_L00
M01_L01:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFF99CE0D08]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFF99CE0D08]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       rdi,4000
       ja        short M01_L03
       jmp       short M01_L01
; Total bytes of code 150
```
**Extern method**
System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rbp,[rbx+198]
       mov       r14,rbp
       lea       rsi,[rbx+78]
       lea       rdi,[rsp+30]
       mov       ecx,9
       rep movsq
       xor       edx,edx
       cmp       dword ptr [rbp+8],1
       setg      dl
       test      edx,edx
       je        near ptr M00_L03
       mov       esi,[r14+8]
       mov       ebp,esi
       add       ebp,1
       jo        near ptr M00_L02
       test      ebp,ebp
       jl        near ptr M00_L04
       mov       r15,r14
       cmp       esi,ebp
       je        short M00_L00
       movsxd    rdx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       lea       rcx,[r14+10]
       lea       rdx,[r15+10]
       cmp       ebp,esi
       mov       r8d,esi
       cmovle    r8d,ebp
       lea       r8,[r8+r8*8]
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L05
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M00_L00:
       sub       ebp,1
       jo        short M00_L02
       cmp       ebp,[r14+8]
       jae       near ptr M00_L06
       mov       eax,ebp
       lea       rax,[rax+rax*8]
       lea       rdi,[r14+rax*8+10]
       lea       rsi,[rsp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
M00_L01:
       mov       [rsp+28],r14
       mov       r14,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+8],rcx
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L02:
       call      CORINFO_HELP_OVERFLOW
M00_L03:
       jmp       short M00_L01
M00_L04:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFF3A4DED18]
       int       3
M00_L05:
       call      qword ptr [7FFF3A3D5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L00
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 313
```
```assembly
; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M01_L02
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M01_L03
M01_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFF99CE0D08]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rbx,4000
       add       rsi,4000
       cmp       rdi,4000
       ja        short M01_L00
M01_L01:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFF99CE0D08]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFF99CE0D08]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       rdi,4000
       ja        short M01_L03
       jmp       short M01_L01
; Total bytes of code 150
```
**Extern method**
System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rbp,[rbx+198]
       mov       r14,rbp
       lea       rsi,[rbx+78]
       lea       rdi,[rsp+30]
       mov       ecx,9
       rep movsq
       xor       edx,edx
       cmp       dword ptr [rbp+8],1
       setg      dl
       test      edx,edx
       je        near ptr M00_L03
       mov       esi,[r14+8]
       mov       ebp,esi
       add       ebp,1
       jo        near ptr M00_L02
       test      ebp,ebp
       jl        near ptr M00_L04
       mov       r15,r14
       cmp       esi,ebp
       je        short M00_L00
       movsxd    rdx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       lea       rcx,[r14+10]
       lea       rdx,[r15+10]
       cmp       ebp,esi
       mov       r8d,esi
       cmovle    r8d,ebp
       lea       r8,[r8+r8*8]
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L05
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M00_L00:
       sub       ebp,1
       jo        short M00_L02
       cmp       ebp,[r14+8]
       jae       near ptr M00_L06
       mov       eax,ebp
       lea       rax,[rax+rax*8]
       lea       rdi,[r14+rax*8+10]
       lea       rsi,[rsp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
M00_L01:
       mov       [rsp+28],r14
       mov       r14,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+8],rcx
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L02:
       call      CORINFO_HELP_OVERFLOW
M00_L03:
       jmp       short M00_L01
M00_L04:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFF3A4DED18]
       int       3
M00_L05:
       call      qword ptr [7FFF3A3D5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L00
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 313
```
```assembly
; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M01_L02
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M01_L03
M01_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFF99CE0D08]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rbx,4000
       add       rsi,4000
       cmp       rdi,4000
       ja        short M01_L00
M01_L01:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFF99CE0D08]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFF99CE0D08]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       rdi,4000
       ja        short M01_L03
       jmp       short M01_L01
; Total bytes of code 150
```
**Extern method**
System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rbp,[rbx+198]
       mov       r14,rbp
       lea       rsi,[rbx+78]
       lea       rdi,[rsp+30]
       mov       ecx,9
       rep movsq
       xor       edx,edx
       cmp       dword ptr [rbp+8],1
       setg      dl
       test      edx,edx
       je        near ptr M00_L03
       mov       esi,[r14+8]
       mov       ebp,esi
       add       ebp,1
       jo        near ptr M00_L02
       test      ebp,ebp
       jl        near ptr M00_L04
       mov       r15,r14
       cmp       esi,ebp
       je        short M00_L00
       movsxd    rdx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       lea       rcx,[r14+10]
       lea       rdx,[r15+10]
       cmp       ebp,esi
       mov       r8d,esi
       cmovle    r8d,ebp
       lea       r8,[r8+r8*8]
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L05
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M00_L00:
       sub       ebp,1
       jo        short M00_L02
       cmp       ebp,[r14+8]
       jae       near ptr M00_L06
       mov       eax,ebp
       lea       rax,[rax+rax*8]
       lea       rdi,[r14+rax*8+10]
       lea       rsi,[rsp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
M00_L01:
       mov       [rsp+28],r14
       mov       r14,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+8],rcx
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L02:
       call      CORINFO_HELP_OVERFLOW
M00_L03:
       jmp       short M00_L01
M00_L04:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFF3A4DED18]
       int       3
M00_L05:
       call      qword ptr [7FFF3A3D5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L00
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 313
```
```assembly
; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M01_L02
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M01_L03
M01_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFF99CE0D08]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rbx,4000
       add       rsi,4000
       cmp       rdi,4000
       ja        short M01_L00
M01_L01:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFF99CE0D08]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFF99CE0D08]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       rdi,4000
       ja        short M01_L03
       jmp       short M01_L01
; Total bytes of code 150
```
**Extern method**
System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rbp,[rbx+198]
       mov       r14,rbp
       lea       rsi,[rbx+78]
       lea       rdi,[rsp+30]
       mov       ecx,9
       rep movsq
       xor       edx,edx
       cmp       dword ptr [rbp+8],1
       setg      dl
       test      edx,edx
       je        near ptr M00_L03
       mov       esi,[r14+8]
       mov       ebp,esi
       add       ebp,1
       jo        near ptr M00_L02
       test      ebp,ebp
       jl        near ptr M00_L04
       mov       r15,r14
       cmp       esi,ebp
       je        short M00_L00
       movsxd    rdx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       lea       rcx,[r14+10]
       lea       rdx,[r15+10]
       cmp       ebp,esi
       mov       r8d,esi
       cmovle    r8d,ebp
       lea       r8,[r8+r8*8]
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L05
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M00_L00:
       sub       ebp,1
       jo        short M00_L02
       cmp       ebp,[r14+8]
       jae       near ptr M00_L06
       mov       eax,ebp
       lea       rax,[rax+rax*8]
       lea       rdi,[r14+rax*8+10]
       lea       rsi,[rsp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
M00_L01:
       mov       [rsp+28],r14
       mov       r14,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+8],rcx
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L02:
       call      CORINFO_HELP_OVERFLOW
M00_L03:
       jmp       short M00_L01
M00_L04:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFF3A4EED18]
       int       3
M00_L05:
       call      qword ptr [7FFF3A3E5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L00
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 313
```
```assembly
; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M01_L02
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M01_L03
M01_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFF99CE0D08]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rbx,4000
       add       rsi,4000
       cmp       rdi,4000
       ja        short M01_L00
M01_L01:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFF99CE0D08]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFF99CE0D08]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       rdi,4000
       ja        short M01_L03
       jmp       short M01_L01
; Total bytes of code 150
```
**Extern method**
System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rbp,[rbx+198]
       mov       r14,rbp
       lea       rsi,[rbx+78]
       lea       rdi,[rsp+30]
       mov       ecx,9
       rep movsq
       xor       edx,edx
       cmp       dword ptr [rbp+8],1
       setg      dl
       test      edx,edx
       je        near ptr M00_L03
       mov       esi,[r14+8]
       mov       ebp,esi
       add       ebp,1
       jo        near ptr M00_L02
       test      ebp,ebp
       jl        near ptr M00_L04
       mov       r15,r14
       cmp       esi,ebp
       je        short M00_L00
       movsxd    rdx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       lea       rcx,[r14+10]
       lea       rdx,[r15+10]
       cmp       ebp,esi
       mov       r8d,esi
       cmovle    r8d,ebp
       lea       r8,[r8+r8*8]
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L05
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M00_L00:
       sub       ebp,1
       jo        short M00_L02
       cmp       ebp,[r14+8]
       jae       near ptr M00_L06
       mov       eax,ebp
       lea       rax,[rax+rax*8]
       lea       rdi,[r14+rax*8+10]
       lea       rsi,[rsp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
M00_L01:
       mov       [rsp+28],r14
       mov       r14,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+8],rcx
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L02:
       call      CORINFO_HELP_OVERFLOW
M00_L03:
       jmp       short M00_L01
M00_L04:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFF3A4EED18]
       int       3
M00_L05:
       call      qword ptr [7FFF3A3E5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L00
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 313
```
```assembly
; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M01_L02
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M01_L03
M01_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFF99CE0D08]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rbx,4000
       add       rsi,4000
       cmp       rdi,4000
       ja        short M01_L00
M01_L01:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFF99CE0D08]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFF99CE0D08]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       rdi,4000
       ja        short M01_L03
       jmp       short M01_L01
; Total bytes of code 150
```
**Extern method**
System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rbp,[rbx+198]
       mov       r14,rbp
       lea       rsi,[rbx+78]
       lea       rdi,[rsp+30]
       mov       ecx,9
       rep movsq
       xor       edx,edx
       cmp       dword ptr [rbp+8],1
       setg      dl
       test      edx,edx
       je        near ptr M00_L03
       mov       esi,[r14+8]
       mov       ebp,esi
       add       ebp,1
       jo        near ptr M00_L02
       test      ebp,ebp
       jl        near ptr M00_L04
       mov       r15,r14
       cmp       esi,ebp
       je        short M00_L00
       movsxd    rdx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Address, DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       lea       rcx,[r14+10]
       lea       rdx,[r15+10]
       cmp       ebp,esi
       mov       r8d,esi
       cmovle    r8d,ebp
       lea       r8,[r8+r8*8]
       shl       r8,3
       cmp       r8,4000
       jbe       near ptr M00_L05
       call      qword ptr [7FFF3A3D5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M00_L00:
       sub       ebp,1
       jo        short M00_L02
       cmp       ebp,[r14+8]
       jae       near ptr M00_L06
       mov       eax,ebp
       lea       rax,[rax+rax*8]
       lea       rdi,[r14+rax*8+10]
       lea       rsi,[rsp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
M00_L01:
       mov       [rsp+28],r14
       mov       r14,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+8],rcx
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L02:
       call      CORINFO_HELP_OVERFLOW
M00_L03:
       jmp       short M00_L01
M00_L04:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFF3A4DED18]
       int       3
M00_L05:
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L00
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 313
```
```assembly
; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M01_L02
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M01_L03
M01_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rbx,4000
       add       rsi,4000
       cmp       rdi,4000
       ja        short M01_L00
M01_L01:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       rdi,4000
       ja        short M01_L03
       jmp       short M01_L01
; Total bytes of code 147
```
**Extern method**
System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)

