## DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark-20240305-033619
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF82997BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF82977BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        cmp       rsi,rbp
        jne       short M01_L03
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
        jne       short M01_L06
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
        jae       short M01_L04
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
        jae       near ptr M01_L12
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
        jmp       short M01_L01
 M01_L03:
        mov       rcx,rdi
-       mov       r11,7FFF823B0D48
+       mov       r11,7FFF82390D48
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
        jmp       short M01_L05
        mov       eax,ebx
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L06:
-       call      qword ptr [7FFF8272EFB8]
+       call      qword ptr [7FFF8270EFB8]
        int       3
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
        xor       eax,eax
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L09:
-       mov       rcx,7FFF82435120
+       mov       rcx,7FFF82415120
        mov       edx,67
        call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov       rcx,244BE401FB8
+       mov       rcx,1BF43C01FB8
        mov       rdi,[rcx]
        jmp       near ptr M01_L00
 M01_L10:
        mov       rcx,rsi
-       mov       r11,7FFF823B0D50
+       mov       r11,7FFF82390D50
        call      qword ptr [r11]
        mov       rdi,rax
        jmp       near ptr M01_L00
 M01_L11:
-       mov       r11,7FFF823B0D40
+       mov       r11,7FFF82390D40
        call      qword ptr [r11]
        mov       rdi,rax
        jmp       near ptr M01_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF82997BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF82967BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        cmp       rsi,rbp
        jne       short M01_L03
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
        jne       short M01_L06
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
        jae       short M01_L04
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
        jae       near ptr M01_L12
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
        jmp       short M01_L01
 M01_L03:
        mov       rcx,rdi
-       mov       r11,7FFF823B0D48
+       mov       r11,7FFF82380D28
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
        jmp       short M01_L05
        mov       eax,ebx
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L06:
-       call      qword ptr [7FFF8272EFB8]
+       call      qword ptr [7FFF826FEFB8]
        int       3
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
        xor       eax,eax
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L09:
-       mov       rcx,7FFF82435120
+       mov       rcx,7FFF82405120
        mov       edx,67
        call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov       rcx,244BE401FB8
+       mov       rcx,16496801FB8
        mov       rdi,[rcx]
        jmp       near ptr M01_L00
 M01_L10:
        mov       rcx,rsi
-       mov       r11,7FFF823B0D50
+       mov       r11,7FFF82380D30
        call      qword ptr [r11]
        mov       rdi,rax
        jmp       near ptr M01_L00
 M01_L11:
-       mov       r11,7FFF823B0D40
+       mov       r11,7FFF82380D20
        call      qword ptr [r11]
        mov       rdi,rax
        jmp       near ptr M01_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF82997BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF829A7BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        cmp       rsi,rbp
        jne       short M01_L03
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
        jne       short M01_L06
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
        jae       short M01_L04
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
        jae       near ptr M01_L12
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
        jmp       short M01_L01
 M01_L03:
        mov       rcx,rdi
-       mov       r11,7FFF823B0D48
+       mov       r11,7FFF823C0D48
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
        jmp       short M01_L05
        mov       eax,ebx
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L06:
-       call      qword ptr [7FFF8272EFB8]
+       call      qword ptr [7FFF8273EFB8]
        int       3
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
        xor       eax,eax
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L09:
-       mov       rcx,7FFF82435120
+       mov       rcx,7FFF82445120
        mov       edx,67
        call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov       rcx,244BE401FB8
+       mov       rcx,2D34A401FB8
        mov       rdi,[rcx]
        jmp       near ptr M01_L00
 M01_L10:
        mov       rcx,rsi
-       mov       r11,7FFF823B0D50
+       mov       r11,7FFF823C0D50
        call      qword ptr [r11]
        mov       rdi,rax
        jmp       near ptr M01_L00
 M01_L11:
-       mov       r11,7FFF823B0D40
+       mov       r11,7FFF823C0D40
        call      qword ptr [r11]
        mov       rdi,rax
        jmp       near ptr M01_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF82997BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF829A7BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        mov       eax,1
        jmp       short M00_L00
 ; Total bytes of code 54
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
        test      rcx,rcx
-       je        near ptr M01_L08
+       je        near ptr M01_L07
        xor       ebx,ebx
        mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rcx],rax
-       jne       near ptr M01_L11
+       jne       near ptr M01_L10
        mov       rcx,[rcx+8]
        mov       rsi,rcx
        mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rsi],rcx
-       jne       near ptr M01_L10
+       jne       near ptr M01_L09
        cmp       dword ptr [rsi+10],0
-       je        near ptr M01_L09
+       je        near ptr M01_L08
        mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rcx,rdi
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rdx,rsi
        mov       esi,[rdx+14]
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rdi+10],rcx
        mov       [rdi+18],ecx
        mov       [rdi+1C],esi
        mov       rsi,[rdi]
        mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rbp,rcx
        jmp       short M01_L02
 M01_L01:
        add       ebx,1
-       jo        near ptr M01_L07
+       jo        near ptr M01_L06
 M01_L02:
        cmp       rsi,rbp
        jne       short M01_L03
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
-       jne       short M01_L06
+       jne       near ptr M01_L11
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
        jae       short M01_L04
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
        jae       near ptr M01_L12
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
        jmp       short M01_L01
 M01_L03:
        mov       rcx,rdi
-       mov       r11,7FFF823B0D48
+       mov       r11,7FFF823C0D78
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
        jmp       short M01_L05
        mov       eax,ebx
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L06:
-       call      qword ptr [7FFF8272EFB8]
-       int       3
-M01_L07:
        call      CORINFO_HELP_OVERFLOW
-M01_L08:
+M01_L07:
        xor       eax,eax
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
-M01_L09:
-       mov       rcx,7FFF82435120
-       mov       edx,67
+M01_L08:
+       mov       rcx,7FFF82445120
+       mov       edx,63
        call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov       rcx,244BE401FB8
+       mov       rcx,1AC90401FA8
        mov       rdi,[rcx]
        jmp       near ptr M01_L00
-M01_L10:
+M01_L09:
        mov       rcx,rsi
-       mov       r11,7FFF823B0D50
+       mov       r11,7FFF823C0D80
        call      qword ptr [r11]
        mov       rdi,rax
        jmp       near ptr M01_L00
-M01_L11:
-       mov       r11,7FFF823B0D40
+M01_L10:
+       mov       r11,7FFF823C0D70
        call      qword ptr [r11]
        mov       rdi,rax
        jmp       near ptr M01_L00
+M01_L11:
+       call      qword ptr [7FFF8273EFB8]
+       int       3
 M01_L12:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 393
+; Total bytes of code 397
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        mov       eax,1
        jmp       short M00_L00
 ; Total bytes of code 54
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
-       test      rcx,rcx
+       mov       rbx,rcx
+       test      rbx,rbx
        je        near ptr M01_L08
-       xor       ebx,ebx
-       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rcx],rax
-       jne       near ptr M01_L11
-       mov       rcx,[rcx+8]
-       mov       rsi,rcx
-       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rsi],rcx
-       jne       near ptr M01_L10
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M01_L09
-       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,rdi
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
+       cmp       [rbx],rcx
+       jne       short M01_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,rsi
-       mov       esi,[rdx+14]
        lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [rdi+10],rcx
-       mov       [rdi+18],ecx
-       mov       [rdi+1C],esi
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L01
 M01_L00:
-       mov       rsi,[rdi]
-       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rbp,rcx
-       jmp       short M01_L02
+       mov       rcx,rbx
+       mov       r11,7FFF823B08E0
+       call      qword ptr [r11]
+       mov       rdi,rax
 M01_L01:
-       add       ebx,1
-       jo        near ptr M01_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
 M01_L02:
