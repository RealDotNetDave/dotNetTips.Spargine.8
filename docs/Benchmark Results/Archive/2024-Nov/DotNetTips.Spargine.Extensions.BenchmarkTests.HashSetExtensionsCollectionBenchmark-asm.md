## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       call      qword ptr [7FFBF9826F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FFBF9B4E238]
       mov       ecx,49
       mov       rdx,7FFBF9A486A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98D4940
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A486A8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B4E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97D6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FFBF9B4E238]
       mov       ecx,241
       mov       rdx,7FFBF9A486A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98D4940
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A486A8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B4E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97D6670]
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
       mov       rdx,7FFBFA051CA0
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
       mov       rdx,7FFBFA051E08
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
       call      qword ptr [7FFBF97AF030]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FFBF9826EC8]
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
       call      qword ptr [7FFBF9554360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFBF9826EE0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBF9826C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FFBF9826F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FFBF9605B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFBF9605B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBF97AEF40]
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
       mov       rax,268EC700008
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       call      qword ptr [7FFBF9806F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FFBF9B2E238]
       mov       ecx,49
       mov       rdx,7FFBF9A27810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98B4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9536B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A27810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9536B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B2E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97B6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FFBF9B2E238]
       mov       ecx,241
       mov       rdx,7FFBF9A27810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98B4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9536B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A27810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9536B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B2E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97B6670]
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
       mov       rdx,7FFBFA0411A8
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
       mov       rdx,7FFBFA041310
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
       call      qword ptr [7FFBF978F030]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FFBF9806EC8]
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
       call      qword ptr [7FFBF9534360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFBF9806EE0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBF9806C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FFBF9806F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FFBF95E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFBF95E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBF978EF40]
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
       mov       rax,213F6570008
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       call      qword ptr [7FFBF9816F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FFBF9B3E238]
       mov       ecx,49
       mov       rdx,7FFBF9A37810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98C4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A37810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B3E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97C6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FFBF9B3E238]
       mov       ecx,241
       mov       rdx,7FFBF9A37810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98C4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A37810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B3E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97C6670]
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
       mov       rdx,7FFBFA051238
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M01_L01
M01_L06:
       mov       rdx,7FFBFA0513A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L04
M01_L07:
       xor       r13d,r13d
       jmp       near ptr M01_L02
M01_L08:
       call      qword ptr [7FFBF979F030]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FFBF9816EC8]
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
       call      qword ptr [7FFBF9544360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFBF9816EE0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBF9816C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FFBF9816F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FFBF95F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFBF95F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBF979EF40]
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
       mov       rax,217FCA40008
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       call      qword ptr [7FFBF9826F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FFBF9B4E238]
       mov       ecx,49
       mov       rdx,7FFBF9A47810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98D4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A47810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B4E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97D6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FFBF9B4E238]
       mov       ecx,241
       mov       rdx,7FFBF9A47810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98D4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A47810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B4E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97D6670]
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
       mov       rdx,7FFBFA061220
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
       mov       rdx,7FFBFA061388
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
       call      qword ptr [7FFBF97AF030]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FFBF9826EC8]
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
       call      qword ptr [7FFBF9554360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFBF9826EE0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBF9826C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FFBF9826F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FFBF9605B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFBF9605B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBF97AEF40]
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
       mov       rax,21AFD790008
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       call      qword ptr [7FFBF9826F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FFBF9B4E238]
       mov       ecx,49
       mov       rdx,7FFBF9A47810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98D4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A47810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B4E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97D6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FFBF9B4E238]
       mov       ecx,241
       mov       rdx,7FFBF9A47810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98D4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A47810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B4E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97D6670]
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
       mov       rdx,7FFBFA061788
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
       mov       rdx,7FFBFA0618F0
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
       call      qword ptr [7FFBF97AF030]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FFBF9826EC8]
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
       call      qword ptr [7FFBF9554360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFBF9826EE0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBF9826C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FFBF9826F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FFBF9605B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFBF9605B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBF97AEF40]
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
       mov       rax,30C4BC10008
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       call      qword ptr [7FFBF9836F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FFBF9B5E238]
       mov       ecx,49
       mov       rdx,7FFBF9A57810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98E4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9566B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A57810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9566B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B5E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97E6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FFBF9B5E238]
       mov       ecx,241
       mov       rdx,7FFBF9A57810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98E4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9566B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A57810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9566B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B5E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97E6670]
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
       mov       rdx,7FFBFA05F1F8
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
       mov       rdx,7FFBFA05F360
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
       call      qword ptr [7FFBF97BF030]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FFBF9836EC8]
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
       call      qword ptr [7FFBF9564360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFBF9836EE0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBF9836C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FFBF9836F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FFBF9615B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFBF9615B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBF97BEF40]
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
       mov       rax,194074C0008
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       call      qword ptr [7FFBF9836F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FFBF9B5E238]
       mov       ecx,49
       mov       rdx,7FFBF9A57810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98E4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9566B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A57810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9566B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B5E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97E6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FFBF9B5E238]
       mov       ecx,241
       mov       rdx,7FFBF9A57810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98E4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9566B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A57810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9566B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B5E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97E6670]
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
       mov       rdx,7FFBFA098070
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
       mov       rdx,7FFBFA0981D8
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
       call      qword ptr [7FFBF97BF030]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FFBF9836EC8]
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
       call      qword ptr [7FFBF9564360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFBF9836EE0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBF9836C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FFBF9836F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FFBF9615B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFBF9615B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBF97BEF40]
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
       mov       rax,1A115840008
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       call      qword ptr [7FFBF9826F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       call      qword ptr [7FFBF9B4E238]
       mov       ecx,49
       mov       rdx,7FFBF9A47810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98D4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A47810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B4E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97D6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L01:
       call      qword ptr [7FFBF9B4E238]
       mov       ecx,241
       mov       rdx,7FFBF9A47810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98D4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A47810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B4E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97D6670]
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
       mov       rdx,7FFBFA020958
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
       mov       rdx,7FFBFA020AC0
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
       call      qword ptr [7FFBF97AF030]
       int       3
