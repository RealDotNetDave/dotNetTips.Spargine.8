## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.AddIf()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rdx,[rbx+290]
       mov       r8,rsi
       test      r8,r8
       je        short M00_L00
       xor       r8d,r8d
       test      rdx,rdx
       setne     r8b
       test      r8d,r8d
       je        near ptr M00_L01
       lea       r8,[rsp+30]
       mov       rcx,rsi
       call      qword ptr [7FF900245CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       mov       [rsp+28],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FF9005469D0]
       mov       ecx,43
       mov       rdx,7FF900527160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF9003B7000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF900527160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005467C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900226718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FF9005469D0]
       mov       ecx,28D
       mov       rdx,7FF900527160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF9003B7000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF900527160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005467C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900226718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 405
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       qword ptr [rbx+8],0
       je        near ptr M01_L13
M01_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       xor       r15d,r15d
       test      rsi,rsi
       je        near ptr M01_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FF900B276B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L02:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r13d,eax
M01_L03:
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M01_L16
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       js        near ptr M01_L15
M01_L04:
       cmp       eax,[rbp+8]
       jae       near ptr M01_L16
       mov       [rsp+38],eax
       mov       ecx,eax
       shl       rcx,4
       lea       r8,[rbp+rcx+10]
       mov       [rsp+28],r8
       cmp       [r8+8],r13d
       jne       near ptr M01_L14
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+68]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L05:
       xor       r13d,r13d
       jmp       short M01_L03
M01_L06:
       mov       rdx,7FF900B276C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       r8,[rsp+28]
       mov       rdx,[r8]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L14
       mov       r13d,[rsp+38]
       mov       [rdi],r13d
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L08:
       call      qword ptr [7FF900395E48]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FF900245C50]
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L16
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
M01_L10:
       mov       eax,[rsp+34]
       mov       ebp,eax
       lea       ecx,[rbp+1]
       mov       [rbx+28],ecx
       mov       rcx,[rbx+10]
       mov       rax,rcx
       mov       rcx,rax
       mov       eax,ebp
       mov       rbp,rcx
M01_L11:
       cmp       eax,[rbp+8]
       jae       near ptr M01_L16
       mov       [rsp+3C],eax
       mov       ecx,eax
       shl       rcx,4
       lea       rcx,[rbp+rcx+10]
       mov       [rcx+8],r13d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r13d,[rsp+3C]
       lea       edx,[r13+1]
       mov       [r12],edx
       inc       dword ptr [rbx+34]
       mov       [rdi],r13d
       cmp       r15d,64
       jbe       short M01_L12
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      qword ptr [7FF900024360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF900245C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900245998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       mov       [rdi],eax
M01_L12:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L13:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF900245CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M01_L00
M01_L14:
       mov       r8,[rsp+28]
       mov       eax,[r8+0C]
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M01_L08
       test      eax,eax
       jge       near ptr M01_L04
M01_L15:
       cmp       dword ptr [rbx+30],0
       jle       near ptr M01_L09
       mov       eax,[rbx+2C]
       dec       dword ptr [rbx+30]
       mov       ecx,[rbx+2C]
       cmp       ecx,[rbp+8]
       jae       short M01_L16
       shl       rcx,4
       mov       ecx,[rbp+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+2C],ecx
       jmp       near ptr M01_L11
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
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
       je        near ptr M02_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L02
       test      rbx,rbx
       je        short M02_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M02_L01
       call      00007FF900021E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       call      qword ptr [7FF900395D58]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,28502980008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.AddIf()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rdx,[rbx+290]
       mov       r8,rsi
       test      r8,r8
       je        short M00_L00
       xor       r8d,r8d
       test      rdx,rdx
       setne     r8b
       test      r8d,r8d
       je        near ptr M00_L01
       lea       r8,[rsp+30]
       mov       rcx,rsi
       call      qword ptr [7FF900215CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       mov       [rsp+28],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FF9005169D0]
       mov       ecx,43
       mov       rdx,7FF9004F7160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF900387000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9004F7160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005167C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001F6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FF9005169D0]
       mov       ecx,28D
       mov       rdx,7FF9004F7160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF900387000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9004F7160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005167C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001F6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 405
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       qword ptr [rbx+8],0
       je        near ptr M01_L13
M01_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       xor       r15d,r15d
       test      rsi,rsi
       je        near ptr M01_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FF900B07BA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L02:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r13d,eax
M01_L03:
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M01_L16
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       js        near ptr M01_L15
M01_L04:
       cmp       eax,[rbp+8]
       jae       near ptr M01_L16
       mov       [rsp+38],eax
       mov       ecx,eax
       shl       rcx,4
       lea       r8,[rbp+rcx+10]
       mov       [rsp+28],r8
       cmp       [r8+8],r13d
       jne       near ptr M01_L14
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+68]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L05:
       xor       r13d,r13d
       jmp       short M01_L03
