## DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark-20250805-031626
**Diff for AddIf method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF9B3085CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3075CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33D4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33D4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 405
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
-       mov       rdx,7FF9B3966E18
+       mov       rdx,7FF9B3966D08
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FF9B3966E30
+       mov       rdx,7FF9B3966D20
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
-       call      qword ptr [7FF9B31D5E48]
+       call      qword ptr [7FF9B31C5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FF9B3085C50]
+       call      qword ptr [7FF9B3075C50]
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
-       call      qword ptr [7FF9B2E64360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF9B2E54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FF9B3085C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FF9B3075C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3085998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3075998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        mov       [rdi],eax
 M01_L12:
        mov       eax,1
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
-       call      qword ptr [7FF9B3085CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FF9B3075CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
        jmp       near ptr M01_L00
 M01_L14:
        mov       r8,[rsp+28]
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
-       call      00007FF9B2E61E60
+       call      00007FF9B2E51E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FF9B31D5D58]
+       call      qword ptr [7FF9B31C5D58]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,1B285890008
+       mov       rax,2ABED910008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for AddIf method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rdx,7FF9B3966E18
+       mov       rdx,7FF9B3976D08
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FF9B3966E30
+       mov       rdx,7FF9B3976D20
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L07:
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,1B285890008
+       mov       rax,25FB4FE0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for AddIf method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF9B3085CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3075CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33D4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33D4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 405
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
-       mov       rdx,7FF9B3966E18
+       mov       rdx,7FF9B3956D38
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FF9B3966E30
+       mov       rdx,7FF9B3956D50
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
-       call      qword ptr [7FF9B31D5E48]
+       call      qword ptr [7FF9B31C5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FF9B3085C50]
+       call      qword ptr [7FF9B3075C50]
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
-       call      qword ptr [7FF9B2E64360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF9B2E54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FF9B3085C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FF9B3075C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3085998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3075998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        mov       [rdi],eax
 M01_L12:
        mov       eax,1
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
-       call      qword ptr [7FF9B3085CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FF9B3075CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
        jmp       near ptr M01_L00
 M01_L14:
        mov       r8,[rsp+28]
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
-       call      00007FF9B2E61E60
+       call      00007FF9B2E51E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FF9B31D5D58]
+       call      qword ptr [7FF9B31C5D58]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,1B285890008
+       mov       rax,2D693720008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for AddIf method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rdx,7FF9B3966E18
+       mov       rdx,7FF9B3967200
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FF9B3966E30
+       mov       rdx,7FF9B3967218
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L07:
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,1B285890008
+       mov       rax,3138BED0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for AddIf method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF9B3085CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3065CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 405
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
-       mov       rdx,7FF9B3966E18
+       mov       rdx,7FF9B3957370
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FF9B3966E30
+       mov       rdx,7FF9B3957388
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
-       call      qword ptr [7FF9B31D5E48]
+       call      qword ptr [7FF9B31B5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FF9B3085C50]
+       call      qword ptr [7FF9B3065C50]
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
-       call      qword ptr [7FF9B2E64360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF9B2E44360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FF9B3085C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FF9B3065C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3085998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3065998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        mov       [rdi],eax
 M01_L12:
        mov       eax,1
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
-       call      qword ptr [7FF9B3085CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FF9B3065CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
        jmp       near ptr M01_L00
 M01_L14:
        mov       r8,[rsp+28]
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
-       call      00007FF9B2E61E60
+       call      00007FF9B2E41E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2EF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2EF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FF9B31D5D58]
+       call      qword ptr [7FF9B31B5D58]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,1B285890008
+       mov       rax,278A38A0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for AddIf method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF9B3085CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3095CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33F4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B3207190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33F4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3076718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33F4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B3207190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33F4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3076718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 405
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
-       mov       r11,[rdx+60]
+       mov       r11,[rdx+58]
        test      r11,r11
        je        short M01_L01
        jmp       short M01_L02
 M01_L01:
-       mov       rdx,7FF9B3966E18
+       mov       rdx,7FF9B3908E00
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
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
-       mov       r11,[rdx+68]
+       mov       r11,[rdx+60]
        test      r11,r11
        je        short M01_L06
        jmp       short M01_L07
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FF9B3966E30
+       mov       rdx,7FF9B3908E18
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
-       call      qword ptr [7FF9B31D5E48]
+       call      qword ptr [7FF9B31E5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FF9B3085C50]
+       call      qword ptr [7FF9B3095C50]
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
-       call      qword ptr [7FF9B2E64360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF9B2E74360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FF9B3085C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FF9B3095C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3085998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3095998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        mov       [rdi],eax
 M01_L12:
        mov       eax,1
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
-       call      qword ptr [7FF9B3085CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FF9B3095CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
        jmp       near ptr M01_L00
 M01_L14:
        mov       r8,[rsp+28]
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
-       call      00007FF9B2E61E60
+       call      00007FF9B2E71E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FF9B31D5D58]
+       call      qword ptr [7FF9B31E5D58]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,1B285890008
+       mov       rax,215B9D00008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for AddIf method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF9B3085CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3075CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33D4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33D4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 405
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
-       mov       r11,[rdx+60]
+       mov       r11,[rdx+58]
        test      r11,r11
        je        short M01_L01
        jmp       short M01_L02
 M01_L01:
-       mov       rdx,7FF9B3966E18
+       mov       rdx,7FF9B38D8930
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
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
-       mov       r11,[rdx+68]
+       mov       r11,[rdx+60]
        test      r11,r11
        je        short M01_L06
        jmp       short M01_L07
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FF9B3966E30
+       mov       rdx,7FF9B38D8948
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
-       call      qword ptr [7FF9B31D5E48]
+       call      qword ptr [7FF9B31C5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FF9B3085C50]
+       call      qword ptr [7FF9B3075C50]
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
-       call      qword ptr [7FF9B2E64360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF9B2E54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FF9B3085C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FF9B3075C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3085998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3075998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        mov       [rdi],eax
 M01_L12:
        mov       eax,1
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
-       call      qword ptr [7FF9B3085CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FF9B3075CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
        jmp       near ptr M01_L00
 M01_L14:
        mov       r8,[rsp+28]
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
-       call      00007FF9B2E61E60
+       call      00007FF9B2E51E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FF9B31D5D58]
+       call      qword ptr [7FF9B31C5D58]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,1B285890008
+       mov       rax,23430470008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for AddIf method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF9B3075CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3085CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FF9B33D4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31E7190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33D4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3056718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FF9B33D4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31E7190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33D4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3056718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 405
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
-       mov       rdx,7FF9B3966D08
+       mov       rdx,7FF9B3976D08
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FF9B3966D20
+       mov       rdx,7FF9B3976D20
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
-       call      qword ptr [7FF9B31C5E48]
+       call      qword ptr [7FF9B31D5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FF9B3075C50]
+       call      qword ptr [7FF9B3085C50]
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
-       call      qword ptr [7FF9B2E54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF9B2E64360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FF9B3075C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FF9B3085C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3075998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3085998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        mov       [rdi],eax
 M01_L12:
        mov       eax,1
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
-       call      qword ptr [7FF9B3075CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FF9B3085CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
        jmp       near ptr M01_L00
 M01_L14:
        mov       r8,[rsp+28]
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
-       call      00007FF9B2E51E60
+       call      00007FF9B2E61E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FF9B31C5D58]
+       call      qword ptr [7FF9B31D5D58]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,2ABED910008
+       mov       rax,25FB4FE0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for AddIf method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rdx,7FF9B3966D08
+       mov       rdx,7FF9B3956D38
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FF9B3966D20
+       mov       rdx,7FF9B3956D50
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L07:
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,2ABED910008
+       mov       rax,2D693720008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for AddIf method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF9B3075CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3085CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FF9B33D4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31E7190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33D4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3056718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FF9B33D4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31E7190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33D4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3056718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 405
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
-       mov       rdx,7FF9B3966D08
+       mov       rdx,7FF9B3967200
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FF9B3966D20
+       mov       rdx,7FF9B3967218
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
-       call      qword ptr [7FF9B31C5E48]
+       call      qword ptr [7FF9B31D5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FF9B3075C50]
+       call      qword ptr [7FF9B3085C50]
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
-       call      qword ptr [7FF9B2E54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF9B2E64360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FF9B3075C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FF9B3085C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3075998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3085998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        mov       [rdi],eax
 M01_L12:
        mov       eax,1
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
-       call      qword ptr [7FF9B3075CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FF9B3085CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
        jmp       near ptr M01_L00
 M01_L14:
        mov       r8,[rsp+28]
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
-       call      00007FF9B2E51E60
+       call      00007FF9B2E61E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FF9B31C5D58]
+       call      qword ptr [7FF9B31D5D58]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,2ABED910008
+       mov       rax,3138BED0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for AddIf method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF9B3075CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3065CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FF9B33D4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31E7190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33D4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3056718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FF9B33D4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31E7190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33D4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3056718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 405
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
-       mov       rdx,7FF9B3966D08
+       mov       rdx,7FF9B3957370
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FF9B3966D20
+       mov       rdx,7FF9B3957388
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
-       call      qword ptr [7FF9B31C5E48]
+       call      qword ptr [7FF9B31B5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FF9B3075C50]
+       call      qword ptr [7FF9B3065C50]
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
-       call      qword ptr [7FF9B2E54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF9B2E44360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FF9B3075C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FF9B3065C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3075998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3065998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        mov       [rdi],eax
 M01_L12:
        mov       eax,1
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
-       call      qword ptr [7FF9B3075CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FF9B3065CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
        jmp       near ptr M01_L00
 M01_L14:
        mov       r8,[rsp+28]
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
-       call      00007FF9B2E51E60
+       call      00007FF9B2E41E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2EF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2EF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FF9B31C5D58]
+       call      qword ptr [7FF9B31B5D58]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,2ABED910008
+       mov       rax,278A38A0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for AddIf method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF9B3075CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3095CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FF9B33D4CF0]
+       call      qword ptr [7FF9B33F4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31E7190
+       mov       rdx,7FF9B3207190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33D4AE0]
+       call      qword ptr [7FF9B33F4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3056718]
+       call      qword ptr [7FF9B3076718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FF9B33D4CF0]
+       call      qword ptr [7FF9B33F4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31E7190
+       mov       rdx,7FF9B3207190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33D4AE0]
+       call      qword ptr [7FF9B33F4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3056718]
+       call      qword ptr [7FF9B3076718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 405
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
-       mov       r11,[rdx+60]
+       mov       r11,[rdx+58]
        test      r11,r11
        je        short M01_L01
        jmp       short M01_L02
 M01_L01:
-       mov       rdx,7FF9B3966D08
+       mov       rdx,7FF9B3908E00
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
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
-       mov       r11,[rdx+68]
+       mov       r11,[rdx+60]
        test      r11,r11
        je        short M01_L06
        jmp       short M01_L07
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FF9B3966D20
+       mov       rdx,7FF9B3908E18
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
-       call      qword ptr [7FF9B31C5E48]
+       call      qword ptr [7FF9B31E5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FF9B3075C50]
+       call      qword ptr [7FF9B3095C50]
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
-       call      qword ptr [7FF9B2E54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF9B2E74360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FF9B3075C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FF9B3095C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3075998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3095998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        mov       [rdi],eax
 M01_L12:
        mov       eax,1
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
-       call      qword ptr [7FF9B3075CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FF9B3095CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
        jmp       near ptr M01_L00
 M01_L14:
        mov       r8,[rsp+28]
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
-       call      00007FF9B2E51E60
+       call      00007FF9B2E71E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FF9B31C5D58]
+       call      qword ptr [7FF9B31E5D58]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,2ABED910008
+       mov       rax,215B9D00008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for AddIf method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
call      qword ptr [7FF9B33D4CF0]
        mov       ecx,28D
        mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
        mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 405
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
-       mov       r11,[rdx+60]
+       mov       r11,[rdx+58]
        test      r11,r11
        je        short M01_L01
        jmp       short M01_L02
 M01_L01:
-       mov       rdx,7FF9B3966D08
+       mov       rdx,7FF9B38D8930
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
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
-       mov       r11,[rdx+68]
+       mov       r11,[rdx+60]
        test      r11,r11
        je        short M01_L06
        jmp       short M01_L07
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FF9B3966D20
+       mov       rdx,7FF9B38D8948
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L07:
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,2ABED910008
+       mov       rax,23430470008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for AddIf method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF9B3085CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3075CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33D4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33D4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 405
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
-       mov       rdx,7FF9B3976D08
+       mov       rdx,7FF9B3956D38
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FF9B3976D20
+       mov       rdx,7FF9B3956D50
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
-       call      qword ptr [7FF9B31D5E48]
+       call      qword ptr [7FF9B31C5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FF9B3085C50]
+       call      qword ptr [7FF9B3075C50]
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
-       call      qword ptr [7FF9B2E64360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF9B2E54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FF9B3085C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FF9B3075C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3085998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3075998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        mov       [rdi],eax
 M01_L12:
        mov       eax,1
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
-       call      qword ptr [7FF9B3085CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FF9B3075CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
        jmp       near ptr M01_L00
 M01_L14:
        mov       r8,[rsp+28]
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
-       call      00007FF9B2E61E60
+       call      00007FF9B2E51E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FF9B31D5D58]
+       call      qword ptr [7FF9B31C5D58]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,25FB4FE0008
+       mov       rax,2D693720008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for AddIf method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rdx,7FF9B3976D08
+       mov       rdx,7FF9B3967200
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FF9B3976D20
+       mov       rdx,7FF9B3967218
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L07:
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,25FB4FE0008
+       mov       rax,3138BED0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for AddIf method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF9B3085CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3065CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 405
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
-       mov       rdx,7FF9B3976D08
+       mov       rdx,7FF9B3957370
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FF9B3976D20
+       mov       rdx,7FF9B3957388
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
-       call      qword ptr [7FF9B31D5E48]
+       call      qword ptr [7FF9B31B5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FF9B3085C50]
+       call      qword ptr [7FF9B3065C50]
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
-       call      qword ptr [7FF9B2E64360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF9B2E44360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FF9B3085C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FF9B3065C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3085998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3065998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        mov       [rdi],eax
 M01_L12:
        mov       eax,1
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
-       call      qword ptr [7FF9B3085CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FF9B3065CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
        jmp       near ptr M01_L00
 M01_L14:
        mov       r8,[rsp+28]
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
-       call      00007FF9B2E61E60
+       call      00007FF9B2E41E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2EF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2EF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FF9B31D5D58]
+       call      qword ptr [7FF9B31B5D58]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,25FB4FE0008
+       mov       rax,278A38A0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for AddIf method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF9B3085CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3095CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33F4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B3207190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33F4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3076718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33F4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B3207190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33F4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3076718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 405
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
-       mov       r11,[rdx+60]
+       mov       r11,[rdx+58]
        test      r11,r11
        je        short M01_L01
        jmp       short M01_L02
 M01_L01:
-       mov       rdx,7FF9B3976D08
+       mov       rdx,7FF9B3908E00
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
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
-       mov       r11,[rdx+68]
+       mov       r11,[rdx+60]
        test      r11,r11
        je        short M01_L06
        jmp       short M01_L07
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FF9B3976D20
+       mov       rdx,7FF9B3908E18
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
-       call      qword ptr [7FF9B31D5E48]
+       call      qword ptr [7FF9B31E5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FF9B3085C50]
+       call      qword ptr [7FF9B3095C50]
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
-       call      qword ptr [7FF9B2E64360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF9B2E74360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FF9B3085C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FF9B3095C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3085998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3095998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        mov       [rdi],eax
 M01_L12:
        mov       eax,1
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
-       call      qword ptr [7FF9B3085CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FF9B3095CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
        jmp       near ptr M01_L00
 M01_L14:
        mov       r8,[rsp+28]
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
-       call      00007FF9B2E61E60
+       call      00007FF9B2E71E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FF9B31D5D58]
+       call      qword ptr [7FF9B31E5D58]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,25FB4FE0008
+       mov       rax,215B9D00008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for AddIf method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF9B3085CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3075CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33D4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33D4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 405
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
-       mov       r11,[rdx+60]
+       mov       r11,[rdx+58]
        test      r11,r11
        je        short M01_L01
        jmp       short M01_L02
 M01_L01:
-       mov       rdx,7FF9B3976D08
+       mov       rdx,7FF9B38D8930
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
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
-       mov       r11,[rdx+68]
+       mov       r11,[rdx+60]
        test      r11,r11
        je        short M01_L06
        jmp       short M01_L07
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FF9B3976D20
+       mov       rdx,7FF9B38D8948
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
-       call      qword ptr [7FF9B31D5E48]
+       call      qword ptr [7FF9B31C5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FF9B3085C50]
+       call      qword ptr [7FF9B3075C50]
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
-       call      qword ptr [7FF9B2E64360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF9B2E54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FF9B3085C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FF9B3075C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3085998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3075998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        mov       [rdi],eax
 M01_L12:
        mov       eax,1
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
-       call      qword ptr [7FF9B3085CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FF9B3075CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
        jmp       near ptr M01_L00
 M01_L14:
        mov       r8,[rsp+28]
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
-       call      00007FF9B2E61E60
+       call      00007FF9B2E51E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FF9B31D5D58]
+       call      qword ptr [7FF9B31C5D58]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,25FB4FE0008
+       mov       rax,23430470008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for AddIf method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF9B3075CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3085CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FF9B33D4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31E7190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33D4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3056718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FF9B33D4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31E7190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33D4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3056718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 405
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
-       mov       rdx,7FF9B3956D38
+       mov       rdx,7FF9B3967200
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FF9B3956D50
+       mov       rdx,7FF9B3967218
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
-       call      qword ptr [7FF9B31C5E48]
+       call      qword ptr [7FF9B31D5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FF9B3075C50]
+       call      qword ptr [7FF9B3085C50]
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
-       call      qword ptr [7FF9B2E54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF9B2E64360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FF9B3075C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FF9B3085C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3075998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3085998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        mov       [rdi],eax
 M01_L12:
        mov       eax,1
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
-       call      qword ptr [7FF9B3075CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FF9B3085CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
        jmp       near ptr M01_L00
 M01_L14:
        mov       r8,[rsp+28]
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
-       call      00007FF9B2E51E60
+       call      00007FF9B2E61E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FF9B31C5D58]
+       call      qword ptr [7FF9B31D5D58]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,2D693720008
+       mov       rax,3138BED0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for AddIf method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF9B3075CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3065CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FF9B33D4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31E7190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33D4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3056718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FF9B33D4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31E7190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33D4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3056718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 405
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
-       mov       rdx,7FF9B3956D38
+       mov       rdx,7FF9B3957370
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FF9B3956D50
+       mov       rdx,7FF9B3957388
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
-       call      qword ptr [7FF9B31C5E48]
+       call      qword ptr [7FF9B31B5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FF9B3075C50]
+       call      qword ptr [7FF9B3065C50]
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
-       call      qword ptr [7FF9B2E54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF9B2E44360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FF9B3075C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FF9B3065C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3075998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3065998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        mov       [rdi],eax
 M01_L12:
        mov       eax,1
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
-       call      qword ptr [7FF9B3075CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FF9B3065CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
        jmp       near ptr M01_L00
 M01_L14:
        mov       r8,[rsp+28]
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
-       call      00007FF9B2E51E60
+       call      00007FF9B2E41E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2EF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2EF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FF9B31C5D58]
+       call      qword ptr [7FF9B31B5D58]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,2D693720008
+       mov       rax,278A38A0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for AddIf method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF9B3075CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3095CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FF9B33D4CF0]
+       call      qword ptr [7FF9B33F4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31E7190
+       mov       rdx,7FF9B3207190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33D4AE0]
+       call      qword ptr [7FF9B33F4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3056718]
+       call      qword ptr [7FF9B3076718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FF9B33D4CF0]
+       call      qword ptr [7FF9B33F4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31E7190
+       mov       rdx,7FF9B3207190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33D4AE0]
+       call      qword ptr [7FF9B33F4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3056718]
+       call      qword ptr [7FF9B3076718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 405
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
-       mov       r11,[rdx+60]
+       mov       r11,[rdx+58]
        test      r11,r11
        je        short M01_L01
        jmp       short M01_L02
 M01_L01:
-       mov       rdx,7FF9B3956D38
+       mov       rdx,7FF9B3908E00
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
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
-       mov       r11,[rdx+68]
+       mov       r11,[rdx+60]
        test      r11,r11
        je        short M01_L06
        jmp       short M01_L07
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FF9B3956D50
+       mov       rdx,7FF9B3908E18
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
-       call      qword ptr [7FF9B31C5E48]
+       call      qword ptr [7FF9B31E5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FF9B3075C50]
+       call      qword ptr [7FF9B3095C50]
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
-       call      qword ptr [7FF9B2E54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF9B2E74360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FF9B3075C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FF9B3095C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3075998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3095998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        mov       [rdi],eax
 M01_L12:
        mov       eax,1
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
-       call      qword ptr [7FF9B3075CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FF9B3095CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
        jmp       near ptr M01_L00
 M01_L14:
        mov       r8,[rsp+28]
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
-       call      00007FF9B2E51E60
+       call      00007FF9B2E71E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FF9B31C5D58]
+       call      qword ptr [7FF9B31E5D58]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,2D693720008
+       mov       rax,215B9D00008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for AddIf method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
call      qword ptr [7FF9B33D4CF0]
        mov       ecx,28D
        mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
        mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 405
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
-       mov       r11,[rdx+60]
+       mov       r11,[rdx+58]
        test      r11,r11
        je        short M01_L01
        jmp       short M01_L02
 M01_L01:
-       mov       rdx,7FF9B3956D38
+       mov       rdx,7FF9B38D8930
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
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
-       mov       r11,[rdx+68]
+       mov       r11,[rdx+60]
        test      r11,r11
        je        short M01_L06
        jmp       short M01_L07
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FF9B3956D50
+       mov       rdx,7FF9B38D8948
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L07:
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,2D693720008
+       mov       rax,23430470008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for AddIf method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF9B3085CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3065CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 405
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
-       mov       rdx,7FF9B3967200
+       mov       rdx,7FF9B3957370
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FF9B3967218
+       mov       rdx,7FF9B3957388
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
-       call      qword ptr [7FF9B31D5E48]
+       call      qword ptr [7FF9B31B5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FF9B3085C50]
+       call      qword ptr [7FF9B3065C50]
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
-       call      qword ptr [7FF9B2E64360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF9B2E44360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FF9B3085C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FF9B3065C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3085998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3065998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        mov       [rdi],eax
 M01_L12:
        mov       eax,1
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
-       call      qword ptr [7FF9B3085CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FF9B3065CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
        jmp       near ptr M01_L00
 M01_L14:
        mov       r8,[rsp+28]
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
-       call      00007FF9B2E61E60
+       call      00007FF9B2E41E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2EF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2EF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FF9B31D5D58]
+       call      qword ptr [7FF9B31B5D58]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,3138BED0008
+       mov       rax,278A38A0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for AddIf method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF9B3085CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3095CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33F4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B3207190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33F4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3076718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33F4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B3207190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33F4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3076718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 405
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
-       mov       r11,[rdx+60]
+       mov       r11,[rdx+58]
        test      r11,r11
        je        short M01_L01
        jmp       short M01_L02
 M01_L01:
-       mov       rdx,7FF9B3967200
+       mov       rdx,7FF9B3908E00
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
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
-       mov       r11,[rdx+68]
+       mov       r11,[rdx+60]
        test      r11,r11
        je        short M01_L06
        jmp       short M01_L07
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FF9B3967218
+       mov       rdx,7FF9B3908E18
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
-       call      qword ptr [7FF9B31D5E48]
+       call      qword ptr [7FF9B31E5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FF9B3085C50]
+       call      qword ptr [7FF9B3095C50]
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
-       call      qword ptr [7FF9B2E64360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF9B2E74360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FF9B3085C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FF9B3095C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3085998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3095998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        mov       [rdi],eax
 M01_L12:
        mov       eax,1
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
-       call      qword ptr [7FF9B3085CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FF9B3095CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
        jmp       near ptr M01_L00
 M01_L14:
        mov       r8,[rsp+28]
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
-       call      00007FF9B2E61E60
+       call      00007FF9B2E71E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FF9B31D5D58]
+       call      qword ptr [7FF9B31E5D58]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,3138BED0008
+       mov       rax,215B9D00008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for AddIf method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF9B3085CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3075CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33D4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33D4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 405
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
-       mov       r11,[rdx+60]
+       mov       r11,[rdx+58]
        test      r11,r11
        je        short M01_L01
        jmp       short M01_L02
 M01_L01:
-       mov       rdx,7FF9B3967200
+       mov       rdx,7FF9B38D8930
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
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
-       mov       r11,[rdx+68]
+       mov       r11,[rdx+60]
        test      r11,r11
        je        short M01_L06
        jmp       short M01_L07
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FF9B3967218
+       mov       rdx,7FF9B38D8948
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
-       call      qword ptr [7FF9B31D5E48]
+       call      qword ptr [7FF9B31C5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FF9B3085C50]
+       call      qword ptr [7FF9B3075C50]
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
-       call      qword ptr [7FF9B2E64360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF9B2E54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FF9B3085C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FF9B3075C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3085998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3075998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        mov       [rdi],eax
 M01_L12:
        mov       eax,1
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
-       call      qword ptr [7FF9B3085CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FF9B3075CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
        jmp       near ptr M01_L00
 M01_L14:
        mov       r8,[rsp+28]
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
-       call      00007FF9B2E61E60
+       call      00007FF9B2E51E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9B2F15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FF9B31D5D58]
+       call      qword ptr [7FF9B31C5D58]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,3138BED0008
+       mov       rax,23430470008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for AddIf method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF9B3065CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3095CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FF9B33C4CF0]
+       call      qword ptr [7FF9B33F4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3347160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31D7190
+       mov       rdx,7FF9B3207190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3347160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33C4AE0]
+       call      qword ptr [7FF9B33F4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3046718]
+       call      qword ptr [7FF9B3076718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FF9B33C4CF0]
+       call      qword ptr [7FF9B33F4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3347160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31D7190
+       mov       rdx,7FF9B3207190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3347160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33C4AE0]
+       call      qword ptr [7FF9B33F4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3046718]
+       call      qword ptr [7FF9B3076718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 405
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
-       mov       r11,[rdx+60]
+       mov       r11,[rdx+58]
        test      r11,r11
        je        short M01_L01
        jmp       short M01_L02
 M01_L01:
-       mov       rdx,7FF9B3957370
+       mov       rdx,7FF9B3908E00
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
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
-       mov       r11,[rdx+68]
+       mov       r11,[rdx+60]
        test      r11,r11
        je        short M01_L06
        jmp       short M01_L07
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FF9B3957388
+       mov       rdx,7FF9B3908E18
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
-       call      qword ptr [7FF9B31B5E48]
+       call      qword ptr [7FF9B31E5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FF9B3065C50]
+       call      qword ptr [7FF9B3095C50]
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
-       call      qword ptr [7FF9B2E44360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF9B2E74360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FF9B3065C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FF9B3095C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3065998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3095998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        mov       [rdi],eax
 M01_L12:
        mov       eax,1
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
-       call      qword ptr [7FF9B3065CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FF9B3095CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
        jmp       near ptr M01_L00
 M01_L14:
        mov       r8,[rsp+28]
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
-       call      00007FF9B2E41E60
+       call      00007FF9B2E71E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9B2EF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9B2EF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FF9B31B5D58]
+       call      qword ptr [7FF9B31E5D58]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,278A38A0008
+       mov       rax,215B9D00008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for AddIf method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF9B3065CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3075CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FF9B33C4CF0]
+       call      qword ptr [7FF9B33D4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3347160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31D7190
+       mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3347160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33C4AE0]
+       call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3046718]
+       call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FF9B33C4CF0]
+       call      qword ptr [7FF9B33D4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3347160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31D7190
+       mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3347160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33C4AE0]
+       call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3046718]
+       call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 405
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
-       mov       r11,[rdx+60]
+       mov       r11,[rdx+58]
        test      r11,r11
        je        short M01_L01
        jmp       short M01_L02
 M01_L01:
-       mov       rdx,7FF9B3957370
+       mov       rdx,7FF9B38D8930
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
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
-       mov       r11,[rdx+68]
+       mov       r11,[rdx+60]
        test      r11,r11
        je        short M01_L06
        jmp       short M01_L07
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FF9B3957388
+       mov       rdx,7FF9B38D8948
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
-       call      qword ptr [7FF9B31B5E48]
+       call      qword ptr [7FF9B31C5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FF9B3065C50]
+       call      qword ptr [7FF9B3075C50]
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
-       call      qword ptr [7FF9B2E44360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF9B2E54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FF9B3065C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FF9B3075C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3065998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3075998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        mov       [rdi],eax
 M01_L12:
        mov       eax,1
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
-       call      qword ptr [7FF9B3065CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FF9B3075CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
        jmp       near ptr M01_L00
 M01_L14:
        mov       r8,[rsp+28]
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
-       call      00007FF9B2E41E60
+       call      00007FF9B2E51E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9B2EF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9B2EF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FF9B31B5D58]
+       call      qword ptr [7FF9B31C5D58]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,278A38A0008
+       mov       rax,23430470008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for AddIf method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       call      qword ptr [7FF9B3095CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3075CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FF9B33F4CF0]
+       call      qword ptr [7FF9B33D4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B3207190
+       mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33F4AE0]
+       call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3076718]
+       call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FF9B33F4CF0]
+       call      qword ptr [7FF9B33D4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B3207190
+       mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33F4AE0]
+       call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3076718]
+       call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 405
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
-       mov       rdx,7FF9B3908E00
+       mov       rdx,7FF9B38D8930
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FF9B3908E18
+       mov       rdx,7FF9B38D8948
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
-       call      qword ptr [7FF9B31E5E48]
+       call      qword ptr [7FF9B31C5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FF9B3095C50]
+       call      qword ptr [7FF9B3075C50]
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
-       call      qword ptr [7FF9B2E74360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF9B2E54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FF9B3095C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FF9B3075C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3095998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3075998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        mov       [rdi],eax
 M01_L12:
        mov       eax,1
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
-       call      qword ptr [7FF9B3095CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FF9B3075CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
        jmp       near ptr M01_L00
 M01_L14:
        mov       r8,[rsp+28]
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
-       call      00007FF9B2E71E60
+       call      00007FF9B2E51E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9B2F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9B2F25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9B2F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       rax,r15
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
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
-       call      qword ptr [7FF9B31E5D58]
+       call      qword ptr [7FF9B31C5D58]
        int       3
 M02_L02:
        test      rbx,rbx
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,215B9D00008
+       mov       rax,23430470008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FF9B3953688
-       call      qword ptr [7FF9B393D1B8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FF9B3953B10
+       call      qword ptr [7FF9B393DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        short M01_L04
 M01_L02:
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9B393DB60]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9B393E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FF9B3944B40
+       mov       rdx,7FF9B3945820
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945050
+       mov       rdx,7FF9B3945D30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FF9B3953688
-       call      qword ptr [7FF9B393D1B8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FF9B3947C70
+       call      qword ptr [7FF9B392DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FF9B331E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9B330E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        near ptr M01_L06
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        short M01_L04
 M01_L02:
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9B393DB60]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9B392E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FF9B3944B40
+       mov       rdx,7FF9B3935820
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945050
+       mov       rdx,7FF9B3935D30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FF9B33F4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B3207190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33F4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3076718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FF9B3953688
-       call      qword ptr [7FF9B393D1B8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FF9B3957C70
+       call      qword ptr [7FF9B393DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        short M01_L04
 M01_L02:
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9B393DB60]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9B393E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FF9B3944B40
+       mov       rdx,7FF9B3945820
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945050
+       mov       rdx,7FF9B3945D30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FF9B3953688
-       call      qword ptr [7FF9B393D1B8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FF9B39535C8
+       call      qword ptr [7FF9B393DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        short M01_L04
 M01_L02:
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9B393DB60]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9B393E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FF9B3944B40
+       mov       rdx,7FF9B3945700
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945050
+       mov       rdx,7FF9B3945C10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FF9B3953688
-       call      qword ptr [7FF9B393D1B8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FF9B3953B10
+       call      qword ptr [7FF9B393DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        short M01_L04
 M01_L02:
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9B393DB60]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9B393E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FF9B3944B40
+       mov       rdx,7FF9B3945820
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945050
+       mov       rdx,7FF9B3945D30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FF9B3953688
-       call      qword ptr [7FF9B393D1B8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FF9B3A82F20
+       call      qword ptr [7FF9B3A6EDD8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FF9B331E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9B330E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        near ptr M01_L06
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        short M01_L04
 M01_L02:
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9B393DB60]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9B3A6F780]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FF9B3944B40
+       mov       rdx,7FF9B3A78518
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945050
+       mov       rdx,7FF9B3A78A28
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FF9B33F4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B3207190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33F4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3076718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FF9B3953688
-       call      qword ptr [7FF9B393D1B8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FF9B3B08F50
+       call      qword ptr [7FF9B3ADE430]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FF9B331E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9B330E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        near ptr M01_L06
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        short M01_L04
 M01_L02:
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9B393DB60]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9B3ADEDD8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FF9B3944B40
+       mov       rdx,7FF9B3AF44E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945050
+       mov       rdx,7FF9B3AF49F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FF9B33F4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B3207190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33F4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3076718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FF9B3953B10
-       call      qword ptr [7FF9B393DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FF9B3947C70
+       call      qword ptr [7FF9B392DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FF9B331E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9B330E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        near ptr M01_L06
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        short M01_L04
 M01_L02:
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9B393E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9B392E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945820
+       mov       rdx,7FF9B3935820
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945D30
+       mov       rdx,7FF9B3935D30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FF9B33F4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B3207190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33F4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3076718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FF9B3953B10
+       mov       rcx,7FF9B3957C70
        call      qword ptr [7FF9B393DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FF9B3953B10
+       mov       rcx,7FF9B39535C8
        call      qword ptr [7FF9B393DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
        call      qword ptr [7FF9B393E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945820
+       mov       rdx,7FF9B3945700
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945D30
+       mov       rdx,7FF9B3945C10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff

```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FF9B3953B10
-       call      qword ptr [7FF9B393DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FF9B3A82F20
+       call      qword ptr [7FF9B3A6EDD8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FF9B331E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9B330E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        near ptr M01_L06
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        short M01_L04
 M01_L02:
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9B393E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9B3A6F780]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945820
+       mov       rdx,7FF9B3A78518
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945D30
+       mov       rdx,7FF9B3A78A28
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FF9B33F4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B3207190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33F4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3076718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FF9B3953B10
-       call      qword ptr [7FF9B393DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FF9B3B08F50
+       call      qword ptr [7FF9B3ADE430]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FF9B331E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9B330E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        near ptr M01_L06
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        short M01_L04
 M01_L02:
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9B393E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9B3ADEDD8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945820
+       mov       rdx,7FF9B3AF44E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945D30
+       mov       rdx,7FF9B3AF49F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FF9B33F4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B3207190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33F4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3076718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FF9B3947C70
-       call      qword ptr [7FF9B392DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FF9B3957C70
+       call      qword ptr [7FF9B393DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FF9B330E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9B331E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        near ptr M01_L06
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        short M01_L04
 M01_L02:
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9B392E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9B393E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FF9B3935820
+       mov       rdx,7FF9B3945820
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9B3935D30
+       mov       rdx,7FF9B3945D30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33F4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B3207190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33F4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3076718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FF9B3947C70
-       call      qword ptr [7FF9B392DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FF9B39535C8
+       call      qword ptr [7FF9B393DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FF9B330E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9B331E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        near ptr M01_L06
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        short M01_L04
 M01_L02:
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9B392E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9B393E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FF9B3935820
+       mov       rdx,7FF9B3945700
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9B3935D30
+       mov       rdx,7FF9B3945C10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33F4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B3207190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33F4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3076718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FF9B3947C70
-       call      qword ptr [7FF9B392DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FF9B3953B10
+       call      qword ptr [7FF9B393DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FF9B330E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9B331E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        near ptr M01_L06
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        short M01_L04
 M01_L02:
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9B392E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9B393E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FF9B3935820
+       mov       rdx,7FF9B3945820
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9B3935D30
+       mov       rdx,7FF9B3945D30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33F4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B3207190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33F4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3076718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FF9B3947C70
-       call      qword ptr [7FF9B392DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FF9B3A82F20
+       call      qword ptr [7FF9B3A6EDD8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        short M01_L04
 M01_L02:
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9B392E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9B3A6F780]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FF9B3935820
+       mov       rdx,7FF9B3A78518
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9B3935D30
+       mov       rdx,7FF9B3A78A28
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FF9B3947C70
-       call      qword ptr [7FF9B392DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FF9B3B08F50
+       call      qword ptr [7FF9B3ADE430]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        short M01_L04
 M01_L02:
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9B392E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9B3ADEDD8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FF9B3935820
+       mov       rdx,7FF9B3AF44E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9B3935D30
+       mov       rdx,7FF9B3AF49F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FF9B3957C70
+       mov       rcx,7FF9B39535C8
        call      qword ptr [7FF9B393DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
        call      qword ptr [7FF9B393E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945820
+       mov       rdx,7FF9B3945700
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945D30
+       mov       rdx,7FF9B3945C10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FF9B3957C70
+       mov       rcx,7FF9B3953B10
        call      qword ptr [7FF9B393DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FF9B3957C70
-       call      qword ptr [7FF9B393DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FF9B3A82F20
+       call      qword ptr [7FF9B3A6EDD8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FF9B331E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9B330E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        near ptr M01_L06
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        short M01_L04
 M01_L02:
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9B393E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9B3A6F780]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945820
+       mov       rdx,7FF9B3A78518
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945D30
+       mov       rdx,7FF9B3A78A28
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FF9B33F4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B3207190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33F4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3076718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FF9B3957C70
-       call      qword ptr [7FF9B393DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FF9B3B08F50
+       call      qword ptr [7FF9B3ADE430]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FF9B331E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9B330E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        near ptr M01_L06
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        short M01_L04
 M01_L02:
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9B393E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9B3ADEDD8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945820
+       mov       rdx,7FF9B3AF44E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945D30
+       mov       rdx,7FF9B3AF49F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FF9B33F4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B3207190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33F4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3076718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FF9B39535C8
+       mov       rcx,7FF9B3953B10
        call      qword ptr [7FF9B393DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
        call      qword ptr [7FF9B393E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945700
+       mov       rdx,7FF9B3945820
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945C10
+       mov       rdx,7FF9B3945D30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FF9B39535C8
-       call      qword ptr [7FF9B393DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FF9B3A82F20
+       call      qword ptr [7FF9B3A6EDD8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FF9B331E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9B330E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        near ptr M01_L06
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        short M01_L04
 M01_L02:
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9B393E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9B3A6F780]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945700
+       mov       rdx,7FF9B3A78518
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945C10
+       mov       rdx,7FF9B3A78A28
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FF9B33F4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B3207190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33F4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3076718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FF9B39535C8
-       call      qword ptr [7FF9B393DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FF9B3B08F50
+       call      qword ptr [7FF9B3ADE430]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FF9B331E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9B330E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        near ptr M01_L06
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        short M01_L04
 M01_L02:
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9B393E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9B3ADEDD8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945700
+       mov       rdx,7FF9B3AF44E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945C10
+       mov       rdx,7FF9B3AF49F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FF9B33F4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B3207190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33F4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3076718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FF9B3953B10
-       call      qword ptr [7FF9B393DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FF9B3A82F20
+       call      qword ptr [7FF9B3A6EDD8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FF9B331E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9B330E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        near ptr M01_L06
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        short M01_L04
 M01_L02:
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9B393E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9B3A6F780]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945820
+       mov       rdx,7FF9B3A78518
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945D30
+       mov       rdx,7FF9B3A78A28
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FF9B33F4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B3207190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33F4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3076718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FF9B3953B10
-       call      qword ptr [7FF9B393DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FF9B3B08F50
+       call      qword ptr [7FF9B3ADE430]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FF9B331E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9B330E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        near ptr M01_L06
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        short M01_L04
 M01_L02:
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9B393E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9B3ADEDD8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945820
+       mov       rdx,7FF9B3AF44E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9B3945D30
+       mov       rdx,7FF9B3AF49F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FF9B33F4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B3207190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33F4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3076718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FF9B3A82F20
-       call      qword ptr [7FF9B3A6EDD8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FF9B3B08F50
+       call      qword ptr [7FF9B3ADE430]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
        mov       rcx,[rbx+10]
        mov       rcx,[rcx+28]
        test      rcx,rcx
        je        short M01_L04
 M01_L02:
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9B3A6F780]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9B3ADEDD8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FF9B3A78518
+       mov       rdx,7FF9B3AF44E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9B3A78A28
+       mov       rdx,7FF9B3AF49F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
```
**Diff for Upsert method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rcx,7FF9B38E7DB8
-       call      qword ptr [7FF9B3905230]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FF9B391C2A8
+       call      qword ptr [7FF9B3935DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FF9B3065998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3095998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3057028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF9B3087028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3065CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3095CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FF9B33C4CF0]
+       call      qword ptr [7FF9B33F4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3347160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31D7190
+       mov       rdx,7FF9B3207190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3347160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33C4AE0]
+       call      qword ptr [7FF9B33F4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3046718]
+       call      qword ptr [7FF9B3076718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FF9B33C4CF0]
+       call      qword ptr [7FF9B33F4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3347160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31D7190
+       mov       rdx,7FF9B3207190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3347160
+       mov       rdx,7FF9B3377160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33C4AE0]
+       call      qword ptr [7FF9B33F4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3046718]
+       call      qword ptr [7FF9B3076718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rcx,7FF9B38E7DB8
-       call      qword ptr [7FF9B3905230]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FF9B390C2A8
+       call      qword ptr [7FF9B3925DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FF9B3065998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3085998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3057028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF9B3077028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3065CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3085CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FF9B33C4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3347160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31D7190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3347160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33C4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3046718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FF9B33C4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3347160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31D7190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3347160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33C4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3046718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rcx,7FF9B38E7DB8
-       call      qword ptr [7FF9B3905230]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FF9B38FBDF0
+       call      qword ptr [7FF9B3915C38]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FF9B3065998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3075998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3057028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF9B3067028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3065CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3075CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FF9B33C4CF0]
+       call      qword ptr [7FF9B33D4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3347160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31D7190
+       mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3347160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33C4AE0]
+       call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3046718]
+       call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FF9B33C4CF0]
+       call      qword ptr [7FF9B33D4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3347160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31D7190
+       mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3347160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33C4AE0]
+       call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3046718]
+       call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rcx,7FF9B38E7DB8
-       call      qword ptr [7FF9B3905230]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FF9B38FBDF0
+       call      qword ptr [7FF9B3915C38]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FF9B3065998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3075998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3057028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF9B3067028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3065CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3075CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FF9B33C4CF0]
+       call      qword ptr [7FF9B33D4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3347160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31D7190
+       mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3347160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33C4AE0]
+       call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3046718]
+       call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FF9B33C4CF0]
+       call      qword ptr [7FF9B33D4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3347160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31D7190
+       mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3347160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33C4AE0]
+       call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3046718]
+       call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rcx,7FF9B38E7DB8
-       call      qword ptr [7FF9B3905230]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FF9B3907838
+       call      qword ptr [7FF9B3925C38]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FF9B3065998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3085998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3057028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF9B3077028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3065CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3085CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FF9B33C4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3347160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31D7190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3347160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33C4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3046718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FF9B33C4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3347160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31D7190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3347160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33C4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3046718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rcx,7FF9B38E7DB8
-       call      qword ptr [7FF9B3905230]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FF9B3A530F0
+       call      qword ptr [7FF9B3A47D98]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
        call      qword ptr [7FF9B3065998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
        call      qword ptr [7FF9B3057028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
```
**Diff for Upsert method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rcx,7FF9B38E7DB8
-       call      qword ptr [7FF9B3905230]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FF9B3AAA450
+       call      qword ptr [7FF9B3AC5DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
        call      qword ptr [7FF9B3065998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
        call      qword ptr [7FF9B3057028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
```
**Diff for Upsert method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rcx,7FF9B391C2A8
-       call      qword ptr [7FF9B3935DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FF9B390C2A8
+       call      qword ptr [7FF9B3925DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FF9B3095998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3085998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3087028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF9B3077028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3095CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3085CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FF9B33F4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B3207190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33F4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3076718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FF9B33F4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B3207190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33F4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3076718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rcx,7FF9B391C2A8
-       call      qword ptr [7FF9B3935DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FF9B38FBDF0
+       call      qword ptr [7FF9B3915C38]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FF9B3095998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3075998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3087028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF9B3067028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3095CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3075CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FF9B33F4CF0]
+       call      qword ptr [7FF9B33D4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B3207190
+       mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33F4AE0]
+       call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3076718]
+       call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FF9B33F4CF0]
+       call      qword ptr [7FF9B33D4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B3207190
+       mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33F4AE0]
+       call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3076718]
+       call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rcx,7FF9B391C2A8
-       call      qword ptr [7FF9B3935DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FF9B38FBDF0
+       call      qword ptr [7FF9B3915C38]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FF9B3095998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3075998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3087028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF9B3067028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3095CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3075CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FF9B33F4CF0]
+       call      qword ptr [7FF9B33D4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B3207190
+       mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33F4AE0]
+       call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3076718]
+       call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FF9B33F4CF0]
+       call      qword ptr [7FF9B33D4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B3207190
+       mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33F4AE0]
+       call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3076718]
+       call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rcx,7FF9B391C2A8
-       call      qword ptr [7FF9B3935DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FF9B3907838
+       call      qword ptr [7FF9B3925C38]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FF9B3095998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3085998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3087028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF9B3077028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3095CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3085CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FF9B33F4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B3207190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33F4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3076718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FF9B33F4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B3207190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33F4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3076718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rcx,7FF9B391C2A8
-       call      qword ptr [7FF9B3935DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FF9B3A530F0
+       call      qword ptr [7FF9B3A47D98]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FF9B3095998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3065998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3087028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF9B3057028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3095CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3065CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FF9B33F4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B3207190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33F4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3076718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FF9B33F4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B3207190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33F4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3076718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rcx,7FF9B391C2A8
-       call      qword ptr [7FF9B3935DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FF9B3AAA450
+       call      qword ptr [7FF9B3AC5DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FF9B3095998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3065998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3087028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF9B3057028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3095CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3065CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FF9B33F4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B3207190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33F4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3076718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FF9B33F4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B3207190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3377160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33F4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3076718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rcx,7FF9B390C2A8
-       call      qword ptr [7FF9B3925DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FF9B38FBDF0
+       call      qword ptr [7FF9B3915C38]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FF9B3085998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3075998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3077028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF9B3067028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3085CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3075CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33D4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33D4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rcx,7FF9B390C2A8
-       call      qword ptr [7FF9B3925DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FF9B38FBDF0
+       call      qword ptr [7FF9B3915C38]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FF9B3085998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3075998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3077028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF9B3067028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3085CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3075CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33D4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33D4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31E7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3357160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33D4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3056718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rcx,7FF9B390C2A8
-       call      qword ptr [7FF9B3925DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FF9B3907838
+       call      qword ptr [7FF9B3925C38]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
        call      qword ptr [7FF9B3085998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
        call      qword ptr [7FF9B3077028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
```
**Diff for Upsert method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rcx,7FF9B390C2A8
-       call      qword ptr [7FF9B3925DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FF9B3A530F0
+       call      qword ptr [7FF9B3A47D98]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FF9B3085998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3065998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3077028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF9B3057028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3085CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3065CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rcx,7FF9B390C2A8
-       call      qword ptr [7FF9B3925DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FF9B3AAA450
+       call      qword ptr [7FF9B3AC5DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FF9B3085998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3065998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3077028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF9B3057028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3085CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3065CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff

```
**Diff for Upsert method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rcx,7FF9B38FBDF0
-       call      qword ptr [7FF9B3915C38]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FF9B3907838
+       call      qword ptr [7FF9B3925C38]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FF9B3075998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3085998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3067028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF9B3077028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3075CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3085CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FF9B33D4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31E7190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33D4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3056718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FF9B33D4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31E7190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33D4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3056718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rcx,7FF9B38FBDF0
-       call      qword ptr [7FF9B3915C38]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FF9B3A530F0
+       call      qword ptr [7FF9B3A47D98]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FF9B3075998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3065998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3067028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF9B3057028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3075CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3065CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FF9B33D4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31E7190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33D4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3056718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FF9B33D4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31E7190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33D4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3056718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rcx,7FF9B38FBDF0
-       call      qword ptr [7FF9B3915C38]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FF9B3AAA450
+       call      qword ptr [7FF9B3AC5DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FF9B3075998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3065998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3067028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF9B3057028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3075CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3065CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FF9B33D4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31E7190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33D4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3056718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FF9B33D4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31E7190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33D4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3056718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rcx,7FF9B38FBDF0
-       call      qword ptr [7FF9B3915C38]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FF9B3907838
+       call      qword ptr [7FF9B3925C38]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FF9B3075998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3085998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3067028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF9B3077028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3075CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3085CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FF9B33D4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31E7190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33D4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3056718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FF9B33D4CF0]
+       call      qword ptr [7FF9B33E4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31E7190
+       mov       rdx,7FF9B31F7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3367160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33D4AE0]
+       call      qword ptr [7FF9B33E4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3056718]
+       call      qword ptr [7FF9B3066718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rcx,7FF9B38FBDF0
-       call      qword ptr [7FF9B3915C38]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FF9B3A530F0
+       call      qword ptr [7FF9B3A47D98]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FF9B3075998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3065998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3067028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF9B3057028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3075CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3065CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FF9B33D4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31E7190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33D4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3056718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FF9B33D4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31E7190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33D4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3056718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rcx,7FF9B38FBDF0
-       call      qword ptr [7FF9B3915C38]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FF9B3AAA450
+       call      qword ptr [7FF9B3AC5DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FF9B3075998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3065998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3067028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF9B3057028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3075CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3065CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FF9B33D4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31E7190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33D4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3056718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FF9B33D4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31E7190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3357160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33D4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3056718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rcx,7FF9B3907838
-       call      qword ptr [7FF9B3925C38]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FF9B3A530F0
+       call      qword ptr [7FF9B3A47D98]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FF9B3085998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3065998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3077028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF9B3057028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3085CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3065CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rcx,7FF9B3907838
-       call      qword ptr [7FF9B3925C38]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FF9B3AAA450
+       call      qword ptr [7FF9B3AC5DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FF9B3085998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FF9B3065998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3077028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF9B3057028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9B3085CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FF9B3065CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,43
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FF9B33E4CF0]
+       call      qword ptr [7FF9B33C4CF0]
        mov       ecx,28D
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9B31F7190
+       mov       rdx,7FF9B31D7190
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9B3367160
+       mov       rdx,7FF9B3347160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF9B2E66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9B2E46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF9B33E4AE0]
+       call      qword ptr [7FF9B33C4AE0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9B3066718]
+       call      qword ptr [7FF9B3046718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
.NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
```diff
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
-       mov       rcx,7FF9B3A530F0
-       call      qword ptr [7FF9B3A47D98]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FF9B3AAA450
+       call      qword ptr [7FF9B3AC5DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
        call      qword ptr [7FF9B3065998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
        call      qword ptr [7FF9B3057028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
```
