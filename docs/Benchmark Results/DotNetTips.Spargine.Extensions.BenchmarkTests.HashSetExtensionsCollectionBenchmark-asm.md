## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9F60B6F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FF9F6354CF0]
       mov       ecx,43
       mov       rdx,7FF9F62D5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62D5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6354AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FF9F6354CF0]
       mov       ecx,28D
       mov       rdx,7FF9F62D5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62D5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6354AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6066670]
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
       mov       rdx,7FF9F68D39D8
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
       mov       rdx,7FF9F68D39F0
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
       call      qword ptr [7FF9F603F030]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FF9F60B6F10]
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
       call      qword ptr [7FF9F5DD4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF9F60B6F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9F60B6C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FF9F60B6F70]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F603EF40]
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
       mov       rax,23263270008
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9F60C6F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FF9F6364CF0]
       mov       ecx,43
       mov       rdx,7FF9F62E5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6175A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62E5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6364AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FF9F6364CF0]
       mov       ecx,28D
       mov       rdx,7FF9F62E5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6175A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62E5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6364AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6076670]
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
       je        near ptr M01_L07
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        near ptr M01_L05
M01_L01:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r13d,eax
M01_L02:
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
M01_L03:
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
M01_L04:
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
M01_L05:
       mov       rdx,7FF9F68E2FA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L01
M01_L06:
       mov       rdx,7FF9F68E2FC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L04
M01_L07:
       xor       r13d,r13d
       jmp       near ptr M01_L02
M01_L08:
       call      qword ptr [7FF9F604F030]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FF9F60C6F10]
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
       call      qword ptr [7FF9F5DE4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF9F60C6F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9F60C6C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FF9F60C6F70]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M01_L00
