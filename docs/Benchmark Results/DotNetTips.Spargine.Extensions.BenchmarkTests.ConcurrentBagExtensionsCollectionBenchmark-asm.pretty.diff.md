## DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark-20250830-235756
**Diff for ToList method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
-       mov       rcx,7FF900ABA9B8
-       call      qword ptr [7FF9008E6778]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900A9F0A8
+       call      qword ptr [7FF9008C6778]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
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
 M00_L00:
-       call      qword ptr [7FF900537060]
+       call      qword ptr [7FF900517060]
        mov       ecx,0AD
-       mov       rdx,7FF900517CA0
+       mov       rdx,7FF9004F7CA0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9003A7000
+       mov       rdx,7FF900387000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF900517CA0
+       mov       rdx,7FF9004F7CA0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF900536E50]
+       call      qword ptr [7FF900516E50]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF9001F6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
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
-       mov       rdx,7FF900C4E2B8
+       mov       rdx,7FF900C613D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C4E368
+       mov       rdx,7FF900C61480
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9000CDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9000ADFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF900C4E2C8
+       mov       rdx,7FF900C613E0
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
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900367A38]
        int       3
 ; Total bytes of code 215
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
-       call      00007FF900011E60
+       call      00007FF8FFFF1E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF900385D58]
+       call      qword ptr [7FF900365D58]
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
-       mov       rax,1CC2DD30008
+       mov       rax,172E2340008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
-       mov       rcx,7FF900ABA9B8
-       call      qword ptr [7FF9008E6778]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900A9F0A8
+       call      qword ptr [7FF9008C6B38]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
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
 M00_L00:
-       call      qword ptr [7FF900537060]
+       call      qword ptr [7FF900517060]
        mov       ecx,0AD
-       mov       rdx,7FF900517CA0
+       mov       rdx,7FF9004F7CA0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9003A7000
+       mov       rdx,7FF900387000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF900517CA0
+       mov       rdx,7FF9004F7CA0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF900536E50]
+       call      qword ptr [7FF900516E50]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF9001F6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
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
-       mov       rdx,7FF900C4E2B8
+       mov       rdx,7FF900C60B18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C4E368
+       mov       rdx,7FF900C60BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9000CDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9000ADFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF900C4E2C8
+       mov       rdx,7FF900C60B28
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
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900367A38]
        int       3
 ; Total bytes of code 215
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
-       call      00007FF900011E60
+       call      00007FF8FFFF1E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF900385D58]
+       call      qword ptr [7FF900365D58]
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
-       mov       rax,1CC2DD30008
+       mov       rax,2852F3C0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
-       mov       rcx,7FF900ABA9B8
+       mov       rcx,7FF900ABF4D8
        call      qword ptr [7FF9008E6778]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
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
        call      qword ptr [7FF900537060]
        mov       ecx,0AD
        mov       rdx,7FF900517CA0
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
        mov       rdx,7FF900517CA0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF900536E50]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF900216718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
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
-       mov       rdx,7FF900C4E2B8
+       mov       rdx,7FF900C811B8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C4E368
+       mov       rdx,7FF900C81268
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF900C4E2C8
+       mov       rdx,7FF900C811C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,1CC2DD30008
+       mov       rax,246F0CD0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
-       mov       rcx,7FF900ABA9B8
-       call      qword ptr [7FF9008E6778]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900A9F0A8
+       call      qword ptr [7FF9008C6B38]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
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
 M00_L00:
-       call      qword ptr [7FF900537060]
+       call      qword ptr [7FF900517060]
        mov       ecx,0AD
-       mov       rdx,7FF900517CA0
+       mov       rdx,7FF9004F7CA0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9003A7000
+       mov       rdx,7FF900387000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF900517CA0
+       mov       rdx,7FF9004F7CA0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF900536E50]
+       call      qword ptr [7FF900516E50]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF9001F6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
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
-       mov       rdx,7FF900C4E2B8
+       mov       rdx,7FF900C61940
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C4E368
+       mov       rdx,7FF900C619F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9000CDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9000ADFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF900C4E2C8
+       mov       rdx,7FF900C61950
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
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900367A38]
        int       3
 ; Total bytes of code 215
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
-       call      00007FF900011E60
+       call      00007FF8FFFF1E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF900385D58]
+       call      qword ptr [7FF900365D58]
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
-       mov       rax,1CC2DD30008
+       mov       rax,1887E960008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
-       mov       rcx,7FF900ABA9B8
-       call      qword ptr [7FF9008E6778]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900ACF0A8
+       call      qword ptr [7FF9008F6778]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
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
 M00_L00:
-       call      qword ptr [7FF900537060]
+       call      qword ptr [7FF900547060]
        mov       ecx,0AD
-       mov       rdx,7FF900517CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9003A7000
+       mov       rdx,7FF9003B7000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF900517CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF900536E50]
+       call      qword ptr [7FF900546E50]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
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
-       mov       rdx,7FF900C4E2B8
+       mov       rdx,7FF900C90C20
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C4E368
+       mov       rdx,7FF900C90CD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9000CDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9000DDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF900C4E2C8
+       mov       rdx,7FF900C90C30
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
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900397A38]
        int       3
 ; Total bytes of code 215
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
-       call      00007FF900011E60
+       call      00007FF900021E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF900385D58]
+       call      qword ptr [7FF900395D58]
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
-       mov       rax,1CC2DD30008
+       mov       rax,22FCA100008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
-       mov       rcx,7FF900ABA9B8
-       call      qword ptr [7FF9008E6778]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900C37910
+       call      qword ptr [7FF9008F6B38]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
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
 M00_L00:
-       call      qword ptr [7FF900537060]
+       call      qword ptr [7FF900547060]
        mov       ecx,0AD
-       mov       rdx,7FF900517CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9003A7000
+       mov       rdx,7FF9003B7000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF900517CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF900536E50]
+       call      qword ptr [7FF900546E50]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
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
-       mov       rdx,7FF900C4E2B8
+       mov       rdx,7FF900CE8D08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C4E368
+       mov       rdx,7FF900CE8DB8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9000CDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9000DDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF900C4E2C8
+       mov       rdx,7FF900CE8D18
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
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900397A38]
        int       3
 ; Total bytes of code 215
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
-       call      00007FF900011E60
+       call      00007FF900021E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF900385D58]
+       call      qword ptr [7FF900395D58]
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
-       mov       rax,1CC2DD30008
+       mov       rax,19B15C00008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
-       mov       rcx,7FF900ABA9B8
-       call      qword ptr [7FF9008E6778]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900CEC370
+       call      qword ptr [7FF9008F6B38]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
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
 M00_L00:
-       call      qword ptr [7FF900537060]
+       call      qword ptr [7FF900547060]
        mov       ecx,0AD
-       mov       rdx,7FF900517CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9003A7000
+       mov       rdx,7FF9003B7000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF900517CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF900536E50]
+       call      qword ptr [7FF900546E50]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
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
-       mov       rdx,7FF900C4E2B8
+       mov       rdx,7FF900CFF220
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C4E368
+       mov       rdx,7FF900CFF2D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9000CDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9000DDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF900C4E2C8
+       mov       rdx,7FF900CFF230
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
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900397A38]
        int       3
 ; Total bytes of code 215
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
-       call      00007FF900011E60
+       call      00007FF900021E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF900385D58]
+       call      qword ptr [7FF900395D58]
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
-       mov       rax,1CC2DD30008
+       mov       rax,1DC780A0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
        mov       rcx,7FF900A9F0A8
-       call      qword ptr [7FF9008C6778]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9008C6B38]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
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
        call      qword ptr [7FF900517060]
        mov       ecx,0AD
        mov       rdx,7FF9004F7CA0
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
        mov       rdx,7FF9004F7CA0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF900516E50]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9001F6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
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
-       mov       rdx,7FF900C613D0
+       mov       rdx,7FF900C60B18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C61480
+       mov       rdx,7FF900C60BC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF900C613E0
+       mov       rdx,7FF900C60B28
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,172E2340008
+       mov       rax,2852F3C0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
-       mov       rcx,7FF900A9F0A8
-       call      qword ptr [7FF9008C6778]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900ABF4D8
+       call      qword ptr [7FF9008E6778]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
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
 M00_L00:
-       call      qword ptr [7FF900517060]
+       call      qword ptr [7FF900537060]
        mov       ecx,0AD