M01_L09:
       mov       eax,[rbx+28]
       mov       [rsp+34],eax
       cmp       [rbp+8],eax
       jne       short M01_L10
       mov       rcx,rbx
       call      qword ptr [7FFBF9826EC8]
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
       call      qword ptr [7FFBF9554360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L12
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFBF9826EE0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBF9826C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FFBF9826F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FFBF9605B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFBF9605B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBF97AEF40]
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
       mov       rax,22637C50008
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       mov       rcx,1B0C7801FB8
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1F1556B3688
       mov       [rsp+20],rdx
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1F1556A0008
       call      qword ptr [7FFBF9B4DA10]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFBF9554348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L07
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFBF960DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L02:
       mov       rcx,offset MT_System.Action`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,7FFBF9F89788
       call      qword ptr [7FFBF9554210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,rbp
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBF960E3B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rdi+18],0
       je        near ptr M00_L08
M00_L03:
       mov       [rsp+38],rdi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9F8EBC8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBF9B4E238]
       mov       ecx,49
       mov       rdx,7FFBF9A47810
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98D4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A47810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B4E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97D6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       ecx,10
       call      qword ptr [7FFBF97D4F30]
       int       3
M00_L07:
       mov       rcx,rax
       mov       r11,7FFBF9410D50
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
       call      qword ptr [7FFBF9B4E238]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,1F1556A0210
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M01_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M01_L04
M01_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBF9B4E028]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBF97D6670]
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
       jmp       qword ptr [7FFBF9554378]
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
       mov       rax,[rax+78]
       test      rax,rax
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rdx
       mov       rdx,7FFBFA0D4C48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M03_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFBF9554348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFBFA0D4C88
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
       mov       rcx,[rcx+68]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFBF9FA97B8
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
       mov       rdx,7FFBFA0D4CA0
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
       mov       rcx,[rcx+60]
       test      rcx,rcx
       je        short M03_L09
       jmp       short M03_L10
M03_L09:
       mov       rcx,rsi
       mov       rdx,7FFBF9FA97A8
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
       mov       rdx,7FFBFA0D4C58
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
       mov       rdx,7FFBFA0D4C70
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
       call      qword ptr [7FFBF960E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M03_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFBF9410D58
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
       call      qword ptr [7FFBF97AED00]
       int       3
M03_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+60]
       test      rcx,rcx
       je        short M03_L20
       jmp       short M03_L21
M03_L20:
       mov       rcx,rsi
       mov       rdx,7FFBF9FA97A8
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
       mov       r11,7FFBF9410D60
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
       call      qword ptr [7FFBF95541F8]
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
       mov       rcx,7FFBF9F89788
       cmp       [rsi+18],rcx
       jne       short M05_L01
M05_L00:
       cmp       edi,[rbx+14]
       jne       short M05_L03
       mov       r14,[rbx+8]
       cmp       ebp,[r14+8]
       jae       near ptr M05_L07
       mov       ecx,ebp
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [7FFBF9F8D788]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M05_L00
       jmp       short M05_L03
M05_L01:
       cmp       edi,[rbx+14]
       jne       short M05_L03
       mov       r14,[rbx+8]
       cmp       ebp,[r14+8]
       jae       short M05_L07
       mov       ecx,ebp
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,7FFBF9F89788
       cmp       [rsi+18],rcx
       jne       short M05_L05
       mov       rcx,[rsi+8]
       call      qword ptr [7FFBF9F8D788]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
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
       call      qword ptr [7FFBF97AED00]
       int       3
M05_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M05_L02
M05_L06:
       call      qword ptr [7FFBF97AEFE8]
       int       3
M05_L07:
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
       call      qword ptr [7FFBF9605B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFBF9605B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBF97AEF40]
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
       mov       rax,1F1556A0008
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       mov       rcx,1F5C7001FB8
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,23654CE3688
       mov       [rsp+20],rdx
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,23654CD0008
       call      qword ptr [7FFBF9B3DA10]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFBF9544348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L07
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFBF95FDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L02:
       mov       rcx,offset MT_System.Action`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,7FFBF9F7AA48
       call      qword ptr [7FFBF9544210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,rbp
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBF95FE3B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rdi+18],0
       je        near ptr M00_L08
M00_L03:
       mov       [rsp+38],rdi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9F7FE88]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBF9B3E238]
       mov       ecx,49
       mov       rdx,7FFBF9A37810
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98C4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A37810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B3E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97C6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       ecx,10
       call      qword ptr [7FFBF97C4F30]
       int       3
M00_L07:
       mov       rcx,rax
       mov       r11,7FFBF9400D50
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
       call      qword ptr [7FFBF9B3E238]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,23654CD0210
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M01_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M01_L04
M01_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBF9B3E028]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBF97C6670]
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
       jmp       qword ptr [7FFBF9544378]
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
       mov       rax,[rax+78]
       test      rax,rax
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rdx
       mov       rdx,7FFBFA0C4E48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M03_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFBF9544348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFBFA0C4E88
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
       mov       rcx,[rcx+68]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFBF9F99C70
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
       mov       rdx,7FFBFA0C4EA0
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
       mov       rcx,[rcx+60]
       test      rcx,rcx
       je        short M03_L09
       jmp       short M03_L10
M03_L09:
       mov       rcx,rsi
       mov       rdx,7FFBF9F99C60
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
       mov       rdx,7FFBFA0C4E58
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
       mov       rdx,7FFBFA0C4E70
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
       call      qword ptr [7FFBF95FE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M03_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFBF9400D58
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
       call      qword ptr [7FFBF979ED00]
       int       3
M03_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+60]
       test      rcx,rcx
       je        short M03_L20
       jmp       short M03_L21
M03_L20:
       mov       rcx,rsi
       mov       rdx,7FFBF9F99C60
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
       mov       r11,7FFBF9400D60
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
       call      qword ptr [7FFBF95441F8]
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
       mov       rcx,7FFBF9F7AA48
       cmp       [rsi+18],rcx
       jne       short M05_L01
M05_L00:
       cmp       edi,[rbx+14]
       jne       short M05_L03
       mov       r14,[rbx+8]
       cmp       ebp,[r14+8]
       jae       near ptr M05_L07
       mov       ecx,ebp
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [7FFBF9F7EA48]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M05_L00
       jmp       short M05_L03
M05_L01:
       cmp       edi,[rbx+14]
       jne       short M05_L03
       mov       r14,[rbx+8]
       cmp       ebp,[r14+8]
       jae       short M05_L07
       mov       ecx,ebp
       mov       rdx,[r14+rcx*8+10]
       mov       rcx,7FFBF9F7AA48
       cmp       [rsi+18],rcx
       jne       short M05_L05
       mov       rcx,[rsi+8]
       call      qword ptr [7FFBF9F7EA48]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
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
       call      qword ptr [7FFBF979ED00]
       int       3
M05_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M05_L02
M05_L06:
       call      qword ptr [7FFBF979EFE8]
       int       3