M01_L14:
       mov       r8,[rsp+28]
       mov       eax,[r8+0C]
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M01_L08
       test      eax,eax
       jge       near ptr M01_L03
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
; Total bytes of code 663
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
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F604EF40]
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
       mov       rax,2988A7D0008
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9F6096F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,43
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,28D
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
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
       mov       rdx,7FF9F68B3210
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
       mov       rdx,7FF9F68B3228
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
       call      qword ptr [7FF9F601F030]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FF9F6096F10]
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
       call      qword ptr [7FF9F5DB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF9F6096F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9F6096C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FF9F6096F70]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F601EF40]
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
       mov       rax,2B644870008
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9F60C6F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FF9F6364CF0]
       mov       ecx,43
       mov       rdx,7FF9F62E5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6175A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62E5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6364AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FF9F6364CF0]
       mov       ecx,28D
       mov       rdx,7FF9F62E5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6175A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62E5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6364AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6076670]
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
       mov       rdx,7FF9F68E2F90
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
       mov       rdx,7FF9F68E2FA8
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
       call      qword ptr [7FF9F604F030]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FF9F60C6F10]
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
       call      qword ptr [7FF9F5DE4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF9F60C6F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9F60C6C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FF9F60C6F70]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F604EF40]
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
       mov       rax,305CCAB0008
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9F6086F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FF9F6324CF0]
       mov       ecx,43
       mov       rdx,7FF9F62A5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6135A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62A5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6324AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6036670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FF9F6324CF0]
       mov       ecx,28D
       mov       rdx,7FF9F62A5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6135A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62A5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6324AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6036670]
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
       mov       rdx,7FF9F68B2F78
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
       mov       rdx,7FF9F68B2F90
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
       call      qword ptr [7FF9F600F030]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FF9F6086F10]
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
       call      qword ptr [7FF9F5DA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF9F6086F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9F6086C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FF9F6086F70]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9F5E55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9F5E55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F600EF40]
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
       mov       rax,1816A860008
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9F60B6F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FF9F6354CF0]
       mov       ecx,43
       mov       rdx,7FF9F62D5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62D5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6354AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FF9F6354CF0]
       mov       ecx,28D
       mov       rdx,7FF9F62D5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62D5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6354AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6066670]
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
       mov       rdx,7FF9F68D2F78
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
       mov       rdx,7FF9F68D2F90
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
       call      qword ptr [7FF9F603F030]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FF9F60B6F10]
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
       call      qword ptr [7FF9F5DD4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF9F60B6F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9F60B6C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FF9F60B6F70]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F603EF40]
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
       mov       rax,259E9890008
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9F60A6F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FF9F6344CF0]
       mov       ecx,43
       mov       rdx,7FF9F62C5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6155A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62C5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6344AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6056670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FF9F6344CF0]
       mov       ecx,28D
       mov       rdx,7FF9F62C5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6155A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62C5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6344AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6056670]
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
       mov       rdx,7FF9F6858930
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
       mov       rdx,7FF9F6858948
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
       call      qword ptr [7FF9F602F030]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FF9F60A6F10]
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
       call      qword ptr [7FF9F5DC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF9F60A6F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9F60A6C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FF9F60A6F70]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F602EF40]
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
       mov       rax,1F695EC0008
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9F60C6F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FF9F6364CF0]
       mov       ecx,43
       mov       rdx,7FF9F62E5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6175A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62E5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6364AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FF9F6364CF0]
       mov       ecx,28D
       mov       rdx,7FF9F62E5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6175A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62E5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6364AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6076670]
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
       mov       rdx,7FF9F6868400
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
       mov       rdx,7FF9F6868418
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
       call      qword ptr [7FF9F604F030]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FF9F60C6F10]
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
       call      qword ptr [7FF9F5DE4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF9F60C6F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9F60C6C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FF9F60C6F70]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F604EF40]
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
       mov       rax,24D854A0008
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToConcurrentHashSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToConcurrentHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF9F683F678]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToConcurrentHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.HashSetExtensions.ToConcurrentHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-40],rsp
       mov       [rbp-18],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF9F6860B60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F683F348]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L08
       lea       rdx,[rbp-30]
       call      qword ptr [7FF9F6096CD0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rbx,[rdx+20]
       test      rbx,rbx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FF9F6860EF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M01_L03:
       mov       rdx,rbx
       lea       rcx,[rbp-30]
       call      qword ptr [7FF9F6444C78]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M01_L05
M01_L04:
       mov       rdx,[rbp-28]
       mov       rcx,rsi
       call      qword ptr [7FF9F6851220]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       rdx,rbx
       lea       rcx,[rbp-30]
       call      qword ptr [7FF9F6444C78]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M01_L04
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rax,[rdx+28]
       test      rax,rax
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rdx,7FF9F6860F20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L07:
       lea       rcx,[rbp-30]
       call      rax
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M01_L08:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,43
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rax,[rdx+28]
       test      rax,rax
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FF9F6860F20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L10:
       lea       rcx,[rbp-30]
       call      rax
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 469
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToConcurrentHashSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToConcurrentHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF9F6864DF8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToConcurrentHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.HashSetExtensions.ToConcurrentHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-40],rsp
       mov       [rbp-18],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF9F6870FB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F6864AC8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L08
       lea       rdx,[rbp-30]
       call      qword ptr [7FF9F6096CD0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rbx,[rdx+20]
       test      rbx,rbx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FF9F6871350
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M01_L03:
       mov       rdx,rbx
       lea       rcx,[rbp-30]
       call      qword ptr [7FF9F6444C78]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M01_L05
M01_L04:
       mov       rdx,[rbp-28]
       mov       rcx,rsi
       call      qword ptr [7FF9F68547C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       rdx,rbx
       lea       rcx,[rbp-30]
       call      qword ptr [7FF9F6444C78]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M01_L04
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rax,[rdx+28]
       test      rax,rax
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rdx,7FF9F6871378
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L07:
       lea       rcx,[rbp-30]
       call      rax
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M01_L08:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,43
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rax,[rdx+28]
       test      rax,rax
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FF9F6871378
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L10:
       lea       rcx,[rbp-30]
       call      rax
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 469
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToConcurrentHashSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToConcurrentHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF9F68650B0]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToConcurrentHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.HashSetExtensions.ToConcurrentHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-40],rsp
       mov       [rbp-18],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF9F68710C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F6864D80]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L08
       lea       rdx,[rbp-30]
       call      qword ptr [7FF9F6096CD0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rbx,[rdx+20]
       test      rbx,rbx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FF9F6871460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M01_L03:
       mov       rdx,rbx
       lea       rcx,[rbp-30]
       call      qword ptr [7FF9F6444C78]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M01_L05
M01_L04:
       mov       rdx,[rbp-28]
       mov       rcx,rsi
       call      qword ptr [7FF9F68547C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       rdx,rbx
       lea       rcx,[rbp-30]
       call      qword ptr [7FF9F6444C78]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M01_L04
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rax,[rdx+28]
       test      rax,rax
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rdx,7FF9F6871488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L07:
       lea       rcx,[rbp-30]
       call      rax
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M01_L08:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,43
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rax,[rdx+28]
       test      rax,rax
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FF9F6871488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L10:
       lea       rcx,[rbp-30]
       call      rax
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 469
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToConcurrentHashSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToConcurrentHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF9F68850B0]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToConcurrentHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.HashSetExtensions.ToConcurrentHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-40],rsp
       mov       [rbp-18],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF9F68910C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F6884D80]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L08
       lea       rdx,[rbp-30]
       call      qword ptr [7FF9F60B6CD0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rbx,[rdx+20]
       test      rbx,rbx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FF9F6891460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M01_L03:
       mov       rdx,rbx
       lea       rcx,[rbp-30]
       call      qword ptr [7FF9F6464C78]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M01_L05
M01_L04:
       mov       rdx,[rbp-28]
       mov       rcx,rsi
       call      qword ptr [7FF9F68747C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       rdx,rbx
       lea       rcx,[rbp-30]
       call      qword ptr [7FF9F6464C78]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M01_L04
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rax,[rdx+28]
       test      rax,rax
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rdx,7FF9F6891488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L07:
       lea       rcx,[rbp-30]
       call      rax
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M01_L08:
       call      qword ptr [7FF9F6354CF0]
       mov       ecx,43
       mov       rdx,7FF9F62D5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62D5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6354AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rax,[rdx+28]
       test      rax,rax
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FF9F6891488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L10:
       lea       rcx,[rbp-30]
       call      rax
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 469
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToConcurrentHashSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToConcurrentHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF9F6864DF8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToConcurrentHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.HashSetExtensions.ToConcurrentHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-40],rsp
       mov       [rbp-18],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF9F6870F70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F6864AC8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L08
       lea       rdx,[rbp-30]
       call      qword ptr [7FF9F6096CD0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rbx,[rdx+20]
       test      rbx,rbx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FF9F6871308
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M01_L03:
       mov       rdx,rbx
       lea       rcx,[rbp-30]
       call      qword ptr [7FF9F6444C78]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M01_L05
M01_L04:
       mov       rdx,[rbp-28]
       mov       rcx,rsi
       call      qword ptr [7FF9F68547C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       rdx,rbx
       lea       rcx,[rbp-30]
       call      qword ptr [7FF9F6444C78]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M01_L04
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rax,[rdx+28]
       test      rax,rax
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rdx,7FF9F6871330
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L07:
       lea       rcx,[rbp-30]
       call      rax
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M01_L08:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,43
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rax,[rdx+28]
       test      rax,rax
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FF9F6871330
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L10:
       lea       rcx,[rbp-30]
       call      rax
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 469
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToConcurrentHashSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToConcurrentHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF9F68950B0]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToConcurrentHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.HashSetExtensions.ToConcurrentHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-40],rsp
       mov       [rbp-18],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF9F68A10C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F6894D80]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L08
       lea       rdx,[rbp-30]
       call      qword ptr [7FF9F60C6CD0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rbx,[rdx+20]
       test      rbx,rbx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FF9F68A1460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M01_L03:
       mov       rdx,rbx
       lea       rcx,[rbp-30]
       call      qword ptr [7FF9F6474C78]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M01_L05
M01_L04:
       mov       rdx,[rbp-28]
       mov       rcx,rsi
       call      qword ptr [7FF9F68847C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       rdx,rbx
       lea       rcx,[rbp-30]
       call      qword ptr [7FF9F6474C78]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M01_L04
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rax,[rdx+28]
       test      rax,rax
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rdx,7FF9F68A1488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L07:
       lea       rcx,[rbp-30]
       call      rax
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M01_L08:
       call      qword ptr [7FF9F6364CF0]
       mov       ecx,43
       mov       rdx,7FF9F62E5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6175A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62E5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6364AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rax,[rdx+28]
       test      rax,rax
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FF9F68A1488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L10:
       lea       rcx,[rbp-30]
       call      rax
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 469
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToConcurrentHashSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToConcurrentHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF9F6A34DF8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToConcurrentHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.HashSetExtensions.ToConcurrentHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-40],rsp
       mov       [rbp-18],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF9F69FD650
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F6A34AC8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L08
       lea       rdx,[rbp-30]
       call      qword ptr [7FF9F60B6CD0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rbx,[rdx+20]
       test      rbx,rbx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FF9F69FD9E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M01_L03:
       mov       rdx,rbx
       lea       rcx,[rbp-30]
       call      qword ptr [7FF9F6464C78]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M01_L05
M01_L04:
       mov       rdx,[rbp-28]
       mov       rcx,rsi
       call      qword ptr [7FF9F6A220D0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       rdx,rbx
       lea       rcx,[rbp-30]
       call      qword ptr [7FF9F6464C78]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M01_L04
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rax,[rdx+28]
       test      rax,rax
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rdx,7FF9F69FDA10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L07:
       lea       rcx,[rbp-30]
       call      rax
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M01_L08:
       call      qword ptr [7FF9F6354CF0]
       mov       ecx,43
       mov       rdx,7FF9F62D5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62D5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6354AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rax,[rdx+28]
       test      rax,rax
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FF9F69FDA10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L10:
       lea       rcx,[rbp-30]
       call      rax
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 469
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToConcurrentHashSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToConcurrentHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF9F6A34630]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToConcurrentHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
; DotNetTips.Spargine.Extensions.HashSetExtensions.ToConcurrentHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-40],rsp
       mov       [rbp-18],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF9F69FFE38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F6A34300]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L08
       lea       rdx,[rbp-30]
       call      qword ptr [7FF9F60A6CD0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rbx,[rdx+20]
       test      rbx,rbx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FF9F6A40228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M01_L03:
       mov       rdx,rbx
       lea       rcx,[rbp-30]
       call      qword ptr [7FF9F6454C78]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M01_L05
M01_L04:
       mov       rdx,[rbp-28]
       mov       rcx,rsi
       call      qword ptr [7FF9F6A261D0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       rdx,rbx
       lea       rcx,[rbp-30]
       call      qword ptr [7FF9F6454C78]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M01_L04
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rax,[rdx+28]
       test      rax,rax
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rdx,7FF9F6A40250
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L07:
       lea       rcx,[rbp-30]
       call      rax
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M01_L08:
       call      qword ptr [7FF9F6344CF0]
       mov       ecx,43
       mov       rdx,7FF9F62C5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6155A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62C5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6344AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6056670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rax,[rdx+28]
       test      rax,rax
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FF9F6A40250
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L10:
       lea       rcx,[rbp-30]
       call      rax
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 469
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF9F68951B8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
       call      qword ptr [7FF9F626D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9F6895B60]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FF9F6882A90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FF9F6882FA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L02
M01_L05:
       call      qword ptr [7FF9F62EF990]
       mov       ecx,43
       mov       rdx,7FF9F62C5E78
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1446
       mov       rdx,7FF9F61559D0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF9F62C5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F62EF780]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6056670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L01
; Total bytes of code 315
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF9F688CFF0]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
       call      qword ptr [7FF9F627EAC0]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9F688D998]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FF9F68A2FD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FF9F68A34E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L02
