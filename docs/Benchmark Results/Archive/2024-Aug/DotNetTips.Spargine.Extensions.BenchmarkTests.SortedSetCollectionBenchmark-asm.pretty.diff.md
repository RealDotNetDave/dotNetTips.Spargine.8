## DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark-20240727-060430
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,2B55200CE18
+       mov       r8,27170802278
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE8C5BF888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE8C58DB00]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 M00_L01:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2B55200CE10
+       mov       rdx,27170802270
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE8C6BAC58
-       call      qword ptr [7FFE8BCA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2B55200CE18
+       mov       r8,7FFE8C688D20
+       call      qword ptr [7FFE8BC74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,27170802278
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6BAC58
+       mov       rdx,7FFE8C688D20
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE8C79F388
+       mov       rdx,7FFE8C7B2B98
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        mov       rax,[rbp-38]
        jne       near ptr M01_L14
 M01_L05:
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C6BEFE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C68D0B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6BAC58
+       mov       rdx,7FFE8C688D20
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE8C79F388
+       mov       rdx,7FFE8C7B2B98
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE8BB60E38
+       mov       r11,7FFE8BB30E38
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        mov       rax,[rbp-38]
        jne       short M01_L14
 M01_L11:
        mov       rdi,[rax]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C6BEFE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C68D0B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE8C79F2B0
+       mov       rdx,7FFE8C7B2AC0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       eax,1
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L16:
        mov       ecx,10
-       call      qword ptr [7FFE8BF24F30]
+       call      qword ptr [7FFE8BEF4F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE8BF24F30]
+       call      qword ptr [7FFE8BEF4F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,rax
-       mov       r11,7FFE8BB60E40
+       mov       r11,7FFE8BB30E40
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-38],0
        je        short M01_L22
        mov       rcx,[rbp-38]
        mov       rdi,[rcx]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        je        short M01_L22
        mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB60E40
+       mov       r11,7FFE8BB30E40
        call      qword ptr [r11]
 M01_L22:
        nop
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 ; Total bytes of code 607
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFE8BCA41F8]
+       call      qword ptr [7FFE8BC741F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,2B55200CE18
+       mov       r8,1B5F600CE18
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE8C5BF888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE8C58DB00]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 M00_L01:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2B55200CE10
+       mov       rdx,1B5F600CE10
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE8C6BAC58
-       call      qword ptr [7FFE8BCA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2B55200CE18
+       mov       r8,7FFE8C6893B0
+       call      qword ptr [7FFE8BC74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1B5F600CE18
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6BAC58
+       mov       rdx,7FFE8C6893B0
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE8C79F388
+       mov       rdx,7FFE8C7B2BD8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
 M01_L04:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
-       mov       rax,[rbp-38]
        jne       near ptr M01_L14
 M01_L05:
+       mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C6BEFE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C68D740]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6BAC58
+       mov       rdx,7FFE8C6893B0
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE8C79F388
+       mov       rdx,7FFE8C7B2BD8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE8BB60E38
+       mov       r11,7FFE8BB30E38
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
-       mov       rax,[rbp-38]
        jne       short M01_L14
 M01_L11:
+       mov       rax,[rbp-38]
        mov       rdi,[rax]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C6BEFE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C68D740]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE8C79F2B0
+       mov       rdx,7FFE8C7B2B00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       eax,1
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L16:
        mov       ecx,10
-       call      qword ptr [7FFE8BF24F30]
+       call      qword ptr [7FFE8BEF4F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE8BF24F30]
+       call      qword ptr [7FFE8BEF4F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFE8BB60E40
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE8BB30E40
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-38],0
        je        short M01_L22
        mov       rcx,[rbp-38]
        mov       rdi,[rcx]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        je        short M01_L22
-       mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB60E40
+       mov       r11,7FFE8BB30E40
        call      qword ptr [r11]
 M01_L22:
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
-; Total bytes of code 607
+; Total bytes of code 604
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFE8BCA41F8]
+       call      qword ptr [7FFE8BC741F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,2B55200CE18
+       mov       r8,1B6AB402278
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE8C5BF888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE8C59CCA8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 M00_L01:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2B55200CE10
+       mov       rdx,1B6AB402270
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE8C6BAC58
-       call      qword ptr [7FFE8BCA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2B55200CE18
+       mov       r8,7FFE8C6A3D38
+       call      qword ptr [7FFE8BC84210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1B6AB402278
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6BAC58
+       mov       rdx,7FFE8C6A3D38
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE8C79F388
+       mov       rdx,7FFE8C7C2D08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
 M01_L04:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
-       mov       rax,[rbp-38]
        jne       near ptr M01_L14
 M01_L05:
+       mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C6BEFE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C6AC288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6BAC58
+       mov       rdx,7FFE8C6A3D38
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE8C79F388
+       mov       rdx,7FFE8C7C2D08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE8BB60E38
+       mov       r11,7FFE8BB40E38
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
-       mov       rax,[rbp-38]
        jne       short M01_L14
 M01_L11:
+       mov       rax,[rbp-38]
        mov       rdi,[rax]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C6BEFE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C6AC288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE8C79F2B0
+       mov       rdx,7FFE8C7C2C30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       eax,1
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L16:
        mov       ecx,10
-       call      qword ptr [7FFE8BF24F30]
+       call      qword ptr [7FFE8BF04F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE8BF24F30]
+       call      qword ptr [7FFE8BF04F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFE8BB60E40
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE8BB40E40
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-38],0
        je        short M01_L22
        mov       rcx,[rbp-38]
        mov       rdi,[rcx]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        je        short M01_L22
-       mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB60E40
+       mov       r11,7FFE8BB40E40
        call      qword ptr [r11]
 M01_L22:
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
-; Total bytes of code 607
+; Total bytes of code 604
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFE8BCA41F8]
+       call      qword ptr [7FFE8BC841F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,2B55200CE18
+       mov       r8,1B07500CE18
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE8C5BF888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE8C58FF48]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 M00_L01:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2B55200CE10
+       mov       rdx,1B07500CE10
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE8C6BAC58
-       call      qword ptr [7FFE8BCA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2B55200CE18
+       mov       r8,7FFE8C68B3A8
+       call      qword ptr [7FFE8BC74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1B07500CE18
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6BAC58
+       mov       rdx,7FFE8C68B3A8
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE8C79F388
+       mov       rdx,7FFE8C7B88A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        mov       rax,[rbp-38]
        jne       near ptr M01_L14
 M01_L05:
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C6BEFE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C68F738]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6BAC58
+       mov       rdx,7FFE8C68B3A8
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE8C79F388
+       mov       rdx,7FFE8C7B88A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE8BB60E38
+       mov       r11,7FFE8BB30EE8
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        mov       rax,[rbp-38]
        jne       short M01_L14
 M01_L11:
        mov       rdi,[rax]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C6BEFE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C68F738]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE8C79F2B0
+       mov       rdx,7FFE8C7B87C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       eax,1
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L16:
        mov       ecx,10
-       call      qword ptr [7FFE8BF24F30]
+       call      qword ptr [7FFE8BEF4F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE8BF24F30]
+       call      qword ptr [7FFE8BEF4F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,rax
-       mov       r11,7FFE8BB60E40
+       mov       r11,7FFE8BB30EF0
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-38],0
        je        short M01_L22
        mov       rcx,[rbp-38]
        mov       rdi,[rcx]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        je        short M01_L22
        mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB60E40
+       mov       r11,7FFE8BB30EF0
        call      qword ptr [r11]
 M01_L22:
        nop
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 ; Total bytes of code 607
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFE8BCA41F8]
+       call      qword ptr [7FFE8BC741F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,2B55200CE18
+       mov       r8,18EEAC0CE18
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE8C5BF888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE8C6AE7F0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 M00_L01:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2B55200CE10
+       mov       rdx,18EEAC0CE10
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE8C6BAC58
+       mov       r8,7FFE8C729F08
        call      qword ptr [7FFE8BCA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2B55200CE18
+       mov       rcx,18EEAC0CE18
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6BAC58
+       mov       rdx,7FFE8C729F08
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE8C79F388
+       mov       rdx,7FFE8C806E18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
 M01_L04:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
-       mov       rax,[rbp-38]
        jne       near ptr M01_L14
 M01_L05:
+       mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C6BEFE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C72E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6BAC58
+       mov       rdx,7FFE8C729F08
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE8C79F388
+       mov       rdx,7FFE8C806E18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE8BB60E38
+       mov       r11,7FFE8BB61388
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
-       mov       rax,[rbp-38]
        jne       short M01_L14
 M01_L11:
+       mov       rax,[rbp-38]
        mov       rdi,[rax]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C6BEFE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C72E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE8C79F2B0
+       mov       rdx,7FFE8C806D40
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFE8BB60E40
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE8BB61390
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-38],0
        je        short M01_L22
        mov       rcx,[rbp-38]
        mov       rdi,[rcx]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        je        short M01_L22
        mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB60E40
+       mov       r11,7FFE8BB61390
        call      qword ptr [r11]
 M01_L22:
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
-; Total bytes of code 607
+; Total bytes of code 608
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,2B55200CE18
+       mov       r8,1A29BC02278
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE8C5BF888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE8C68E7C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 M00_L01:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2B55200CE10
+       mov       rdx,1A29BC02270
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE8C6BAC58
-       call      qword ptr [7FFE8BCA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2B55200CE18
+       mov       r8,7FFE8C709950
+       call      qword ptr [7FFE8BC74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1A29BC02278
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6BAC58
+       mov       rdx,7FFE8C709950
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE8C79F388
+       mov       rdx,7FFE8C7CB358
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
 M01_L04:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
-       mov       rax,[rbp-38]
        jne       near ptr M01_L14
 M01_L05:
+       mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C6BEFE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C70DCE0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6BAC58
+       mov       rdx,7FFE8C709950
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE8C79F388
+       mov       rdx,7FFE8C7CB358
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE8BB60E38
+       mov       r11,7FFE8BB31498
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
-       mov       rax,[rbp-38]
        jne       short M01_L14
 M01_L11:
+       mov       rax,[rbp-38]
        mov       rdi,[rax]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C6BEFE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C70DCE0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE8C79F2B0
+       mov       rdx,7FFE8C7CB280
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       eax,1
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L16:
        mov       ecx,10
-       call      qword ptr [7FFE8BF24F30]
+       call      qword ptr [7FFE8BEF4F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE8BF24F30]
+       call      qword ptr [7FFE8BEF4F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFE8BB60E40
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE8BB314A0
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-38],0
        je        short M01_L22
        mov       rcx,[rbp-38]
        mov       rdi,[rcx]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        je        short M01_L22
-       mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB60E40
+       mov       r11,7FFE8BB314A0
        call      qword ptr [r11]
 M01_L22:
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
-; Total bytes of code 607
+; Total bytes of code 604
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFE8BCA41F8]
+       call      qword ptr [7FFE8BC741F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,2B55200CE18
+       mov       r8,291E540CE18
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE8C5BF888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE8C6BE9B8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 M00_L01:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2B55200CE10
+       mov       rdx,291E540CE10
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE8C6BAC58
+       mov       r8,7FFE8C739950
        call      qword ptr [7FFE8BCA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2B55200CE18
+       mov       rcx,291E540CE18
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6BAC58
+       mov       rdx,7FFE8C739950
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE8C79F388
+       mov       rdx,7FFE8C7FD880
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
 M01_L04:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
-       mov       rax,[rbp-38]
        jne       near ptr M01_L14
 M01_L05:
+       mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C6BEFE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C73DCE0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6BAC58
+       mov       rdx,7FFE8C739950
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE8C79F388
+       mov       rdx,7FFE8C7FD880
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE8BB60E38
+       mov       r11,7FFE8BB614C0
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
-       mov       rax,[rbp-38]
        jne       short M01_L14
 M01_L11:
+       mov       rax,[rbp-38]
        mov       rdi,[rax]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C6BEFE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C73DCE0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE8C79F2B0
+       mov       rdx,7FFE8C7FD7A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFE8BB60E40
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE8BB614C8
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-38],0
        je        short M01_L22
        mov       rcx,[rbp-38]
        mov       rdi,[rcx]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        je        short M01_L22
-       mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB60E40
+       mov       r11,7FFE8BB614C8
        call      qword ptr [r11]
 M01_L22:
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
-; Total bytes of code 607
+; Total bytes of code 604
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,27170802278
+       mov       r8,1B5F600CE18
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,27170802270
+       mov       rdx,1B5F600CE10
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE8C688D20
+       mov       r8,7FFE8C6893B0
        call      qword ptr [7FFE8BC74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,27170802278
+       mov       rcx,1B5F600CE18
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C688D20
+       mov       rdx,7FFE8C6893B0
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2B98
+       mov       rdx,7FFE8C7B2BD8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
 M01_L04:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
-       mov       rax,[rbp-38]
        jne       near ptr M01_L14
 M01_L05:
+       mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C68D0B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C68D740]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C688D20
+       mov       rdx,7FFE8C6893B0
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2B98
+       mov       rdx,7FFE8C7B2BD8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
        mov       rcx,rax
        mov       r11,7FFE8BB30E38
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
-       mov       rax,[rbp-38]
        jne       short M01_L14
 M01_L11:
+       mov       rax,[rbp-38]
        mov       rdi,[rax]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C68D0B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C68D740]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2AC0
+       mov       rdx,7FFE8C7B2B00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
+       mov       rcx,[rbp-38]
        mov       r11,7FFE8BB30E40
        call      qword ptr [r11]
        jmp       short M01_L15
        xor       eax,eax
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-38],0
        je        short M01_L22
        mov       rcx,[rbp-38]
        mov       rdi,[rcx]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        je        short M01_L22
-       mov       rcx,[rbp-38]
        mov       r11,7FFE8BB30E40
        call      qword ptr [r11]
 M01_L22:
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
-; Total bytes of code 607
+; Total bytes of code 604
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,27170802278
+       mov       r8,1B6AB402278
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE8C58DB00]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE8C59CCA8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 M00_L01:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,27170802270
+       mov       rdx,1B6AB402270
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE8C688D20
-       call      qword ptr [7FFE8BC74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,27170802278
+       mov       r8,7FFE8C6A3D38
+       call      qword ptr [7FFE8BC84210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1B6AB402278
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C688D20
+       mov       rdx,7FFE8C6A3D38
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2B98
+       mov       rdx,7FFE8C7C2D08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
 M01_L04:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
-       mov       rax,[rbp-38]
        jne       near ptr M01_L14
 M01_L05:
+       mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C68D0B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C6AC288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C688D20
+       mov       rdx,7FFE8C6A3D38
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2B98
+       mov       rdx,7FFE8C7C2D08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE8BB30E38
+       mov       r11,7FFE8BB40E38
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
-       mov       rax,[rbp-38]
        jne       short M01_L14
 M01_L11:
+       mov       rax,[rbp-38]
        mov       rdi,[rax]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C68D0B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C6AC288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2AC0
+       mov       rdx,7FFE8C7C2C30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       eax,1
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L16:
        mov       ecx,10
-       call      qword ptr [7FFE8BEF4F30]
+       call      qword ptr [7FFE8BF04F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE8BEF4F30]
+       call      qword ptr [7FFE8BF04F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFE8BB30E40
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE8BB40E40
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-38],0
        je        short M01_L22
        mov       rcx,[rbp-38]
        mov       rdi,[rcx]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        je        short M01_L22
-       mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB30E40
+       mov       r11,7FFE8BB40E40
        call      qword ptr [r11]
 M01_L22:
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
-; Total bytes of code 607
+; Total bytes of code 604
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFE8BC741F8]
+       call      qword ptr [7FFE8BC841F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,27170802278
+       mov       r8,1B07500CE18
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE8C58DB00]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE8C58FF48]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 M00_L01:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,27170802270
+       mov       rdx,1B07500CE10
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE8C688D20
+       mov       r8,7FFE8C68B3A8
        call      qword ptr [7FFE8BC74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,27170802278
+       mov       rcx,1B07500CE18
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C688D20
+       mov       rdx,7FFE8C68B3A8
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2B98
+       mov       rdx,7FFE8C7B88A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        mov       rax,[rbp-38]
        jne       near ptr M01_L14
 M01_L05:
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C68D0B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C68F738]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C688D20
+       mov       rdx,7FFE8C68B3A8
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2B98
+       mov       rdx,7FFE8C7B88A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE8BB30E38
+       mov       r11,7FFE8BB30EE8
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        mov       rax,[rbp-38]
        jne       short M01_L14
 M01_L11:
        mov       rdi,[rax]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C68D0B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C68F738]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2AC0
