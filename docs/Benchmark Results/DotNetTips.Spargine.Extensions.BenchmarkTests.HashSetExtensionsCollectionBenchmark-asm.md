## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.AddIf()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rdx,[rbx+288]
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
       call      qword ptr [7FF95CD66F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FF95D004C60]
       mov       ecx,49
       mov       rdx,7FF95CF89088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE15108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF89088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D004A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FF95D004C60]
       mov       ecx,25D
       mov       rdx,7FF95CF89088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE15108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF89088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D004A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD16670]
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
       mov       rdx,7FF95D585138
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
       mov       rdx,7FF95D585150
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
       call      qword ptr [7FF95CCEF030]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FF95CD66F10]
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
       call      qword ptr [7FF95CA84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF95CD66F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF95CD66C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FF95CD66F70]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF95CB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF95CCEEF40]
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
       mov       rax,30B1A770008
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.AddIf()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rdx,[rbx+288]
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
       call      qword ptr [7FF95CDA6F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FF95D044C60]
       mov       ecx,49
       mov       rdx,7FF95CFC9088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE55108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CFC9088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D044A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD56670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FF95D044C60]
       mov       ecx,25D
       mov       rdx,7FF95CFC9088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE55108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CFC9088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D044A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD56670]
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
       mov       rdx,7FF95D5C72A8
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
       mov       rdx,7FF95D5C72C0
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
       call      qword ptr [7FF95CD2F030]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FF95CDA6F10]
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
       call      qword ptr [7FF95CAC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF95CDA6F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF95CDA6C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FF95CDA6F70]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF95CB75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF95CD2EF40]
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
       mov       rax,1C5B7C10008
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.AddIf()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rdx,[rbx+288]
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
       call      qword ptr [7FF95CD96F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FF95D034C60]
       mov       ecx,49
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD46670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FF95D034C60]
       mov       ecx,25D
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD46670]
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
       mov       rdx,7FF95D5B7570
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
       mov       rdx,7FF95D5B7588
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
       call      qword ptr [7FF95CD1F030]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FF95CD96F10]
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
       call      qword ptr [7FF95CAB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF95CD96F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF95CD96C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FF95CD96F70]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF95CB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF95CD1EF40]
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
       mov       rax,22961610008
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.AddIf()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rdx,[rbx+288]
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
       call      qword ptr [7FF95CD76F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FF95CFBF4F8]
       mov       ecx,49
       mov       rdx,7FF95CF98B80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE24D28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF98B80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95CFBF2E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FF95CFBF4F8]
       mov       ecx,25D
       mov       rdx,7FF95CF98B80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE24D28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF98B80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95CFBF2E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD26670]
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
       mov       rdx,7FF95D597570
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
       mov       rdx,7FF95D597588
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
       call      qword ptr [7FF95CCFF030]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FF95CD76F10]
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
       call      qword ptr [7FF95CA94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF95CD76F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF95CD76C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FF95CD76F70]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF95CB45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF95CCFEF40]
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
       mov       rax,242C4360008
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.AddIf()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rdx,[rbx+288]
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
       call      qword ptr [7FF95CD96F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FF95D034C60]
       mov       ecx,49
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD46670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FF95D034C60]
       mov       ecx,25D
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD46670]
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
       mov       rdx,7FF95D5B7630
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
       mov       rdx,7FF95D5B7648
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
       call      qword ptr [7FF95CD1F030]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FF95CD96F10]
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
       call      qword ptr [7FF95CAB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF95CD96F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF95CD96C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FF95CD96F70]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF95CB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF95CD1EF40]
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
       mov       rax,25591200008
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.AddIf()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rdx,[rbx+288]
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
       call      qword ptr [7FF95CD96F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FF95D034C60]
       mov       ecx,49
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD46670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FF95D034C60]
       mov       ecx,25D
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD46670]
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
       mov       rdx,7FF95D663298
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
       mov       rdx,7FF95D6632B0
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
       call      qword ptr [7FF95CD1F030]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FF95CD96F10]
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
       call      qword ptr [7FF95CAB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF95CD96F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF95CD96C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FF95CD96F70]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF95CB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF95CD1EF40]
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
       mov       rax,274E5300008
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.AddIf()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rdx,[rbx+288]
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
       call      qword ptr [7FF95CD66F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FF95D004C60]
       mov       ecx,49
       mov       rdx,7FF95CF89088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE15108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF89088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D004A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FF95D004C60]
       mov       ecx,25D
       mov       rdx,7FF95CF89088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE15108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF89088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D004A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD16670]
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
       mov       rdx,7FF95D61F850
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
       mov       rdx,7FF95D61F868
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
       call      qword ptr [7FF95CCEF030]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FF95CD66F10]
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
       call      qword ptr [7FF95CA84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF95CD66F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF95CD66C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FF95CD66F70]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF95CB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF95CCEEF40]
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
       mov       rax,2C47C6C0008
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.AddIf()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rdx,[rbx+288]
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
       call      qword ptr [7FF95CD76F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FF95D014C60]
       mov       ecx,49
       mov       rdx,7FF95CF99088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE25108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF99088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FF95D014C60]
       mov       ecx,25D
       mov       rdx,7FF95CF99088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE25108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF99088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD26670]
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
       mov       rdx,7FF95D5E15C8
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
       mov       rdx,7FF95D5E15E0
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
       call      qword ptr [7FF95CCFF030]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FF95CD76F10]
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
       call      qword ptr [7FF95CA94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF95CD76F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF95CD76C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FF95CD76F70]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF95CB45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF95CCFEF40]
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
       mov       rax,29F7FF20008
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToConcurrentHashSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,0C
       mov       ebp,1F
       cmp       ebp,edx
       cmovl     ebp,edx
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       mov       r15d,[r14+8]
       mov       r13d,r15d
       mov       r12,r13
       xor       eax,eax
       mov       [rsp+44],eax
       test      r12,r12
       jle       short M00_L01
       mov       rdx,offset MT_System.Object
       mov       [rsp+30],rdx
M00_L00:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+44]
       cmp       r8d,r15d
       jae       near ptr M00_L09
       mov       [rsp+44],r8d
       mov       ecx,r8d
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8d,[rsp+44]
       add       r8d,1
       jo        near ptr M00_L04
       movsxd    rdx,r8d
       cmp       rdx,r12
       mov       [rsp+44],r8d
       mov       rdx,[rsp+30]
       jl        short M00_L00
M00_L01:
       mov       rdx,r13
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       movsxd    rdx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Tables[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r13
       lea       rcx,[r12+10]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+1C],1
       mov       eax,[rbp+8]
       xor       edx,edx
       div       r15d
       mov       [rdi+18],eax
       mov       rcx,17139801FD8
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1B1CB70EC98
       mov       [rsp+20],rdx
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1B1CB700008
       call      qword ptr [7FF95D28C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FF95CAA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L07
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FF95CB5DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L02:
       mov       rcx,offset MT_System.Action`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       call      qword ptr [7FF95CAA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,rbp
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95CB5E3B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rdi+18],0
       je        near ptr M00_L08
M00_L03:
       mov       [rsp+38],rdi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF95D52EBE0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L04:
       call      CORINFO_HELP_OVERFLOW
M00_L05:
       call      qword ptr [7FF95D024C60]
       mov       ecx,49
       mov       rdx,7FF95CFA9088
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,1464
       mov       rdx,7FF95CE35108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CFA9088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D024A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD36670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       ecx,10
       call      qword ptr [7FF95CD34F30]
       int       3
M00_L07:
       mov       rcx,rax
       mov       r11,7FF95C961048
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L02
M00_L08:
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
       mov       eax,[rax+8]
       mov       rdx,[rdi+10]
       mov       rcx,[rdx+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rdi+18],eax
       jmp       near ptr M00_L03
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 812
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,r9
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       je        short M01_L01
M01_L00:
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       test      r8,r8
       je        short M01_L02
       mov       rax,r8
       mov       rdx,rax
       jmp       short M01_L00
M01_L02:
       call      qword ptr [7FF95D024C60]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,1B1CB700210
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M01_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M01_L04
M01_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D024A50]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF95CD36670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 159
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       push      rbx
       test      rdx,rdx
       je        short M02_L02
       mov       rbx,[rdx]
       movzx     r8d,word ptr [rbx+0E]
       test      r8,r8
       je        short M02_L01
       mov       r10,[rbx+38]
       cmp       r8,4
       jl        short M02_L04
M02_L00:
       cmp       [r10],rcx
       je        short M02_L02
       cmp       [r10+8],rcx
       je        short M02_L02
       cmp       [r10+10],rcx
       je        short M02_L02
       cmp       [r10+18],rcx
       je        short M02_L02
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M02_L00
       test      r8,r8
       jne       short M02_L04
M02_L01:
       test      dword ptr [rbx],406C0000
       jne       short M02_L03
       xor       edx,edx
M02_L02:
       mov       rax,rdx
       pop       rbx
       ret
M02_L03:
       pop       rbx
       jmp       qword ptr [7FF95CAA4378]
M02_L04:
       cmp       [r10],rcx
       je        short M02_L02
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M02_L04
       jmp       short M02_L01
; Total bytes of code 112
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
       je        near ptr M03_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rdx
       mov       rdx,7FF95D6DABB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M03_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF95CAA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M03_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FF95D6DABF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M03_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FF95D22F868
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L05:
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
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FF95D6DAC08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L07:
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
M03_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L09
       jmp       short M03_L10
M03_L09:
       mov       rcx,rsi
       mov       rdx,7FF95D22F858
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M03_L11
       jmp       short M03_L12
M03_L11:
       mov       rcx,rsi
       mov       rdx,7FF95D6DABC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M03_L17
M03_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M03_L14
       jmp       short M03_L15
M03_L14:
       mov       rcx,rsi
       mov       rdx,7FF95D6DABD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M03_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M03_L17
M03_L16:
       mov       rdx,r8
       call      qword ptr [7FF95CB5E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M03_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF95C961050
       call      qword ptr [r11]
       test      eax,eax
       jne       short M03_L13
       mov       rcx,rsp
       call      M03_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L18:
       mov       ecx,17
       call      qword ptr [7FF95CD0ED00]
       int       3
M03_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L20
       jmp       short M03_L21
M03_L20:
       mov       rcx,rsi
       mov       rdx,7FF95D22F858
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L21:
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
M03_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M03_L23
       mov       rcx,[rbp-28]
       mov       r11,7FF95C961058
       call      qword ptr [r11]
M03_L23:
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
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+40]
       test      r11,r11
       je        short M04_L00
       jmp       short M04_L01
M04_L00:
       mov       rdx,7FF95D50F148
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M04_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r8d,eax
       mov       rdx,rsi
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF95D52D5D8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 92
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M05_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       call      qword ptr [7FF95CAA41F8]
       int       3
; Total bytes of code 44
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M06_L04
       mov       edi,[rbx+14]
       xor       ebp,ebp
       cmp       dword ptr [rbx+10],0
       jle       short M06_L03
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       cmp       [rsi+18],rcx
       jne       short M06_L01
M06_L00:
       cmp       edi,[rbx+14]
       jne       short M06_L03
       mov       r14,[rbx+8]
       cmp       ebp,[r14+8]
       jae       near ptr M06_L07
       mov       ecx,ebp
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [7FF95D52D788]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M06_L00
       jmp       short M06_L03
M06_L01:
       cmp       edi,[rbx+14]
       jne       short M06_L03
       mov       r14,[rbx+8]
       cmp       ebp,[r14+8]
       jae       short M06_L07
       mov       ecx,ebp
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       cmp       [rsi+18],rcx
       jne       short M06_L05
       mov       rcx,[rsi+8]
       call      qword ptr [7FF95D52D788]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
M06_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M06_L01
M06_L03:
       cmp       edi,[rbx+14]
       jne       short M06_L06
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L04:
       mov       ecx,1C
       call      qword ptr [7FF95CD0ED00]
       int       3
M06_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M06_L02
M06_L06:
       call      qword ptr [7FF95CD0EFE8]
       int       3
M06_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 202
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
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
       je        near ptr M08_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M08_L02
       test      rbx,rbx
       je        short M08_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M08_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M08_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF95CB55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L01:
       call      qword ptr [7FF95CD0EF40]
       int       3
M08_L02:
       test      rbx,rbx
       je        short M08_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M08_L04
M08_L03:
       mov       rax,1B1CB700008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToConcurrentHashSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,0C
       mov       ebp,1F
       cmp       ebp,edx
       cmovl     ebp,edx
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       mov       r15d,[r14+8]
       mov       r13d,r15d
       mov       r12,r13
       xor       eax,eax
       mov       [rsp+44],eax
       test      r12,r12
       jle       short M00_L01
       mov       rdx,offset MT_System.Object
       mov       [rsp+30],rdx
M00_L00:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+44]
       cmp       r8d,r15d
       jae       near ptr M00_L09
       mov       [rsp+44],r8d
       mov       ecx,r8d
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8d,[rsp+44]
       add       r8d,1
       jo        near ptr M00_L04
       movsxd    rdx,r8d
       cmp       rdx,r12
       mov       [rsp+44],r8d
       mov       rdx,[rsp+30]
       jl        short M00_L00
M00_L01:
       mov       rdx,r13
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       movsxd    rdx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Tables[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r13
       lea       rcx,[r12+10]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+1C],1
       mov       eax,[rbp+8]
       xor       edx,edx
       div       r15d
       mov       [rdi+18],eax
       mov       rcx,2075A001FD8
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,247E7EEEC98
       mov       [rsp+20],rdx
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,247E7EE0008
       call      qword ptr [7FF95D2AC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FF95CAC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L07
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FF95CB7DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L02:
       mov       rcx,offset MT_System.Action`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       call      qword ptr [7FF95CAC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,rbp
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95CB7E3B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rdi+18],0
       je        near ptr M00_L08
M00_L03:
       mov       [rsp+38],rdi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF95D55FF78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L04:
       call      CORINFO_HELP_OVERFLOW
M00_L05:
       call      qword ptr [7FF95D044C60]
       mov       ecx,49
       mov       rdx,7FF95CFC9088
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,1464
       mov       rdx,7FF95CE55108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF95CAC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CFC9088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D044A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD56670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       ecx,10
       call      qword ptr [7FF95CD54F30]
       int       3
M00_L07:
       mov       rcx,rax
       mov       r11,7FF95C980F28
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L02
M00_L08:
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
       mov       eax,[rax+8]
       mov       rdx,[rdi+10]
       mov       rcx,[rdx+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rdi+18],eax
       jmp       near ptr M00_L03
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 812
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,r9
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       je        short M01_L01
M01_L00:
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       test      r8,r8
       je        short M01_L02
       mov       rax,r8
       mov       rdx,rax
       jmp       short M01_L00
M01_L02:
       call      qword ptr [7FF95D044C60]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,247E7EE0210
       call      qword ptr [7FF95CAC6B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M01_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FF95CAC6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M01_L04
M01_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF95CAC6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D044A50]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF95CD56670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 159
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       push      rbx
       test      rdx,rdx
       je        short M02_L02
       mov       rbx,[rdx]
       movzx     r8d,word ptr [rbx+0E]
       test      r8,r8
       je        short M02_L01
       mov       r10,[rbx+38]
       cmp       r8,4
       jl        short M02_L04
M02_L00:
       cmp       [r10],rcx
       je        short M02_L02
       cmp       [r10+8],rcx
       je        short M02_L02
       cmp       [r10+10],rcx
       je        short M02_L02
       cmp       [r10+18],rcx
       je        short M02_L02
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M02_L00
       test      r8,r8
       jne       short M02_L04
M02_L01:
       test      dword ptr [rbx],406C0000
       jne       short M02_L03
       xor       edx,edx
M02_L02:
       mov       rax,rdx
       pop       rbx
       ret
M02_L03:
       pop       rbx
       jmp       qword ptr [7FF95CAC4378]
M02_L04:
       cmp       [r10],rcx
       je        short M02_L02
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M02_L04
       jmp       short M02_L01
; Total bytes of code 112
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
       je        near ptr M03_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rdx
       mov       rdx,7FF95D6FD578
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M03_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF95CAC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M03_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FF95D6FD5B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M03_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FF95D24F850
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L05:
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
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FF95D6FD5D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L07:
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
M03_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L09
       jmp       short M03_L10
M03_L09:
       mov       rcx,rsi
       mov       rdx,7FF95D24F840
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M03_L11
       jmp       short M03_L12
M03_L11:
       mov       rcx,rsi
       mov       rdx,7FF95D6FD588
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M03_L17
M03_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M03_L14
       jmp       short M03_L15
M03_L14:
       mov       rcx,rsi
       mov       rdx,7FF95D6FD5A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M03_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M03_L17
M03_L16:
       mov       rdx,r8
       call      qword ptr [7FF95CB7E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M03_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF95C980F30
       call      qword ptr [r11]
       test      eax,eax
       jne       short M03_L13
       mov       rcx,rsp
       call      M03_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L18:
       mov       ecx,17
       call      qword ptr [7FF95CD2ED00]
       int       3
M03_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L20
       jmp       short M03_L21
M03_L20:
       mov       rcx,rsi
       mov       rdx,7FF95D24F840
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L21:
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
M03_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M03_L23
       mov       rcx,[rbp-28]
       mov       r11,7FF95C980F38
       call      qword ptr [r11]
M03_L23:
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
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+40]
       test      r11,r11
       je        short M04_L00
       jmp       short M04_L01
M04_L00:
       mov       rdx,7FF95D561FB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M04_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r8d,eax
       mov       rdx,rsi
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF95D55E970]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 92
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M05_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       call      qword ptr [7FF95CAC41F8]
       int       3