M01_L05:
       call      qword ptr [7FF9F6354CF0]
       mov       ecx,43
       mov       rdx,7FF9F62D5E78
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF9F62D5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6354AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L01
; Total bytes of code 315
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF9F687CFF0]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
       call      qword ptr [7FF9F626EAC0]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9F687D998]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FF9F6892FD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FF9F68934E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L02
M01_L05:
       call      qword ptr [7FF9F6344CF0]
       mov       ecx,43
       mov       rdx,7FF9F62C5E78
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1446
       mov       rdx,7FF9F6155A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF9F62C5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6344AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6056670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L01
; Total bytes of code 315
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF9F686C810]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
       call      qword ptr [7FF9F625EAC0]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9F686D1B8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FF9F6882E80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FF9F6883390
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L02
M01_L05:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,43
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L01
; Total bytes of code 315
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF9F686CFF0]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
       call      qword ptr [7FF9F625EAC0]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9F686D998]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FF9F6882FD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FF9F68834E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L02
M01_L05:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,43
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L01
; Total bytes of code 315
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF9F686CFF0]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
       call      qword ptr [7FF9F626EAC0]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9F686D998]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FF9F6892FD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FF9F68934E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L02
M01_L05:
       call      qword ptr [7FF9F6344CF0]
       mov       ecx,43
       mov       rdx,7FF9F62C5760
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1446
       mov       rdx,7FF9F61552F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF9F62C5760
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6344AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6056670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L01
; Total bytes of code 315
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF9F69CEAF0]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
       call      qword ptr [7FF9F626EAC0]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9F69CF498]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FF9F69F2900
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FF9F69F2E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L02
M01_L05:
       call      qword ptr [7FF9F6344CF0]
       mov       ecx,43
       mov       rdx,7FF9F62C5E78
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1446
       mov       rdx,7FF9F6155A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF9F62C5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6344AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6056670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L01