M05_L07:
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
       call      qword ptr [7FFBF95F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFBF95F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBF979EF40]
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
       mov       rax,23654CD0008
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       mov       rcx,2459E401FB8
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2862C273688
       mov       [rsp+20],rdx
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2862C260008
       call      qword ptr [7FFBF9B3DA10]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFBF9544348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L07
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFBF95FDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L02:
       mov       rcx,offset MT_System.Action`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,7FFBF9F7AB20
       call      qword ptr [7FFBF9544210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,rbp
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBF95FE3B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rdi+18],0
       je        near ptr M00_L08
M00_L03:
       mov       [rsp+38],rdi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9F7FF60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBF9B3E238]
       mov       ecx,49
       mov       rdx,7FFBF9A37810
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98C4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A37810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B3E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97C6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       ecx,10
       call      qword ptr [7FFBF97C4F30]
       int       3
M00_L07:
       mov       rcx,rax
       mov       r11,7FFBF9400D50
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
       call      qword ptr [7FFBF9B3E238]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,2862C260210
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M01_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M01_L04
M01_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBF9B3E028]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBF97C6670]
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
       jmp       qword ptr [7FFBF9544378]
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
       mov       rax,[rax+78]
       test      rax,rax
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rdx
       mov       rdx,7FFBFA0C4A28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M03_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFBF9544348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFBFA0C4A68
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
       mov       rcx,[rcx+68]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFBF9F99880
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
       mov       rdx,7FFBFA0C4A80
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
       mov       rcx,[rcx+60]
       test      rcx,rcx
       je        short M03_L09
       jmp       short M03_L10
M03_L09:
       mov       rcx,rsi
       mov       rdx,7FFBF9F99870
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
       mov       rdx,7FFBFA0C4A38
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
       mov       rdx,7FFBFA0C4A50
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
       call      qword ptr [7FFBF95FE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M03_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFBF9400D58
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
       call      qword ptr [7FFBF979ED00]
       int       3
M03_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+60]
       test      rcx,rcx
       je        short M03_L20
       jmp       short M03_L21
M03_L20:
       mov       rcx,rsi
       mov       rdx,7FFBF9F99870
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
       mov       r11,7FFBF9400D60
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
       call      qword ptr [7FFBF95441F8]
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
       mov       rcx,7FFBF9F7AB20
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
       call      qword ptr [7FFBF9F7EB20]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
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
       mov       rcx,7FFBF9F7AB20
       cmp       r14,rcx
       jne       short M05_L05
       mov       rcx,[rsi+8]
       call      qword ptr [7FFBF9F7EB20]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
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
       call      qword ptr [7FFBF979ED00]
       int       3
M05_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M05_L02
M05_L06:
       call      qword ptr [7FFBF979EFE8]
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
       call      qword ptr [7FFBF95F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFBF95F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBF979EF40]
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
       mov       rax,2862C260008
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       mov       rcx,13F93C01FB8
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,18021AD3688
       mov       [rsp+20],rdx
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,18021AC0008
       call      qword ptr [7FFBF9B3DA10]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFBF9544348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L07
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFBF95FDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L02:
       mov       rcx,offset MT_System.Action`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,7FFBF9F7AB20
       call      qword ptr [7FFBF9544210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,rbp
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBF95FE3B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rdi+18],0
       je        near ptr M00_L08
M00_L03:
       mov       [rsp+38],rdi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9F7FF60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBF9B3E238]
       mov       ecx,49
       mov       rdx,7FFBF9A37810
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98C4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A37810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B3E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97C6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       ecx,10
       call      qword ptr [7FFBF97C4F30]
       int       3
M00_L07:
       mov       rcx,rax
       mov       r11,7FFBF9400E70
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
       call      qword ptr [7FFBF9B3E238]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,18021AC0210
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M01_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M01_L04
M01_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBF9B3E028]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBF97C6670]
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
       jmp       qword ptr [7FFBF9544378]
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
       mov       rax,[rax+78]
       test      rax,rax
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rdx
       mov       rdx,7FFBFA0C4A68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M03_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFBF9544348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFBFA0C4AA8
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
       mov       rcx,[rcx+68]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFBF9F99A58
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
       mov       rdx,7FFBFA0C4AC0
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
       mov       rcx,[rcx+60]
       test      rcx,rcx
       je        short M03_L09
       jmp       short M03_L10
M03_L09:
       mov       rcx,rsi
       mov       rdx,7FFBF9F99A48
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
       mov       rdx,7FFBFA0C4A78
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
       mov       rdx,7FFBFA0C4A90
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
       call      qword ptr [7FFBF95FE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M03_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFBF9400E78
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
       call      qword ptr [7FFBF979ED00]
       int       3
M03_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+60]
       test      rcx,rcx
       je        short M03_L20
       jmp       short M03_L21
M03_L20:
       mov       rcx,rsi
       mov       rdx,7FFBF9F99A48
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
       mov       r11,7FFBF9400E80
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
       call      qword ptr [7FFBF95441F8]
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
       mov       rcx,7FFBF9F7AB20
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
       call      qword ptr [7FFBF9F7EB20]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
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
       mov       rcx,7FFBF9F7AB20
       cmp       r14,rcx
       jne       short M05_L05
       mov       rcx,[rsi+8]
       call      qword ptr [7FFBF9F7EB20]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
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
       call      qword ptr [7FFBF979ED00]
       int       3
M05_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M05_L02
M05_L06:
       call      qword ptr [7FFBF979EFE8]
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
       call      qword ptr [7FFBF95F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFBF95F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBF979EF40]
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
       mov       rax,18021AC0008
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       mov       rcx,1EF43001FB8
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,22FD0E23688
       mov       [rsp+20],rdx
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,22FD0E10008
       call      qword ptr [7FFBF9B4DA10]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFBF9554348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L07
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFBF960DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L02:
       mov       rcx,offset MT_System.Action`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,7FFBF9F8AB20
       call      qword ptr [7FFBF9554210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,rbp
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBF960E3B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rdi+18],0
       je        near ptr M00_L08
M00_L03:
       mov       [rsp+38],rdi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9F8FF60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBF9B4E238]
       mov       ecx,49
       mov       rdx,7FFBF9A47810
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98D4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A47810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B4E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97D6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       ecx,10
       call      qword ptr [7FFBF97D4F30]
       int       3
M00_L07:
       mov       rcx,rax
       mov       r11,7FFBF9410D50
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
       call      qword ptr [7FFBF9B4E238]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,22FD0E10210
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M01_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M01_L04
M01_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBF9B4E028]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBF97D6670]
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
       jmp       qword ptr [7FFBF9554378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       mov       rax,[rax+78]
       test      rax,rax
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rdx
       mov       rdx,7FFBFA0D57B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M03_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFBF9554348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFBFA0D57F8
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
       mov       rcx,[rcx+68]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFBF9FAA100
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
       mov       rdx,7FFBFA0D5810
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
       mov       rcx,[rcx+60]
       test      rcx,rcx
       je        short M03_L09
       jmp       short M03_L10
M03_L09:
       mov       rcx,rsi
       mov       rdx,7FFBF9FAA0F0
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
       mov       rdx,7FFBFA0D57C8
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
       mov       rdx,7FFBFA0D57E0
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
       call      qword ptr [7FFBF960E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M03_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFBF9410D58
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
       call      qword ptr [7FFBF97AED00]
       int       3
M03_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+60]
       test      rcx,rcx
       je        short M03_L20
       jmp       short M03_L21
M03_L20:
       mov       rcx,rsi
       mov       rdx,7FFBF9FAA0F0
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
       mov       r11,7FFBF9410D60
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
       call      qword ptr [7FFBF95541F8]
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
       mov       rcx,7FFBF9F8AB20
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
       call      qword ptr [7FFBF9F8EB20]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
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
       mov       rcx,7FFBF9F8AB20
       cmp       r14,rcx
       jne       short M05_L05
       mov       rcx,[rsi+8]
       call      qword ptr [7FFBF9F8EB20]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
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
       call      qword ptr [7FFBF97AED00]
       int       3
M05_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M05_L02
M05_L06:
       call      qword ptr [7FFBF97AEFE8]
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
       call      qword ptr [7FFBF9605B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFBF9605B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBF97AEF40]
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
       mov       rax,22FD0E10008
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       mov       rcx,1C4F0401FB8
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2057E273688
       mov       [rsp+20],rdx
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2057E260008
       call      qword ptr [7FFBF9B6DA10]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFBF9574348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L07
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFBF962DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L02:
       mov       rcx,offset MT_System.Action`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       call      qword ptr [7FFBF9574210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,rbp
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBF962E3B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rdi+18],0
       je        near ptr M00_L08