-       cmp       rsi,rbp
-       jne       short M01_L03
+       add       esi,1
+       jo        near ptr M01_L07
+M01_L03:
+       cmp       rbx,rbp
+       jne       short M01_L04
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
-       jne       short M01_L06
+       jne       short M01_L09
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
-       jae       short M01_L04
+       jae       short M01_L05
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
-       jae       near ptr M01_L12
+       jae       short M01_L10
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
-       jmp       short M01_L01
-M01_L03:
+       jmp       short M01_L02
+M01_L04:
        mov       rcx,rdi
-       mov       r11,7FFF823B0D48
+       mov       r11,7FFF823B08E8
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L01
-       jmp       short M01_L05
-M01_L04:
+       jne       short M01_L02
+       jmp       short M01_L06
+M01_L05:
        mov       rcx,[r14]
        mov       ecx,[rcx+10]
        inc       ecx
        mov       [r14+10],ecx
        xor       ecx,ecx
        mov       [r14+8],rcx
-M01_L05:
-       mov       eax,ebx
+M01_L06:
+       mov       eax,esi
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
-M01_L06:
-       call      qword ptr [7FFF8272EFB8]
-       int       3
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L09:
-       mov       rcx,7FFF82435120
-       mov       edx,67
-       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov       rcx,244BE401FB8
-       mov       rdi,[rcx]
-       jmp       near ptr M01_L00
+       call      qword ptr [7FFF8272EFB8]
+       int       3
 M01_L10:
-       mov       rcx,rsi
-       mov       r11,7FFF823B0D50
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L11:
-       mov       r11,7FFF823B0D40
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L12:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 393
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF82997BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF82977BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        mov       eax,1
        jmp       short M00_L00
 ; Total bytes of code 54
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
-       test      rcx,rcx
+       mov       rbx,rcx
+       test      rbx,rbx
        je        near ptr M01_L08
-       xor       ebx,ebx
-       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rcx],rax
-       jne       near ptr M01_L11
-       mov       rcx,[rcx+8]
-       mov       rsi,rcx
-       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rsi],rcx
-       jne       near ptr M01_L10
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M01_L09
-       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,rdi
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
+       cmp       [rbx],rcx
+       jne       short M01_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,rsi
-       mov       esi,[rdx+14]
        lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [rdi+10],rcx
-       mov       [rdi+18],ecx
-       mov       [rdi+1C],esi
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L01
 M01_L00:
-       mov       rsi,[rdi]
-       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rbp,rcx
-       jmp       short M01_L02
+       mov       rcx,rbx
+       mov       r11,7FFF82390888
+       call      qword ptr [r11]
+       mov       rdi,rax
 M01_L01:
-       add       ebx,1
-       jo        near ptr M01_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
 M01_L02:
-       cmp       rsi,rbp
-       jne       short M01_L03
+       add       esi,1
+       jo        near ptr M01_L07
+M01_L03:
+       cmp       rbx,rbp
+       jne       short M01_L04
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
-       jne       short M01_L06
+       jne       short M01_L09
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
-       jae       short M01_L04
+       jae       short M01_L05
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
-       jae       near ptr M01_L12
+       jae       short M01_L10
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
-       jmp       short M01_L01
-M01_L03:
+       jmp       short M01_L02
+M01_L04:
        mov       rcx,rdi
-       mov       r11,7FFF823B0D48
+       mov       r11,7FFF82390890
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L01
-       jmp       short M01_L05
-M01_L04:
+       jne       short M01_L02
+       jmp       short M01_L06
+M01_L05:
        mov       rcx,[r14]
        mov       ecx,[rcx+10]
        inc       ecx
        mov       [r14+10],ecx
        xor       ecx,ecx
        mov       [r14+8],rcx
-M01_L05:
-       mov       eax,ebx
+M01_L06:
+       mov       eax,esi
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
-M01_L06:
-       call      qword ptr [7FFF8272EFB8]
-       int       3
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L09:
-       mov       rcx,7FFF82435120
-       mov       edx,67
-       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov       rcx,244BE401FB8
-       mov       rdi,[rcx]
-       jmp       near ptr M01_L00
+       call      qword ptr [7FFF8270EFB8]
+       int       3
 M01_L10:
-       mov       rcx,rsi
-       mov       r11,7FFF823B0D50
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L11:
-       mov       r11,7FFF823B0D40
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L12:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 393
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF82997BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF82977BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        mov       eax,1
        jmp       short M00_L00
 ; Total bytes of code 54
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
-       test      rcx,rcx
+       mov       rbx,rcx
+       test      rbx,rbx
        je        near ptr M01_L08
-       xor       ebx,ebx
-       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rcx],rax
-       jne       near ptr M01_L11
-       mov       rcx,[rcx+8]
-       mov       rsi,rcx
-       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rsi],rcx
-       jne       near ptr M01_L10
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M01_L09
-       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,rdi
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
+       cmp       [rbx],rcx
+       jne       short M01_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,rsi
-       mov       esi,[rdx+14]
        lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [rdi+10],rcx
-       mov       [rdi+18],ecx
-       mov       [rdi+1C],esi
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L01
 M01_L00:
-       mov       rsi,[rdi]
-       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rbp,rcx
-       jmp       short M01_L02
+       mov       rcx,rbx
+       mov       r11,7FFF82390888
+       call      qword ptr [r11]
+       mov       rdi,rax
 M01_L01:
-       add       ebx,1
-       jo        near ptr M01_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
 M01_L02:
-       cmp       rsi,rbp
-       jne       short M01_L03
+       add       esi,1
+       jo        near ptr M01_L07
+M01_L03:
+       cmp       rbx,rbp
+       jne       short M01_L04
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
-       jne       short M01_L06
+       jne       short M01_L09
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
-       jae       short M01_L04
+       jae       short M01_L05
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
-       jae       near ptr M01_L12
+       jae       short M01_L10
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
-       jmp       short M01_L01
-M01_L03:
+       jmp       short M01_L02
+M01_L04:
        mov       rcx,rdi
-       mov       r11,7FFF823B0D48
+       mov       r11,7FFF82390890
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L01
-       jmp       short M01_L05
-M01_L04:
+       jne       short M01_L02
+       jmp       short M01_L06
+M01_L05:
        mov       rcx,[r14]
        mov       ecx,[rcx+10]
        inc       ecx
        mov       [r14+10],ecx
        xor       ecx,ecx
        mov       [r14+8],rcx
-M01_L05:
-       mov       eax,ebx
+M01_L06:
+       mov       eax,esi
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
-M01_L06:
-       call      qword ptr [7FFF8272EFB8]
-       int       3
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L09:
-       mov       rcx,7FFF82435120
-       mov       edx,67
-       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov       rcx,244BE401FB8
-       mov       rdi,[rcx]
-       jmp       near ptr M01_L00
+       call      qword ptr [7FFF8270EFB8]
+       int       3
 M01_L10:
-       mov       rcx,rsi
-       mov       r11,7FFF823B0D50
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L11:
-       mov       r11,7FFF823B0D40
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L12:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 393
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF82977BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF82967BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        cmp       rsi,rbp
        jne       short M01_L03
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
        jne       short M01_L06
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
        jae       short M01_L04
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
        jae       near ptr M01_L12
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
        jmp       short M01_L01
 M01_L03:
        mov       rcx,rdi
-       mov       r11,7FFF82390D48
+       mov       r11,7FFF82380D28
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
        jmp       short M01_L05
        mov       eax,ebx
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L06:
-       call      qword ptr [7FFF8270EFB8]
+       call      qword ptr [7FFF826FEFB8]
        int       3
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
        xor       eax,eax
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L09:
-       mov       rcx,7FFF82415120
+       mov       rcx,7FFF82405120
        mov       edx,67
        call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov       rcx,1BF43C01FB8
