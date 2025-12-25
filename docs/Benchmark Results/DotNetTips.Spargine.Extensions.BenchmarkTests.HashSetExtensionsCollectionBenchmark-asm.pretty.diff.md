## DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark-20251224-220121
**Diff for AddIf method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE009C5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE00CC69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,43
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B37000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE00CC69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B37000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00996718]
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
-       mov       rdx,7FFE012B77A0
+       mov       rdx,7FFE012A8560
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FFE012B77B8
+       mov       rdx,7FFE012A8578
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
-       call      qword ptr [7FFE00B15E48]
+       call      qword ptr [7FFE00B05E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE009C5C50]
+       call      qword ptr [7FFE009B5C50]
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
-       call      qword ptr [7FFE007A4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE00794360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE009C5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE009B5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009C5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE009C5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE009B5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
-       call      00007FFE007A1E60
+       call      00007FFE00791E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE00855B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE00855B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE00B15D58]
+       call      qword ptr [7FFE00B05D58]
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
-       mov       rax,2E69DCD0008
+       mov       rax,2B4B4EE0008
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
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE009C5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009A5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE00CC69D0]
+       call      qword ptr [7FFE00CA69D0]
        mov       ecx,43
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B37000
+       mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00986718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE00CC69D0]
+       call      qword ptr [7FFE00CA69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B37000
+       mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00986718]
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
-       mov       rdx,7FFE012B77A0
+       mov       rdx,7FFE01298A78
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FFE012B77B8
+       mov       rdx,7FFE01298A90
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
-       call      qword ptr [7FFE00B15E48]
+       call      qword ptr [7FFE00AF5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE009C5C50]
+       call      qword ptr [7FFE009A5C50]
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
-       call      qword ptr [7FFE007A4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE00784360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE009C5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE009A5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009C5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009A5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE009C5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE009A5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
-       call      00007FFE007A1E60
+       call      00007FFE00781E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE00855B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE00855B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE00B15D58]
+       call      qword ptr [7FFE00AF5D58]
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
-       mov       rax,2E69DCD0008
+       mov       rax,2232A860008
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
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE009C5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009A5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE00CC69D0]
+       call      qword ptr [7FFE00CA69D0]
        mov       ecx,43
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B37000
+       mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00986718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE00CC69D0]
+       call      qword ptr [7FFE00CA69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B37000
+       mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00986718]
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
-       mov       rdx,7FFE012B77A0
+       mov       rdx,7FFE01298948
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FFE012B77B8
+       mov       rdx,7FFE01298960
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
-       call      qword ptr [7FFE00B15E48]
+       call      qword ptr [7FFE00AF5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE009C5C50]
+       call      qword ptr [7FFE009A5C50]
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
-       call      qword ptr [7FFE007A4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE00784360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE009C5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE009A5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009C5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009A5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE009C5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE009A5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
-       call      00007FFE007A1E60
+       call      00007FFE00781E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE00855B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE00855B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE00B15D58]
+       call      qword ptr [7FFE00AF5D58]
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
-       mov       rax,2E69DCD0008
+       mov       rax,27E61660008
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
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE009C5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE00CC69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,43
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B37000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE00CC69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B37000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00996718]
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
-       mov       rdx,7FFE012B77A0
+       mov       rdx,7FFE0122AC68
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
-       mov       rdx,7FFE012B77B8
+       mov       rdx,7FFE0122AC80
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
-       call      qword ptr [7FFE00B15E48]
+       call      qword ptr [7FFE00B05E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE009C5C50]
+       call      qword ptr [7FFE009B5C50]
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
-       call      qword ptr [7FFE007A4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE00794360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE009C5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE009B5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009C5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE009C5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE009B5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
-       call      00007FFE007A1E60
+       call      00007FFE00791E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE00855B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE00855B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE00B15D58]
+       call      qword ptr [7FFE00B05D58]
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
-       mov       rax,2E69DCD0008
+       mov       rax,1E2C3B60008
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
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE009C5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009A5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE00CC69D0]
+       call      qword ptr [7FFE00CA69D0]
        mov       ecx,43
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B37000
+       mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00986718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE00CC69D0]
+       call      qword ptr [7FFE00CA69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B37000
+       mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00986718]
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
-       mov       rdx,7FFE012B77A0
+       mov       rdx,7FFE01219A10
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
-       mov       rdx,7FFE012B77B8
+       mov       rdx,7FFE01219A28
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
-       call      qword ptr [7FFE00B15E48]
+       call      qword ptr [7FFE00AF5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE009C5C50]
+       call      qword ptr [7FFE009A5C50]
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
-       call      qword ptr [7FFE007A4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE00784360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE009C5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE009A5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009C5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009A5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE009C5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE009A5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
-       call      00007FFE007A1E60
+       call      00007FFE00781E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE00855B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE00855B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE00B15D58]
+       call      qword ptr [7FFE00AF5D58]
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
-       mov       rax,2E69DCD0008
+       mov       rax,253788B0008
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
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE009C5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE00CC69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,43
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B37000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE00CC69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B37000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00996718]
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
-       mov       rdx,7FFE012B77A0
+       mov       rdx,7FFE012E0C18
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
-       mov       rdx,7FFE012B77B8
+       mov       rdx,7FFE012E0C30
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
-       call      qword ptr [7FFE00B15E48]
+       call      qword ptr [7FFE00B05E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE009C5C50]
+       call      qword ptr [7FFE009B5C50]
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
-       call      qword ptr [7FFE007A4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE00794360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE009C5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE009B5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009C5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE009C5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE009B5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
-       call      00007FFE007A1E60
+       call      00007FFE00791E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE00855B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE00855B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE00B15D58]
+       call      qword ptr [7FFE00B05D58]
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
-       mov       rax,2E69DCD0008
+       mov       rax,1B3A7540008
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
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE009C5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009A5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE00CC69D0]
+       call      qword ptr [7FFE00CA69D0]
        mov       ecx,43
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B37000
+       mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00986718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE00CC69D0]
+       call      qword ptr [7FFE00CA69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B37000
+       mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00986718]
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
-       mov       rdx,7FFE012B77A0
+       mov       rdx,7FFE012B6590
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
-       mov       rdx,7FFE012B77B8
+       mov       rdx,7FFE012B65A8
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
-       call      qword ptr [7FFE00B15E48]
+       call      qword ptr [7FFE00AF5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE009C5C50]
+       call      qword ptr [7FFE009A5C50]
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
-       call      qword ptr [7FFE007A4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE00784360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE009C5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE009A5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009C5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009A5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE009C5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE009A5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
-       call      00007FFE007A1E60
+       call      00007FFE00781E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE00855B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE00855B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE00B15D58]
+       call      qword ptr [7FFE00AF5D58]
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
-       mov       rax,2E69DCD0008
+       mov       rax,1A762B60008
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
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009A5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00CA69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00986718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00CA69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00986718]
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
-       mov       rdx,7FFE012A8560
+       mov       rdx,7FFE01298A78
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FFE012A8578
+       mov       rdx,7FFE01298A90
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
-       call      qword ptr [7FFE00B05E48]
+       call      qword ptr [7FFE00AF5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE009B5C50]
+       call      qword ptr [7FFE009A5C50]
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
-       call      qword ptr [7FFE00794360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE00784360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE009B5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE009A5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009A5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE009B5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE009A5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
-       call      00007FFE00791E60
+       call      00007FFE00781E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE00B05D58]
+       call      qword ptr [7FFE00AF5D58]
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
-       mov       rax,2B4B4EE0008
+       mov       rax,2232A860008
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
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009A5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00CA69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00986718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00CA69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00986718]
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
-       mov       rdx,7FFE012A8560
+       mov       rdx,7FFE01298948
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FFE012A8578
+       mov       rdx,7FFE01298960
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
-       call      qword ptr [7FFE00B05E48]
+       call      qword ptr [7FFE00AF5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE009B5C50]
+       call      qword ptr [7FFE009A5C50]
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
-       call      qword ptr [7FFE00794360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE00784360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE009B5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE009A5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009A5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE009B5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE009A5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
-       call      00007FFE00791E60
+       call      00007FFE00781E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE00B05D58]
+       call      qword ptr [7FFE00AF5D58]
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
-       mov       rax,2B4B4EE0008
+       mov       rax,27E61660008
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
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFE00CB69D0]
        mov       ecx,28D
        mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
        mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FFE00996718]
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
-       mov       rdx,7FFE012A8560
+       mov       rdx,7FFE0122AC68
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
-       mov       rdx,7FFE012A8578
+       mov       rdx,7FFE0122AC80
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
-       mov       rax,2B4B4EE0008
+       mov       rax,1E2C3B60008
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
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009A5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00CA69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00986718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00CA69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00986718]
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
-       mov       rdx,7FFE012A8560
+       mov       rdx,7FFE01219A10
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
-       mov       rdx,7FFE012A8578
+       mov       rdx,7FFE01219A28
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
-       call      qword ptr [7FFE00B05E48]
+       call      qword ptr [7FFE00AF5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE009B5C50]
+       call      qword ptr [7FFE009A5C50]
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
-       call      qword ptr [7FFE00794360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE00784360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE009B5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE009A5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009A5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE009B5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE009A5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
-       call      00007FFE00791E60
+       call      00007FFE00781E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE00B05D58]
+       call      qword ptr [7FFE00AF5D58]
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
-       mov       rax,2B4B4EE0008
+       mov       rax,253788B0008
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
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFE00CB69D0]
        mov       ecx,28D
        mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
        mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FFE00996718]
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
-       mov       rdx,7FFE012A8560
+       mov       rdx,7FFE012E0C18
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
-       mov       rdx,7FFE012A8578
+       mov       rdx,7FFE012E0C30
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
-       mov       rax,2B4B4EE0008
+       mov       rax,1B3A7540008
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
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009A5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00CA69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00986718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00CA69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00986718]
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
-       mov       rdx,7FFE012A8560
+       mov       rdx,7FFE012B6590
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
-       mov       rdx,7FFE012A8578
+       mov       rdx,7FFE012B65A8
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
-       call      qword ptr [7FFE00B05E48]
+       call      qword ptr [7FFE00AF5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE009B5C50]
+       call      qword ptr [7FFE009A5C50]
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
-       call      qword ptr [7FFE00794360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE00784360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE009B5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE009A5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009A5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE009B5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE009A5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
-       call      00007FFE00791E60
+       call      00007FFE00781E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE00B05D58]
+       call      qword ptr [7FFE00AF5D58]
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
-       mov       rax,2B4B4EE0008
+       mov       rax,1A762B60008
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
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       mov       rdx,7FFE01298A78
+       mov       rdx,7FFE01298948
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FFE01298A90
+       mov       rdx,7FFE01298960
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
-       mov       rax,2232A860008
+       mov       rax,27E61660008
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
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE009A5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE00CA69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B17000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE00CA69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B17000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00996718]
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
-       mov       rdx,7FFE01298A78
+       mov       rdx,7FFE0122AC68
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
-       mov       rdx,7FFE01298A90
+       mov       rdx,7FFE0122AC80
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
-       call      qword ptr [7FFE00AF5E48]
+       call      qword ptr [7FFE00B05E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE009A5C50]
+       call      qword ptr [7FFE009B5C50]
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
-       call      qword ptr [7FFE00784360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE00794360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE009A5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE009B5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009A5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE009A5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE009B5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
-       call      00007FFE00781E60
+       call      00007FFE00791E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE00AF5D58]
+       call      qword ptr [7FFE00B05D58]
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
-       mov       rax,2232A860008
+       mov       rax,1E2C3B60008
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
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFE00CA69D0]
        mov       ecx,28D
        mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
        mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FFE00986718]
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
-       mov       rdx,7FFE01298A78
+       mov       rdx,7FFE01219A10
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
-       mov       rdx,7FFE01298A90
+       mov       rdx,7FFE01219A28
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
-       mov       rax,2232A860008
+       mov       rax,253788B0008
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
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE009A5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE00CA69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B17000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE00CA69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B17000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00996718]
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
-       mov       rdx,7FFE01298A78
+       mov       rdx,7FFE012E0C18
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
-       mov       rdx,7FFE01298A90
+       mov       rdx,7FFE012E0C30
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
-       call      qword ptr [7FFE00AF5E48]
+       call      qword ptr [7FFE00B05E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE009A5C50]
+       call      qword ptr [7FFE009B5C50]
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
-       call      qword ptr [7FFE00784360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE00794360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE009A5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE009B5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009A5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE009A5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE009B5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
-       call      00007FFE00781E60
+       call      00007FFE00791E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE00AF5D58]
+       call      qword ptr [7FFE00B05D58]
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
-       mov       rax,2232A860008
+       mov       rax,1B3A7540008
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
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFE00CA69D0]
        mov       ecx,28D
        mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
        mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FFE00986718]
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
-       mov       rdx,7FFE01298A78
+       mov       rdx,7FFE012B6590
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
-       mov       rdx,7FFE01298A90
+       mov       rdx,7FFE012B65A8
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
-       mov       rax,2232A860008
+       mov       rax,1A762B60008
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
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE009A5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE00CA69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B17000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE00CA69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B17000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00996718]
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
-       mov       rdx,7FFE01298948
+       mov       rdx,7FFE0122AC68
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
-       mov       rdx,7FFE01298960
+       mov       rdx,7FFE0122AC80
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
-       call      qword ptr [7FFE00AF5E48]
+       call      qword ptr [7FFE00B05E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE009A5C50]
+       call      qword ptr [7FFE009B5C50]
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
-       call      qword ptr [7FFE00784360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE00794360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE009A5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE009B5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009A5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE009A5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE009B5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
-       call      00007FFE00781E60
+       call      00007FFE00791E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE00AF5D58]
+       call      qword ptr [7FFE00B05D58]
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
-       mov       rax,27E61660008
+       mov       rax,1E2C3B60008
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
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFE00CA69D0]
        mov       ecx,28D
        mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
        mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FFE00986718]
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
-       mov       rdx,7FFE01298948
+       mov       rdx,7FFE01219A10
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
-       mov       rdx,7FFE01298960
+       mov       rdx,7FFE01219A28
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
-       mov       rax,27E61660008
+       mov       rax,253788B0008
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
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE009A5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE00CA69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B17000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE00CA69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B17000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00996718]
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
-       mov       rdx,7FFE01298948
+       mov       rdx,7FFE012E0C18
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
-       mov       rdx,7FFE01298960
+       mov       rdx,7FFE012E0C30
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
-       call      qword ptr [7FFE00AF5E48]
+       call      qword ptr [7FFE00B05E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE009A5C50]
+       call      qword ptr [7FFE009B5C50]
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
-       call      qword ptr [7FFE00784360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE00794360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE009A5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE009B5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009A5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE009A5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE009B5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
-       call      00007FFE00781E60
+       call      00007FFE00791E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE00AF5D58]
+       call      qword ptr [7FFE00B05D58]
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
-       mov       rax,27E61660008
+       mov       rax,1B3A7540008
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
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFE00CA69D0]
        mov       ecx,28D
        mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
        mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FFE00986718]
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
-       mov       rdx,7FFE01298948
+       mov       rdx,7FFE012B6590
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
-       mov       rdx,7FFE01298960
+       mov       rdx,7FFE012B65A8
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
-       mov       rax,27E61660008
+       mov       rax,1A762B60008
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
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009A5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00CA69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00986718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00CA69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00986718]
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
-       mov       rdx,7FFE0122AC68
+       mov       rdx,7FFE01219A10
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FFE0122AC80
+       mov       rdx,7FFE01219A28
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
-       call      qword ptr [7FFE00B05E48]
+       call      qword ptr [7FFE00AF5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE009B5C50]
+       call      qword ptr [7FFE009A5C50]
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
-       call      qword ptr [7FFE00794360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE00784360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE009B5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE009A5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009A5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE009B5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE009A5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
-       call      00007FFE00791E60
+       call      00007FFE00781E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE00B05D58]
+       call      qword ptr [7FFE00AF5D58]
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
-       mov       rax,1E2C3B60008
+       mov       rax,253788B0008
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
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
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
-       mov       rdx,7FFE0122AC68
+       mov       rdx,7FFE012E0C18
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FFE0122AC80
+       mov       rdx,7FFE012E0C30
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
-       mov       rax,1E2C3B60008
+       mov       rax,1B3A7540008
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
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009A5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00CA69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00986718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00CA69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00986718]
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
-       mov       rdx,7FFE0122AC68
+       mov       rdx,7FFE012B6590
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FFE0122AC80
+       mov       rdx,7FFE012B65A8
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
-       call      qword ptr [7FFE00B05E48]
+       call      qword ptr [7FFE00AF5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE009B5C50]
+       call      qword ptr [7FFE009A5C50]
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
-       call      qword ptr [7FFE00794360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE00784360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE009B5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE009A5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009A5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE009B5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE009A5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
-       call      00007FFE00791E60
+       call      00007FFE00781E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE00B05D58]
+       call      qword ptr [7FFE00AF5D58]
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
-       mov       rax,1E2C3B60008
+       mov       rax,1A762B60008
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
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE009A5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE00CA69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B17000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE00CA69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B17000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00996718]
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
-       mov       rdx,7FFE01219A10
+       mov       rdx,7FFE012E0C18
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FFE01219A28
+       mov       rdx,7FFE012E0C30
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
-       call      qword ptr [7FFE00AF5E48]
+       call      qword ptr [7FFE00B05E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE009A5C50]
+       call      qword ptr [7FFE009B5C50]
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
-       call      qword ptr [7FFE00784360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE00794360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE009A5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE009B5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009A5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE009A5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE009B5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
-       call      00007FFE00781E60
+       call      00007FFE00791E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE00AF5D58]
+       call      qword ptr [7FFE00B05D58]
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
-       mov       rax,253788B0008
+       mov       rax,1B3A7540008
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
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
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
-       mov       rdx,7FFE01219A10
+       mov       rdx,7FFE012B6590
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FFE01219A28
+       mov       rdx,7FFE012B65A8
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
-       mov       rax,253788B0008
+       mov       rax,1A762B60008
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
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009A5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00CA69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00986718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00CA69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00986718]
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
-       mov       rdx,7FFE012E0C18
+       mov       rdx,7FFE012B6590
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FFE012E0C30
+       mov       rdx,7FFE012B65A8
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
-       call      qword ptr [7FFE00B05E48]
+       call      qword ptr [7FFE00AF5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE009B5C50]
+       call      qword ptr [7FFE009A5C50]
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
-       call      qword ptr [7FFE00794360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE00784360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE009B5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE009A5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009A5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE009B5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE009A5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
-       call      00007FFE00791E60
+       call      00007FFE00781E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE00B05D58]
+       call      qword ptr [7FFE00AF5D58]
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
-       mov       rax,1B3A7540008
+       mov       rax,1A762B60008
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
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FFE01277C70
-       call      qword ptr [7FFE0125DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FFE01257C70
+       call      qword ptr [7FFE0123DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE00C3E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE00C1E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE0125E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE0123E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE01265B80
+       mov       rdx,7FFE01245B80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE01266090
+       mov       rdx,7FFE01246090
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00C969D0]
        mov       ecx,43
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B07000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00C967C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00976718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FFE01277C70
-       call      qword ptr [7FFE0125DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FFE01257C70
+       call      qword ptr [7FFE0123DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE00C3E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE00C1E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE0125E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE0123E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE01265B80
+       mov       rdx,7FFE01245B80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE01266090
+       mov       rdx,7FFE01246090
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00C969D0]
        mov       ecx,43
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B07000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00C967C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00976718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FFE01277C70
-       call      qword ptr [7FFE0125DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FFE01287650
+       call      qword ptr [7FFE0126DCC8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE00C3E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE00C4E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE0125E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE0126E670]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE01265B80
+       mov       rdx,7FFE01275B00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE01266090
+       mov       rdx,7FFE01276010
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00CC69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B37000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FFE01277C70
-       call      qword ptr [7FFE0125DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FFE013AAB70
+       call      qword ptr [7FFE013B4150]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE00C3E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE00C2E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE0125E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE013B4AF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE01265B80
+       mov       rdx,7FFE01398540
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE01266090
+       mov       rdx,7FFE01398A50
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00CA69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00986718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FFE01277C70
-       call      qword ptr [7FFE0125DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FFE01449A50
+       call      qword ptr [7FFE0142DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE00C3E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE00C4E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE0125E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE0142E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE01265B80
+       mov       rdx,7FFE01434BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE01266090
+       mov       rdx,7FFE014350F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00CC69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B37000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FFE01277C70
-       call      qword ptr [7FFE0125DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FFE01461648
+       call      qword ptr [7FFE0142EDD8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE0125E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE0142F780]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE01265B80
+       mov       rdx,7FFE01452900
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE01266090
+       mov       rdx,7FFE01452E10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FFE01277C70
-       call      qword ptr [7FFE0125DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FFE01531ED0
+       call      qword ptr [7FFE015251B8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE00C3E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE00C1E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE0125E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE01525B60]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE01265B80
+       mov       rdx,7FFE01518518
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE01266090
+       mov       rdx,7FFE01518A28
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00C969D0]
        mov       ecx,43
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B07000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00C967C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00976718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff

```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FFE01257C70
-       call      qword ptr [7FFE0123DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FFE01287650
+       call      qword ptr [7FFE0126DCC8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE00C1E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE00C4E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE0123E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE0126E670]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE01245B80
+       mov       rdx,7FFE01275B00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE01246090
+       mov       rdx,7FFE01276010
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE00C969D0]
+       call      qword ptr [7FFE00CC69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B07000
+       mov       rdx,7FFE00B37000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00C967C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00976718]
+       call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FFE01257C70
-       call      qword ptr [7FFE0123DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FFE013AAB70
+       call      qword ptr [7FFE013B4150]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE00C1E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE00C2E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE0123E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE013B4AF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE01245B80
+       mov       rdx,7FFE01398540
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE01246090
+       mov       rdx,7FFE01398A50
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE00C969D0]
+       call      qword ptr [7FFE00CA69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B07000
+       mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00C967C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00976718]
+       call      qword ptr [7FFE00986718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FFE01257C70
-       call      qword ptr [7FFE0123DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FFE01449A50
+       call      qword ptr [7FFE0142DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE00C1E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE00C4E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE0123E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE0142E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE01245B80
+       mov       rdx,7FFE01434BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE01246090
+       mov       rdx,7FFE014350F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE00C969D0]
+       call      qword ptr [7FFE00CC69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B07000
+       mov       rdx,7FFE00B37000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00C967C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00976718]
+       call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FFE01257C70
-       call      qword ptr [7FFE0123DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FFE01461648
+       call      qword ptr [7FFE0142EDD8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE00C1E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE00C3E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE0123E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE0142F780]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE01245B80
+       mov       rdx,7FFE01452900
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE01246090
+       mov       rdx,7FFE01452E10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE00C969D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B07000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00C967C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00976718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FFE01257C70
-       call      qword ptr [7FFE0123DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FFE01531ED0
+       call      qword ptr [7FFE015251B8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE0123E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE01525B60]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE01245B80
+       mov       rdx,7FFE01518518
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE01246090
+       mov       rdx,7FFE01518A28
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FFE01257C70
-       call      qword ptr [7FFE0123DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FFE01287650
+       call      qword ptr [7FFE0126DCC8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE00C1E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE00C4E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE0123E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE0126E670]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE01245B80
+       mov       rdx,7FFE01275B00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE01246090
+       mov       rdx,7FFE01276010
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE00C969D0]
+       call      qword ptr [7FFE00CC69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B07000
+       mov       rdx,7FFE00B37000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00C967C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00976718]
+       call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FFE01257C70
-       call      qword ptr [7FFE0123DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FFE013AAB70
+       call      qword ptr [7FFE013B4150]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE00C1E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE00C2E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE0123E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE013B4AF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE01245B80
+       mov       rdx,7FFE01398540
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE01246090
+       mov       rdx,7FFE01398A50
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE00C969D0]
+       call      qword ptr [7FFE00CA69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B07000
+       mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00C967C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00976718]
+       call      qword ptr [7FFE00986718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FFE01257C70
-       call      qword ptr [7FFE0123DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FFE01449A50
+       call      qword ptr [7FFE0142DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE00C1E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE00C4E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE0123E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE0142E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE01245B80
+       mov       rdx,7FFE01434BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE01246090
+       mov       rdx,7FFE014350F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE00C969D0]
+       call      qword ptr [7FFE00CC69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B07000
+       mov       rdx,7FFE00B37000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00C967C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00976718]
+       call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FFE01257C70
-       call      qword ptr [7FFE0123DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FFE01461648
+       call      qword ptr [7FFE0142EDD8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE00C1E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE00C3E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE0123E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE0142F780]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE01245B80
+       mov       rdx,7FFE01452900
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE01246090
+       mov       rdx,7FFE01452E10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE00C969D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B07000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00C967C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00976718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FFE01257C70
-       call      qword ptr [7FFE0123DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FFE01531ED0
+       call      qword ptr [7FFE015251B8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE0123E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE01525B60]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE01245B80
+       mov       rdx,7FFE01518518
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE01246090
+       mov       rdx,7FFE01518A28
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FFE01287650
-       call      qword ptr [7FFE0126DCC8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FFE013AAB70
+       call      qword ptr [7FFE013B4150]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE00C4E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE00C2E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE0126E670]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE013B4AF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE01275B00
+       mov       rdx,7FFE01398540
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE01276010
+       mov       rdx,7FFE01398A50
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE00CC69D0]
+       call      qword ptr [7FFE00CA69D0]
        mov       ecx,43
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B37000
+       mov       rdx,7FFE00B17000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C87160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CA67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00986718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FFE01287650
-       call      qword ptr [7FFE0126DCC8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FFE01449A50
+       call      qword ptr [7FFE0142DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE0126E670]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE0142E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE01275B00
+       mov       rdx,7FFE01434BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE01276010
+       mov       rdx,7FFE014350F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FFE01287650
-       call      qword ptr [7FFE0126DCC8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FFE01461648
+       call      qword ptr [7FFE0142EDD8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE00C4E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE00C3E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE0126E670]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE0142F780]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE01275B00
+       mov       rdx,7FFE01452900
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE01276010
+       mov       rdx,7FFE01452E10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE00CC69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,43
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B37000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FFE01287650
-       call      qword ptr [7FFE0126DCC8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FFE01531ED0
+       call      qword ptr [7FFE015251B8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE00C4E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE00C1E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE0126E670]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE01525B60]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE01275B00
+       mov       rdx,7FFE01518518
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE01276010
+       mov       rdx,7FFE01518A28
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE00CC69D0]
+       call      qword ptr [7FFE00C969D0]
        mov       ecx,43
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B37000
+       mov       rdx,7FFE00B07000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00C967C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00976718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FFE013AAB70
-       call      qword ptr [7FFE013B4150]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FFE01449A50
+       call      qword ptr [7FFE0142DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE00C2E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE00C4E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE013B4AF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE0142E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE01398540
+       mov       rdx,7FFE01434BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE01398A50
+       mov       rdx,7FFE014350F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE00CA69D0]
+       call      qword ptr [7FFE00CC69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B17000
+       mov       rdx,7FFE00B37000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FFE013AAB70
-       call      qword ptr [7FFE013B4150]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FFE01461648
+       call      qword ptr [7FFE0142EDD8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE00C2E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE00C3E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE013B4AF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE0142F780]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE01398540
+       mov       rdx,7FFE01452900
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE01398A50
+       mov       rdx,7FFE01452E10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE00CA69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B17000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FFE013AAB70
-       call      qword ptr [7FFE013B4150]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FFE01531ED0
+       call      qword ptr [7FFE015251B8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE00C2E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE00C1E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE013B4AF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE01525B60]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE01398540
+       mov       rdx,7FFE01518518
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE01398A50
+       mov       rdx,7FFE01518A28
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE00CA69D0]
+       call      qword ptr [7FFE00C969D0]
        mov       ecx,43
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B17000
+       mov       rdx,7FFE00B07000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00C967C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00976718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FFE01449A50
-       call      qword ptr [7FFE0142DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FFE01461648
+       call      qword ptr [7FFE0142EDD8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE00C4E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE00C3E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE0142E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE0142F780]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE01434BE0
+       mov       rdx,7FFE01452900
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE014350F0
+       mov       rdx,7FFE01452E10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE00CC69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,43
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B37000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FFE01449A50
-       call      qword ptr [7FFE0142DEA8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FFE01531ED0
+       call      qword ptr [7FFE015251B8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE00C4E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE00C1E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE0142E850]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE01525B60]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE01434BE0
+       mov       rdx,7FFE01518518
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE014350F0
+       mov       rdx,7FFE01518A28
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE00CC69D0]
+       call      qword ptr [7FFE00C969D0]
        mov       ecx,43
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B37000
+       mov       rdx,7FFE00B07000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00C967C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00976718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
-       mov       rcx,7FFE01461648
-       call      qword ptr [7FFE0142EDD8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       mov       rcx,7FFE01531ED0
+       call      qword ptr [7FFE015251B8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE00C3E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE00C1E418]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE0142F780]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE01525B60]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE01452900
+       mov       rdx,7FFE01518518
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE01452E10
+       mov       rdx,7FFE01518A28
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00C969D0]
        mov       ecx,43
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B07000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00C967C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00976718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for Upsert method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       mov       rcx,7FFE0122BD70
-       call      qword ptr [7FFE012458D8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FFE0123C2A8
+       call      qword ptr [7FFE01255DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE009A5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE00997028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE009A7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009A5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE00CA69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B17000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE00CA69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B17000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       mov       rcx,7FFE0122BD70
-       call      qword ptr [7FFE012458D8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FFE0121C2A8
+       call      qword ptr [7FFE01235DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE009A5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE00995998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE00997028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE00987028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009A5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE00995CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE00CA69D0]
+       call      qword ptr [7FFE00C969D0]
        mov       ecx,43
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B17000
+       mov       rdx,7FFE00B07000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00C967C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00976718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE00CA69D0]
+       call      qword ptr [7FFE00C969D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B17000
+       mov       rdx,7FFE00B07000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00C967C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00976718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       mov       rcx,7FFE0122BD70
-       call      qword ptr [7FFE012458D8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FFE0121C2A8
+       call      qword ptr [7FFE01235DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE009A5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE00995998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE00997028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE00987028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009A5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE00995CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE00CA69D0]
+       call      qword ptr [7FFE00C969D0]
        mov       ecx,43
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B17000
+       mov       rdx,7FFE00B07000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00C967C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00976718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE00CA69D0]
+       call      qword ptr [7FFE00C969D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B17000
+       mov       rdx,7FFE00B07000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00C967C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00976718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       mov       rcx,7FFE0122BD70
-       call      qword ptr [7FFE012458D8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FFE013B4978
+       call      qword ptr [7FFE013AC4E0]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE009A5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009C5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE00997028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE009B7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009A5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009C5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE00CA69D0]
+       call      qword ptr [7FFE00CC69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B17000
+       mov       rdx,7FFE00B37000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE00CA69D0]
+       call      qword ptr [7FFE00CC69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B17000
+       mov       rdx,7FFE00B37000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       mov       rcx,7FFE0122BD70
-       call      qword ptr [7FFE012458D8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FFE0140E698
+       call      qword ptr [7FFE01425DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE009A5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009C5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE00997028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE009B7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009A5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009C5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE00CA69D0]
+       call      qword ptr [7FFE00CC69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B17000
+       mov       rdx,7FFE00B37000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE00CA69D0]
+       call      qword ptr [7FFE00CC69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B17000
+       mov       rdx,7FFE00B37000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       mov       rcx,7FFE0122BD70
-       call      qword ptr [7FFE012458D8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FFE01435D30
+       call      qword ptr [7FFE01426D60]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE009A5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE00997028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE009A7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009A5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE00CA69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B17000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE00CA69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B17000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       mov       rcx,7FFE0122BD70
-       call      qword ptr [7FFE012458D8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FFE01526778
+       call      qword ptr [7FFE0150D8D8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE009A5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE00997028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE009A7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009A5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE00CA69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B17000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE00CA69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B17000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C87160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CA67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00986718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       mov       rcx,7FFE0123C2A8
-       call      qword ptr [7FFE01255DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FFE0121C2A8
+       call      qword ptr [7FFE01235DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE00995998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009A7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE00987028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE00995CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00C969D0]
        mov       ecx,43
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B07000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00C967C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00976718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00C969D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B07000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00C967C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00976718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       mov       rcx,7FFE0123C2A8
-       call      qword ptr [7FFE01255DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FFE0121C2A8
+       call      qword ptr [7FFE01235DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE00995998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009A7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE00987028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE00995CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00C969D0]
        mov       ecx,43
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B07000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00C967C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00976718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00C969D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B07000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00C77160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00C967C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE00976718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       mov       rcx,7FFE0123C2A8
-       call      qword ptr [7FFE01255DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FFE013B4978
+       call      qword ptr [7FFE013AC4E0]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009C5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009A7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE009B7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009C5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00CC69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B37000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00CC69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B37000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       mov       rcx,7FFE0123C2A8
-       call      qword ptr [7FFE01255DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FFE0140E698
+       call      qword ptr [7FFE01425DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009C5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009A7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE009B7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009C5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00CC69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B37000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE00CB69D0]
+       call      qword ptr [7FFE00CC69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B27000
+       mov       rdx,7FFE00B37000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C97160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CB67C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00996718]
+       call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       mov       rcx,7FFE0123C2A8
-       call      qword ptr [7FFE01255DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FFE01435D30
+       call      qword ptr [7FFE01426D60]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
        call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
        call      qword ptr [7FFE009A7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
```
**Diff for Upsert method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       mov       rcx,7FFE0123C2A8
-       call      qword ptr [7FFE01255DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FFE01526778
+       call      qword ptr [7FFE0150D8D8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
        call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
        call      qword ptr [7FFE009A7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
```
**Diff for Upsert method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```diff

```
**Diff for Upsert method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       mov       rcx,7FFE0121C2A8
-       call      qword ptr [7FFE01235DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FFE013B4978
+       call      qword ptr [7FFE013AC4E0]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE00995998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009C5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE00987028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE009B7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE00995CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009C5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE00C969D0]
+       call      qword ptr [7FFE00CC69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B07000
+       mov       rdx,7FFE00B37000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00C967C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00976718]
+       call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE00C969D0]
+       call      qword ptr [7FFE00CC69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B07000
+       mov       rdx,7FFE00B37000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00C967C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00976718]
+       call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       mov       rcx,7FFE0121C2A8
-       call      qword ptr [7FFE01235DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FFE0140E698
+       call      qword ptr [7FFE01425DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE00995998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009C5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE00987028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE009B7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE00995CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009C5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE00C969D0]
+       call      qword ptr [7FFE00CC69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B07000
+       mov       rdx,7FFE00B37000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00C967C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00976718]
+       call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE00C969D0]
+       call      qword ptr [7FFE00CC69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B07000
+       mov       rdx,7FFE00B37000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00C967C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00976718]
+       call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       mov       rcx,7FFE0121C2A8
-       call      qword ptr [7FFE01235DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FFE01435D30
+       call      qword ptr [7FFE01426D60]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE00995998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE00987028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE009A7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE00995CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE00C969D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B07000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00C967C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00976718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE00C969D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B07000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00C967C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00976718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       mov       rcx,7FFE0121C2A8
-       call      qword ptr [7FFE01235DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FFE01526778
+       call      qword ptr [7FFE0150D8D8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE00995998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE00987028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE009A7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE00995CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE00C969D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B07000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00C967C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00976718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE00C969D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B07000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00C967C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00976718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       mov       rcx,7FFE0121C2A8
-       call      qword ptr [7FFE01235DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FFE013B4978
+       call      qword ptr [7FFE013AC4E0]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE00995998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009C5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE00987028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE009B7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE00995CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009C5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE00C969D0]
+       call      qword ptr [7FFE00CC69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B07000
+       mov       rdx,7FFE00B37000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00C967C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00976718]
+       call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE00C969D0]
+       call      qword ptr [7FFE00CC69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B07000
+       mov       rdx,7FFE00B37000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00C967C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00976718]
+       call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       mov       rcx,7FFE0121C2A8
-       call      qword ptr [7FFE01235DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FFE0140E698
+       call      qword ptr [7FFE01425DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE00995998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009C5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE00987028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE009B7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE00995CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009C5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE00C969D0]
+       call      qword ptr [7FFE00CC69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B07000
+       mov       rdx,7FFE00B37000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00C967C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00976718]
+       call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE00C969D0]
+       call      qword ptr [7FFE00CC69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B07000
+       mov       rdx,7FFE00B37000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00CA7160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00C967C0]
+       call      qword ptr [7FFE00CC67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00976718]
+       call      qword ptr [7FFE009A6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       mov       rcx,7FFE0121C2A8
-       call      qword ptr [7FFE01235DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FFE01435D30
+       call      qword ptr [7FFE01426D60]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE00995998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE00987028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE009A7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE00995CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE00C969D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B07000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00C967C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00976718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE00C969D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B07000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00C967C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00976718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       mov       rcx,7FFE0121C2A8
-       call      qword ptr [7FFE01235DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FFE01526778
+       call      qword ptr [7FFE0150D8D8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE00995998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE00987028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE009A7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE00995CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE00C969D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,43
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B07000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00C967C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00976718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE00C969D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B07000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00C77160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00C967C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE00976718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       mov       rcx,7FFE013B4978
-       call      qword ptr [7FFE013AC4E0]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FFE0140E698
+       call      qword ptr [7FFE01425DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
        call      qword ptr [7FFE009C5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
        call      qword ptr [7FFE009B7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
```
**Diff for Upsert method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       mov       rcx,7FFE013B4978
-       call      qword ptr [7FFE013AC4E0]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FFE01435D30
+       call      qword ptr [7FFE01426D60]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE009C5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009B7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE009A7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009C5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE00CC69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,43
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B37000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE00CC69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B37000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       mov       rcx,7FFE013B4978
-       call      qword ptr [7FFE013AC4E0]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FFE01526778
+       call      qword ptr [7FFE0150D8D8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE009C5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009B7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE009A7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009C5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE00CC69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,43
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B37000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE00CC69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B37000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       mov       rcx,7FFE0140E698
-       call      qword ptr [7FFE01425DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FFE01435D30
+       call      qword ptr [7FFE01426D60]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE009C5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009B7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE009A7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009C5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE00CC69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,43
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B37000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE00CC69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B37000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       mov       rcx,7FFE0140E698
-       call      qword ptr [7FFE01425DE8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FFE01526778
+       call      qword ptr [7FFE0150D8D8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE009C5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009B7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE009A7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE009C5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE009B5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE00CC69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,43
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B37000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE00CC69D0]
+       call      qword ptr [7FFE00CB69D0]
        mov       ecx,28D
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FFE00B37000
+       mov       rdx,7FFE00B27000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE00CA7160
+       mov       rdx,7FFE00C97160
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE00CC67C0]
+       call      qword ptr [7FFE00CB67C0]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE009A6718]
+       call      qword ptr [7FFE00996718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
.NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
-       mov       rcx,7FFE01435D30
-       call      qword ptr [7FFE01426D60]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       mov       rcx,7FFE01526778
+       call      qword ptr [7FFE0150D8D8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
        call      qword ptr [7FFE009B5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
        call      qword ptr [7FFE009A7028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
```