M01_L06:
       mov       rdx,7FF900B07BC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       r8,[rsp+28]
       mov       rdx,[r8]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L14
       mov       r13d,[rsp+38]
       mov       [rdi],r13d
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L08:
       call      qword ptr [7FF900365E48]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FF900215C50]
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L16
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
M01_L10:
       mov       eax,[rsp+34]
       mov       ebp,eax
       lea       ecx,[rbp+1]
       mov       [rbx+28],ecx
       mov       rcx,[rbx+10]
       mov       rax,rcx
       mov       rcx,rax
       mov       eax,ebp
       mov       rbp,rcx
M01_L11:
       cmp       eax,[rbp+8]
       jae       near ptr M01_L16
       mov       [rsp+3C],eax
       mov       ecx,eax
       shl       rcx,4
       lea       rcx,[rbp+rcx+10]
       mov       [rcx+8],r13d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r13d,[rsp+3C]
       lea       edx,[r13+1]
       mov       [r12],edx
       inc       dword ptr [rbx+34]
       mov       [rdi],r13d
       cmp       r15d,64
       jbe       short M01_L12
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      qword ptr [7FF8FFFF4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF900215C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900215998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       mov       [rdi],eax
M01_L12:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L13:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF900215CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M01_L00
M01_L14:
       mov       r8,[rsp+28]
       mov       eax,[r8+0C]
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M01_L08
       test      eax,eax
       jge       near ptr M01_L04
M01_L15:
       cmp       dword ptr [rbx+30],0
       jle       near ptr M01_L09
       mov       eax,[rbx+2C]
       dec       dword ptr [rbx+30]
       mov       ecx,[rbx+2C]
       cmp       ecx,[rbp+8]
       jae       short M01_L16
       shl       rcx,4
       mov       ecx,[rbp+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+2C],ecx
       jmp       near ptr M01_L11
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
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
       je        near ptr M02_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L02
       test      rbx,rbx
       je        short M02_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M02_L01
       call      00007FF8FFFF1E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       call      qword ptr [7FF900365D58]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,26B5AF10008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.AddIf()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rdx,[rbx+290]
       mov       r8,rsi
       test      r8,r8
       je        short M00_L00
       xor       r8d,r8d
       test      rdx,rdx
       setne     r8b
       test      r8d,r8d
       je        near ptr M00_L01
       lea       r8,[rsp+30]
       mov       rcx,rsi
       call      qword ptr [7FF900245CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       mov       [rsp+28],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FF9005469D0]
       mov       ecx,43
       mov       rdx,7FF900527160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF9003B7000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF900527160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005467C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900226718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FF9005469D0]
       mov       ecx,28D
       mov       rdx,7FF900527160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF9003B7000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF900527160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005467C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900226718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 405
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       qword ptr [rbx+8],0
       je        near ptr M01_L13
M01_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       xor       r15d,r15d
       test      rsi,rsi
       je        near ptr M01_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FF900B377A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L02:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r13d,eax
M01_L03:
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M01_L16
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       js        near ptr M01_L15
M01_L04:
       cmp       eax,[rbp+8]
       jae       near ptr M01_L16
       mov       [rsp+38],eax
       mov       ecx,eax
       shl       rcx,4
       lea       r8,[rbp+rcx+10]
       mov       [rsp+28],r8
       cmp       [r8+8],r13d
       jne       near ptr M01_L14
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+68]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L05:
       xor       r13d,r13d
       jmp       short M01_L03
M01_L06:
       mov       rdx,7FF900B377B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       r8,[rsp+28]
       mov       rdx,[r8]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L14
       mov       r13d,[rsp+38]
       mov       [rdi],r13d
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L08:
       call      qword ptr [7FF900395E48]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FF900245C50]
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L16
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
M01_L10:
       mov       eax,[rsp+34]
       mov       ebp,eax
       lea       ecx,[rbp+1]
       mov       [rbx+28],ecx
       mov       rcx,[rbx+10]
       mov       rax,rcx
       mov       rcx,rax
       mov       eax,ebp
       mov       rbp,rcx
M01_L11:
       cmp       eax,[rbp+8]
       jae       near ptr M01_L16
       mov       [rsp+3C],eax
       mov       ecx,eax
       shl       rcx,4
       lea       rcx,[rbp+rcx+10]
       mov       [rcx+8],r13d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r13d,[rsp+3C]
       lea       edx,[r13+1]
       mov       [r12],edx
       inc       dword ptr [rbx+34]
       mov       [rdi],r13d
       cmp       r15d,64
       jbe       short M01_L12
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      qword ptr [7FF900024360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF900245C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900245998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       mov       [rdi],eax
M01_L12:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L13:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF900245CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M01_L00
M01_L14:
       mov       r8,[rsp+28]
       mov       eax,[r8+0C]
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M01_L08
       test      eax,eax
       jge       near ptr M01_L04
M01_L15:
       cmp       dword ptr [rbx+30],0
       jle       near ptr M01_L09
       mov       eax,[rbx+2C]
       dec       dword ptr [rbx+30]
       mov       ecx,[rbx+2C]
       cmp       ecx,[rbp+8]
       jae       short M01_L16
       shl       rcx,4
       mov       ecx,[rbp+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+2C],ecx
       jmp       near ptr M01_L11
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
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
       je        near ptr M02_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L02
       test      rbx,rbx
       je        short M02_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M02_L01
       call      00007FF900021E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       call      qword ptr [7FF900395D58]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,22C92ED0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.AddIf()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rdx,[rbx+290]
       mov       r8,rsi
       test      r8,r8
       je        short M00_L00
       xor       r8d,r8d
       test      rdx,rdx
       setne     r8b
       test      r8d,r8d
       je        near ptr M00_L01
       lea       r8,[rsp+30]
       mov       rcx,rsi
       call      qword ptr [7FF900245CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       mov       [rsp+28],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FF9005469D0]
       mov       ecx,43
       mov       rdx,7FF900527160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF9003B7000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF900527160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005467C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900226718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FF9005469D0]
       mov       ecx,28D
       mov       rdx,7FF900527160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF9003B7000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF900527160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005467C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900226718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 405
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       qword ptr [rbx+8],0
       je        near ptr M01_L13