M00_L03:
       mov       [rsp+38],rdi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9FF7E88]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBF9B6E238]
       mov       ecx,49
       mov       rdx,7FFBF9A67810
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98F4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A67810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B6E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       ecx,10
       call      qword ptr [7FFBF97F4F30]
       int       3
M00_L07:
       mov       rcx,rax
       mov       r11,7FFBF9430EA8
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
       call      qword ptr [7FFBF9B6E238]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,2057E260210
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M01_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M01_L04
M01_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBF9B6E028]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBF97F6670]
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
       jmp       qword ptr [7FFBF9574378]
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
       mov       rax,[rax+80]
       test      rax,rax
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rdx
       mov       rdx,7FFBFA12EAF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M03_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFBF9574348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M03_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+98]
       test      r11,r11
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFBFA12EB30
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
       mov       rcx,[rcx+68]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFBF9F5B2F8
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
       mov       r11,[rcx+0A0]
       test      r11,r11
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FFBFA12EB48
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
       mov       rcx,[rcx+60]
       test      rcx,rcx
       je        short M03_L09
       jmp       short M03_L10
M03_L09:
       mov       rcx,rsi
       mov       rdx,7FFBF9F5B2E8
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
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M03_L11
       jmp       short M03_L12
M03_L11:
       mov       rcx,rsi
       mov       rdx,7FFBFA12EB00
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
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M03_L14
       jmp       short M03_L15
M03_L14:
       mov       rcx,rsi
       mov       rdx,7FFBFA12EB18
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
       call      qword ptr [7FFBF962E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M03_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFBF9430E98
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
       call      qword ptr [7FFBF97CED00]
       int       3
M03_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+60]
       test      rcx,rcx
       je        short M03_L20
       jmp       short M03_L21
M03_L20:
       mov       rcx,rsi
       mov       rdx,7FFBF9F5B2E8
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
       mov       r11,7FFBF9430EA0
       call      qword ptr [r11]
M03_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 693
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
       mov       rdx,7FFBF9FD9118
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
       call      qword ptr [7FFBF9FF6898]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
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
       call      qword ptr [7FFBF95741F8]
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
       call      qword ptr [7FFBF9FF6A48]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
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
       call      qword ptr [7FFBF9FF6A48]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
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
       call      qword ptr [7FFBF97CED00]
       int       3
M06_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M06_L02
M06_L06:
       call      qword ptr [7FFBF97CEFE8]
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
       call      qword ptr [7FFBF9625B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFBF9625B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBF97CEF40]
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
       mov       rax,2057E260008
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       mov       rcx,1B1D1801FE8
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1F25F763688
       mov       [rsp+20],rdx
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1F25F750008
       call      qword ptr [7FFBF9B3DA10]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFBF9544348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L07
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFBF95FDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L02:
       mov       rcx,offset MT_System.Action`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
       call      qword ptr [7FFBF9544210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,rbp
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBF95FE3B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rdi+18],0
       je        near ptr M00_L08
M00_L03:
       mov       [rsp+38],rdi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBFA02D710]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBF9B3E238]
       mov       ecx,49
       mov       rdx,7FFBF9A386A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98C4940
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A386A8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B3E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97C6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       ecx,10
       call      qword ptr [7FFBF97C4F30]
       int       3
M00_L07:
       mov       rcx,rax
       mov       r11,7FFBF94015D8
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
       call      qword ptr [7FFBF9B3E238]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,1F25F750210
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M01_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M01_L04
M01_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBF9B3E028]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBF97C6670]
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
       jmp       qword ptr [7FFBF9544378]
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
       mov       rax,[rax+80]
       test      rax,rax
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rdx
       mov       rdx,7FFBFA1E98D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M03_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFBF9544348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M03_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+98]
       test      r11,r11
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFBFA1E9918
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
       mov       rcx,[rcx+60]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFBF9D4F438
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
       mov       r11,[rcx+0A0]
       test      r11,r11
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FFBFA1E9930
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
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M03_L09
       jmp       short M03_L10
M03_L09:
       mov       rcx,rsi
       mov       rdx,7FFBF9D4F428
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
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M03_L11
       jmp       short M03_L12
M03_L11:
       mov       rcx,rsi
       mov       rdx,7FFBFA1E98E8
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
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M03_L14
       jmp       short M03_L15
M03_L14:
       mov       rcx,rsi
       mov       rdx,7FFBFA1E9900
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
       call      qword ptr [7FFBF95FE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M03_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFBF94015C8
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
       call      qword ptr [7FFBF979ED00]
       int       3
M03_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M03_L20
       jmp       short M03_L21
M03_L20:
       mov       rcx,rsi
       mov       rdx,7FFBF9D4F428
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
       mov       r11,7FFBF94015D0
       call      qword ptr [r11]
M03_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 693
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
       mov       rdx,7FFBFA018EE0
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
       call      qword ptr [7FFBFA02C120]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
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
       call      qword ptr [7FFBF95441F8]
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
       call      qword ptr [7FFBFA02C2D0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
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
       call      qword ptr [7FFBFA02C2D0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
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
       call      qword ptr [7FFBF979ED00]
       int       3
M06_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M06_L02
M06_L06:
       call      qword ptr [7FFBF979EFE8]
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
       call      qword ptr [7FFBF95F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFBF95F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBF979EF40]
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
       mov       rax,1F25F750008
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       mov       rcx,1533F001FF8
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,193CD0A3688
       mov       [rsp+20],rdx
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.String, System.String)
       xor       r8d,r8d
       mov       r9,193CD090008
       call      qword ptr [7FFBF9B6DA10]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFBF9574348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L07
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFBF962DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L02:
       mov       rcx,offset MT_System.Action`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,7FFBFA172538
       call      qword ptr [7FFBF9574210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,rbp
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBF962E3B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rdi+18],0
       je        near ptr M00_L08