+       mov       rcx,16496801FB8
        mov       rdi,[rcx]
        jmp       near ptr M01_L00
 M01_L10:
        mov       rcx,rsi
-       mov       r11,7FFF82390D50
+       mov       r11,7FFF82380D30
        call      qword ptr [r11]
        mov       rdi,rax
        jmp       near ptr M01_L00
 M01_L11:
-       mov       r11,7FFF82390D40
+       mov       r11,7FFF82380D20
        call      qword ptr [r11]
        mov       rdi,rax
        jmp       near ptr M01_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF82977BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF829A7BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        cmp       rsi,rbp
        jne       short M01_L03
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
        jne       short M01_L06
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
        jae       short M01_L04
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
        jae       near ptr M01_L12
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
        jmp       short M01_L01
 M01_L03:
        mov       rcx,rdi
-       mov       r11,7FFF82390D48
+       mov       r11,7FFF823C0D48
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
        jmp       short M01_L05
        mov       eax,ebx
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L06:
-       call      qword ptr [7FFF8270EFB8]
+       call      qword ptr [7FFF8273EFB8]
        int       3
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
        xor       eax,eax
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L09:
-       mov       rcx,7FFF82415120
+       mov       rcx,7FFF82445120
        mov       edx,67
        call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov       rcx,1BF43C01FB8
+       mov       rcx,2D34A401FB8
        mov       rdi,[rcx]
        jmp       near ptr M01_L00
 M01_L10:
        mov       rcx,rsi
-       mov       r11,7FFF82390D50
+       mov       r11,7FFF823C0D50
        call      qword ptr [r11]
        mov       rdi,rax
        jmp       near ptr M01_L00
 M01_L11:
-       mov       r11,7FFF82390D40
+       mov       r11,7FFF823C0D40
        call      qword ptr [r11]
        mov       rdi,rax
        jmp       near ptr M01_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF82977BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF829A7BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        mov       eax,1
        jmp       short M00_L00
 ; Total bytes of code 54
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
        test      rcx,rcx
-       je        near ptr M01_L08
+       je        near ptr M01_L07
        xor       ebx,ebx
        mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rcx],rax
-       jne       near ptr M01_L11
+       jne       near ptr M01_L10
        mov       rcx,[rcx+8]
        mov       rsi,rcx
        mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rsi],rcx
-       jne       near ptr M01_L10
+       jne       near ptr M01_L09
        cmp       dword ptr [rsi+10],0
-       je        near ptr M01_L09
+       je        near ptr M01_L08
        mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rcx,rdi
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rdx,rsi
        mov       esi,[rdx+14]
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rdi+10],rcx
        mov       [rdi+18],ecx
        mov       [rdi+1C],esi
        mov       rsi,[rdi]
        mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rbp,rcx
        jmp       short M01_L02
 M01_L01:
        add       ebx,1
-       jo        near ptr M01_L07
+       jo        near ptr M01_L06
 M01_L02:
        cmp       rsi,rbp
        jne       short M01_L03
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
-       jne       short M01_L06
+       jne       near ptr M01_L11
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
        jae       short M01_L04
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
        jae       near ptr M01_L12
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
        jmp       short M01_L01
 M01_L03:
        mov       rcx,rdi
-       mov       r11,7FFF82390D48
+       mov       r11,7FFF823C0D78
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
        jmp       short M01_L05
        mov       eax,ebx
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L06:
-       call      qword ptr [7FFF8270EFB8]
-       int       3
-M01_L07:
        call      CORINFO_HELP_OVERFLOW
-M01_L08:
+M01_L07:
        xor       eax,eax
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
-M01_L09:
-       mov       rcx,7FFF82415120
-       mov       edx,67
+M01_L08:
+       mov       rcx,7FFF82445120
+       mov       edx,63
        call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov       rcx,1BF43C01FB8
+       mov       rcx,1AC90401FA8
        mov       rdi,[rcx]
        jmp       near ptr M01_L00
-M01_L10:
+M01_L09:
        mov       rcx,rsi
-       mov       r11,7FFF82390D50
+       mov       r11,7FFF823C0D80
        call      qword ptr [r11]
        mov       rdi,rax
        jmp       near ptr M01_L00
-M01_L11:
-       mov       r11,7FFF82390D40
+M01_L10:
+       mov       r11,7FFF823C0D70
        call      qword ptr [r11]
        mov       rdi,rax
        jmp       near ptr M01_L00
+M01_L11:
+       call      qword ptr [7FFF8273EFB8]
+       int       3
 M01_L12:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 393
+; Total bytes of code 397
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF82977BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF82997BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        mov       eax,1
        jmp       short M00_L00
 ; Total bytes of code 54
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
-       test      rcx,rcx
+       mov       rbx,rcx
+       test      rbx,rbx
        je        near ptr M01_L08
-       xor       ebx,ebx
-       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rcx],rax
-       jne       near ptr M01_L11
-       mov       rcx,[rcx+8]
-       mov       rsi,rcx
-       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rsi],rcx
-       jne       near ptr M01_L10
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M01_L09
-       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,rdi
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
+       cmp       [rbx],rcx
+       jne       short M01_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,rsi
-       mov       esi,[rdx+14]
        lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [rdi+10],rcx
-       mov       [rdi+18],ecx
-       mov       [rdi+1C],esi
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L01
 M01_L00:
-       mov       rsi,[rdi]
-       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rbp,rcx
-       jmp       short M01_L02
+       mov       rcx,rbx
+       mov       r11,7FFF823B08E0
+       call      qword ptr [r11]
+       mov       rdi,rax
 M01_L01:
-       add       ebx,1
-       jo        near ptr M01_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
 M01_L02:
-       cmp       rsi,rbp
-       jne       short M01_L03
+       add       esi,1
+       jo        near ptr M01_L07
+M01_L03:
+       cmp       rbx,rbp
+       jne       short M01_L04
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
-       jne       short M01_L06
+       jne       short M01_L09
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
-       jae       short M01_L04
+       jae       short M01_L05
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
-       jae       near ptr M01_L12
+       jae       short M01_L10
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
-       jmp       short M01_L01
-M01_L03:
+       jmp       short M01_L02
+M01_L04:
        mov       rcx,rdi
-       mov       r11,7FFF82390D48
+       mov       r11,7FFF823B08E8
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L01
-       jmp       short M01_L05
-M01_L04:
+       jne       short M01_L02
+       jmp       short M01_L06
+M01_L05:
        mov       rcx,[r14]
        mov       ecx,[rcx+10]
        inc       ecx
        mov       [r14+10],ecx
        xor       ecx,ecx
        mov       [r14+8],rcx
-M01_L05:
-       mov       eax,ebx
+M01_L06:
+       mov       eax,esi
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
-M01_L06:
-       call      qword ptr [7FFF8270EFB8]
-       int       3
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L09:
-       mov       rcx,7FFF82415120
-       mov       edx,67
-       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov       rcx,1BF43C01FB8
-       mov       rdi,[rcx]
-       jmp       near ptr M01_L00
+       call      qword ptr [7FFF8272EFB8]
+       int       3
 M01_L10:
-       mov       rcx,rsi
-       mov       r11,7FFF82390D50
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L11:
-       mov       r11,7FFF82390D40
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L12:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 393
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        mov       eax,1
        jmp       short M00_L00
 ; Total bytes of code 54
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
-       test      rcx,rcx
+       mov       rbx,rcx
+       test      rbx,rbx
        je        near ptr M01_L08
-       xor       ebx,ebx
-       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rcx],rax
-       jne       near ptr M01_L11
-       mov       rcx,[rcx+8]
-       mov       rsi,rcx
-       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rsi],rcx
-       jne       near ptr M01_L10
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M01_L09
-       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,rdi
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
+       cmp       [rbx],rcx
+       jne       short M01_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,rsi
-       mov       esi,[rdx+14]
        lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [rdi+10],rcx