-       mov       rdx,7FF9004F7CA0
+       mov       rdx,7FF900517CA0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF900387000
+       mov       rdx,7FF9003A7000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9004F7CA0
+       mov       rdx,7FF900517CA0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF900516E50]
+       call      qword ptr [7FF900536E50]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9001F6718]
+       call      qword ptr [7FF900216718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
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
-       mov       rdx,7FF900C613D0
+       mov       rdx,7FF900C811B8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C61480
+       mov       rdx,7FF900C81268
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9000ADFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9000CDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF900C613E0
+       mov       rdx,7FF900C811C8
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
-       call      qword ptr [7FF900367A38]
+       call      qword ptr [7FF900387A38]
        int       3
 ; Total bytes of code 215
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
-       call      00007FF8FFFF1E60
+       call      00007FF900011E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF900365D58]
+       call      qword ptr [7FF900385D58]
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
-       mov       rax,172E2340008
+       mov       rax,246F0CD0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
        mov       rcx,7FF900A9F0A8
-       call      qword ptr [7FF9008C6778]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9008C6B38]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
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
        call      qword ptr [7FF900517060]
        mov       ecx,0AD
        mov       rdx,7FF9004F7CA0
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
        mov       rdx,7FF9004F7CA0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF900516E50]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9001F6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
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
-       mov       rdx,7FF900C613D0
+       mov       rdx,7FF900C61940
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C61480
+       mov       rdx,7FF900C619F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF900C613E0
+       mov       rdx,7FF900C61950
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,172E2340008
+       mov       rax,1887E960008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
-       mov       rcx,7FF900A9F0A8
-       call      qword ptr [7FF9008C6778]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900ACF0A8
+       call      qword ptr [7FF9008F6778]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
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
 M00_L00:
-       call      qword ptr [7FF900517060]
+       call      qword ptr [7FF900547060]
        mov       ecx,0AD
-       mov       rdx,7FF9004F7CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF900387000
+       mov       rdx,7FF9003B7000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9004F7CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF900516E50]
+       call      qword ptr [7FF900546E50]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9001F6718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
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
-       mov       rdx,7FF900C613D0
+       mov       rdx,7FF900C90C20
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C61480
+       mov       rdx,7FF900C90CD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9000ADFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9000DDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF900C613E0
+       mov       rdx,7FF900C90C30
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
-       call      qword ptr [7FF900367A38]
+       call      qword ptr [7FF900397A38]
        int       3
 ; Total bytes of code 215
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
-       call      00007FF8FFFF1E60
+       call      00007FF900021E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF900365D58]
+       call      qword ptr [7FF900395D58]
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
-       mov       rax,172E2340008
+       mov       rax,22FCA100008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
-       mov       rcx,7FF900A9F0A8
-       call      qword ptr [7FF9008C6778]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900C37910
+       call      qword ptr [7FF9008F6B38]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
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
 M00_L00:
-       call      qword ptr [7FF900517060]
+       call      qword ptr [7FF900547060]
        mov       ecx,0AD
-       mov       rdx,7FF9004F7CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF900387000
+       mov       rdx,7FF9003B7000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9004F7CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF900516E50]
+       call      qword ptr [7FF900546E50]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9001F6718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
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
-       mov       rdx,7FF900C613D0
+       mov       rdx,7FF900CE8D08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C61480
+       mov       rdx,7FF900CE8DB8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9000ADFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9000DDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF900C613E0
+       mov       rdx,7FF900CE8D18
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
-       call      qword ptr [7FF900367A38]
+       call      qword ptr [7FF900397A38]
        int       3
 ; Total bytes of code 215
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
-       call      00007FF8FFFF1E60
+       call      00007FF900021E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF900365D58]
+       call      qword ptr [7FF900395D58]
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
-       mov       rax,172E2340008
+       mov       rax,19B15C00008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
-       mov       rcx,7FF900A9F0A8
-       call      qword ptr [7FF9008C6778]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900CEC370
+       call      qword ptr [7FF9008F6B38]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
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
 M00_L00:
-       call      qword ptr [7FF900517060]
+       call      qword ptr [7FF900547060]
        mov       ecx,0AD