M00_L03:
       mov       [rsp+38],rdi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBFA177978]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBF9B6E238]
       mov       ecx,49
       mov       rdx,7FFBF9A67810
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98F4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A67810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B6E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       ecx,10
       call      qword ptr [7FFBF97F4F30]
       int       3
M00_L07:
       mov       rcx,rax
       mov       r11,7FFBF9431770
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
       call      qword ptr [7FFBF9B6E238]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,193CD090210
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M01_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M01_L04
M01_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBF9B6E028]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBF97F6670]
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
       jmp       qword ptr [7FFBF9574378]
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
       mov       rax,[rax+80]
       test      rax,rax
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rdx
       mov       rdx,7FFBFA20A280
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M03_L01:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFBF9574348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M03_L08
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+98]
       test      r11,r11
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFBFA20A2C0
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
       mov       rcx,[rcx+60]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFBF9D7F5E8
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
       mov       r11,[rcx+0A0]
       test      r11,r11
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FFBFA20A2D8
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
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M03_L09
       jmp       short M03_L10
M03_L09:
       mov       rcx,rsi
       mov       rdx,7FFBF9D7F5D8
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
       mov       r11,[rcx+88]
       test      r11,r11
       je        short M03_L11
       jmp       short M03_L12
M03_L11:
       mov       rcx,rsi
       mov       rdx,7FFBFA20A290
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
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M03_L14
       jmp       short M03_L15
M03_L14:
       mov       rcx,rsi
       mov       rdx,7FFBFA20A2A8
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
       call      qword ptr [7FFBF962E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M03_L17:
       mov       rcx,[rbp-28]
       mov       r11,7FFBF9431778
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
       call      qword ptr [7FFBF97CED00]
       int       3
M03_L19:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M03_L20
       jmp       short M03_L21
M03_L20:
       mov       rcx,rsi
       mov       rdx,7FFBF9D7F5D8
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
       mov       r11,7FFBF9431780
       call      qword ptr [r11]
M03_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 693
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
       call      qword ptr [7FFBF95741F8]
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
       mov       rcx,7FFBFA172538
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
       call      qword ptr [7FFBFA176538]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
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
       mov       rcx,7FFBFA172538
       cmp       r14,rcx
       jne       short M05_L05
       mov       rcx,[rsi+8]
       call      qword ptr [7FFBFA176538]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__23_0(System.__Canon)
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
       call      qword ptr [7FFBF97CED00]
       int       3
M05_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       short M05_L02
M05_L06:
       call      qword ptr [7FFBF97CEFE8]
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
       call      qword ptr [7FFBF9625B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFBF9625B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBF97CEF40]
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
       mov       rax,193CD090008
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       mov       r9,1EBC50100F8
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
       call      qword ptr [7FFBF9F7F348]; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
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
       mov       rdx,1EBC5010100
       mov       rdx,[rdx]
       mov       rcx,r14
       call      qword ptr [7FFBF9FB4BA0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+20],ebp
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1EBC9001FD8
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
       call      qword ptr [7FFBF9FB7078]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       call      qword ptr [7FFBF9B3E238]
       mov       ecx,49
       mov       rdx,7FFBF9A37DC0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98C4518
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A37DC0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B3E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97C6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rdx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9F7F180]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L05:
       jmp       near ptr M00_L02
M00_L06:
       mov       ecx,45F
       mov       rdx,7FFBF9F8AE20
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF9FB4D20]
       int       3
M00_L07:
       mov       ecx,469
       mov       rdx,7FFBF9F8AE20
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF9FB4D20]
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
       mov       rdx,7FFBFA0F6658
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       lea       rcx,[rbp-150]
       mov       r8,rsi
       call      qword ptr [7FFBF9FB55C0]; System.Collections.Immutable.ImmutableExtensions.GetEnumerableDisposable[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FFBFA0F6718
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L04:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFBF9FB5560]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
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
       mov       rdx,7FFBFA0F6750
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M01_L06:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFBF9FB5548]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].get_Current()
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
       mov       rdx,7FFBFA0F6738
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
       call      qword ptr [7FFBF9F7F720]; System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, OperationResult<System.__Canon> ByRef)
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
       call      qword ptr [7FFBF9FB4B40]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetItem(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean ByRef, Boolean ByRef)
       mov       r12,rax
M01_L14:
       inc       r13d
M01_L15:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFBF9FB5560]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
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
       call      qword ptr [7FFBF9FB4C90]
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
       mov       rdx,7FFBFA0F6778
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
       mov       rdx,7FFBFA0F45A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L23:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-190]
       mov       r8,r12
       mov       r9d,r13d
       call      qword ptr [7FFBF9FB53F8]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
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
       mov       rdx,7FFBF9F8AE20
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF9FB4D20]
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
       mov       rdx,7FFBFA0F6778
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
       mov       rcx,7FFBF9FB11D0
       cmp       [rsi+18],rcx
       jne       short M02_L04
       mov       rcx,[rsi+8]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFBF9FB51D0]; System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
M02_L03:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9FB4BA0]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9FB4BA0]
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
       call      qword ptr [7FFBF95F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFBF95F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBF979EF40]
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
       mov       rax,22C56F80008
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       mov       r9,1736E0120F0
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
       call      qword ptr [7FFBF9FE4720]; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
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
       mov       rdx,1736E0120F8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      qword ptr [7FFBF9FE5DA0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+20],ebp
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1736E001FD8
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
       call      qword ptr [7FFBF9FEC960]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       call      qword ptr [7FFBF9B6E238]
       mov       ecx,49
       mov       rdx,7FFBF9A67358
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98F3C38
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A67358
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B6E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rdx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9FE4558]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L05:
       jmp       near ptr M00_L02
M00_L06:
       mov       ecx,45F
       mov       rdx,7FFBF9FBE460
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF9FE5F20]
       int       3
M00_L07:
       mov       ecx,469
       mov       rdx,7FFBF9FBE460
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF9FE5F20]
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
       mov       rdx,7FFBFA125810
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       lea       rcx,[rbp-150]
       mov       r8,rsi
       call      qword ptr [7FFBF9FE67C0]; System.Collections.Immutable.ImmutableExtensions.GetEnumerableDisposable[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FFBFA1258D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L04:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFBF9FE6760]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
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
       mov       rdx,7FFBFA125908
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M01_L06:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFBF9FE6748]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].get_Current()
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
       mov       rdx,7FFBFA1258F0
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
       call      qword ptr [7FFBF9FE5D40]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetItem(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean ByRef, Boolean ByRef)
       mov       r12,rax
