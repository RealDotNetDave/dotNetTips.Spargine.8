## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.AddIf()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       mov       rdx,[rbx+1A0]
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
       call      qword ptr [7FFE8BF56F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FFE8C27EDF0]
       mov       ecx,49
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FFE8C27EDF0]
       mov       ecx,267
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
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
       mov       rdx,7FFE8C733210
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
       mov       rdx,7FFE8C733378
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
       call      qword ptr [7FFE8BEDF000]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FFE8BF56EC8]
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
       call      qword ptr [7FFE8BC84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFE8BF56EE0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BF56C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FFE8BF56F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BEDEF10]
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
       mov       rax,1B5E7120008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.AddIf()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       mov       rdx,[rbx+1A0]
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
       call      qword ptr [7FFE8BF56F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FFE8C27EDF0]
       mov       ecx,49
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FFE8C27EDF0]
       mov       ecx,267
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
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
       mov       rdx,7FFE8C733210
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
       mov       rdx,7FFE8C733378
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
       call      qword ptr [7FFE8BEDF000]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FFE8BF56EC8]
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
       call      qword ptr [7FFE8BC84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFE8BF56EE0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BF56C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FFE8BF56F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BEDEF10]
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
       mov       rax,27E11EB0008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.AddIf()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       mov       rdx,[rbx+1A0]
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
       call      qword ptr [7FFE8BF56F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FFE8C27EDF0]
       mov       ecx,49
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FFE8C27EDF0]
       mov       ecx,267
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
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
       mov       rdx,7FFE8C6FF848
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
       mov       rdx,7FFE8C6FF9B0
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
       call      qword ptr [7FFE8BEDF000]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FFE8BF56EC8]
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
       call      qword ptr [7FFE8BC84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFE8BF56EE0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BF56C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FFE8BF56F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BEDEF10]
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
       mov       rax,1CADF2D0008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.AddIf()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       mov       rdx,[rbx+1A0]
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
       call      qword ptr [7FFE8BF66F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FFE8C28EDF0]
       mov       ecx,49
       mov       rdx,7FFE8C170EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C012E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C170EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C28EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FFE8C28EDF0]
       mov       ecx,267
       mov       rdx,7FFE8C170EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C012E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C170EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C28EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF16670]
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
       mov       rdx,7FFE8C743758
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
       mov       rdx,7FFE8C7438C0
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
       call      qword ptr [7FFE8BEEF000]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FFE8BF66EC8]
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
       call      qword ptr [7FFE8BC94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFE8BF66EE0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BF66C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FFE8BF66F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BEEEF10]
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
       mov       rax,22F78290008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.AddIf()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       mov       rdx,[rbx+1A0]
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
       call      qword ptr [7FFE8BF46F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FFE8C26DE30]
       mov       ecx,49
       mov       rdx,7FFE8C150EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8BFF2E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C150EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C26DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FFE8C26DE30]
       mov       ecx,267
       mov       rdx,7FFE8C150EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8BFF2E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C150EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C26DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BEF6670]
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
       mov       rdx,7FFE8C728518
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
       mov       rdx,7FFE8C728680
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
       call      qword ptr [7FFE8BECF000]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FFE8BF46EC8]
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
       call      qword ptr [7FFE8BC74360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFE8BF46EE0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BF46C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FFE8BF46F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BECEF10]
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
       mov       rax,26841750008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.AddIf()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       mov       rdx,[rbx+1A0]
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
       call      qword ptr [7FFE8BF86F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FFE8C2AEDF0]
       mov       ecx,49
       mov       rdx,7FFE8C190EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C032E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C190EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C2AEBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF36670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FFE8C2AEDF0]
       mov       ecx,267
       mov       rdx,7FFE8C190EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C032E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C190EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C2AEBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF36670]
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
       mov       rdx,7FFE8C792900
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
       mov       rdx,7FFE8C792A68
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
       call      qword ptr [7FFE8BF0F000]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FFE8BF86EC8]
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
       call      qword ptr [7FFE8BCB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFE8BF86EE0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BF86C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FFE8BF86F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FFE8BD65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BF0EF10]
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
       mov       rax,1D505FD0008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.AddIf()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       mov       rdx,[rbx+1A0]
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
       call      qword ptr [7FFE8BF76F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FFE8C29EDF0]
       mov       ecx,49
       mov       rdx,7FFE8C180EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C180EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C29EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FFE8C29EDF0]
       mov       ecx,267
       mov       rdx,7FFE8C180EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C180EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C29EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
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
       mov       rdx,offset System.Runtime.Intrinsics.Vector128.AsInt16[[System.UInt16, System.Private.CoreLib]](System.Runtime.Intrinsics.Vector128`1<UInt16>)
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
       mov       rdx,7FFE8C7597D8
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
       call      qword ptr [7FFE8BEFF000]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FFE8BF76EC8]
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
       call      qword ptr [7FFE8BCA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFE8BF76EE0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BF76C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FFE8BF76F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BEFEF10]
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
       mov       rax,2D46D220008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.AddIf()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       mov       rdx,[rbx+1A0]
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
       call      qword ptr [7FFE8BF56F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FFE8C27EDF0]
       mov       ecx,49
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FFE8C27EDF0]
       mov       ecx,267
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
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
       mov       rdx,7FFE8C73B6B8
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
       mov       rdx,7FFE8C73B820
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
       call      qword ptr [7FFE8BEDF000]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FFE8BF56EC8]
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
       call      qword ptr [7FFE8BC84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFE8BF56EE0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BF56C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FFE8BF56F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BEDEF10]
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
       mov       rax,287C9340008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       test      rsi,rsi
       je        near ptr M00_L04
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
       xor       r15d,r15d
       mov       r13d,[r14+8]
       test      r13d,r13d
       jle       short M00_L01
       mov       r12,offset MT_System.Object
M00_L00:
       mov       rcx,r12
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,r15d
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L03
       cmp       r13d,r15d
       jg        short M00_L00
M00_L01:
       mov       edx,r13d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
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
       mov       rdx,r15
       lea       rcx,[r12+10]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+1C],1
       mov       eax,[rbp+8]
       xor       edx,edx
       div       r13d
       mov       [rdi+18],eax
       mov       rcx,26CDD401FC8
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE8C43F7E0]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C6A85B8
       mov       [rbp+18],rcx
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BD3E3B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rdi+18],0
       je        near ptr M00_L05
M00_L02:
       mov       [rsp+20],rdi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C6AD9C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L03:
       call      CORINFO_HELP_OVERFLOW
M00_L04:
       call      qword ptr [7FFE8C27EDF0]
       mov       ecx,49
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
       mov       eax,[rax+8]
       mov       rdx,[rdi+10]
       mov       rcx,[rdx+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rdi+18],eax
       jmp       near ptr M00_L02
; Total bytes of code 628
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L07
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFE8C7C59E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE8BC84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L02
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE8C7C5A90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BD3DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFE8C7C59F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M01_L07:
       mov       ecx,10
       call      qword ptr [7FFE8BF04F30]
       int       3
; Total bytes of code 215
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
       je        near ptr M02_L04
       mov       edi,[rbx+14]
       xor       ebp,ebp
       cmp       dword ptr [rbx+10],0
       jle       short M02_L03
       mov       rcx,7FFE8C6A85B8
       cmp       [rsi+18],rcx
       jne       short M02_L01
M02_L00:
       cmp       edi,[rbx+14]
       jne       short M02_L03
       mov       r14,[rbx+8]
       cmp       ebp,[r14+8]
       jae       near ptr M02_L07
       mov       ecx,ebp
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [7FFE8C6AC5B8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M02_L00
       jmp       short M02_L03
M02_L01:
       cmp       edi,[rbx+14]
       jne       short M02_L03
       mov       r14,[rbx+8]
       cmp       ebp,[r14+8]
       jae       short M02_L07
       mov       ecx,ebp
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,7FFE8C6A85B8
       cmp       [rsi+18],rcx
       jne       short M02_L05
       mov       rcx,[rsi+8]
       call      qword ptr [7FFE8C6AC5B8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
M02_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M02_L01
M02_L03:
       cmp       edi,[rbx+14]
       jne       short M02_L06
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L04:
       mov       ecx,1C
       call      qword ptr [7FFE8BEDECD0]
       int       3
M02_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M02_L02
M02_L06:
       call      qword ptr [7FFE8BEDEFB8]
       int       3
M02_L07:
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BEDEF10]
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
       mov       rax,2AD6F270008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       test      rsi,rsi
       je        near ptr M00_L04
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
       xor       r15d,r15d
       mov       r13d,[r14+8]
       test      r13d,r13d
       jle       short M00_L01
       mov       r12,offset MT_System.Object
M00_L00:
       mov       rcx,r12
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,r15d
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L03
       cmp       r13d,r15d
       jg        short M00_L00
M00_L01:
       mov       edx,r13d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
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
       mov       rdx,r15
       lea       rcx,[r12+10]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+1C],1
       mov       eax,[rbp+8]
       xor       edx,edx
       div       r13d
       mov       [rdi+18],eax
       mov       rcx,2BFAE801FC8
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE8C43F198]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C6A3C60
       mov       [rbp+18],rcx
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BD3E3B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rdi+18],0
       je        near ptr M00_L05
M00_L02:
       mov       [rsp+20],rdi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C6AD320]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L03:
       call      CORINFO_HELP_OVERFLOW
M00_L04:
       call      qword ptr [7FFE8C27EDF0]
       mov       ecx,49
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
       mov       eax,[rax+8]
       mov       rdx,[rdi+10]
       mov       rcx,[rdx+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rdi+18],eax
       jmp       near ptr M00_L02
; Total bytes of code 628
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L07
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFE8C7C57A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE8BC84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L02
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE8C7C5858
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BD3DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFE8C7C57B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M01_L07:
       mov       ecx,10
       call      qword ptr [7FFE8BF04F30]
       int       3
; Total bytes of code 215
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
       je        near ptr M02_L04
       mov       edi,[rbx+14]
       xor       ebp,ebp
       cmp       dword ptr [rbx+10],0
       jle       short M02_L03
       mov       rcx,7FFE8C6A3C60
       cmp       [rsi+18],rcx
       jne       short M02_L01
M02_L00:
       cmp       edi,[rbx+14]
       jne       short M02_L03
       mov       r14,[rbx+8]
       cmp       ebp,[r14+8]
       jae       near ptr M02_L07
       mov       ecx,ebp
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [7FFE8C6A7C60]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M02_L00
       jmp       short M02_L03
M02_L01:
       cmp       edi,[rbx+14]
       jne       short M02_L03
       mov       r14,[rbx+8]
       cmp       ebp,[r14+8]
       jae       short M02_L07
       mov       ecx,ebp
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,7FFE8C6A3C60
       cmp       [rsi+18],rcx
       jne       short M02_L05
       mov       rcx,[rsi+8]
       call      qword ptr [7FFE8C6A7C60]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
M02_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M02_L01
M02_L03:
       cmp       edi,[rbx+14]
       jne       short M02_L06
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L04:
       mov       ecx,1C
       call      qword ptr [7FFE8BEDECD0]
       int       3
M02_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M02_L02
M02_L06:
       call      qword ptr [7FFE8BEDEFB8]
       int       3
M02_L07:
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BEDEF10]
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
       mov       rax,30040640008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       test      rsi,rsi
       je        near ptr M00_L04
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
       xor       r15d,r15d
       mov       r13d,[r14+8]
       test      r13d,r13d
       jle       short M00_L01
       mov       r12,offset MT_System.Object
M00_L00:
       mov       rcx,r12
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,r15d
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L03
       cmp       r13d,r15d
       jg        short M00_L00
M00_L01:
       mov       edx,r13d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
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
       mov       rdx,r15
       lea       rcx,[r12+10]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+1C],1
       mov       eax,[rbp+8]
       xor       edx,edx
       div       r13d
       mov       [rdi+18],eax
       mov       rcx,26E04001FC8
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE8C43F108]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C6A3930
       mov       [rbp+18],rcx
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BD3E3B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rdi+18],0
       je        near ptr M00_L05
M00_L02:
       mov       [rsp+20],rdi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C6ACE28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L03:
       call      CORINFO_HELP_OVERFLOW
M00_L04:
       call      qword ptr [7FFE8C27EDF0]
       mov       ecx,49
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
       mov       eax,[rax+8]
       mov       rdx,[rdi+10]
       mov       rcx,[rdx+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rdi+18],eax
       jmp       near ptr M00_L02
; Total bytes of code 628
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L07
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFE8C7C65E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE8BC84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L02
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE8C7C6698
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BD3DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFE8C7C65F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M01_L07:
       mov       ecx,10
       call      qword ptr [7FFE8BF04F30]
       int       3
; Total bytes of code 215
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
       je        near ptr M02_L04
       mov       edi,[rbx+14]
       xor       ebp,ebp
       cmp       dword ptr [rbx+10],0
       jle       short M02_L03
       mov       rcx,7FFE8C6A3930
       cmp       [rsi+18],rcx
       jne       short M02_L01
M02_L00:
       cmp       edi,[rbx+14]
       jne       short M02_L03
       mov       r14,[rbx+8]
       cmp       ebp,[r14+8]
       jae       near ptr M02_L07
       mov       ecx,ebp
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [7FFE8C6A7930]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M02_L00
       jmp       short M02_L03
M02_L01:
       cmp       edi,[rbx+14]
       jne       short M02_L03
       mov       r14,[rbx+8]
       cmp       ebp,[r14+8]
       jae       short M02_L07
       mov       ecx,ebp
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,7FFE8C6A3930
       cmp       [rsi+18],rcx
       jne       short M02_L05
       mov       rcx,[rsi+8]
       call      qword ptr [7FFE8C6A7930]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
M02_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M02_L01
M02_L03:
       cmp       edi,[rbx+14]
       jne       short M02_L06
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L04:
       mov       ecx,1C
       call      qword ptr [7FFE8BEDECD0]
       int       3
M02_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M02_L02
M02_L06:
       call      qword ptr [7FFE8BEDEFB8]
       int       3
M02_L07:
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BEDEF10]
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
       mov       rax,2AE95D50008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       test      rsi,rsi
       je        near ptr M00_L04
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
       xor       r15d,r15d
       mov       r13d,[r14+8]
       test      r13d,r13d
       jle       short M00_L01
       mov       r12,offset MT_System.Object
M00_L00:
       mov       rcx,r12
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,r15d
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L03
       cmp       r13d,r15d
       jg        short M00_L00
M00_L01:
       mov       edx,r13d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
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
       mov       rdx,r15
       lea       rcx,[r12+10]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+1C],1
       mov       eax,[rbp+8]
       xor       edx,edx
       div       r13d
       mov       [rdi+18],eax
       mov       rcx,205D2C01FC8
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE8C42F108]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C693C60
       mov       [rbp+18],rcx
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BD2E3B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rdi+18],0
       je        near ptr M00_L05
M00_L02:
       mov       [rsp+20],rdi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C69D320]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L03:
       call      CORINFO_HELP_OVERFLOW
M00_L04:
       call      qword ptr [7FFE8C26EDF0]
       mov       ecx,49
       mov       rdx,7FFE8C150EC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,100A
       mov       rdx,7FFE8BFF2E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C150EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C26EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
       mov       eax,[rax+8]
       mov       rdx,[rdi+10]
       mov       rcx,[rdx+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rdi+18],eax
       jmp       near ptr M00_L02
; Total bytes of code 628
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L07
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFE8C7B65F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE8BC74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L02
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE8C7B66A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BD2DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFE8C7B6600
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M01_L07:
       mov       ecx,10
       call      qword ptr [7FFE8BEF4F30]
       int       3
; Total bytes of code 215
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
       je        near ptr M02_L04
       mov       edi,[rbx+14]
       xor       ebp,ebp
       cmp       dword ptr [rbx+10],0
       jle       short M02_L03
       mov       r14,[rsi+18]
       mov       rcx,7FFE8C693C60
       cmp       r14,rcx
       jne       short M02_L01
M02_L00:
       cmp       edi,[rbx+14]
       jne       short M02_L03
       mov       r14,[rbx+8]
       cmp       ebp,[r14+8]
       jae       short M02_L07
       mov       ecx,ebp
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [7FFE8C697C60]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M02_L00
       jmp       short M02_L03
M02_L01:
       cmp       edi,[rbx+14]
       jne       short M02_L03
       mov       rcx,[rbx+8]
       cmp       ebp,[rcx+8]
       jae       short M02_L07
       mov       edx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,7FFE8C693C60
       cmp       r14,rcx
       jne       short M02_L05
       mov       rcx,[rsi+8]
       call      qword ptr [7FFE8C697C60]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
M02_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M02_L01
M02_L03:
       cmp       edi,[rbx+14]
       jne       short M02_L06
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L04:
       mov       ecx,1C
       call      qword ptr [7FFE8BECECD0]
       int       3
M02_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M02_L02
M02_L06:
       call      qword ptr [7FFE8BECEFB8]
       int       3
M02_L07:
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
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BECEF10]
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
       mov       rax,24660AD0008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       test      rsi,rsi
       je        near ptr M00_L04
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
       xor       r15d,r15d
       mov       r13d,[r14+8]
       test      r13d,r13d
       jle       short M00_L01
       mov       r12,offset MT_System.Object
M00_L00:
       mov       rcx,r12
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,r15d
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L03
       cmp       r13d,r15d
       jg        short M00_L00
M00_L01:
       mov       edx,r13d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
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
       mov       rdx,r15
       lea       rcx,[r12+10]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+1C],1
       mov       eax,[rbp+8]
       xor       edx,edx
       div       r13d
       mov       [rdi+18],eax
       mov       rcx,1DF24801FC8
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE8C42F108]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C69A538
       mov       [rbp+18],rcx
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BD2E3B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rdi+18],0
       je        near ptr M00_L05
M00_L02:
       mov       [rsp+20],rdi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C69F948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L03:
       call      CORINFO_HELP_OVERFLOW
M00_L04:
       call      qword ptr [7FFE8C26EDF0]
       mov       ecx,49
       mov       rdx,7FFE8C150EC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,100A
       mov       rdx,7FFE8BFF2E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C150EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C26EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
       mov       eax,[rax+8]
       mov       rdx,[rdi+10]
       mov       rcx,[rdx+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rdi+18],eax
       jmp       near ptr M00_L02
; Total bytes of code 628
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L07
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFE8C7BA660
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE8BC74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L02
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE8C7BA710
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BD2DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFE8C7BA670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M01_L07:
       mov       ecx,10
       call      qword ptr [7FFE8BEF4F30]
       int       3
; Total bytes of code 215
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
       je        near ptr M02_L04
       mov       edi,[rbx+14]
       xor       ebp,ebp
       cmp       dword ptr [rbx+10],0
       jle       short M02_L03
       mov       r14,[rsi+18]
       mov       rcx,7FFE8C69A538
       cmp       r14,rcx
       jne       short M02_L01
M02_L00:
       cmp       edi,[rbx+14]
       jne       short M02_L03
       mov       r14,[rbx+8]
       cmp       ebp,[r14+8]
       jae       short M02_L07
       mov       ecx,ebp
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [7FFE8C69E538]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M02_L00
       jmp       short M02_L03
M02_L01:
       cmp       edi,[rbx+14]
       jne       short M02_L03
       mov       rcx,[rbx+8]
       cmp       ebp,[rcx+8]
       jae       short M02_L07
       mov       edx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,7FFE8C69A538
       cmp       r14,rcx
       jne       short M02_L05
       mov       rcx,[rsi+8]
       call      qword ptr [7FFE8C69E538]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
M02_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M02_L01
M02_L03:
       cmp       edi,[rbx+14]
       jne       short M02_L06
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L04:
       mov       ecx,1C
       call      qword ptr [7FFE8BECECD0]
       int       3
M02_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M02_L02
M02_L06:
       call      qword ptr [7FFE8BECEFB8]
       int       3
M02_L07:
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
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BECEF10]
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
       mov       rax,21FB6730008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       test      rsi,rsi
       je        near ptr M00_L04
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
       xor       r15d,r15d
       mov       r13d,[r14+8]
       test      r13d,r13d
       jle       short M00_L01
       mov       r12,offset MT_System.Object
M00_L00:
       mov       rcx,r12
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,r15d
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L03
       cmp       r13d,r15d
       jg        short M00_L00
M00_L01:
       mov       edx,r13d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
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
       mov       rdx,r15
       lea       rcx,[r12+10]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+1C],1
       mov       eax,[rbp+8]
       xor       edx,edx
       div       r13d
       mov       [rdi+18],eax
       mov       rcx,1DC2B001FF0
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE8C44F108]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C7192A8
       mov       [rbp+18],rcx
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BD4E3B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rdi+18],0
       je        near ptr M00_L05
M00_L02:
       mov       [rsp+20],rdi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C71E6D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L03:
       call      CORINFO_HELP_OVERFLOW
M00_L04:
       call      qword ptr [7FFE8C28EDF0]
       mov       ecx,49
       mov       rdx,7FFE8C170EC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,100A
       mov       rdx,7FFE8C012E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C170EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C28EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
       mov       eax,[rax+8]
       mov       rdx,[rdi+10]
       mov       rcx,[rdx+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rdi+18],eax
       jmp       near ptr M00_L02
; Total bytes of code 628
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L07
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFE8C7F1248
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE8BC94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L02
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE8C7F12F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BD4DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFE8C7F1258
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M01_L07:
       mov       ecx,10
       call      qword ptr [7FFE8BF14F30]
       int       3
; Total bytes of code 215
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
       je        near ptr M02_L04
       mov       edi,[rbx+14]
       xor       ebp,ebp
       cmp       dword ptr [rbx+10],0
       jle       short M02_L03
       mov       r14,[rsi+18]
       mov       rcx,7FFE8C7192A8
       cmp       r14,rcx
       jne       short M02_L01
M02_L00:
       cmp       edi,[rbx+14]
       jne       short M02_L03
       mov       r14,[rbx+8]
       cmp       ebp,[r14+8]
       jae       short M02_L07
       mov       ecx,ebp
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [7FFE8C71D2A8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M02_L00
       jmp       short M02_L03
M02_L01:
       cmp       edi,[rbx+14]
       jne       short M02_L03
       mov       rcx,[rbx+8]
       cmp       ebp,[rcx+8]
       jae       short M02_L07
       mov       edx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,7FFE8C7192A8
       cmp       r14,rcx
       jne       short M02_L05
       mov       rcx,[rsi+8]
       call      qword ptr [7FFE8C71D2A8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
M02_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M02_L01
M02_L03:
       cmp       edi,[rbx+14]
       jne       short M02_L06
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L04:
       mov       ecx,1C
       call      qword ptr [7FFE8BEEECD0]
       int       3
M02_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M02_L02
M02_L06:
       call      qword ptr [7FFE8BEEEFB8]
       int       3
M02_L07:
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BEEEF10]
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
       mov       rax,21CB9050008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       test      rsi,rsi
       je        near ptr M00_L04
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
       xor       r15d,r15d
       mov       r13d,[r14+8]
       test      r13d,r13d
       jle       short M00_L01
       mov       r12,offset MT_System.Object
M00_L00:
       mov       rcx,r12
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,r15d
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L03
       cmp       r13d,r15d
       jg        short M00_L00
M00_L01:
       mov       edx,r13d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
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
       mov       rdx,r15
       lea       rcx,[r12+10]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+1C],1
       mov       eax,[rbp+8]
       xor       edx,edx
       div       r13d
       mov       [rdi+18],eax
       mov       rcx,220F5801FF8
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE8C42F108]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C70A490
       mov       [rbp+18],rcx
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BD2E3B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rdi+18],0
       je        near ptr M00_L05
M00_L02:
       mov       [rsp+20],rdi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C70F8B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L03:
       call      CORINFO_HELP_OVERFLOW
M00_L04:
       call      qword ptr [7FFE8C26EDF0]
       mov       ecx,49
       mov       rdx,7FFE8C150EC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,100A
       mov       rdx,7FFE8BFF2E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C150EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C26EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
       mov       eax,[rax+8]
       mov       rdx,[rdi+10]
       mov       rcx,[rdx+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rdi+18],eax
       jmp       near ptr M00_L02
; Total bytes of code 628
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L07
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFE8C7CDCB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE8BC74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L02
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE8C7CDD68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BD2DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFE8C7CDCC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M01_L07:
       mov       ecx,10
       call      qword ptr [7FFE8BEF4F30]
       int       3
; Total bytes of code 215
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
       je        near ptr M02_L04
       mov       edi,[rbx+14]
       xor       ebp,ebp
       cmp       dword ptr [rbx+10],0
       jle       short M02_L03
       mov       r14,[rsi+18]
       mov       rcx,7FFE8C70A490
       cmp       r14,rcx
       jne       short M02_L01
M02_L00:
       cmp       edi,[rbx+14]
       jne       short M02_L03
       mov       r14,[rbx+8]
       cmp       ebp,[r14+8]
       jae       short M02_L07
       mov       ecx,ebp
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [7FFE8C70E490]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M02_L00
       jmp       short M02_L03
M02_L01:
       cmp       edi,[rbx+14]
       jne       short M02_L03
       mov       rcx,[rbx+8]
       cmp       ebp,[rcx+8]
       jae       short M02_L07
       mov       edx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,7FFE8C70A490
       cmp       r14,rcx
       jne       short M02_L05
       mov       rcx,[rsi+8]
       call      qword ptr [7FFE8C70E490]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
M02_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M02_L01
M02_L03:
       cmp       edi,[rbx+14]
       jne       short M02_L06
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L04:
       mov       ecx,1C
       call      qword ptr [7FFE8BECECD0]
       int       3
M02_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M02_L02
M02_L06:
       call      qword ptr [7FFE8BECEFB8]
       int       3
M02_L07:
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
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BECEF10]
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
       mov       rax,261877C0008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       test      rsi,rsi
       je        near ptr M00_L04
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
       xor       r15d,r15d
       mov       r13d,[r14+8]
       test      r13d,r13d
       jle       short M00_L01
       mov       r12,offset MT_System.Object
M00_L00:
       mov       rcx,r12
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,r15d
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L03
       cmp       r13d,r15d
       jg        short M00_L00
M00_L01:
       mov       edx,r13d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
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
       mov       rdx,r15
       lea       rcx,[r12+10]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+1C],1
       mov       eax,[rbp+8]
       xor       edx,edx
       div       r13d
       mov       [rdi+18],eax
       mov       rcx,1D187801FF8
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.ToList[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE8C45F108]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C7392A8
       mov       [rbp+18],rcx
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BD5E3B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rdi+18],0
       je        near ptr M00_L05
M00_L02:
       mov       [rsp+20],rdi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C73E6D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L03:
       call      CORINFO_HELP_OVERFLOW
M00_L04:
       call      qword ptr [7FFE8C29EDF0]
       mov       ecx,49
       mov       rdx,7FFE8C180EC8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C180EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C29EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
       mov       eax,[rax+8]
       mov       rdx,[rdi+10]
       mov       rcx,[rdx+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rdi+18],eax
       jmp       near ptr M00_L02
; Total bytes of code 628
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L07
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFE8C810C90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE8BCA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L02
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE8C810D40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BD5DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FFE8C810CA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M01_L07:
       mov       ecx,10
       call      qword ptr [7FFE8BF24F30]
       int       3
; Total bytes of code 215
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
       je        near ptr M02_L04
       mov       edi,[rbx+14]
       xor       ebp,ebp
       cmp       dword ptr [rbx+10],0
       jle       short M02_L03
       mov       r14,[rsi+18]
       mov       rcx,7FFE8C7392A8
       cmp       r14,rcx
       jne       short M02_L01
M02_L00:
       cmp       edi,[rbx+14]
       jne       short M02_L03
       mov       r14,[rbx+8]
       cmp       ebp,[r14+8]
       jae       short M02_L07
       mov       ecx,ebp
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [7FFE8C73D2A8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M02_L00
       jmp       short M02_L03
M02_L01:
       cmp       edi,[rbx+14]
       jne       short M02_L03
       mov       rcx,[rbx+8]
       cmp       ebp,[rcx+8]
       jae       short M02_L07
       mov       edx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,7FFE8C7392A8
       cmp       r14,rcx
       jne       short M02_L05
       mov       rcx,[rsi+8]
       call      qword ptr [7FFE8C73D2A8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
M02_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M02_L01
M02_L03:
       cmp       edi,[rbx+14]
       jne       short M02_L06
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L04:
       mov       ecx,1C
       call      qword ptr [7FFE8BEFECD0]
       int       3
M02_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M02_L02
M02_L06:
       call      qword ptr [7FFE8BEFEFB8]
       int       3
M02_L07:
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
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BEFEF10]
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
       mov       rax,21215640008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       r8,[rbx+198]
       test      r8,r8
       je        near ptr M00_L03
       mov       r9,29C00011868
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
       call      qword ptr [7FFE8C6AD5A8]; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
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
       mov       rdx,29C00011870
       mov       rdx,[rdx]
       mov       rcx,r14
       call      qword ptr [7FFE8C6AEC28]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+20],ebp
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,29C00001FE8
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
       call      qword ptr [7FFE8C6E5308]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       call      qword ptr [7FFE8C27EDF0]
       mov       ecx,49
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rdx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C6AD3E0]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L05:
       jmp       near ptr M00_L02
M00_L06:
       mov       ecx,45F
       mov       rdx,7FFE8C6B2760
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8C6AEDA8]
       int       3
M00_L07:
       mov       ecx,469
       mov       rdx,7FFE8C6B2760
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8C6AEDA8]
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
       mov       rdx,[rcx+0C8]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,r14
       mov       rdx,7FFE8C7E7EC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       lea       rcx,[rbp-150]
       mov       r8,rsi
       call      qword ptr [7FFE8C6AF648]; System.Collections.Immutable.ImmutableExtensions.GetEnumerableDisposable[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rdi,[rbp-0C8]
       lea       rsi,[rbp-150]
       mov       ecx,11
       rep movsq
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rsi,[rcx+0D0]
       test      rsi,rsi
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,7FFE8C7E7F80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L04:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFE8C6AF5E8]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       je        near ptr M01_L20
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdi,[rcx+0E0]
       test      rdi,rdi
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,r14
       mov       rdx,7FFE8C7E7FB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M01_L06:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFE8C6AF5D0]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].get_Current()
       mov       [rbp-1B8],rax
       test      rax,rax
       je        near ptr M01_L19
       mov       rax,[rbp-1B8]
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0D8]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,r14
       mov       rdx,7FFE8C7E7FA0
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
       cmp       qword ptr [rax+8],0
       je        near ptr M01_L17
       mov       r8d,[rax+18]
       cmp       edx,r8d
       je        near ptr M01_L16
       jle       short M01_L11
       mov       rax,[rax+10]
       mov       edx,[rbp-154]
       jmp       short M01_L10
M01_L11:
       mov       rax,[rax+8]
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
       call      qword ptr [7FFE8C6AEBC8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetItem(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean ByRef, Boolean ByRef)
       mov       r12,rax
M01_L13:
       inc       r13d
M01_L14:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFE8C6AF5E8]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L06
       jmp       near ptr M01_L20
M01_L15:
       lea       r8,[rbp-198]
       mov       rcx,r12
       mov       edx,[rbp-154]
       call      qword ptr [7FFE8C6AED18]
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
       call      qword ptr [7FFE8C6AD980]; System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, OperationResult<System.__Canon> ByRef)
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
       mov       rax,[rcx+0E8]
       test      rax,rax
       je        short M01_L21
       jmp       short M01_L22
M01_L21:
       mov       rcx,r14
       mov       rdx,7FFE8C7E7FE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L22:
       lea       rcx,[rbp-0C8]
       call      rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-190],xmm0
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdx,[rcx+0B0]
       test      rdx,rdx
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rcx,r14
       mov       rdx,7FFE8C7E5E10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L24:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-190]
       mov       r8,r12
       mov       r9d,r13d
       call      qword ptr [7FFE8C6AF480]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
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
       mov       ecx,48B
       mov       rdx,7FFE8C6B2760
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8C6AEDA8]
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
       mov       rax,[rdx+0E8]
       test      rax,rax
       je        short M01_L26
       jmp       short M01_L27
M01_L26:
       mov       rdx,7FFE8C7E7FE0
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
; Total bytes of code 1064
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
       je        short M02_L02
M02_L01:
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L02:
       test      rsi,rsi
       je        short M02_L03
       mov       ecx,[rbx+18]
       mov       rdx,[rbx+20]
       mov       rax,[rbx+28]
       mov       [rsp+20],ecx
       mov       [rsp+28],rdx
       mov       [rsp+30],rax
       mov       rcx,7FFE8C6AB258
       cmp       [rsi+18],rcx
       jne       short M02_L04
       mov       rcx,[rsi+8]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFE8C6AF258]; System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
M02_L03:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C6AEC28]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C6AEC28]
       mov       byte ptr [rbx+1C],1
       jmp       short M02_L01
M02_L04:
       lea       rdx,[rsp+20]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M02_L03
; Total bytes of code 153
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BEDEF10]
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
       mov       rax,2DC91ED0008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       r8,[rbx+198]
       test      r8,r8
       je        near ptr M00_L03
       mov       r9,1AB2A411868
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
       call      qword ptr [7FFE8C6CD5A8]; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
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
       mov       rdx,1AB2A411870
       mov       rdx,[rdx]
       mov       rcx,r14
       call      qword ptr [7FFE8C6CEC28]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+20],ebp
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1AB2A401FE8
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
       call      qword ptr [7FFE8C705308]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       call      qword ptr [7FFE8C29EDF0]
       mov       ecx,49
       mov       rdx,7FFE8C180EC8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C180EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C29EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rdx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C6CD3E0]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L05:
       jmp       near ptr M00_L02
M00_L06:
       mov       ecx,45F
       mov       rdx,7FFE8C6D2760
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8C6CEDA8]
       int       3
M00_L07:
       mov       ecx,469
       mov       rdx,7FFE8C6D2760
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8C6CEDA8]
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
       mov       rdx,[rcx+0F0]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,r14
       mov       rdx,7FFE8C808CE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       lea       rcx,[rbp-150]
       mov       r8,rsi
       call      qword ptr [7FFE8C6CF648]; System.Collections.Immutable.ImmutableExtensions.GetEnumerableDisposable[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rdi,[rbp-0C8]
       lea       rsi,[rbp-150]
       mov       ecx,11
       rep movsq
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rsi,[rcx+0F8]
       test      rsi,rsi
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,7FFE8C808DA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L04:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFE8C6CF5E8]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       je        near ptr M01_L19
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdi,[rcx+108]
       test      rdi,rdi
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,r14
       mov       rdx,7FFE8C808DD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M01_L06:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFE8C6CF5D0]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].get_Current()
       mov       [rbp-1B8],rax
       test      rax,rax
       je        near ptr M01_L16
       mov       rax,[rbp-1B8]
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+100]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,r14
       mov       rdx,7FFE8C808DC0
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
       jg        short M01_L11
       mov       rax,r8
       mov       edx,[rbp-154]
       jmp       short M01_L10
M01_L11:
       mov       rax,[rax+10]
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
       call      qword ptr [7FFE8C6CD980]; System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, OperationResult<System.__Canon> ByRef)
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
       call      qword ptr [7FFE8C6CEBC8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetItem(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean ByRef, Boolean ByRef)
       mov       r12,rax
M01_L14:
       inc       r13d
M01_L15:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFE8C6CF5E8]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
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
       call      qword ptr [7FFE8C6CED18]
       mov       r12,rax
       jmp       short M01_L14
M01_L19:
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+110]
       test      rax,rax
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,r14
       mov       rdx,7FFE8C808E00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L21:
       lea       rcx,[rbp-0C8]
       call      rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-190],xmm0
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdx,[rcx+0E0]
       test      rdx,rdx
       je        short M01_L22
       jmp       short M01_L23
M01_L22:
       mov       rcx,r14
       mov       rdx,7FFE8C807E60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L23:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-190]
       mov       r8,r12
       mov       r9d,r13d
       call      qword ptr [7FFE8C6CF480]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
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
       mov       ecx,48B
       mov       rdx,7FFE8C6D2760
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8C6CEDA8]
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
       mov       rax,[rdx+110]
       test      rax,rax
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rdx,7FFE8C808E00
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
       mov       rcx,7FFE8C6CB258
       cmp       [rsi+18],rcx
       jne       short M02_L03
       mov       rcx,[rsi+8]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFE8C6CF258]; System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
M02_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C6CEC28]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C6CEC28]
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
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BEFEF10]
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
       mov       rax,1EBBC4B0008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       r8,[rbx+198]
       test      r8,r8
       je        near ptr M00_L03
       mov       r9,21357C11868
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
       call      qword ptr [7FFE8C6AE178]; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
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
       mov       rdx,21357C11870
       mov       rdx,[rdx]
       mov       rcx,r14
       call      qword ptr [7FFE8C6AF7F8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+20],ebp
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,21357C01FE8
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
       call      qword ptr [7FFE8C6E5CF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       call      qword ptr [7FFE8C27EDF0]
       mov       ecx,49
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rdx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C6ADFB0]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L05:
       jmp       near ptr M00_L02
M00_L06:
       mov       ecx,45F
       mov       rdx,7FFE8C6B5740
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8C6AF978]
       int       3
M00_L07:
       mov       ecx,469
       mov       rdx,7FFE8C6B5740
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8C6AF978]
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
       mov       rdx,[rcx+0F0]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,r14
       mov       rdx,7FFE8C7F87F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       lea       rcx,[rbp-150]
       mov       r8,rsi
       call      qword ptr [7FFE8C6E4240]; System.Collections.Immutable.ImmutableExtensions.GetEnumerableDisposable[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rdi,[rbp-0C8]
       lea       rsi,[rbp-150]
       mov       ecx,11
       rep movsq
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rsi,[rcx+0F8]
       test      rsi,rsi
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,7FFE8C7F88B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L04:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFE8C6E41E0]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       je        near ptr M01_L19
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdi,[rcx+108]
       test      rdi,rdi
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,r14
       mov       rdx,7FFE8C7F88E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M01_L06:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFE8C6E41C8]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].get_Current()
       mov       [rbp-1B8],rax
       test      rax,rax
       je        near ptr M01_L16
       mov       rax,[rbp-1B8]
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+100]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,r14
       mov       rdx,7FFE8C7F88D0
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
       jg        short M01_L11
       mov       rax,r8
       mov       edx,[rbp-154]
       jmp       short M01_L10
M01_L11:
       mov       rax,[rax+10]
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
       call      qword ptr [7FFE8C6AE550]; System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, OperationResult<System.__Canon> ByRef)
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
       call      qword ptr [7FFE8C6AF798]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetItem(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean ByRef, Boolean ByRef)
       mov       r12,rax
M01_L14:
       inc       r13d
M01_L15:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFE8C6E41E0]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
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
       call      qword ptr [7FFE8C6AF8E8]
       mov       r12,rax
       jmp       short M01_L14
M01_L19:
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+110]
       test      rax,rax
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,r14
       mov       rdx,7FFE8C7F8910
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L21:
       lea       rcx,[rbp-0C8]
       call      rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-190],xmm0
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdx,[rcx+0E0]
       test      rdx,rdx
       je        short M01_L22
       jmp       short M01_L23
M01_L22:
       mov       rcx,r14
       mov       rdx,7FFE8C7F7970
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L23:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-190]
       mov       r8,r12
       mov       r9d,r13d
       call      qword ptr [7FFE8C6E4078]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
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
       mov       ecx,48B
       mov       rdx,7FFE8C6B5740
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8C6AF978]
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
       mov       rax,[rdx+110]
       test      rax,rax
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rdx,7FFE8C7F8910
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
       mov       rcx,7FFE8C6ABE28
       cmp       [rsi+18],rcx
       jne       short M02_L03
       mov       rcx,[rsi+8]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFE8C6AFE28]; System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
M02_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C6AF7F8]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C6AF7F8]
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BEDEF10]
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
       mov       rax,253E9AB0008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       r8,[rbx+198]
       test      r8,r8
       je        near ptr M00_L03
       mov       r9,21DB4011868
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
       call      qword ptr [7FFE8C6DD860]; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
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
       mov       rdx,21DB4011870
       mov       rdx,[rdx]
       mov       rcx,r14
       call      qword ptr [7FFE8C6DEEE0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+20],ebp
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,21DB4001FE8
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
       call      qword ptr [7FFE8C705A88]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       call      qword ptr [7FFE8C2AEDF0]
       mov       ecx,49
       mov       rdx,7FFE8C190EC8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFE8C032E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BCB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C190EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C2AEBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF36670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rdx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C6DD698]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L05:
       jmp       near ptr M00_L02
M00_L06:
       mov       ecx,45F
       mov       rdx,7FFE8C6E26B0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8C6DF060]
       int       3
M00_L07:
       mov       ecx,469
       mov       rdx,7FFE8C6E26B0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8C6DF060]
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
       mov       rdx,[rcx+0C8]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,r14
       mov       rdx,7FFE8C828508
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       lea       rcx,[rbp-150]
       mov       r8,rsi
       call      qword ptr [7FFE8C6DF900]; System.Collections.Immutable.ImmutableExtensions.GetEnumerableDisposable[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rdi,[rbp-0C8]
       lea       rsi,[rbp-150]
       mov       ecx,11
       rep movsq
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rsi,[rcx+0D0]
       test      rsi,rsi
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,7FFE8C8285C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L04:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFE8C6DF8A0]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       je        near ptr M01_L19
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdi,[rcx+0E0]
       test      rdi,rdi
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,r14
       mov       rdx,7FFE8C828600
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M01_L06:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFE8C6DF888]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].get_Current()
       mov       [rbp-1B8],rax
       test      rax,rax
       je        near ptr M01_L16
       mov       rax,[rbp-1B8]
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0D8]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,r14
       mov       rdx,7FFE8C8285E8
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
       call      qword ptr [7FFE8C6DDC38]; System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, OperationResult<System.__Canon> ByRef)
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
       call      qword ptr [7FFE8C6DEE80]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetItem(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean ByRef, Boolean ByRef)
       mov       r12,rax
M01_L14:
       inc       r13d
M01_L15:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFE8C6DF8A0]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
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
       call      qword ptr [7FFE8C6DEFD0]
       mov       r12,rax
       jmp       short M01_L14
M01_L19:
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+0E8]
       test      rax,rax
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,r14
       mov       rdx,7FFE8C828628
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L21:
       lea       rcx,[rbp-0C8]
       call      rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-190],xmm0
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdx,[rcx+0B0]
       test      rdx,rdx
       je        short M01_L22
       jmp       short M01_L23
M01_L22:
       mov       rcx,r14
       mov       rdx,7FFE8C826458
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L23:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-190]
       mov       r8,r12
       mov       r9d,r13d
       call      qword ptr [7FFE8C6DF738]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
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
       mov       ecx,48B
       mov       rdx,7FFE8C6E26B0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8C6DF060]
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
       mov       rax,[rdx+0E8]
       test      rax,rax
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rdx,7FFE8C828628
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
       mov       rcx,7FFE8C6DB510
       cmp       [rsi+18],rcx
       jne       short M02_L03
       mov       rcx,[rsi+8]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFE8C6DF510]; System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
M02_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C6DEEE0]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C6DEEE0]
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
       call      qword ptr [7FFE8BD65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BF0EF10]
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
       mov       rax,25E45F50008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       r8,[rbx+198]
       test      r8,r8
       je        near ptr M00_L03
       mov       r9,2C08D406CC8
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
       call      qword ptr [7FFE8C6BE9A0]; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
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
       mov       rdx,2C08D406CD0
       mov       rdx,[rdx]
       mov       rcx,r14
       call      qword ptr [7FFE8C704180]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+20],ebp
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2C089401FE8
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
       call      qword ptr [7FFE8C706658]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       call      qword ptr [7FFE8C29EDF0]
       mov       ecx,49
       mov       rdx,7FFE8C180EC8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C180EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C29EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rdx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C6BE7D8]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L05:
       jmp       near ptr M00_L02
M00_L06:
       mov       ecx,45F
       mov       rdx,7FFE8C6D5F08
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8C704300]
       int       3
M00_L07:
       mov       ecx,469
       mov       rdx,7FFE8C6D5F08
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8C704300]
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
       mov       rdx,[rcx+0C8]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,r14
       mov       rdx,7FFE8C830F60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       lea       rcx,[rbp-150]
       mov       r8,rsi
       call      qword ptr [7FFE8C704BA0]; System.Collections.Immutable.ImmutableExtensions.GetEnumerableDisposable[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rdi,[rbp-0C8]
       lea       rsi,[rbp-150]
       mov       ecx,11
       rep movsq
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rsi,[rcx+0D0]
       test      rsi,rsi
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,7FFE8C831020
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L04:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFE8C704B40]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       je        near ptr M01_L20
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdi,[rcx+0E0]
       test      rdi,rdi
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,r14
       mov       rdx,7FFE8C831058
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M01_L06:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFE8C704B28]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].get_Current()
       mov       [rbp-1B8],rax
       test      rax,rax
       je        near ptr M01_L19
       mov       rax,[rbp-1B8]
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0D8]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,r14
       mov       rdx,7FFE8C831040
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
       jg        short M01_L11
       mov       rax,r8
       mov       edx,[rbp-154]
       jmp       short M01_L10
M01_L11:
       mov       rax,[rax+10]
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
       call      qword ptr [7FFE8C704120]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetItem(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean ByRef, Boolean ByRef)
       mov       r12,rax
M01_L13:
       inc       r13d
M01_L14:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFE8C704B40]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L06
       jmp       near ptr M01_L20
M01_L15:
       lea       r8,[rbp-198]
       mov       rcx,r12
       mov       edx,[rbp-154]
       call      qword ptr [7FFE8C704270]
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
       call      qword ptr [7FFE8C6BED78]; System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, OperationResult<System.__Canon> ByRef)
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
       mov       rax,[rcx+0E8]
       test      rax,rax
       je        short M01_L21
       jmp       short M01_L22
M01_L21:
       mov       rcx,r14
       mov       rdx,7FFE8C831080
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L22:
       lea       rcx,[rbp-0C8]
       call      rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-190],xmm0
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdx,[rcx+0B0]
       test      rdx,rdx
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rcx,r14
       mov       rdx,7FFE8C81ED30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L24:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-190]
       mov       r8,r12
       mov       r9d,r13d
       call      qword ptr [7FFE8C7049D8]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
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
       mov       ecx,48B
       mov       rdx,7FFE8C6D5F08
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8C704300]
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
       mov       rax,[rdx+0E8]
       test      rax,rax
       je        short M01_L26
       jmp       short M01_L27
M01_L26:
       mov       rdx,7FFE8C831080
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
; Total bytes of code 1063
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
       mov       rcx,7FFE8C7007B0
       cmp       [rsi+18],rcx
       jne       short M02_L03
       mov       rcx,[rsi+8]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFE8C7047B0]; System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
M02_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C704180]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C704180]
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
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BEFEF10]
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
       mov       rax,3011B220008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       r8,[rbx+198]
       test      r8,r8
       je        near ptr M00_L03
       mov       r9,23B96C11868
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
       call      qword ptr [7FFE8C70E178]; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
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
       mov       rdx,23B96C11870
       mov       rdx,[rdx]
       mov       rcx,r14
       call      qword ptr [7FFE8C70F7F8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+20],ebp
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,23B96C01FF8
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
       call      qword ptr [7FFE8C745CF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       call      qword ptr [7FFE8C27DE30]
       mov       ecx,49
       mov       rdx,7FFE8C1611E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002F68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C1611E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rdx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C70DFB0]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L05:
       jmp       near ptr M00_L02
M00_L06:
       mov       ecx,45F
       mov       rdx,7FFE8C716890
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8C70F978]
       int       3
M00_L07:
       mov       ecx,469
       mov       rdx,7FFE8C716890
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8C70F978]
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
       mov       rdx,[rcx+0C8]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,r14
       mov       rdx,7FFE8C815F38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       lea       rcx,[rbp-150]
       mov       r8,rsi
       call      qword ptr [7FFE8C744240]; System.Collections.Immutable.ImmutableExtensions.GetEnumerableDisposable[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rdi,[rbp-0C8]
       lea       rsi,[rbp-150]
       mov       ecx,11
       rep movsq
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rsi,[rcx+0D0]
       test      rsi,rsi
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,7FFE8C815FF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L04:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFE8C7441E0]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       je        near ptr M01_L20
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdi,[rcx+0E0]
       test      rdi,rdi
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,r14
       mov       rdx,7FFE8C816030
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M01_L06:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFE8C7441C8]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].get_Current()
       mov       [rbp-1B8],rax
       test      rax,rax
       je        near ptr M01_L19
       mov       rax,[rbp-1B8]
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0D8]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,r14
       mov       rdx,7FFE8C816018
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
       call      qword ptr [7FFE8C70F798]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetItem(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean ByRef, Boolean ByRef)
       mov       r12,rax
M01_L13:
       inc       r13d
M01_L14:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFE8C7441E0]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L06
       jmp       near ptr M01_L20
M01_L15:
       lea       r8,[rbp-198]
       mov       rcx,r12
       mov       edx,[rbp-154]
       call      qword ptr [7FFE8C70F8E8]
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
       call      qword ptr [7FFE8C70E550]; System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, OperationResult<System.__Canon> ByRef)
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
       mov       rax,[rcx+0E8]
       test      rax,rax
       je        short M01_L21
       jmp       short M01_L22
M01_L21:
       mov       rcx,r14
       mov       rdx,7FFE8C816058
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L22:
       lea       rcx,[rbp-0C8]
       call      rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-190],xmm0
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdx,[rcx+0B0]
       test      rdx,rdx
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rcx,r14
       mov       rdx,7FFE8C813E88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L24:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-190]
       mov       r8,r12
       mov       r9d,r13d
       call      qword ptr [7FFE8C744078]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
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
       mov       ecx,48B
       mov       rdx,7FFE8C716890
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8C70F978]
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
       mov       rax,[rdx+0E8]
       test      rax,rax
       je        short M01_L26
       jmp       short M01_L27
M01_L26:
       mov       rdx,7FFE8C816058
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
; Total bytes of code 1063
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
       mov       rcx,7FFE8C70BE28
       cmp       [rsi+18],rcx
       jne       short M02_L03
       mov       rcx,[rsi+8]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFE8C70FE28]; System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
M02_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C70F7F8]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C70F7F8]
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BEDEF10]
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
       mov       rax,27C28C80008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       r8,[rbx+198]
       test      r8,r8
       je        near ptr M00_L03
       mov       r9,266A1C11868
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
       call      qword ptr [7FFE8C74E178]; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
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
       mov       rdx,266A1C11870
       mov       rdx,[rdx]
       mov       rcx,r14
       call      qword ptr [7FFE8C74F7F8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+20],ebp
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,266A1C02010
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
       call      qword ptr [7FFE8C775CF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       call      qword ptr [7FFE8C29DE30]
       mov       ecx,49
       mov       rdx,7FFE8C1811E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022F68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C1811E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C29DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rdx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C74DFB0]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L05:
       jmp       near ptr M00_L02
M00_L06:
       mov       ecx,45F
       mov       rdx,7FFE8C738BB0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8C74F978]
       int       3
M00_L07:
       mov       ecx,469
       mov       rdx,7FFE8C738BB0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8C74F978]
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
       mov       rdx,[rcx+0C8]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,r14
       mov       rdx,7FFE8C860808
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       lea       rcx,[rbp-150]
       mov       r8,rsi
       call      qword ptr [7FFE8C774240]; System.Collections.Immutable.ImmutableExtensions.GetEnumerableDisposable[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rdi,[rbp-0C8]
       lea       rsi,[rbp-150]
       mov       ecx,11
       rep movsq
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rsi,[rcx+0D0]
       test      rsi,rsi
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,7FFE8C8608C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L04:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFE8C7741E0]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       je        near ptr M01_L19
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdi,[rcx+0E0]
       test      rdi,rdi
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,r14
       mov       rdx,7FFE8C860900
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M01_L06:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFE8C7741C8]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].get_Current()
       mov       [rbp-1B8],rax
       test      rax,rax
       je        near ptr M01_L16
       mov       rax,[rbp-1B8]
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0D8]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,r14
       mov       rdx,7FFE8C8608E8
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
       call      qword ptr [7FFE8C74E550]; System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, OperationResult<System.__Canon> ByRef)
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
       call      qword ptr [7FFE8C74F798]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetItem(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean ByRef, Boolean ByRef)
       mov       r12,rax
M01_L14:
       inc       r13d
M01_L15:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFE8C7741E0]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
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
       call      qword ptr [7FFE8C74F8E8]
       mov       r12,rax
       jmp       short M01_L14
M01_L19:
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+0E8]
       test      rax,rax
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,r14
       mov       rdx,7FFE8C860928
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L21:
       lea       rcx,[rbp-0C8]
       call      rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-190],xmm0
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdx,[rcx+0B0]
       test      rdx,rdx
       je        short M01_L22
       jmp       short M01_L23
M01_L22:
       mov       rcx,r14
       mov       rdx,7FFE8C82E748
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L23:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-190]
       mov       r8,r12
       mov       r9d,r13d
       call      qword ptr [7FFE8C774078]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
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
       mov       ecx,48B
       mov       rdx,7FFE8C738BB0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8C74F978]
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
       mov       rax,[rdx+0E8]
       test      rax,rax
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rdx,7FFE8C860928
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
       mov       rcx,7FFE8C74BE28
       cmp       [rsi+18],rcx
       jne       short M02_L03
       mov       rcx,[rsi+8]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFE8C74FE28]; System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
M02_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C74F7F8]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C74F7F8]
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
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BEFEF10]
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
       mov       rax,2A733CE0008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       r8,[rbx+198]
       test      r8,r8
       je        near ptr M00_L03
       mov       r9,1690DC0F870
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
       call      qword ptr [7FFE8C70E9A0]; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
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
       mov       rdx,1690DC0F878
       mov       rdx,[rdx]
       mov       rcx,r14
       call      qword ptr [7FFE8C744180]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+20],ebp
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1690DC0F880
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
       call      qword ptr [7FFE8C746658]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       call      qword ptr [7FFE8C26DE30]
       mov       ecx,49
       mov       rdx,7FFE8C1511E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFE8BFF2F68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C1511E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C26DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rdx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C70E7D8]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L05:
       jmp       near ptr M00_L02
M00_L06:
       mov       ecx,45F
       mov       rdx,7FFE8C718BB0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8C744300]
       int       3
M00_L07:
       mov       ecx,469
       mov       rdx,7FFE8C718BB0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8C744300]
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
       mov       rdx,[rcx+0C8]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,r14
       mov       rdx,7FFE8C831708
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       lea       rcx,[rbp-150]
       mov       r8,rsi
       call      qword ptr [7FFE8C744BA0]; System.Collections.Immutable.ImmutableExtensions.GetEnumerableDisposable[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rdi,[rbp-0C8]
       lea       rsi,[rbp-150]
       mov       ecx,11
       rep movsq
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rsi,[rcx+0D0]
       test      rsi,rsi
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,7FFE8C8317C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L04:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFE8C744B40]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       je        near ptr M01_L20
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdi,[rcx+0E0]
       test      rdi,rdi
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,r14
       mov       rdx,7FFE8C831800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M01_L06:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFE8C744B28]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].get_Current()
       mov       [rbp-1B8],rax
       test      rax,rax
       je        near ptr M01_L17
       mov       rax,[rbp-1B8]
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0D8]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,r14
       mov       rdx,7FFE8C8317E8
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
       je        near ptr M01_L18
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
       call      qword ptr [7FFE8C744120]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetItem(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean ByRef, Boolean ByRef)
       mov       r12,rax
M01_L13:
       inc       r13d
M01_L14:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFE8C744B40]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L06
       jmp       near ptr M01_L20
M01_L15:
       lea       r8,[rbp-198]
       mov       rcx,r12
       mov       edx,[rbp-154]
       call      qword ptr [7FFE8C744270]
       mov       r12,rax
       jmp       short M01_L13
M01_L16:
       mov       r10,[rax+20]
       mov       r11,[rax+28]
       jmp       short M01_L19
M01_L17:
       mov       rax,[rbp-1B8]
       xor       r8d,r8d
       mov       eax,r8d
       jmp       near ptr M01_L09
M01_L18:
       xor       r10d,r10d
       xor       r11d,r11d
M01_L19:
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
       call      qword ptr [7FFE8C70ED78]; System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, OperationResult<System.__Canon> ByRef)
       cmp       dword ptr [rbp-170],0
       jne       near ptr M01_L14
       mov       r9,[rbx+10]
       mov       rax,[rbp-180]
       mov       r8,[rbp-178]
       test      r8,r8
       je        near ptr M01_L15
       jmp       near ptr M01_L12
M01_L20:
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+0E8]
       test      rax,rax
       je        short M01_L21
       jmp       short M01_L22
M01_L21:
       mov       rcx,r14
       mov       rdx,7FFE8C831828
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L22:
       lea       rcx,[rbp-0C8]
       call      rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-190],xmm0
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdx,[rcx+0B0]
       test      rdx,rdx
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rcx,r14
       mov       rdx,7FFE8C7FF5F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L24:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-190]
       mov       r8,r12
       mov       r9d,r13d
       call      qword ptr [7FFE8C7449D8]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
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
       mov       ecx,48B
       mov       rdx,7FFE8C718BB0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8C744300]
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
       mov       rax,[rdx+0E8]
       test      rax,rax
       je        short M01_L26
       jmp       short M01_L27
M01_L26:
       mov       rdx,7FFE8C831828
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
; Total bytes of code 1063
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
       mov       rcx,7FFE8C7407B0
       cmp       [rsi+18],rcx
       jne       short M02_L03
       mov       rcx,[rsi+8]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFE8C7447B0]; System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
M02_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C744180]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C744180]
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
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BECEF10]
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
       mov       rax,1A99FC00008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.Upsert()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       mov       r8,[rbx+1A0]
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE8C695F38]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FFE8BF46C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BF2D6E8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BF46F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FFE8C26EDF0]
       mov       ecx,49
       mov       rdx,7FFE8C150EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8BFF2E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C150EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C26EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FFE8C26EDF0]
       mov       ecx,267
       mov       rdx,7FFE8C150EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8BFF2E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C150EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C26EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.Upsert()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       mov       r8,[rbx+1A0]
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE8C6A7228]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FFE8BF56C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BF3D6E8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BF56F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FFE8C27EDF0]
       mov       ecx,49
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FFE8C27EDF0]
       mov       ecx,267
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.Upsert()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       mov       r8,[rbx+1A0]
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE8C695D88]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FFE8BF46C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BF2D6E8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BF46F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FFE8C26EDF0]
       mov       ecx,49
       mov       rdx,7FFE8C150EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8BFF2E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C150EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C26EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FFE8C26EDF0]
       mov       ecx,267
       mov       rdx,7FFE8C150EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8BFF2E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C150EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C26EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.Upsert()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       mov       r8,[rbx+1A0]
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE8C6C7558]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FFE8BF76C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BF5D6E8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BF76F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FFE8C29EDF0]
       mov       ecx,49
       mov       rdx,7FFE8C180EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C180EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C29EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FFE8C29EDF0]
       mov       ecx,267
       mov       rdx,7FFE8C180EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C180EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C29EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.Upsert()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       mov       r8,[rbx+1A0]
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE8C6AD3E0]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FFE8BF56C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BF3D6E8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BF56F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FFE8C27EDF0]
       mov       ecx,49
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FFE8C27EDF0]
       mov       ecx,267
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C160EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.Upsert()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       mov       r8,[rbx+1A0]
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE8C71CD50]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FFE8BF66C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BF4D6E8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BF66F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FFE8C28EDF0]
       mov       ecx,49
       mov       rdx,7FFE8C170EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C012E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C170EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C28EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FFE8C28EDF0]
       mov       ecx,267
       mov       rdx,7FFE8C170EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C012E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C170EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C28EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.Upsert()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       mov       r8,[rbx+1A0]
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE8C72CD50]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FFE8BF66C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BF4D6E8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BF66F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FFE8C28EDF0]
       mov       ecx,49
       mov       rdx,7FFE8C170EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C012E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C170EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C28EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FFE8C28EDF0]
       mov       ecx,267
       mov       rdx,7FFE8C170EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C012E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C170EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C28EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.Upsert()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       mov       r8,[rbx+1A0]
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE8C73DF38]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FFE8BF76C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BF5D6E8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8BF76F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FFE8C29EDF0]
       mov       ecx,49
       mov       rdx,7FFE8C180EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C180EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C29EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FFE8C29EDF0]
       mov       ecx,267
       mov       rdx,7FFE8C180EC8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C180EC8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C29EBE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