-       mov       rdx,7FF9004F7CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF900387000
+       mov       rdx,7FF9003B7000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9004F7CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF900516E50]
+       call      qword ptr [7FF900546E50]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9001F6718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
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
-       mov       rdx,7FF900C613D0
+       mov       rdx,7FF900CFF220
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C61480
+       mov       rdx,7FF900CFF2D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9000ADFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9000DDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF900C613E0
+       mov       rdx,7FF900CFF230
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
-       call      qword ptr [7FF900367A38]
+       call      qword ptr [7FF900397A38]
        int       3
 ; Total bytes of code 215
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
-       call      00007FF8FFFF1E60
+       call      00007FF900021E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF900365D58]
+       call      qword ptr [7FF900395D58]
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
-       mov       rax,172E2340008
+       mov       rax,1DC780A0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
-       mov       rcx,7FF900A9F0A8
-       call      qword ptr [7FF9008C6B38]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900ABF4D8
+       call      qword ptr [7FF9008E6778]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
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
 M00_L00:
-       call      qword ptr [7FF900517060]
+       call      qword ptr [7FF900537060]
        mov       ecx,0AD
-       mov       rdx,7FF9004F7CA0
+       mov       rdx,7FF900517CA0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF900387000
+       mov       rdx,7FF9003A7000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9004F7CA0
+       mov       rdx,7FF900517CA0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF900516E50]
+       call      qword ptr [7FF900536E50]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9001F6718]
+       call      qword ptr [7FF900216718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
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
-       mov       rdx,7FF900C60B18
+       mov       rdx,7FF900C811B8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C60BC8
+       mov       rdx,7FF900C81268
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9000ADFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9000CDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF900C60B28
+       mov       rdx,7FF900C811C8
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
-       call      qword ptr [7FF900367A38]
+       call      qword ptr [7FF900387A38]
        int       3
 ; Total bytes of code 215
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
-       call      00007FF8FFFF1E60
+       call      00007FF900011E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF900365D58]
+       call      qword ptr [7FF900385D58]
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
-       mov       rax,2852F3C0008
+       mov       rax,246F0CD0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
call      qword ptr [7FF900517060]
        mov       ecx,0AD
        mov       rdx,7FF9004F7CA0
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
        mov       rdx,7FF9004F7CA0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF900516E50]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF9001F6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
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
-       mov       rdx,7FF900C60B18
+       mov       rdx,7FF900C61940
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C60BC8
+       mov       rdx,7FF900C619F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF900C60B28
+       mov       rdx,7FF900C61950
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,2852F3C0008
+       mov       rax,1887E960008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
-       mov       rcx,7FF900A9F0A8
-       call      qword ptr [7FF9008C6B38]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900ACF0A8
+       call      qword ptr [7FF9008F6778]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
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
 M00_L00:
-       call      qword ptr [7FF900517060]
+       call      qword ptr [7FF900547060]
        mov       ecx,0AD
-       mov       rdx,7FF9004F7CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF900387000
+       mov       rdx,7FF9003B7000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9004F7CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF900516E50]
+       call      qword ptr [7FF900546E50]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9001F6718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
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
-       mov       rdx,7FF900C60B18
+       mov       rdx,7FF900C90C20
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C60BC8
+       mov       rdx,7FF900C90CD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9000ADFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9000DDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF900C60B28
+       mov       rdx,7FF900C90C30
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
-       call      qword ptr [7FF900367A38]
+       call      qword ptr [7FF900397A38]
        int       3
 ; Total bytes of code 215
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
-       call      00007FF8FFFF1E60
+       call      00007FF900021E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF900365D58]
+       call      qword ptr [7FF900395D58]
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
-       mov       rax,2852F3C0008
+       mov       rax,22FCA100008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
-       mov       rcx,7FF900A9F0A8
-       call      qword ptr [7FF9008C6B38]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900C37910
+       call      qword ptr [7FF9008F6B38]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
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
 M00_L00:
-       call      qword ptr [7FF900517060]
+       call      qword ptr [7FF900547060]
        mov       ecx,0AD