M01_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       xor       r15d,r15d
       test      rsi,rsi
       je        near ptr M01_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FF900B37868
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L02:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r13d,eax
M01_L03:
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M01_L16
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       js        near ptr M01_L15
M01_L04:
       cmp       eax,[rbp+8]
       jae       near ptr M01_L16
       mov       [rsp+38],eax
       mov       ecx,eax
       shl       rcx,4
       lea       r8,[rbp+rcx+10]
       mov       [rsp+28],r8
       cmp       [r8+8],r13d
       jne       near ptr M01_L14
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+68]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L05:
       xor       r13d,r13d
       jmp       short M01_L03
M01_L06:
       mov       rdx,7FF900B37880
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       r8,[rsp+28]
       mov       rdx,[r8]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L14
       mov       r13d,[rsp+38]
       mov       [rdi],r13d
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L08:
       call      qword ptr [7FF900395E48]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FF900245C50]
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L16
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
M01_L10:
       mov       eax,[rsp+34]
       mov       ebp,eax
       lea       ecx,[rbp+1]
       mov       [rbx+28],ecx
       mov       rcx,[rbx+10]
       mov       rax,rcx
       mov       rcx,rax
       mov       eax,ebp
       mov       rbp,rcx
M01_L11:
       cmp       eax,[rbp+8]
       jae       near ptr M01_L16
       mov       [rsp+3C],eax
       mov       ecx,eax
       shl       rcx,4
       lea       rcx,[rbp+rcx+10]
       mov       [rcx+8],r13d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r13d,[rsp+3C]
       lea       edx,[r13+1]
       mov       [r12],edx
       inc       dword ptr [rbx+34]
       mov       [rdi],r13d
       cmp       r15d,64
       jbe       short M01_L12
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      qword ptr [7FF900024360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF900245C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900245998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       mov       [rdi],eax
M01_L12:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L13:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF900245CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M01_L00
M01_L14:
       mov       r8,[rsp+28]
       mov       eax,[r8+0C]
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M01_L08
       test      eax,eax
       jge       near ptr M01_L04
M01_L15:
       cmp       dword ptr [rbx+30],0
       jle       near ptr M01_L09
       mov       eax,[rbx+2C]
       dec       dword ptr [rbx+30]
       mov       ecx,[rbx+2C]
       cmp       ecx,[rbp+8]
       jae       short M01_L16
       shl       rcx,4
       mov       ecx,[rbp+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+2C],ecx
       jmp       near ptr M01_L11
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
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
       je        near ptr M02_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L02
       test      rbx,rbx
       je        short M02_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M02_L01
       call      00007FF900021E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       call      qword ptr [7FF900395D58]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,2DCC5340008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.AddIf()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rdx,[rbx+290]
       mov       r8,rsi
       test      r8,r8
       je        short M00_L00
       xor       r8d,r8d
       test      rdx,rdx
       setne     r8b
       test      r8d,r8d
       je        near ptr M00_L01
       lea       r8,[rsp+30]
       mov       rcx,rsi
       call      qword ptr [7FF900215CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       mov       [rsp+28],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FF9005169D0]
       mov       ecx,43
       mov       rdx,7FF9004F7160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF900387000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9004F7160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005167C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001F6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FF9005169D0]
       mov       ecx,28D
       mov       rdx,7FF9004F7160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF900387000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9004F7160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005167C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001F6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 405
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       qword ptr [rbx+8],0
       je        near ptr M01_L13
M01_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       xor       r15d,r15d
       test      rsi,rsi
       je        near ptr M01_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FF900B07818
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L02:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r13d,eax
M01_L03:
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M01_L16
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       js        near ptr M01_L15
M01_L04:
       cmp       eax,[rbp+8]
       jae       near ptr M01_L16
       mov       [rsp+38],eax
       mov       ecx,eax
       shl       rcx,4
       lea       r8,[rbp+rcx+10]
       mov       [rsp+28],r8
       cmp       [r8+8],r13d
       jne       near ptr M01_L14
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+68]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L05:
       xor       r13d,r13d
       jmp       short M01_L03