+       mov       rdx,7FFE8C7B87C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,rax
-       mov       r11,7FFE8BB30E40
+       mov       r11,7FFE8BB30EF0
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-38],0
        je        short M01_L22
        mov       rcx,[rbp-38]
        mov       rdi,[rcx]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        je        short M01_L22
        mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB30E40
+       mov       r11,7FFE8BB30EF0
        call      qword ptr [r11]
 M01_L22:
        nop
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,27170802278
+       mov       r8,18EEAC0CE18
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE8C58DB00]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE8C6AE7F0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 M00_L01:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,27170802270
+       mov       rdx,18EEAC0CE10
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE8C688D20
-       call      qword ptr [7FFE8BC74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,27170802278
+       mov       r8,7FFE8C729F08
+       call      qword ptr [7FFE8BCA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,18EEAC0CE18
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C688D20
+       mov       rdx,7FFE8C729F08
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2B98
+       mov       rdx,7FFE8C806E18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
 M01_L04:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
-       mov       rax,[rbp-38]
        jne       near ptr M01_L14
 M01_L05:
+       mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C68D0B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C72E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C688D20
+       mov       rdx,7FFE8C729F08
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2B98
+       mov       rdx,7FFE8C806E18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE8BB30E38
+       mov       r11,7FFE8BB61388
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
-       mov       rax,[rbp-38]
        jne       short M01_L14
 M01_L11:
+       mov       rax,[rbp-38]
        mov       rdi,[rax]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C68D0B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C72E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2AC0
+       mov       rdx,7FFE8C806D40
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       eax,1
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L16:
        mov       ecx,10
-       call      qword ptr [7FFE8BEF4F30]
+       call      qword ptr [7FFE8BF24F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE8BEF4F30]
+       call      qword ptr [7FFE8BF24F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFE8BB30E40
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE8BB61390
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-38],0
        je        short M01_L22
        mov       rcx,[rbp-38]
        mov       rdi,[rcx]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        je        short M01_L22
        mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB30E40
+       mov       r11,7FFE8BB61390
        call      qword ptr [r11]
 M01_L22:
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
-; Total bytes of code 607
+; Total bytes of code 608
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFE8BC741F8]
+       call      qword ptr [7FFE8BCA41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,27170802278
+       mov       r8,1A29BC02278
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE8C58DB00]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE8C68E7C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 M00_L01:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,27170802270
+       mov       rdx,1A29BC02270
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE8C688D20
+       mov       r8,7FFE8C709950
        call      qword ptr [7FFE8BC74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,27170802278
+       mov       rcx,1A29BC02278
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C688D20
+       mov       rdx,7FFE8C709950
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2B98
+       mov       rdx,7FFE8C7CB358
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
 M01_L04:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
-       mov       rax,[rbp-38]
        jne       near ptr M01_L14
 M01_L05:
+       mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C68D0B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C70DCE0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C688D20
+       mov       rdx,7FFE8C709950
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2B98
+       mov       rdx,7FFE8C7CB358
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE8BB30E38
+       mov       r11,7FFE8BB31498
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
-       mov       rax,[rbp-38]
        jne       short M01_L14
 M01_L11:
+       mov       rax,[rbp-38]
        mov       rdi,[rax]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C68D0B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C70DCE0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2AC0
+       mov       rdx,7FFE8C7CB280
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFE8BB30E40
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE8BB314A0
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-38],0
        je        short M01_L22
        mov       rcx,[rbp-38]
        mov       rdi,[rcx]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        je        short M01_L22
-       mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB30E40
+       mov       r11,7FFE8BB314A0
        call      qword ptr [r11]
 M01_L22:
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
-; Total bytes of code 607
+; Total bytes of code 604
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,27170802278
+       mov       r8,291E540CE18
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE8C58DB00]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE8C6BE9B8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 M00_L01:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,27170802270
+       mov       rdx,291E540CE10
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE8C688D20
-       call      qword ptr [7FFE8BC74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,27170802278
+       mov       r8,7FFE8C739950
+       call      qword ptr [7FFE8BCA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,291E540CE18
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C688D20
+       mov       rdx,7FFE8C739950
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2B98
+       mov       rdx,7FFE8C7FD880
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
 M01_L04:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
-       mov       rax,[rbp-38]
        jne       near ptr M01_L14
 M01_L05:
+       mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C68D0B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C73DCE0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C688D20
+       mov       rdx,7FFE8C739950
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2B98
+       mov       rdx,7FFE8C7FD880
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE8BB30E38
+       mov       r11,7FFE8BB614C0
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
-       mov       rax,[rbp-38]
        jne       short M01_L14
 M01_L11:
+       mov       rax,[rbp-38]
        mov       rdi,[rax]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C68D0B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C73DCE0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2AC0
+       mov       rdx,7FFE8C7FD7A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       eax,1
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L16:
        mov       ecx,10
-       call      qword ptr [7FFE8BEF4F30]
+       call      qword ptr [7FFE8BF24F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE8BEF4F30]
+       call      qword ptr [7FFE8BF24F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFE8BB30E40
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE8BB614C8
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-38],0
        je        short M01_L22
        mov       rcx,[rbp-38]
        mov       rdi,[rcx]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        je        short M01_L22
-       mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB30E40
+       mov       r11,7FFE8BB614C8
        call      qword ptr [r11]
 M01_L22:
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
-; Total bytes of code 607
+; Total bytes of code 604
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFE8BC741F8]
+       call      qword ptr [7FFE8BCA41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,1B5F600CE18
+       mov       r8,1B6AB402278
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE8C58DB00]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE8C59CCA8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 M00_L01:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1B5F600CE10
+       mov       rdx,1B6AB402270
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE8C6893B0
-       call      qword ptr [7FFE8BC74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1B5F600CE18
+       mov       r8,7FFE8C6A3D38
+       call      qword ptr [7FFE8BC84210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1B6AB402278
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6893B0
+       mov       rdx,7FFE8C6A3D38
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2BD8
+       mov       rdx,7FFE8C7C2D08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        jne       near ptr M01_L14
 M01_L05:
        mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C68D740]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C6AC288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6893B0
+       mov       rdx,7FFE8C6A3D38
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2BD8
+       mov       rdx,7FFE8C7C2D08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE8BB30E38
+       mov       r11,7FFE8BB40E38
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        jne       short M01_L14
 M01_L11:
        mov       rax,[rbp-38]
        mov       rdi,[rax]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C68D740]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C6AC288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2B00
+       mov       rdx,7FFE8C7C2C30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       eax,1
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L16:
        mov       ecx,10
-       call      qword ptr [7FFE8BEF4F30]
+       call      qword ptr [7FFE8BF04F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE8BEF4F30]
+       call      qword ptr [7FFE8BF04F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB30E40
+       mov       r11,7FFE8BB40E40
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-38],0
        je        short M01_L22
        mov       rcx,[rbp-38]
        mov       rdi,[rcx]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        je        short M01_L22
-       mov       r11,7FFE8BB30E40
+       mov       r11,7FFE8BB40E40
        call      qword ptr [r11]
 M01_L22:
        nop
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 ; Total bytes of code 604
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFE8BC741F8]
+       call      qword ptr [7FFE8BC841F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,1B5F600CE18
+       mov       r8,1B07500CE18
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE8C58DB00]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE8C58FF48]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 M00_L01:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1B5F600CE10
+       mov       rdx,1B07500CE10
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE8C6893B0
+       mov       r8,7FFE8C68B3A8
        call      qword ptr [7FFE8BC74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1B5F600CE18
+       mov       rcx,1B07500CE18
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6893B0
+       mov       rdx,7FFE8C68B3A8
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2BD8
+       mov       rdx,7FFE8C7B88A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
 M01_L04:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
+       mov       rax,[rbp-38]
        jne       near ptr M01_L14
 M01_L05:
-       mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C68D740]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C68F738]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6893B0
+       mov       rdx,7FFE8C68B3A8
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2BD8
+       mov       rdx,7FFE8C7B88A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE8BB30E38
+       mov       r11,7FFE8BB30EE8
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
+       mov       rax,[rbp-38]
        jne       short M01_L14
 M01_L11:
-       mov       rax,[rbp-38]
        mov       rdi,[rax]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C68D740]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C68F738]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2B00
+       mov       rdx,7FFE8C7B87C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB30E40
+       mov       rcx,rax
+       mov       r11,7FFE8BB30EF0
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-38],0
        je        short M01_L22
        mov       rcx,[rbp-38]
        mov       rdi,[rcx]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        je        short M01_L22
-       mov       r11,7FFE8BB30E40
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE8BB30EF0
        call      qword ptr [r11]
 M01_L22:
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
-; Total bytes of code 604
+; Total bytes of code 607
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,1B5F600CE18
+       mov       r8,18EEAC0CE18
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE8C58DB00]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE8C6AE7F0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 M00_L01:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1B5F600CE10
+       mov       rdx,18EEAC0CE10
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE8C6893B0
-       call      qword ptr [7FFE8BC74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1B5F600CE18
+       mov       r8,7FFE8C729F08
+       call      qword ptr [7FFE8BCA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,18EEAC0CE18
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6893B0
+       mov       rdx,7FFE8C729F08
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2BD8
+       mov       rdx,7FFE8C806E18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        jne       near ptr M01_L14
 M01_L05:
        mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C68D740]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C72E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6893B0
+       mov       rdx,7FFE8C729F08
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2BD8
+       mov       rdx,7FFE8C806E18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE8BB30E38
+       mov       r11,7FFE8BB61388
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        jne       short M01_L14
 M01_L11:
        mov       rax,[rbp-38]
        mov       rdi,[rax]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C68D740]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C72E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2B00
+       mov       rdx,7FFE8C806D40
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       eax,1
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L16:
        mov       ecx,10
-       call      qword ptr [7FFE8BEF4F30]
+       call      qword ptr [7FFE8BF24F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE8BEF4F30]
+       call      qword ptr [7FFE8BF24F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB30E40
+       mov       r11,7FFE8BB61390
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-38],0
        je        short M01_L22
        mov       rcx,[rbp-38]
        mov       rdi,[rcx]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        je        short M01_L22
-       mov       r11,7FFE8BB30E40
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE8BB61390
        call      qword ptr [r11]
 M01_L22:
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
-; Total bytes of code 604
+; Total bytes of code 608
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFE8BC741F8]
+       call      qword ptr [7FFE8BCA41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,1B5F600CE18
+       mov       r8,1A29BC02278
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE8C58DB00]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE8C68E7C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 M00_L01:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1B5F600CE10
+       mov       rdx,1A29BC02270
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE8C6893B0
+       mov       r8,7FFE8C709950
        call      qword ptr [7FFE8BC74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1B5F600CE18
+       mov       rcx,1A29BC02278
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6893B0
+       mov       rdx,7FFE8C709950
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2BD8
+       mov       rdx,7FFE8C7CB358
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        jne       near ptr M01_L14
 M01_L05:
        mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C68D740]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C70DCE0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6893B0
+       mov       rdx,7FFE8C709950
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2BD8
+       mov       rdx,7FFE8C7CB358
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE8BB30E38
+       mov       r11,7FFE8BB31498
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        jne       short M01_L14
 M01_L11:
        mov       rax,[rbp-38]
        mov       rdi,[rax]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C68D740]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C70DCE0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2B00
+       mov       rdx,7FFE8C7CB280
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB30E40
+       mov       r11,7FFE8BB314A0
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-38],0
        je        short M01_L22
        mov       rcx,[rbp-38]
        mov       rdi,[rcx]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        je        short M01_L22
-       mov       r11,7FFE8BB30E40
+       mov       r11,7FFE8BB314A0
        call      qword ptr [r11]
 M01_L22:
        nop
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,1B5F600CE18
+       mov       r8,291E540CE18
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE8C58DB00]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE8C6BE9B8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 M00_L01:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1B5F600CE10
+       mov       rdx,291E540CE10
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE8C6893B0
-       call      qword ptr [7FFE8BC74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1B5F600CE18
+       mov       r8,7FFE8C739950
+       call      qword ptr [7FFE8BCA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,291E540CE18
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6893B0
+       mov       rdx,7FFE8C739950
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2BD8
+       mov       rdx,7FFE8C7FD880
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        jne       near ptr M01_L14
 M01_L05:
        mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C68D740]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C73DCE0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6893B0
+       mov       rdx,7FFE8C739950
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2BD8
+       mov       rdx,7FFE8C7FD880
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE8BB30E38
+       mov       r11,7FFE8BB614C0
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        jne       short M01_L14
 M01_L11:
        mov       rax,[rbp-38]
        mov       rdi,[rax]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C68D740]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C73DCE0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B2B00
+       mov       rdx,7FFE8C7FD7A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       eax,1
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L16:
        mov       ecx,10
-       call      qword ptr [7FFE8BEF4F30]
+       call      qword ptr [7FFE8BF24F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE8BEF4F30]
+       call      qword ptr [7FFE8BF24F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB30E40
+       mov       r11,7FFE8BB614C8
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-38],0
        je        short M01_L22
        mov       rcx,[rbp-38]
        mov       rdi,[rcx]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        je        short M01_L22
-       mov       r11,7FFE8BB30E40
+       mov       r11,7FFE8BB614C8
        call      qword ptr [r11]
 M01_L22:
        nop
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 ; Total bytes of code 604
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFE8BC741F8]
+       call      qword ptr [7FFE8BCA41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,1B6AB402278
+       mov       r8,1B07500CE18
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE8C59CCA8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE8C58FF48]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 M00_L01:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1B6AB402270
+       mov       rdx,1B07500CE10
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE8C6A3D38
-       call      qword ptr [7FFE8BC84210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1B6AB402278
+       mov       r8,7FFE8C68B3A8
+       call      qword ptr [7FFE8BC74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1B07500CE18
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6A3D38
+       mov       rdx,7FFE8C68B3A8
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7C2D08
+       mov       rdx,7FFE8C7B88A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
 M01_L04:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
+       mov       rax,[rbp-38]
        jne       near ptr M01_L14
 M01_L05:
-       mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C6AC288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C68F738]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6A3D38
+       mov       rdx,7FFE8C68B3A8
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7C2D08
+       mov       rdx,7FFE8C7B88A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE8BB40E38
+       mov       r11,7FFE8BB30EE8
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
+       mov       rax,[rbp-38]
        jne       short M01_L14
 M01_L11:
-       mov       rax,[rbp-38]
        mov       rdi,[rax]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C6AC288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C68F738]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7C2C30