-       mov       rdx,7FF9004F7CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF900387000
+       mov       rdx,7FF9003B7000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9004F7CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF900516E50]
+       call      qword ptr [7FF900546E50]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9001F6718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
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
-       mov       rdx,7FF900C60B18
+       mov       rdx,7FF900CE8D08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C60BC8
+       mov       rdx,7FF900CE8DB8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9000ADFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9000DDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF900C60B28
+       mov       rdx,7FF900CE8D18
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
-       call      qword ptr [7FF900367A38]
+       call      qword ptr [7FF900397A38]
        int       3
 ; Total bytes of code 215
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
-       call      00007FF8FFFF1E60
+       call      00007FF900021E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF900365D58]
+       call      qword ptr [7FF900395D58]
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
-       mov       rax,2852F3C0008
+       mov       rax,19B15C00008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
-       mov       rcx,7FF900A9F0A8
-       call      qword ptr [7FF9008C6B38]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900CEC370
+       call      qword ptr [7FF9008F6B38]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
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
 M00_L00:
-       call      qword ptr [7FF900517060]
+       call      qword ptr [7FF900547060]
        mov       ecx,0AD
-       mov       rdx,7FF9004F7CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF900387000
+       mov       rdx,7FF9003B7000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9004F7CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF900516E50]
+       call      qword ptr [7FF900546E50]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9001F6718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
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
-       mov       rdx,7FF900C60B18
+       mov       rdx,7FF900CFF220
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C60BC8
+       mov       rdx,7FF900CFF2D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9000ADFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9000DDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF900C60B28
+       mov       rdx,7FF900CFF230
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
-       call      qword ptr [7FF900367A38]
+       call      qword ptr [7FF900397A38]
        int       3
 ; Total bytes of code 215
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
-       call      00007FF8FFFF1E60
+       call      00007FF900021E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF900365D58]
+       call      qword ptr [7FF900395D58]
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
-       mov       rax,2852F3C0008
+       mov       rax,1DC780A0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
-       mov       rcx,7FF900ABF4D8
-       call      qword ptr [7FF9008E6778]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900A9F0A8
+       call      qword ptr [7FF9008C6B38]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
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
 M00_L00:
-       call      qword ptr [7FF900537060]
+       call      qword ptr [7FF900517060]
        mov       ecx,0AD
-       mov       rdx,7FF900517CA0
+       mov       rdx,7FF9004F7CA0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9003A7000
+       mov       rdx,7FF900387000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF900517CA0
+       mov       rdx,7FF9004F7CA0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF900536E50]
+       call      qword ptr [7FF900516E50]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF9001F6718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
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
-       mov       rdx,7FF900C811B8
+       mov       rdx,7FF900C61940
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C81268
+       mov       rdx,7FF900C619F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9000CDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9000ADFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF900C811C8
+       mov       rdx,7FF900C61950
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
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900367A38]
        int       3
 ; Total bytes of code 215
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
-       call      00007FF900011E60
+       call      00007FF8FFFF1E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF900385D58]
+       call      qword ptr [7FF900365D58]
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
-       mov       rax,246F0CD0008
+       mov       rax,1887E960008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
-       mov       rcx,7FF900ABF4D8
-       call      qword ptr [7FF9008E6778]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900ACF0A8
+       call      qword ptr [7FF9008F6778]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
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
 M00_L00:
-       call      qword ptr [7FF900537060]
+       call      qword ptr [7FF900547060]
        mov       ecx,0AD
-       mov       rdx,7FF900517CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9003A7000
+       mov       rdx,7FF9003B7000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF900517CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF900536E50]
+       call      qword ptr [7FF900546E50]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
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
-       mov       rdx,7FF900C811B8
+       mov       rdx,7FF900C90C20
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C81268
+       mov       rdx,7FF900C90CD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9000CDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9000DDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF900C811C8
+       mov       rdx,7FF900C90C30
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
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900397A38]
        int       3
 ; Total bytes of code 215
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
-       call      00007FF900011E60
+       call      00007FF900021E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF900385D58]
+       call      qword ptr [7FF900395D58]
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
-       mov       rax,246F0CD0008
+       mov       rax,22FCA100008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
-       mov       rcx,7FF900ABF4D8
-       call      qword ptr [7FF9008E6778]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900C37910
+       call      qword ptr [7FF9008F6B38]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
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
 M00_L00:
-       call      qword ptr [7FF900537060]
+       call      qword ptr [7FF900547060]
        mov       ecx,0AD