M01_L06:
       mov       rdx,7FF900B07830
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       r8,[rsp+28]
       mov       rdx,[r8]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L14
       mov       r13d,[rsp+38]
       mov       [rdi],r13d
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L08:
       call      qword ptr [7FF900365E48]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FF900215C50]
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L16
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
M01_L10:
       mov       eax,[rsp+34]
       mov       ebp,eax
       lea       ecx,[rbp+1]
       mov       [rbx+28],ecx
       mov       rcx,[rbx+10]
       mov       rax,rcx
       mov       rcx,rax
       mov       eax,ebp
       mov       rbp,rcx
M01_L11:
       cmp       eax,[rbp+8]
       jae       near ptr M01_L16
       mov       [rsp+3C],eax
       mov       ecx,eax
       shl       rcx,4
       lea       rcx,[rbp+rcx+10]
       mov       [rcx+8],r13d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r13d,[rsp+3C]
       lea       edx,[r13+1]
       mov       [r12],edx
       inc       dword ptr [rbx+34]
       mov       [rdi],r13d
       cmp       r15d,64
       jbe       short M01_L12
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      qword ptr [7FF8FFFF4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF900215C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900215998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       mov       [rdi],eax
M01_L12:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L13:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF900215CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M01_L00
M01_L14:
       mov       r8,[rsp+28]
       mov       eax,[r8+0C]
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M01_L08
       test      eax,eax
       jge       near ptr M01_L04
M01_L15:
       cmp       dword ptr [rbx+30],0
       jle       near ptr M01_L09
       mov       eax,[rbx+2C]
       dec       dword ptr [rbx+30]
       mov       ecx,[rbx+2C]
       cmp       ecx,[rbp+8]
       jae       short M01_L16
       shl       rcx,4
       mov       ecx,[rbp+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+2C],ecx
       jmp       near ptr M01_L11
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
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
       je        near ptr M02_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L02
       test      rbx,rbx
       je        short M02_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M02_L01
       call      00007FF8FFFF1E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       call      qword ptr [7FF900365D58]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,2BCA8200008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.AddIf()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rdx,[rbx+290]
       mov       r8,rsi
       test      r8,r8
       je        short M00_L00
       xor       r8d,r8d
       test      rdx,rdx
       setne     r8b
       test      r8d,r8d
       je        near ptr M00_L01
       lea       r8,[rsp+30]
       mov       rcx,rsi
       call      qword ptr [7FF900225CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       mov       [rsp+28],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FF9005269D0]
       mov       ecx,43
       mov       rdx,7FF900507160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF900397000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900006B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF900507160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900006B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005267C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900206718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FF9005269D0]
       mov       ecx,28D
       mov       rdx,7FF900507160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF900397000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900006B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF900507160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900006B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005267C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900206718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 405
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       qword ptr [rbx+8],0
       je        near ptr M01_L13
M01_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       xor       r15d,r15d
       test      rsi,rsi
       je        near ptr M01_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FF900B177A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L02:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r13d,eax
M01_L03:
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M01_L16
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       js        near ptr M01_L15
M01_L04:
       cmp       eax,[rbp+8]
       jae       near ptr M01_L16
       mov       [rsp+38],eax
       mov       ecx,eax
       shl       rcx,4
       lea       r8,[rbp+rcx+10]
       mov       [rsp+28],r8
       cmp       [r8+8],r13d
       jne       near ptr M01_L14
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+68]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L05:
       xor       r13d,r13d
       jmp       short M01_L03
M01_L06:
       mov       rdx,7FF900B177B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       r8,[rsp+28]
       mov       rdx,[r8]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L14
       mov       r13d,[rsp+38]
       mov       [rdi],r13d
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L08:
       call      qword ptr [7FF900375E48]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FF900225C50]
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L16
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
M01_L10:
       mov       eax,[rsp+34]
       mov       ebp,eax
       lea       ecx,[rbp+1]
       mov       [rbx+28],ecx
       mov       rcx,[rbx+10]
       mov       rax,rcx
       mov       rcx,rax
       mov       eax,ebp
       mov       rbp,rcx
M01_L11:
       cmp       eax,[rbp+8]
       jae       near ptr M01_L16
       mov       [rsp+3C],eax
       mov       ecx,eax
       shl       rcx,4
       lea       rcx,[rbp+rcx+10]
       mov       [rcx+8],r13d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r13d,[rsp+3C]
       lea       edx,[r13+1]
       mov       [r12],edx
       inc       dword ptr [rbx+34]
       mov       [rdi],r13d
       cmp       r15d,64
       jbe       short M01_L12
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      qword ptr [7FF900004360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF900225C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900225998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       mov       [rdi],eax
M01_L12:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L13:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF900225CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M01_L00
M01_L14:
       mov       r8,[rsp+28]
       mov       eax,[r8+0C]
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M01_L08
       test      eax,eax
       jge       near ptr M01_L04
M01_L15:
       cmp       dword ptr [rbx+30],0
       jle       near ptr M01_L09
       mov       eax,[rbx+2C]
       dec       dword ptr [rbx+30]
       mov       ecx,[rbx+2C]
       cmp       ecx,[rbp+8]
       jae       short M01_L16
       shl       rcx,4
       mov       ecx,[rbp+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+2C],ecx
       jmp       near ptr M01_L11
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
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
       je        near ptr M02_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L02
       test      rbx,rbx
       je        short M02_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M02_L01
       call      00007FF900001E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       call      qword ptr [7FF900375D58]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,243A2C80008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.AddIf()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rdx,[rbx+290]
       mov       r8,rsi
       test      r8,r8
       je        short M00_L00
       xor       r8d,r8d
       test      rdx,rdx
       setne     r8b
       test      r8d,r8d
       je        near ptr M00_L01
       lea       r8,[rsp+30]
       mov       rcx,rsi
       call      qword ptr [7FF900235CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       mov       [rsp+28],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FF9005369D0]
       mov       ecx,43
       mov       rdx,7FF900517160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF9003A7000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF900517160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005367C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900216718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FF9005369D0]
       mov       ecx,28D
       mov       rdx,7FF900517160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF9003A7000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF900517160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005367C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900216718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 405
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       qword ptr [rbx+8],0
       je        near ptr M01_L13