+       mov       rdx,7FFE8C7B87C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       eax,1
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L16:
        mov       ecx,10
-       call      qword ptr [7FFE8BF04F30]
+       call      qword ptr [7FFE8BEF4F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE8BF04F30]
+       call      qword ptr [7FFE8BEF4F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB40E40
+       mov       rcx,rax
+       mov       r11,7FFE8BB30EF0
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-38],0
        je        short M01_L22
        mov       rcx,[rbp-38]
        mov       rdi,[rcx]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        je        short M01_L22
-       mov       r11,7FFE8BB40E40
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE8BB30EF0
        call      qword ptr [r11]
 M01_L22:
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
-; Total bytes of code 604
+; Total bytes of code 607
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFE8BC841F8]
+       call      qword ptr [7FFE8BC741F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,1B6AB402278
+       mov       r8,18EEAC0CE18
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE8C59CCA8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE8C6AE7F0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 M00_L01:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1B6AB402270
+       mov       rdx,18EEAC0CE10
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE8C6A3D38
-       call      qword ptr [7FFE8BC84210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1B6AB402278
+       mov       r8,7FFE8C729F08
+       call      qword ptr [7FFE8BCA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,18EEAC0CE18
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6A3D38
+       mov       rdx,7FFE8C729F08
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7C2D08
+       mov       rdx,7FFE8C806E18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        jne       near ptr M01_L14
 M01_L05:
        mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C6AC288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C72E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6A3D38
+       mov       rdx,7FFE8C729F08
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7C2D08
+       mov       rdx,7FFE8C806E18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE8BB40E38
+       mov       r11,7FFE8BB61388
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        jne       short M01_L14
 M01_L11:
        mov       rax,[rbp-38]
        mov       rdi,[rax]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C6AC288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C72E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7C2C30
+       mov       rdx,7FFE8C806D40
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       eax,1
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L16:
        mov       ecx,10
-       call      qword ptr [7FFE8BF04F30]
+       call      qword ptr [7FFE8BF24F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE8BF04F30]
+       call      qword ptr [7FFE8BF24F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB40E40
+       mov       r11,7FFE8BB61390
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-38],0
        je        short M01_L22
        mov       rcx,[rbp-38]
        mov       rdi,[rcx]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        je        short M01_L22
-       mov       r11,7FFE8BB40E40
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE8BB61390
        call      qword ptr [r11]
 M01_L22:
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
-; Total bytes of code 604
+; Total bytes of code 608
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFE8BC841F8]
+       call      qword ptr [7FFE8BCA41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,1B6AB402278
+       mov       r8,1A29BC02278
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE8C59CCA8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE8C68E7C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 M00_L01:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1B6AB402270
+       mov       rdx,1A29BC02270
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE8C6A3D38
-       call      qword ptr [7FFE8BC84210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1B6AB402278
+       mov       r8,7FFE8C709950
+       call      qword ptr [7FFE8BC74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1A29BC02278
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6A3D38
+       mov       rdx,7FFE8C709950
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7C2D08
+       mov       rdx,7FFE8C7CB358
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        jne       near ptr M01_L14
 M01_L05:
        mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C6AC288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C70DCE0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6A3D38
+       mov       rdx,7FFE8C709950
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7C2D08
+       mov       rdx,7FFE8C7CB358
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE8BB40E38
+       mov       r11,7FFE8BB31498
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        jne       short M01_L14
 M01_L11:
        mov       rax,[rbp-38]
        mov       rdi,[rax]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C6AC288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C70DCE0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7C2C30
+       mov       rdx,7FFE8C7CB280
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       eax,1
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L16:
        mov       ecx,10
-       call      qword ptr [7FFE8BF04F30]
+       call      qword ptr [7FFE8BEF4F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE8BF04F30]
+       call      qword ptr [7FFE8BEF4F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB40E40
+       mov       r11,7FFE8BB314A0
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-38],0
        je        short M01_L22
        mov       rcx,[rbp-38]
        mov       rdi,[rcx]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        je        short M01_L22
-       mov       r11,7FFE8BB40E40
+       mov       r11,7FFE8BB314A0
        call      qword ptr [r11]
 M01_L22:
        nop
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 ; Total bytes of code 604
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFE8BC841F8]
+       call      qword ptr [7FFE8BC741F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,1B6AB402278
+       mov       r8,291E540CE18
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE8C59CCA8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE8C6BE9B8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 M00_L01:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1B6AB402270
+       mov       rdx,291E540CE10
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE8C6A3D38
-       call      qword ptr [7FFE8BC84210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1B6AB402278
+       mov       r8,7FFE8C739950
+       call      qword ptr [7FFE8BCA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,291E540CE18
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6A3D38
+       mov       rdx,7FFE8C739950
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7C2D08
+       mov       rdx,7FFE8C7FD880
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        jne       near ptr M01_L14
 M01_L05:
        mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C6AC288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C73DCE0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C6A3D38
+       mov       rdx,7FFE8C739950
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7C2D08
+       mov       rdx,7FFE8C7FD880
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE8BB40E38
+       mov       r11,7FFE8BB614C0
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        jne       short M01_L14
 M01_L11:
        mov       rax,[rbp-38]
        mov       rdi,[rax]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C6AC288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C73DCE0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7C2C30
+       mov       rdx,7FFE8C7FD7A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       eax,1
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L16:
        mov       ecx,10
-       call      qword ptr [7FFE8BF04F30]
+       call      qword ptr [7FFE8BF24F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE8BF04F30]
+       call      qword ptr [7FFE8BF24F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB40E40
+       mov       r11,7FFE8BB614C8
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-38],0
        je        short M01_L22
        mov       rcx,[rbp-38]
        mov       rdi,[rcx]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        je        short M01_L22
-       mov       r11,7FFE8BB40E40
+       mov       r11,7FFE8BB614C8
        call      qword ptr [r11]
 M01_L22:
        nop
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 ; Total bytes of code 604
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFE8BC841F8]
+       call      qword ptr [7FFE8BCA41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,1B07500CE18
+       mov       r8,18EEAC0CE18
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE8C58FF48]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE8C6AE7F0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 M00_L01:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1B07500CE10
+       mov       rdx,18EEAC0CE10
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE8C68B3A8
-       call      qword ptr [7FFE8BC74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1B07500CE18
+       mov       r8,7FFE8C729F08
+       call      qword ptr [7FFE8BCA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,18EEAC0CE18
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C68B3A8
+       mov       rdx,7FFE8C729F08
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B88A0
+       mov       rdx,7FFE8C806E18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
 M01_L04:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
-       mov       rax,[rbp-38]
        jne       near ptr M01_L14
 M01_L05:
+       mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C68F738]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C72E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C68B3A8
+       mov       rdx,7FFE8C729F08
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B88A0
+       mov       rdx,7FFE8C806E18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE8BB30EE8
+       mov       r11,7FFE8BB61388
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
-       mov       rax,[rbp-38]
        jne       short M01_L14
 M01_L11:
+       mov       rax,[rbp-38]
        mov       rdi,[rax]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C68F738]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C72E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B87C8
+       mov       rdx,7FFE8C806D40
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       eax,1
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L16:
        mov       ecx,10
-       call      qword ptr [7FFE8BEF4F30]
+       call      qword ptr [7FFE8BF24F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE8BEF4F30]
+       call      qword ptr [7FFE8BF24F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFE8BB30EF0
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE8BB61390
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-38],0
        je        short M01_L22
        mov       rcx,[rbp-38]
        mov       rdi,[rcx]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        je        short M01_L22
        mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB30EF0
+       mov       r11,7FFE8BB61390
        call      qword ptr [r11]
 M01_L22:
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
-; Total bytes of code 607
+; Total bytes of code 608
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFE8BC741F8]
+       call      qword ptr [7FFE8BCA41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,1B07500CE18
+       mov       r8,1A29BC02278
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE8C58FF48]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE8C68E7C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 M00_L01:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1B07500CE10
+       mov       rdx,1A29BC02270
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE8C68B3A8
+       mov       r8,7FFE8C709950
        call      qword ptr [7FFE8BC74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1B07500CE18
+       mov       rcx,1A29BC02278
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C68B3A8
+       mov       rdx,7FFE8C709950
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B88A0
+       mov       rdx,7FFE8C7CB358
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
 M01_L04:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
-       mov       rax,[rbp-38]
        jne       near ptr M01_L14
 M01_L05:
+       mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C68F738]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C70DCE0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C68B3A8
+       mov       rdx,7FFE8C709950
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B88A0
+       mov       rdx,7FFE8C7CB358
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE8BB30EE8
+       mov       r11,7FFE8BB31498
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
-       mov       rax,[rbp-38]
        jne       short M01_L14
 M01_L11:
+       mov       rax,[rbp-38]
        mov       rdi,[rax]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C68F738]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C70DCE0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B87C8
+       mov       rdx,7FFE8C7CB280
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFE8BB30EF0
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE8BB314A0
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-38],0
        je        short M01_L22
        mov       rcx,[rbp-38]
        mov       rdi,[rcx]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        je        short M01_L22
-       mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB30EF0
+       mov       r11,7FFE8BB314A0
        call      qword ptr [r11]
 M01_L22:
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
-; Total bytes of code 607
+; Total bytes of code 604
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,1B07500CE18
+       mov       r8,291E540CE18
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE8C58FF48]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE8C6BE9B8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 M00_L01:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1B07500CE10
+       mov       rdx,291E540CE10
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE8C68B3A8
-       call      qword ptr [7FFE8BC74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1B07500CE18
+       mov       r8,7FFE8C739950
+       call      qword ptr [7FFE8BCA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,291E540CE18
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C68B3A8
+       mov       rdx,7FFE8C739950
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B88A0
+       mov       rdx,7FFE8C7FD880
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
 M01_L04:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
-       mov       rax,[rbp-38]
        jne       near ptr M01_L14
 M01_L05:
+       mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C68F738]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C73DCE0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C68B3A8
+       mov       rdx,7FFE8C739950
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B88A0
+       mov       rdx,7FFE8C7FD880
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE8BB30EE8
+       mov       r11,7FFE8BB614C0
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
-       mov       rax,[rbp-38]
        jne       short M01_L14
 M01_L11:
+       mov       rax,[rbp-38]
        mov       rdi,[rax]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C68F738]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C73DCE0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7B87C8
+       mov       rdx,7FFE8C7FD7A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       eax,1
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L16:
        mov       ecx,10
-       call      qword ptr [7FFE8BEF4F30]
+       call      qword ptr [7FFE8BF24F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE8BEF4F30]
+       call      qword ptr [7FFE8BF24F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFE8BB30EF0
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE8BB614C8
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-38],0
        je        short M01_L22
        mov       rcx,[rbp-38]
        mov       rdi,[rcx]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        je        short M01_L22
-       mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB30EF0
+       mov       r11,7FFE8BB614C8
        call      qword ptr [r11]
 M01_L22:
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
-; Total bytes of code 607
+; Total bytes of code 604
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFE8BC741F8]
+       call      qword ptr [7FFE8BCA41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,18EEAC0CE18
+       mov       r8,1A29BC02278
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE8C6AE7F0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE8C68E7C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 M00_L01:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,18EEAC0CE10
+       mov       rdx,1A29BC02270
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE8C729F08
-       call      qword ptr [7FFE8BCA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,18EEAC0CE18
+       mov       r8,7FFE8C709950
+       call      qword ptr [7FFE8BC74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1A29BC02278
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C729F08
+       mov       rdx,7FFE8C709950
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE8C806E18
+       mov       rdx,7FFE8C7CB358
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        jne       near ptr M01_L14
 M01_L05:
        mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C72E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C70DCE0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C729F08
+       mov       rdx,7FFE8C709950
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE8C806E18
+       mov       rdx,7FFE8C7CB358
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE8BB61388
+       mov       r11,7FFE8BB31498
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        jne       short M01_L14
 M01_L11:
        mov       rax,[rbp-38]
        mov       rdi,[rax]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C72E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C70DCE0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE8C806D40
+       mov       rdx,7FFE8C7CB280
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       eax,1
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L16:
        mov       ecx,10
-       call      qword ptr [7FFE8BF24F30]
+       call      qword ptr [7FFE8BEF4F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE8BF24F30]
+       call      qword ptr [7FFE8BEF4F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB61390
+       mov       r11,7FFE8BB314A0
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-38],0
        je        short M01_L22
        mov       rcx,[rbp-38]
        mov       rdi,[rcx]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        je        short M01_L22
-       mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB61390
+       mov       r11,7FFE8BB314A0
        call      qword ptr [r11]
 M01_L22:
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
-; Total bytes of code 608
+; Total bytes of code 604
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFE8BCA41F8]
+       call      qword ptr [7FFE8BC741F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,18EEAC0CE18
+       mov       r8,291E540CE18
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE8C6AE7F0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE8C6BE9B8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 M00_L01:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,18EEAC0CE10
+       mov       rdx,291E540CE10
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE8C729F08
+       mov       r8,7FFE8C739950
        call      qword ptr [7FFE8BCA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,18EEAC0CE18
+       mov       rcx,291E540CE18
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C729F08
+       mov       rdx,7FFE8C739950
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE8C806E18
+       mov       rdx,7FFE8C7FD880
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        jne       near ptr M01_L14
 M01_L05:
        mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C72E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C73DCE0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C729F08
+       mov       rdx,7FFE8C739950
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE8C806E18
+       mov       rdx,7FFE8C7FD880
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE8BB61388
+       mov       r11,7FFE8BB614C0
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        jne       short M01_L14
 M01_L11:
        mov       rax,[rbp-38]
        mov       rdi,[rax]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C72E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C73DCE0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE8C806D40
+       mov       rdx,7FFE8C7FD7A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB61390
+       mov       r11,7FFE8BB614C8
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-38],0
        je        short M01_L22
        mov       rcx,[rbp-38]
        mov       rdi,[rcx]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        je        short M01_L22
-       mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB61390
+       mov       r11,7FFE8BB614C8
        call      qword ptr [r11]
 M01_L22:
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
-; Total bytes of code 608
+; Total bytes of code 604
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,1A29BC02278
+       mov       r8,291E540CE18
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE8C68E7C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE8C6BE9B8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
 M00_L01:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1A29BC02270
+       mov       rdx,291E540CE10
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE8C709950
-       call      qword ptr [7FFE8BC74210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1A29BC02278
+       mov       r8,7FFE8C739950
+       call      qword ptr [7FFE8BCA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,291E540CE18
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C709950
+       mov       rdx,7FFE8C739950
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7CB358
+       mov       rdx,7FFE8C7FD880
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        jne       near ptr M01_L14
 M01_L05:
        mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C70DCE0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C73DCE0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,7FFE8C709950
+       mov       rdx,7FFE8C739950
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+30]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7CB358
+       mov       rdx,7FFE8C7FD880
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE8BB31498
+       mov       r11,7FFE8BB614C0
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        jne       short M01_L14
 M01_L11:
        mov       rax,[rbp-38]
        mov       rdi,[rax]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE8C70DCE0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE8C73DCE0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE8C7CB280
+       mov       rdx,7FFE8C7FD7A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       eax,1
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L16:
        mov       ecx,10
-       call      qword ptr [7FFE8BEF4F30]
+       call      qword ptr [7FFE8BF24F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE8BEF4F30]
+       call      qword ptr [7FFE8BF24F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE8BB314A0
+       mov       r11,7FFE8BB614C8
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
        cmp       qword ptr [rbp-38],0
        je        short M01_L22
        mov       rcx,[rbp-38]
        mov       rdi,[rcx]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rdi,r14
        je        short M01_L22
-       mov       r11,7FFE8BB314A0
+       mov       r11,7FFE8BB614C8
        call      qword ptr [r11]
 M01_L22:
        nop
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
 ; Total bytes of code 604
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFE8BC741F8]
+       call      qword ptr [7FFE8BCA41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff

```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
-       mov       rcx,28ABF401FE0
+       mov       rcx,21B47401FE0
        mov       rcx,[rcx]
-       call      qword ptr [7FFE8C69D2F0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C6CD7B8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
 ; Total bytes of code 76
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rcx,[rsi+8]
        cmp       qword ptr [rcx+10],0
        jne       near ptr M01_L11
 M01_L03:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69D830]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C6CDCF8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        jmp       short M01_L05
 M01_L04:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7E2458
+       mov       rdx,7FFE8C812910
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       short M01_L01
 M01_L05:
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L06:
        mov       ecx,48B
-       mov       rdx,7FFE8C6B3268
+       mov       rdx,7FFE8C6E5218
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFE8C69E628]
+       call      qword ptr [7FFE8C6CEAF0]
        int       3
 M01_L07:
        cmp       [rcx],ecx
-       call      qword ptr [7FFE8C69ED90]
+       call      qword ptr [7FFE8C6CF258]
        mov       rcx,rax
 M01_L08:
        mov       rdx,[rcx+10]
        mov       rax,[rsi+8]
        cmp       qword ptr [rax+10],0
        jne       short M01_L10
        mov       rax,rcx
        jmp       short M01_L05
 M01_L10:
        mov       rdx,[rcx+8]
        mov       edx,[rdx+20]
        mov       rax,[rsi+8]
        cmp       edx,[rax+20]
        jle       near ptr M01_L02
        mov       rdx,rsi
-       call      qword ptr [7FFE8C69D2F0]
+       call      qword ptr [7FFE8C6CD7B8]
        jmp       short M01_L05
 M01_L11:
        mov       rcx,[rdi+30]
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
        je        short M01_L12
        jmp       short M01_L13
 M01_L12:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7E2408
+       mov       rdx,7FFE8C8128C0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L13:
        lea       r8,[rsp+20]
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69EEE0]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFE8C6CF3A8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        test      eax,eax
        je        short M01_L14
        mov       rcx,[rsi+8]
        mov       ecx,[rcx+20]
        add       ecx,[rsp+20]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,ecx
-       vmulss    xmm0,xmm0,dword ptr [7FFE8C64F7A8]
+       vmulss    xmm0,xmm0,dword ptr [7FFE8C68D858]
        mov       rcx,[rsi+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
        vucomiss  xmm0,xmm1
        ja        near ptr M01_L03
 M01_L14:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69D7E8]
+       call      qword ptr [7FFE8C6CDCB0]
        jmp       near ptr M01_L05
 ; Total bytes of code 356
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
-       mov       rcx,28ABF401FE0
+       mov       rcx,1CFC8401FE8
        mov       rcx,[rcx]
-       call      qword ptr [7FFE8C69D2F0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C6BCBE8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
 ; Total bytes of code 76
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rcx,[rsi+8]
        cmp       qword ptr [rcx+10],0
        jne       near ptr M01_L11
 M01_L03:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69D830]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C6BD128]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        jmp       short M01_L05
 M01_L04:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7E2458
+       mov       rdx,7FFE8C7F3370
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       short M01_L01
 M01_L05:
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L06:
        mov       ecx,48B
-       mov       rdx,7FFE8C6B3268
+       mov       rdx,7FFE8C6C56D0
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFE8C69E628]
+       call      qword ptr [7FFE8C6BDF20]
        int       3
 M01_L07:
        cmp       [rcx],ecx
-       call      qword ptr [7FFE8C69ED90]
+       call      qword ptr [7FFE8C6BE688]
        mov       rcx,rax
 M01_L08:
        mov       rdx,[rcx+10]
        mov       rax,[rsi+8]
        cmp       qword ptr [rax+10],0
        jne       short M01_L10
        mov       rax,rcx
        jmp       short M01_L05
 M01_L10:
        mov       rdx,[rcx+8]
        mov       edx,[rdx+20]
        mov       rax,[rsi+8]
        cmp       edx,[rax+20]
        jle       near ptr M01_L02
        mov       rdx,rsi
-       call      qword ptr [7FFE8C69D2F0]
+       call      qword ptr [7FFE8C6BCBE8]
        jmp       short M01_L05
 M01_L11:
        mov       rcx,[rdi+30]
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
        je        short M01_L12
        jmp       short M01_L13
 M01_L12:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7E2408
+       mov       rdx,7FFE8C7F3320
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L13:
        lea       r8,[rsp+20]
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69EEE0]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFE8C6BE7D8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        test      eax,eax
        je        short M01_L14
        mov       rcx,[rsi+8]
        mov       ecx,[rcx+20]
        add       ecx,[rsp+20]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,ecx
-       vmulss    xmm0,xmm0,dword ptr [7FFE8C64F7A8]
+       vmulss    xmm0,xmm0,dword ptr [7FFE8C66F638]
        mov       rcx,[rsi+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
        vucomiss  xmm0,xmm1
        ja        near ptr M01_L03
 M01_L14:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69D7E8]
+       call      qword ptr [7FFE8C6BD0E0]
        jmp       near ptr M01_L05
 ; Total bytes of code 356
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
-       mov       rcx,28ABF401FE0
+       mov       rcx,23FAE801FE8
        mov       rcx,[rcx]
-       call      qword ptr [7FFE8C69D2F0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C69DFF8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
 ; Total bytes of code 76
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rcx,[rsi+8]
        cmp       qword ptr [rcx+10],0
        jne       near ptr M01_L11
 M01_L03:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69D830]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C69E538]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        jmp       short M01_L05
 M01_L04:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7E2458
+       mov       rdx,7FFE8C7E34A8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       short M01_L01
 M01_L05:
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L06:
        mov       ecx,48B
-       mov       rdx,7FFE8C6B3268
+       mov       rdx,7FFE8C6B56D0
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFE8C69E628]
+       call      qword ptr [7FFE8C69F330]
        int       3
 M01_L07:
        cmp       [rcx],ecx
-       call      qword ptr [7FFE8C69ED90]
+       call      qword ptr [7FFE8C69FA98]
        mov       rcx,rax
 M01_L08:
        mov       rdx,[rcx+10]
        mov       rax,[rsi+8]
        cmp       qword ptr [rax+10],0
        jne       short M01_L10
        mov       rax,rcx
        jmp       short M01_L05
 M01_L10:
        mov       rdx,[rcx+8]
        mov       edx,[rdx+20]
        mov       rax,[rsi+8]
        cmp       edx,[rax+20]
        jle       near ptr M01_L02
        mov       rdx,rsi
-       call      qword ptr [7FFE8C69D2F0]
+       call      qword ptr [7FFE8C69DFF8]
        jmp       short M01_L05
 M01_L11:
        mov       rcx,[rdi+30]
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
        je        short M01_L12
        jmp       short M01_L13
 M01_L12:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7E2408
+       mov       rdx,7FFE8C7E3458
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L13:
        lea       r8,[rsp+20]
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69EEE0]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFE8C69FBE8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        test      eax,eax
        je        short M01_L14
        mov       rcx,[rsi+8]
        mov       ecx,[rcx+20]
        add       ecx,[rsp+20]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,ecx
-       vmulss    xmm0,xmm0,dword ptr [7FFE8C64F7A8]
+       vmulss    xmm0,xmm0,dword ptr [7FFE8C65CEC8]
        mov       rcx,[rsi+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
        vucomiss  xmm0,xmm1
        ja        near ptr M01_L03
 M01_L14:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69D7E8]
+       call      qword ptr [7FFE8C69E4F0]
        jmp       near ptr M01_L05
 ; Total bytes of code 356
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
-       mov       rcx,28ABF401FE0
+       mov       rcx,19650001FE8
        mov       rcx,[rcx]
-       call      qword ptr [7FFE8C69D2F0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C6AF648]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
 ; Total bytes of code 76
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rcx,[rsi+8]
        cmp       qword ptr [rcx+10],0
        jne       near ptr M01_L11
 M01_L03:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69D830]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C6AFB88]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        jmp       short M01_L05
 M01_L04:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7E2458
+       mov       rdx,7FFE8C7FB068
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       short M01_L01
 M01_L05:
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L06:
        mov       ecx,48B
-       mov       rdx,7FFE8C6B3268
+       mov       rdx,7FFE8C6BCE78
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFE8C69E628]
+       call      qword ptr [7FFE8C6F4A38]
        int       3
 M01_L07:
        cmp       [rcx],ecx
-       call      qword ptr [7FFE8C69ED90]
+       call      qword ptr [7FFE8C6F51A0]
        mov       rcx,rax
 M01_L08:
        mov       rdx,[rcx+10]
        mov       rax,[rsi+8]
        cmp       qword ptr [rax+10],0
        jne       short M01_L10
        mov       rax,rcx
        jmp       short M01_L05
 M01_L10:
        mov       rdx,[rcx+8]
        mov       edx,[rdx+20]
        mov       rax,[rsi+8]
        cmp       edx,[rax+20]
        jle       near ptr M01_L02
        mov       rdx,rsi
-       call      qword ptr [7FFE8C69D2F0]
+       call      qword ptr [7FFE8C6AF648]
        jmp       short M01_L05
 M01_L11:
        mov       rcx,[rdi+30]
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
        je        short M01_L12
        jmp       short M01_L13
 M01_L12:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7E2408
+       mov       rdx,7FFE8C7FB018
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L13:
        lea       r8,[rsp+20]
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69EEE0]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFE8C6F52F0]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        test      eax,eax
        je        short M01_L14
        mov       rcx,[rsi+8]
        mov       ecx,[rcx+20]
        add       ecx,[rsp+20]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,ecx
-       vmulss    xmm0,xmm0,dword ptr [7FFE8C64F7A8]
+       vmulss    xmm0,xmm0,dword ptr [7FFE8C65D628]
        mov       rcx,[rsi+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
        vucomiss  xmm0,xmm1
        ja        near ptr M01_L03
 M01_L14:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69D7E8]
+       call      qword ptr [7FFE8C6AFB40]
        jmp       near ptr M01_L05
 ; Total bytes of code 356
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
-       mov       rcx,28ABF401FE0
+       mov       rcx,247BC401FF8
        mov       rcx,[rcx]
-       call      qword ptr [7FFE8C69D2F0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C70E598]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
 ; Total bytes of code 76
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rcx,[rsi+8]
        cmp       qword ptr [rcx+10],0
        jne       near ptr M01_L11
 M01_L03:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69D830]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C70EAD8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        jmp       short M01_L05
 M01_L04:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7E2458
+       mov       rdx,7FFE8C8064E8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       short M01_L01
 M01_L05:
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L06:
        mov       ecx,48B
-       mov       rdx,7FFE8C6B3268
+       mov       rdx,7FFE8C715DD0
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFE8C69E628]
+       call      qword ptr [7FFE8C70F8D0]
        int       3
 M01_L07:
        cmp       [rcx],ecx
-       call      qword ptr [7FFE8C69ED90]
+       call      qword ptr [7FFE8C734318]
        mov       rcx,rax
 M01_L08:
        mov       rdx,[rcx+10]
        mov       rax,[rsi+8]
        cmp       qword ptr [rax+10],0
        jne       short M01_L10
        mov       rax,rcx
        jmp       short M01_L05
 M01_L10:
        mov       rdx,[rcx+8]
        mov       edx,[rdx+20]
        mov       rax,[rsi+8]
        cmp       edx,[rax+20]
        jle       near ptr M01_L02
        mov       rdx,rsi
-       call      qword ptr [7FFE8C69D2F0]
+       call      qword ptr [7FFE8C70E598]
        jmp       short M01_L05
 M01_L11:
        mov       rcx,[rdi+30]
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
        je        short M01_L12
        jmp       short M01_L13
 M01_L12:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7E2408
+       mov       rdx,7FFE8C806498
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L13:
        lea       r8,[rsp+20]
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69EEE0]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFE8C734468]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        test      eax,eax
        je        short M01_L14
        mov       rcx,[rsi+8]
        mov       ecx,[rcx+20]
        add       ecx,[rsp+20]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,ecx
-       vmulss    xmm0,xmm0,dword ptr [7FFE8C64F7A8]
+       vmulss    xmm0,xmm0,dword ptr [7FFE8C620778]
        mov       rcx,[rsi+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
        vucomiss  xmm0,xmm1
        ja        near ptr M01_L03
 M01_L14:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69D7E8]
+       call      qword ptr [7FFE8C70EA90]
        jmp       near ptr M01_L05
 ; Total bytes of code 356
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
-       mov       rcx,28ABF401FE0
+       mov       rcx,1C6A0011868
        mov       rcx,[rcx]
-       call      qword ptr [7FFE8C69D2F0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C72E598]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
 ; Total bytes of code 76
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rcx,[rsi+8]
        cmp       qword ptr [rcx+10],0
        jne       near ptr M01_L11
 M01_L03:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69D830]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C72EAD8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        jmp       short M01_L05
 M01_L04:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7E2458
+       mov       rdx,7FFE8C80C828
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       short M01_L01
 M01_L05:
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L06:
        mov       ecx,48B
-       mov       rdx,7FFE8C6B3268
+       mov       rdx,7FFE8C7385E8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFE8C69E628]
+       call      qword ptr [7FFE8C72F8D0]
        int       3
 M01_L07:
        cmp       [rcx],ecx
-       call      qword ptr [7FFE8C69ED90]
+       call      qword ptr [7FFE8C754318]
        mov       rcx,rax
 M01_L08:
        mov       rdx,[rcx+10]
        mov       rax,[rsi+8]
        cmp       qword ptr [rax+10],0
        jne       short M01_L10
        mov       rax,rcx
        jmp       short M01_L05
 M01_L10:
        mov       rdx,[rcx+8]
        mov       edx,[rdx+20]
        mov       rax,[rsi+8]
        cmp       edx,[rax+20]
        jle       near ptr M01_L02
        mov       rdx,rsi
-       call      qword ptr [7FFE8C69D2F0]
+       call      qword ptr [7FFE8C72E598]
        jmp       short M01_L05
 M01_L11:
        mov       rcx,[rdi+30]
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
        je        short M01_L12
        jmp       short M01_L13
 M01_L12:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7E2408
+       mov       rdx,7FFE8C80C7D8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L13:
        lea       r8,[rsp+20]
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69EEE0]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFE8C754468]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        test      eax,eax
        je        short M01_L14
        mov       rcx,[rsi+8]
        mov       ecx,[rcx+20]
        add       ecx,[rsp+20]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,ecx
-       vmulss    xmm0,xmm0,dword ptr [7FFE8C64F7A8]
+       vmulss    xmm0,xmm0,dword ptr [7FFE8C5C6408]
        mov       rcx,[rsi+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
        vucomiss  xmm0,xmm1
        ja        near ptr M01_L03
 M01_L14:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69D7E8]
+       call      qword ptr [7FFE8C72EA90]
        jmp       near ptr M01_L05
 ; Total bytes of code 356
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
-       mov       rcx,28ABF401FE0
+       mov       rcx,2976EC02010
        mov       rcx,[rcx]
-       call      qword ptr [7FFE8C69D2F0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C71E598]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
 ; Total bytes of code 76
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
 M01_L00:
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        vzeroupper
        mov       [rsp+28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,[rsi]
        test      rbx,rbx
        je        short M01_L06
        mov       rcx,rbx
        cmp       [rcx],rdi
-       je        short M01_L08
+       je        near ptr M01_L08
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
-       mov       rax,[rcx+78]
+       mov       rax,[rcx+88]
        test      rax,rax
        je        short M01_L04
 M01_L01:
        mov       rcx,[rsi+8]
        cmp       qword ptr [rcx+10],0
        jne       near ptr M01_L11
 M01_L03:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69D830]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C71EAD8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        jmp       short M01_L05
 M01_L04:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7E2458
+       mov       rdx,7FFE8C7EF540
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       short M01_L01
 M01_L05:
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L06:
        mov       ecx,48B
-       mov       rdx,7FFE8C6B3268
+       mov       rdx,7FFE8C7285E8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFE8C69E628]
+       call      qword ptr [7FFE8C71F8D0]
        int       3
 M01_L07:
        cmp       [rcx],ecx
-       call      qword ptr [7FFE8C69ED90]
+       call      qword ptr [7FFE8C744318]
        mov       rcx,rax
 M01_L08:
        mov       rdx,[rcx+10]
        mov       rax,[rsi+8]
        cmp       qword ptr [rax+10],0
        jne       short M01_L10
        mov       rax,rcx
        jmp       short M01_L05
 M01_L10:
        mov       rdx,[rcx+8]
        mov       edx,[rdx+20]
        mov       rax,[rsi+8]
        cmp       edx,[rax+20]
        jle       near ptr M01_L02
        mov       rdx,rsi
-       call      qword ptr [7FFE8C69D2F0]
+       call      qword ptr [7FFE8C71E598]
        jmp       short M01_L05
 M01_L11:
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
-       mov       rcx,[rcx+70]
+       mov       rcx,[rcx+80]
        test      rcx,rcx
        je        short M01_L12
        jmp       short M01_L13
 M01_L12:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7E2408
+       mov       rdx,7FFE8C7EF4F0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L13:
        lea       r8,[rsp+20]
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69EEE0]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFE8C744468]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        test      eax,eax
        je        short M01_L14
        mov       rcx,[rsi+8]
        mov       ecx,[rcx+20]
        add       ecx,[rsp+20]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,ecx
-       vmulss    xmm0,xmm0,dword ptr [7FFE8C64F7A8]
+       vmulss    xmm0,xmm0,dword ptr [7FFE8C5A88F0]
        mov       rcx,[rsi+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
        vucomiss  xmm0,xmm1
        ja        near ptr M01_L03
 M01_L14:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69D7E8]
+       call      qword ptr [7FFE8C71EA90]
        jmp       near ptr M01_L05
-; Total bytes of code 356
+; Total bytes of code 366
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
-       mov       rcx,21B47401FE0
+       mov       rcx,1CFC8401FE8
        mov       rcx,[rcx]
-       call      qword ptr [7FFE8C6CD7B8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C6BCBE8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
 ; Total bytes of code 76
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rcx,[rsi+8]
        cmp       qword ptr [rcx+10],0
        jne       near ptr M01_L11
 M01_L03:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6CDCF8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C6BD128]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        jmp       short M01_L05
 M01_L04:
        mov       rcx,rdi
-       mov       rdx,7FFE8C812910
+       mov       rdx,7FFE8C7F3370
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       short M01_L01
 M01_L05:
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L06:
        mov       ecx,48B
-       mov       rdx,7FFE8C6E5218
+       mov       rdx,7FFE8C6C56D0
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFE8C6CEAF0]
+       call      qword ptr [7FFE8C6BDF20]
        int       3
 M01_L07:
        cmp       [rcx],ecx
-       call      qword ptr [7FFE8C6CF258]
+       call      qword ptr [7FFE8C6BE688]
        mov       rcx,rax
 M01_L08:
        mov       rdx,[rcx+10]
        mov       rax,[rsi+8]
        cmp       qword ptr [rax+10],0
        jne       short M01_L10
        mov       rax,rcx
        jmp       short M01_L05
 M01_L10:
        mov       rdx,[rcx+8]
        mov       edx,[rdx+20]
        mov       rax,[rsi+8]
        cmp       edx,[rax+20]
        jle       near ptr M01_L02
        mov       rdx,rsi
-       call      qword ptr [7FFE8C6CD7B8]
+       call      qword ptr [7FFE8C6BCBE8]
        jmp       short M01_L05
 M01_L11:
        mov       rcx,[rdi+30]
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
        je        short M01_L12
        jmp       short M01_L13
 M01_L12:
        mov       rcx,rdi
-       mov       rdx,7FFE8C8128C0
+       mov       rdx,7FFE8C7F3320
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L13:
        lea       r8,[rsp+20]
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6CF3A8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFE8C6BE7D8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        test      eax,eax
        je        short M01_L14
        mov       rcx,[rsi+8]
        mov       ecx,[rcx+20]
        add       ecx,[rsp+20]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,ecx
-       vmulss    xmm0,xmm0,dword ptr [7FFE8C68D858]
+       vmulss    xmm0,xmm0,dword ptr [7FFE8C66F638]
        mov       rcx,[rsi+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
        vucomiss  xmm0,xmm1
        ja        near ptr M01_L03
 M01_L14:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6CDCB0]
+       call      qword ptr [7FFE8C6BD0E0]
        jmp       near ptr M01_L05
 ; Total bytes of code 356
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
-       mov       rcx,21B47401FE0
+       mov       rcx,23FAE801FE8
        mov       rcx,[rcx]
-       call      qword ptr [7FFE8C6CD7B8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C69DFF8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
 ; Total bytes of code 76
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rcx,[rsi+8]
        cmp       qword ptr [rcx+10],0
        jne       near ptr M01_L11
 M01_L03:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6CDCF8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C69E538]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        jmp       short M01_L05
 M01_L04:
        mov       rcx,rdi
-       mov       rdx,7FFE8C812910
+       mov       rdx,7FFE8C7E34A8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       short M01_L01
 M01_L05:
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L06:
        mov       ecx,48B
-       mov       rdx,7FFE8C6E5218
+       mov       rdx,7FFE8C6B56D0
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFE8C6CEAF0]
+       call      qword ptr [7FFE8C69F330]
        int       3
 M01_L07:
        cmp       [rcx],ecx
-       call      qword ptr [7FFE8C6CF258]
+       call      qword ptr [7FFE8C69FA98]
        mov       rcx,rax
 M01_L08:
        mov       rdx,[rcx+10]
        mov       rax,[rsi+8]
        cmp       qword ptr [rax+10],0
        jne       short M01_L10
        mov       rax,rcx
        jmp       short M01_L05
 M01_L10:
        mov       rdx,[rcx+8]
        mov       edx,[rdx+20]
        mov       rax,[rsi+8]
        cmp       edx,[rax+20]
        jle       near ptr M01_L02
        mov       rdx,rsi
-       call      qword ptr [7FFE8C6CD7B8]
+       call      qword ptr [7FFE8C69DFF8]
        jmp       short M01_L05
 M01_L11:
        mov       rcx,[rdi+30]
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
        je        short M01_L12
        jmp       short M01_L13
 M01_L12:
        mov       rcx,rdi
-       mov       rdx,7FFE8C8128C0
+       mov       rdx,7FFE8C7E3458
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L13:
        lea       r8,[rsp+20]
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6CF3A8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFE8C69FBE8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        test      eax,eax
        je        short M01_L14
        mov       rcx,[rsi+8]
        mov       ecx,[rcx+20]
        add       ecx,[rsp+20]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,ecx
-       vmulss    xmm0,xmm0,dword ptr [7FFE8C68D858]
+       vmulss    xmm0,xmm0,dword ptr [7FFE8C65CEC8]
        mov       rcx,[rsi+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
        vucomiss  xmm0,xmm1
        ja        near ptr M01_L03
 M01_L14:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6CDCB0]
+       call      qword ptr [7FFE8C69E4F0]
        jmp       near ptr M01_L05
 ; Total bytes of code 356
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
-       mov       rcx,21B47401FE0
+       mov       rcx,19650001FE8
        mov       rcx,[rcx]
-       call      qword ptr [7FFE8C6CD7B8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C6AF648]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
 ; Total bytes of code 76
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rcx,[rsi+8]
        cmp       qword ptr [rcx+10],0
        jne       near ptr M01_L11
 M01_L03:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6CDCF8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C6AFB88]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        jmp       short M01_L05
 M01_L04:
        mov       rcx,rdi
-       mov       rdx,7FFE8C812910
+       mov       rdx,7FFE8C7FB068
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       short M01_L01
 M01_L05:
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L06:
        mov       ecx,48B
-       mov       rdx,7FFE8C6E5218
+       mov       rdx,7FFE8C6BCE78
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFE8C6CEAF0]
+       call      qword ptr [7FFE8C6F4A38]
        int       3
 M01_L07:
        cmp       [rcx],ecx
-       call      qword ptr [7FFE8C6CF258]
+       call      qword ptr [7FFE8C6F51A0]
        mov       rcx,rax
 M01_L08:
        mov       rdx,[rcx+10]
        mov       rax,[rsi+8]
        cmp       qword ptr [rax+10],0
        jne       short M01_L10
        mov       rax,rcx
        jmp       short M01_L05
 M01_L10:
        mov       rdx,[rcx+8]
        mov       edx,[rdx+20]
        mov       rax,[rsi+8]
        cmp       edx,[rax+20]
        jle       near ptr M01_L02
        mov       rdx,rsi
-       call      qword ptr [7FFE8C6CD7B8]
+       call      qword ptr [7FFE8C6AF648]
        jmp       short M01_L05
 M01_L11:
        mov       rcx,[rdi+30]
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
        je        short M01_L12
        jmp       short M01_L13
 M01_L12:
        mov       rcx,rdi
-       mov       rdx,7FFE8C8128C0
+       mov       rdx,7FFE8C7FB018
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L13:
        lea       r8,[rsp+20]
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6CF3A8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFE8C6F52F0]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        test      eax,eax
        je        short M01_L14
        mov       rcx,[rsi+8]
        mov       ecx,[rcx+20]
        add       ecx,[rsp+20]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,ecx
-       vmulss    xmm0,xmm0,dword ptr [7FFE8C68D858]
+       vmulss    xmm0,xmm0,dword ptr [7FFE8C65D628]
        mov       rcx,[rsi+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
        vucomiss  xmm0,xmm1
        ja        near ptr M01_L03
 M01_L14:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6CDCB0]
+       call      qword ptr [7FFE8C6AFB40]
        jmp       near ptr M01_L05
 ; Total bytes of code 356
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
-       mov       rcx,21B47401FE0
+       mov       rcx,247BC401FF8
        mov       rcx,[rcx]
-       call      qword ptr [7FFE8C6CD7B8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C70E598]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
 ; Total bytes of code 76
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rcx,[rsi+8]
        cmp       qword ptr [rcx+10],0
        jne       near ptr M01_L11
 M01_L03:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6CDCF8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C70EAD8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        jmp       short M01_L05
 M01_L04:
        mov       rcx,rdi
-       mov       rdx,7FFE8C812910
+       mov       rdx,7FFE8C8064E8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       short M01_L01
 M01_L05:
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L06:
        mov       ecx,48B
-       mov       rdx,7FFE8C6E5218
+       mov       rdx,7FFE8C715DD0
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFE8C6CEAF0]
+       call      qword ptr [7FFE8C70F8D0]
        int       3
 M01_L07:
        cmp       [rcx],ecx
-       call      qword ptr [7FFE8C6CF258]
+       call      qword ptr [7FFE8C734318]
        mov       rcx,rax
 M01_L08:
        mov       rdx,[rcx+10]
        mov       rax,[rsi+8]
        cmp       qword ptr [rax+10],0
        jne       short M01_L10
        mov       rax,rcx
        jmp       short M01_L05
 M01_L10:
        mov       rdx,[rcx+8]
        mov       edx,[rdx+20]
        mov       rax,[rsi+8]
        cmp       edx,[rax+20]
        jle       near ptr M01_L02
        mov       rdx,rsi
-       call      qword ptr [7FFE8C6CD7B8]
+       call      qword ptr [7FFE8C70E598]
        jmp       short M01_L05
 M01_L11:
        mov       rcx,[rdi+30]
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
        je        short M01_L12
        jmp       short M01_L13
 M01_L12:
        mov       rcx,rdi
-       mov       rdx,7FFE8C8128C0
+       mov       rdx,7FFE8C806498
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L13:
        lea       r8,[rsp+20]
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6CF3A8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFE8C734468]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        test      eax,eax
        je        short M01_L14
        mov       rcx,[rsi+8]
        mov       ecx,[rcx+20]
        add       ecx,[rsp+20]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,ecx
-       vmulss    xmm0,xmm0,dword ptr [7FFE8C68D858]
+       vmulss    xmm0,xmm0,dword ptr [7FFE8C620778]
        mov       rcx,[rsi+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
        vucomiss  xmm0,xmm1
        ja        near ptr M01_L03
 M01_L14:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6CDCB0]
+       call      qword ptr [7FFE8C70EA90]
        jmp       near ptr M01_L05
 ; Total bytes of code 356
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
-       mov       rcx,21B47401FE0
+       mov       rcx,1C6A0011868
        mov       rcx,[rcx]
-       call      qword ptr [7FFE8C6CD7B8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C72E598]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
 ; Total bytes of code 76
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rcx,[rsi+8]
        cmp       qword ptr [rcx+10],0
        jne       near ptr M01_L11
 M01_L03:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6CDCF8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C72EAD8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        jmp       short M01_L05
 M01_L04:
        mov       rcx,rdi
-       mov       rdx,7FFE8C812910
+       mov       rdx,7FFE8C80C828
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       short M01_L01
 M01_L05:
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L06:
        mov       ecx,48B
-       mov       rdx,7FFE8C6E5218
+       mov       rdx,7FFE8C7385E8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFE8C6CEAF0]
+       call      qword ptr [7FFE8C72F8D0]
        int       3
 M01_L07:
        cmp       [rcx],ecx
-       call      qword ptr [7FFE8C6CF258]
+       call      qword ptr [7FFE8C754318]
        mov       rcx,rax
 M01_L08:
        mov       rdx,[rcx+10]
        mov       rax,[rsi+8]
        cmp       qword ptr [rax+10],0
        jne       short M01_L10
        mov       rax,rcx
        jmp       short M01_L05
 M01_L10:
        mov       rdx,[rcx+8]
        mov       edx,[rdx+20]
        mov       rax,[rsi+8]
        cmp       edx,[rax+20]
        jle       near ptr M01_L02
        mov       rdx,rsi
-       call      qword ptr [7FFE8C6CD7B8]
+       call      qword ptr [7FFE8C72E598]
        jmp       short M01_L05
 M01_L11:
        mov       rcx,[rdi+30]
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
        je        short M01_L12
        jmp       short M01_L13
 M01_L12:
        mov       rcx,rdi
-       mov       rdx,7FFE8C8128C0
+       mov       rdx,7FFE8C80C7D8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L13:
        lea       r8,[rsp+20]
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6CF3A8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFE8C754468]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        test      eax,eax
        je        short M01_L14
        mov       rcx,[rsi+8]
        mov       ecx,[rcx+20]
        add       ecx,[rsp+20]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,ecx
-       vmulss    xmm0,xmm0,dword ptr [7FFE8C68D858]
+       vmulss    xmm0,xmm0,dword ptr [7FFE8C5C6408]
        mov       rcx,[rsi+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
        vucomiss  xmm0,xmm1
        ja        near ptr M01_L03
 M01_L14:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6CDCB0]
+       call      qword ptr [7FFE8C72EA90]
        jmp       near ptr M01_L05
 ; Total bytes of code 356
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
-       mov       rcx,21B47401FE0
+       mov       rcx,2976EC02010
        mov       rcx,[rcx]
-       call      qword ptr [7FFE8C6CD7B8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C71E598]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
 ; Total bytes of code 76
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
 M01_L00:
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        vzeroupper
        mov       [rsp+28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,[rsi]
        test      rbx,rbx
        je        short M01_L06
        mov       rcx,rbx
        cmp       [rcx],rdi
-       je        short M01_L08
+       je        near ptr M01_L08
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
-       mov       rax,[rcx+78]
+       mov       rax,[rcx+88]
        test      rax,rax
        je        short M01_L04
 M01_L01:
        mov       rcx,[rsi+8]
        cmp       qword ptr [rcx+10],0
        jne       near ptr M01_L11
 M01_L03:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6CDCF8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C71EAD8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        jmp       short M01_L05
 M01_L04:
        mov       rcx,rdi
-       mov       rdx,7FFE8C812910
+       mov       rdx,7FFE8C7EF540
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       short M01_L01
 M01_L05:
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L06:
        mov       ecx,48B
-       mov       rdx,7FFE8C6E5218
+       mov       rdx,7FFE8C7285E8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFE8C6CEAF0]
+       call      qword ptr [7FFE8C71F8D0]
        int       3
 M01_L07:
        cmp       [rcx],ecx
-       call      qword ptr [7FFE8C6CF258]
+       call      qword ptr [7FFE8C744318]
        mov       rcx,rax
 M01_L08:
        mov       rdx,[rcx+10]
        mov       rax,[rsi+8]
        cmp       qword ptr [rax+10],0
        jne       short M01_L10
        mov       rax,rcx
        jmp       short M01_L05
 M01_L10:
        mov       rdx,[rcx+8]
        mov       edx,[rdx+20]
        mov       rax,[rsi+8]
        cmp       edx,[rax+20]
        jle       near ptr M01_L02
        mov       rdx,rsi
-       call      qword ptr [7FFE8C6CD7B8]
+       call      qword ptr [7FFE8C71E598]
        jmp       short M01_L05
 M01_L11:
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
-       mov       rcx,[rcx+70]
+       mov       rcx,[rcx+80]
        test      rcx,rcx
        je        short M01_L12
        jmp       short M01_L13
 M01_L12:
        mov       rcx,rdi
-       mov       rdx,7FFE8C8128C0
+       mov       rdx,7FFE8C7EF4F0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L13:
        lea       r8,[rsp+20]
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6CF3A8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFE8C744468]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        test      eax,eax
        je        short M01_L14
        mov       rcx,[rsi+8]
        mov       ecx,[rcx+20]
        add       ecx,[rsp+20]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,ecx
-       vmulss    xmm0,xmm0,dword ptr [7FFE8C68D858]
+       vmulss    xmm0,xmm0,dword ptr [7FFE8C5A88F0]
        mov       rcx,[rsi+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
        vucomiss  xmm0,xmm1
        ja        near ptr M01_L03
 M01_L14:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6CDCB0]
+       call      qword ptr [7FFE8C71EA90]
        jmp       near ptr M01_L05
-; Total bytes of code 356
+; Total bytes of code 366
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
-       mov       rcx,1CFC8401FE8
+       mov       rcx,23FAE801FE8
        mov       rcx,[rcx]
-       call      qword ptr [7FFE8C6BCBE8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C69DFF8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
 ; Total bytes of code 76
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rcx,[rsi+8]
        cmp       qword ptr [rcx+10],0
        jne       near ptr M01_L11
 M01_L03:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6BD128]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C69E538]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        jmp       short M01_L05
 M01_L04:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7F3370
+       mov       rdx,7FFE8C7E34A8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       short M01_L01
 M01_L05:
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L06:
        mov       ecx,48B
-       mov       rdx,7FFE8C6C56D0
+       mov       rdx,7FFE8C6B56D0
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFE8C6BDF20]
+       call      qword ptr [7FFE8C69F330]
        int       3
 M01_L07:
        cmp       [rcx],ecx
-       call      qword ptr [7FFE8C6BE688]
+       call      qword ptr [7FFE8C69FA98]
        mov       rcx,rax
 M01_L08:
        mov       rdx,[rcx+10]
        mov       rax,[rsi+8]
        cmp       qword ptr [rax+10],0
        jne       short M01_L10
        mov       rax,rcx
        jmp       short M01_L05
 M01_L10:
        mov       rdx,[rcx+8]
        mov       edx,[rdx+20]
        mov       rax,[rsi+8]
        cmp       edx,[rax+20]
        jle       near ptr M01_L02
        mov       rdx,rsi
-       call      qword ptr [7FFE8C6BCBE8]
+       call      qword ptr [7FFE8C69DFF8]
        jmp       short M01_L05
 M01_L11:
        mov       rcx,[rdi+30]
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
        je        short M01_L12
        jmp       short M01_L13
 M01_L12:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7F3320
+       mov       rdx,7FFE8C7E3458
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L13:
        lea       r8,[rsp+20]
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6BE7D8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFE8C69FBE8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        test      eax,eax
        je        short M01_L14
        mov       rcx,[rsi+8]
        mov       ecx,[rcx+20]
        add       ecx,[rsp+20]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,ecx
-       vmulss    xmm0,xmm0,dword ptr [7FFE8C66F638]
+       vmulss    xmm0,xmm0,dword ptr [7FFE8C65CEC8]
        mov       rcx,[rsi+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
        vucomiss  xmm0,xmm1
        ja        near ptr M01_L03
 M01_L14:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6BD0E0]
+       call      qword ptr [7FFE8C69E4F0]
        jmp       near ptr M01_L05
 ; Total bytes of code 356
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
-       mov       rcx,1CFC8401FE8
+       mov       rcx,19650001FE8
        mov       rcx,[rcx]
-       call      qword ptr [7FFE8C6BCBE8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C6AF648]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
 ; Total bytes of code 76
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rcx,[rsi+8]
        cmp       qword ptr [rcx+10],0
        jne       near ptr M01_L11
 M01_L03:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6BD128]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C6AFB88]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        jmp       short M01_L05
 M01_L04:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7F3370
+       mov       rdx,7FFE8C7FB068
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       short M01_L01
 M01_L05:
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L06:
        mov       ecx,48B
-       mov       rdx,7FFE8C6C56D0
+       mov       rdx,7FFE8C6BCE78
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFE8C6BDF20]
+       call      qword ptr [7FFE8C6F4A38]
        int       3
 M01_L07:
        cmp       [rcx],ecx
-       call      qword ptr [7FFE8C6BE688]
+       call      qword ptr [7FFE8C6F51A0]
        mov       rcx,rax
 M01_L08:
        mov       rdx,[rcx+10]
        mov       rax,[rsi+8]
        cmp       qword ptr [rax+10],0
        jne       short M01_L10
        mov       rax,rcx
        jmp       short M01_L05
 M01_L10:
        mov       rdx,[rcx+8]
        mov       edx,[rdx+20]
        mov       rax,[rsi+8]
        cmp       edx,[rax+20]
        jle       near ptr M01_L02
        mov       rdx,rsi
-       call      qword ptr [7FFE8C6BCBE8]
+       call      qword ptr [7FFE8C6AF648]
        jmp       short M01_L05
 M01_L11:
        mov       rcx,[rdi+30]
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
        je        short M01_L12
        jmp       short M01_L13
 M01_L12:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7F3320
+       mov       rdx,7FFE8C7FB018
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L13:
        lea       r8,[rsp+20]
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6BE7D8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFE8C6F52F0]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        test      eax,eax
        je        short M01_L14
        mov       rcx,[rsi+8]
        mov       ecx,[rcx+20]
        add       ecx,[rsp+20]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,ecx
-       vmulss    xmm0,xmm0,dword ptr [7FFE8C66F638]
+       vmulss    xmm0,xmm0,dword ptr [7FFE8C65D628]
        mov       rcx,[rsi+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
        vucomiss  xmm0,xmm1
        ja        near ptr M01_L03
 M01_L14:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6BD0E0]
+       call      qword ptr [7FFE8C6AFB40]
        jmp       near ptr M01_L05
 ; Total bytes of code 356
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
-       mov       rcx,1CFC8401FE8
+       mov       rcx,247BC401FF8
        mov       rcx,[rcx]
-       call      qword ptr [7FFE8C6BCBE8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C70E598]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
 ; Total bytes of code 76
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rcx,[rsi+8]
        cmp       qword ptr [rcx+10],0
        jne       near ptr M01_L11
 M01_L03:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6BD128]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C70EAD8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        jmp       short M01_L05
 M01_L04:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7F3370
+       mov       rdx,7FFE8C8064E8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       short M01_L01
 M01_L05:
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L06:
        mov       ecx,48B
-       mov       rdx,7FFE8C6C56D0
+       mov       rdx,7FFE8C715DD0
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFE8C6BDF20]
+       call      qword ptr [7FFE8C70F8D0]
        int       3
 M01_L07:
        cmp       [rcx],ecx
-       call      qword ptr [7FFE8C6BE688]
+       call      qword ptr [7FFE8C734318]
        mov       rcx,rax
 M01_L08:
        mov       rdx,[rcx+10]
        mov       rax,[rsi+8]
        cmp       qword ptr [rax+10],0
        jne       short M01_L10
        mov       rax,rcx
        jmp       short M01_L05
 M01_L10:
        mov       rdx,[rcx+8]
        mov       edx,[rdx+20]
        mov       rax,[rsi+8]
        cmp       edx,[rax+20]
        jle       near ptr M01_L02
        mov       rdx,rsi
-       call      qword ptr [7FFE8C6BCBE8]
+       call      qword ptr [7FFE8C70E598]
        jmp       short M01_L05
 M01_L11:
        mov       rcx,[rdi+30]
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
        je        short M01_L12
        jmp       short M01_L13
 M01_L12:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7F3320
+       mov       rdx,7FFE8C806498
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L13:
        lea       r8,[rsp+20]
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6BE7D8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFE8C734468]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        test      eax,eax
        je        short M01_L14
        mov       rcx,[rsi+8]
        mov       ecx,[rcx+20]
        add       ecx,[rsp+20]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,ecx
-       vmulss    xmm0,xmm0,dword ptr [7FFE8C66F638]
+       vmulss    xmm0,xmm0,dword ptr [7FFE8C620778]
        mov       rcx,[rsi+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
        vucomiss  xmm0,xmm1
        ja        near ptr M01_L03
 M01_L14:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6BD0E0]
+       call      qword ptr [7FFE8C70EA90]
        jmp       near ptr M01_L05
 ; Total bytes of code 356
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
-       mov       rcx,1CFC8401FE8
+       mov       rcx,1C6A0011868
        mov       rcx,[rcx]
-       call      qword ptr [7FFE8C6BCBE8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C72E598]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
 ; Total bytes of code 76
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rcx,[rsi+8]
        cmp       qword ptr [rcx+10],0
        jne       near ptr M01_L11
 M01_L03:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6BD128]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C72EAD8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        jmp       short M01_L05
 M01_L04:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7F3370
+       mov       rdx,7FFE8C80C828
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       short M01_L01
 M01_L05:
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L06:
        mov       ecx,48B
-       mov       rdx,7FFE8C6C56D0
+       mov       rdx,7FFE8C7385E8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFE8C6BDF20]
+       call      qword ptr [7FFE8C72F8D0]
        int       3
 M01_L07:
        cmp       [rcx],ecx
-       call      qword ptr [7FFE8C6BE688]
+       call      qword ptr [7FFE8C754318]
        mov       rcx,rax
 M01_L08:
        mov       rdx,[rcx+10]
        mov       rax,[rsi+8]
        cmp       qword ptr [rax+10],0
        jne       short M01_L10
        mov       rax,rcx
        jmp       short M01_L05
 M01_L10:
        mov       rdx,[rcx+8]
        mov       edx,[rdx+20]
        mov       rax,[rsi+8]
        cmp       edx,[rax+20]
        jle       near ptr M01_L02
        mov       rdx,rsi
-       call      qword ptr [7FFE8C6BCBE8]
+       call      qword ptr [7FFE8C72E598]
        jmp       short M01_L05
 M01_L11:
        mov       rcx,[rdi+30]
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
        je        short M01_L12
        jmp       short M01_L13
 M01_L12:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7F3320
+       mov       rdx,7FFE8C80C7D8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L13:
        lea       r8,[rsp+20]
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6BE7D8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFE8C754468]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        test      eax,eax
        je        short M01_L14
        mov       rcx,[rsi+8]
        mov       ecx,[rcx+20]
        add       ecx,[rsp+20]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,ecx
-       vmulss    xmm0,xmm0,dword ptr [7FFE8C66F638]
+       vmulss    xmm0,xmm0,dword ptr [7FFE8C5C6408]
        mov       rcx,[rsi+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
        vucomiss  xmm0,xmm1
        ja        near ptr M01_L03
 M01_L14:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6BD0E0]
+       call      qword ptr [7FFE8C72EA90]
        jmp       near ptr M01_L05
 ; Total bytes of code 356
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
-       mov       rcx,1CFC8401FE8
+       mov       rcx,2976EC02010
        mov       rcx,[rcx]
-       call      qword ptr [7FFE8C6BCBE8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C71E598]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
 ; Total bytes of code 76
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
 M01_L00:
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        vzeroupper
        mov       [rsp+28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,[rsi]
        test      rbx,rbx
        je        short M01_L06
        mov       rcx,rbx
        cmp       [rcx],rdi
-       je        short M01_L08
+       je        near ptr M01_L08
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
-       mov       rax,[rcx+78]
+       mov       rax,[rcx+88]
        test      rax,rax
        je        short M01_L04
 M01_L01:
        mov       rcx,[rsi+8]
        cmp       qword ptr [rcx+10],0
        jne       near ptr M01_L11
 M01_L03:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6BD128]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C71EAD8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        jmp       short M01_L05
 M01_L04:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7F3370
+       mov       rdx,7FFE8C7EF540
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       short M01_L01
 M01_L05:
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L06:
        mov       ecx,48B
-       mov       rdx,7FFE8C6C56D0
+       mov       rdx,7FFE8C7285E8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFE8C6BDF20]
+       call      qword ptr [7FFE8C71F8D0]
        int       3
 M01_L07:
        cmp       [rcx],ecx
-       call      qword ptr [7FFE8C6BE688]
+       call      qword ptr [7FFE8C744318]
        mov       rcx,rax
 M01_L08:
        mov       rdx,[rcx+10]
        mov       rax,[rsi+8]
        cmp       qword ptr [rax+10],0
        jne       short M01_L10
        mov       rax,rcx
        jmp       short M01_L05
 M01_L10:
        mov       rdx,[rcx+8]
        mov       edx,[rdx+20]
        mov       rax,[rsi+8]
        cmp       edx,[rax+20]
        jle       near ptr M01_L02
        mov       rdx,rsi
-       call      qword ptr [7FFE8C6BCBE8]
+       call      qword ptr [7FFE8C71E598]
        jmp       short M01_L05
 M01_L11:
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
-       mov       rcx,[rcx+70]
+       mov       rcx,[rcx+80]
        test      rcx,rcx
        je        short M01_L12
        jmp       short M01_L13
 M01_L12:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7F3320
+       mov       rdx,7FFE8C7EF4F0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L13:
        lea       r8,[rsp+20]
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6BE7D8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFE8C744468]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        test      eax,eax
        je        short M01_L14
        mov       rcx,[rsi+8]
        mov       ecx,[rcx+20]
        add       ecx,[rsp+20]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,ecx
-       vmulss    xmm0,xmm0,dword ptr [7FFE8C66F638]
+       vmulss    xmm0,xmm0,dword ptr [7FFE8C5A88F0]
        mov       rcx,[rsi+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
        vucomiss  xmm0,xmm1
        ja        near ptr M01_L03
 M01_L14:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6BD0E0]
+       call      qword ptr [7FFE8C71EA90]
        jmp       near ptr M01_L05
-; Total bytes of code 356
+; Total bytes of code 366
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
-       mov       rcx,23FAE801FE8
+       mov       rcx,19650001FE8
        mov       rcx,[rcx]
-       call      qword ptr [7FFE8C69DFF8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C6AF648]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
 ; Total bytes of code 76
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rcx,[rsi+8]
        cmp       qword ptr [rcx+10],0
        jne       near ptr M01_L11
 M01_L03:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69E538]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C6AFB88]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        jmp       short M01_L05
 M01_L04:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7E34A8
+       mov       rdx,7FFE8C7FB068
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       short M01_L01
 M01_L05:
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L06:
        mov       ecx,48B
-       mov       rdx,7FFE8C6B56D0
+       mov       rdx,7FFE8C6BCE78
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFE8C69F330]
+       call      qword ptr [7FFE8C6F4A38]
        int       3
 M01_L07:
        cmp       [rcx],ecx
-       call      qword ptr [7FFE8C69FA98]
+       call      qword ptr [7FFE8C6F51A0]
        mov       rcx,rax
 M01_L08:
        mov       rdx,[rcx+10]
        mov       rax,[rsi+8]
        cmp       qword ptr [rax+10],0
        jne       short M01_L10
        mov       rax,rcx
        jmp       short M01_L05
 M01_L10:
        mov       rdx,[rcx+8]
        mov       edx,[rdx+20]
        mov       rax,[rsi+8]
        cmp       edx,[rax+20]
        jle       near ptr M01_L02
        mov       rdx,rsi
-       call      qword ptr [7FFE8C69DFF8]
+       call      qword ptr [7FFE8C6AF648]
        jmp       short M01_L05
 M01_L11:
        mov       rcx,[rdi+30]
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
        je        short M01_L12
        jmp       short M01_L13
 M01_L12:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7E3458
+       mov       rdx,7FFE8C7FB018
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L13:
        lea       r8,[rsp+20]
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69FBE8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFE8C6F52F0]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        test      eax,eax
        je        short M01_L14
        mov       rcx,[rsi+8]
        mov       ecx,[rcx+20]
        add       ecx,[rsp+20]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,ecx
-       vmulss    xmm0,xmm0,dword ptr [7FFE8C65CEC8]
+       vmulss    xmm0,xmm0,dword ptr [7FFE8C65D628]
        mov       rcx,[rsi+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
        vucomiss  xmm0,xmm1
        ja        near ptr M01_L03
 M01_L14:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69E4F0]
+       call      qword ptr [7FFE8C6AFB40]
        jmp       near ptr M01_L05
 ; Total bytes of code 356
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
-       mov       rcx,23FAE801FE8
+       mov       rcx,247BC401FF8
        mov       rcx,[rcx]
-       call      qword ptr [7FFE8C69DFF8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C70E598]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
 ; Total bytes of code 76
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rcx,[rsi+8]
        cmp       qword ptr [rcx+10],0
        jne       near ptr M01_L11
 M01_L03:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69E538]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C70EAD8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        jmp       short M01_L05
 M01_L04:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7E34A8
+       mov       rdx,7FFE8C8064E8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       short M01_L01
 M01_L05:
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L06:
        mov       ecx,48B
-       mov       rdx,7FFE8C6B56D0
+       mov       rdx,7FFE8C715DD0
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFE8C69F330]
+       call      qword ptr [7FFE8C70F8D0]
        int       3
 M01_L07:
        cmp       [rcx],ecx
-       call      qword ptr [7FFE8C69FA98]
+       call      qword ptr [7FFE8C734318]
        mov       rcx,rax
 M01_L08:
        mov       rdx,[rcx+10]
        mov       rax,[rsi+8]
        cmp       qword ptr [rax+10],0
        jne       short M01_L10
        mov       rax,rcx
        jmp       short M01_L05
 M01_L10:
        mov       rdx,[rcx+8]
        mov       edx,[rdx+20]
        mov       rax,[rsi+8]
        cmp       edx,[rax+20]
        jle       near ptr M01_L02
        mov       rdx,rsi
-       call      qword ptr [7FFE8C69DFF8]
+       call      qword ptr [7FFE8C70E598]
        jmp       short M01_L05
 M01_L11:
        mov       rcx,[rdi+30]
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
        je        short M01_L12
        jmp       short M01_L13
 M01_L12:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7E3458
+       mov       rdx,7FFE8C806498
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L13:
        lea       r8,[rsp+20]
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69FBE8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFE8C734468]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        test      eax,eax
        je        short M01_L14
        mov       rcx,[rsi+8]
        mov       ecx,[rcx+20]
        add       ecx,[rsp+20]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,ecx
-       vmulss    xmm0,xmm0,dword ptr [7FFE8C65CEC8]
+       vmulss    xmm0,xmm0,dword ptr [7FFE8C620778]
        mov       rcx,[rsi+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
        vucomiss  xmm0,xmm1
        ja        near ptr M01_L03
 M01_L14:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69E4F0]
+       call      qword ptr [7FFE8C70EA90]
        jmp       near ptr M01_L05
 ; Total bytes of code 356
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
-       mov       rcx,23FAE801FE8
+       mov       rcx,1C6A0011868
        mov       rcx,[rcx]
-       call      qword ptr [7FFE8C69DFF8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C72E598]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
 ; Total bytes of code 76
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rcx,[rsi+8]
        cmp       qword ptr [rcx+10],0
        jne       near ptr M01_L11
 M01_L03:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69E538]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C72EAD8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        jmp       short M01_L05
 M01_L04:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7E34A8
+       mov       rdx,7FFE8C80C828
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       short M01_L01
 M01_L05:
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L06:
        mov       ecx,48B
-       mov       rdx,7FFE8C6B56D0
+       mov       rdx,7FFE8C7385E8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFE8C69F330]
+       call      qword ptr [7FFE8C72F8D0]
        int       3
 M01_L07:
        cmp       [rcx],ecx
-       call      qword ptr [7FFE8C69FA98]
+       call      qword ptr [7FFE8C754318]
        mov       rcx,rax
 M01_L08:
        mov       rdx,[rcx+10]
        mov       rax,[rsi+8]
        cmp       qword ptr [rax+10],0
        jne       short M01_L10
        mov       rax,rcx
        jmp       short M01_L05
 M01_L10:
        mov       rdx,[rcx+8]
        mov       edx,[rdx+20]
        mov       rax,[rsi+8]
        cmp       edx,[rax+20]
        jle       near ptr M01_L02
        mov       rdx,rsi
-       call      qword ptr [7FFE8C69DFF8]
+       call      qword ptr [7FFE8C72E598]
        jmp       short M01_L05
 M01_L11:
        mov       rcx,[rdi+30]
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
        je        short M01_L12
        jmp       short M01_L13
 M01_L12:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7E3458
+       mov       rdx,7FFE8C80C7D8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L13:
        lea       r8,[rsp+20]
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69FBE8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFE8C754468]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        test      eax,eax
        je        short M01_L14
        mov       rcx,[rsi+8]
        mov       ecx,[rcx+20]
        add       ecx,[rsp+20]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,ecx
-       vmulss    xmm0,xmm0,dword ptr [7FFE8C65CEC8]
+       vmulss    xmm0,xmm0,dword ptr [7FFE8C5C6408]
        mov       rcx,[rsi+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
        vucomiss  xmm0,xmm1
        ja        near ptr M01_L03
 M01_L14:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69E4F0]
+       call      qword ptr [7FFE8C72EA90]
        jmp       near ptr M01_L05
 ; Total bytes of code 356
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
-       mov       rcx,23FAE801FE8
+       mov       rcx,2976EC02010
        mov       rcx,[rcx]
-       call      qword ptr [7FFE8C69DFF8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C71E598]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
 ; Total bytes of code 76
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
 M01_L00:
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        vzeroupper
        mov       [rsp+28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,[rsi]
        test      rbx,rbx
        je        short M01_L06
        mov       rcx,rbx
        cmp       [rcx],rdi
-       je        short M01_L08
+       je        near ptr M01_L08
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
-       mov       rax,[rcx+78]
+       mov       rax,[rcx+88]
        test      rax,rax
        je        short M01_L04
 M01_L01:
        mov       rcx,[rsi+8]
        cmp       qword ptr [rcx+10],0
        jne       near ptr M01_L11
 M01_L03:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69E538]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C71EAD8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        jmp       short M01_L05
 M01_L04:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7E34A8
+       mov       rdx,7FFE8C7EF540
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       short M01_L01
 M01_L05:
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L06:
        mov       ecx,48B
-       mov       rdx,7FFE8C6B56D0
+       mov       rdx,7FFE8C7285E8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFE8C69F330]
+       call      qword ptr [7FFE8C71F8D0]
        int       3
 M01_L07:
        cmp       [rcx],ecx
-       call      qword ptr [7FFE8C69FA98]
+       call      qword ptr [7FFE8C744318]
        mov       rcx,rax
 M01_L08:
        mov       rdx,[rcx+10]
        mov       rax,[rsi+8]
        cmp       qword ptr [rax+10],0
        jne       short M01_L10
        mov       rax,rcx
        jmp       short M01_L05
 M01_L10:
        mov       rdx,[rcx+8]
        mov       edx,[rdx+20]
        mov       rax,[rsi+8]
        cmp       edx,[rax+20]
        jle       near ptr M01_L02
        mov       rdx,rsi
-       call      qword ptr [7FFE8C69DFF8]
+       call      qword ptr [7FFE8C71E598]
        jmp       short M01_L05
 M01_L11:
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
-       mov       rcx,[rcx+70]
+       mov       rcx,[rcx+80]
        test      rcx,rcx
        je        short M01_L12
        jmp       short M01_L13
 M01_L12:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7E3458
+       mov       rdx,7FFE8C7EF4F0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L13:
        lea       r8,[rsp+20]
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69FBE8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFE8C744468]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        test      eax,eax
        je        short M01_L14
        mov       rcx,[rsi+8]
        mov       ecx,[rcx+20]
        add       ecx,[rsp+20]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,ecx
-       vmulss    xmm0,xmm0,dword ptr [7FFE8C65CEC8]
+       vmulss    xmm0,xmm0,dword ptr [7FFE8C5A88F0]
        mov       rcx,[rsi+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
        vucomiss  xmm0,xmm1
        ja        near ptr M01_L03
 M01_L14:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C69E4F0]
+       call      qword ptr [7FFE8C71EA90]
        jmp       near ptr M01_L05
-; Total bytes of code 356
+; Total bytes of code 366
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
-       mov       rcx,19650001FE8
+       mov       rcx,247BC401FF8
        mov       rcx,[rcx]
-       call      qword ptr [7FFE8C6AF648]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C70E598]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
 ; Total bytes of code 76
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rcx,[rsi+8]
        cmp       qword ptr [rcx+10],0
        jne       near ptr M01_L11
 M01_L03:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6AFB88]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C70EAD8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        jmp       short M01_L05
 M01_L04:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7FB068
+       mov       rdx,7FFE8C8064E8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       short M01_L01
 M01_L05:
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L06:
        mov       ecx,48B
-       mov       rdx,7FFE8C6BCE78
+       mov       rdx,7FFE8C715DD0
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFE8C6F4A38]
+       call      qword ptr [7FFE8C70F8D0]
        int       3
 M01_L07:
        cmp       [rcx],ecx
-       call      qword ptr [7FFE8C6F51A0]
+       call      qword ptr [7FFE8C734318]
        mov       rcx,rax
 M01_L08:
        mov       rdx,[rcx+10]
        mov       rax,[rsi+8]
        cmp       qword ptr [rax+10],0
        jne       short M01_L10
        mov       rax,rcx
        jmp       short M01_L05
 M01_L10:
        mov       rdx,[rcx+8]
        mov       edx,[rdx+20]
        mov       rax,[rsi+8]
        cmp       edx,[rax+20]
        jle       near ptr M01_L02
        mov       rdx,rsi
-       call      qword ptr [7FFE8C6AF648]
+       call      qword ptr [7FFE8C70E598]
        jmp       short M01_L05
 M01_L11:
        mov       rcx,[rdi+30]
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
        je        short M01_L12
        jmp       short M01_L13
 M01_L12:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7FB018
+       mov       rdx,7FFE8C806498
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L13:
        lea       r8,[rsp+20]
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6F52F0]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFE8C734468]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        test      eax,eax
        je        short M01_L14
        mov       rcx,[rsi+8]
        mov       ecx,[rcx+20]
        add       ecx,[rsp+20]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,ecx
-       vmulss    xmm0,xmm0,dword ptr [7FFE8C65D628]
+       vmulss    xmm0,xmm0,dword ptr [7FFE8C620778]
        mov       rcx,[rsi+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
        vucomiss  xmm0,xmm1
        ja        near ptr M01_L03
 M01_L14:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6AFB40]
+       call      qword ptr [7FFE8C70EA90]
        jmp       near ptr M01_L05
 ; Total bytes of code 356
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
-       mov       rcx,19650001FE8
+       mov       rcx,1C6A0011868
        mov       rcx,[rcx]
-       call      qword ptr [7FFE8C6AF648]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C72E598]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
 ; Total bytes of code 76
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rcx,[rsi+8]
        cmp       qword ptr [rcx+10],0
        jne       near ptr M01_L11
 M01_L03:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6AFB88]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C72EAD8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        jmp       short M01_L05
 M01_L04:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7FB068
+       mov       rdx,7FFE8C80C828
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       short M01_L01
 M01_L05:
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L06:
        mov       ecx,48B
-       mov       rdx,7FFE8C6BCE78
+       mov       rdx,7FFE8C7385E8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFE8C6F4A38]
+       call      qword ptr [7FFE8C72F8D0]
        int       3
 M01_L07:
        cmp       [rcx],ecx
-       call      qword ptr [7FFE8C6F51A0]
+       call      qword ptr [7FFE8C754318]
        mov       rcx,rax
 M01_L08:
        mov       rdx,[rcx+10]
        mov       rax,[rsi+8]
        cmp       qword ptr [rax+10],0
        jne       short M01_L10
        mov       rax,rcx
        jmp       short M01_L05
 M01_L10:
        mov       rdx,[rcx+8]
        mov       edx,[rdx+20]
        mov       rax,[rsi+8]
        cmp       edx,[rax+20]
        jle       near ptr M01_L02
        mov       rdx,rsi
-       call      qword ptr [7FFE8C6AF648]
+       call      qword ptr [7FFE8C72E598]
        jmp       short M01_L05
 M01_L11:
        mov       rcx,[rdi+30]
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
        je        short M01_L12
        jmp       short M01_L13
 M01_L12:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7FB018
+       mov       rdx,7FFE8C80C7D8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L13:
        lea       r8,[rsp+20]
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6F52F0]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFE8C754468]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        test      eax,eax
        je        short M01_L14
        mov       rcx,[rsi+8]
        mov       ecx,[rcx+20]
        add       ecx,[rsp+20]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,ecx
-       vmulss    xmm0,xmm0,dword ptr [7FFE8C65D628]
+       vmulss    xmm0,xmm0,dword ptr [7FFE8C5C6408]
        mov       rcx,[rsi+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
        vucomiss  xmm0,xmm1
        ja        near ptr M01_L03
 M01_L14:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6AFB40]
+       call      qword ptr [7FFE8C72EA90]
        jmp       near ptr M01_L05
 ; Total bytes of code 356
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
-       mov       rcx,19650001FE8
+       mov       rcx,2976EC02010
        mov       rcx,[rcx]
-       call      qword ptr [7FFE8C6AF648]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C71E598]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
 ; Total bytes of code 76
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
 M01_L00:
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        vzeroupper
        mov       [rsp+28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,[rsi]
        test      rbx,rbx
        je        short M01_L06
        mov       rcx,rbx
        cmp       [rcx],rdi
-       je        short M01_L08
+       je        near ptr M01_L08
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
-       mov       rax,[rcx+78]
+       mov       rax,[rcx+88]
        test      rax,rax
        je        short M01_L04
 M01_L01:
        mov       rcx,[rsi+8]
        cmp       qword ptr [rcx+10],0
        jne       near ptr M01_L11
 M01_L03:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6AFB88]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C71EAD8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        jmp       short M01_L05
 M01_L04:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7FB068
+       mov       rdx,7FFE8C7EF540
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       short M01_L01
 M01_L05:
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L06:
        mov       ecx,48B
-       mov       rdx,7FFE8C6BCE78
+       mov       rdx,7FFE8C7285E8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFE8C6F4A38]
+       call      qword ptr [7FFE8C71F8D0]
        int       3
 M01_L07:
        cmp       [rcx],ecx
-       call      qword ptr [7FFE8C6F51A0]
+       call      qword ptr [7FFE8C744318]
        mov       rcx,rax
 M01_L08:
        mov       rdx,[rcx+10]
        mov       rax,[rsi+8]
        cmp       qword ptr [rax+10],0
        jne       short M01_L10
        mov       rax,rcx
        jmp       short M01_L05
 M01_L10:
        mov       rdx,[rcx+8]
        mov       edx,[rdx+20]
        mov       rax,[rsi+8]
        cmp       edx,[rax+20]
        jle       near ptr M01_L02
        mov       rdx,rsi
-       call      qword ptr [7FFE8C6AF648]
+       call      qword ptr [7FFE8C71E598]
        jmp       short M01_L05
 M01_L11:
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
-       mov       rcx,[rcx+70]
+       mov       rcx,[rcx+80]
        test      rcx,rcx
        je        short M01_L12
        jmp       short M01_L13
 M01_L12:
        mov       rcx,rdi
-       mov       rdx,7FFE8C7FB018
+       mov       rdx,7FFE8C7EF4F0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L13:
        lea       r8,[rsp+20]
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6F52F0]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFE8C744468]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        test      eax,eax
        je        short M01_L14
        mov       rcx,[rsi+8]
        mov       ecx,[rcx+20]
        add       ecx,[rsp+20]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,ecx
-       vmulss    xmm0,xmm0,dword ptr [7FFE8C65D628]
+       vmulss    xmm0,xmm0,dword ptr [7FFE8C5A88F0]
        mov       rcx,[rsi+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
        vucomiss  xmm0,xmm1
        ja        near ptr M01_L03
 M01_L14:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C6AFB40]
+       call      qword ptr [7FFE8C71EA90]
        jmp       near ptr M01_L05
-; Total bytes of code 356
+; Total bytes of code 366
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
-       mov       rcx,247BC401FF8
+       mov       rcx,1C6A0011868
        mov       rcx,[rcx]
-       call      qword ptr [7FFE8C70E598]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C72E598]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
 ; Total bytes of code 76
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rcx,[rsi+8]
        cmp       qword ptr [rcx+10],0
        jne       near ptr M01_L11
 M01_L03:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C70EAD8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C72EAD8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        jmp       short M01_L05
 M01_L04:
        mov       rcx,rdi
-       mov       rdx,7FFE8C8064E8
+       mov       rdx,7FFE8C80C828
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       short M01_L01
 M01_L05:
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L06:
        mov       ecx,48B
-       mov       rdx,7FFE8C715DD0
+       mov       rdx,7FFE8C7385E8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFE8C70F8D0]
+       call      qword ptr [7FFE8C72F8D0]
        int       3
 M01_L07:
        cmp       [rcx],ecx
-       call      qword ptr [7FFE8C734318]
+       call      qword ptr [7FFE8C754318]
        mov       rcx,rax
 M01_L08:
        mov       rdx,[rcx+10]
        mov       rax,[rsi+8]
        cmp       qword ptr [rax+10],0
        jne       short M01_L10
        mov       rax,rcx
        jmp       short M01_L05
 M01_L10:
        mov       rdx,[rcx+8]
        mov       edx,[rdx+20]
        mov       rax,[rsi+8]
        cmp       edx,[rax+20]
        jle       near ptr M01_L02
        mov       rdx,rsi
-       call      qword ptr [7FFE8C70E598]
+       call      qword ptr [7FFE8C72E598]
        jmp       short M01_L05
 M01_L11:
        mov       rcx,[rdi+30]
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
        je        short M01_L12
        jmp       short M01_L13
 M01_L12:
        mov       rcx,rdi
-       mov       rdx,7FFE8C806498
+       mov       rdx,7FFE8C80C7D8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L13:
        lea       r8,[rsp+20]
        mov       rdx,rbx
-       call      qword ptr [7FFE8C734468]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFE8C754468]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        test      eax,eax
        je        short M01_L14
        mov       rcx,[rsi+8]
        mov       ecx,[rcx+20]
        add       ecx,[rsp+20]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,ecx
-       vmulss    xmm0,xmm0,dword ptr [7FFE8C620778]
+       vmulss    xmm0,xmm0,dword ptr [7FFE8C5C6408]
        mov       rcx,[rsi+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
        vucomiss  xmm0,xmm1
        ja        near ptr M01_L03
 M01_L14:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C70EA90]
+       call      qword ptr [7FFE8C72EA90]
        jmp       near ptr M01_L05
 ; Total bytes of code 356
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
-       mov       rcx,247BC401FF8
+       mov       rcx,2976EC02010
        mov       rcx,[rcx]
-       call      qword ptr [7FFE8C70E598]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C71E598]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
 ; Total bytes of code 76
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
 M01_L00:
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        vzeroupper
        mov       [rsp+28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,[rsi]
        test      rbx,rbx
        je        short M01_L06
        mov       rcx,rbx
        cmp       [rcx],rdi
-       je        short M01_L08
+       je        near ptr M01_L08
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
-       mov       rax,[rcx+78]
+       mov       rax,[rcx+88]
        test      rax,rax
        je        short M01_L04
 M01_L01:
        mov       rcx,[rsi+8]
        cmp       qword ptr [rcx+10],0
        jne       near ptr M01_L11
 M01_L03:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C70EAD8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C71EAD8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        jmp       short M01_L05
 M01_L04:
        mov       rcx,rdi
-       mov       rdx,7FFE8C8064E8
+       mov       rdx,7FFE8C7EF540
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       short M01_L01
 M01_L05:
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L06:
        mov       ecx,48B
-       mov       rdx,7FFE8C715DD0
+       mov       rdx,7FFE8C7285E8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFE8C70F8D0]
+       call      qword ptr [7FFE8C71F8D0]
        int       3
 M01_L07:
        cmp       [rcx],ecx
-       call      qword ptr [7FFE8C734318]
+       call      qword ptr [7FFE8C744318]
        mov       rcx,rax
 M01_L08:
        mov       rdx,[rcx+10]
        mov       rax,[rsi+8]
        cmp       qword ptr [rax+10],0
        jne       short M01_L10
        mov       rax,rcx
        jmp       short M01_L05
 M01_L10:
        mov       rdx,[rcx+8]
        mov       edx,[rdx+20]
        mov       rax,[rsi+8]
        cmp       edx,[rax+20]
        jle       near ptr M01_L02
        mov       rdx,rsi
-       call      qword ptr [7FFE8C70E598]
+       call      qword ptr [7FFE8C71E598]
        jmp       short M01_L05
 M01_L11:
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
-       mov       rcx,[rcx+70]
+       mov       rcx,[rcx+80]
        test      rcx,rcx
        je        short M01_L12
        jmp       short M01_L13
 M01_L12:
        mov       rcx,rdi
-       mov       rdx,7FFE8C806498
+       mov       rdx,7FFE8C7EF4F0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L13:
        lea       r8,[rsp+20]
        mov       rdx,rbx
-       call      qword ptr [7FFE8C734468]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFE8C744468]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        test      eax,eax
        je        short M01_L14
        mov       rcx,[rsi+8]
        mov       ecx,[rcx+20]
        add       ecx,[rsp+20]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,ecx
-       vmulss    xmm0,xmm0,dword ptr [7FFE8C620778]
+       vmulss    xmm0,xmm0,dword ptr [7FFE8C5A88F0]
        mov       rcx,[rsi+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
        vucomiss  xmm0,xmm1
        ja        near ptr M01_L03
 M01_L14:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C70EA90]
+       call      qword ptr [7FFE8C71EA90]
        jmp       near ptr M01_L05
-; Total bytes of code 356
+; Total bytes of code 366
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
.NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rbx,rcx
        mov       rdx,[rbx+190]
-       mov       rcx,1C6A0011868
+       mov       rcx,2976EC02010
        mov       rcx,[rcx]
-       call      qword ptr [7FFE8C72E598]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C71E598]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
 ; Total bytes of code 76
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
 M01_L00:
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        vzeroupper
        mov       [rsp+28],rcx
        mov       rsi,rcx
        mov       rbx,rdx
        mov       rdi,[rsi]
        test      rbx,rbx
        je        short M01_L06
        mov       rcx,rbx
        cmp       [rcx],rdi
-       je        short M01_L08
+       je        near ptr M01_L08
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
-       mov       rax,[rcx+78]
+       mov       rax,[rcx+88]
        test      rax,rax
        je        short M01_L04
 M01_L01:
        mov       rcx,[rsi+8]
        cmp       qword ptr [rcx+10],0
        jne       near ptr M01_L11
 M01_L03:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C72EAD8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE8C71EAD8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        jmp       short M01_L05
 M01_L04:
        mov       rcx,rdi
-       mov       rdx,7FFE8C80C828
+       mov       rdx,7FFE8C7EF540
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       short M01_L01
 M01_L05:
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L06:
        mov       ecx,48B
-       mov       rdx,7FFE8C7385E8
+       mov       rdx,7FFE8C7285E8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFE8C72F8D0]
+       call      qword ptr [7FFE8C71F8D0]
        int       3
 M01_L07:
        cmp       [rcx],ecx
-       call      qword ptr [7FFE8C754318]
+       call      qword ptr [7FFE8C744318]
        mov       rcx,rax
 M01_L08:
        mov       rdx,[rcx+10]
        mov       rax,[rsi+8]
        cmp       qword ptr [rax+10],0
        jne       short M01_L10
        mov       rax,rcx
        jmp       short M01_L05
 M01_L10:
        mov       rdx,[rcx+8]
        mov       edx,[rdx+20]
        mov       rax,[rsi+8]
        cmp       edx,[rax+20]
        jle       near ptr M01_L02
        mov       rdx,rsi
-       call      qword ptr [7FFE8C72E598]
+       call      qword ptr [7FFE8C71E598]
        jmp       short M01_L05
 M01_L11:
        mov       rcx,[rdi+30]
        mov       rcx,[rcx]
-       mov       rcx,[rcx+70]
+       mov       rcx,[rcx+80]
        test      rcx,rcx
        je        short M01_L12
        jmp       short M01_L13
 M01_L12:
        mov       rcx,rdi
-       mov       rdx,7FFE8C80C7D8
+       mov       rdx,7FFE8C7EF4F0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L13:
        lea       r8,[rsp+20]
        mov       rdx,rbx
-       call      qword ptr [7FFE8C754468]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFE8C744468]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        test      eax,eax
        je        short M01_L14
        mov       rcx,[rsi+8]
        mov       ecx,[rcx+20]
        add       ecx,[rsp+20]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,ecx
-       vmulss    xmm0,xmm0,dword ptr [7FFE8C5C6408]
+       vmulss    xmm0,xmm0,dword ptr [7FFE8C5A88F0]
        mov       rcx,[rsi+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
        vucomiss  xmm0,xmm1
        ja        near ptr M01_L03
 M01_L14:
        mov       rcx,rsi
        mov       rdx,rbx
-       call      qword ptr [7FFE8C72EA90]
+       call      qword ptr [7FFE8C71EA90]
        jmp       near ptr M01_L05
-; Total bytes of code 356
+; Total bytes of code 366
```