; Total bytes of code 44
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M06_L04
       mov       edi,[rbx+14]
       xor       ebp,ebp
       cmp       dword ptr [rbx+10],0
       jle       short M06_L03
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       cmp       [rsi+18],rcx
       jne       short M06_L01
M06_L00:
       cmp       edi,[rbx+14]
       jne       short M06_L03
       mov       r14,[rbx+8]
       cmp       ebp,[r14+8]
       jae       near ptr M06_L07
       mov       ecx,ebp
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [7FF95D55EB20]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M06_L00
       jmp       short M06_L03
M06_L01:
       cmp       edi,[rbx+14]
       jne       short M06_L03
       mov       r14,[rbx+8]
       cmp       ebp,[r14+8]
       jae       short M06_L07
       mov       ecx,ebp
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       cmp       [rsi+18],rcx
       jne       short M06_L05
       mov       rcx,[rsi+8]
       call      qword ptr [7FF95D55EB20]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
M06_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M06_L01
M06_L03:
       cmp       edi,[rbx+14]
       jne       short M06_L06
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L04:
       mov       ecx,1C
       call      qword ptr [7FF95CD2ED00]
       int       3
M06_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M06_L02
M06_L06:
       call      qword ptr [7FF95CD2EFE8]
       int       3
M06_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 202
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
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
       je        near ptr M08_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M08_L02
       test      rbx,rbx
       je        short M08_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M08_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M08_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF95CB75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L01:
       call      qword ptr [7FF95CD2EF40]
       int       3
M08_L02:
       test      rbx,rbx
       je        short M08_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M08_L04
M08_L03:
       mov       rax,247E7EE0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToConcurrentHashSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,0C
       mov       ebp,1F
       cmp       ebp,edx
       cmovl     ebp,edx
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       mov       r15d,[r14+8]
       mov       r13d,r15d
       mov       r12,r13
       xor       eax,eax
       mov       [rsp+44],eax
       test      r12,r12
       jle       short M00_L01
       mov       rdx,offset MT_System.Object
       mov       [rsp+30],rdx
M00_L00:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+44]
       cmp       r8d,r15d
       jae       near ptr M00_L09
       mov       [rsp+44],r8d
       mov       ecx,r8d
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8d,[rsp+44]
       add       r8d,1
       jo        near ptr M00_L04
       movsxd    rdx,r8d
       cmp       rdx,r12
       mov       [rsp+44],r8d
       mov       rdx,[rsp+30]
       jl        short M00_L00
M00_L01:
       mov       rdx,r13
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       movsxd    rdx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Tables[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r13
       lea       rcx,[r12+10]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+1C],1
       mov       eax,[rbp+8]
       xor       edx,edx
       div       r15d
       mov       [rdi+18],eax
       mov       rcx,24EDA801FD8
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,28F6887EC98
       mov       [rsp+20],rdx
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,28F68870008
       call      qword ptr [7FF95D26C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FF95CA84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L07
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FF95CB3DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L02:
       mov       rcx,offset MT_System.Action`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       call      qword ptr [7FF95CA84210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,rbp
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95CB3E3B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rdi+18],0
       je        near ptr M00_L08
M00_L03:
       mov       [rsp+38],rdi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF95D51FEA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L04:
       call      CORINFO_HELP_OVERFLOW
M00_L05:
       call      qword ptr [7FF95D004C60]
       mov       ecx,49
       mov       rdx,7FF95CF89088
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,1464
       mov       rdx,7FF95CE15108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF89088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D004A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       ecx,10
       call      qword ptr [7FF95CD14F30]
       int       3
M00_L07:
       mov       rcx,rax
       mov       r11,7FF95C940F28
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L02
M00_L08:
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
       mov       eax,[rax+8]
       mov       rdx,[rdi+10]
       mov       rcx,[rdx+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rdi+18],eax
       jmp       near ptr M00_L03
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 812
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,r9
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       je        short M01_L01
M01_L00:
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       test      r8,r8
       je        short M01_L02
       mov       rax,r8
       mov       rdx,rax
       jmp       short M01_L00
M01_L02:
       call      qword ptr [7FF95D004C60]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,28F68870210
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M01_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M01_L04
M01_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D004A50]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF95CD16670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 159
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       push      rbx
       test      rdx,rdx
       je        short M02_L02
       mov       rbx,[rdx]
       movzx     r8d,word ptr [rbx+0E]
       test      r8,r8
       je        short M02_L01
       mov       r10,[rbx+38]
       cmp       r8,4
       jl        short M02_L04
M02_L00:
       cmp       [r10],rcx
       je        short M02_L02
       cmp       [r10+8],rcx
       je        short M02_L02
       cmp       [r10+10],rcx
       je        short M02_L02
       cmp       [r10+18],rcx
       je        short M02_L02
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M02_L00
       test      r8,r8
       jne       short M02_L04
M02_L01:
       test      dword ptr [rbx],406C0000
       jne       short M02_L03
       xor       edx,edx
M02_L02:
       mov       rax,rdx
       pop       rbx
       ret
M02_L03:
       pop       rbx
       jmp       qword ptr [7FF95CA84378]
M02_L04:
       cmp       [r10],rcx
       je        short M02_L02
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M02_L04
       jmp       short M02_L01
; Total bytes of code 112
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
       je        near ptr M03_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rdx
       mov       rdx,7FF95D6BD588
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M03_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF95CA84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M03_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FF95D6BD5C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M03_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FF95D20F858
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L05:
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
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FF95D6BD5E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L07:
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
M03_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L09
       jmp       short M03_L10
M03_L09:
       mov       rcx,rsi
       mov       rdx,7FF95D20F848
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M03_L11
       jmp       short M03_L12
M03_L11:
       mov       rcx,rsi
       mov       rdx,7FF95D6BD598
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M03_L17
M03_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M03_L14
       jmp       short M03_L15
M03_L14:
       mov       rcx,rsi
       mov       rdx,7FF95D6BD5B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M03_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M03_L17
M03_L16:
       mov       rdx,r8
       call      qword ptr [7FF95CB3E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M03_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF95C940F30
       call      qword ptr [r11]
       test      eax,eax
       jne       short M03_L13
       mov       rcx,rsp
       call      M03_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L18:
       mov       ecx,17
       call      qword ptr [7FF95CCEED00]
       int       3
M03_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L20
       jmp       short M03_L21
M03_L20:
       mov       rcx,rsi
       mov       rdx,7FF95D20F848
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L21:
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
M03_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M03_L23
       mov       rcx,[rbp-28]
       mov       r11,7FF95C940F38
       call      qword ptr [r11]
M03_L23:
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
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+40]
       test      r11,r11
       je        short M04_L00
       jmp       short M04_L01
M04_L00:
       mov       rdx,7FF95D521E30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M04_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r8d,eax
       mov       rdx,rsi
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF95D51E898]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 92
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M05_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       call      qword ptr [7FF95CA841F8]
       int       3
; Total bytes of code 44
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M06_L04
       mov       edi,[rbx+14]
       xor       ebp,ebp
       cmp       dword ptr [rbx+10],0
       jle       short M06_L03
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       cmp       [rsi+18],rcx
       jne       short M06_L01
M06_L00:
       cmp       edi,[rbx+14]
       jne       short M06_L03
       mov       r14,[rbx+8]
       cmp       ebp,[r14+8]
       jae       near ptr M06_L07
       mov       ecx,ebp
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [7FF95D51EA48]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M06_L00
       jmp       short M06_L03
M06_L01:
       cmp       edi,[rbx+14]
       jne       short M06_L03
       mov       r14,[rbx+8]
       cmp       ebp,[r14+8]
       jae       short M06_L07
       mov       ecx,ebp
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       cmp       [rsi+18],rcx
       jne       short M06_L05
       mov       rcx,[rsi+8]
       call      qword ptr [7FF95D51EA48]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
M06_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M06_L01
M06_L03:
       cmp       edi,[rbx+14]
       jne       short M06_L06
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L04:
       mov       ecx,1C
       call      qword ptr [7FF95CCEED00]
       int       3
M06_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M06_L02
M06_L06:
       call      qword ptr [7FF95CCEEFE8]
       int       3
M06_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 202
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
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
       je        near ptr M08_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M08_L02
       test      rbx,rbx
       je        short M08_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M08_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M08_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF95CB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L01:
       call      qword ptr [7FF95CCEEF40]
       int       3
M08_L02:
       test      rbx,rbx
       je        short M08_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M08_L04
M08_L03:
       mov       rax,28F68870008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToConcurrentHashSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,0C
       mov       ebp,1F
       cmp       ebp,edx
       cmovl     ebp,edx
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       mov       r15d,[r14+8]
       mov       r13d,r15d
       mov       r12,r13
       xor       eax,eax
       mov       [rsp+44],eax
       test      r12,r12
       jle       short M00_L01
       mov       rdx,offset MT_System.Object
       mov       [rsp+30],rdx
M00_L00:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+44]
       cmp       r8d,r15d
       jae       near ptr M00_L09
       mov       [rsp+44],r8d
       mov       ecx,r8d
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8d,[rsp+44]
       add       r8d,1
       jo        near ptr M00_L04
       movsxd    rdx,r8d
       cmp       rdx,r12
       mov       [rsp+44],r8d
       mov       rdx,[rsp+30]
       jl        short M00_L00
M00_L01:
       mov       rdx,r13
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       movsxd    rdx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Tables[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r13
       lea       rcx,[r12+10]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+1C],1
       mov       eax,[rbp+8]
       xor       edx,edx
       div       r15d
       mov       [rdi+18],eax
       mov       rcx,1480F001FD8
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,188A106EC98
       mov       [rsp+20],rdx
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,188A1060008
       call      qword ptr [7FF95D26C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FF95CA84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L07
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FF95CB3DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L02:
       mov       rcx,offset MT_System.Action`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       call      qword ptr [7FF95CA84210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,rbp
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95CB3E3B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rdi+18],0
       je        near ptr M00_L08
M00_L03:
       mov       [rsp+38],rdi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF95D51FF78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L04:
       call      CORINFO_HELP_OVERFLOW
M00_L05:
       call      qword ptr [7FF95D004C60]
       mov       ecx,49
       mov       rdx,7FF95CF89088
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,1464
       mov       rdx,7FF95CE15108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF89088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D004A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       ecx,10
       call      qword ptr [7FF95CD14F30]
       int       3
M00_L07:
       mov       rcx,rax
       mov       r11,7FF95C940F38
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L02
M00_L08:
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
       mov       eax,[rax+8]
       mov       rdx,[rdi+10]
       mov       rcx,[rdx+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rdi+18],eax
       jmp       near ptr M00_L03
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 812
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,r9
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       je        short M01_L01
M01_L00:
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       test      r8,r8
       je        short M01_L02
       mov       rax,r8
       mov       rdx,rax
       jmp       short M01_L00
M01_L02:
       call      qword ptr [7FF95D004C60]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,188A1060210
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M01_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M01_L04
M01_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D004A50]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF95CD16670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 159
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       push      rbx
       test      rdx,rdx
       je        short M02_L02
       mov       rbx,[rdx]
       movzx     r8d,word ptr [rbx+0E]
       test      r8,r8
       je        short M02_L01
       mov       r10,[rbx+38]
       cmp       r8,4
       jl        short M02_L04
M02_L00:
       cmp       [r10],rcx
       je        short M02_L02
       cmp       [r10+8],rcx
       je        short M02_L02
       cmp       [r10+10],rcx
       je        short M02_L02
       cmp       [r10+18],rcx
       je        short M02_L02
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M02_L00
       test      r8,r8
       jne       short M02_L04
M02_L01:
       test      dword ptr [rbx],406C0000
       jne       short M02_L03
       xor       edx,edx
M02_L02:
       mov       rax,rdx
       pop       rbx
       ret
M02_L03:
       pop       rbx
       jmp       qword ptr [7FF95CA84378]
M02_L04:
       cmp       [r10],rcx
       je        short M02_L02
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M02_L04
       jmp       short M02_L01
; Total bytes of code 112
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
       je        near ptr M03_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rdx
       mov       rdx,7FF95D6BCD40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M03_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF95CA84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M03_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FF95D6BCD80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M03_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FF95D20C9B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L05:
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
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FF95D6BCD98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L07:
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
M03_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L09
       jmp       short M03_L10
M03_L09:
       mov       rcx,rsi
       mov       rdx,7FF95D20C760
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M03_L11
       jmp       short M03_L12
M03_L11:
       mov       rcx,rsi
       mov       rdx,7FF95D6BCD50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M03_L17
M03_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M03_L14
       jmp       short M03_L15
M03_L14:
       mov       rcx,rsi
       mov       rdx,7FF95D6BCD68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M03_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M03_L17
M03_L16:
       mov       rdx,r8
       call      qword ptr [7FF95CB3E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M03_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF95C940F28
       call      qword ptr [r11]
       test      eax,eax
       jne       short M03_L13
       mov       rcx,rsp
       call      M03_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L18:
       mov       ecx,17
       call      qword ptr [7FF95CCEED00]
       int       3
M03_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L20
       jmp       short M03_L21
M03_L20:
       mov       rcx,rsi
       mov       rdx,7FF95D20C760
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L21:
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
M03_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M03_L23
       mov       rcx,[rbp-28]
       mov       r11,7FF95C940F30
       call      qword ptr [r11]
M03_L23:
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
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+40]
       test      r11,r11
       je        short M04_L00
       jmp       short M04_L01
M04_L00:
       mov       rdx,7FF95D521FB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M04_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r8d,eax
       mov       rdx,rsi
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF95D51E970]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 92
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M05_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       call      qword ptr [7FF95CA841F8]
       int       3
; Total bytes of code 44
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M06_L04
       mov       edi,[rbx+14]
       xor       ebp,ebp
       cmp       dword ptr [rbx+10],0
       jle       short M06_L03
       mov       r14,[rsi+18]
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       cmp       r14,rcx
       jne       short M06_L01
M06_L00:
       cmp       edi,[rbx+14]
       jne       short M06_L03
       mov       r14,[rbx+8]
       cmp       ebp,[r14+8]
       jae       short M06_L07
       mov       ecx,ebp
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [7FF95D51EB20]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M06_L00
       jmp       short M06_L03