M01_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       xor       r15d,r15d
       test      rsi,rsi
       je        near ptr M01_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FF900B191B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L02:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r13d,eax
M01_L03:
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M01_L16
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       js        near ptr M01_L15
M01_L04:
       cmp       eax,[rbp+8]
       jae       near ptr M01_L16
       mov       [rsp+38],eax
       mov       ecx,eax
       shl       rcx,4
       lea       r8,[rbp+rcx+10]
       mov       [rsp+28],r8
       cmp       [r8+8],r13d
       jne       near ptr M01_L14
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+68]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L05:
       xor       r13d,r13d
       jmp       short M01_L03
M01_L06:
       mov       rdx,7FF900B191D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       r8,[rsp+28]
       mov       rdx,[r8]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L14
       mov       r13d,[rsp+38]
       mov       [rdi],r13d
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L08:
       call      qword ptr [7FF900385E48]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FF900235C50]
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L16
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
M01_L10:
       mov       eax,[rsp+34]
       mov       ebp,eax
       lea       ecx,[rbp+1]
       mov       [rbx+28],ecx
       mov       rcx,[rbx+10]
       mov       rax,rcx
       mov       rcx,rax
       mov       eax,ebp
       mov       rbp,rcx
M01_L11:
       cmp       eax,[rbp+8]
       jae       near ptr M01_L16
       mov       [rsp+3C],eax
       mov       ecx,eax
       shl       rcx,4
       lea       rcx,[rbp+rcx+10]
       mov       [rcx+8],r13d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r13d,[rsp+3C]
       lea       edx,[r13+1]
       mov       [r12],edx
       inc       dword ptr [rbx+34]
       mov       [rdi],r13d
       cmp       r15d,64
       jbe       short M01_L12
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      qword ptr [7FF900014360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF900235C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900235998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       mov       [rdi],eax
M01_L12:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L13:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF900235CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M01_L00
M01_L14:
       mov       r8,[rsp+28]
       mov       eax,[r8+0C]
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M01_L08
       test      eax,eax
       jge       near ptr M01_L04
M01_L15:
       cmp       dword ptr [rbx+30],0
       jle       near ptr M01_L09
       mov       eax,[rbx+2C]
       dec       dword ptr [rbx+30]
       mov       ecx,[rbx+2C]
       cmp       ecx,[rbp+8]
       jae       short M01_L16
       shl       rcx,4
       mov       ecx,[rbp+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+2C],ecx
       jmp       near ptr M01_L11
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
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
       je        near ptr M02_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L02
       test      rbx,rbx
       je        short M02_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M02_L01
       call      00007FF900011E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       call      qword ptr [7FF900385D58]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,25E23A00008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.AddIf()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       rdx,[rbx+290]
       mov       r8,rsi
       test      r8,r8
       je        short M00_L00
       xor       r8d,r8d
       test      rdx,rdx
       setne     r8b
       test      r8d,r8d
       je        near ptr M00_L01
       lea       r8,[rsp+30]
       mov       rcx,rsi
       call      qword ptr [7FF900235CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       mov       [rsp+28],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FF9005369D0]
       mov       ecx,43
       mov       rdx,7FF900517160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF9003A7000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF900517160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005367C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900216718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FF9005369D0]
       mov       ecx,28D
       mov       rdx,7FF900517160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF9003A7000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF900517160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005367C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900216718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 405
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       qword ptr [rbx+8],0
       je        near ptr M01_L13
M01_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       xor       r15d,r15d
       test      rsi,rsi
       je        near ptr M01_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+58]
       test      r11,r11
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FF900A99080
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L02:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r13d,eax
M01_L03:
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M01_L16
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       js        near ptr M01_L15
M01_L04:
       cmp       eax,[rbp+8]
       jae       near ptr M01_L16
       mov       [rsp+38],eax
       mov       ecx,eax
       shl       rcx,4
       lea       r8,[rbp+rcx+10]
       mov       [rsp+28],r8
       cmp       [r8+8],r13d
       jne       near ptr M01_L14
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L05:
       xor       r13d,r13d
       jmp       short M01_L03