M01_L13:
       inc       r13d
M01_L14:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFBF9FE6760]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L06
       jmp       near ptr M01_L20
M01_L15:
       lea       r8,[rbp-198]
       mov       rcx,r12
       mov       edx,[rbp-154]
       call      qword ptr [7FFBF9FE5E90]
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
       call      qword ptr [7FFBF9FE4AF8]; System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, OperationResult<System.__Canon> ByRef)
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
       mov       rdx,7FFBFA125930
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
       mov       rdx,7FFBFA123760
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L24:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-190]
       mov       r8,r12
       mov       r9d,r13d
       call      qword ptr [7FFBF9FE65F8]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
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
       mov       rdx,7FFBF9FBE460
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF9FE5F20]
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
       mov       rdx,7FFBFA125930
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
       mov       rcx,7FFBF9FE23D0
       cmp       [rsi+18],rcx
       jne       short M02_L03
       mov       rcx,[rsi+8]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFBF9FE63D0]; System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
M02_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9FE5DA0]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9FE5DA0]
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
       call      qword ptr [7FFBF9625B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFBF9625B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBF97CEF40]
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
       mov       rax,1B3FBD80008
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       mov       r9,1FF1B8120F0
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
       call      qword ptr [7FFBF9FC4720]; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
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
       mov       rdx,1FF1B8120F8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      qword ptr [7FFBF9FC5DA0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+20],ebp
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1FF1B801FD8
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
       call      qword ptr [7FFBF9FCC960]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       call      qword ptr [7FFBF9B4E238]
       mov       ecx,49
       mov       rdx,7FFBF9A47810
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98D4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A47810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B4E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97D6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rdx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9FC4558]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L05:
       jmp       near ptr M00_L02
M00_L06:
       mov       ecx,45F
       mov       rdx,7FFBF9F9E890
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF9FC5F20]
       int       3
M00_L07:
       mov       ecx,469
       mov       rdx,7FFBF9F9E890
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF9FC5F20]
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
       mov       rdx,7FFBFA105A98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       lea       rcx,[rbp-150]
       mov       r8,rsi
       call      qword ptr [7FFBF9FC67C0]; System.Collections.Immutable.ImmutableExtensions.GetEnumerableDisposable[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FFBFA105B58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L04:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFBF9FC6760]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
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
       mov       rdx,7FFBFA105B90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M01_L06:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFBF9FC6748]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].get_Current()
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
       mov       rdx,7FFBFA105B78
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
       call      qword ptr [7FFBF9FC4AF8]; System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, OperationResult<System.__Canon> ByRef)
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
       call      qword ptr [7FFBF9FC5D40]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetItem(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean ByRef, Boolean ByRef)
       mov       r12,rax
M01_L14:
       inc       r13d
M01_L15:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFBF9FC6760]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
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
       call      qword ptr [7FFBF9FC5E90]
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
       mov       rdx,7FFBFA105BB8
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
       mov       rdx,7FFBFA1039E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L23:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-190]
       mov       r8,r12
       mov       r9d,r13d
       call      qword ptr [7FFBF9FC65F8]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
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
       mov       rdx,7FFBF9F9E890
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF9FC5F20]
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
       mov       rdx,7FFBFA105BB8
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
       mov       rcx,7FFBF9FC23D0
       cmp       [rsi+18],rcx
       jne       short M02_L03
       mov       rcx,[rsi+8]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFBF9FC63D0]; System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
M02_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9FC5DA0]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9FC5DA0]
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
       call      qword ptr [7FFBF9605B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFBF9605B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBF97AEF40]
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
       mov       rax,23FA9900008
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       mov       r9,287CD8120F0
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
       call      qword ptr [7FFBF9FC4720]; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
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
       mov       rdx,287CD8120F8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      qword ptr [7FFBF9FC5DA0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+20],ebp
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,287CD801FD8
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
       call      qword ptr [7FFBF9FCC960]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       call      qword ptr [7FFBF9B4E238]
       mov       ecx,49
       mov       rdx,7FFBF9A47358
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98D3C38
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A47358
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B4E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97D6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rdx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9FC4558]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L05:
       jmp       near ptr M00_L02
M00_L06:
       mov       ecx,45F
       mov       rdx,7FFBF9F9E890
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF9FC5F20]
       int       3
M00_L07:
       mov       ecx,469
       mov       rdx,7FFBF9F9E890
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF9FC5F20]
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
       mov       rdx,7FFBFA105CB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       lea       rcx,[rbp-150]
       mov       r8,rsi
       call      qword ptr [7FFBF9FC67C0]; System.Collections.Immutable.ImmutableExtensions.GetEnumerableDisposable[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FFBFA105D78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L04:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFBF9FC6760]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
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
       mov       rdx,7FFBFA105DB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M01_L06:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFBF9FC6748]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].get_Current()
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
       mov       rdx,7FFBFA105D98
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
       call      qword ptr [7FFBF9FC4AF8]; System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, OperationResult<System.__Canon> ByRef)
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
       call      qword ptr [7FFBF9FC5D40]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetItem(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean ByRef, Boolean ByRef)
       mov       r12,rax
M01_L14:
       inc       r13d
M01_L15:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFBF9FC6760]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
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
       call      qword ptr [7FFBF9FC5E90]
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
       mov       rdx,7FFBFA105DD8
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
       mov       rdx,7FFBFA103C08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L23:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-190]
       mov       r8,r12
       mov       r9d,r13d
       call      qword ptr [7FFBF9FC65F8]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
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
       mov       rdx,7FFBF9F9E890
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF9FC5F20]
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
       mov       rdx,7FFBFA105DD8
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
       mov       rcx,7FFBF9FC23D0
       cmp       [rsi+18],rcx
       jne       short M02_L03
       mov       rcx,[rsi+8]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFBF9FC63D0]; System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
M02_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9FC5DA0]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9FC5DA0]
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
       call      qword ptr [7FFBF9605B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFBF9605B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBF97AEF40]
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
       mov       rax,2C85B960008
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       mov       r9,22CCA0120F0
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
       call      qword ptr [7FFBF9FA4720]; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
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
       mov       rdx,22CCA0120F8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      qword ptr [7FFBF9FA5DA0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+20],ebp
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,22CCA001FD8
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
       call      qword ptr [7FFBF9FAC960]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       call      qword ptr [7FFBF9B2E238]
       mov       ecx,49
       mov       rdx,7FFBF9A286A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98B4940
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBF9536B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A286A8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9536B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B2E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97B6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rdx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9FA4558]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L05:
       jmp       near ptr M00_L02
M00_L06:
       mov       ecx,45F
       mov       rdx,7FFBF9F7EDF8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF9FA5F20]
       int       3