M06_L01:
       cmp       edi,[rbx+14]
       jne       short M06_L03
       mov       rcx,[rbx+8]
       cmp       ebp,[rcx+8]
       jae       short M06_L07
       mov       edx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       cmp       r14,rcx
       jne       short M06_L05
       mov       rcx,[rsi+8]
       call      qword ptr [7FF95D51EB20]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
M06_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M06_L01
M06_L03:
       cmp       edi,[rbx+14]
       jne       short M06_L06
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L04:
       mov       ecx,1C
       call      qword ptr [7FF95CCEED00]
       int       3
M06_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M06_L02
M06_L06:
       call      qword ptr [7FF95CCEEFE8]
       int       3
M06_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 199
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
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
       je        near ptr M08_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M08_L02
       test      rbx,rbx
       je        short M08_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M08_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M08_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF95CB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L01:
       call      qword ptr [7FF95CCEEF40]
       int       3
M08_L02:
       test      rbx,rbx
       je        short M08_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M08_L04
M08_L03:
       mov       rax,188A1060008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToConcurrentHashSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,0C
       mov       ebp,1F
       cmp       ebp,edx
       cmovl     ebp,edx
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       mov       r15d,[r14+8]
       mov       r13d,r15d
       mov       r12,r13
       xor       eax,eax
       mov       [rsp+44],eax
       test      r12,r12
       jle       short M00_L01
       mov       rdx,offset MT_System.Object
       mov       [rsp+30],rdx
M00_L00:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+44]
       cmp       r8d,r15d
       jae       near ptr M00_L09
       mov       [rsp+44],r8d
       mov       ecx,r8d
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8d,[rsp+44]
       add       r8d,1
       jo        near ptr M00_L04
       movsxd    rdx,r8d
       cmp       rdx,r12
       mov       [rsp+44],r8d
       mov       rdx,[rsp+30]
       jl        short M00_L00
M00_L01:
       mov       rdx,r13
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       movsxd    rdx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Tables[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r13
       lea       rcx,[r12+10]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+1C],1
       mov       eax,[rbp+8]
       xor       edx,edx
       div       r15d
       mov       [rdi+18],eax
       mov       rcx,26C10C01FD8
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2ACA29EEC98
       mov       [rsp+20],rdx
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2ACA29E0008
       call      qword ptr [7FF95D26C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FF95CA84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L07
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FF95CB3DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L02:
       mov       rcx,offset MT_System.Action`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       call      qword ptr [7FF95CA84210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,rbp
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95CB3E3B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rdi+18],0
       je        near ptr M00_L08
M00_L03:
       mov       [rsp+38],rdi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF95D51FF78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L04:
       call      CORINFO_HELP_OVERFLOW
M00_L05:
       call      qword ptr [7FF95D004C60]
       mov       ecx,49
       mov       rdx,7FF95CF89088
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,1464
       mov       rdx,7FF95CE15108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF89088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D004A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       ecx,10
       call      qword ptr [7FF95CD14F30]
       int       3
M00_L07:
       mov       rcx,rax
       mov       r11,7FF95C940F38
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L02
M00_L08:
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
       mov       eax,[rax+8]
       mov       rdx,[rdi+10]
       mov       rcx,[rdx+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rdi+18],eax
       jmp       near ptr M00_L03
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 812
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,r9
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       je        short M01_L01
M01_L00:
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       test      r8,r8
       je        short M01_L02
       mov       rax,r8
       mov       rdx,rax
       jmp       short M01_L00
M01_L02:
       call      qword ptr [7FF95D004C60]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,2ACA29E0210
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M01_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M01_L04
M01_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D004A50]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF95CD16670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 159
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       push      rbx
       test      rdx,rdx
       je        short M02_L02
       mov       rbx,[rdx]
       movzx     r8d,word ptr [rbx+0E]
       test      r8,r8
       je        short M02_L01
       mov       r10,[rbx+38]
       cmp       r8,4
       jl        short M02_L04
M02_L00:
       cmp       [r10],rcx
       je        short M02_L02
       cmp       [r10+8],rcx
       je        short M02_L02
       cmp       [r10+10],rcx
       je        short M02_L02
       cmp       [r10+18],rcx
       je        short M02_L02
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M02_L00
       test      r8,r8
       jne       short M02_L04
M02_L01:
       test      dword ptr [rbx],406C0000
       jne       short M02_L03
       xor       edx,edx
M02_L02:
       mov       rax,rdx
       pop       rbx
       ret
M02_L03:
       pop       rbx
       jmp       qword ptr [7FF95CA84378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M02_L04:
       cmp       [r10],rcx
       je        short M02_L02
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M02_L04
       jmp       short M02_L01
; Total bytes of code 112
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
       je        near ptr M03_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rdx
       mov       rdx,7FF95D6BD200
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M03_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF95CA84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M03_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FF95D6BD240
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M03_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FF95D20F8B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L05:
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
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FF95D6BD258
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L07:
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
M03_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L09
       jmp       short M03_L10
M03_L09:
       mov       rcx,rsi
       mov       rdx,7FF95D20F8A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M03_L11
       jmp       short M03_L12
M03_L11:
       mov       rcx,rsi
       mov       rdx,7FF95D6BD210
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M03_L17
M03_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M03_L14
       jmp       short M03_L15
M03_L14:
       mov       rcx,rsi
       mov       rdx,7FF95D6BD228
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M03_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M03_L17
M03_L16:
       mov       rdx,r8
       call      qword ptr [7FF95CB3E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M03_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF95C940F28
       call      qword ptr [r11]
       test      eax,eax
       jne       short M03_L13
       mov       rcx,rsp
       call      M03_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L18:
       mov       ecx,17
       call      qword ptr [7FF95CCEED00]
       int       3
M03_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L20
       jmp       short M03_L21
M03_L20:
       mov       rcx,rsi
       mov       rdx,7FF95D20F8A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L21:
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
M03_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M03_L23
       mov       rcx,[rbp-28]
       mov       r11,7FF95C940F30
       call      qword ptr [r11]
M03_L23:
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
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+40]
       test      r11,r11
       je        short M04_L00
       jmp       short M04_L01
M04_L00:
       mov       rdx,7FF95D521FB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M04_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r8d,eax
       mov       rdx,rsi
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF95D51E970]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 92
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M05_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       call      qword ptr [7FF95CA841F8]
       int       3
; Total bytes of code 44
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M06_L04
       mov       edi,[rbx+14]
       xor       ebp,ebp
       cmp       dword ptr [rbx+10],0
       jle       short M06_L03
       mov       r14,[rsi+18]
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       cmp       r14,rcx
       jne       short M06_L01
M06_L00:
       cmp       edi,[rbx+14]
       jne       short M06_L03
       mov       r14,[rbx+8]
       cmp       ebp,[r14+8]
       jae       short M06_L07
       mov       ecx,ebp
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [7FF95D51EB20]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M06_L00
       jmp       short M06_L03
M06_L01:
       cmp       edi,[rbx+14]
       jne       short M06_L03
       mov       rcx,[rbx+8]
       cmp       ebp,[rcx+8]
       jae       short M06_L07
       mov       edx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       cmp       r14,rcx
       jne       short M06_L05
       mov       rcx,[rsi+8]
       call      qword ptr [7FF95D51EB20]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
M06_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M06_L01
M06_L03:
       cmp       edi,[rbx+14]
       jne       short M06_L06
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L04:
       mov       ecx,1C
       call      qword ptr [7FF95CCEED00]
       int       3
M06_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M06_L02
M06_L06:
       call      qword ptr [7FF95CCEEFE8]
       int       3
M06_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 199
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
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
       je        near ptr M08_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M08_L02
       test      rbx,rbx
       je        short M08_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M08_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M08_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF95CB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L01:
       call      qword ptr [7FF95CCEEF40]
       int       3
M08_L02:
       test      rbx,rbx
       je        short M08_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M08_L04
M08_L03:
       mov       rax,2ACA29E0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToConcurrentHashSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,0C
       mov       ebp,1F
       cmp       ebp,edx
       cmovl     ebp,edx
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       mov       r15d,[r14+8]
       mov       r13d,r15d
       mov       r12,r13
       xor       eax,eax
       mov       [rsp+44],eax
       test      r12,r12
       jle       short M00_L01
       mov       rdx,offset MT_System.Object
       mov       [rsp+30],rdx
M00_L00:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+44]
       cmp       r8d,r15d
       jae       near ptr M00_L09
       mov       [rsp+44],r8d
       mov       ecx,r8d
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8d,[rsp+44]
       add       r8d,1
       jo        near ptr M00_L04
       movsxd    rdx,r8d
       cmp       rdx,r12
       mov       [rsp+44],r8d
       mov       rdx,[rsp+30]
       jl        short M00_L00
M00_L01:
       mov       rdx,r13
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       movsxd    rdx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Tables[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r13
       lea       rcx,[r12+10]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+1C],1
       mov       eax,[rbp+8]
       xor       edx,edx
       div       r15d
       mov       [rdi+18],eax
       mov       rcx,25819001FD8
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,298A6DFEC98
       mov       [rsp+20],rdx
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,298A6DF0008
       call      qword ptr [7FF95D27C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FF95CA94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L07
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FF95CB4DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L02:
       mov       rcx,offset MT_System.Action`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       call      qword ptr [7FF95CA94210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,rbp
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95CB4E3B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rdi+18],0
       je        near ptr M00_L08
M00_L03:
       mov       [rsp+38],rdi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF95D52FF78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L04:
       call      CORINFO_HELP_OVERFLOW
M00_L05:
       call      qword ptr [7FF95D014C60]
       mov       ecx,49
       mov       rdx,7FF95CF99088
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,1464
       mov       rdx,7FF95CE25108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF99088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       ecx,10
       call      qword ptr [7FF95CD24F30]
       int       3
M00_L07:
       mov       rcx,rax
       mov       r11,7FF95C950F28
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L02
M00_L08:
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
       mov       eax,[rax+8]
       mov       rdx,[rdi+10]
       mov       rcx,[rdx+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rdi+18],eax
       jmp       near ptr M00_L03
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 812
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,r9
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       je        short M01_L01
M01_L00:
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       test      r8,r8
       je        short M01_L02
       mov       rax,r8
       mov       rdx,rax
       jmp       short M01_L00
M01_L02:
       call      qword ptr [7FF95D014C60]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,298A6DF0210
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M01_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M01_L04
M01_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF95CD26670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 159
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       push      rbx
       test      rdx,rdx
       je        short M02_L02
       mov       rbx,[rdx]
       movzx     r8d,word ptr [rbx+0E]
       test      r8,r8
       je        short M02_L01
       mov       r10,[rbx+38]
       cmp       r8,4
       jl        short M02_L04
M02_L00:
       cmp       [r10],rcx
       je        short M02_L02
       cmp       [r10+8],rcx
       je        short M02_L02
       cmp       [r10+10],rcx
       je        short M02_L02
       cmp       [r10+18],rcx
       je        short M02_L02
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M02_L00
       test      r8,r8
       jne       short M02_L04
M02_L01:
       test      dword ptr [rbx],406C0000
       jne       short M02_L03
       xor       edx,edx
M02_L02:
       mov       rax,rdx
       pop       rbx
       ret
M02_L03:
       pop       rbx
       jmp       qword ptr [7FF95CA94378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M02_L04:
       cmp       [r10],rcx
       je        short M02_L02
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M02_L04
       jmp       short M02_L01
; Total bytes of code 112
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
       je        near ptr M03_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+70]
       test      rax,rax
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rdx
       mov       rdx,7FF95D6CD340
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M03_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF95CA94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M03_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FF95D6CD380
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M03_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FF95D21F838
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L05:
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
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FF95D6CD398
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L07:
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
M03_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L09
       jmp       short M03_L10
M03_L09:
       mov       rcx,rsi
       mov       rdx,7FF95D21F828
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M03_L11
       jmp       short M03_L12
M03_L11:
       mov       rcx,rsi
       mov       rdx,7FF95D6CD350
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M03_L17
M03_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M03_L14
       jmp       short M03_L15
M03_L14:
       mov       rcx,rsi
       mov       rdx,7FF95D6CD368
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M03_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M03_L17
M03_L16:
       mov       rdx,r8
       call      qword ptr [7FF95CB4E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M03_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF95C950F30
       call      qword ptr [r11]
       test      eax,eax
       jne       short M03_L13
       mov       rcx,rsp
       call      M03_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L18:
       mov       ecx,17
       call      qword ptr [7FF95CCFED00]
       int       3
M03_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L20
       jmp       short M03_L21
M03_L20:
       mov       rcx,rsi
       mov       rdx,7FF95D21F828
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L21:
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
M03_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M03_L23
       mov       rcx,[rbp-28]
       mov       r11,7FF95C950F38
       call      qword ptr [r11]
M03_L23:
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
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+40]
       test      r11,r11
       je        short M04_L00
       jmp       short M04_L01
M04_L00:
       mov       rdx,7FF95D531FB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M04_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r8d,eax
       mov       rdx,rsi
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF95D52E970]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 92
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M05_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       call      qword ptr [7FF95CA941F8]
       int       3
; Total bytes of code 44
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M06_L04
       mov       edi,[rbx+14]
       xor       ebp,ebp
       cmp       dword ptr [rbx+10],0
       jle       short M06_L03
       mov       r14,[rsi+18]
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       cmp       r14,rcx
       jne       short M06_L01
M06_L00:
       cmp       edi,[rbx+14]
       jne       short M06_L03
       mov       r14,[rbx+8]
       cmp       ebp,[r14+8]
       jae       short M06_L07
       mov       ecx,ebp
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [7FF95D52EB20]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M06_L00
       jmp       short M06_L03
M06_L01:
       cmp       edi,[rbx+14]
       jne       short M06_L03
       mov       rcx,[rbx+8]
       cmp       ebp,[rcx+8]
       jae       short M06_L07
       mov       edx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       cmp       r14,rcx
       jne       short M06_L05
       mov       rcx,[rsi+8]
       call      qword ptr [7FF95D52EB20]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
M06_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M06_L01
M06_L03:
       cmp       edi,[rbx+14]
       jne       short M06_L06
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L04:
       mov       ecx,1C
       call      qword ptr [7FF95CCFED00]
       int       3
M06_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M06_L02
M06_L06:
       call      qword ptr [7FF95CCFEFE8]
       int       3
M06_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 199
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
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
       je        near ptr M08_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M08_L02
       test      rbx,rbx
       je        short M08_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M08_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M08_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF95CB45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L01:
       call      qword ptr [7FF95CCFEF40]
       int       3
M08_L02:
       test      rbx,rbx
       je        short M08_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M08_L04
M08_L03:
       mov       rax,298A6DF0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToConcurrentHashSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,0C
       mov       ebp,1F
       cmp       ebp,edx
       cmovl     ebp,edx
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       mov       r15d,[r14+8]
       mov       r13d,r15d
       mov       r12,r13
       xor       eax,eax
       mov       [rsp+44],eax
       test      r12,r12
       jle       short M00_L01
       mov       rdx,offset MT_System.Object
       mov       [rsp+30],rdx
M00_L00:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+44]
       cmp       r8d,r15d
       jae       near ptr M00_L09
       mov       [rsp+44],r8d
       mov       ecx,r8d
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8d,[rsp+44]
       add       r8d,1
       jo        near ptr M00_L04
       movsxd    rdx,r8d
       cmp       rdx,r12
       mov       [rsp+44],r8d
       mov       rdx,[rsp+30]
       jl        short M00_L00