M01_L06:
       mov       rdx,7FF900A99098
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       r8,[rsp+28]
       mov       rdx,[r8]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L14
       mov       r13d,[rsp+38]
       mov       [rdi],r13d
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L08:
       call      qword ptr [7FF900385E48]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FF900235C50]
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L16
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
M01_L10:
       mov       eax,[rsp+34]
       mov       ebp,eax
       lea       ecx,[rbp+1]
       mov       [rbx+28],ecx
       mov       rcx,[rbx+10]
       mov       rax,rcx
       mov       rcx,rax
       mov       eax,ebp
       mov       rbp,rcx
M01_L11:
       cmp       eax,[rbp+8]
       jae       near ptr M01_L16
       mov       [rsp+3C],eax
       mov       ecx,eax
       shl       rcx,4
       lea       rcx,[rbp+rcx+10]
       mov       [rcx+8],r13d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r13d,[rsp+3C]
       lea       edx,[r13+1]
       mov       [r12],edx
       inc       dword ptr [rbx+34]
       mov       [rdi],r13d
       cmp       r15d,64
       jbe       short M01_L12
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      qword ptr [7FF900014360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF900235C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900235998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       mov       [rdi],eax
M01_L12:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L13:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF900235CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M01_L00
M01_L14:
       mov       r8,[rsp+28]
       mov       eax,[r8+0C]
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M01_L08
       test      eax,eax
       jge       near ptr M01_L04
M01_L15:
       cmp       dword ptr [rbx+30],0
       jle       near ptr M01_L09
       mov       eax,[rbx+2C]
       dec       dword ptr [rbx+30]
       mov       ecx,[rbx+2C]
       cmp       ecx,[rbp+8]
       jae       short M01_L16
       shl       rcx,4
       mov       ecx,[rbp+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+2C],ecx
       jmp       near ptr M01_L11
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
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
       je        near ptr M02_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L02
       test      rbx,rbx
       je        short M02_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M02_L01
       call      00007FF900011E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       call      qword ptr [7FF900385D58]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,303FFA60008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       mov       rcx,7FF900AF3B10
       call      qword ptr [7FF900ADC150]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
; 	public static ImmutableHashSet<T> ToImmutableHashSet<T>(this HashSet<T> collection) => [.. collection.ArgumentNotNull()];
; 	                                                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+38],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L05
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FF9004BE418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       je        near ptr M01_L06
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
M01_L01:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M01_L04
M01_L02:
       mov       [rsp+28],rsi
       mov       [rsp+30],edi
       lea       rdx,[rsp+28]
       call      qword ptr [7FF900ADCAF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FF900AE4B40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FF900AE5050
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L02
M01_L05:
       call      qword ptr [7FF9005369D0]
       mov       ecx,43
       mov       rdx,7FF900517160
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1C09
       mov       rdx,7FF9003A7000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF900517160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005367C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900216718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L01
; Total bytes of code 315
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       mov       rcx,7FF900AD7C70
       call      qword ptr [7FF900ABDEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
; 	public static ImmutableHashSet<T> ToImmutableHashSet<T>(this HashSet<T> collection) => [.. collection.ArgumentNotNull()];
; 	                                                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+38],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L05
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FF90049E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       je        near ptr M01_L06
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
M01_L01:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M01_L04
M01_L02:
       mov       [rsp+28],rsi
       mov       [rsp+30],edi
       lea       rdx,[rsp+28]
       call      qword ptr [7FF900ABE850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FF900AC5B80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FF900AC6090
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L02
M01_L05:
       call      qword ptr [7FF9005169D0]
       mov       ecx,43
       mov       rdx,7FF9004F7160
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1C09
       mov       rdx,7FF900387000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF9004F7160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005167C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001F6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L01
; Total bytes of code 315
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       mov       rcx,7FF900AF7C70
       call      qword ptr [7FF900ADDEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
; 	public static ImmutableHashSet<T> ToImmutableHashSet<T>(this HashSet<T> collection) => [.. collection.ArgumentNotNull()];
; 	                                                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+38],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L05
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FF9004BE418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       je        near ptr M01_L06
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
M01_L01:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M01_L04
M01_L02:
       mov       [rsp+28],rsi
       mov       [rsp+30],edi
       lea       rdx,[rsp+28]
       call      qword ptr [7FF900ADE850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FF900AE5B80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FF900AE6090
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L02
M01_L05:
       call      qword ptr [7FF9005369D0]
       mov       ecx,43
       mov       rdx,7FF900517160
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1C09
       mov       rdx,7FF9003A7000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF900517160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005367C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900216718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L01
; Total bytes of code 315
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       mov       rcx,7FF900AF7650
       call      qword ptr [7FF900ADDCC8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
; 	public static ImmutableHashSet<T> ToImmutableHashSet<T>(this HashSet<T> collection) => [.. collection.ArgumentNotNull()];
; 	                                                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+38],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L05
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FF9004BE418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       je        near ptr M01_L06
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
M01_L01:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M01_L04
M01_L02:
       mov       [rsp+28],rsi
       mov       [rsp+30],edi
       lea       rdx,[rsp+28]
       call      qword ptr [7FF900ADE670]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FF900AE5A60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FF900AE5F70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L02
M01_L05:
       call      qword ptr [7FF9005369D0]
       mov       ecx,43
       mov       rdx,7FF900517160
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1C09
       mov       rdx,7FF9003A7000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF900517160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005367C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900216718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L01
; Total bytes of code 315
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       mov       rcx,7FF900B07650
       call      qword ptr [7FF900AEDCC8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
; 	public static ImmutableHashSet<T> ToImmutableHashSet<T>(this HashSet<T> collection) => [.. collection.ArgumentNotNull()];
; 	                                                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+38],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L05
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FF9004CE418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       je        near ptr M01_L06
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
M01_L01:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M01_L04
M01_L02:
       mov       [rsp+28],rsi
       mov       [rsp+30],edi
       lea       rdx,[rsp+28]
       call      qword ptr [7FF900AEE670]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FF900AF5A60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FF900AF5F70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L02
M01_L05:
       call      qword ptr [7FF9005469D0]
       mov       ecx,43
       mov       rdx,7FF900527160
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1C09
       mov       rdx,7FF9003B7000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF900527160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005467C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900226718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L01
; Total bytes of code 315
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       mov       rcx,7FF900AE7650
       call      qword ptr [7FF900ACDCC8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
; 	public static ImmutableHashSet<T> ToImmutableHashSet<T>(this HashSet<T> collection) => [.. collection.ArgumentNotNull()];
; 	                                                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+38],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L05
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FF9004AE418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       je        near ptr M01_L06
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
M01_L01:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M01_L04
M01_L02:
       mov       [rsp+28],rsi
       mov       [rsp+30],edi
       lea       rdx,[rsp+28]
       call      qword ptr [7FF900ACE670]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FF900AD5B00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FF900AD6010
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L02
M01_L05:
       call      qword ptr [7FF9005269D0]
       mov       ecx,43
       mov       rdx,7FF900507160
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1C09
       mov       rdx,7FF900397000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF900006B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF900507160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF900006B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005267C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900206718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L01
; Total bytes of code 315
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       mov       rcx,7FF900C192C0
       call      qword ptr [7FF900BFF690]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
; 	public static ImmutableHashSet<T> ToImmutableHashSet<T>(this HashSet<T> collection) => [.. collection.ArgumentNotNull()];
; 	                                                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+38],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L05
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FF90049E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       je        near ptr M01_L06
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
M01_L01:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M01_L04
M01_L02:
       mov       [rsp+28],rsi
       mov       [rsp+30],edi
       lea       rdx,[rsp+28]
       call      qword ptr [7FF900C24168]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FF900C08518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FF900C08A28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L02
M01_L05:
       call      qword ptr [7FF9005169D0]
       mov       ecx,43
       mov       rdx,7FF9004F7160
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1C09
       mov       rdx,7FF900387000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF9004F7160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005167C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001F6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L01
; Total bytes of code 315
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       mov       rcx,7FF900CC9FB8
       call      qword ptr [7FF900CADEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
; 	public static ImmutableHashSet<T> ToImmutableHashSet<T>(this HashSet<T> collection) => [.. collection.ArgumentNotNull()];
; 	                                                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+38],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L05
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L03
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FF9004CE418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       je        near ptr M01_L06
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
M01_L01:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M01_L04
M01_L02:
       mov       [rsp+28],rsi
       mov       [rsp+30],edi
       lea       rdx,[rsp+28]
       call      qword ptr [7FF900CAE850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FF900CB4D00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FF900CB5210
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L02
M01_L05:
       call      qword ptr [7FF9005469D0]
       mov       ecx,43
       mov       rdx,7FF900527160
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1C09
       mov       rdx,7FF9003B7000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF900527160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005467C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900226718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L01
; Total bytes of code 315
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.Upsert()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       r8,[rbx+290]
       mov       rdx,rsi
       mov       rcx,7FF900AC7CF0
       call      qword ptr [7FF900ABFE58]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
       mov       [rsp+20],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 85
```
```assembly
; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
; 		collection = collection.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (collection.Contains(item))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = collection.Remove(item);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		_ = collection.Add(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        short M01_L01
       xor       ecx,ecx
       test      rsi,rsi
       setne     cl
       test      ecx,ecx
       je        near ptr M01_L02
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900245998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900237028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900245CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF9005469D0]
       mov       ecx,43
       mov       rdx,7FF900527160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF9003B7000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF900527160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005467C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900226718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FF9005469D0]
       mov       ecx,28D
       mov       rdx,7FF900527160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF9003B7000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF900527160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005467C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900226718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.Upsert()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       r8,[rbx+290]
       mov       rdx,rsi
       mov       rcx,7FF900A9BD70
       call      qword ptr [7FF900AB58D8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
       mov       [rsp+20],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 85
```
```assembly
; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
; 		collection = collection.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (collection.Contains(item))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = collection.Remove(item);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		_ = collection.Add(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        short M01_L01
       xor       ecx,ecx
       test      rsi,rsi
       setne     cl
       test      ecx,ecx
       je        near ptr M01_L02
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900215998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900207028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900215CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF9005169D0]
       mov       ecx,43
       mov       rdx,7FF9004F7160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF900387000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9004F7160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005167C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001F6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FF9005169D0]
       mov       ecx,28D
       mov       rdx,7FF9004F7160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF900387000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9004F7160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005167C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001F6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.Upsert()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       r8,[rbx+290]
       mov       rdx,rsi
       mov       rcx,7FF900AAC2A8
       call      qword ptr [7FF900AC5DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
       mov       [rsp+20],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 85
```
```assembly
; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
; 		collection = collection.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (collection.Contains(item))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = collection.Remove(item);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		_ = collection.Add(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        short M01_L01
       xor       ecx,ecx
       test      rsi,rsi
       setne     cl
       test      ecx,ecx
       je        near ptr M01_L02
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900225998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900217028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900225CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF9005269D0]
       mov       ecx,43
       mov       rdx,7FF900507160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF900397000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900006B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF900507160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900006B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005267C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900206718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FF9005269D0]
       mov       ecx,28D
       mov       rdx,7FF900507160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF900397000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900006B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF900507160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900006B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005267C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900206718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.Upsert()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       r8,[rbx+290]
       mov       rdx,rsi
       mov       rcx,7FF900ABBD70
       call      qword ptr [7FF900AD58D8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
       mov       [rsp+20],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 85
```
```assembly
; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
; 		collection = collection.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (collection.Contains(item))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = collection.Remove(item);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		_ = collection.Add(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        short M01_L01
       xor       ecx,ecx
       test      rsi,rsi
       setne     cl
       test      ecx,ecx
       je        near ptr M01_L02
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900235998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900227028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900235CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF9005369D0]
       mov       ecx,43
       mov       rdx,7FF900517160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF9003A7000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF900517160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005367C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900216718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FF9005369D0]
       mov       ecx,28D
       mov       rdx,7FF900517160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF9003A7000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF900517160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005367C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900216718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.Upsert()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       r8,[rbx+290]
       mov       rdx,rsi
       mov       rcx,7FF900A9BD70
       call      qword ptr [7FF900AB58D8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
       mov       [rsp+20],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 85
```
```assembly
; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
; 		collection = collection.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (collection.Contains(item))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = collection.Remove(item);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		_ = collection.Add(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        short M01_L01
       xor       ecx,ecx
       test      rsi,rsi
       setne     cl
       test      ecx,ecx
       je        near ptr M01_L02
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900215998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900207028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900215CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF9005169D0]
       mov       ecx,43
       mov       rdx,7FF9004F7160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF900387000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9004F7160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005167C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001F6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FF9005169D0]
       mov       ecx,28D
       mov       rdx,7FF9004F7160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF900387000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9004F7160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005167C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001F6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.Upsert()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       r8,[rbx+290]
       mov       rdx,rsi
       mov       rcx,7FF900ACC2A8
       call      qword ptr [7FF900AE5DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
       mov       [rsp+20],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 85
```
```assembly
; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
; 		collection = collection.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (collection.Contains(item))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = collection.Remove(item);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		_ = collection.Add(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        short M01_L01
       xor       ecx,ecx
       test      rsi,rsi
       setne     cl
       test      ecx,ecx
       je        near ptr M01_L02
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900245998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900237028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900245CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF9005469D0]
       mov       ecx,43
       mov       rdx,7FF900527160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF9003B7000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF900527160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005467C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900226718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FF9005469D0]
       mov       ecx,28D
       mov       rdx,7FF900527160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF9003B7000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF900527160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005467C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900226718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.Upsert()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       r8,[rbx+290]
       mov       rdx,rsi
       mov       rcx,7FF900C0D1C0
       call      qword ptr [7FF900C273C0]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
       mov       [rsp+20],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 85
```
```assembly
; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
; 		collection = collection.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (collection.Contains(item))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = collection.Remove(item);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		_ = collection.Add(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        short M01_L01
       xor       ecx,ecx
       test      rsi,rsi
       setne     cl
       test      ecx,ecx
       je        near ptr M01_L02
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900245998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900237028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900245CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF9005469D0]
       mov       ecx,43
       mov       rdx,7FF900527160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF9003B7000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF900527160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005467C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900226718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FF9005469D0]
       mov       ecx,28D
       mov       rdx,7FF900527160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF9003B7000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF900527160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005467C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF900226718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.Upsert()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       r8,[rbx+290]
       mov       rdx,rsi
       mov       rcx,7FF900C5DA00
       call      qword ptr [7FF900C66418]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
       mov       [rsp+20],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 85
```
```assembly
; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
; 		collection = collection.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (collection.Contains(item))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = collection.Remove(item);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		_ = collection.Add(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        short M01_L01
       xor       ecx,ecx
       test      rsi,rsi
       setne     cl
       test      ecx,ecx
       je        near ptr M01_L02
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900215998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900207028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF900215CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF9005169D0]
       mov       ecx,43
       mov       rdx,7FF9004F7160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF900387000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9004F7160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005167C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001F6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FF9005169D0]
       mov       ecx,28D
       mov       rdx,7FF9004F7160
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FF900387000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9004F7160
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9005167C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9001F6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