-       mov       rdx,7FF900517CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9003A7000
+       mov       rdx,7FF9003B7000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF900517CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF900536E50]
+       call      qword ptr [7FF900546E50]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
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
-       mov       rdx,7FF900C811B8
+       mov       rdx,7FF900CE8D08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C81268
+       mov       rdx,7FF900CE8DB8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9000CDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9000DDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF900C811C8
+       mov       rdx,7FF900CE8D18
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
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900397A38]
        int       3
 ; Total bytes of code 215
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
-       call      00007FF900011E60
+       call      00007FF900021E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF900385D58]
+       call      qword ptr [7FF900395D58]
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
-       mov       rax,246F0CD0008
+       mov       rax,19B15C00008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
-       mov       rcx,7FF900ABF4D8
-       call      qword ptr [7FF9008E6778]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900CEC370
+       call      qword ptr [7FF9008F6B38]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
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
 M00_L00:
-       call      qword ptr [7FF900537060]
+       call      qword ptr [7FF900547060]
        mov       ecx,0AD
-       mov       rdx,7FF900517CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF9003A7000
+       mov       rdx,7FF9003B7000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF900517CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF900016B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF900536E50]
+       call      qword ptr [7FF900546E50]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF900216718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
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
-       mov       rdx,7FF900C811B8
+       mov       rdx,7FF900CFF220
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C81268
+       mov       rdx,7FF900CFF2D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9000CDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9000DDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF900C811C8
+       mov       rdx,7FF900CFF230
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
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900397A38]
        int       3
 ; Total bytes of code 215
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
-       call      00007FF900011E60
+       call      00007FF900021E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9000C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF900385D58]
+       call      qword ptr [7FF900395D58]
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
-       mov       rax,246F0CD0008
+       mov       rax,1DC780A0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
-       mov       rcx,7FF900A9F0A8
-       call      qword ptr [7FF9008C6B38]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900ACF0A8
+       call      qword ptr [7FF9008F6778]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
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
 M00_L00:
-       call      qword ptr [7FF900517060]
+       call      qword ptr [7FF900547060]
        mov       ecx,0AD
-       mov       rdx,7FF9004F7CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF900387000
+       mov       rdx,7FF9003B7000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9004F7CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF900516E50]
+       call      qword ptr [7FF900546E50]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9001F6718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
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
-       mov       rdx,7FF900C61940
+       mov       rdx,7FF900C90C20
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C619F0
+       mov       rdx,7FF900C90CD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9000ADFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9000DDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF900C61950
+       mov       rdx,7FF900C90C30
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
-       call      qword ptr [7FF900367A38]
+       call      qword ptr [7FF900397A38]
        int       3
 ; Total bytes of code 215
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
-       call      00007FF8FFFF1E60
+       call      00007FF900021E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF900365D58]
+       call      qword ptr [7FF900395D58]
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
-       mov       rax,1887E960008
+       mov       rax,22FCA100008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
-       mov       rcx,7FF900A9F0A8
-       call      qword ptr [7FF9008C6B38]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900C37910
+       call      qword ptr [7FF9008F6B38]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
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
 M00_L00:
-       call      qword ptr [7FF900517060]
+       call      qword ptr [7FF900547060]
        mov       ecx,0AD
-       mov       rdx,7FF9004F7CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF900387000
+       mov       rdx,7FF9003B7000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9004F7CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF900516E50]
+       call      qword ptr [7FF900546E50]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9001F6718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
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
-       mov       rdx,7FF900C61940
+       mov       rdx,7FF900CE8D08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C619F0
+       mov       rdx,7FF900CE8DB8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9000ADFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9000DDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF900C61950
+       mov       rdx,7FF900CE8D18
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
-       call      qword ptr [7FF900367A38]
+       call      qword ptr [7FF900397A38]
        int       3
 ; Total bytes of code 215
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
-       call      00007FF8FFFF1E60
+       call      00007FF900021E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF900365D58]
+       call      qword ptr [7FF900395D58]
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
-       mov       rax,1887E960008
+       mov       rax,19B15C00008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
-       mov       rcx,7FF900A9F0A8
-       call      qword ptr [7FF9008C6B38]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900CEC370
+       call      qword ptr [7FF9008F6B38]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
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
 M00_L00:
-       call      qword ptr [7FF900517060]
+       call      qword ptr [7FF900547060]
        mov       ecx,0AD