M00_L01:
       mov       rdx,r13
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       movsxd    rdx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Tables[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r13
       lea       rcx,[r12+10]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+1C],1
       mov       eax,[rbp+8]
       xor       edx,edx
       div       r15d
       mov       [rdi+18],eax
       mov       rcx,165D2402000
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1A66030EC98
       mov       [rsp+20],rdx
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1A660300008
       call      qword ptr [7FF95D26C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FF95CA84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L07
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FF95CB3DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L02:
       mov       rcx,offset MT_System.Action`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,7FF95D613780
       call      qword ptr [7FF95CA84210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,rbp
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95CB3E3B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rdi+18],0
       je        near ptr M00_L08
M00_L03:
       mov       [rsp+38],rdi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF95D61CE40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L04:
       call      CORINFO_HELP_OVERFLOW
M00_L05:
       call      qword ptr [7FF95D004C60]
       mov       ecx,49
       mov       rdx,7FF95CF89088
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,1464
       mov       rdx,7FF95CE15108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF89088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D004A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       ecx,10
       call      qword ptr [7FF95CD14F30]
       int       3
M00_L07:
       mov       rcx,rax
       mov       r11,7FF95C9417B0
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L02
M00_L08:
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
       mov       eax,[rax+8]
       mov       rdx,[rdi+10]
       mov       rcx,[rdx+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rdi+18],eax
       jmp       near ptr M00_L03
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 812
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,r9
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       je        short M01_L01
M01_L00:
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       test      r8,r8
       je        short M01_L02
       mov       rax,r8
       mov       rdx,rax
       jmp       short M01_L00
M01_L02:
       call      qword ptr [7FF95D004C60]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,1A660300210
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M01_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M01_L04
M01_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D004A50]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF95CD16670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 159
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L01
       mov       r8,[rdx]
       movzx     r10d,word ptr [r8+0E]
       test      r10,r10
       je        short M02_L04
       mov       r9,[r8+38]
       cmp       r10,4
       jl        short M02_L03
M02_L00:
       cmp       [r9],rcx
       je        short M02_L01
       cmp       [r9+8],rcx
       je        short M02_L01
       cmp       [r9+10],rcx
       jne       short M02_L02
M02_L01:
       mov       rax,rdx
       ret
M02_L02:
       cmp       [r9+18],rcx
       je        short M02_L01
       add       r9,20
       add       r10,0FFFFFFFFFFFFFFFC
       cmp       r10,4
       jge       short M02_L00
       test      r10,r10
       je        short M02_L04
M02_L03:
       cmp       [r9],rcx
       je        short M02_L01
       add       r9,8
       dec       r10
       test      r10,r10
       jg        short M02_L03
M02_L04:
       test      dword ptr [r8],406C0000
       jne       short M02_L05
       xor       edx,edx
       jmp       short M02_L01
M02_L05:
       jmp       qword ptr [7FF95CA84378]
; Total bytes of code 110
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
       je        near ptr M03_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+78]
       test      rax,rax
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rdx
       mov       rdx,7FF95D755DB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M03_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF95CA84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M03_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FF95D755DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M03_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FF95D20C970
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+98]
       test      r11,r11
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FF95D755E10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L07:
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
M03_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L09
       jmp       short M03_L10
M03_L09:
       mov       rcx,rsi
       mov       rdx,7FF95D20C978
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M03_L11
       jmp       short M03_L12
M03_L11:
       mov       rcx,rsi
       mov       rdx,7FF95D755DC8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M03_L17
M03_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M03_L14
       jmp       short M03_L15
M03_L14:
       mov       rcx,rsi
       mov       rdx,7FF95D755DE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M03_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M03_L17
M03_L16:
       mov       rdx,r8
       call      qword ptr [7FF95CB3E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M03_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF95C9417A0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M03_L13
       mov       rcx,rsp
       call      M03_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L18:
       mov       ecx,17
       call      qword ptr [7FF95CCEED00]
       int       3
M03_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L20
       jmp       short M03_L21
M03_L20:
       mov       rcx,rsi
       mov       rdx,7FF95D20C978
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L21:
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
M03_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M03_L23
       mov       rcx,[rbp-28]
       mov       r11,7FF95C9417A8
       call      qword ptr [r11]
M03_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 690
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FF95CA841F8]
       int       3
; Total bytes of code 44
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M05_L04
       mov       edi,[rbx+14]
       xor       ebp,ebp
       cmp       dword ptr [rbx+10],0
       jle       short M05_L03
       mov       r14,[rsi+18]
       mov       rcx,7FF95D613780
       cmp       r14,rcx
       jne       short M05_L01
M05_L00:
       cmp       edi,[rbx+14]
       jne       short M05_L03
       mov       r14,[rbx+8]
       cmp       ebp,[r14+8]
       jae       short M05_L07
       mov       ecx,ebp
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [7FF95D617780]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M05_L00
       jmp       short M05_L03
M05_L01:
       cmp       edi,[rbx+14]
       jne       short M05_L03
       mov       rcx,[rbx+8]
       cmp       ebp,[rcx+8]
       jae       short M05_L07
       mov       edx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,7FF95D613780
       cmp       r14,rcx
       jne       short M05_L05
       mov       rcx,[rsi+8]
       call      qword ptr [7FF95D617780]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
M05_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M05_L01
M05_L03:
       cmp       edi,[rbx+14]
       jne       short M05_L06
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L04:
       mov       ecx,1C
       call      qword ptr [7FF95CCEED00]
       int       3
M05_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M05_L02
M05_L06:
       call      qword ptr [7FF95CCEEFE8]
       int       3
M05_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 199
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
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
       je        near ptr M07_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M07_L02
       test      rbx,rbx
       je        short M07_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M07_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M07_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF95CB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L01:
       call      qword ptr [7FF95CCEEF40]
       int       3
M07_L02:
       test      rbx,rbx
       je        short M07_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M07_L04
M07_L03:
       mov       rax,1A660300008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToConcurrentHashSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,0C
       mov       ebp,1F
       cmp       ebp,edx
       cmovl     ebp,edx
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       mov       r15d,[r14+8]
       mov       r13d,r15d
       mov       r12,r13
       xor       eax,eax
       mov       [rsp+44],eax
       test      r12,r12
       jle       short M00_L01
       mov       rdx,offset MT_System.Object
       mov       [rsp+30],rdx
M00_L00:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+44]
       cmp       r8d,r15d
       jae       near ptr M00_L09
       mov       [rsp+44],r8d
       mov       ecx,r8d
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8d,[rsp+44]
       add       r8d,1
       jo        near ptr M00_L04
       movsxd    rdx,r8d
       cmp       rdx,r12
       mov       [rsp+44],r8d
       mov       rdx,[rsp+30]
       jl        short M00_L00
M00_L01:
       mov       rdx,r13
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       movsxd    rdx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Tables[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r13
       lea       rcx,[r12+10]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+1C],1
       mov       eax,[rbp+8]
       xor       edx,edx
       div       r15d
       mov       [rdi+18],eax
       mov       rcx,18731412488
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1C7C334EC98
       mov       [rsp+20],rdx
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1C7C3340008
       call      qword ptr [7FF95D29C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FF95CAB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L07
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FF95CB6DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L02:
       mov       rcx,offset MT_System.Action`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       call      qword ptr [7FF95CAB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,rbp
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95CB6E3B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rdi+18],0
       je        near ptr M00_L08
M00_L03:
       mov       [rsp+38],rdi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF95D70FF78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L04:
       call      CORINFO_HELP_OVERFLOW
M00_L05:
       call      qword ptr [7FF95D034C60]
       mov       ecx,49
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD46670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       ecx,10
       call      qword ptr [7FF95CD44F30]
       int       3
M00_L07:
       mov       rcx,rax
       mov       r11,7FF95C971948
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M00_L02
M00_L08:
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
       mov       eax,[rax+8]
       mov       rdx,[rdi+10]
       mov       rcx,[rdx+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rdi+18],eax
       jmp       near ptr M00_L03
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 812
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,r9
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       je        short M01_L01
M01_L00:
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       test      r8,r8
       je        short M01_L02
       mov       rax,r8
       mov       rdx,rax
       jmp       short M01_L00
M01_L02:
       call      qword ptr [7FF95D034C60]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,1C7C3340210
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M01_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M01_L04
M01_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF95CD46670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 159
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L01
       mov       r8,[rdx]
       movzx     r10d,word ptr [r8+0E]
       test      r10,r10
       je        short M02_L04
       mov       r9,[r8+38]
       cmp       r10,4
       jl        short M02_L03
M02_L00:
       cmp       [r9],rcx
       je        short M02_L01
       cmp       [r9+8],rcx
       je        short M02_L01
       cmp       [r9+10],rcx
       jne       short M02_L02
M02_L01:
       mov       rax,rdx
       ret
M02_L02:
       cmp       [r9+18],rcx
       je        short M02_L01
       add       r9,20
       add       r10,0FFFFFFFFFFFFFFFC
       cmp       r10,4
       jge       short M02_L00
       test      r10,r10
       je        short M02_L04
M02_L03:
       cmp       [r9],rcx
       je        short M02_L01
       add       r9,8
       dec       r10
       test      r10,r10
       jg        short M02_L03
M02_L04:
       test      dword ptr [r8],406C0000
       jne       short M02_L05
       xor       edx,edx
       jmp       short M02_L01
M02_L05:
       jmp       qword ptr [7FF95CAB4378]
; Total bytes of code 110
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
       je        near ptr M03_L18
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+78]
       test      rax,rax
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rdx
       mov       rdx,7FF95D786710
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M03_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF95CAB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M03_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FF95D786750
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M03_L19
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FF95D23F860
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L05:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+98]
       test      r11,r11
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FF95D786768
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L07:
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
M03_L08:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L09
       jmp       short M03_L10
M03_L09:
       mov       rcx,rsi
       mov       rdx,7FF95D23F850
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L10:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M03_L11
       jmp       short M03_L12
M03_L11:
       mov       rcx,rsi
       mov       rdx,7FF95D786720
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-28],rax
       jmp       short M03_L17
M03_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M03_L14
       jmp       short M03_L15
M03_L14:
       mov       rcx,rsi
       mov       rdx,7FF95D786738
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M03_L16
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       movsxd    rdx,edx
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M03_L17
M03_L16:
       mov       rdx,r8
       call      qword ptr [7FF95CB6E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M03_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FF95C971950
       call      qword ptr [r11]
       test      eax,eax
       jne       short M03_L13
       mov       rcx,rsp
       call      M03_L22
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L18:
       mov       ecx,17
       call      qword ptr [7FF95CD1ED00]
       int       3
M03_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L20
       jmp       short M03_L21
M03_L20:
       mov       rcx,rsi
       mov       rdx,7FF95D23F850
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L21:
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
M03_L22:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-28],0
       je        short M03_L23
       mov       rcx,[rbp-28]
       mov       r11,7FF95C971958
       call      qword ptr [r11]
M03_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 690
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+40]
       test      r11,r11
       je        short M04_L00
       jmp       short M04_L01
M04_L00:
       mov       rdx,7FF95D6ED620
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M04_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r8d,eax
       mov       rdx,rsi
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF95D70E970]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 92
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M05_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       call      qword ptr [7FF95CAB41F8]
       int       3
; Total bytes of code 44
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M06_L04
       mov       edi,[rbx+14]
       xor       ebp,ebp
       cmp       dword ptr [rbx+10],0
       jle       short M06_L03
       mov       r14,[rsi+18]
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       cmp       r14,rcx
       jne       short M06_L01
M06_L00:
       cmp       edi,[rbx+14]
       jne       short M06_L03
       mov       r14,[rbx+8]
       cmp       ebp,[r14+8]
       jae       short M06_L07
       mov       ecx,ebp
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [7FF95D70EB20]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M06_L00
       jmp       short M06_L03
M06_L01:
       cmp       edi,[rbx+14]
       jne       short M06_L03
       mov       rcx,[rbx+8]
       cmp       ebp,[rcx+8]
       jae       short M06_L07
       mov       edx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       cmp       r14,rcx
       jne       short M06_L05
       mov       rcx,[rsi+8]
       call      qword ptr [7FF95D70EB20]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
M06_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M06_L01
M06_L03:
       cmp       edi,[rbx+14]
       jne       short M06_L06
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L04:
       mov       ecx,1C
       call      qword ptr [7FF95CD1ED00]
       int       3
M06_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M06_L02
M06_L06:
       call      qword ptr [7FF95CD1EFE8]
       int       3
M06_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 199
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
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
       je        near ptr M08_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M08_L02
       test      rbx,rbx
       je        short M08_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M08_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M08_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF95CB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L01:
       call      qword ptr [7FF95CD1EF40]
       int       3
M08_L02:
       test      rbx,rbx
       je        short M08_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M08_L04
M08_L03:
       mov       rax,1C7C3340008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       rbx,rcx
       mov       r8,[rbx+280]
       test      r8,r8
       je        near ptr M00_L03
       mov       r9,22B7AC124C8
       mov       rsi,[r9]
       mov       r9d,[rsi+20]
       test      r9d,r9d
       jne       short M00_L00
       mov       rcx,r8
       mov       rdi,offset MT_System.Collections.Immutable.ImmutableHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        near ptr M00_L04
M00_L00:
       mov       rcx,[rsi+10]
       mov       rdx,[rsi+8]
       mov       rax,[rsi+18]
       mov       [rsp+28],rcx
       mov       [rsp+30],rdx
       mov       [rsp+38],rax
       mov       [rsp+40],r9d
       lea       r9,[rsp+28]
       lea       rcx,[rsp+50]
       mov       rdi,offset MT_System.Collections.Immutable.ImmutableHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rdx,rdi
       call      qword ptr [7FF95D5846A8]; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
       mov       ebp,[rsp+58]
       cmp       dword ptr [rsp+5C],0
       jne       short M00_L01
       add       ebp,[rsi+20]
M00_L01:
       mov       r14,[rsp+50]
       cmp       r14,[rsi+10]
       je        near ptr M00_L05
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rsi,[rsi+8]
       test      r14,r14
       je        near ptr M00_L06
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rdx,22B7AC124D0
       mov       rdx,[rdx]
       mov       rcx,r14
       call      qword ptr [7FF95D586868]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+20],ebp
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,22B7AC01FF8
       mov       rdx,[rcx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,rdi
M00_L02:
       mov       [rsp+48],rsi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+48]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Immutable.ImmutableHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF95D58FDE0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       call      qword ptr [7FF95D034C60]
       mov       ecx,49
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD46670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rdx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF95D5844E0]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L05:
       jmp       near ptr M00_L02
M00_L06:
       mov       ecx,4AB
       mov       rdx,7FF95D54AE60
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D586F28]
       int       3
M00_L07:
       mov       ecx,4B5
       mov       rdx,7FF95D54AE60
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D586F28]
       int       3
; Total bytes of code 574
```
```assembly
; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,1B8
       vzeroupper
       lea       rbp,[rsp+1F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1B0],xmm4
       vmovdqa   xmmword ptr [rbp-1A0],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-1C0],rsp
       mov       [rbp-40],rdx
       mov       [rbp+18],rdx
       mov       r15,rcx
       mov       r14,rdx
       mov       rsi,r8
       mov       rbx,r9
       test      rsi,rsi
       je        near ptr M01_L24
       xor       r13d,r13d
       mov       r12,[rbx]
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdx,[rcx+70]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,r14
       mov       rdx,7FF95D577A80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       lea       rcx,[rbp-150]
       mov       r8,rsi
       call      qword ptr [7FF95D58CF30]; System.Collections.Immutable.ImmutableExtensions.GetEnumerableDisposable[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rdi,[rbp-0C8]
       lea       rsi,[rbp-150]
       mov       ecx,11
       rep movsq
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rsi,[rcx+78]
       test      rsi,rsi
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,7FF95D577B40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L04:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF95D58CED0]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       je        near ptr M01_L19
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdi,[rcx+88]
       test      rdi,rdi
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,r14
       mov       rdx,7FF95D577B78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M01_L06:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF95D58CEB8]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].get_Current()
       mov       [rbp-1B8],rax
       test      rax,rax
       je        near ptr M01_L15
       mov       rax,[rbp-1B8]
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,r14
       mov       rdx,7FF95D577B60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rax,[rbp-1B8]
M01_L08:
       mov       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [r11]