-       mov       [rdi+18],ecx
-       mov       [rdi+1C],esi
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L01
 M01_L00:
-       mov       rsi,[rdi]
-       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rbp,rcx
-       jmp       short M01_L02
+       mov       rcx,rbx
+       mov       r11,7FFF82390888
+       call      qword ptr [r11]
+       mov       rdi,rax
 M01_L01:
-       add       ebx,1
-       jo        near ptr M01_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
 M01_L02:
-       cmp       rsi,rbp
-       jne       short M01_L03
+       add       esi,1
+       jo        near ptr M01_L07
+M01_L03:
+       cmp       rbx,rbp
+       jne       short M01_L04
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
-       jne       short M01_L06
+       jne       short M01_L09
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
-       jae       short M01_L04
+       jae       short M01_L05
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
-       jae       near ptr M01_L12
+       jae       short M01_L10
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
-       jmp       short M01_L01
-M01_L03:
+       jmp       short M01_L02
+M01_L04:
        mov       rcx,rdi
-       mov       r11,7FFF82390D48
+       mov       r11,7FFF82390890
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L01
-       jmp       short M01_L05
-M01_L04:
+       jne       short M01_L02
+       jmp       short M01_L06
+M01_L05:
        mov       rcx,[r14]
        mov       ecx,[rcx+10]
        inc       ecx
        mov       [r14+10],ecx
        xor       ecx,ecx
        mov       [r14+8],rcx
-M01_L05:
-       mov       eax,ebx
+M01_L06:
+       mov       eax,esi
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
-M01_L06:
-       call      qword ptr [7FFF8270EFB8]
-       int       3
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L09:
-       mov       rcx,7FFF82415120
-       mov       edx,67
-       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov       rcx,1BF43C01FB8
-       mov       rdi,[rcx]
-       jmp       near ptr M01_L00
+       call      qword ptr [7FFF8270EFB8]
+       int       3
 M01_L10:
-       mov       rcx,rsi
-       mov       r11,7FFF82390D50
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L11:
-       mov       r11,7FFF82390D40
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L12:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 393
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        mov       eax,1
        jmp       short M00_L00
 ; Total bytes of code 54
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
-       test      rcx,rcx
+       mov       rbx,rcx
+       test      rbx,rbx
        je        near ptr M01_L08
-       xor       ebx,ebx
-       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rcx],rax
-       jne       near ptr M01_L11
-       mov       rcx,[rcx+8]
-       mov       rsi,rcx
-       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rsi],rcx
-       jne       near ptr M01_L10
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M01_L09
-       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,rdi
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
+       cmp       [rbx],rcx
+       jne       short M01_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,rsi
-       mov       esi,[rdx+14]
        lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [rdi+10],rcx
-       mov       [rdi+18],ecx
-       mov       [rdi+1C],esi
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L01
 M01_L00:
-       mov       rsi,[rdi]
-       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rbp,rcx
-       jmp       short M01_L02
+       mov       rcx,rbx
+       mov       r11,7FFF82390888
+       call      qword ptr [r11]
+       mov       rdi,rax
 M01_L01:
-       add       ebx,1
-       jo        near ptr M01_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
 M01_L02:
-       cmp       rsi,rbp
-       jne       short M01_L03
+       add       esi,1
+       jo        near ptr M01_L07
+M01_L03:
+       cmp       rbx,rbp
+       jne       short M01_L04
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
-       jne       short M01_L06
+       jne       short M01_L09
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
-       jae       short M01_L04
+       jae       short M01_L05
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
-       jae       near ptr M01_L12
+       jae       short M01_L10
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
-       jmp       short M01_L01
-M01_L03:
+       jmp       short M01_L02
+M01_L04:
        mov       rcx,rdi
-       mov       r11,7FFF82390D48
+       mov       r11,7FFF82390890
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L01
-       jmp       short M01_L05
-M01_L04:
+       jne       short M01_L02
+       jmp       short M01_L06
+M01_L05:
        mov       rcx,[r14]
        mov       ecx,[rcx+10]
        inc       ecx
        mov       [r14+10],ecx
        xor       ecx,ecx
        mov       [r14+8],rcx
-M01_L05:
-       mov       eax,ebx
+M01_L06:
+       mov       eax,esi
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
-M01_L06:
-       call      qword ptr [7FFF8270EFB8]
-       int       3
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L09:
-       mov       rcx,7FFF82415120
-       mov       edx,67
-       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov       rcx,1BF43C01FB8
-       mov       rdi,[rcx]
-       jmp       near ptr M01_L00
+       call      qword ptr [7FFF8270EFB8]
+       int       3
 M01_L10:
-       mov       rcx,rsi
-       mov       r11,7FFF82390D50
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L11:
-       mov       r11,7FFF82390D40
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L12:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 393
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF82967BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF829A7BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        cmp       rsi,rbp
        jne       short M01_L03
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
        jne       short M01_L06
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
        jae       short M01_L04
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
        jae       near ptr M01_L12
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
        jmp       short M01_L01
 M01_L03:
        mov       rcx,rdi
-       mov       r11,7FFF82380D28
+       mov       r11,7FFF823C0D48
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
        jmp       short M01_L05
        mov       eax,ebx
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L06:
-       call      qword ptr [7FFF826FEFB8]
+       call      qword ptr [7FFF8273EFB8]
        int       3
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
        xor       eax,eax
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L09:
-       mov       rcx,7FFF82405120
+       mov       rcx,7FFF82445120
        mov       edx,67
        call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov       rcx,16496801FB8
+       mov       rcx,2D34A401FB8
        mov       rdi,[rcx]
        jmp       near ptr M01_L00
 M01_L10:
        mov       rcx,rsi
-       mov       r11,7FFF82380D30
+       mov       r11,7FFF823C0D50
        call      qword ptr [r11]
        mov       rdi,rax
        jmp       near ptr M01_L00
 M01_L11:
-       mov       r11,7FFF82380D20
+       mov       r11,7FFF823C0D40
        call      qword ptr [r11]
        mov       rdi,rax
        jmp       near ptr M01_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF82967BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF829A7BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        mov       eax,1
        jmp       short M00_L00
 ; Total bytes of code 54
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
        test      rcx,rcx
-       je        near ptr M01_L08
+       je        near ptr M01_L07
        xor       ebx,ebx
        mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rcx],rax
-       jne       near ptr M01_L11
+       jne       near ptr M01_L10
        mov       rcx,[rcx+8]
        mov       rsi,rcx
        mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rsi],rcx
-       jne       near ptr M01_L10
+       jne       near ptr M01_L09
        cmp       dword ptr [rsi+10],0
-       je        near ptr M01_L09
+       je        near ptr M01_L08
        mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rcx,rdi
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rdx,rsi
        mov       esi,[rdx+14]
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rdi+10],rcx
        mov       [rdi+18],ecx
        mov       [rdi+1C],esi
        mov       rsi,[rdi]
        mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rbp,rcx
        jmp       short M01_L02
 M01_L01:
        add       ebx,1
-       jo        near ptr M01_L07
+       jo        near ptr M01_L06
 M01_L02:
        cmp       rsi,rbp
        jne       short M01_L03
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
-       jne       short M01_L06
+       jne       near ptr M01_L11
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
        jae       short M01_L04
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
        jae       near ptr M01_L12
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
        jmp       short M01_L01
 M01_L03:
        mov       rcx,rdi
-       mov       r11,7FFF82380D28
+       mov       r11,7FFF823C0D78
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
        jmp       short M01_L05
        mov       eax,ebx
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L06:
-       call      qword ptr [7FFF826FEFB8]
-       int       3
-M01_L07:
        call      CORINFO_HELP_OVERFLOW
