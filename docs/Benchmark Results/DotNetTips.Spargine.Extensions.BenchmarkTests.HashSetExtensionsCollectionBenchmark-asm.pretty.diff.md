## DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark-20250411-232914
**Diff for AddIf method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE7DCA5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC95CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE7DFAF990]
+       call      qword ptr [7FFE7DF9F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE16D80
+       mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DFAF780]
+       call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC86718]
+       call      qword ptr [7FFE7DC76718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE7DFAF990]
+       call      qword ptr [7FFE7DF9F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE16D80
+       mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DFAF780]
+       call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC86718]
+       call      qword ptr [7FFE7DC76718]
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
-       mov       rdx,7FFE7E5739E0
+       mov       rdx,7FFE7E572F08
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FFE7E5739F8
+       mov       rdx,7FFE7E572F20
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
-       call      qword ptr [7FFE7DDF5E48]
+       call      qword ptr [7FFE7DDE5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE7DCA5C50]
+       call      qword ptr [7FFE7DC95C50]
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
-       call      qword ptr [7FFE7DA84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE7DA74360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE7DCA5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE7DC95C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DCA5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC95998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE7DCA5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE7DC95CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE7DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE7DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE7DDF5D58]
+       call      qword ptr [7FFE7DDE5D58]
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
-       mov       rax,21293660008
+       mov       rax,1C2A97F0008
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE7DCA5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC65CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE7DFAF990]
+       call      qword ptr [7FFE7DF6F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF46F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE16D80
+       mov       rdx,7FFE7DDD6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF46F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DFAF780]
+       call      qword ptr [7FFE7DF6F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC86718]
+       call      qword ptr [7FFE7DC46718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE7DFAF990]
+       call      qword ptr [7FFE7DF6F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF46F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE16D80
+       mov       rdx,7FFE7DDD6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF46F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DFAF780]
+       call      qword ptr [7FFE7DF6F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC86718]
+       call      qword ptr [7FFE7DC46718]
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
-       mov       rdx,7FFE7E5739E0
+       mov       rdx,7FFE7E532FA8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FFE7E5739F8
+       mov       rdx,7FFE7E532FC0
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
-       call      qword ptr [7FFE7DDF5E48]
+       call      qword ptr [7FFE7DDB5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE7DCA5C50]
+       call      qword ptr [7FFE7DC65C50]
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
-       call      qword ptr [7FFE7DA84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE7DA44360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE7DCA5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE7DC65C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DCA5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC65998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE7DCA5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE7DC65CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE7DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DAF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE7DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DAF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE7DDF5D58]
+       call      qword ptr [7FFE7DDB5D58]
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
-       mov       rax,21293660008
+       mov       rax,2A306510008
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE7DCA5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC95CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE7DFAF990]
+       call      qword ptr [7FFE7DF9F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE16D80
+       mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DFAF780]
+       call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC86718]
+       call      qword ptr [7FFE7DC76718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE7DFAF990]
+       call      qword ptr [7FFE7DF9F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE16D80
+       mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DFAF780]
+       call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC86718]
+       call      qword ptr [7FFE7DC76718]
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
-       mov       rdx,7FFE7E5739E0
+       mov       rdx,7FFE7E562FD8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FFE7E5739F8
+       mov       rdx,7FFE7E562FF0
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
-       call      qword ptr [7FFE7DDF5E48]
+       call      qword ptr [7FFE7DDE5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE7DCA5C50]
+       call      qword ptr [7FFE7DC95C50]
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
-       call      qword ptr [7FFE7DA84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE7DA74360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE7DCA5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE7DC95C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DCA5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC95998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE7DCA5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE7DC95CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE7DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE7DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE7DDF5D58]
+       call      qword ptr [7FFE7DDE5D58]
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
-       mov       rax,21293660008
+       mov       rax,201DE620008
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE7DCA5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC75CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE7DFAF990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE16D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DFAF780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC86718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE7DFAF990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE16D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DFAF780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC86718]
+       call      qword ptr [7FFE7DC56718]
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
-       mov       rdx,7FFE7E5739E0
+       mov       rdx,7FFE7E542F90
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FFE7E5739F8
+       mov       rdx,7FFE7E542FA8
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
-       call      qword ptr [7FFE7DDF5E48]
+       call      qword ptr [7FFE7DDC5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE7DCA5C50]
+       call      qword ptr [7FFE7DC75C50]
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
-       call      qword ptr [7FFE7DA84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE7DA54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE7DCA5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE7DC75C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DCA5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC75998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE7DCA5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE7DC75CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE7DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE7DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE7DDF5D58]
+       call      qword ptr [7FFE7DDC5D58]
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
-       mov       rax,21293660008
+       mov       rax,21B63740008
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       mov       rdx,7FFE7E5739E0
+       mov       rdx,7FFE7E572FD8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FFE7E5739F8
+       mov       rdx,7FFE7E572FF0
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
-       mov       rax,21293660008
+       mov       rax,25F49120008
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE7DCA5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC95CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE7DFAF990]
+       call      qword ptr [7FFE7DF9F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE16D80
+       mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DFAF780]
+       call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC86718]
+       call      qword ptr [7FFE7DC76718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE7DFAF990]
+       call      qword ptr [7FFE7DF9F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE16D80
+       mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DFAF780]
+       call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC86718]
+       call      qword ptr [7FFE7DC76718]
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
-       mov       rdx,7FFE7E5739E0
+       mov       rdx,7FFE7E4F8930
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
-       mov       rdx,7FFE7E5739F8
+       mov       rdx,7FFE7E4F8948
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
-       call      qword ptr [7FFE7DDF5E48]
+       call      qword ptr [7FFE7DDE5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE7DCA5C50]
+       call      qword ptr [7FFE7DC95C50]
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
-       call      qword ptr [7FFE7DA84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE7DA74360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE7DCA5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE7DC95C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DCA5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC95998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE7DCA5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE7DC95CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE7DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE7DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE7DDF5D58]
+       call      qword ptr [7FFE7DDE5D58]
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
-       mov       rax,21293660008
+       mov       rax,256BD0A0008
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE7DCA5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC85CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE7DFAF990]
+       call      qword ptr [7FFE7DF8F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE16D80
+       mov       rdx,7FFE7DDF6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DFAF780]
+       call      qword ptr [7FFE7DF8F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC86718]
+       call      qword ptr [7FFE7DC66718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE7DFAF990]
+       call      qword ptr [7FFE7DF8F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE16D80
+       mov       rdx,7FFE7DDF6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DFAF780]
+       call      qword ptr [7FFE7DF8F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC86718]
+       call      qword ptr [7FFE7DC66718]
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
-       mov       rdx,7FFE7E5739E0
+       mov       rdx,7FFE7E4E8460
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
-       mov       rdx,7FFE7E5739F8
+       mov       rdx,7FFE7E4E8478
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
-       call      qword ptr [7FFE7DDF5E48]
+       call      qword ptr [7FFE7DDD5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE7DCA5C50]
+       call      qword ptr [7FFE7DC85C50]
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
-       call      qword ptr [7FFE7DA84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE7DA64360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE7DCA5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE7DC85C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DCA5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC85998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE7DCA5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE7DC85CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE7DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE7DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE7DDF5D58]
+       call      qword ptr [7FFE7DDD5D58]
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
-       mov       rax,21293660008
+       mov       rax,245C2F60008
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE7DC95CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC65CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DF6F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF46F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DDD6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF46F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DF6F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC46718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DF6F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF46F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DDD6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF46F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA46B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DF6F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC46718]
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
-       mov       rdx,7FFE7E572F08
+       mov       rdx,7FFE7E532FA8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FFE7E572F20
+       mov       rdx,7FFE7E532FC0
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
-       call      qword ptr [7FFE7DDE5E48]
+       call      qword ptr [7FFE7DDB5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE7DC95C50]
+       call      qword ptr [7FFE7DC65C50]
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
-       call      qword ptr [7FFE7DA74360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE7DA44360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE7DC95C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE7DC65C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC95998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC65998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE7DC95CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE7DC65CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DAF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DAF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE7DDE5D58]
+       call      qword ptr [7FFE7DDB5D58]
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
-       mov       rax,1C2A97F0008
+       mov       rax,2A306510008
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       mov       rdx,7FFE7E572F08
+       mov       rdx,7FFE7E562FD8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FFE7E572F20
+       mov       rdx,7FFE7E562FF0
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
-       mov       rax,1C2A97F0008
+       mov       rax,201DE620008
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE7DC95CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC75CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC56718]
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
-       mov       rdx,7FFE7E572F08
+       mov       rdx,7FFE7E542F90
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FFE7E572F20
+       mov       rdx,7FFE7E542FA8
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
-       call      qword ptr [7FFE7DDE5E48]
+       call      qword ptr [7FFE7DDC5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE7DC95C50]
+       call      qword ptr [7FFE7DC75C50]
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
-       call      qword ptr [7FFE7DA74360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE7DA54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE7DC95C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE7DC75C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC95998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC75998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE7DC95CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE7DC75CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE7DDE5D58]
+       call      qword ptr [7FFE7DDC5D58]
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
-       mov       rax,1C2A97F0008
+       mov       rax,21B63740008
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE7DC95CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DCA5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,43
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC86718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC86718]
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
-       mov       rdx,7FFE7E572F08
+       mov       rdx,7FFE7E572FD8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FFE7E572F20
+       mov       rdx,7FFE7E572FF0
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
-       call      qword ptr [7FFE7DDE5E48]
+       call      qword ptr [7FFE7DDF5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE7DC95C50]
+       call      qword ptr [7FFE7DCA5C50]
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
-       call      qword ptr [7FFE7DA74360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE7DA84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE7DC95C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE7DCA5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC95998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DCA5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE7DC95CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE7DCA5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE7DDE5D58]
+       call      qword ptr [7FFE7DDF5D58]
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
-       mov       rax,1C2A97F0008
+       mov       rax,25F49120008
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFE7DF9F990]
        mov       ecx,28D
        mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
        mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FFE7DC76718]
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
-       mov       rdx,7FFE7E572F08
+       mov       rdx,7FFE7E4F8930
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
-       mov       rdx,7FFE7E572F20
+       mov       rdx,7FFE7E4F8948
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
-       mov       rax,1C2A97F0008
+       mov       rax,256BD0A0008
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE7DC95CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC85CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DF8F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DDF6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DF8F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC66718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DF8F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DDF6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DF8F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC66718]
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
-       mov       rdx,7FFE7E572F08
+       mov       rdx,7FFE7E4E8460
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
-       mov       rdx,7FFE7E572F20
+       mov       rdx,7FFE7E4E8478
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
-       call      qword ptr [7FFE7DDE5E48]
+       call      qword ptr [7FFE7DDD5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE7DC95C50]
+       call      qword ptr [7FFE7DC85C50]
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
-       call      qword ptr [7FFE7DA74360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE7DA64360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE7DC95C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE7DC85C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC95998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC85998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE7DC95CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE7DC85CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE7DDE5D58]
+       call      qword ptr [7FFE7DDD5D58]
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
-       mov       rax,1C2A97F0008
+       mov       rax,245C2F60008
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE7DC65CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC95CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE7DF6F990]
+       call      qword ptr [7FFE7DF9F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF46F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDD6D80
+       mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF46F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF6F780]
+       call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC46718]
+       call      qword ptr [7FFE7DC76718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE7DF6F990]
+       call      qword ptr [7FFE7DF9F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF46F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDD6D80
+       mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF46F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF6F780]
+       call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC46718]
+       call      qword ptr [7FFE7DC76718]
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
-       mov       rdx,7FFE7E532FA8
+       mov       rdx,7FFE7E562FD8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FFE7E532FC0
+       mov       rdx,7FFE7E562FF0
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
-       call      qword ptr [7FFE7DDB5E48]
+       call      qword ptr [7FFE7DDE5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE7DC65C50]
+       call      qword ptr [7FFE7DC95C50]
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
-       call      qword ptr [7FFE7DA44360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE7DA74360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE7DC65C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE7DC95C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC65998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC95998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE7DC65CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE7DC95CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE7DAF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE7DAF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE7DDB5D58]
+       call      qword ptr [7FFE7DDE5D58]
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
-       mov       rax,2A306510008
+       mov       rax,201DE620008
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE7DC65CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC75CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE7DF6F990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF46F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDD6D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF46F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF6F780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC46718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE7DF6F990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF46F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDD6D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF46F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF6F780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC46718]
+       call      qword ptr [7FFE7DC56718]
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
-       mov       rdx,7FFE7E532FA8
+       mov       rdx,7FFE7E542F90
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FFE7E532FC0
+       mov       rdx,7FFE7E542FA8
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
-       call      qword ptr [7FFE7DDB5E48]
+       call      qword ptr [7FFE7DDC5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE7DC65C50]
+       call      qword ptr [7FFE7DC75C50]
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
-       call      qword ptr [7FFE7DA44360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE7DA54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE7DC65C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE7DC75C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC65998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC75998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE7DC65CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE7DC75CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE7DAF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE7DAF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE7DDB5D58]
+       call      qword ptr [7FFE7DDC5D58]
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
-       mov       rax,2A306510008
+       mov       rax,21B63740008
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE7DC65CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DCA5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE7DF6F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,43
-       mov       rdx,7FFE7DF46F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDD6D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF46F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF6F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC46718]
+       call      qword ptr [7FFE7DC86718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE7DF6F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF46F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDD6D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF46F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF6F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC46718]
+       call      qword ptr [7FFE7DC86718]
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
-       mov       rdx,7FFE7E532FA8
+       mov       rdx,7FFE7E572FD8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FFE7E532FC0
+       mov       rdx,7FFE7E572FF0
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
-       call      qword ptr [7FFE7DDB5E48]
+       call      qword ptr [7FFE7DDF5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE7DC65C50]
+       call      qword ptr [7FFE7DCA5C50]
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
-       call      qword ptr [7FFE7DA44360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE7DA84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE7DC65C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE7DCA5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC65998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DCA5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE7DC65CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE7DCA5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE7DAF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE7DAF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE7DDB5D58]
+       call      qword ptr [7FFE7DDF5D58]
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
-       mov       rax,2A306510008
+       mov       rax,25F49120008
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE7DC65CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC95CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE7DF6F990]
+       call      qword ptr [7FFE7DF9F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF46F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDD6D80
+       mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF46F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF6F780]
+       call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC46718]
+       call      qword ptr [7FFE7DC76718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE7DF6F990]
+       call      qword ptr [7FFE7DF9F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF46F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDD6D80
+       mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF46F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF6F780]
+       call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC46718]
+       call      qword ptr [7FFE7DC76718]
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
-       mov       rdx,7FFE7E532FA8
+       mov       rdx,7FFE7E4F8930
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
-       mov       rdx,7FFE7E532FC0
+       mov       rdx,7FFE7E4F8948
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
-       call      qword ptr [7FFE7DDB5E48]
+       call      qword ptr [7FFE7DDE5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE7DC65C50]
+       call      qword ptr [7FFE7DC95C50]
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
-       call      qword ptr [7FFE7DA44360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE7DA74360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE7DC65C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE7DC95C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC65998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC95998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE7DC65CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE7DC95CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE7DAF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE7DAF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE7DDB5D58]
+       call      qword ptr [7FFE7DDE5D58]
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
-       mov       rax,2A306510008
+       mov       rax,256BD0A0008
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE7DC65CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC85CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE7DF6F990]
+       call      qword ptr [7FFE7DF8F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF46F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDD6D80
+       mov       rdx,7FFE7DDF6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF46F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF6F780]
+       call      qword ptr [7FFE7DF8F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC46718]
+       call      qword ptr [7FFE7DC66718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE7DF6F990]
+       call      qword ptr [7FFE7DF8F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF46F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDD6D80
+       mov       rdx,7FFE7DDF6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF46F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA46B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF6F780]
+       call      qword ptr [7FFE7DF8F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC46718]
+       call      qword ptr [7FFE7DC66718]
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
-       mov       rdx,7FFE7E532FA8
+       mov       rdx,7FFE7E4E8460
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
-       mov       rdx,7FFE7E532FC0
+       mov       rdx,7FFE7E4E8478
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
-       call      qword ptr [7FFE7DDB5E48]
+       call      qword ptr [7FFE7DDD5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE7DC65C50]
+       call      qword ptr [7FFE7DC85C50]
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
-       call      qword ptr [7FFE7DA44360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE7DA64360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE7DC65C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE7DC85C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC65998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC85998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE7DC65CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE7DC85CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE7DAF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE7DAF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE7DDB5D58]
+       call      qword ptr [7FFE7DDD5D58]
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
-       mov       rax,2A306510008
+       mov       rax,245C2F60008
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE7DC95CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC75CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC56718]
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
-       mov       rdx,7FFE7E562FD8
+       mov       rdx,7FFE7E542F90
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FFE7E562FF0
+       mov       rdx,7FFE7E542FA8
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
-       call      qword ptr [7FFE7DDE5E48]
+       call      qword ptr [7FFE7DDC5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE7DC95C50]
+       call      qword ptr [7FFE7DC75C50]
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
-       call      qword ptr [7FFE7DA74360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE7DA54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE7DC95C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE7DC75C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC95998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC75998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE7DC95CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE7DC75CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE7DDE5D58]
+       call      qword ptr [7FFE7DDC5D58]
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
-       mov       rax,201DE620008
+       mov       rax,21B63740008
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE7DC95CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DCA5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,43
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC86718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC86718]
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
-       mov       rdx,7FFE7E562FD8
+       mov       rdx,7FFE7E572FD8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FFE7E562FF0
+       mov       rdx,7FFE7E572FF0
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
-       call      qword ptr [7FFE7DDE5E48]
+       call      qword ptr [7FFE7DDF5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE7DC95C50]
+       call      qword ptr [7FFE7DCA5C50]
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
-       call      qword ptr [7FFE7DA74360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE7DA84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE7DC95C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE7DCA5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC95998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DCA5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE7DC95CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE7DCA5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE7DDE5D58]
+       call      qword ptr [7FFE7DDF5D58]
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
-       mov       rax,201DE620008
+       mov       rax,25F49120008
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFE7DF9F990]
        mov       ecx,28D
        mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
        mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
        mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FFE7DC76718]
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
-       mov       rdx,7FFE7E562FD8
+       mov       rdx,7FFE7E4F8930
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
-       mov       rdx,7FFE7E562FF0
+       mov       rdx,7FFE7E4F8948
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
-       mov       rax,201DE620008
+       mov       rax,256BD0A0008
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE7DC95CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC85CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DF8F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DDF6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DF8F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC66718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DF8F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DDF6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DF8F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC66718]
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
-       mov       rdx,7FFE7E562FD8
+       mov       rdx,7FFE7E4E8460
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
-       mov       rdx,7FFE7E562FF0
+       mov       rdx,7FFE7E4E8478
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
-       call      qword ptr [7FFE7DDE5E48]
+       call      qword ptr [7FFE7DDD5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE7DC95C50]
+       call      qword ptr [7FFE7DC85C50]
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
-       call      qword ptr [7FFE7DA74360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE7DA64360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE7DC95C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE7DC85C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC95998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC85998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE7DC95CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE7DC85CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE7DDE5D58]
+       call      qword ptr [7FFE7DDD5D58]
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
-       mov       rax,201DE620008
+       mov       rax,245C2F60008
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE7DC75CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DCA5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE7DF7F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,43
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDE6D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF7F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC56718]
+       call      qword ptr [7FFE7DC86718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE7DF7F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDE6D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF7F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC56718]
+       call      qword ptr [7FFE7DC86718]
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
-       mov       rdx,7FFE7E542F90
+       mov       rdx,7FFE7E572FD8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FFE7E542FA8
+       mov       rdx,7FFE7E572FF0
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
-       call      qword ptr [7FFE7DDC5E48]
+       call      qword ptr [7FFE7DDF5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE7DC75C50]
+       call      qword ptr [7FFE7DCA5C50]
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
-       call      qword ptr [7FFE7DA54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE7DA84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE7DC75C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE7DCA5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC75998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DCA5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE7DC75CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE7DCA5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE7DB05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE7DB05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE7DDC5D58]
+       call      qword ptr [7FFE7DDF5D58]
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
-       mov       rax,21B63740008
+       mov       rax,25F49120008
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE7DC75CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC95CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE7DF7F990]
+       call      qword ptr [7FFE7DF9F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDE6D80
+       mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF7F780]
+       call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC56718]
+       call      qword ptr [7FFE7DC76718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE7DF7F990]
+       call      qword ptr [7FFE7DF9F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDE6D80
+       mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF7F780]
+       call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC56718]
+       call      qword ptr [7FFE7DC76718]
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
-       mov       rdx,7FFE7E542F90
+       mov       rdx,7FFE7E4F8930
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
-       mov       rdx,7FFE7E542FA8
+       mov       rdx,7FFE7E4F8948
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
-       call      qword ptr [7FFE7DDC5E48]
+       call      qword ptr [7FFE7DDE5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE7DC75C50]
+       call      qword ptr [7FFE7DC95C50]
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
-       call      qword ptr [7FFE7DA54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE7DA74360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE7DC75C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE7DC95C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC75998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC95998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE7DC75CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE7DC95CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE7DB05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE7DB05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE7DDC5D58]
+       call      qword ptr [7FFE7DDE5D58]
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
-       mov       rax,21B63740008
+       mov       rax,256BD0A0008
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE7DC75CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC85CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE7DF7F990]
+       call      qword ptr [7FFE7DF8F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDE6D80
+       mov       rdx,7FFE7DDF6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF7F780]
+       call      qword ptr [7FFE7DF8F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC56718]
+       call      qword ptr [7FFE7DC66718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE7DF7F990]
+       call      qword ptr [7FFE7DF8F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDE6D80
+       mov       rdx,7FFE7DDF6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF7F780]
+       call      qword ptr [7FFE7DF8F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC56718]
+       call      qword ptr [7FFE7DC66718]
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
-       mov       rdx,7FFE7E542F90
+       mov       rdx,7FFE7E4E8460
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
-       mov       rdx,7FFE7E542FA8
+       mov       rdx,7FFE7E4E8478
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
-       call      qword ptr [7FFE7DDC5E48]
+       call      qword ptr [7FFE7DDD5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE7DC75C50]
+       call      qword ptr [7FFE7DC85C50]
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
-       call      qword ptr [7FFE7DA54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE7DA64360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE7DC75C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE7DC85C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC75998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC85998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE7DC75CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE7DC85CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE7DB05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE7DB05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE7DDC5D58]
+       call      qword ptr [7FFE7DDD5D58]
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
-       mov       rax,21B63740008
+       mov       rax,245C2F60008
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE7DCA5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC95CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE7DFAF990]
+       call      qword ptr [7FFE7DF9F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE16D80
+       mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DFAF780]
+       call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC86718]
+       call      qword ptr [7FFE7DC76718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE7DFAF990]
+       call      qword ptr [7FFE7DF9F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE16D80
+       mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DFAF780]
+       call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC86718]
+       call      qword ptr [7FFE7DC76718]
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
-       mov       rdx,7FFE7E572FD8
+       mov       rdx,7FFE7E4F8930
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
-       mov       rdx,7FFE7E572FF0
+       mov       rdx,7FFE7E4F8948
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
-       call      qword ptr [7FFE7DDF5E48]
+       call      qword ptr [7FFE7DDE5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE7DCA5C50]
+       call      qword ptr [7FFE7DC95C50]
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
-       call      qword ptr [7FFE7DA84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE7DA74360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE7DCA5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE7DC95C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DCA5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC95998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE7DCA5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE7DC95CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE7DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE7DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE7DDF5D58]
+       call      qword ptr [7FFE7DDE5D58]
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
-       mov       rax,25F49120008
+       mov       rax,256BD0A0008
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE7DCA5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC85CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE7DFAF990]
+       call      qword ptr [7FFE7DF8F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE16D80
+       mov       rdx,7FFE7DDF6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DFAF780]
+       call      qword ptr [7FFE7DF8F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC86718]
+       call      qword ptr [7FFE7DC66718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE7DFAF990]
+       call      qword ptr [7FFE7DF8F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE16D80
+       mov       rdx,7FFE7DDF6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DFAF780]
+       call      qword ptr [7FFE7DF8F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC86718]
+       call      qword ptr [7FFE7DC66718]
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
-       mov       rdx,7FFE7E572FD8
+       mov       rdx,7FFE7E4E8460
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
-       mov       rdx,7FFE7E572FF0
+       mov       rdx,7FFE7E4E8478
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
-       call      qword ptr [7FFE7DDF5E48]
+       call      qword ptr [7FFE7DDD5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE7DCA5C50]
+       call      qword ptr [7FFE7DC85C50]
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
-       call      qword ptr [7FFE7DA84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE7DA64360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE7DCA5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE7DC85C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DCA5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC85998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE7DCA5CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE7DC85CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE7DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE7DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE7DDF5D58]
+       call      qword ptr [7FFE7DDD5D58]
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
-       mov       rax,25F49120008
+       mov       rax,245C2F60008
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE7DC95CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC85CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DF8F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DDF6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DF8F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC66718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M00_L01:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DF8F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DDF6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DF8F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC66718]
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
-       mov       rdx,7FFE7E4F8930
+       mov       rdx,7FFE7E4E8460
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L02:
        xor       r13d,r13d
        jmp       short M01_L03
 M01_L06:
-       mov       rdx,7FFE7E4F8948
+       mov       rdx,7FFE7E4E8478
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
-       call      qword ptr [7FFE7DDE5E48]
+       call      qword ptr [7FFE7DDD5E48]
        int       3
 M01_L09:
        mov       eax,[rbx+28]
        mov       [rsp+34],eax
        cmp       [rbp+8],eax
        jne       short M01_L10
        mov       rcx,rbx
-       call      qword ptr [7FFE7DC95C50]
+       call      qword ptr [7FFE7DC85C50]
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
-       call      qword ptr [7FFE7DA74360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFE7DA64360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        test      rax,rax
        je        short M01_L12
        mov       edx,[rbp+8]
        mov       rcx,rbx
        mov       r8d,1
-       call      qword ptr [7FFE7DC95C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
+       call      qword ptr [7FFE7DC85C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC95998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC85998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
-       call      qword ptr [7FFE7DC95CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
+       call      qword ptr [7FFE7DC85CB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
        call      System.String.FastAllocateString(Int32)
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FFE7DB25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FFE7DB15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FFE7DDE5D58]
+       call      qword ptr [7FFE7DDD5D58]
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
-       mov       rax,256BD0A0008
+       mov       rax,245C2F60008
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE7E5451B8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       call      qword ptr [7FFE7E546550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE7DF1D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE7DF2D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE7E545B60]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE7E546EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE7E532A90
+       mov       rdx,7FFE7E552FD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE7E532FA0
+       mov       rdx,7FFE7E5534E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,43
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC86718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE7E5451B8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       call      qword ptr [7FFE7E516550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE7DF1D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE7DEFD938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE7E545B60]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE7E516EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE7E532A90
+       mov       rdx,7FFE7E522FD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE7E532FA0
+       mov       rdx,7FFE7E5234E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE7E5451B8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       call      qword ptr [7FFE7E536550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE7E545B60]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE7E536EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE7E532A90
+       mov       rdx,7FFE7E542E80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE7E532FA0
+       mov       rdx,7FFE7E543390
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE7E5451B8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       call      qword ptr [7FFE7E546550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE7DF1D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE7DF2D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE7E545B60]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE7E546EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE7E532A90
+       mov       rdx,7FFE7E552FD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE7E532FA0
+       mov       rdx,7FFE7E5534E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,43
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC86718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE7E5451B8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       call      qword ptr [7FFE7E526550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE7DF1D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE7DF0D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE7E545B60]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE7E526EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE7E532A90
+       mov       rdx,7FFE7E532FD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE7E532FA0
+       mov       rdx,7FFE7E5334E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DF8F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DDF6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DF8F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC66718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE7E5451B8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       call      qword ptr [7FFE7E656DD8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE7DF1D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE7DEFD938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE7E545B60]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE7E657780]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE7E532A90
+       mov       rdx,7FFE7E662900
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE7E532FA0
+       mov       rdx,7FFE7E662E10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE7E5451B8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       call      qword ptr [7FFE7E715CC8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE7DF1D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE7DF2D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE7E545B60]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE7E716670]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE7E532A90
+       mov       rdx,7FFE7E702900
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE7E532FA0
+       mov       rdx,7FFE7E702E10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,43
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC86718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE7E546550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       call      qword ptr [7FFE7E516550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE7DF2D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE7DEFD938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE7E546EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE7E516EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE7E552FD0
+       mov       rdx,7FFE7E522FD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE7E5534E0
+       mov       rdx,7FFE7E5234E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE7DFAF990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE16D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DFAF780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC86718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE7E546550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       call      qword ptr [7FFE7E536550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE7DF2D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE7DF1D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE7E546EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE7E536EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE7E552FD0
+       mov       rdx,7FFE7E542E80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE7E5534E0
+       mov       rdx,7FFE7E543390
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE7DFAF990]
+       call      qword ptr [7FFE7DF9F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE16D80
+       mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DFAF780]
+       call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC86718]
+       call      qword ptr [7FFE7DC76718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE7E546550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       call      qword ptr [7FFE7E526550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE7DF2D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE7DF0D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE7E546EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE7E526EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE7E552FD0
+       mov       rdx,7FFE7E532FD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE7E5534E0
+       mov       rdx,7FFE7E5334E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE7DFAF990]
+       call      qword ptr [7FFE7DF8F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE16D80
+       mov       rdx,7FFE7DDF6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DFAF780]
+       call      qword ptr [7FFE7DF8F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC86718]
+       call      qword ptr [7FFE7DC66718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE7E546550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       call      qword ptr [7FFE7E656DD8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE7DF2D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE7DEFD938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE7E546EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE7E657780]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE7E552FD0
+       mov       rdx,7FFE7E662900
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE7E5534E0
+       mov       rdx,7FFE7E662E10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE7DFAF990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE16D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DFAF780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC86718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE7E546550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       call      qword ptr [7FFE7E715CC8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE7E546EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE7E716670]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE7E552FD0
+       mov       rdx,7FFE7E702900
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE7E5534E0
+       mov       rdx,7FFE7E702E10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE7E516550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       call      qword ptr [7FFE7E536550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE7DEFD938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE7DF1D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE7E516EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE7E536EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE7E522FD0
+       mov       rdx,7FFE7E542E80
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE7E5234E0
+       mov       rdx,7FFE7E543390
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE7DF7F990]
+       call      qword ptr [7FFE7DF9F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDE6D80
+       mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF7F780]
+       call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC56718]
+       call      qword ptr [7FFE7DC76718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE7E516550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       call      qword ptr [7FFE7E546550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE7DEFD938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE7DF2D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE7E516EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE7E546EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE7E522FD0
+       mov       rdx,7FFE7E552FD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE7E5234E0
+       mov       rdx,7FFE7E5534E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE7DF7F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,43
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDE6D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF7F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC56718]
+       call      qword ptr [7FFE7DC86718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE7E516550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       call      qword ptr [7FFE7E526550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE7DEFD938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE7DF0D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE7E516EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE7E526EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE7E522FD0
+       mov       rdx,7FFE7E532FD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE7E5234E0
+       mov       rdx,7FFE7E5334E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE7DF7F990]
+       call      qword ptr [7FFE7DF8F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDE6D80
+       mov       rdx,7FFE7DDF6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF7F780]
+       call      qword ptr [7FFE7DF8F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC56718]
+       call      qword ptr [7FFE7DC66718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE7E516550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       call      qword ptr [7FFE7E656DD8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE7E516EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE7E657780]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE7E522FD0
+       mov       rdx,7FFE7E662900
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE7E5234E0
+       mov       rdx,7FFE7E662E10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE7E516550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       call      qword ptr [7FFE7E715CC8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE7DEFD938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE7DF2D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE7E516EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE7E716670]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE7E522FD0
+       mov       rdx,7FFE7E702900
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE7E5234E0
+       mov       rdx,7FFE7E702E10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE7DF7F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,43
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDE6D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF7F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC56718]
+       call      qword ptr [7FFE7DC86718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE7E536550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       call      qword ptr [7FFE7E546550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE7DF1D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE7DF2D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE7E536EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE7E546EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE7E542E80
+       mov       rdx,7FFE7E552FD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE7E543390
+       mov       rdx,7FFE7E5534E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,43
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC86718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE7E536550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       call      qword ptr [7FFE7E526550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE7DF1D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE7DF0D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE7E536EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE7E526EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE7E542E80
+       mov       rdx,7FFE7E532FD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE7E543390
+       mov       rdx,7FFE7E5334E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DF8F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DDF6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DF8F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC66718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE7E536550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       call      qword ptr [7FFE7E656DD8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE7DF1D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE7DEFD938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE7E536EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE7E657780]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE7E542E80
+       mov       rdx,7FFE7E662900
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE7E543390
+       mov       rdx,7FFE7E662E10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE7E536550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       call      qword ptr [7FFE7E715CC8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE7DF1D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE7DF2D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE7E536EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE7E716670]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE7E542E80
+       mov       rdx,7FFE7E702900
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE7E543390
+       mov       rdx,7FFE7E702E10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,43
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC86718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE7E546550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       call      qword ptr [7FFE7E526550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE7DF2D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE7DF0D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE7E546EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE7E526EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE7E552FD0
+       mov       rdx,7FFE7E532FD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE7E5534E0
+       mov       rdx,7FFE7E5334E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE7DFAF990]
+       call      qword ptr [7FFE7DF8F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE16D80
+       mov       rdx,7FFE7DDF6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DFAF780]
+       call      qword ptr [7FFE7DF8F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC86718]
+       call      qword ptr [7FFE7DC66718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE7E546550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       call      qword ptr [7FFE7E656DD8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE7DF2D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE7DEFD938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE7E546EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE7E657780]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE7E552FD0
+       mov       rdx,7FFE7E662900
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE7E5534E0
+       mov       rdx,7FFE7E662E10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE7DFAF990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE16D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DFAF780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC86718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE7E546550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       call      qword ptr [7FFE7E715CC8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE7E546EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE7E716670]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE7E552FD0
+       mov       rdx,7FFE7E702900
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE7E5534E0
+       mov       rdx,7FFE7E702E10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE7E526550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       call      qword ptr [7FFE7E656DD8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE7DF0D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE7DEFD938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE7E526EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE7E657780]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE7E532FD0
+       mov       rdx,7FFE7E662900
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE7E5334E0
+       mov       rdx,7FFE7E662E10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE7DF8F990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDF6D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF8F780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC66718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE7E526550]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       call      qword ptr [7FFE7E715CC8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE7DF0D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE7DF2D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE7E526EF8]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE7E716670]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE7E532FD0
+       mov       rdx,7FFE7E702900
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE7E5334E0
+       mov       rdx,7FFE7E702E10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE7DF8F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,43
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDF6D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF8F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC66718]
+       call      qword ptr [7FFE7DC86718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for ToImmutableHashSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE7E656DD8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
+       call      qword ptr [7FFE7E715CC8]; DotNetTips.Spargine.Extensions.HashSetExtensions.ToImmutableHashSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
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
-       call      qword ptr [7FFE7DEFD938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE7DF2D938]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FFE7E657780]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE7E716670]; System.Collections.Immutable.ImmutableHashSet.Create[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        mov       rcx,rbx
-       mov       rdx,7FFE7E662900
+       mov       rdx,7FFE7E702900
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L00
 M01_L04:
        mov       rcx,rbx
-       mov       rdx,7FFE7E662E10
+       mov       rdx,7FFE7E702E10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
        jmp       short M01_L02
 M01_L05:
-       call      qword ptr [7FFE7DF7F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,43
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rsi,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDE6D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rsi
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rdi,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rdi
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF7F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC56718]
+       call      qword ptr [7FFE7DC86718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L06:
```
**Diff for Upsert method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE7E4FD950]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFE7E4FE5C8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
        call      qword ptr [7FFE7DC85998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
        call      qword ptr [7FFE7DC77028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
```
**Diff for Upsert method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE7E4FD950]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFE7E50E820]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE7DC85998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC95998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC77028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE7DC87028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC85CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC95CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE7DF8F990]
+       call      qword ptr [7FFE7DF9F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDF6D80
+       mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF8F780]
+       call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC66718]
+       call      qword ptr [7FFE7DC76718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE7DF8F990]
+       call      qword ptr [7FFE7DF9F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDF6D80
+       mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF8F780]
+       call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC66718]
+       call      qword ptr [7FFE7DC76718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE7E4FD950]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFE7E4EE5C8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE7DC85998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC75998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC77028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE7DC67028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC85CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC75CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE7DF8F990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDF6D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF8F780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC66718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE7DF8F990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDF6D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF8F780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC66718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE7E4FD950]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFE7E4FE820]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
        call      qword ptr [7FFE7DC85998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
        call      qword ptr [7FFE7DC77028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
```
**Diff for Upsert method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE7E4FD950]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFE7E50E5C8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE7DC85998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC95998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC77028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE7DC87028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC85CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC95CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE7DF8F990]
+       call      qword ptr [7FFE7DF9F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDF6D80
+       mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF8F780]
+       call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC66718]
+       call      qword ptr [7FFE7DC76718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE7DF8F990]
+       call      qword ptr [7FFE7DF9F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDF6D80
+       mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF8F780]
+       call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC66718]
+       call      qword ptr [7FFE7DC76718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE7E4FD950]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFE7E61D950]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE7DC85998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DCA5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC77028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE7DC97028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC85CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DCA5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE7DF8F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,43
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDF6D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF8F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC66718]
+       call      qword ptr [7FFE7DC86718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE7DF8F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDF6D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF8F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC66718]
+       call      qword ptr [7FFE7DC86718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE7E4FD950]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFE7E6ADFE0]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE7DC85998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC75998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC77028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE7DC67028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC85CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC75CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE7DF8F990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDF6D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF8F780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC66718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE7DF8F990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDF6D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF8F780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC66718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE7E4FE5C8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFE7E50E820]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE7DC85998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC95998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC77028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE7DC87028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC85CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC95CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE7DF8F990]
+       call      qword ptr [7FFE7DF9F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDF6D80
+       mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF8F780]
+       call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC66718]
+       call      qword ptr [7FFE7DC76718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE7DF8F990]
+       call      qword ptr [7FFE7DF9F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDF6D80
+       mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF8F780]
+       call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC66718]
+       call      qword ptr [7FFE7DC76718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE7E4FE5C8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFE7E4EE5C8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE7DC85998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC75998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC77028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE7DC67028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC85CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC75CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE7DF8F990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDF6D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF8F780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC66718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE7DF8F990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDF6D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF8F780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC66718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE7E4FE5C8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFE7E4FE820]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
        call      qword ptr [7FFE7DC85998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
        call      qword ptr [7FFE7DC77028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
```
**Diff for Upsert method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE7E4FE5C8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFE7E50E5C8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE7DC85998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC95998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC77028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE7DC87028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC85CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC95CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE7DF8F990]
+       call      qword ptr [7FFE7DF9F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDF6D80
+       mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF8F780]
+       call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC66718]
+       call      qword ptr [7FFE7DC76718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE7DF8F990]
+       call      qword ptr [7FFE7DF9F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDF6D80
+       mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF8F780]
+       call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC66718]
+       call      qword ptr [7FFE7DC76718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE7E4FE5C8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFE7E61D950]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE7DC85998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DCA5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC77028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE7DC97028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC85CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DCA5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE7DF8F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,43
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDF6D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF8F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC66718]
+       call      qword ptr [7FFE7DC86718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE7DF8F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDF6D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF8F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC66718]
+       call      qword ptr [7FFE7DC86718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE7E4FE5C8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFE7E6ADFE0]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE7DC85998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC75998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC77028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE7DC67028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC85CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC75CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE7DF8F990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDF6D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF8F780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC66718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE7DF8F990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDF6D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF8F780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC66718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE7E50E820]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFE7E4EE5C8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE7DC95998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC75998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC87028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE7DC67028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC95CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC75CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE7E50E820]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFE7E4FE820]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE7DC95998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC85998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC87028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE7DC77028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC95CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC85CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DF8F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DDF6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DF8F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC66718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DF8F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DDF6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DF8F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC66718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE7E50E820]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFE7E50E5C8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
        call      qword ptr [7FFE7DC95998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
        call      qword ptr [7FFE7DC87028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
```
**Diff for Upsert method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE7E50E820]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFE7E61D950]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE7DC95998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DCA5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC87028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE7DC97028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC95CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DCA5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,43
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC86718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC86718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE7E50E820]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFE7E6ADFE0]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE7DC95998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC75998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC87028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE7DC67028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC95CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC75CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE7E4EE5C8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFE7E4FE820]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE7DC75998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC85998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC67028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE7DC77028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC75CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC85CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE7DF7F990]
+       call      qword ptr [7FFE7DF8F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDE6D80
+       mov       rdx,7FFE7DDF6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF7F780]
+       call      qword ptr [7FFE7DF8F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC56718]
+       call      qword ptr [7FFE7DC66718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE7DF7F990]
+       call      qword ptr [7FFE7DF8F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDE6D80
+       mov       rdx,7FFE7DDF6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF66F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF7F780]
+       call      qword ptr [7FFE7DF8F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC56718]
+       call      qword ptr [7FFE7DC66718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE7E4EE5C8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFE7E50E5C8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE7DC75998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC95998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC67028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE7DC87028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC75CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC95CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE7DF7F990]
+       call      qword ptr [7FFE7DF9F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDE6D80
+       mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF7F780]
+       call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC56718]
+       call      qword ptr [7FFE7DC76718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE7DF7F990]
+       call      qword ptr [7FFE7DF9F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDE6D80
+       mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF7F780]
+       call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC56718]
+       call      qword ptr [7FFE7DC76718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE7E4EE5C8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFE7E61D950]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE7DC75998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DCA5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC67028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE7DC97028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC75CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DCA5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE7DF7F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,43
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDE6D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF7F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC56718]
+       call      qword ptr [7FFE7DC86718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE7DF7F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDE6D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF56F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF7F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC56718]
+       call      qword ptr [7FFE7DC86718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE7E4EE5C8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFE7E6ADFE0]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
        call      qword ptr [7FFE7DC75998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
        call      qword ptr [7FFE7DC67028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
```
**Diff for Upsert method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE7E4FE820]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFE7E50E5C8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE7DC85998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC95998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC77028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE7DC87028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC85CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC95CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE7DF8F990]
+       call      qword ptr [7FFE7DF9F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDF6D80
+       mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF8F780]
+       call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC66718]
+       call      qword ptr [7FFE7DC76718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE7DF8F990]
+       call      qword ptr [7FFE7DF9F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDF6D80
+       mov       rdx,7FFE7DE06D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF76F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF8F780]
+       call      qword ptr [7FFE7DF9F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC66718]
+       call      qword ptr [7FFE7DC76718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE7E4FE820]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFE7E61D950]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE7DC85998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DCA5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC77028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE7DC97028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC85CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DCA5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE7DF8F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,43
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDF6D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF8F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC66718]
+       call      qword ptr [7FFE7DC86718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE7DF8F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDF6D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF8F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC66718]
+       call      qword ptr [7FFE7DC86718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE7E4FE820]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFE7E6ADFE0]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE7DC85998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC75998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC77028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE7DC67028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC85CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC75CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE7DF8F990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDF6D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF8F780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC66718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE7DF8F990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DDF6D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF66F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA66B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF8F780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC66718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE7E50E5C8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFE7E61D950]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE7DC95998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DCA5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC87028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE7DC97028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC95CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DCA5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,43
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC86718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DFAF990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DE16D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF86F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DFAF780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC86718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE7E50E5C8]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFE7E6ADFE0]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE7DC95998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC75998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC87028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE7DC67028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC95CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC75CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE7DF9F990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE06D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF76F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA76B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DF9F780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC76718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
**Diff for Upsert method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.HashSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE7E61D950]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFE7E6ADFE0]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
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
-       call      qword ptr [7FFE7DCA5998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
+       call      qword ptr [7FFE7DC75998]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
        test      eax,eax
        jl        short M01_L00
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DC97028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE7DC67028]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 M01_L00:
        lea       r8,[rsp+20]
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FFE7DCA5CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
+       call      qword ptr [7FFE7DC75CC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M01_L01:
-       call      qword ptr [7FFE7DFAF990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,43
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE16D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DFAF780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC86718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
-       call      qword ptr [7FFE7DFAF990]
+       call      qword ptr [7FFE7DF7F990]
        mov       ecx,28D
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1AC2
-       mov       rdx,7FFE7DE16D80
+       mov       rdx,7FFE7DDE6D80
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FFE7DF86F50
+       mov       rdx,7FFE7DF56F50
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FFE7DA86B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFE7DA56B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFE7DFAF780]
+       call      qword ptr [7FFE7DF7F780]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FFE7DC86718]
+       call      qword ptr [7FFE7DC56718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 386
```