M01_L09:
       mov       edx,eax
       mov       [rbp-154],edx
       cmp       [r12],r12b
       mov       rax,r12
M01_L10:
       mov       r8,[rax+8]
       test      r8,r8
       je        near ptr M01_L16
       mov       ecx,[rax+18]
       cmp       edx,ecx
       je        near ptr M01_L17
       jg        short M01_L11
       mov       rax,r8
       mov       edx,[rbp-154]
       jmp       short M01_L10
M01_L11:
       mov       rax,[rax+10]
       mov       edx,[rbp-154]
       jmp       short M01_L10
M01_L12:
       mov       [rbp-168],r10
       mov       [rbp-160],r11
       mov       r8,rdi
       mov       rcx,[rbx+8]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-170]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-168]
       lea       rdx,[rbp-180]
       mov       r9,[rbp-1B8]
       call      qword ptr [7FF95D584A80]; System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, OperationResult<System.__Canon> ByRef)
       cmp       dword ptr [rbp-170],0
       jne       short M01_L14
       mov       r9,[rbx+10]
       mov       rcx,[rbp-180]
       mov       rdx,[rbp-178]
       test      rdx,rdx
       je        near ptr M01_L18
       mov       r8d,[rbp-154]
       mov       [rbp-1B0],rcx
       mov       [rbp-1A8],rdx
       lea       rcx,[rbp-198]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-1A0]
       mov       [rsp+28],rcx
       mov       rcx,r12
       mov       edx,r8d
       lea       r8,[rbp-1B0]
       call      qword ptr [7FF95D586808]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetItem(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean ByRef, Boolean ByRef)
       mov       r12,rax
M01_L13:
       inc       r13d
M01_L14:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF95D58CED0]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L06
       jmp       short M01_L19
M01_L15:
       mov       rax,[rbp-1B8]
       xor       r8d,r8d
       mov       eax,r8d
       jmp       near ptr M01_L09
M01_L16:
       xor       r10d,r10d
       xor       r11d,r11d
       jmp       near ptr M01_L12
M01_L17:
       mov       r10,[rax+20]
       mov       r11,[rax+28]
       jmp       near ptr M01_L12
M01_L18:
       lea       r8,[rbp-198]
       mov       rcx,r12
       mov       edx,[rbp-154]
       call      qword ptr [7FF95D586958]
       mov       r12,rax
       jmp       short M01_L13
M01_L19:
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+90]
       test      rax,rax
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,r14
       mov       rdx,7FF95D577BA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L21:
       lea       rcx,[rbp-0C8]
       call      rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-190],xmm0
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdx,[rcx+60]
       test      rdx,rdx
       je        short M01_L22
       jmp       short M01_L23
M01_L22:
       mov       rcx,r14
       mov       rdx,7FF95D576488
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L23:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-190]
       mov       r8,r12
       mov       r9d,r13d
       call      qword ptr [7FF95D5878E8]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       mov       rdx,[rbp-190]
       mov       rcx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,[rbp-188]
       mov       [r15+8],eax
       mov       eax,[rbp-184]
       mov       [r15+0C],eax
       mov       rax,r15
       add       rsp,1B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L24:
       mov       ecx,4D7
       mov       rdx,7FF95D54AE60
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D586F28]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+1F0]
       mov       rcx,[rbp+18]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+90]
       test      rax,rax
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rdx,7FF95D577BA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L26:
       lea       rcx,[rbp-0C8]
       call      rax
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1050
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
M02_L00:
       push      rsi
       push      rbx
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       short M02_L02
       test      rsi,rsi
       je        short M02_L01
       mov       ecx,[rbx+18]
       mov       rdx,[rbx+20]
       mov       rax,[rbx+28]
       mov       [rsp+20],ecx
       mov       [rsp+28],rdx
       mov       [rsp+30],rax
       mov       rcx,offset System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
       cmp       [rsi+18],rcx
       jne       short M02_L03
       mov       rcx,[rsi+8]
       lea       rdx,[rsp+20]
       call      qword ptr [7FF95D586DC0]; System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
M02_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95D586868]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95D586868]
       mov       byte ptr [rbx+1C],1
M02_L02:
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L03:
       lea       rdx,[rsp+20]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M02_L01
; Total bytes of code 151
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
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
       je        near ptr M04_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M04_L02
       test      rbx,rbx
       je        short M04_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M04_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF95CB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L01:
       call      qword ptr [7FF95CD1EF40]
       int       3
M04_L02:
       test      rbx,rbx
       je        short M04_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M04_L04
M04_L03:
       mov       rax,26C0CA90008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       rbx,rcx
       mov       r8,[rbx+280]
       test      r8,r8
       je        near ptr M00_L03
       mov       r9,23CAC8124C8
       mov       rsi,[r9]
       mov       r9d,[rsi+20]
       test      r9d,r9d
       jne       short M00_L00
       mov       rcx,r8
       mov       rdi,offset MT_System.Collections.Immutable.ImmutableHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        near ptr M00_L04
M00_L00:
       mov       rcx,[rsi+10]
       mov       rdx,[rsi+8]
       mov       rax,[rsi+18]
       mov       [rsp+28],rcx
       mov       [rsp+30],rdx
       mov       [rsp+38],rax
       mov       [rsp+40],r9d
       lea       r9,[rsp+28]
       lea       rcx,[rsp+50]
       mov       rdi,offset MT_System.Collections.Immutable.ImmutableHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rdx,rdi
       call      qword ptr [7FF95D575398]; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
       mov       ebp,[rsp+58]
       cmp       dword ptr [rsp+5C],0
       jne       short M00_L01
       add       ebp,[rsi+20]
M00_L01:
       mov       r14,[rsp+50]
       cmp       r14,[rsi+10]
       je        near ptr M00_L05
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rsi,[rsi+8]
       test      r14,r14
       je        near ptr M00_L06
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rdx,23CAC8124D0
       mov       rdx,[rdx]
       mov       rcx,r14
       call      qword ptr [7FF95D577558]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+20],ebp
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,23CAC801FF8
       mov       rdx,[rcx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,rdi
M00_L02:
       mov       [rsp+48],rsi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+48]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Immutable.ImmutableHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF95D5947F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       call      qword ptr [7FF95CFCF4F8]
       mov       ecx,49
       mov       rdx,7FF95CFA8B80
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1464
       mov       rdx,7FF95CE350F0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CFA8B80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95CFCF2E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD36670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rdx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF95D5751D0]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L05:
       jmp       near ptr M00_L02
M00_L06:
       mov       ecx,4AB
       mov       rdx,7FF95D550000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D577C18]
       int       3
M00_L07:
       mov       ecx,4B5
       mov       rdx,7FF95D550000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D577C18]
       int       3
; Total bytes of code 574
```
```assembly
; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,1B8
       vzeroupper
       lea       rbp,[rsp+1F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1B0],xmm4
       vmovdqa   xmmword ptr [rbp-1A0],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-1C0],rsp
       mov       [rbp-40],rdx
       mov       [rbp+18],rdx
       mov       r15,rcx
       mov       r14,rdx
       mov       rsi,r8
       mov       rbx,r9
       test      rsi,rsi
       je        near ptr M01_L25
       xor       r13d,r13d
       mov       r12,[rbx]
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdx,[rcx+70]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,r14
       mov       rdx,7FF95D567DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       lea       rcx,[rbp-150]
       mov       r8,rsi
       call      qword ptr [7FF95D57D830]; System.Collections.Immutable.ImmutableExtensions.GetEnumerableDisposable[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rdi,[rbp-0C8]
       lea       rsi,[rbp-150]
       mov       ecx,11
       rep movsq
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rsi,[rcx+78]
       test      rsi,rsi
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,7FF95D567E80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L04:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF95D57D7D0]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       je        near ptr M01_L20
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdi,[rcx+88]
       test      rdi,rdi
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,r14
       mov       rdx,7FF95D567EB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M01_L06:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF95D57D7B8]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].get_Current()
       mov       [rbp-1B8],rax
       test      rax,rax
       je        near ptr M01_L19
       mov       rax,[rbp-1B8]
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,r14
       mov       rdx,7FF95D567EA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rax,[rbp-1B8]
M01_L08:
       mov       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [r11]
M01_L09:
       mov       edx,eax
       mov       [rbp-154],edx
       cmp       [r12],r12b
       mov       rax,r12
M01_L10:
       mov       r8,[rax+8]
       test      r8,r8
       je        near ptr M01_L17
       mov       ecx,[rax+18]
       cmp       edx,ecx
       je        near ptr M01_L16
       jle       short M01_L11
       mov       rax,[rax+10]
       mov       edx,[rbp-154]
       jmp       short M01_L10
M01_L11:
       mov       rax,r8
       mov       edx,[rbp-154]
       jmp       short M01_L10
M01_L12:
       mov       rcx,r12
       mov       r12d,[rbp-154]
       mov       edx,r12d
       mov       [rbp-1B0],rax
       mov       [rbp-1A8],r8
       lea       r8,[rbp-198]
       mov       [rsp+20],r8
       lea       r8,[rbp-1A0]
       mov       [rsp+28],r8
       lea       r8,[rbp-1B0]
       call      qword ptr [7FF95D5774F8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetItem(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean ByRef, Boolean ByRef)
       mov       r12,rax
M01_L13:
       inc       r13d
M01_L14:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF95D57D7D0]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L06
       jmp       near ptr M01_L20
M01_L15:
       lea       r8,[rbp-198]
       mov       rcx,r12
       mov       edx,[rbp-154]
       call      qword ptr [7FF95D577648]
       mov       r12,rax
       jmp       short M01_L13
M01_L16:
       mov       r10,[rax+20]
       mov       r11,[rax+28]
       jmp       short M01_L18
M01_L17:
       xor       r10d,r10d
       xor       r11d,r11d
M01_L18:
       mov       [rbp-168],r10
       mov       [rbp-160],r11
       mov       r8,rdi
       mov       rcx,[rbx+8]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-170]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-168]
       lea       rdx,[rbp-180]
       mov       r9,[rbp-1B8]
       call      qword ptr [7FF95D575770]; System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, OperationResult<System.__Canon> ByRef)
       cmp       dword ptr [rbp-170],0
       jne       near ptr M01_L14
       mov       r9,[rbx+10]
       mov       rax,[rbp-180]
       mov       r8,[rbp-178]
       test      r8,r8
       je        near ptr M01_L15
       jmp       near ptr M01_L12
M01_L19:
       mov       rax,[rbp-1B8]
       xor       r8d,r8d
       mov       eax,r8d
       jmp       near ptr M01_L09
M01_L20:
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+90]
       test      rax,rax
       je        short M01_L21
       jmp       short M01_L22
M01_L21:
       mov       rcx,r14
       mov       rdx,7FF95D567EE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L22:
       lea       rcx,[rbp-0C8]
       call      rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-190],xmm0
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdx,[rcx+60]
       test      rdx,rdx
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rcx,r14
       mov       rdx,7FF95D5667C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L24:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-190]
       mov       r8,r12
       mov       r9d,r13d
       call      qword ptr [7FF95D57C648]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       mov       rdx,[rbp-190]
       mov       rcx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,[rbp-188]
       mov       [r15+8],eax
       mov       eax,[rbp-184]
       mov       [r15+0C],eax
       mov       rax,r15
       add       rsp,1B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L25:
       mov       ecx,4D7
       mov       rdx,7FF95D550000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D577C18]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+1F0]
       mov       rcx,[rbp+18]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+90]
       test      rax,rax
       je        short M01_L26
       jmp       short M01_L27
M01_L26:
       mov       rdx,7FF95D567EE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L27:
       lea       rcx,[rbp-0C8]
       call      rax
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1054
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
M02_L00:
       push      rsi
       push      rbx
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       short M02_L02
       test      rsi,rsi
       je        short M02_L01
       mov       ecx,[rbx+18]
       mov       rdx,[rbx+20]
       mov       rax,[rbx+28]
       mov       [rsp+20],ecx
       mov       [rsp+28],rdx
       mov       [rsp+30],rax
       mov       rcx,offset System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
       cmp       [rsi+18],rcx
       jne       short M02_L03
       mov       rcx,[rsi+8]
       lea       rdx,[rsp+20]
       call      qword ptr [7FF95D577AB0]; System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
M02_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95D577558]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95D577558]
       mov       byte ptr [rbx+1C],1
M02_L02:
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L03:
       lea       rdx,[rsp+20]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M02_L01
; Total bytes of code 151
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
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
       je        near ptr M04_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M04_L02
       test      rbx,rbx
       je        short M04_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M04_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF95CB55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L01:
       call      qword ptr [7FF95CD0EF40]
       int       3
M04_L02:
       test      rbx,rbx
       je        short M04_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M04_L04
M04_L03:
       mov       rax,27D3A560008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       rbx,rcx
       mov       r8,[rbx+280]
       test      r8,r8
       je        near ptr M00_L03
       mov       r9,166800124C8
       mov       rsi,[r9]
       mov       r9d,[rsi+20]
       test      r9d,r9d
       jne       short M00_L00
       mov       rcx,r8
       mov       rdi,offset MT_System.Collections.Immutable.ImmutableHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        near ptr M00_L04
M00_L00:
       mov       rcx,[rsi+10]
       mov       rdx,[rsi+8]
       mov       rax,[rsi+18]
       mov       [rsp+28],rcx
       mov       [rsp+30],rdx
       mov       [rsp+38],rax
       mov       [rsp+40],r9d
       lea       r9,[rsp+28]
       lea       rcx,[rsp+50]
       mov       rdi,offset MT_System.Collections.Immutable.ImmutableHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rdx,rdi
       call      qword ptr [7FF95D555A40]; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
       mov       ebp,[rsp+58]
       cmp       dword ptr [rsp+5C],0
       jne       short M00_L01
       add       ebp,[rsi+20]
M00_L01:
       mov       r14,[rsp+50]
       cmp       r14,[rsi+10]
       je        near ptr M00_L05
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rsi,[rsi+8]
       test      r14,r14
       je        near ptr M00_L06
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rdx,166800124D0
       mov       rdx,[rdx]
       mov       rcx,r14
       call      qword ptr [7FF95D557C00]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+20],ebp
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,16680001FF8
       mov       rdx,[rcx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,rdi
M00_L02:
       mov       [rsp+48],rsi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+48]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Immutable.ImmutableHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF95D584E58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       call      qword ptr [7FF95D014C60]
       mov       ecx,49
       mov       rdx,7FF95CF99088
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1464
       mov       rdx,7FF95CE25108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF99088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rdx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF95D555878]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L05:
       jmp       near ptr M00_L02
M00_L06:
       mov       ecx,4AB
       mov       rdx,7FF95D540000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D55C2D0]
       int       3
M00_L07:
       mov       ecx,4B5
       mov       rdx,7FF95D540000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D55C2D0]
       int       3
; Total bytes of code 574
```
```assembly
; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,1B8
       vzeroupper
       lea       rbp,[rsp+1F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1B0],xmm4
       vmovdqa   xmmword ptr [rbp-1A0],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-1C0],rsp
       mov       [rbp-40],rdx
       mov       [rbp+18],rdx
       mov       r15,rcx
       mov       r14,rdx
       mov       rsi,r8
       mov       rbx,r9
       test      rsi,rsi
       je        near ptr M01_L24
       xor       r13d,r13d
       mov       r12,[rbx]
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdx,[rcx+70]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,r14
       mov       rdx,7FF95D567DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       lea       rcx,[rbp-150]
       mov       r8,rsi
       call      qword ptr [7FF95D55DE78]; System.Collections.Immutable.ImmutableExtensions.GetEnumerableDisposable[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rdi,[rbp-0C8]
       lea       rsi,[rbp-150]
       mov       ecx,11
       rep movsq
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rsi,[rcx+78]
       test      rsi,rsi
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,7FF95D567E80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L04:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF95D55DE18]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       je        near ptr M01_L19
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdi,[rcx+88]
       test      rdi,rdi
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,r14
       mov       rdx,7FF95D567EB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M01_L06:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF95D55DE00]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].get_Current()
       mov       [rbp-1B8],rax
       test      rax,rax
       je        near ptr M01_L15
       mov       rax,[rbp-1B8]
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,r14
       mov       rdx,7FF95D567EA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rax,[rbp-1B8]