-M01_L08:
+M01_L07:
        xor       eax,eax
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
-M01_L09:
-       mov       rcx,7FFF82405120
-       mov       edx,67
+M01_L08:
+       mov       rcx,7FFF82445120
+       mov       edx,63
        call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov       rcx,16496801FB8
+       mov       rcx,1AC90401FA8
        mov       rdi,[rcx]
        jmp       near ptr M01_L00
-M01_L10:
+M01_L09:
        mov       rcx,rsi
-       mov       r11,7FFF82380D30
+       mov       r11,7FFF823C0D80
        call      qword ptr [r11]
        mov       rdi,rax
        jmp       near ptr M01_L00
-M01_L11:
-       mov       r11,7FFF82380D20
+M01_L10:
+       mov       r11,7FFF823C0D70
        call      qword ptr [r11]
        mov       rdi,rax
        jmp       near ptr M01_L00
+M01_L11:
+       call      qword ptr [7FFF8273EFB8]
+       int       3
 M01_L12:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 393
+; Total bytes of code 397
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF82967BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF82997BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        mov       eax,1
        jmp       short M00_L00
 ; Total bytes of code 54
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
-       test      rcx,rcx
+       mov       rbx,rcx
+       test      rbx,rbx
        je        near ptr M01_L08
-       xor       ebx,ebx
-       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rcx],rax
-       jne       near ptr M01_L11
-       mov       rcx,[rcx+8]
-       mov       rsi,rcx
-       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rsi],rcx
-       jne       near ptr M01_L10
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M01_L09
-       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,rdi
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
+       cmp       [rbx],rcx
+       jne       short M01_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,rsi
-       mov       esi,[rdx+14]
        lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [rdi+10],rcx
-       mov       [rdi+18],ecx
-       mov       [rdi+1C],esi
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L01
 M01_L00:
-       mov       rsi,[rdi]
-       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rbp,rcx
-       jmp       short M01_L02
+       mov       rcx,rbx
+       mov       r11,7FFF823B08E0
+       call      qword ptr [r11]
+       mov       rdi,rax
 M01_L01:
-       add       ebx,1
-       jo        near ptr M01_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
 M01_L02:
-       cmp       rsi,rbp
-       jne       short M01_L03
+       add       esi,1
+       jo        near ptr M01_L07
+M01_L03:
+       cmp       rbx,rbp
+       jne       short M01_L04
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
-       jne       short M01_L06
+       jne       short M01_L09
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
-       jae       short M01_L04
+       jae       short M01_L05
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
-       jae       near ptr M01_L12
+       jae       short M01_L10
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
-       jmp       short M01_L01
-M01_L03:
+       jmp       short M01_L02
+M01_L04:
        mov       rcx,rdi
-       mov       r11,7FFF82380D28
+       mov       r11,7FFF823B08E8
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L01
-       jmp       short M01_L05
-M01_L04:
+       jne       short M01_L02
+       jmp       short M01_L06
+M01_L05:
        mov       rcx,[r14]
        mov       ecx,[rcx+10]
        inc       ecx
        mov       [r14+10],ecx
        xor       ecx,ecx
        mov       [r14+8],rcx
-M01_L05:
-       mov       eax,ebx
+M01_L06:
+       mov       eax,esi
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
-M01_L06:
-       call      qword ptr [7FFF826FEFB8]
-       int       3
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L09:
-       mov       rcx,7FFF82405120
-       mov       edx,67
-       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov       rcx,16496801FB8
-       mov       rdi,[rcx]
-       jmp       near ptr M01_L00
+       call      qword ptr [7FFF8272EFB8]
+       int       3
 M01_L10:
-       mov       rcx,rsi
-       mov       r11,7FFF82380D30
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L11:
-       mov       r11,7FFF82380D20
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L12:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 393
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF82967BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF82977BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        mov       eax,1
        jmp       short M00_L00
 ; Total bytes of code 54
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
-       test      rcx,rcx
+       mov       rbx,rcx
+       test      rbx,rbx
        je        near ptr M01_L08
-       xor       ebx,ebx
-       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rcx],rax
-       jne       near ptr M01_L11
-       mov       rcx,[rcx+8]
-       mov       rsi,rcx
-       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rsi],rcx
-       jne       near ptr M01_L10
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M01_L09
-       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,rdi
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
+       cmp       [rbx],rcx
+       jne       short M01_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,rsi
-       mov       esi,[rdx+14]
        lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [rdi+10],rcx
-       mov       [rdi+18],ecx
-       mov       [rdi+1C],esi
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L01
 M01_L00:
-       mov       rsi,[rdi]
-       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rbp,rcx
-       jmp       short M01_L02
+       mov       rcx,rbx
+       mov       r11,7FFF82390888
+       call      qword ptr [r11]
+       mov       rdi,rax
 M01_L01:
-       add       ebx,1
-       jo        near ptr M01_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
 M01_L02:
-       cmp       rsi,rbp
-       jne       short M01_L03
+       add       esi,1
+       jo        near ptr M01_L07
+M01_L03:
+       cmp       rbx,rbp
+       jne       short M01_L04
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
-       jne       short M01_L06
+       jne       short M01_L09
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
-       jae       short M01_L04
+       jae       short M01_L05
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
-       jae       near ptr M01_L12
+       jae       short M01_L10
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
-       jmp       short M01_L01
-M01_L03:
+       jmp       short M01_L02
+M01_L04:
        mov       rcx,rdi
-       mov       r11,7FFF82380D28
+       mov       r11,7FFF82390890
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L01
-       jmp       short M01_L05
-M01_L04:
+       jne       short M01_L02
+       jmp       short M01_L06
+M01_L05:
        mov       rcx,[r14]
        mov       ecx,[rcx+10]
        inc       ecx
        mov       [r14+10],ecx
        xor       ecx,ecx
        mov       [r14+8],rcx
-M01_L05:
-       mov       eax,ebx
+M01_L06:
+       mov       eax,esi
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
-M01_L06:
-       call      qword ptr [7FFF826FEFB8]
-       int       3
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L09:
-       mov       rcx,7FFF82405120
-       mov       edx,67
-       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov       rcx,16496801FB8
-       mov       rdi,[rcx]
-       jmp       near ptr M01_L00
+       call      qword ptr [7FFF8270EFB8]
+       int       3
 M01_L10:
-       mov       rcx,rsi
-       mov       r11,7FFF82380D30
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L11:
-       mov       r11,7FFF82380D20
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L12:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 393
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF82967BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF82977BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        mov       eax,1
        jmp       short M00_L00
 ; Total bytes of code 54
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
-       test      rcx,rcx
+       mov       rbx,rcx
+       test      rbx,rbx
        je        near ptr M01_L08
-       xor       ebx,ebx
-       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rcx],rax
-       jne       near ptr M01_L11
-       mov       rcx,[rcx+8]
-       mov       rsi,rcx
-       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rsi],rcx
-       jne       near ptr M01_L10
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M01_L09
-       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,rdi
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
+       cmp       [rbx],rcx
+       jne       short M01_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,rsi
-       mov       esi,[rdx+14]
        lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [rdi+10],rcx
-       mov       [rdi+18],ecx
-       mov       [rdi+1C],esi
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L01
 M01_L00:
-       mov       rsi,[rdi]
-       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rbp,rcx
-       jmp       short M01_L02
+       mov       rcx,rbx
+       mov       r11,7FFF82390888
+       call      qword ptr [r11]
+       mov       rdi,rax
 M01_L01:
-       add       ebx,1
-       jo        near ptr M01_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
 M01_L02:
-       cmp       rsi,rbp
-       jne       short M01_L03
+       add       esi,1
+       jo        near ptr M01_L07
+M01_L03:
+       cmp       rbx,rbp
+       jne       short M01_L04
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
-       jne       short M01_L06
+       jne       short M01_L09
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
-       jae       short M01_L04
+       jae       short M01_L05
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
-       jae       near ptr M01_L12
+       jae       short M01_L10
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
-       jmp       short M01_L01
-M01_L03:
+       jmp       short M01_L02
+M01_L04:
        mov       rcx,rdi
-       mov       r11,7FFF82380D28
+       mov       r11,7FFF82390890
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L01
-       jmp       short M01_L05
-M01_L04:
+       jne       short M01_L02
+       jmp       short M01_L06
+M01_L05:
        mov       rcx,[r14]
        mov       ecx,[rcx+10]
        inc       ecx
        mov       [r14+10],ecx
        xor       ecx,ecx
        mov       [r14+8],rcx
-M01_L05:
-       mov       eax,ebx
+M01_L06:
+       mov       eax,esi
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
-M01_L06:
-       call      qword ptr [7FFF826FEFB8]
-       int       3
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L09:
-       mov       rcx,7FFF82405120
-       mov       edx,67
-       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov       rcx,16496801FB8
-       mov       rdi,[rcx]
-       jmp       near ptr M01_L00
+       call      qword ptr [7FFF8270EFB8]
+       int       3
 M01_L10:
-       mov       rcx,rsi
-       mov       r11,7FFF82380D30
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L11:
-       mov       r11,7FFF82380D20
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L12:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 393
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        mov       eax,1
        jmp       short M00_L00
 ; Total bytes of code 54
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
        test      rcx,rcx
-       je        near ptr M01_L08
+       je        near ptr M01_L07
        xor       ebx,ebx
        mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rcx],rax
-       jne       near ptr M01_L11
+       jne       near ptr M01_L10
        mov       rcx,[rcx+8]
        mov       rsi,rcx
        mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rsi],rcx
-       jne       near ptr M01_L10
+       jne       near ptr M01_L09
        cmp       dword ptr [rsi+10],0
-       je        near ptr M01_L09
+       je        near ptr M01_L08
        mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rcx,rdi
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rdx,rsi
        mov       esi,[rdx+14]
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rdi+10],rcx
        mov       [rdi+18],ecx
        mov       [rdi+1C],esi
        mov       rsi,[rdi]
        mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rbp,rcx
        jmp       short M01_L02
 M01_L01:
        add       ebx,1
-       jo        near ptr M01_L07
+       jo        near ptr M01_L06
 M01_L02:
        cmp       rsi,rbp
        jne       short M01_L03
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
-       jne       short M01_L06
+       jne       near ptr M01_L11
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
        jae       short M01_L04
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
        jae       near ptr M01_L12
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
        jmp       short M01_L01
 M01_L03:
        mov       rcx,rdi
-       mov       r11,7FFF823C0D48
+       mov       r11,7FFF823C0D78
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
        jmp       short M01_L05
        mov       eax,ebx
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L06:
-       call      qword ptr [7FFF8273EFB8]
-       int       3
-M01_L07:
        call      CORINFO_HELP_OVERFLOW
-M01_L08:
+M01_L07:
        xor       eax,eax
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
-M01_L09:
+M01_L08:
        mov       rcx,7FFF82445120
-       mov       edx,67
+       mov       edx,63
        call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov       rcx,2D34A401FB8
+       mov       rcx,1AC90401FA8
        mov       rdi,[rcx]
        jmp       near ptr M01_L00
-M01_L10:
+M01_L09:
        mov       rcx,rsi
-       mov       r11,7FFF823C0D50
+       mov       r11,7FFF823C0D80
        call      qword ptr [r11]
        mov       rdi,rax
        jmp       near ptr M01_L00
-M01_L11:
-       mov       r11,7FFF823C0D40
+M01_L10:
+       mov       r11,7FFF823C0D70
        call      qword ptr [r11]
        mov       rdi,rax
        jmp       near ptr M01_L00
+M01_L11:
+       call      qword ptr [7FFF8273EFB8]
+       int       3
 M01_L12:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 393
+; Total bytes of code 397
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF829A7BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF82997BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        mov       eax,1
        jmp       short M00_L00
 ; Total bytes of code 54
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
-       test      rcx,rcx
+       mov       rbx,rcx
+       test      rbx,rbx
        je        near ptr M01_L08
-       xor       ebx,ebx
-       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rcx],rax
-       jne       near ptr M01_L11
-       mov       rcx,[rcx+8]
-       mov       rsi,rcx
-       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rsi],rcx
-       jne       near ptr M01_L10
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M01_L09
-       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,rdi
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
+       cmp       [rbx],rcx
+       jne       short M01_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,rsi
-       mov       esi,[rdx+14]
        lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [rdi+10],rcx
-       mov       [rdi+18],ecx
-       mov       [rdi+1C],esi
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L01
 M01_L00:
-       mov       rsi,[rdi]
-       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rbp,rcx
-       jmp       short M01_L02
+       mov       rcx,rbx
+       mov       r11,7FFF823B08E0
+       call      qword ptr [r11]
+       mov       rdi,rax
 M01_L01:
-       add       ebx,1
-       jo        near ptr M01_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
 M01_L02:
-       cmp       rsi,rbp
-       jne       short M01_L03
+       add       esi,1
+       jo        near ptr M01_L07
+M01_L03:
+       cmp       rbx,rbp
+       jne       short M01_L04
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
-       jne       short M01_L06
+       jne       short M01_L09
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
-       jae       short M01_L04
+       jae       short M01_L05
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
-       jae       near ptr M01_L12
+       jae       short M01_L10
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
-       jmp       short M01_L01
-M01_L03:
+       jmp       short M01_L02
+M01_L04:
        mov       rcx,rdi
-       mov       r11,7FFF823C0D48
+       mov       r11,7FFF823B08E8
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L01
-       jmp       short M01_L05
-M01_L04:
+       jne       short M01_L02
+       jmp       short M01_L06
+M01_L05:
        mov       rcx,[r14]
        mov       ecx,[rcx+10]
        inc       ecx
        mov       [r14+10],ecx
        xor       ecx,ecx
        mov       [r14+8],rcx
-M01_L05:
-       mov       eax,ebx
+M01_L06:
+       mov       eax,esi
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
-M01_L06:
-       call      qword ptr [7FFF8273EFB8]
-       int       3
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L09:
-       mov       rcx,7FFF82445120
-       mov       edx,67
-       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov       rcx,2D34A401FB8
-       mov       rdi,[rcx]
-       jmp       near ptr M01_L00
+       call      qword ptr [7FFF8272EFB8]
+       int       3
 M01_L10:
-       mov       rcx,rsi
-       mov       r11,7FFF823C0D50
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L11:
-       mov       r11,7FFF823C0D40
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L12:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 393
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF829A7BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF82977BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        mov       eax,1
        jmp       short M00_L00
 ; Total bytes of code 54
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
-       test      rcx,rcx
+       mov       rbx,rcx
+       test      rbx,rbx
        je        near ptr M01_L08
-       xor       ebx,ebx
-       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rcx],rax
-       jne       near ptr M01_L11
-       mov       rcx,[rcx+8]
-       mov       rsi,rcx
-       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rsi],rcx
-       jne       near ptr M01_L10
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M01_L09
-       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,rdi
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
+       cmp       [rbx],rcx
+       jne       short M01_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,rsi
-       mov       esi,[rdx+14]
        lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [rdi+10],rcx
-       mov       [rdi+18],ecx
-       mov       [rdi+1C],esi
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L01
 M01_L00:
-       mov       rsi,[rdi]
-       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rbp,rcx
-       jmp       short M01_L02
+       mov       rcx,rbx
+       mov       r11,7FFF82390888
+       call      qword ptr [r11]
+       mov       rdi,rax
 M01_L01:
-       add       ebx,1
-       jo        near ptr M01_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
 M01_L02:
-       cmp       rsi,rbp
-       jne       short M01_L03
+       add       esi,1
+       jo        near ptr M01_L07
+M01_L03:
+       cmp       rbx,rbp
+       jne       short M01_L04
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
-       jne       short M01_L06
+       jne       short M01_L09
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
-       jae       short M01_L04
+       jae       short M01_L05
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
-       jae       near ptr M01_L12
+       jae       short M01_L10
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
-       jmp       short M01_L01
-M01_L03:
+       jmp       short M01_L02
+M01_L04:
        mov       rcx,rdi
-       mov       r11,7FFF823C0D48
+       mov       r11,7FFF82390890
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L01
-       jmp       short M01_L05
-M01_L04:
+       jne       short M01_L02
+       jmp       short M01_L06
+M01_L05:
        mov       rcx,[r14]
        mov       ecx,[rcx+10]
        inc       ecx
        mov       [r14+10],ecx
        xor       ecx,ecx
        mov       [r14+8],rcx
-M01_L05:
-       mov       eax,ebx
+M01_L06:
+       mov       eax,esi
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
-M01_L06:
-       call      qword ptr [7FFF8273EFB8]
-       int       3
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L09:
-       mov       rcx,7FFF82445120
-       mov       edx,67
-       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov       rcx,2D34A401FB8
-       mov       rdi,[rcx]
-       jmp       near ptr M01_L00
+       call      qword ptr [7FFF8270EFB8]
+       int       3
 M01_L10:
-       mov       rcx,rsi
-       mov       r11,7FFF823C0D50
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L11:
-       mov       r11,7FFF823C0D40
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L12:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 393
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF829A7BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF82977BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        mov       eax,1
        jmp       short M00_L00
 ; Total bytes of code 54
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
-       test      rcx,rcx
+       mov       rbx,rcx
+       test      rbx,rbx
        je        near ptr M01_L08
-       xor       ebx,ebx
-       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rcx],rax
-       jne       near ptr M01_L11
-       mov       rcx,[rcx+8]
-       mov       rsi,rcx
-       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rsi],rcx
-       jne       near ptr M01_L10
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M01_L09
-       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,rdi
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
+       cmp       [rbx],rcx
+       jne       short M01_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,rsi
-       mov       esi,[rdx+14]
        lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [rdi+10],rcx
-       mov       [rdi+18],ecx
-       mov       [rdi+1C],esi
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L01
 M01_L00:
-       mov       rsi,[rdi]
-       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rbp,rcx
-       jmp       short M01_L02
+       mov       rcx,rbx
+       mov       r11,7FFF82390888
+       call      qword ptr [r11]
+       mov       rdi,rax
 M01_L01:
-       add       ebx,1
-       jo        near ptr M01_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
 M01_L02:
-       cmp       rsi,rbp
-       jne       short M01_L03
+       add       esi,1
+       jo        near ptr M01_L07
+M01_L03:
+       cmp       rbx,rbp
+       jne       short M01_L04
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
-       jne       short M01_L06
+       jne       short M01_L09
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
-       jae       short M01_L04
+       jae       short M01_L05
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
-       jae       near ptr M01_L12
+       jae       short M01_L10
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
-       jmp       short M01_L01
-M01_L03:
+       jmp       short M01_L02
+M01_L04:
        mov       rcx,rdi
-       mov       r11,7FFF823C0D48
+       mov       r11,7FFF82390890
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L01
-       jmp       short M01_L05
-M01_L04:
+       jne       short M01_L02
+       jmp       short M01_L06
+M01_L05:
        mov       rcx,[r14]
        mov       ecx,[rcx+10]
        inc       ecx
        mov       [r14+10],ecx
        xor       ecx,ecx
        mov       [r14+8],rcx
-M01_L05:
-       mov       eax,ebx
+M01_L06:
+       mov       eax,esi
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
-M01_L06:
-       call      qword ptr [7FFF8273EFB8]
-       int       3
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L09:
-       mov       rcx,7FFF82445120
-       mov       edx,67
-       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov       rcx,2D34A401FB8
-       mov       rdi,[rcx]
-       jmp       near ptr M01_L00
+       call      qword ptr [7FFF8270EFB8]
+       int       3
 M01_L10:
-       mov       rcx,rsi
-       mov       r11,7FFF823C0D50
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L11:
-       mov       r11,7FFF823C0D40
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L12:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 393
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF829A7BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF82997BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        mov       eax,1
        jmp       short M00_L00
 ; Total bytes of code 54
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
-       test      rcx,rcx
-       je        near ptr M01_L07
-       xor       ebx,ebx
-       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rcx],rax
-       jne       near ptr M01_L10
-       mov       rcx,[rcx+8]
-       mov       rsi,rcx
-       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rsi],rcx
-       jne       near ptr M01_L09
-       cmp       dword ptr [rsi+10],0
+       mov       rbx,rcx
+       test      rbx,rbx
        je        near ptr M01_L08
-       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,rdi
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
+       cmp       [rbx],rcx
+       jne       short M01_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,rsi
-       mov       esi,[rdx+14]
        lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [rdi+10],rcx
-       mov       [rdi+18],ecx
-       mov       [rdi+1C],esi
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L01
 M01_L00:
-       mov       rsi,[rdi]
-       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rbp,rcx
-       jmp       short M01_L02
+       mov       rcx,rbx
+       mov       r11,7FFF823B08E0
+       call      qword ptr [r11]
+       mov       rdi,rax
 M01_L01:
-       add       ebx,1
-       jo        near ptr M01_L06
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
 M01_L02:
-       cmp       rsi,rbp
-       jne       short M01_L03
+       add       esi,1
+       jo        near ptr M01_L07
+M01_L03:
+       cmp       rbx,rbp
+       jne       short M01_L04
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
-       jne       near ptr M01_L11
+       jne       short M01_L09
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
-       jae       short M01_L04
+       jae       short M01_L05
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
-       jae       near ptr M01_L12
+       jae       short M01_L10
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
-       jmp       short M01_L01
-M01_L03:
+       jmp       short M01_L02
+M01_L04:
        mov       rcx,rdi
-       mov       r11,7FFF823C0D78
+       mov       r11,7FFF823B08E8
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L01
-       jmp       short M01_L05
-M01_L04:
+       jne       short M01_L02
+       jmp       short M01_L06
+M01_L05:
        mov       rcx,[r14]
        mov       ecx,[rcx+10]
        inc       ecx
        mov       [r14+10],ecx
        xor       ecx,ecx
        mov       [r14+8],rcx
-M01_L05:
-       mov       eax,ebx
+M01_L06:
+       mov       eax,esi
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
-M01_L06:
-       call      CORINFO_HELP_OVERFLOW
 M01_L07:
+       call      CORINFO_HELP_OVERFLOW
+M01_L08:
        xor       eax,eax
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
-M01_L08:
-       mov       rcx,7FFF82445120
-       mov       edx,63
-       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov       rcx,1AC90401FA8
-       mov       rdi,[rcx]
-       jmp       near ptr M01_L00
 M01_L09:
-       mov       rcx,rsi
-       mov       r11,7FFF823C0D80
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L10:
-       mov       r11,7FFF823C0D70
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L11:
-       call      qword ptr [7FFF8273EFB8]
+       call      qword ptr [7FFF8272EFB8]
        int       3
-M01_L12:
+M01_L10:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 397
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF829A7BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF82977BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        mov       eax,1
        jmp       short M00_L00
 ; Total bytes of code 54
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
-       test      rcx,rcx
-       je        near ptr M01_L07
-       xor       ebx,ebx
-       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rcx],rax
-       jne       near ptr M01_L10
-       mov       rcx,[rcx+8]
-       mov       rsi,rcx
-       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rsi],rcx
-       jne       near ptr M01_L09
-       cmp       dword ptr [rsi+10],0
+       mov       rbx,rcx
+       test      rbx,rbx
        je        near ptr M01_L08