M00_L07:
       mov       ecx,469
       mov       rdx,7FFBF9F7EDF8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF9FA5F20]
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
       mov       rdx,7FFBFA0E6C80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       lea       rcx,[rbp-150]
       mov       r8,rsi
       call      qword ptr [7FFBF9FA67C0]; System.Collections.Immutable.ImmutableExtensions.GetEnumerableDisposable[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FFBFA0E6D40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L04:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFBF9FA6760]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
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
       mov       rdx,7FFBFA0E6D78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M01_L06:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFBF9FA6748]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].get_Current()
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
       mov       rdx,7FFBFA0E6D60
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
       call      qword ptr [7FFBF9FA4AF8]; System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, OperationResult<System.__Canon> ByRef)
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
       call      qword ptr [7FFBF9FA5D40]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetItem(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean ByRef, Boolean ByRef)
       mov       r12,rax
M01_L14:
       inc       r13d
M01_L15:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFBF9FA6760]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
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
       call      qword ptr [7FFBF9FA5E90]
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
       mov       rdx,7FFBFA0E6DA0
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
       mov       rdx,7FFBFA0E5E00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L23:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-190]
       mov       r8,r12
       mov       r9d,r13d
       call      qword ptr [7FFBF9FA65F8]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
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
       mov       rdx,7FFBF9F7EDF8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF9FA5F20]
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
       mov       rdx,7FFBFA0E6DA0
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
       mov       rcx,7FFBF9FA23D0
       cmp       [rsi+18],rcx
       jne       short M02_L03
       mov       rcx,[rsi+8]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFBF9FA63D0]; System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
M02_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9FA5DA0]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9FA5DA0]
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
       call      qword ptr [7FFBF95E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFBF95E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBF978EF40]
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
       mov       rax,26D5BFC0008
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       mov       r9,29D7A8120F0
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
       call      qword ptr [7FFBF9FDC720]; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
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
       mov       rdx,29D7A8120F8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      qword ptr [7FFBF9FDDDA0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+20],ebp
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,29D7A801FD8
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
       call      qword ptr [7FFBFA014960]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       call      qword ptr [7FFBF9B6E238]
       mov       ecx,49
       mov       rdx,7FFBF9A67810
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98F4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A67810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B6E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rdx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9FDC558]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L05:
       jmp       near ptr M00_L02
M00_L06:
       mov       ecx,45F
       mov       rdx,7FFBF9FCD4E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF9FDDF20]
       int       3
M00_L07:
       mov       ecx,469
       mov       rdx,7FFBF9FCD4E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF9FDDF20]
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
       mov       rdx,[rcx+0F0]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,r14
       mov       rdx,7FFBFA12BC50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       lea       rcx,[rbp-150]
       mov       r8,rsi
       call      qword ptr [7FFBF9FDE7C0]; System.Collections.Immutable.ImmutableExtensions.GetEnumerableDisposable[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FFBFA12BD10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L04:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFBF9FDE760]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       je        near ptr M01_L20
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdi,[rcx+108]
       test      rdi,rdi
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,r14
       mov       rdx,7FFBFA12BD48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M01_L06:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFBF9FDE748]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].get_Current()
       mov       [rbp-1B8],rax
       test      rax,rax
       je        near ptr M01_L19
       mov       rax,[rbp-1B8]
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+100]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,r14
       mov       rdx,7FFBFA12BD30
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
       call      qword ptr [7FFBF9FDDD40]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetItem(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean ByRef, Boolean ByRef)
       mov       r12,rax
M01_L13:
       inc       r13d
M01_L14:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFBF9FDE760]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L06
       jmp       near ptr M01_L20
M01_L15:
       lea       r8,[rbp-198]
       mov       rcx,r12
       mov       edx,[rbp-154]
       call      qword ptr [7FFBF9FDDE90]
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
       call      qword ptr [7FFBF9FDCAF8]; System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, OperationResult<System.__Canon> ByRef)
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
       mov       rax,[rcx+110]
       test      rax,rax
       je        short M01_L21
       jmp       short M01_L22
M01_L21:
       mov       rcx,r14
       mov       rdx,7FFBFA12BD70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L22:
       lea       rcx,[rbp-0C8]
       call      rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-190],xmm0
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rdx,[rcx+0E0]
       test      rdx,rdx
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rcx,r14
       mov       rdx,7FFBFA12ADD0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L24:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-190]
       mov       r8,r12
       mov       r9d,r13d
       call      qword ptr [7FFBF9FDE5F8]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
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
       mov       rdx,7FFBF9FCD4E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF9FDDF20]
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
       je        short M01_L26
       jmp       short M01_L27
M01_L26:
       mov       rdx,7FFBFA12BD70
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
       mov       rcx,7FFBF9FDA3D0
       cmp       [rsi+18],rcx
       jne       short M02_L03
       mov       rcx,[rsi+8]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFBF9FDE3D0]; System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
M02_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9FDDDA0]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9FDDDA0]
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
       call      qword ptr [7FFBF9625B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFBF9625B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBF97CEF40]
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
       mov       rax,2DE0C820008
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       mov       r9,1E8088100F8
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
       call      qword ptr [7FFBFA04E178]; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
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
       mov       rdx,1E808810100
       mov       rdx,[rdx]
       mov       rcx,r14
       call      qword ptr [7FFBFA04F7F8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+20],ebp
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1E80C802000
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
       call      qword ptr [7FFBFA075CF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       call      qword ptr [7FFBF9B5E238]
       mov       ecx,49
       mov       rdx,7FFBF9A57810
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98E4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBF9566B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A57810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9566B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B5E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97E6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rdx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFBFA04DFB0]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L05:
       jmp       near ptr M00_L02
M00_L06:
       mov       ecx,45F
       mov       rdx,7FFBFA050710
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBFA04F978]
       int       3
M00_L07:
       mov       ecx,469
       mov       rdx,7FFBFA050710
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBFA04F978]
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
       mov       rdx,7FFBFA22F480
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       lea       rcx,[rbp-150]
       mov       r8,rsi
       call      qword ptr [7FFBFA074240]; System.Collections.Immutable.ImmutableExtensions.GetEnumerableDisposable[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FFBFA22F540
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L04:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFBFA0741E0]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
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
       mov       rdx,7FFBFA22F578
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M01_L06:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFBFA0741C8]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].get_Current()
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
       mov       rdx,7FFBFA22F560
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
       call      qword ptr [7FFBFA04E550]; System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, OperationResult<System.__Canon> ByRef)
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
       call      qword ptr [7FFBFA04F798]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetItem(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean ByRef, Boolean ByRef)
       mov       r12,rax
M01_L14:
       inc       r13d