M01_L08:
       mov       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [r11]
M01_L09:
       mov       edx,eax
       mov       [rbp-154],edx
       cmp       [r12],r12b
       mov       rax,r12
M01_L10:
       mov       r8,[rax+8]
       test      r8,r8
       je        near ptr M01_L16
       mov       ecx,[rax+18]
       cmp       edx,ecx
       je        near ptr M01_L17
       jle       short M01_L11
       mov       rax,[rax+10]
       mov       edx,[rbp-154]
       jmp       short M01_L10
M01_L11:
       mov       rax,r8
       mov       edx,[rbp-154]
       jmp       short M01_L10
M01_L12:
       mov       [rbp-168],r10
       mov       [rbp-160],r11
       mov       r8,rdi
       mov       rcx,[rbx+8]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-170]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-168]
       lea       rdx,[rbp-180]
       mov       r9,[rbp-1B8]
       call      qword ptr [7FF95D555E18]; System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, OperationResult<System.__Canon> ByRef)
       cmp       dword ptr [rbp-170],0
       jne       short M01_L14
       mov       r9,[rbx+10]
       mov       rcx,[rbp-180]
       mov       rdx,[rbp-178]
       test      rdx,rdx
       je        near ptr M01_L18
       mov       r8d,[rbp-154]
       mov       [rbp-1B0],rcx
       mov       [rbp-1A8],rdx
       lea       rcx,[rbp-198]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-1A0]
       mov       [rsp+28],rcx
       mov       rcx,r12
       mov       edx,r8d
       lea       r8,[rbp-1B0]
       call      qword ptr [7FF95D557BA0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetItem(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean ByRef, Boolean ByRef)
       mov       r12,rax
M01_L13:
       inc       r13d
M01_L14:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF95D55DE18]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L06
       jmp       short M01_L19
M01_L15:
       mov       rax,[rbp-1B8]
       xor       r8d,r8d
       mov       eax,r8d
       jmp       near ptr M01_L09
M01_L16:
       xor       r10d,r10d
       xor       r11d,r11d
       jmp       near ptr M01_L12
M01_L17:
       mov       r10,[rax+20]
       mov       r11,[rax+28]
       jmp       near ptr M01_L12
M01_L18:
       lea       r8,[rbp-198]
       mov       rcx,r12
       mov       edx,[rbp-154]
       call      qword ptr [7FF95D557CF0]
       mov       r12,rax
       jmp       short M01_L13
M01_L19:
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+90]
       test      rax,rax
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,r14
       mov       rdx,7FF95D567EE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L21:
       lea       rcx,[rbp-0C8]
       call      rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-190],xmm0
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdx,[rcx+60]
       test      rdx,rdx
       je        short M01_L22
       jmp       short M01_L23
M01_L22:
       mov       rcx,r14
       mov       rdx,7FF95D5667C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L23:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-190]
       mov       r8,r12
       mov       r9d,r13d
       call      qword ptr [7FF95D55CC90]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       mov       rdx,[rbp-190]
       mov       rcx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,[rbp-188]
       mov       [r15+8],eax
       mov       eax,[rbp-184]
       mov       [r15+0C],eax
       mov       rax,r15
       add       rsp,1B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L24:
       mov       ecx,4D7
       mov       rdx,7FF95D540000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D55C2D0]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+1F0]
       mov       rcx,[rbp+18]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+90]
       test      rax,rax
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rdx,7FF95D567EE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L26:
       lea       rcx,[rbp-0C8]
       call      rax
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1050
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
M02_L00:
       push      rsi
       push      rbx
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       short M02_L02
       test      rsi,rsi
       je        short M02_L01
       mov       ecx,[rbx+18]
       mov       rdx,[rbx+20]
       mov       rax,[rbx+28]
       mov       [rsp+20],ecx
       mov       [rsp+28],rdx
       mov       [rsp+30],rax
       mov       rcx,offset System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
       cmp       [rsi+18],rcx
       jne       short M02_L03
       mov       rcx,[rsi+8]
       lea       rdx,[rsp+20]
       call      qword ptr [7FF95D55C168]; System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
M02_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95D557C00]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95D557C00]
       mov       byte ptr [rbx+1C],1
M02_L02:
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L03:
       lea       rdx,[rsp+20]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M02_L01
; Total bytes of code 151
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
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
       je        near ptr M04_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M04_L02
       test      rbx,rbx
       je        short M04_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M04_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF95CB45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L01:
       call      qword ptr [7FF95CCFEF40]
       int       3
M04_L02:
       test      rbx,rbx
       je        short M04_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M04_L04
M04_L03:
       mov       rax,1A70DD00008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       rbx,rcx
       mov       r8,[rbx+280]
       test      r8,r8
       je        near ptr M00_L03
       mov       r9,1555BC104D0
       mov       rsi,[r9]
       mov       r9d,[rsi+20]
       test      r9d,r9d
       jne       short M00_L00
       mov       rcx,r8
       mov       rdi,offset MT_System.Collections.Immutable.ImmutableHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        near ptr M00_L04
M00_L00:
       mov       rcx,[rsi+10]
       mov       rdx,[rsi+8]
       mov       rax,[rsi+18]
       mov       [rsp+28],rcx
       mov       [rsp+30],rdx
       mov       [rsp+38],rax
       mov       [rsp+40],r9d
       lea       r9,[rsp+28]
       lea       rcx,[rsp+50]
       mov       rdi,offset MT_System.Collections.Immutable.ImmutableHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rdx,rdi
       call      qword ptr [7FF95D555A40]; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
       mov       ebp,[rsp+58]
       cmp       dword ptr [rsp+5C],0
       jne       short M00_L01
       add       ebp,[rsi+20]
M00_L01:
       mov       r14,[rsp+50]
       cmp       r14,[rsi+10]
       je        near ptr M00_L05
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rsi,[rsi+8]
       test      r14,r14
       je        near ptr M00_L06
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rdx,1555BC104D8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      qword ptr [7FF95D557C00]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+20],ebp
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1555FC01FF8
       mov       rdx,[rcx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,rdi
M00_L02:
       mov       [rsp+48],rsi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+48]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Immutable.ImmutableHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF95D584E58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       call      qword ptr [7FF95D014C60]
       mov       ecx,49
       mov       rdx,7FF95CF99088
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1464
       mov       rdx,7FF95CE25108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF99088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rdx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF95D555878]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L05:
       jmp       near ptr M00_L02
M00_L06:
       mov       ecx,4AB
       mov       rdx,7FF95D540000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D55C2D0]
       int       3
M00_L07:
       mov       ecx,4B5
       mov       rdx,7FF95D540000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D55C2D0]
       int       3
; Total bytes of code 574
```
```assembly
; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,1B8
       vzeroupper
       lea       rbp,[rsp+1F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1B0],xmm4
       vmovdqa   xmmword ptr [rbp-1A0],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-1C0],rsp
       mov       [rbp-40],rdx
       mov       [rbp+18],rdx
       mov       r15,rcx
       mov       r14,rdx
       mov       rsi,r8
       mov       rbx,r9
       test      rsi,rsi
       je        near ptr M01_L24
       xor       r13d,r13d
       mov       r12,[rbx]
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdx,[rcx+70]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,r14
       mov       rdx,7FF95D567DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       lea       rcx,[rbp-150]
       mov       r8,rsi
       call      qword ptr [7FF95D55DE78]; System.Collections.Immutable.ImmutableExtensions.GetEnumerableDisposable[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rdi,[rbp-0C8]
       lea       rsi,[rbp-150]
       mov       ecx,11
       rep movsq
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rsi,[rcx+78]
       test      rsi,rsi
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,7FF95D567E80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L04:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF95D55DE18]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       je        near ptr M01_L19
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdi,[rcx+88]
       test      rdi,rdi
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,r14
       mov       rdx,7FF95D567EB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M01_L06:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF95D55DE00]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].get_Current()
       mov       [rbp-1B8],rax
       test      rax,rax
       je        short M01_L07
       mov       rax,[rbp-1B8]
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L10
       jmp       short M01_L11
M01_L07:
       xor       r8d,r8d
       mov       eax,r8d
       jmp       short M01_L12
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M01_L08:
       lea       r8,[rbp-198]
       mov       rcx,r12
       mov       edx,[rbp-154]
       call      qword ptr [7FF95D557CF0]
       mov       r12,rax
       jmp       near ptr M01_L17
M01_L09:
       mov       r11,[r10+20]
       mov       r9,[r10+28]
       jmp       short M01_L16
M01_L10:
       mov       rcx,r14
       mov       rdx,7FF95D567EA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rax,[rbp-1B8]
M01_L11:
       mov       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [r11]
M01_L12:
       mov       edx,eax
       mov       [rbp-154],edx
       cmp       [r12],r12b
       mov       r10,r12
M01_L13:
       mov       r8,[r10+8]
       test      r8,r8
       je        short M01_L15
       mov       ecx,[r10+18]
       cmp       edx,ecx
       je        short M01_L09
       jle       short M01_L14
       mov       r10,[r10+10]
       mov       edx,[rbp-154]
       jmp       short M01_L13
M01_L14:
       mov       r10,r8
       mov       edx,[rbp-154]
       jmp       short M01_L13
M01_L15:
       xor       r11d,r11d
       xor       r9d,r9d
M01_L16:
       mov       [rbp-168],r11
       mov       [rbp-160],r9
       mov       r8,rdi
       mov       rcx,[rbx+8]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-170]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-168]
       lea       rdx,[rbp-180]
       mov       r9,[rbp-1B8]
       call      qword ptr [7FF95D555E18]; System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, OperationResult<System.__Canon> ByRef)
       cmp       dword ptr [rbp-170],0
       jne       short M01_L18
       mov       r9,[rbx+10]
       mov       rcx,[rbp-180]
       mov       rdx,[rbp-178]
       test      rdx,rdx
       je        near ptr M01_L08
       mov       r8d,[rbp-154]
       mov       [rbp-1B0],rcx
       mov       [rbp-1A8],rdx
       lea       rcx,[rbp-198]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-1A0]
       mov       [rsp+28],rcx
       mov       rcx,r12
       mov       edx,r8d
       lea       r8,[rbp-1B0]
       call      qword ptr [7FF95D557BA0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetItem(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean ByRef, Boolean ByRef)
       mov       r12,rax
M01_L17:
       inc       r13d
M01_L18:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF95D55DE18]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L06
M01_L19:
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+90]
       test      rax,rax
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,r14
       mov       rdx,7FF95D567EE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L21:
       lea       rcx,[rbp-0C8]
       call      rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-190],xmm0
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdx,[rcx+60]
       test      rdx,rdx
       je        short M01_L22
       jmp       short M01_L23
M01_L22:
       mov       rcx,r14
       mov       rdx,7FF95D5667C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L23:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-190]
       mov       r8,r12
       mov       r9d,r13d
       call      qword ptr [7FF95D55CC90]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       mov       rdx,[rbp-190]
       mov       rcx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,[rbp-188]
       mov       [r15+8],eax
       mov       eax,[rbp-184]
       mov       [r15+0C],eax
       mov       rax,r15
       add       rsp,1B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L24:
       mov       ecx,4D7
       mov       rdx,7FF95D540000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D55C2D0]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+1F0]
       mov       rcx,[rbp+18]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+90]
       test      rax,rax
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rdx,7FF95D567EE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L26:
       lea       rcx,[rbp-0C8]
       call      rax
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1037
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
M02_L00:
       push      rsi
       push      rbx
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       short M02_L02
       test      rsi,rsi
       je        short M02_L01
       mov       ecx,[rbx+18]
       mov       rdx,[rbx+20]
       mov       rax,[rbx+28]
       mov       [rsp+20],ecx
       mov       [rsp+28],rdx
       mov       [rsp+30],rax
       mov       rcx,offset System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
       cmp       [rsi+18],rcx
       jne       short M02_L03
       mov       rcx,[rsi+8]
       lea       rdx,[rsp+20]
       call      qword ptr [7FF95D55C168]; System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
M02_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95D557C00]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95D557C00]
       mov       byte ptr [rbx+1C],1
M02_L02:
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L03:
       lea       rdx,[rsp+20]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M02_L01
; Total bytes of code 151
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
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
       je        near ptr M04_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M04_L02
       test      rbx,rbx
       je        short M04_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M04_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF95CB45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L01:
       call      qword ptr [7FF95CCFEF40]
       int       3
M04_L02:
       test      rbx,rbx
       je        short M04_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M04_L04
M04_L03:
       mov       rax,195ED8F0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       rbx,rcx
       mov       r8,[rbx+280]
       test      r8,r8
       je        near ptr M00_L03
       mov       r9,235B74124C8
       mov       rsi,[r9]
       mov       r9d,[rsi+20]
       test      r9d,r9d
       jne       short M00_L00
       mov       rcx,r8
       mov       rdi,offset MT_System.Collections.Immutable.ImmutableHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        near ptr M00_L04
M00_L00:
       mov       rcx,[rsi+10]
       mov       rdx,[rsi+8]
       mov       rax,[rsi+18]
       mov       [rsp+28],rcx
       mov       [rsp+30],rdx
       mov       [rsp+38],rax
       mov       [rsp+40],r9d
       lea       r9,[rsp+28]
       lea       rcx,[rsp+50]
       mov       rdi,offset MT_System.Collections.Immutable.ImmutableHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rdx,rdi
       call      qword ptr [7FF95D575A40]; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
       mov       ebp,[rsp+58]
       cmp       dword ptr [rsp+5C],0
       jne       short M00_L01
       add       ebp,[rsi+20]
M00_L01:
       mov       r14,[rsp+50]
       cmp       r14,[rsi+10]
       je        near ptr M00_L05
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rsi,[rsi+8]
       test      r14,r14
       je        near ptr M00_L06
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rdx,235B74124D0
       mov       rdx,[rdx]
       mov       rcx,r14
       call      qword ptr [7FF95D577C00]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+20],ebp
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,235B7401FF8
       mov       rdx,[rcx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,rdi
M00_L02:
       mov       [rsp+48],rsi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+48]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Immutable.ImmutableHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF95D5A4E58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       call      qword ptr [7FF95D034C60]
       mov       ecx,49
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD46670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rdx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF95D575878]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L05:
       jmp       near ptr M00_L02
M00_L06:
       mov       ecx,4AB
       mov       rdx,7FF95D560000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D57C2D0]
       int       3
M00_L07:
       mov       ecx,4B5
       mov       rdx,7FF95D560000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D57C2D0]
       int       3
; Total bytes of code 574
```
```assembly
; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,1B8
       vzeroupper
       lea       rbp,[rsp+1F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1B0],xmm4
       vmovdqa   xmmword ptr [rbp-1A0],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-1C0],rsp
       mov       [rbp-40],rdx
       mov       [rbp+18],rdx
       mov       r15,rcx
       mov       r14,rdx
       mov       rsi,r8
       mov       rbx,r9
       test      rsi,rsi
       je        near ptr M01_L24
       xor       r13d,r13d
       mov       r12,[rbx]
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdx,[rcx+70]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,r14
       mov       rdx,7FF95D587DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       lea       rcx,[rbp-150]
       mov       r8,rsi
       call      qword ptr [7FF95D57DE78]; System.Collections.Immutable.ImmutableExtensions.GetEnumerableDisposable[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rdi,[rbp-0C8]
       lea       rsi,[rbp-150]
       mov       ecx,11
       rep movsq
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rsi,[rcx+78]
       test      rsi,rsi
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,7FF95D587E80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L04:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF95D57DE18]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       je        near ptr M01_L19
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdi,[rcx+88]
       test      rdi,rdi
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,r14
       mov       rdx,7FF95D587EB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M01_L06:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF95D57DE00]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].get_Current()
       mov       [rbp-1B8],rax
       test      rax,rax
       je        near ptr M01_L16
       mov       rax,[rbp-1B8]
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,r14
       mov       rdx,7FF95D587EA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rax,[rbp-1B8]