-       mov       rdx,7FF9004F7CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
        mov       ecx,1C09
-       mov       rdx,7FF900387000
+       mov       rdx,7FF9003B7000
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       ecx,1
-       mov       rdx,7FF9004F7CA0
+       mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
-       call      qword ptr [7FF8FFFF6B08]; System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FF900516E50]
+       call      qword ptr [7FF900546E50]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
-       call      qword ptr [7FF9001F6718]
+       call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
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
-       mov       rdx,7FF900C61940
+       mov       rdx,7FF900CFF220
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C619F0
+       mov       rdx,7FF900CFF2D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       rcx,rbx
        mov       rdx,rsi
-       call      qword ptr [7FF9000ADFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9000DDFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rax,rbx
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF900C61950
+       mov       rdx,7FF900CFF230
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
-       call      qword ptr [7FF900367A38]
+       call      qword ptr [7FF900397A38]
        int       3
 ; Total bytes of code 215
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
-       call      00007FF8FFFF1E60
+       call      00007FF900021E60
        mov       r15,rax
        cmp       [r15],r15b
        lea       rcx,[r15+0C]
        lea       rdx,[rsi+0C]
        mov       r8d,edi
        add       r8,r8
-       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        movsxd    r8,r14d
        lea       rcx,[r15+r8*2+0C]
        lea       rdx,[rbx+0C]
        mov       r8d,ebp
        add       r8,r8
-       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF900365D58]
+       call      qword ptr [7FF900395D58]
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
-       mov       rax,1887E960008
+       mov       rax,1DC780A0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
-       mov       rcx,7FF900ACF0A8
-       call      qword ptr [7FF9008F6778]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900C37910
+       call      qword ptr [7FF9008F6B38]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
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
        call      qword ptr [7FF900547060]
        mov       ecx,0AD
        mov       rdx,7FF900527CA0
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
        mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF900546E50]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
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
-       mov       rdx,7FF900C90C20
+       mov       rdx,7FF900CE8D08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C90CD0
+       mov       rdx,7FF900CE8DB8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF900C90C30
+       mov       rdx,7FF900CE8D18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,22FCA100008
+       mov       rax,19B15C00008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
-       mov       rcx,7FF900ACF0A8
-       call      qword ptr [7FF9008F6778]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900CEC370
+       call      qword ptr [7FF9008F6B38]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
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
        call      qword ptr [7FF900547060]
        mov       ecx,0AD
        mov       rdx,7FF900527CA0
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
        mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF900546E50]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
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
-       mov       rdx,7FF900C90C20
+       mov       rdx,7FF900CFF220
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C90CD0
+       mov       rdx,7FF900CFF2D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF900C90C30
+       mov       rdx,7FF900CFF230
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,22FCA100008
+       mov       rax,1DC780A0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
**Diff for ToList method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
        push      rsi
        push      rbx
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rbx,rcx
        mov       rdx,[rbx+280]
        test      rdx,rdx
        je        short M00_L00
-       mov       rcx,7FF900C37910
+       mov       rcx,7FF900CEC370
        call      qword ptr [7FF9008F6B38]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rsp+20],rax
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
        call      qword ptr [7FF900547060]
        mov       ecx,0AD
        mov       rdx,7FF900527CA0
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
        mov       rdx,7FF900527CA0
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       rcx,rbx
        call      qword ptr [7FF900026B08]; System.String.Concat(System.String, System.String)
        mov       rbx,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        call      qword ptr [7FF900546E50]
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rsi
        call      qword ptr [7FF900226718]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 ; Total bytes of code 227
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
-       mov       rdx,7FF900CE8D08
+       mov       rdx,7FF900CFF220
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900CE8DB8
+       mov       rdx,7FF900CFF2D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L03:
        mov       rcx,[rbx+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L05
        jmp       short M01_L06
 M01_L05:
        mov       rcx,rbx
-       mov       rdx,7FF900CE8D18
+       mov       rdx,7FF900CFF230
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M01_L06:
        test      rbx,rbx
        je        short M02_L03
        mov       ebp,[rbx+8]
        xor       eax,eax
        test      ebp,ebp
        sete      al
        test      eax,eax
        je        short M02_L04
 M02_L03:
-       mov       rax,19B15C00008
+       mov       rax,1DC780A0008
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
```