M01_L15:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFBFA0741E0]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
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
       call      qword ptr [7FFBFA04F8E8]
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
       mov       rdx,7FFBFA22F5A0
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
       mov       rdx,7FFBFA22E600
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L23:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-190]
       mov       r8,r12
       mov       r9d,r13d
       call      qword ptr [7FFBFA074078]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
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
       mov       rdx,7FFBFA050710
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBFA04F978]
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
       mov       rdx,7FFBFA22F5A0
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
       call      qword ptr [7FFBFA04FE28]; System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
M02_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBFA04F7F8]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBFA04F7F8]
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
       call      qword ptr [7FFBF9615B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFBF9615B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBF97BEF40]
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
       mov       rax,2289A710008
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       mov       r9,23057C120F0
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
       call      qword ptr [7FFBFA16C4E0]; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>, MutationInput<System.__Canon>)
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
       mov       rdx,23057C120F8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      qword ptr [7FFBFA16DB60]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+20],ebp
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,23057C02010
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
       call      qword ptr [7FFBFA1A4108]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       call      qword ptr [7FFBF9B5E238]
       mov       ecx,49
       mov       rdx,7FFBF9A57358
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98E3C38
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBF9566B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A57358
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9566B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B5E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97E6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rdx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFBFA16C318]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L05:
       jmp       near ptr M00_L02
M00_L06:
       mov       ecx,45F
       mov       rdx,7FFBFA1727A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBFA16DCE0]
       int       3
M00_L07:
       mov       ecx,469
       mov       rdx,7FFBFA1727A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBFA16DCE0]
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
       mov       rdx,7FFBFA240768
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       lea       rcx,[rbp-150]
       mov       r8,rsi
       call      qword ptr [7FFBFA16E580]; System.Collections.Immutable.ImmutableExtensions.GetEnumerableDisposable[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FFBFA240828
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L04:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFBFA16E520]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
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
       mov       rdx,7FFBFA240860
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M01_L06:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFBFA16E508]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].get_Current()
       mov       [rbp-1B8],rax
       test      rax,rax
       je        near ptr M01_L15
       mov       rax,[rbp-1B8]
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+100]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,r14
       mov       rdx,7FFBFA240848
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
       call      qword ptr [7FFBFA16C8B8]; System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, OperationResult<System.__Canon> ByRef)
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
       call      qword ptr [7FFBFA16DB00]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetItem(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean ByRef, Boolean ByRef)
       mov       r12,rax
M01_L13:
       inc       r13d
M01_L14:
       mov       rdx,rsi
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFBFA16E520]; System.Collections.Immutable.DisposableEnumeratorAdapter`2[[System.__Canon, System.Private.CoreLib],[System.Collections.Immutable.ImmutableHashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MoveNext()
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
       call      qword ptr [7FFBFA16DC50]
       mov       r12,rax
       jmp       short M01_L13
M01_L19:
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+110]
       test      rax,rax
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,r14
       mov       rdx,7FFBFA240888
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
       mov       rdx,7FFBFA21F890
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L23:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-190]
       mov       r8,r12
       mov       r9d,r13d
       call      qword ptr [7FFBFA16E3B8]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
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
       mov       rdx,7FFBFA1727A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBFA16DCE0]
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
       mov       rdx,7FFBFA240888
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
; Total bytes of code 1059
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
       mov       rcx,7FFBFA16A190
       cmp       [rsi+18],rcx
       jne       short M02_L03
       mov       rcx,[rsi+8]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFBFA16E190]; System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__91_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
M02_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBFA16DB60]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBFA16DB60]
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
       call      qword ptr [7FFBF9615B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFBF9615B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBF97BEF40]
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
       mov       rax,270E5A20008
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       call      qword ptr [7FFBF9F8D230]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FFBF9826C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBF980E3F8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBF9826F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FFBF9B4E238]
       mov       ecx,49
       mov       rdx,7FFBF9A47810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98D4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A47810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B4E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97D6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FFBF9B4E238]
       mov       ecx,241
       mov       rdx,7FFBF9A47810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98D4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A47810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B4E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97D6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       call      qword ptr [7FFBF9F7E5C8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FFBF9816C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBF97FE3F8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBF9816F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FFBF9B3E238]
       mov       ecx,49
       mov       rdx,7FFBF9A37810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98C4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A37810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B3E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97C6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FFBF9B3E238]
       mov       ecx,241
       mov       rdx,7FFBF9A37810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98C4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A37810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B3E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97C6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       call      qword ptr [7FFBF9FAE5C8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FFBF9846C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBF982E3F8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBF9846F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FFBF9B6E238]
       mov       ecx,49
       mov       rdx,7FFBF9A67810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98F4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A67810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B6E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FFBF9B6E238]
       mov       ecx,241
       mov       rdx,7FFBF9A67810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98F4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A67810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B6E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       call      qword ptr [7FFBF9F7E5C8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FFBF9816C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBF97FE3F8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBF9816F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FFBF9B3E238]
       mov       ecx,49
       mov       rdx,7FFBF9A37810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98C4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A37810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B3E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97C6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FFBF9B3E238]
       mov       ecx,241
       mov       rdx,7FFBF9A37810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98C4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A37810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B3E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97C6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       call      qword ptr [7FFBF9F7E4F0]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FFBF9816C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBF97FE3F8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBF9816F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FFBF9B3E238]
       mov       ecx,49
       mov       rdx,7FFBF9A37810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98C4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A37810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B3E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97C6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FFBF9B3E238]
       mov       ecx,241
       mov       rdx,7FFBF9A37810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98C4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A37810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B3E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97C6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       call      qword ptr [7FFBF9FEFBA0]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FFBF9846C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBF982E3F8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBF9846F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FFBF9B6E238]
       mov       ecx,49
       mov       rdx,7FFBF9A67810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98F4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A67810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B6E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FFBF9B6E238]
       mov       ecx,241
       mov       rdx,7FFBF9A67810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98F4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A67810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B6E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       call      qword ptr [7FFBFA026D78]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FFBF9816C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBF97FE3F8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBF9816F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FFBF9B3E238]
       mov       ecx,49
       mov       rdx,7FFBF9A37810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98C4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A37810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B3E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97C6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FFBF9B3E238]
       mov       ecx,241
       mov       rdx,7FFBF9A37810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98C4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A37810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B3E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97C6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       call      qword ptr [7FFBFA165FE0]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
       call      qword ptr [7FFBF9836C28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        short M01_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBF981E3F8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M01_L00:
       lea       r8,[rsp+20]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBF9836F40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FFBF9B5E238]
       mov       ecx,49
       mov       rdx,7FFBF9A57810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98E4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9566B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A57810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9566B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B5E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97E6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FFBF9B5E238]
       mov       ecx,241
       mov       rdx,7FFBF9A57810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98E4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9566B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9A57810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9566B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9B5E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97E6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