M01_L08:
       mov       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [r11]
M01_L09:
       mov       edx,eax
       mov       [rbp-154],edx
       cmp       [r12],r12b
       mov       rax,r12
M01_L10:
       mov       r8,[rax+8]
       test      r8,r8
       je        short M01_L12
       mov       ecx,[rax+18]
       cmp       edx,ecx
       je        near ptr M01_L17
       jle       short M01_L11
       mov       rax,[rax+10]
       mov       edx,[rbp-154]
       jmp       short M01_L10
M01_L11:
       mov       rax,r8
       mov       edx,[rbp-154]
       jmp       short M01_L10
M01_L12:
       xor       r10d,r10d
       xor       r11d,r11d
M01_L13:
       mov       [rbp-168],r10
       mov       [rbp-160],r11
       mov       r8,rdi
       mov       rcx,[rbx+8]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-170]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-168]
       lea       rdx,[rbp-180]
       mov       r9,[rbp-1B8]
       call      qword ptr [7FF95D575E18]; System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, OperationResult<System.__Canon> ByRef)
       cmp       dword ptr [rbp-170],0
       jne       short M01_L15
       mov       r9,[rbx+10]
       mov       rcx,[rbp-180]
       mov       rdx,[rbp-178]
       test      rdx,rdx
       je        near ptr M01_L18
       mov       r8d,[rbp-154]
       mov       [rbp-1B0],rcx
       mov       [rbp-1A8],rdx
       lea       rcx,[rbp-198]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-1A0]
       mov       [rsp+28],rcx
       mov       rcx,r12
       mov       edx,r8d
       lea       r8,[rbp-1B0]
       call      qword ptr [7FF95D577BA0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetItem(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean ByRef, Boolean ByRef)
       mov       r12,rax
M01_L14:
       inc       r13d
M01_L15:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF95D57DE18]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L06
       jmp       short M01_L19
M01_L16:
       mov       rax,[rbp-1B8]
       xor       r8d,r8d
       mov       eax,r8d
       jmp       near ptr M01_L09
M01_L17:
       mov       r10,[rax+20]
       mov       r11,[rax+28]
       jmp       near ptr M01_L13
M01_L18:
       lea       r8,[rbp-198]
       mov       rcx,r12
       mov       edx,[rbp-154]
       call      qword ptr [7FF95D577CF0]
       mov       r12,rax
       jmp       short M01_L14
M01_L19:
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+90]
       test      rax,rax
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,r14
       mov       rdx,7FF95D587EE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L21:
       lea       rcx,[rbp-0C8]
       call      rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-190],xmm0
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdx,[rcx+60]
       test      rdx,rdx
       je        short M01_L22
       jmp       short M01_L23
M01_L22:
       mov       rcx,r14
       mov       rdx,7FF95D5867C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L23:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-190]
       mov       r8,r12
       mov       r9d,r13d
       call      qword ptr [7FF95D57CC90]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       mov       rdx,[rbp-190]
       mov       rcx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,[rbp-188]
       mov       [r15+8],eax
       mov       eax,[rbp-184]
       mov       [r15+0C],eax
       mov       rax,r15
       add       rsp,1B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L24:
       mov       ecx,4D7
       mov       rdx,7FF95D560000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D57C2D0]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+1F0]
       mov       rcx,[rbp+18]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+90]
       test      rax,rax
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rdx,7FF95D587EE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L26:
       lea       rcx,[rbp-0C8]
       call      rax
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1041
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
M02_L00:
       push      rsi
       push      rbx
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       short M02_L02
       test      rsi,rsi
       je        short M02_L01
       mov       ecx,[rbx+18]
       mov       rdx,[rbx+20]
       mov       rax,[rbx+28]
       mov       [rsp+20],ecx
       mov       [rsp+28],rdx
       mov       [rsp+30],rax
       mov       rcx,offset System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
       cmp       [rsi+18],rcx
       jne       short M02_L03
       mov       rcx,[rsi+8]
       lea       rdx,[rsp+20]
       call      qword ptr [7FF95D57C168]; System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
M02_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95D577C00]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95D577C00]
       mov       byte ptr [rbx+1C],1
M02_L02:
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L03:
       lea       rdx,[rsp+20]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M02_L01
; Total bytes of code 151
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
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
       je        near ptr M04_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M04_L02
       test      rbx,rbx
       je        short M04_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M04_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF95CB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L01:
       call      qword ptr [7FF95CD1EF40]
       int       3
M04_L02:
       test      rbx,rbx
       je        short M04_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M04_L04
M04_L03:
       mov       rax,27645450008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       rbx,rcx
       mov       r8,[rbx+280]
       test      r8,r8
       je        near ptr M00_L03
       mov       r9,17A770104D0
       mov       rsi,[r9]
       mov       r9d,[rsi+20]
       test      r9d,r9d
       jne       short M00_L00
       mov       rcx,r8
       mov       rdi,offset MT_System.Collections.Immutable.ImmutableHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        near ptr M00_L04
M00_L00:
       mov       rcx,[rsi+10]
       mov       rdx,[rsi+8]
       mov       rax,[rsi+18]
       mov       [rsp+28],rcx
       mov       [rsp+30],rdx
       mov       [rsp+38],rax
       mov       [rsp+40],r9d
       lea       r9,[rsp+28]
       lea       rcx,[rsp+50]
       mov       rdi,offset MT_System.Collections.Immutable.ImmutableHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rdx,rdi
       call      qword ptr [7FF95D58D650]; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
       mov       ebp,[rsp+58]
       cmp       dword ptr [rsp+5C],0
       jne       short M00_L01
       add       ebp,[rsi+20]
M00_L01:
       mov       r14,[rsp+50]
       cmp       r14,[rsi+10]
       je        near ptr M00_L05
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rsi,[rsi+8]
       test      r14,r14
       je        near ptr M00_L06
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rdx,17A770104D8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      qword ptr [7FF95D58F810]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+20],ebp
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,17A7B002000
       mov       rdx,[rcx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,rdi
M00_L02:
       mov       [rsp+48],rsi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+48]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Immutable.ImmutableHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF95D5DCE58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       call      qword ptr [7FF95D014C60]
       mov       ecx,49
       mov       rdx,7FF95CF99088
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1464
       mov       rdx,7FF95CE25108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF99088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rdx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF95D58D488]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L05:
       jmp       near ptr M00_L02
M00_L06:
       mov       ecx,4AB
       mov       rdx,7FF95D57F5E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D58FED0]
       int       3
M00_L07:
       mov       ecx,4B5
       mov       rdx,7FF95D57F5E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D58FED0]
       int       3
; Total bytes of code 574
```
```assembly
; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,1B8
       vzeroupper
       lea       rbp,[rsp+1F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1B0],xmm4
       vmovdqa   xmmword ptr [rbp-1A0],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-1C0],rsp
       mov       [rbp-40],rdx
       mov       [rbp+18],rdx
       mov       r15,rcx
       mov       r14,rdx
       mov       rsi,r8
       mov       rbx,r9
       test      rsi,rsi
       je        near ptr M01_L25
       xor       r13d,r13d
       mov       r12,[rbx]
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdx,[rcx+70]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,r14
       mov       rdx,7FF95D5B7DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       lea       rcx,[rbp-150]
       mov       r8,rsi
       call      qword ptr [7FF95D5D5AA0]; System.Collections.Immutable.ImmutableExtensions.GetEnumerableDisposable[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rdi,[rbp-0C8]
       lea       rsi,[rbp-150]
       mov       ecx,11
       rep movsq
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rsi,[rcx+78]
       test      rsi,rsi
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,7FF95D5B7E80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L04:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF95D5D5A40]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       je        near ptr M01_L20
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdi,[rcx+88]
       test      rdi,rdi
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,r14
       mov       rdx,7FF95D5B7EB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M01_L06:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF95D5D5A28]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].get_Current()
       mov       [rbp-1B8],rax
       test      rax,rax
       je        near ptr M01_L19
       mov       rax,[rbp-1B8]
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,r14
       mov       rdx,7FF95D5B7EA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rax,[rbp-1B8]
M01_L08:
       mov       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [r11]
M01_L09:
       mov       edx,eax
       mov       [rbp-154],edx
       cmp       [r12],r12b
       mov       rax,r12
M01_L10:
       mov       r8,[rax+8]
       test      r8,r8
       je        near ptr M01_L17
       mov       ecx,[rax+18]
       cmp       edx,ecx
       je        near ptr M01_L16
       jle       short M01_L11
       mov       rax,[rax+10]
       mov       edx,[rbp-154]
       jmp       short M01_L10
M01_L11:
       mov       rax,r8
       mov       edx,[rbp-154]
       jmp       short M01_L10
M01_L12:
       mov       rcx,r12
       mov       r12d,[rbp-154]
       mov       edx,r12d
       mov       [rbp-1B0],rax
       mov       [rbp-1A8],r8
       lea       r8,[rbp-198]
       mov       [rsp+20],r8
       lea       r8,[rbp-1A0]
       mov       [rsp+28],r8
       lea       r8,[rbp-1B0]
       call      qword ptr [7FF95D58F7B0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetItem(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean ByRef, Boolean ByRef)
       mov       r12,rax
M01_L13:
       inc       r13d
M01_L14:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF95D5D5A40]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L06
       jmp       near ptr M01_L20
M01_L15:
       lea       r8,[rbp-198]
       mov       rcx,r12
       mov       edx,[rbp-154]
       call      qword ptr [7FF95D58F900]
       mov       r12,rax
       jmp       short M01_L13
M01_L16:
       mov       r10,[rax+20]
       mov       r11,[rax+28]
       jmp       short M01_L18
M01_L17:
       xor       r10d,r10d
       xor       r11d,r11d
M01_L18:
       mov       [rbp-168],r10
       mov       [rbp-160],r11
       mov       r8,rdi
       mov       rcx,[rbx+8]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-170]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-168]
       lea       rdx,[rbp-180]
       mov       r9,[rbp-1B8]
       call      qword ptr [7FF95D58DA28]; System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, OperationResult<System.__Canon> ByRef)
       cmp       dword ptr [rbp-170],0
       jne       near ptr M01_L14
       mov       r9,[rbx+10]
       mov       rax,[rbp-180]
       mov       r8,[rbp-178]
       test      r8,r8
       je        near ptr M01_L15
       jmp       near ptr M01_L12
M01_L19:
       mov       rax,[rbp-1B8]
       xor       r8d,r8d
       mov       eax,r8d
       jmp       near ptr M01_L09
M01_L20:
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+90]
       test      rax,rax
       je        short M01_L21
       jmp       short M01_L22
M01_L21:
       mov       rcx,r14
       mov       rdx,7FF95D5B7EE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L22:
       lea       rcx,[rbp-0C8]
       call      rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-190],xmm0
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdx,[rcx+60]
       test      rdx,rdx
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rcx,r14
       mov       rdx,7FF95D5B67C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L24:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-190]
       mov       r8,r12
       mov       r9d,r13d
       call      qword ptr [7FF95D5D48B8]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       mov       rdx,[rbp-190]
       mov       rcx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,[rbp-188]
       mov       [r15+8],eax
       mov       eax,[rbp-184]
       mov       [r15+0C],eax
       mov       rax,r15
       add       rsp,1B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L25:
       mov       ecx,4D7
       mov       rdx,7FF95D57F5E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D58FED0]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+1F0]
       mov       rcx,[rbp+18]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+90]
       test      rax,rax
       je        short M01_L26
       jmp       short M01_L27
M01_L26:
       mov       rdx,7FF95D5B7EE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L27:
       lea       rcx,[rbp-0C8]
       call      rax
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1054
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
M02_L00:
       push      rsi
       push      rbx
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       short M02_L02
       test      rsi,rsi
       je        short M02_L01
       mov       ecx,[rbx+18]
       mov       rdx,[rbx+20]
       mov       rax,[rbx+28]
       mov       [rsp+20],ecx
       mov       [rsp+28],rdx
       mov       [rsp+30],rax
       mov       rcx,offset System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
       cmp       [rsi+18],rcx
       jne       short M02_L03
       mov       rcx,[rsi+8]
       lea       rdx,[rsp+20]
       call      qword ptr [7FF95D58FD68]; System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
M02_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95D58F810]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95D58F810]
       mov       byte ptr [rbx+1C],1
M02_L02:
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L03:
       lea       rdx,[rsp+20]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M02_L01
; Total bytes of code 151
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
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
       je        near ptr M04_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M04_L02
       test      rbx,rbx
       je        short M04_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M04_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF95CB45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L01:
       call      qword ptr [7FF95CCFEF40]
       int       3
M04_L02:
       test      rbx,rbx
       je        short M04_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M04_L04
M04_L03:
       mov       rax,1BB08F50008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       rbx,rcx
       mov       r8,[rbx+280]
       test      r8,r8
       je        near ptr M00_L03
       mov       r9,1DE740104D8
       mov       rsi,[r9]
       mov       r9d,[rsi+20]
       test      r9d,r9d
       jne       short M00_L00
       mov       rcx,r8
       mov       rdi,offset MT_System.Collections.Immutable.ImmutableHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        near ptr M00_L04
M00_L00:
       mov       rcx,[rsi+10]
       mov       rdx,[rsi+8]
       mov       rax,[rsi+18]
       mov       [rsp+28],rcx
       mov       [rsp+30],rdx
       mov       [rsp+38],rax
       mov       [rsp+40],r9d
       lea       r9,[rsp+28]
       lea       rcx,[rsp+50]
       mov       rdi,offset MT_System.Collections.Immutable.ImmutableHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rdx,rdi
       call      qword ptr [7FF95D63E778]; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
       mov       ebp,[rsp+58]
       cmp       dword ptr [rsp+5C],0
       jne       short M00_L01
       add       ebp,[rsi+20]
M00_L01:
       mov       r14,[rsp+50]
       cmp       r14,[rsi+10]
       je        near ptr M00_L05
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rsi,[rsi+8]
       test      r14,r14
       je        near ptr M00_L06
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rdx,1DE740104E0
       mov       rdx,[rdx]
       mov       rcx,r14
       call      qword ptr [7FF95D674F30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+20],ebp
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1DE740104F0
       mov       rdx,[rcx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,rdi
M00_L02:
       mov       [rsp+48],rsi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+48]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Immutable.ImmutableHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF95D67E520]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       call      qword ptr [7FF95D024C60]
       mov       ecx,49
       mov       rdx,7FF95CFA9088
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1464
       mov       rdx,7FF95CE35108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CFA9088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D024A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD36670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rdx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF95D63E5B0]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L05:
       jmp       near ptr M00_L02
M00_L06:
       mov       ecx,4AB
       mov       rdx,7FF95D643D38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D6755F0]
       int       3
M00_L07:
       mov       ecx,4B5
       mov       rdx,7FF95D643D38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D6755F0]
       int       3
; Total bytes of code 574
```
```assembly
; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,1B8
       vzeroupper
       lea       rbp,[rsp+1F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1B0],xmm4
       vmovdqa   xmmword ptr [rbp-1A0],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-1C0],rsp
       mov       [rbp-40],rdx
       mov       [rbp+18],rdx
       mov       r15,rcx
       mov       r14,rdx
       mov       rsi,r8
       mov       rbx,r9
       test      rsi,rsi
       je        near ptr M01_L24
       xor       r13d,r13d
       mov       r12,[rbx]
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdx,[rcx+70]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,r14
       mov       rdx,7FF95D65D698
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       lea       rcx,[rbp-150]
       mov       r8,rsi
       call      qword ptr [7FF95D677198]; System.Collections.Immutable.ImmutableExtensions.GetEnumerableDisposable[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rdi,[rbp-0C8]
       lea       rsi,[rbp-150]
       mov       ecx,11
       rep movsq
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rsi,[rcx+78]
       test      rsi,rsi
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,7FF95D65D758
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L04:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF95D677138]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       je        near ptr M01_L19
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdi,[rcx+88]
       test      rdi,rdi
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,r14
       mov       rdx,7FF95D65D790
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M01_L06:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF95D677120]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].get_Current()
       mov       [rbp-1B8],rax
       test      rax,rax
       je        near ptr M01_L16
       mov       rax,[rbp-1B8]
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,r14
       mov       rdx,7FF95D65D778
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rax,[rbp-1B8]
M01_L08:
       mov       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [r11]