; Total bytes of code 315
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF9F6A1C060]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
       call      qword ptr [7FF9F624EAC0]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9F6A1CA08]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FF9F6A32900
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FF9F6A32E10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M01_L02
M01_L05:
       call      qword ptr [7FF9F6324CF0]
       mov       ecx,43
       mov       rdx,7FF9F62A5E78
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1446
       mov       rdx,7FF9F6135A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF9F62A5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6324AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6036670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L01
; Total bytes of code 315
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF9F683F0A8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FF9F6096C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9F607F930]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9F6096F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,43
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,28D
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF9F6864AE0]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FF9F6096C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9F607F930]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9F6096F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,43
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,28D
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF9F6874828]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FF9F60A6C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9F608F930]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9F60A6F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF9F6344CF0]
       mov       ecx,43
       mov       rdx,7FF9F62C5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6155A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62C5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6344AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6056670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FF9F6344CF0]
       mov       ecx,28D
       mov       rdx,7FF9F62C5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6155A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62C5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6344AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6056670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF9F6864AE0]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FF9F6096C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9F607F930]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9F6096F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,43
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,28D
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF9F6884AE0]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FF9F60B6C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9F609F930]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9F60B6F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF9F6354CF0]
       mov       ecx,43
       mov       rdx,7FF9F62D5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62D5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6354AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FF9F6354CF0]
       mov       ecx,28D
       mov       rdx,7FF9F62D5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62D5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6354AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF9F6884AE0]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FF9F60B6C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9F609F930]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9F60B6F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF9F6354CF0]
       mov       ecx,43
       mov       rdx,7FF9F62D5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62D5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6354AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FF9F6354CF0]
       mov       ecx,28D
       mov       rdx,7FF9F62D5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62D5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6354AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF9F69E65E0]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FF9F60C6C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9F60AF930]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9F60C6F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF9F6364CF0]
       mov       ecx,43
       mov       rdx,7FF9F62E5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6175A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62E5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6364AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FF9F6364CF0]
       mov       ecx,28D
       mov       rdx,7FF9F62E5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6175A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62E5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6364AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF9F6A0FAC8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FF9F6096C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9F607F930]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9F6096F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,43
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,28D
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62B5E78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