-       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,rdi
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
+       cmp       [rbx],rcx
+       jne       short M01_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,rsi
-       mov       esi,[rdx+14]
        lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [rdi+10],rcx
-       mov       [rdi+18],ecx
-       mov       [rdi+1C],esi
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L01
 M01_L00:
-       mov       rsi,[rdi]
-       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rbp,rcx
-       jmp       short M01_L02
+       mov       rcx,rbx
+       mov       r11,7FFF82390888
+       call      qword ptr [r11]
+       mov       rdi,rax
 M01_L01:
-       add       ebx,1
-       jo        near ptr M01_L06
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
 M01_L02:
-       cmp       rsi,rbp
-       jne       short M01_L03
+       add       esi,1
+       jo        near ptr M01_L07
+M01_L03:
+       cmp       rbx,rbp
+       jne       short M01_L04
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
-       jne       near ptr M01_L11
+       jne       short M01_L09
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
-       jae       short M01_L04
+       jae       short M01_L05
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
-       jae       near ptr M01_L12
+       jae       short M01_L10
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
-       jmp       short M01_L01
-M01_L03:
+       jmp       short M01_L02
+M01_L04:
        mov       rcx,rdi
-       mov       r11,7FFF823C0D78
+       mov       r11,7FFF82390890
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L01
-       jmp       short M01_L05
-M01_L04:
+       jne       short M01_L02
+       jmp       short M01_L06
+M01_L05:
        mov       rcx,[r14]
        mov       ecx,[rcx+10]
        inc       ecx
        mov       [r14+10],ecx
        xor       ecx,ecx
        mov       [r14+8],rcx
-M01_L05:
-       mov       eax,ebx
+M01_L06:
+       mov       eax,esi
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
-M01_L06:
-       call      CORINFO_HELP_OVERFLOW
 M01_L07:
+       call      CORINFO_HELP_OVERFLOW
+M01_L08:
        xor       eax,eax
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
-M01_L08:
-       mov       rcx,7FFF82445120
-       mov       edx,63
-       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov       rcx,1AC90401FA8
-       mov       rdi,[rcx]
-       jmp       near ptr M01_L00
 M01_L09:
-       mov       rcx,rsi
-       mov       r11,7FFF823C0D80
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L10:
-       mov       r11,7FFF823C0D70
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L11:
-       call      qword ptr [7FFF8273EFB8]
+       call      qword ptr [7FFF8270EFB8]
        int       3
-M01_L12:
+M01_L10:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 397
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF829A7BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF82977BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        mov       eax,1
        jmp       short M00_L00
 ; Total bytes of code 54
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
-       test      rcx,rcx
-       je        near ptr M01_L07
-       xor       ebx,ebx
-       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rcx],rax
-       jne       near ptr M01_L10
-       mov       rcx,[rcx+8]
-       mov       rsi,rcx
-       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rsi],rcx
-       jne       near ptr M01_L09
-       cmp       dword ptr [rsi+10],0
+       mov       rbx,rcx
+       test      rbx,rbx
        je        near ptr M01_L08
-       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,rdi
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
+       cmp       [rbx],rcx
+       jne       short M01_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,rsi
-       mov       esi,[rdx+14]
        lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [rdi+10],rcx
-       mov       [rdi+18],ecx
-       mov       [rdi+1C],esi
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L01
 M01_L00:
-       mov       rsi,[rdi]
-       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rbp,rcx
-       jmp       short M01_L02
+       mov       rcx,rbx
+       mov       r11,7FFF82390888
+       call      qword ptr [r11]
+       mov       rdi,rax
 M01_L01:
-       add       ebx,1
-       jo        near ptr M01_L06
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
 M01_L02:
-       cmp       rsi,rbp
-       jne       short M01_L03
+       add       esi,1
+       jo        near ptr M01_L07
+M01_L03:
+       cmp       rbx,rbp
+       jne       short M01_L04
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
-       jne       near ptr M01_L11
+       jne       short M01_L09
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
-       jae       short M01_L04
+       jae       short M01_L05
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
-       jae       near ptr M01_L12
+       jae       short M01_L10
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
-       jmp       short M01_L01
-M01_L03:
+       jmp       short M01_L02
+M01_L04:
        mov       rcx,rdi
-       mov       r11,7FFF823C0D78
+       mov       r11,7FFF82390890
        call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L01
-       jmp       short M01_L05
-M01_L04:
+       jne       short M01_L02
+       jmp       short M01_L06
+M01_L05:
        mov       rcx,[r14]
        mov       ecx,[rcx+10]
        inc       ecx
        mov       [r14+10],ecx
        xor       ecx,ecx
        mov       [r14+8],rcx
-M01_L05:
-       mov       eax,ebx
+M01_L06:
+       mov       eax,esi
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
-M01_L06:
-       call      CORINFO_HELP_OVERFLOW
 M01_L07:
+       call      CORINFO_HELP_OVERFLOW
+M01_L08:
        xor       eax,eax
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
-M01_L08:
-       mov       rcx,7FFF82445120
-       mov       edx,63
-       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov       rcx,1AC90401FA8
-       mov       rdi,[rcx]
-       jmp       near ptr M01_L00
 M01_L09:
-       mov       rcx,rsi
-       mov       r11,7FFF823C0D80
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L10:
-       mov       r11,7FFF823C0D70
-       call      qword ptr [r11]
-       mov       rdi,rax
-       jmp       near ptr M01_L00
-M01_L11:
-       call      qword ptr [7FFF8273EFB8]
+       call      qword ptr [7FFF8270EFB8]
        int       3
-M01_L12:
+M01_L10:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 397
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF82997BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF82977BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       eax,1
        jmp       short M00_L00
 ; Total bytes of code 54
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M01_L08
        xor       esi,esi
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
        cmp       [rbx],rcx
        jne       short M01_L00
        mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       r11,7FFF823B08E0
+       mov       r11,7FFF82390888
        call      qword ptr [r11]
        mov       rdi,rax
 M01_L01:
        cmp       rbx,rbp
        jne       short M01_L04
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
        jne       short M01_L09
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
        jae       short M01_L05
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
        jae       short M01_L10
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
        jmp       short M01_L02
 M01_L04:
        mov       rcx,rdi
-       mov       r11,7FFF823B08E8
+       mov       r11,7FFF82390890
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L02
        jmp       short M01_L06
        xor       eax,eax
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L09:
-       call      qword ptr [7FFF8272EFB8]
+       call      qword ptr [7FFF8270EFB8]
        int       3
 M01_L10:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF82997BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF82977BD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       eax,1
        jmp       short M00_L00
 ; Total bytes of code 54
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M01_L08
        xor       esi,esi
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
        cmp       [rbx],rcx
        jne       short M01_L00
        mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
        jmp       short M01_L01
 M01_L00:
        mov       rcx,rbx
-       mov       r11,7FFF823B08E0
+       mov       r11,7FFF82390888
        call      qword ptr [r11]
        mov       rdi,rax
 M01_L01:
        cmp       rbx,rbp
        jne       short M01_L04
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
        jne       short M01_L09
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
        jae       short M01_L05
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
        jae       short M01_L10
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
        jmp       short M01_L02
 M01_L04:
        mov       rcx,rdi
-       mov       r11,7FFF823B08E8
+       mov       r11,7FFF82390890
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L02
        jmp       short M01_L06
        xor       eax,eax
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L09:
-       call      qword ptr [7FFF8272EFB8]
+       call      qword ptr [7FFF8270EFB8]
        int       3
 M01_L10:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff

```