M01_L09:
       mov       edx,eax
       mov       [rbp-154],edx
       cmp       [r12],r12b
       mov       rax,r12
M01_L10:
       mov       r8,[rax+8]
       test      r8,r8
       je        short M01_L12
       mov       ecx,[rax+18]
       cmp       edx,ecx
       je        near ptr M01_L17
       jle       short M01_L11
       mov       rax,[rax+10]
       mov       edx,[rbp-154]
       jmp       short M01_L10
M01_L11:
       mov       rax,r8
       mov       edx,[rbp-154]
       jmp       short M01_L10
M01_L12:
       xor       r10d,r10d
       xor       r11d,r11d
M01_L13:
       mov       [rbp-168],r10
       mov       [rbp-160],r11
       mov       r8,rdi
       mov       rcx,[rbx+8]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-170]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-168]
       lea       rdx,[rbp-180]
       mov       r9,[rbp-1B8]
       call      qword ptr [7FF95D63EB50]; System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, OperationResult<System.__Canon> ByRef)
       cmp       dword ptr [rbp-170],0
       jne       short M01_L15
       mov       r9,[rbx+10]
       mov       rcx,[rbp-180]
       mov       rdx,[rbp-178]
       test      rdx,rdx
       je        near ptr M01_L18
       mov       r8d,[rbp-154]
       mov       [rbp-1B0],rcx
       mov       [rbp-1A8],rdx
       lea       rcx,[rbp-198]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-1A0]
       mov       [rsp+28],rcx
       mov       rcx,r12
       mov       edx,r8d
       lea       r8,[rbp-1B0]
       call      qword ptr [7FF95D674ED0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetItem(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean ByRef, Boolean ByRef)
       mov       r12,rax
M01_L14:
       inc       r13d
M01_L15:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF95D677138]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L06
       jmp       short M01_L19
M01_L16:
       mov       rax,[rbp-1B8]
       xor       r8d,r8d
       mov       eax,r8d
       jmp       near ptr M01_L09
M01_L17:
       mov       r10,[rax+20]
       mov       r11,[rax+28]
       jmp       near ptr M01_L13
M01_L18:
       lea       r8,[rbp-198]
       mov       rcx,r12
       mov       edx,[rbp-154]
       call      qword ptr [7FF95D675020]
       mov       r12,rax
       jmp       short M01_L14
M01_L19:
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+90]
       test      rax,rax
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,r14
       mov       rdx,7FF95D65D7B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L21:
       lea       rcx,[rbp-0C8]
       call      rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-190],xmm0
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdx,[rcx+60]
       test      rdx,rdx
       je        short M01_L22
       jmp       short M01_L23
M01_L22:
       mov       rcx,r14
       mov       rdx,7FF95D65C0A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L23:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-190]
       mov       r8,r12
       mov       r9d,r13d
       call      qword ptr [7FF95D675FB0]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       mov       rdx,[rbp-190]
       mov       rcx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,[rbp-188]
       mov       [r15+8],eax
       mov       eax,[rbp-184]
       mov       [r15+0C],eax
       mov       rax,r15
       add       rsp,1B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L24:
       mov       ecx,4D7
       mov       rdx,7FF95D643D38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D6755F0]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+1F0]
       mov       rcx,[rbp+18]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+90]
       test      rax,rax
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rdx,7FF95D65D7B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L26:
       lea       rcx,[rbp-0C8]
       call      rax
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1041
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
M02_L00:
       push      rsi
       push      rbx
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       short M02_L02
       test      rsi,rsi
       je        short M02_L01
       mov       ecx,[rbx+18]
       mov       rdx,[rbx+20]
       mov       rax,[rbx+28]
       mov       [rsp+20],ecx
       mov       [rsp+28],rdx
       mov       [rsp+30],rax
       mov       rcx,7FF95D671488
       cmp       [rsi+18],rcx
       jne       short M02_L03
       mov       rcx,[rsi+8]
       lea       rdx,[rsp+20]
       call      qword ptr [7FF95D675488]; System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
M02_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95D674F30]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95D674F30]
       mov       byte ptr [rbx+1C],1
M02_L02:
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L03:
       lea       rdx,[rsp+20]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M02_L01
; Total bytes of code 151
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
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
       je        near ptr M04_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M04_L02
       test      rbx,rbx
       je        short M04_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M04_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF95CB55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L01:
       call      qword ptr [7FF95CD0EF40]
       int       3
M04_L02:
       test      rbx,rbx
       je        short M04_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M04_L04
M04_L03:
       mov       rax,21F05FA0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       rbx,rcx
       mov       r8,[rbx+280]
       test      r8,r8
       je        near ptr M00_L03
       mov       r9,1A5000124D8
       mov       rsi,[r9]
       mov       r9d,[rsi+20]
       test      r9d,r9d
       jne       short M00_L00
       mov       rcx,r8
       mov       rdi,offset MT_System.Collections.Immutable.ImmutableHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        near ptr M00_L04
M00_L00:
       mov       rcx,[rsi+10]
       mov       rdx,[rsi+8]
       mov       rax,[rsi+18]
       mov       [rsp+28],rcx
       mov       [rsp+30],rdx
       mov       [rsp+38],rax
       mov       [rsp+40],r9d
       lea       r9,[rsp+28]
       lea       rcx,[rsp+50]
       mov       rdi,offset MT_System.Collections.Immutable.ImmutableHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       mov       rdx,rdi
       call      qword ptr [7FF95D735650]; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
       mov       ebp,[rsp+58]
       cmp       dword ptr [rsp+5C],0
       jne       short M00_L01
       add       ebp,[rsi+20]
M00_L01:
       mov       r14,[rsp+50]
       cmp       r14,[rsi+10]
       je        near ptr M00_L05
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rsi,[rsi+8]
       test      r14,r14
       je        near ptr M00_L06
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rdx,1A5000124E0
       mov       rdx,[rdx]
       mov       rcx,r14
       call      qword ptr [7FF95D737810]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+20],ebp
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1A5000124F0
       mov       rdx,[rcx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,rdi
M00_L02:
       mov       [rsp+48],rsi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+48]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Immutable.ImmutableHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF95D754E58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       call      qword ptr [7FF95D024C60]
       mov       ecx,49
       mov       rdx,7FF95CFA9088
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1464
       mov       rdx,7FF95CE35108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CFA9088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D024A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD36670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rdx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF95D735488]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L05:
       jmp       near ptr M00_L02
M00_L06:
       mov       ecx,4AB
       mov       rdx,7FF95D700000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D737ED0]
       int       3
M00_L07:
       mov       ecx,4B5
       mov       rdx,7FF95D700000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D737ED0]
       int       3
; Total bytes of code 574
```
```assembly
; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,1B8
       vzeroupper
       lea       rbp,[rsp+1F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1B0],xmm4
       vmovdqa   xmmword ptr [rbp-1A0],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-1C0],rsp
       mov       [rbp-40],rdx
       mov       [rbp+18],rdx
       mov       r15,rcx
       mov       r14,rdx
       mov       rsi,r8
       mov       rbx,r9
       test      rsi,rsi
       je        near ptr M01_L24
       xor       r13d,r13d
       mov       r12,[rbx]
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdx,[rcx+70]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,r14
       mov       rdx,7FF95D727A80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       lea       rcx,[rbp-150]
       mov       r8,rsi
       call      qword ptr [7FF95D73DAA0]; System.Collections.Immutable.ImmutableExtensions.GetEnumerableDisposable[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rdi,[rbp-0C8]
       lea       rsi,[rbp-150]
       mov       ecx,11
       rep movsq
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rsi,[rcx+78]
       test      rsi,rsi
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,7FF95D727B40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L04:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF95D73DA40]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       je        near ptr M01_L19
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdi,[rcx+88]
       test      rdi,rdi
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,r14
       mov       rdx,7FF95D727B78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M01_L06:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF95D73DA28]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].get_Current()
       mov       [rbp-1B8],rax
       test      rax,rax
       je        near ptr M01_L15
       mov       rax,[rbp-1B8]
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,r14
       mov       rdx,7FF95D727B60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rax,[rbp-1B8]
M01_L08:
       mov       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [r11]
M01_L09:
       mov       edx,eax
       mov       [rbp-154],edx
       cmp       [r12],r12b
       mov       rax,r12
M01_L10:
       mov       r8,[rax+8]
       test      r8,r8
       je        near ptr M01_L16
       mov       ecx,[rax+18]
       cmp       edx,ecx
       je        near ptr M01_L17
       jle       short M01_L11
       mov       rax,[rax+10]
       mov       edx,[rbp-154]
       jmp       short M01_L10
M01_L11:
       mov       rax,r8
       mov       edx,[rbp-154]
       jmp       short M01_L10
M01_L12:
       mov       [rbp-168],r10
       mov       [rbp-160],r11
       mov       r8,rdi
       mov       rcx,[rbx+8]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-170]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-168]
       lea       rdx,[rbp-180]
       mov       r9,[rbp-1B8]
       call      qword ptr [7FF95D735A28]; System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, OperationResult<System.__Canon> ByRef)
       cmp       dword ptr [rbp-170],0
       jne       short M01_L14
       mov       r9,[rbx+10]
       mov       rcx,[rbp-180]
       mov       rdx,[rbp-178]
       test      rdx,rdx
       je        near ptr M01_L18
       mov       r8d,[rbp-154]
       mov       [rbp-1B0],rcx
       mov       [rbp-1A8],rdx
       lea       rcx,[rbp-198]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-1A0]
       mov       [rsp+28],rcx
       mov       rcx,r12
       mov       edx,r8d
       lea       r8,[rbp-1B0]
       call      qword ptr [7FF95D7377B0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetItem(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean ByRef, Boolean ByRef)
       mov       r12,rax
M01_L13:
       inc       r13d
M01_L14:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF95D73DA40]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L06
       jmp       short M01_L19
M01_L15:
       mov       rax,[rbp-1B8]
       xor       r8d,r8d
       mov       eax,r8d
       jmp       near ptr M01_L09
M01_L16:
       xor       r10d,r10d
       xor       r11d,r11d
       jmp       near ptr M01_L12
M01_L17:
       mov       r10,[rax+20]
       mov       r11,[rax+28]
       jmp       near ptr M01_L12
M01_L18:
       lea       r8,[rbp-198]
       mov       rcx,r12
       mov       edx,[rbp-154]
       call      qword ptr [7FF95D737900]
       mov       r12,rax
       jmp       short M01_L13
M01_L19:
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+90]
       test      rax,rax
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,r14
       mov       rdx,7FF95D727BA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L21:
       lea       rcx,[rbp-0C8]
       call      rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-190],xmm0
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdx,[rcx+60]
       test      rdx,rdx
       je        short M01_L22
       jmp       short M01_L23
M01_L22:
       mov       rcx,r14
       mov       rdx,7FF95D726488
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L23:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-190]
       mov       r8,r12
       mov       r9d,r13d
       call      qword ptr [7FF95D73C8B8]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       mov       rdx,[rbp-190]
       mov       rcx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,[rbp-188]
       mov       [r15+8],eax
       mov       eax,[rbp-184]
       mov       [r15+0C],eax
       mov       rax,r15
       add       rsp,1B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L24:
       mov       ecx,4D7
       mov       rdx,7FF95D700000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D737ED0]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+1F0]
       mov       rcx,[rbp+18]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+90]
       test      rax,rax
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rdx,7FF95D727BA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L26:
       lea       rcx,[rbp-0C8]
       call      rax
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1050
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
M02_L00:
       push      rsi
       push      rbx
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       short M02_L02
       test      rsi,rsi
       je        short M02_L01
       mov       ecx,[rbx+18]
       mov       rdx,[rbx+20]
       mov       rax,[rbx+28]
       mov       [rsp+20],ecx
       mov       [rsp+28],rdx
       mov       [rsp+30],rax
       mov       rcx,offset System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
       cmp       [rsi+18],rcx
       jne       short M02_L03
       mov       rcx,[rsi+8]
       lea       rdx,[rsp+20]
       call      qword ptr [7FF95D737D68]; System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
M02_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95D737810]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95D737810]
       mov       byte ptr [rbx+1C],1
M02_L02:
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L03:
       lea       rdx,[rsp+20]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M02_L01
; Total bytes of code 151
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
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
       je        near ptr M04_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M04_L02
       test      rbx,rbx
       je        short M04_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M04_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF95CB55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L01:
       call      qword ptr [7FF95CD0EF40]
       int       3
M04_L02:
       test      rbx,rbx
       je        short M04_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M04_L04
M04_L03:
       mov       rax,1E591F80008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.Upsert()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       r8,[rbx+288]
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF95D53D230]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FF95CD96C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF95CD7F118]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF95CD96F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF95D034C60]
       mov       ecx,49
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD46670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FF95D034C60]
       mov       ecx,25D
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD46670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.Upsert()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       r8,[rbx+288]
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF95D54DE60]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FF95CD96C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF95CD7F118]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF95CD96F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF95CFDF4F8]
       mov       ecx,49
       mov       rdx,7FF95CFB7FF8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE44C28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CFB7FF8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95CFDF2E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD46670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FF95CFDF4F8]
       mov       ecx,25D
       mov       rdx,7FF95CFB7FF8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE44C28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CFB7FF8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95CFDF2E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD46670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.Upsert()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       r8,[rbx+288]
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF95D52E5C8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FF95CD76C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF95CD5F118]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF95CD76F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF95D014C60]
       mov       ecx,49
       mov       rdx,7FF95CF99088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE25108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF99088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FF95D014C60]
       mov       ecx,25D
       mov       rdx,7FF95CF99088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE25108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF99088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.Upsert()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       r8,[rbx+288]
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF95D51E4F0]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FF95CD66C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF95CD4F118]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF95CD66F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF95D004C60]
       mov       ecx,49
       mov       rdx,7FF95CF89088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE15108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF89088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D004A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FF95D004C60]
       mov       ecx,25D
       mov       rdx,7FF95CF89088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE15108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF89088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D004A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.Upsert()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       r8,[rbx+288]
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF95D54E5C8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FF95CD96C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF95CD7F118]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF95CD96F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF95D034C60]
       mov       ecx,49
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD46670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FF95D034C60]
       mov       ecx,25D
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD46670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.Upsert()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       r8,[rbx+288]
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF95D54E5C8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FF95CD96C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF95CD7F118]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF95CD96F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF95D034C60]
       mov       ecx,49
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD46670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FF95D034C60]
       mov       ecx,25D
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CFB9088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD46670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.Upsert()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       r8,[rbx+288]
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF95D656EF8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FF95CDA6C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF95CD8F118]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF95CDA6F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF95D044C60]
       mov       ecx,49
       mov       rdx,7FF95CFC9088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE55108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CFC9088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D044A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD56670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FF95D044C60]
       mov       ecx,25D
       mov       rdx,7FF95CFC9088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE55108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CFC9088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D044A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD56670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.Upsert()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       r8,[rbx+288]
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF95D6DDE60]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FF95CD66C58]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF95CD4F118]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF95CD66F88]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF95CFAF4F8]
       mov       ecx,49
       mov       rdx,7FF95CF87FF8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE14C28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF87FF8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95CFAF2E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FF95CFAF4F8]
       mov       ecx,25D
       mov       rdx,7FF95CF87FF8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE14C28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF87FF8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95CFAF2E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

