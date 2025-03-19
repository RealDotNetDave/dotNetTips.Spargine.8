## DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark-20250319-012454
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1EDADC0D428
+       mov       r8,23D5F80B430
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
-       call      qword ptr [7FF9F68367D8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9F6807AE0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1EDADC0D420
+       mov       rdx,23D5F80B428
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF9F5DE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1EDADC0D428
+       call      qword ptr [7FF9F5DC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,23D5F80B430
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A1A328
+       mov       rdx,7FF9F69F9A20
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
-       call      qword ptr [7FF9F68A4378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6875590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A1A328
+       mov       rdx,7FF9F69F9A20
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF9F5CA10D0
+       mov       r11,7FF9F5C810D0
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
-       call      qword ptr [7FF9F68A4378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6875590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A1A250
+       mov       rdx,7FF9F69F9948
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
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6054F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6054F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,rax
-       mov       r11,7FF9F5CA10D8
+       mov       r11,7FF9F5C810D8
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
-       mov       r11,7FF9F5CA10D8
+       mov       r11,7FF9F5C810D8
        call      qword ptr [r11]
 M01_L22:
        nop
        mov       ecx,1
        jmp       short M02_L00
 ; Total bytes of code 33
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M03_L00:
-       call      qword ptr [7FF9F5DE41F8]
+       call      qword ptr [7FF9F5DC41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1EDADC0D428
+       mov       r8,274A280D428
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
-       call      qword ptr [7FF9F68367D8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9F6827AE0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1EDADC0D420
+       mov       rdx,274A280D420
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        call      qword ptr [7FF9F5DE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1EDADC0D428
+       mov       rcx,274A280D428
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A1A328
+       mov       rdx,7FF9F6A19E68
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
-       call      qword ptr [7FF9F68A4378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6895CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A1A328
+       mov       rdx,7FF9F6A19E68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
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
-       call      qword ptr [7FF9F68A4378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6895CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A1A250
+       mov       rdx,7FF9F6A19D90
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
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
        mov       r11,7FF9F5CA10D8
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
+; Total bytes of code 603
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M02_L01
        xor       ecx,ecx
        cmp       dword ptr [rax+8],0
        sete      cl
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1EDADC0D428
+       mov       r8,2395A80B430
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
-       call      qword ptr [7FF9F68367D8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9F68275D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1EDADC0D420
+       mov       rdx,2395A80B428
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF9F5DE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1EDADC0D428
+       call      qword ptr [7FF9F5DD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,2395A80B430
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A1A328
+       mov       rdx,7FF9F6A1A080
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
-       call      qword ptr [7FF9F68A4378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6885CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A1A328
+       mov       rdx,7FF9F6A1A080
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF9F5CA10D0
+       mov       r11,7FF9F5C910D8
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
-       call      qword ptr [7FF9F68A4378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6885CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A1A250
+       mov       rdx,7FF9F6A19FA8
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
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF9F5CA10D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FF9F5C910E0
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
-       mov       r11,7FF9F5CA10D8
+       mov       r11,7FF9F5C910E0
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
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M02_L01
        xor       ecx,ecx
        cmp       dword ptr [rax+8],0
        sete      cl
        mov       ecx,1
        jmp       short M02_L00
 ; Total bytes of code 33
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M03_L00:
-       call      qword ptr [7FF9F5DE41F8]
+       call      qword ptr [7FF9F5DD41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1EDADC0D428
+       mov       r8,1B046C0D428
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
-       call      qword ptr [7FF9F68367D8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9F6817AE0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1EDADC0D420
+       mov       rdx,1B046C0D420
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF9F5DE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1EDADC0D428
+       call      qword ptr [7FF9F5DD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1B046C0D428
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A1A328
+       mov       rdx,7FF9F6A0A150
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
-       call      qword ptr [7FF9F68A4378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6885CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A1A328
+       mov       rdx,7FF9F6A0A150
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF9F5CA10D0
+       mov       r11,7FF9F5C910D0
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
-       call      qword ptr [7FF9F68A4378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6885CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A1A250
+       mov       rdx,7FF9F6A0A078
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
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,rax
-       mov       r11,7FF9F5CA10D8
+       mov       r11,7FF9F5C910D8
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
-       mov       r11,7FF9F5CA10D8
+       mov       r11,7FF9F5C910D8
        call      qword ptr [r11]
 M01_L22:
        nop
        mov       ecx,1
        jmp       short M02_L00
 ; Total bytes of code 33
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M03_L00:
-       call      qword ptr [7FF9F5DE41F8]
+       call      qword ptr [7FF9F5DD41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1EDADC0D428
+       mov       r8,23F22C0D428
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
-       call      qword ptr [7FF9F68367D8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9F6817AE0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1EDADC0D420
+       mov       rdx,23F22C0D420
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF9F5DE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1EDADC0D428
+       call      qword ptr [7FF9F5DD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,23F22C0D428
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A1A328
+       mov       rdx,7FF9F6A1A180
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
-       call      qword ptr [7FF9F68A4378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6885590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A1A328
+       mov       rdx,7FF9F6A1A180
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF9F5CA10D0
+       mov       r11,7FF9F5C910D0
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
-       call      qword ptr [7FF9F68A4378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6885590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A1A250
+       mov       rdx,7FF9F6A1A0A8
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
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF9F5CA10D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FF9F5C910D8
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
-       mov       r11,7FF9F5CA10D8
+       mov       r11,7FF9F5C910D8
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
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M02_L01
        xor       ecx,ecx
        cmp       dword ptr [rax+8],0
        sete      cl
        mov       ecx,1
        jmp       short M02_L00
 ; Total bytes of code 33
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M03_L00:
-       call      qword ptr [7FF9F5DE41F8]
+       call      qword ptr [7FF9F5DD41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1EDADC0D428
+       mov       r8,1EA9DC0B430
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
-       call      qword ptr [7FF9F68367D8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9F68ED5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1EDADC0D420
+       mov       rdx,1EA9DC0B428
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF9F5DE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1EDADC0D428
+       mov       r8,7FF9F69D2AF0
+       call      qword ptr [7FF9F5DD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1EA9DC0B430
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
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       rdx,7FF9F69D2AF0
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
-       mov       rdx,7FF9F6A1A328
+       mov       rdx,7FF9F6A97120
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
-       call      qword ptr [7FF9F68A4378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F69D6E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       rdx,7FF9F69D2AF0
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
-       mov       rdx,7FF9F6A1A328
+       mov       rdx,7FF9F6A97120
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF9F5CA10D0
+       mov       r11,7FF9F5C912A0
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
-       call      qword ptr [7FF9F68A4378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F69D6E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A1A250
+       mov       rdx,7FF9F6A97048
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
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF9F5CA10D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FF9F5C912A8
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
-       mov       r11,7FF9F5CA10D8
+       mov       r11,7FF9F5C912A8
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
-; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       mov       rax,[rdx+30]
-       test      rax,rax
-       je        short M02_L01
-       xor       ecx,ecx
-       cmp       dword ptr [rax+8],0
-       sete      cl
-M02_L00:
-       xor       eax,eax
-       test      ecx,ecx
-       sete      al
-       ret
-M02_L01:
-       mov       ecx,1
-       jmp       short M02_L00
-; Total bytes of code 33
+; Total bytes of code 604
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
-       je        short M03_L00
+       je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
-M03_L00:
-       call      qword ptr [7FF9F5DE41F8]
+M02_L00:
+       call      qword ptr [7FF9F5DD41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1EDADC0D428
+       mov       r8,191FC80D428
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
-       call      qword ptr [7FF9F68367D8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9F69FEF40]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1EDADC0D420
+       mov       rdx,191FC80D420
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF9F5DE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1EDADC0D428
+       call      qword ptr [7FF9F5DA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,191FC80D428
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A1A328
+       mov       rdx,7FF9F6A7E870
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
-       call      qword ptr [7FF9F68A4378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6A564F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A1A328
+       mov       rdx,7FF9F6A7E870
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF9F5CA10D0
+       mov       r11,7FF9F5C61B68
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
-       call      qword ptr [7FF9F68A4378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6A564F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A1A250
+       mov       rdx,7FF9F6A7E798
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
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6034F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6034F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF9F5CA10D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FF9F5C61B70
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
-       mov       r11,7FF9F5CA10D8
+       mov       r11,7FF9F5C61B70
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
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        mov       rax,[rdx+30]
        test      rax,rax
-       je        short M02_L01
-       xor       ecx,ecx
+       je        short M02_L00
        cmp       dword ptr [rax+8],0
-       sete      cl
+       sete      al
+       movzx     eax,al
+       jmp       short M02_L01
 M02_L00:
-       xor       eax,eax
-       test      ecx,ecx
+       mov       eax,1
+M02_L01:
+       test      eax,eax
        sete      al
+       movzx     eax,al
        ret
-M02_L01:
-       mov       ecx,1
-       jmp       short M02_L00
-; Total bytes of code 33
+; Total bytes of code 35
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M03_L00:
-       call      qword ptr [7FF9F5DE41F8]
+       call      qword ptr [7FF9F5DA41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,23D5F80B430
+       mov       r8,274A280D428
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
-       call      qword ptr [7FF9F6807AE0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9F6827AE0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,23D5F80B428
+       mov       rdx,274A280D420
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF9F5DC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,23D5F80B430
+       call      qword ptr [7FF9F5DE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,274A280D428
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F69F9A20
+       mov       rdx,7FF9F6A19E68
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
-       call      qword ptr [7FF9F6875590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6895CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F69F9A20
+       mov       rdx,7FF9F6A19E68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF9F5C810D0
+       mov       r11,7FF9F5CA10D0
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
-       call      qword ptr [7FF9F6875590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6895CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F69F9948
+       mov       rdx,7FF9F6A19D90
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
-       call      qword ptr [7FF9F6054F30]
+       call      qword ptr [7FF9F6074F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF9F6054F30]
+       call      qword ptr [7FF9F6074F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,rax
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5CA10D8
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
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5CA10D8
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
+; Total bytes of code 603
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M02_L01
        xor       ecx,ecx
        cmp       dword ptr [rax+8],0
        sete      cl
        mov       ecx,1
        jmp       short M02_L00
 ; Total bytes of code 33
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M03_L00:
-       call      qword ptr [7FF9F5DC41F8]
+       call      qword ptr [7FF9F5DE41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,23D5F80B430
+       mov       r8,2395A80B430
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
-       call      qword ptr [7FF9F6807AE0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9F68275D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,23D5F80B428
+       mov       rdx,2395A80B428
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF9F5DC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,23D5F80B430
+       call      qword ptr [7FF9F5DD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,2395A80B430
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F69F9A20
+       mov       rdx,7FF9F6A1A080
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
-       call      qword ptr [7FF9F6875590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6885CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F69F9A20
+       mov       rdx,7FF9F6A1A080
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF9F5C810D0
+       mov       r11,7FF9F5C910D8
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
-       call      qword ptr [7FF9F6875590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6885CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F69F9948
+       mov       rdx,7FF9F6A19FA8
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
-       call      qword ptr [7FF9F6054F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF9F6054F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF9F5C810D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FF9F5C910E0
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
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5C910E0
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
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M02_L01
        xor       ecx,ecx
        cmp       dword ptr [rax+8],0
        sete      cl
        mov       ecx,1
        jmp       short M02_L00
 ; Total bytes of code 33
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M03_L00:
-       call      qword ptr [7FF9F5DC41F8]
+       call      qword ptr [7FF9F5DD41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,23D5F80B430
+       mov       r8,1B046C0D428
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
-       call      qword ptr [7FF9F6807AE0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9F6817AE0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,23D5F80B428
+       mov       rdx,1B046C0D420
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF9F5DC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,23D5F80B430
+       call      qword ptr [7FF9F5DD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1B046C0D428
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F69F9A20
+       mov       rdx,7FF9F6A0A150
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
-       call      qword ptr [7FF9F6875590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6885CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F69F9A20
+       mov       rdx,7FF9F6A0A150
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF9F5C810D0
+       mov       r11,7FF9F5C910D0
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
-       call      qword ptr [7FF9F6875590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6885CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F69F9948
+       mov       rdx,7FF9F6A0A078
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
-       call      qword ptr [7FF9F6054F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF9F6054F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,rax
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5C910D8
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
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5C910D8
        call      qword ptr [r11]
 M01_L22:
        nop
        mov       ecx,1
        jmp       short M02_L00
 ; Total bytes of code 33
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M03_L00:
-       call      qword ptr [7FF9F5DC41F8]
+       call      qword ptr [7FF9F5DD41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,23D5F80B430
+       mov       r8,23F22C0D428
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
-       call      qword ptr [7FF9F6807AE0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9F6817AE0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,23D5F80B428
+       mov       rdx,23F22C0D420
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF9F5DC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,23D5F80B430
+       call      qword ptr [7FF9F5DD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,23F22C0D428
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F69F9A20
+       mov       rdx,7FF9F6A1A180
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
-       call      qword ptr [7FF9F6875590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6885590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F69F9A20
+       mov       rdx,7FF9F6A1A180
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF9F5C810D0
+       mov       r11,7FF9F5C910D0
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
-       call      qword ptr [7FF9F6875590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6885590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F69F9948
+       mov       rdx,7FF9F6A1A0A8
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
-       call      qword ptr [7FF9F6054F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF9F6054F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF9F5C810D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FF9F5C910D8
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
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5C910D8
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
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M02_L01
        xor       ecx,ecx
        cmp       dword ptr [rax+8],0
        sete      cl
        mov       ecx,1
        jmp       short M02_L00
 ; Total bytes of code 33
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M03_L00:
-       call      qword ptr [7FF9F5DC41F8]
+       call      qword ptr [7FF9F5DD41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,23D5F80B430
+       mov       r8,1EA9DC0B430
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
-       call      qword ptr [7FF9F6807AE0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9F68ED5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,23D5F80B428
+       mov       rdx,1EA9DC0B428
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF9F5DC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,23D5F80B430
+       mov       r8,7FF9F69D2AF0
+       call      qword ptr [7FF9F5DD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1EA9DC0B430
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
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       rdx,7FF9F69D2AF0
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
-       mov       rdx,7FF9F69F9A20
+       mov       rdx,7FF9F6A97120
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
-       call      qword ptr [7FF9F6875590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F69D6E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       rdx,7FF9F69D2AF0
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
-       mov       rdx,7FF9F69F9A20
+       mov       rdx,7FF9F6A97120
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF9F5C810D0
+       mov       r11,7FF9F5C912A0
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
-       call      qword ptr [7FF9F6875590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F69D6E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F69F9948
+       mov       rdx,7FF9F6A97048
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
-       call      qword ptr [7FF9F6054F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF9F6054F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF9F5C810D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FF9F5C912A8
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
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5C912A8
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
-; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       mov       rax,[rdx+30]
-       test      rax,rax
-       je        short M02_L01
-       xor       ecx,ecx
-       cmp       dword ptr [rax+8],0
-       sete      cl
-M02_L00:
-       xor       eax,eax
-       test      ecx,ecx
-       sete      al
-       ret
-M02_L01:
-       mov       ecx,1
-       jmp       short M02_L00
-; Total bytes of code 33
+; Total bytes of code 604
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
-       je        short M03_L00
+       je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
-M03_L00:
-       call      qword ptr [7FF9F5DC41F8]
+M02_L00:
+       call      qword ptr [7FF9F5DD41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,23D5F80B430
+       mov       r8,191FC80D428
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
-       call      qword ptr [7FF9F6807AE0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9F69FEF40]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,23D5F80B428
+       mov       rdx,191FC80D420
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF9F5DC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,23D5F80B430
+       call      qword ptr [7FF9F5DA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,191FC80D428
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F69F9A20
+       mov       rdx,7FF9F6A7E870
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
-       call      qword ptr [7FF9F6875590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6A564F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F69F9A20
+       mov       rdx,7FF9F6A7E870
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF9F5C810D0
+       mov       r11,7FF9F5C61B68
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
-       call      qword ptr [7FF9F6875590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6A564F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F69F9948
+       mov       rdx,7FF9F6A7E798
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
-       call      qword ptr [7FF9F6054F30]
+       call      qword ptr [7FF9F6034F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF9F6054F30]
+       call      qword ptr [7FF9F6034F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF9F5C810D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FF9F5C61B70
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
-       mov       r11,7FF9F5C810D8
+       mov       r11,7FF9F5C61B70
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
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        mov       rax,[rdx+30]
        test      rax,rax
-       je        short M02_L01
-       xor       ecx,ecx
+       je        short M02_L00
        cmp       dword ptr [rax+8],0
-       sete      cl
+       sete      al
+       movzx     eax,al
+       jmp       short M02_L01
 M02_L00:
-       xor       eax,eax
-       test      ecx,ecx
+       mov       eax,1
+M02_L01:
+       test      eax,eax
        sete      al
+       movzx     eax,al
        ret
-M02_L01:
-       mov       ecx,1
-       jmp       short M02_L00
-; Total bytes of code 33
+; Total bytes of code 35
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M03_L00:
-       call      qword ptr [7FF9F5DC41F8]
+       call      qword ptr [7FF9F5DA41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,274A280D428
+       mov       r8,2395A80B430
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
-       call      qword ptr [7FF9F6827AE0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9F68275D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,274A280D420
+       mov       rdx,2395A80B428
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF9F5DE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,274A280D428
+       call      qword ptr [7FF9F5DD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,2395A80B430
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A19E68
+       mov       rdx,7FF9F6A1A080
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
-       call      qword ptr [7FF9F6895CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6885CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A19E68
+       mov       rdx,7FF9F6A1A080
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF9F5CA10D0
+       mov       r11,7FF9F5C910D8
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
-       call      qword ptr [7FF9F6895CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6885CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A19D90
+       mov       rdx,7FF9F6A19FA8
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
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF9F5CA10D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FF9F5C910E0
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
-       mov       r11,7FF9F5CA10D8
+       mov       r11,7FF9F5C910E0
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
-; Total bytes of code 603
+; Total bytes of code 604
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M02_L01
        xor       ecx,ecx
        cmp       dword ptr [rax+8],0
        sete      cl
        mov       ecx,1
        jmp       short M02_L00
 ; Total bytes of code 33
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M03_L00:
-       call      qword ptr [7FF9F5DE41F8]
+       call      qword ptr [7FF9F5DD41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,274A280D428
+       mov       r8,1B046C0D428
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
-       call      qword ptr [7FF9F6827AE0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9F6817AE0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,274A280D420
+       mov       rdx,1B046C0D420
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF9F5DE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,274A280D428
+       call      qword ptr [7FF9F5DD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1B046C0D428
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A19E68
+       mov       rdx,7FF9F6A0A150
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
-       call      qword ptr [7FF9F6895CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6885CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A19E68
+       mov       rdx,7FF9F6A0A150
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF9F5CA10D0
+       mov       r11,7FF9F5C910D0
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
-       call      qword ptr [7FF9F6895CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6885CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A19D90
+       mov       rdx,7FF9F6A0A078
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
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,rax
-       mov       r11,7FF9F5CA10D8
+       mov       r11,7FF9F5C910D8
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
-       mov       r11,7FF9F5CA10D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FF9F5C910D8
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
-; Total bytes of code 603
+; Total bytes of code 607
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M02_L01
        xor       ecx,ecx
        cmp       dword ptr [rax+8],0
        sete      cl
        mov       ecx,1
        jmp       short M02_L00
 ; Total bytes of code 33
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M03_L00:
-       call      qword ptr [7FF9F5DE41F8]
+       call      qword ptr [7FF9F5DD41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,274A280D428
+       mov       r8,23F22C0D428
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
-       call      qword ptr [7FF9F6827AE0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9F6817AE0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,274A280D420
+       mov       rdx,23F22C0D420
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF9F5DE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,274A280D428
+       call      qword ptr [7FF9F5DD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,23F22C0D428
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A19E68
+       mov       rdx,7FF9F6A1A180
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
-       call      qword ptr [7FF9F6895CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6885590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A19E68
+       mov       rdx,7FF9F6A1A180
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF9F5CA10D0
+       mov       r11,7FF9F5C910D0
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
-       call      qword ptr [7FF9F6895CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6885590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A19D90
+       mov       rdx,7FF9F6A1A0A8
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
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF9F5CA10D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FF9F5C910D8
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
-       mov       r11,7FF9F5CA10D8
+       mov       r11,7FF9F5C910D8
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
-; Total bytes of code 603
+; Total bytes of code 604
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M02_L01
        xor       ecx,ecx
        cmp       dword ptr [rax+8],0
        sete      cl
        mov       ecx,1
        jmp       short M02_L00
 ; Total bytes of code 33
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M03_L00:
-       call      qword ptr [7FF9F5DE41F8]
+       call      qword ptr [7FF9F5DD41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,274A280D428
+       mov       r8,1EA9DC0B430
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
-       call      qword ptr [7FF9F6827AE0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9F68ED5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,274A280D420
+       mov       rdx,1EA9DC0B428
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF9F5DE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,274A280D428
+       mov       r8,7FF9F69D2AF0
+       call      qword ptr [7FF9F5DD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1EA9DC0B430
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
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       rdx,7FF9F69D2AF0
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
-       mov       rdx,7FF9F6A19E68
+       mov       rdx,7FF9F6A97120
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
-       call      qword ptr [7FF9F6895CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F69D6E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       rdx,7FF9F69D2AF0
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
-       mov       rdx,7FF9F6A19E68
+       mov       rdx,7FF9F6A97120
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF9F5CA10D0
+       mov       r11,7FF9F5C912A0
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
-       call      qword ptr [7FF9F6895CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F69D6E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A19D90
+       mov       rdx,7FF9F6A97048
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
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF9F5CA10D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FF9F5C912A8
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
-       mov       r11,7FF9F5CA10D8
+       mov       r11,7FF9F5C912A8
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
-; Total bytes of code 603
-; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       mov       rax,[rdx+30]
-       test      rax,rax
-       je        short M02_L01
-       xor       ecx,ecx
-       cmp       dword ptr [rax+8],0
-       sete      cl
-M02_L00:
-       xor       eax,eax
-       test      ecx,ecx
-       sete      al
-       ret
-M02_L01:
-       mov       ecx,1
-       jmp       short M02_L00
-; Total bytes of code 33
+; Total bytes of code 604
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
-       je        short M03_L00
+       je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
-M03_L00:
-       call      qword ptr [7FF9F5DE41F8]
+M02_L00:
+       call      qword ptr [7FF9F5DD41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,274A280D428
+       mov       r8,191FC80D428
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
-       call      qword ptr [7FF9F6827AE0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9F69FEF40]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,274A280D420
+       mov       rdx,191FC80D420
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF9F5DE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,274A280D428
+       call      qword ptr [7FF9F5DA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,191FC80D428
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A19E68
+       mov       rdx,7FF9F6A7E870
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
-       call      qword ptr [7FF9F6895CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6A564F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A19E68
+       mov       rdx,7FF9F6A7E870
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF9F5CA10D0
+       mov       r11,7FF9F5C61B68
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
-       call      qword ptr [7FF9F6895CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6A564F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A19D90
+       mov       rdx,7FF9F6A7E798
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
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6034F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6034F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF9F5CA10D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FF9F5C61B70
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
-       mov       r11,7FF9F5CA10D8
+       mov       r11,7FF9F5C61B70
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
-; Total bytes of code 603
+; Total bytes of code 604
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        mov       rax,[rdx+30]
        test      rax,rax
-       je        short M02_L01
-       xor       ecx,ecx
+       je        short M02_L00
        cmp       dword ptr [rax+8],0
-       sete      cl
+       sete      al
+       movzx     eax,al
+       jmp       short M02_L01
 M02_L00:
-       xor       eax,eax
-       test      ecx,ecx
+       mov       eax,1
+M02_L01:
+       test      eax,eax
        sete      al
+       movzx     eax,al
        ret
-M02_L01:
-       mov       ecx,1
-       jmp       short M02_L00
-; Total bytes of code 33
+; Total bytes of code 35
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M03_L00:
-       call      qword ptr [7FF9F5DE41F8]
+       call      qword ptr [7FF9F5DA41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,2395A80B430
+       mov       r8,1B046C0D428
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
-       call      qword ptr [7FF9F68275D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9F6817AE0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,2395A80B428
+       mov       rdx,1B046C0D420
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        call      qword ptr [7FF9F5DD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2395A80B430
+       mov       rcx,1B046C0D428
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A1A080
+       mov       rdx,7FF9F6A0A150
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
        call      qword ptr [7FF9F6885CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A1A080
+       mov       rdx,7FF9F6A0A150
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF9F5C910D8
+       mov       r11,7FF9F5C910D0
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
        call      qword ptr [7FF9F6885CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A19FA8
+       mov       rdx,7FF9F6A0A078
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,[rbp-38]
-       mov       r11,7FF9F5C910E0
+       mov       rcx,rax
+       mov       r11,7FF9F5C910D8
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
-       mov       r11,7FF9F5C910E0
+       mov       rcx,[rbp-38]
+       mov       r11,7FF9F5C910D8
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
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M02_L01
        xor       ecx,ecx
        cmp       dword ptr [rax+8],0
        sete      cl
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,2395A80B430
+       mov       r8,23F22C0D428
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
-       call      qword ptr [7FF9F68275D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9F6817AE0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,2395A80B428
+       mov       rdx,23F22C0D420
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        call      qword ptr [7FF9F5DD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2395A80B430
+       mov       rcx,23F22C0D428
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A1A080
+       mov       rdx,7FF9F6A1A180
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
-       call      qword ptr [7FF9F6885CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6885590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A1A080
+       mov       rdx,7FF9F6A1A180
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF9F5C910D8
+       mov       r11,7FF9F5C910D0
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
-       call      qword ptr [7FF9F6885CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6885590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A19FA8
+       mov       rdx,7FF9F6A1A0A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FF9F5C910E0
+       mov       r11,7FF9F5C910D8
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
-       mov       r11,7FF9F5C910E0
+       mov       r11,7FF9F5C910D8
        call      qword ptr [r11]
 M01_L22:
        nop
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,2395A80B430
+       mov       r8,1EA9DC0B430
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
-       call      qword ptr [7FF9F68275D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9F68ED5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,2395A80B428
+       mov       rdx,1EA9DC0B428
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       r8,7FF9F69D2AF0
        call      qword ptr [7FF9F5DD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2395A80B430
+       mov       rcx,1EA9DC0B430
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
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       rdx,7FF9F69D2AF0
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
-       mov       rdx,7FF9F6A1A080
+       mov       rdx,7FF9F6A97120
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
-       call      qword ptr [7FF9F6885CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F69D6E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       rdx,7FF9F69D2AF0
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
-       mov       rdx,7FF9F6A1A080
+       mov       rdx,7FF9F6A97120
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF9F5C910D8
+       mov       r11,7FF9F5C912A0
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
-       call      qword ptr [7FF9F6885CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F69D6E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A19FA8
+       mov       rdx,7FF9F6A97048
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FF9F5C910E0
+       mov       r11,7FF9F5C912A8
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
-       mov       r11,7FF9F5C910E0
+       mov       r11,7FF9F5C912A8
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
 ; Total bytes of code 604
-; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       mov       rax,[rdx+30]
-       test      rax,rax
-       je        short M02_L01
-       xor       ecx,ecx
-       cmp       dword ptr [rax+8],0
-       sete      cl
-M02_L00:
-       xor       eax,eax
-       test      ecx,ecx
-       sete      al
-       ret
-M02_L01:
-       mov       ecx,1
-       jmp       short M02_L00
-; Total bytes of code 33
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
-       je        short M03_L00
+       je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
-M03_L00:
+M02_L00:
        call      qword ptr [7FF9F5DD41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,2395A80B430
+       mov       r8,191FC80D428
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
-       call      qword ptr [7FF9F68275D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9F69FEF40]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,2395A80B428
+       mov       rdx,191FC80D420
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF9F5DD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2395A80B430
+       call      qword ptr [7FF9F5DA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,191FC80D428
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A1A080
+       mov       rdx,7FF9F6A7E870
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
-       call      qword ptr [7FF9F6885CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6A564F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A1A080
+       mov       rdx,7FF9F6A7E870
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF9F5C910D8
+       mov       r11,7FF9F5C61B68
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
-       call      qword ptr [7FF9F6885CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6A564F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A19FA8
+       mov       rdx,7FF9F6A7E798
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
-       call      qword ptr [7FF9F6064F30]
+       call      qword ptr [7FF9F6034F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF9F6064F30]
+       call      qword ptr [7FF9F6034F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FF9F5C910E0
+       mov       r11,7FF9F5C61B70
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
-       mov       r11,7FF9F5C910E0
+       mov       r11,7FF9F5C61B70
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
 ; Total bytes of code 604
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        mov       rax,[rdx+30]
        test      rax,rax
-       je        short M02_L01
-       xor       ecx,ecx
+       je        short M02_L00
        cmp       dword ptr [rax+8],0
-       sete      cl
+       sete      al
+       movzx     eax,al
+       jmp       short M02_L01
 M02_L00:
-       xor       eax,eax
-       test      ecx,ecx
+       mov       eax,1
+M02_L01:
+       test      eax,eax
        sete      al
+       movzx     eax,al
        ret
-M02_L01:
-       mov       ecx,1
-       jmp       short M02_L00
-; Total bytes of code 33
+; Total bytes of code 35
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M03_L00:
-       call      qword ptr [7FF9F5DD41F8]
+       call      qword ptr [7FF9F5DA41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1B046C0D428
+       mov       r8,23F22C0D428
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
-       mov       rdx,1B046C0D420
+       mov       rdx,23F22C0D420
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        call      qword ptr [7FF9F5DD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1B046C0D428
+       mov       rcx,23F22C0D428
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A0A150
+       mov       rdx,7FF9F6A1A180
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
-       call      qword ptr [7FF9F6885CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6885590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A0A150
+       mov       rdx,7FF9F6A1A180
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
        mov       rcx,rax
        mov       r11,7FF9F5C910D0
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
-       call      qword ptr [7FF9F6885CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6885590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A0A078
+       mov       rdx,7FF9F6A1A0A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
+       mov       rcx,[rbp-38]
        mov       r11,7FF9F5C910D8
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
        mov       r11,7FF9F5C910D8
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
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M02_L01
        xor       ecx,ecx
        cmp       dword ptr [rax+8],0
        sete      cl
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1B046C0D428
+       mov       r8,1EA9DC0B430
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
-       call      qword ptr [7FF9F6817AE0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9F68ED5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1B046C0D420
+       mov       rdx,1EA9DC0B428
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       r8,7FF9F69D2AF0
        call      qword ptr [7FF9F5DD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1B046C0D428
+       mov       rcx,1EA9DC0B430
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
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       rdx,7FF9F69D2AF0
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
-       mov       rdx,7FF9F6A0A150
+       mov       rdx,7FF9F6A97120
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
-       call      qword ptr [7FF9F6885CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F69D6E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       rdx,7FF9F69D2AF0
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
-       mov       rdx,7FF9F6A0A150
+       mov       rdx,7FF9F6A97120
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF9F5C910D0
+       mov       r11,7FF9F5C912A0
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
-       call      qword ptr [7FF9F6885CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F69D6E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A0A078
+       mov       rdx,7FF9F6A97048
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF9F5C910D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FF9F5C912A8
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
-       mov       r11,7FF9F5C910D8
+       mov       r11,7FF9F5C912A8
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
-; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       mov       rax,[rdx+30]
-       test      rax,rax
-       je        short M02_L01
-       xor       ecx,ecx
-       cmp       dword ptr [rax+8],0
-       sete      cl
-M02_L00:
-       xor       eax,eax
-       test      ecx,ecx
-       sete      al
-       ret
-M02_L01:
-       mov       ecx,1
-       jmp       short M02_L00
-; Total bytes of code 33
+; Total bytes of code 604
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
-       je        short M03_L00
+       je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
-M03_L00:
+M02_L00:
        call      qword ptr [7FF9F5DD41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1B046C0D428
+       mov       r8,191FC80D428
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
-       call      qword ptr [7FF9F6817AE0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9F69FEF40]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1B046C0D420
+       mov       rdx,191FC80D420
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF9F5DD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1B046C0D428
+       call      qword ptr [7FF9F5DA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,191FC80D428
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A0A150
+       mov       rdx,7FF9F6A7E870
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
-       call      qword ptr [7FF9F6885CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6A564F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A0A150
+       mov       rdx,7FF9F6A7E870
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF9F5C910D0
+       mov       r11,7FF9F5C61B68
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
-       call      qword ptr [7FF9F6885CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6A564F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A0A078
+       mov       rdx,7FF9F6A7E798
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
-       call      qword ptr [7FF9F6064F30]
+       call      qword ptr [7FF9F6034F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF9F6064F30]
+       call      qword ptr [7FF9F6034F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF9F5C910D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FF9F5C61B70
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
-       mov       r11,7FF9F5C910D8
+       mov       r11,7FF9F5C61B70
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
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        mov       rax,[rdx+30]
        test      rax,rax
-       je        short M02_L01
-       xor       ecx,ecx
+       je        short M02_L00
        cmp       dword ptr [rax+8],0
-       sete      cl
+       sete      al
+       movzx     eax,al
+       jmp       short M02_L01
 M02_L00:
-       xor       eax,eax
-       test      ecx,ecx
+       mov       eax,1
+M02_L01:
+       test      eax,eax
        sete      al
+       movzx     eax,al
        ret
-M02_L01:
-       mov       ecx,1
-       jmp       short M02_L00
-; Total bytes of code 33
+; Total bytes of code 35
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M03_L00:
-       call      qword ptr [7FF9F5DD41F8]
+       call      qword ptr [7FF9F5DA41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,23F22C0D428
+       mov       r8,1EA9DC0B430
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
-       call      qword ptr [7FF9F6817AE0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9F68ED5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,23F22C0D420
+       mov       rdx,1EA9DC0B428
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       r8,7FF9F69D2AF0
        call      qword ptr [7FF9F5DD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,23F22C0D428
+       mov       rcx,1EA9DC0B430
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
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       rdx,7FF9F69D2AF0
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
-       mov       rdx,7FF9F6A1A180
+       mov       rdx,7FF9F6A97120
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
-       call      qword ptr [7FF9F6885590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F69D6E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       rdx,7FF9F69D2AF0
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
-       mov       rdx,7FF9F6A1A180
+       mov       rdx,7FF9F6A97120
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF9F5C910D0
+       mov       r11,7FF9F5C912A0
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
-       call      qword ptr [7FF9F6885590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F69D6E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A1A0A8
+       mov       rdx,7FF9F6A97048
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FF9F5C910D8
+       mov       r11,7FF9F5C912A8
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
-       mov       r11,7FF9F5C910D8
+       mov       r11,7FF9F5C912A8
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
 ; Total bytes of code 604
-; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       mov       rax,[rdx+30]
-       test      rax,rax
-       je        short M02_L01
-       xor       ecx,ecx
-       cmp       dword ptr [rax+8],0
-       sete      cl
-M02_L00:
-       xor       eax,eax
-       test      ecx,ecx
-       sete      al
-       ret
-M02_L01:
-       mov       ecx,1
-       jmp       short M02_L00
-; Total bytes of code 33
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
-       je        short M03_L00
+       je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
-M03_L00:
+M02_L00:
        call      qword ptr [7FF9F5DD41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,23F22C0D428
+       mov       r8,191FC80D428
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
-       call      qword ptr [7FF9F6817AE0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9F69FEF40]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,23F22C0D420
+       mov       rdx,191FC80D420
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF9F5DD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,23F22C0D428
+       call      qword ptr [7FF9F5DA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,191FC80D428
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A1A180
+       mov       rdx,7FF9F6A7E870
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
-       call      qword ptr [7FF9F6885590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6A564F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A1A180
+       mov       rdx,7FF9F6A7E870
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF9F5C910D0
+       mov       r11,7FF9F5C61B68
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
-       call      qword ptr [7FF9F6885590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6A564F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A1A0A8
+       mov       rdx,7FF9F6A7E798
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
-       call      qword ptr [7FF9F6064F30]
+       call      qword ptr [7FF9F6034F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF9F6064F30]
+       call      qword ptr [7FF9F6034F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FF9F5C910D8
+       mov       r11,7FF9F5C61B70
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
-       mov       r11,7FF9F5C910D8
+       mov       r11,7FF9F5C61B70
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
 ; Total bytes of code 604
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        mov       rax,[rdx+30]
        test      rax,rax
-       je        short M02_L01
-       xor       ecx,ecx
+       je        short M02_L00
        cmp       dword ptr [rax+8],0
-       sete      cl
+       sete      al
+       movzx     eax,al
+       jmp       short M02_L01
 M02_L00:
-       xor       eax,eax
-       test      ecx,ecx
+       mov       eax,1
+M02_L01:
+       test      eax,eax
        sete      al
+       movzx     eax,al
        ret
-M02_L01:
-       mov       ecx,1
-       jmp       short M02_L00
-; Total bytes of code 33
+; Total bytes of code 35
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M03_L00:
-       call      qword ptr [7FF9F5DD41F8]
+       call      qword ptr [7FF9F5DA41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1EA9DC0B430
+       mov       r8,191FC80D428
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
-       call      qword ptr [7FF9F68ED5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9F69FEF40]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1EA9DC0B428
+       mov       rdx,191FC80D420
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FF9F69D2AF0
-       call      qword ptr [7FF9F5DD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1EA9DC0B430
+       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       call      qword ptr [7FF9F5DA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,191FC80D428
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
-       mov       rdx,7FF9F69D2AF0
+       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A97120
+       mov       rdx,7FF9F6A7E870
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
-       call      qword ptr [7FF9F69D6E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6A564F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF9F69D2AF0
+       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
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
-       mov       rdx,7FF9F6A97120
+       mov       rdx,7FF9F6A7E870
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF9F5C912A0
+       mov       r11,7FF9F5C61B68
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
-       call      qword ptr [7FF9F69D6E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF9F6A564F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF9F6A97048
+       mov       rdx,7FF9F6A7E798
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
-       call      qword ptr [7FF9F6064F30]
+       call      qword ptr [7FF9F6034F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF9F6064F30]
+       call      qword ptr [7FF9F6034F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FF9F5C912A8
+       mov       r11,7FF9F5C61B70
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
-       mov       r11,7FF9F5C912A8
+       mov       r11,7FF9F5C61B70
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
 ; Total bytes of code 604
+; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M02_L00
+       cmp       dword ptr [rax+8],0
+       sete      al
+       movzx     eax,al
+       jmp       short M02_L01
+M02_L00:
+       mov       eax,1
+M02_L01:
+       test      eax,eax
+       sete      al
+       movzx     eax,al
+       ret
+; Total bytes of code 35
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
-       je        short M02_L00
+       je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
-M02_L00:
-       call      qword ptr [7FF9F5DD41F8]
+M03_L00:
+       call      qword ptr [7FF9F5DA41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rsp+28],xmm4
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rbx,rcx
        mov       rsi,[rbx+280]
        test      rsi,rsi
        je        near ptr M00_L02
        mov       rdx,rsi
        mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FF9F5DA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F679FBD0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F68052D8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1D879401FE8
+       mov       rcx,1F646001FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9F6864C18]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9F6876580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        mov       [rsp+38],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rsi+8],rcx
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       ecx,10
-       call      qword ptr [7FF9F6034F30]
+       call      qword ptr [7FF9F6054F30]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF9F5C60FE0
+       mov       r11,7FF9F5C80FE0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FF9F5DA4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FF9F5DC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
 ; Total bytes of code 109
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,60
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       [rsp+50],rax
        mov       [rsp+58],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L00
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L00
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4B0
+       mov       rdx,7FF9F6A1EDF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M02_L08
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],40
        jle       short M02_L02
        mov       r11,[rcx+40]
        test      r11,r11
        je        short M02_L02
        jmp       short M02_L03
 M02_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4D0
+       mov       rdx,7FF9F6A1EE10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L03:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       esi,eax
        test      esi,esi
        je        near ptr M02_L15
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],48
        jle       short M02_L04
        mov       rcx,[rcx+48]
        test      rcx,rcx
        je        short M02_L04
        jmp       short M02_L05
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4E8
+       mov       rdx,7FF9F6A1EE28
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L05:
        movsxd    rdx,esi
        call      CORINFO_HELP_NEWARR_1_OBJ
        mov       rsi,rax
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],50
        jle       short M02_L06
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M02_L06
        jmp       short M02_L07
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF5F8
+       mov       rdx,7FF9F6A1EF38
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L07:
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L09
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L09
        jmp       short M02_L10
 M02_L09:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4C0
+       mov       rdx,7FF9F6A1EE00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A15E78]
+       call      qword ptr [7FF9F6A36D18]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4C0
+       mov       rdx,7FF9F6A1EE00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF9F6A15EF0]
+       call      qword ptr [7FF9F6A36D90]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4C0
+       mov       rdx,7FF9F6A1EE00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A15F80]
+       call      qword ptr [7FF9F6A36E20]
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],58
        jle       short M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M02_L16
        jmp       short M02_L17
 M02_L16:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF610
+       mov       rdx,7FF9F6A1EF50
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9F624E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9F626E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 521
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        vzeroupper
        mov       rax,[rcx+8]
        cmp       qword ptr [rax+10],0
        jne       short M03_L01
 M03_L00:
-       jmp       qword ptr [7FF9F6865158]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF9F6876AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF9F690D038]
+       vmulss    xmm0,xmm0,dword ptr [7FF9F693E258]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF9F6865110]
+       jmp       qword ptr [7FF9F6876A78]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rsp+28],xmm4
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rbx,rcx
        mov       rsi,[rbx+280]
        test      rsi,rsi
        je        near ptr M00_L02
        mov       rdx,rsi
        mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FF9F5DA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F679FBD0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F68052D8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1D879401FE8
+       mov       rcx,20D2AC01FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9F6864C18]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9F6875E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        mov       [rsp+38],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rsi+8],rcx
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       ecx,10
-       call      qword ptr [7FF9F6034F30]
+       call      qword ptr [7FF9F6054F30]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF9F5C60FE0
+       mov       r11,7FF9F5C80FE0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FF9F5DA4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FF9F5DC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
 ; Total bytes of code 109
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,60
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       [rsp+50],rax
        mov       [rsp+58],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L00
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L00
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4B0
+       mov       rdx,7FF9F6A1F7D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M02_L08
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],40
        jle       short M02_L02
        mov       r11,[rcx+40]
        test      r11,r11
        je        short M02_L02
        jmp       short M02_L03
 M02_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4D0
+       mov       rdx,7FF9F6A1F7F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L03:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       esi,eax
        test      esi,esi
        je        near ptr M02_L15
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],48
        jle       short M02_L04
        mov       rcx,[rcx+48]
        test      rcx,rcx
        je        short M02_L04
        jmp       short M02_L05
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4E8
+       mov       rdx,7FF9F6A1F810
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L05:
        movsxd    rdx,esi
        call      CORINFO_HELP_NEWARR_1_OBJ
        mov       rsi,rax
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],50
        jle       short M02_L06
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M02_L06
        jmp       short M02_L07
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF5F8
+       mov       rdx,7FF9F6A1F920
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L07:
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L09
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L09
        jmp       short M02_L10
 M02_L09:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4C0
+       mov       rdx,7FF9F6A1F7E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A15E78]
+       call      qword ptr [7FF9F6A36D00]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4C0
+       mov       rdx,7FF9F6A1F7E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF9F6A15EF0]
+       call      qword ptr [7FF9F6A36D78]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4C0
+       mov       rdx,7FF9F6A1F7E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A15F80]
+       call      qword ptr [7FF9F6A36E08]
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],58
        jle       short M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M02_L16
        jmp       short M02_L17
 M02_L16:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF610
+       mov       rdx,7FF9F6A1F938
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9F624E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9F626E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 521
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        vzeroupper
        mov       rax,[rcx+8]
        cmp       qword ptr [rax+10],0
        jne       short M03_L01
 M03_L00:
-       jmp       qword ptr [7FF9F6865158]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF9F68763A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF9F690D038]
+       vmulss    xmm0,xmm0,dword ptr [7FF9F692D318]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF9F6865110]
+       jmp       qword ptr [7FF9F6876358]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rsp+28],xmm4
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rbx,rcx
        mov       rsi,[rbx+280]
        test      rsi,rsi
        je        near ptr M00_L02
        mov       rdx,rsi
        mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FF9F5DA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F679FBD0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F68252D8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1D879401FE8
+       mov       rcx,17830C01FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9F6864C18]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9F6896580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        mov       [rsp+38],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rsi+8],rcx
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       ecx,10
-       call      qword ptr [7FF9F6034F30]
+       call      qword ptr [7FF9F6074F30]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF9F5C60FE0
+       mov       r11,7FF9F5CA0FF0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FF9F5DA4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FF9F5DE4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
 ; Total bytes of code 109
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,60
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       [rsp+50],rax
        mov       [rsp+58],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L00
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L00
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4B0
+       mov       rdx,7FF9F6A3FAA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M02_L08
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],40
        jle       short M02_L02
        mov       r11,[rcx+40]
        test      r11,r11
        je        short M02_L02
        jmp       short M02_L03
 M02_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4D0
+       mov       rdx,7FF9F6A3FAC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L03:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       esi,eax
        test      esi,esi
        je        near ptr M02_L15
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],48
        jle       short M02_L04
        mov       rcx,[rcx+48]
        test      rcx,rcx
        je        short M02_L04
        jmp       short M02_L05
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4E8
+       mov       rdx,7FF9F6A3FAE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L05:
        movsxd    rdx,esi
        call      CORINFO_HELP_NEWARR_1_OBJ
        mov       rsi,rax
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],50
        jle       short M02_L06
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M02_L06
        jmp       short M02_L07
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF5F8
+       mov       rdx,7FF9F6A3FBF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L07:
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L09
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L09
        jmp       short M02_L10
 M02_L09:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4C0
+       mov       rdx,7FF9F6A3FAB8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A15E78]
+       call      qword ptr [7FF9F6A56D00]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4C0
+       mov       rdx,7FF9F6A3FAB8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF9F6A15EF0]
+       call      qword ptr [7FF9F6A56D78]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4C0
+       mov       rdx,7FF9F6A3FAB8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A15F80]
+       call      qword ptr [7FF9F6A56E08]
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],58
        jle       short M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M02_L16
        jmp       short M02_L17
 M02_L16:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF610
+       mov       rdx,7FF9F6A3FC08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9F624E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9F628E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 521
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        vzeroupper
        mov       rax,[rcx+8]
        cmp       qword ptr [rax+10],0
        jne       short M03_L01
 M03_L00:
-       jmp       qword ptr [7FF9F6865158]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF9F6896AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF9F690D038]
+       vmulss    xmm0,xmm0,dword ptr [7FF9F695D6F8]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF9F6865110]
+       jmp       qword ptr [7FF9F6896A78]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rsp+28],xmm4
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rbx,rcx
        mov       rsi,[rbx+280]
        test      rsi,rsi
        je        near ptr M00_L02
        mov       rdx,rsi
        mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FF9F5DA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F679FBD0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F67F59C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1D879401FE8
+       mov       rcx,2E4DC001FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9F6864C18]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9F68667F0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        mov       [rsp+38],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rsi+8],rcx
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       ecx,10
-       call      qword ptr [7FF9F6034F30]
+       call      qword ptr [7FF9F6044F30]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF9F5C60FE0
+       mov       r11,7FF9F5C70FE0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FF9F5DA4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FF9F5DB4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
 ; Total bytes of code 109
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,60
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       [rsp+50],rax
        mov       [rsp+58],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L00
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L00
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4B0
+       mov       rdx,7FF9F6A0F440
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M02_L08
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],40
        jle       short M02_L02
        mov       r11,[rcx+40]
        test      r11,r11
        je        short M02_L02
        jmp       short M02_L03
 M02_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4D0
+       mov       rdx,7FF9F6A0F460
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L03:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       esi,eax
        test      esi,esi
        je        near ptr M02_L15
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],48
        jle       short M02_L04
        mov       rcx,[rcx+48]
        test      rcx,rcx
        je        short M02_L04
        jmp       short M02_L05
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4E8
+       mov       rdx,7FF9F6A0F478
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L05:
        movsxd    rdx,esi
        call      CORINFO_HELP_NEWARR_1_OBJ
        mov       rsi,rax
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],50
        jle       short M02_L06
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M02_L06
        jmp       short M02_L07
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF5F8
+       mov       rdx,7FF9F6A0F588
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L07:
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L09
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L09
        jmp       short M02_L10
 M02_L09:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4C0
+       mov       rdx,7FF9F6A0F450
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A15E78]
+       call      qword ptr [7FF9F6A17288]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4C0
+       mov       rdx,7FF9F6A0F450
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF9F6A15EF0]
+       call      qword ptr [7FF9F6A17300]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4C0
+       mov       rdx,7FF9F6A0F450
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A15F80]
+       call      qword ptr [7FF9F6A17390]
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],58
        jle       short M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M02_L16
        jmp       short M02_L17
 M02_L16:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF610
+       mov       rdx,7FF9F6A0F5A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9F624E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9F625E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 521
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        vzeroupper
        mov       rax,[rcx+8]
        cmp       qword ptr [rax+10],0
        jne       short M03_L01
 M03_L00:
-       jmp       qword ptr [7FF9F6865158]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF9F6866D30]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF9F690D038]
+       vmulss    xmm0,xmm0,dword ptr [7FF9F691D2B8]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF9F6865110]
+       jmp       qword ptr [7FF9F6866CE8]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rsp+28],xmm4
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rbx,rcx
        mov       rsi,[rbx+280]
        test      rsi,rsi
        je        near ptr M00_L02
        mov       rdx,rsi
        mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FF9F5DA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F679FBD0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6804DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1D879401FE8
+       mov       rcx,2C09F401FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9F6864C18]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9F6877750]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        mov       [rsp+38],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rsi+8],rcx
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       ecx,10
-       call      qword ptr [7FF9F6034F30]
+       call      qword ptr [7FF9F6054F30]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF9F5C60FE0
+       mov       r11,7FF9F5C81098
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FF9F5DA4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FF9F5DC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
 ; Total bytes of code 109
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,60
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       [rsp+50],rax
        mov       [rsp+58],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L00
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L00
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4B0
+       mov       rdx,7FF9F6A908A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M02_L08
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],40
        jle       short M02_L02
        mov       r11,[rcx+40]
        test      r11,r11
        je        short M02_L02
        jmp       short M02_L03
 M02_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4D0
+       mov       rdx,7FF9F6A908C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L03:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       esi,eax
        test      esi,esi
        je        near ptr M02_L15
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],48
        jle       short M02_L04
        mov       rcx,[rcx+48]
        test      rcx,rcx
        je        short M02_L04
        jmp       short M02_L05
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4E8
+       mov       rdx,7FF9F6A908D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L05:
        movsxd    rdx,esi
        call      CORINFO_HELP_NEWARR_1_OBJ
        mov       rsi,rax
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],50
        jle       short M02_L06
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M02_L06
        jmp       short M02_L07
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF5F8
+       mov       rdx,7FF9F6A909E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L07:
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L09
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L09
        jmp       short M02_L10
 M02_L09:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4C0
+       mov       rdx,7FF9F6A908B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A15E78]
+       call      qword ptr [7FF9F6A66370]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4C0
+       mov       rdx,7FF9F6A908B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF9F6A15EF0]
+       call      qword ptr [7FF9F6A663E8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4C0
+       mov       rdx,7FF9F6A908B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A15F80]
+       call      qword ptr [7FF9F6A66478]
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],58
        jle       short M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M02_L16
        jmp       short M02_L17
 M02_L16:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF610
+       mov       rdx,7FF9F6A90A00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9F624E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9F626E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 521
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        vzeroupper
        mov       rax,[rcx+8]
        cmp       qword ptr [rax+10],0
        jne       short M03_L01
 M03_L00:
-       jmp       qword ptr [7FF9F6865158]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF9F6877C90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF9F690D038]
+       vmulss    xmm0,xmm0,dword ptr [7FF9F6940A78]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF9F6865110]
+       jmp       qword ptr [7FF9F6877C48]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rsp+28],xmm4
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rbx,rcx
        mov       rsi,[rbx+280]
        test      rsi,rsi
        je        near ptr M00_L02
        mov       rdx,rsi
        mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FF9F5DA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F679FBD0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6865530]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1D879401FE8
+       mov       rcx,16AA9C01FF8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9F6864C18]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9F69D7750]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        mov       [rsp+38],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rsi+8],rcx
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       ecx,10
-       call      qword ptr [7FF9F6034F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF9F5C60FE0
+       mov       r11,7FF9F5C912D8
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
 M00_L04:
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L01
 ; Total bytes of code 207
 ; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       push      rbx
        test      rdx,rdx
-       je        short M01_L01
-       mov       rax,[rdx]
-       movzx     r8d,word ptr [rax+0E]
+       je        short M01_L02
+       mov       rbx,[rdx]
+       movzx     r8d,word ptr [rbx+0E]
        test      r8,r8
-       je        short M01_L04
-       mov       r10,[rax+38]
+       je        short M01_L01
+       mov       r10,[rbx+38]
        cmp       r8,4
-       jl        short M01_L03
+       jl        short M01_L04
 M01_L00:
        cmp       [r10],rcx
-       jne       short M01_L02
-M01_L01:
-       mov       rax,rdx
-       ret
-M01_L02:
+       je        short M01_L02
        cmp       [r10+8],rcx
-       je        short M01_L01
+       je        short M01_L02
        cmp       [r10+10],rcx
-       je        short M01_L01
+       je        short M01_L02
        cmp       [r10+18],rcx
-       je        short M01_L01
+       je        short M01_L02
        add       r10,20
        add       r8,0FFFFFFFFFFFFFFFC
        cmp       r8,4
        jge       short M01_L00
        test      r8,r8
-       je        short M01_L04
+       jne       short M01_L04
+M01_L01:
+       test      dword ptr [rbx],406C0000
+       jne       short M01_L03
+       xor       edx,edx
+M01_L02:
+       mov       rax,rdx
+       pop       rbx
+       ret
 M01_L03:
+       pop       rbx
+       jmp       qword ptr [7FF9F5DD4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+M01_L04:
        cmp       [r10],rcx
-       je        short M01_L01
+       je        short M01_L02
        add       r10,8
        dec       r8
        test      r8,r8
-       jg        short M01_L03
-M01_L04:
-       test      dword ptr [rax],406C0000
-       jne       short M01_L05
-       xor       edx,edx
+       jg        short M01_L04
        jmp       short M01_L01
-M01_L05:
-       jmp       qword ptr [7FF9F5DA4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
-; Total bytes of code 109
+; Total bytes of code 112
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,60
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       [rsp+50],rax
        mov       [rsp+58],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L00
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L00
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4B0
+       mov       rdx,7FF9F6AC7448
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M02_L08
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],40
        jle       short M02_L02
        mov       r11,[rcx+40]
        test      r11,r11
        je        short M02_L02
        jmp       short M02_L03
 M02_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4D0
+       mov       rdx,7FF9F6AC7468
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L03:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       esi,eax
        test      esi,esi
        je        near ptr M02_L15
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],48
        jle       short M02_L04
        mov       rcx,[rcx+48]
        test      rcx,rcx
        je        short M02_L04
        jmp       short M02_L05
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4E8
+       mov       rdx,7FF9F6AC7480
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L05:
        movsxd    rdx,esi
        call      CORINFO_HELP_NEWARR_1_OBJ
        mov       rsi,rax
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],50
        jle       short M02_L06
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M02_L06
        jmp       short M02_L07
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF5F8
+       mov       rdx,7FF9F6AC7590
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L07:
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L09
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L09
        jmp       short M02_L10
 M02_L09:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4C0
+       mov       rdx,7FF9F6AC7458
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A15E78]
+       call      qword ptr [7FF9F6AD4180]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4C0
+       mov       rdx,7FF9F6AC7458
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF9F6A15EF0]
+       call      qword ptr [7FF9F6AD41F8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4C0
+       mov       rdx,7FF9F6AC7458
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A15F80]
+       call      qword ptr [7FF9F6AD4288]
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],58
        jle       short M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M02_L16
        jmp       short M02_L17
 M02_L16:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF610
+       mov       rdx,7FF9F6AC75A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9F624E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9F627E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 521
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        vzeroupper
        mov       rax,[rcx+8]
        cmp       qword ptr [rax+10],0
        jne       short M03_L01
 M03_L00:
-       jmp       qword ptr [7FF9F6865158]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF9F69D7C90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF9F690D038]
+       vmulss    xmm0,xmm0,dword ptr [7FF9F6951A58]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF9F6865110]
+       jmp       qword ptr [7FF9F69D7C48]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rsp+28],xmm4
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rbx,rcx
        mov       rsi,[rbx+280]
        test      rsi,rsi
        je        near ptr M00_L02
        mov       rdx,rsi
        mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FF9F5DA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F679FBD0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F68D7CC0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1D879401FE8
+       mov       rcx,249A28127D0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9F6864C18]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9F6A7CC00]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        mov       [rsp+38],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rsi+8],rcx
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       ecx,10
-       call      qword ptr [7FF9F6034F30]
+       call      qword ptr [7FF9F6054F30]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF9F5C60FE0
+       mov       r11,7FF9F5C81BA0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
 M00_L04:
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L01
 ; Total bytes of code 207
 ; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rdx,rdx
        je        short M01_L01
-       mov       rax,[rdx]
-       movzx     r8d,word ptr [rax+0E]
-       test      r8,r8
-       je        short M01_L04
-       mov       r10,[rax+38]
-       cmp       r8,4
-       jl        short M01_L03
+       mov       r8,[rdx]
+       movzx     r10d,word ptr [r8+0E]
+       test      r10,r10
+       je        short M01_L05
+       mov       r9,[r8+38]
+       cmp       r10,4
+       jl        short M01_L04
 M01_L00:
-       cmp       [r10],rcx
-       jne       short M01_L02
+       cmp       [r9],rcx
+       je        short M01_L01
+       cmp       [r9+8],rcx
+       je        short M01_L01
+       cmp       [r9+10],rcx
+       je        short M01_L01
+       cmp       [r9+18],rcx
+       je        short M01_L01
+       add       r9,20
+       add       r10,0FFFFFFFFFFFFFFFC
+       cmp       r10,4
+       jl        short M01_L03
+       jmp       short M01_L00
 M01_L01:
        mov       rax,rdx
        ret
 M01_L02:
-       cmp       [r10+8],rcx
-       je        short M01_L01
-       cmp       [r10+10],rcx
-       je        short M01_L01
-       cmp       [r10+18],rcx
-       je        short M01_L01
-       add       r10,20
-       add       r8,0FFFFFFFFFFFFFFFC
-       cmp       r8,4
-       jge       short M01_L00
-       test      r8,r8
-       je        short M01_L04
+       jmp       qword ptr [7FF9F5DC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
 M01_L03:
-       cmp       [r10],rcx
-       je        short M01_L01
-       add       r10,8
-       dec       r8
-       test      r8,r8
-       jg        short M01_L03
+       test      r10,r10
+       je        short M01_L05
 M01_L04:
-       test      dword ptr [rax],406C0000
-       jne       short M01_L05
+       cmp       [r9],rcx
+       je        short M01_L01
+       add       r9,8
+       dec       r10
+       test      r10,r10
+       jg        short M01_L04
+M01_L05:
+       test      dword ptr [r8],406C0000
+       jne       short M01_L02
        xor       edx,edx
        jmp       short M01_L01
-M01_L05:
-       jmp       qword ptr [7FF9F5DA4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
-; Total bytes of code 109
+; Total bytes of code 112
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,60
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       [rsp+50],rax
        mov       [rsp+58],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L00
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L00
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4B0
+       mov       rdx,7FF9F6AAE3C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M02_L08
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],40
        jle       short M02_L02
        mov       r11,[rcx+40]
        test      r11,r11
        je        short M02_L02
        jmp       short M02_L03
 M02_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4D0
+       mov       rdx,7FF9F6AAE3E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L03:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       esi,eax
        test      esi,esi
        je        near ptr M02_L15
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],48
        jle       short M02_L04
        mov       rcx,[rcx+48]
        test      rcx,rcx
        je        short M02_L04
        jmp       short M02_L05
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4E8
+       mov       rdx,7FF9F6AAE3F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L05:
        movsxd    rdx,esi
        call      CORINFO_HELP_NEWARR_1_OBJ
        mov       rsi,rax
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],50
        jle       short M02_L06
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M02_L06
        jmp       short M02_L07
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF5F8
+       mov       rdx,7FF9F6AAE508
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L07:
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L09
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L09
        jmp       short M02_L10
 M02_L09:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4C0
+       mov       rdx,7FF9F6AAE3D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A15E78]
+       call      qword ptr [7FF9F6AC5ED8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4C0
+       mov       rdx,7FF9F6AAE3D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF9F6A15EF0]
+       call      qword ptr [7FF9F6AC5F50]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF4C0
+       mov       rdx,7FF9F6AAE3D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A15F80]
+       call      qword ptr [7FF9F6AC5FE0]
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],58
        jle       short M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M02_L16
        jmp       short M02_L17
 M02_L16:
        mov       rcx,rbx
-       mov       rdx,7FF9F69FF610
+       mov       rdx,7FF9F6AAE520
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9F624E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9F626E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 521
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        vzeroupper
        mov       rax,[rcx+8]
        cmp       qword ptr [rax+10],0
        jne       short M03_L01
 M03_L00:
-       jmp       qword ptr [7FF9F6865158]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF9F6A7D140]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF9F690D038]
+       vmulss    xmm0,xmm0,dword ptr [7FF9F6AD9B78]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF9F6865110]
+       jmp       qword ptr [7FF9F6A7D0F8]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1F646001FE8
+       mov       rcx,20D2AC01FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9F6876580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9F6875E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        mov       [rsp+38],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rsi+8],rcx
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        jmp       qword ptr [7FF9F5DC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
 ; Total bytes of code 109
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,60
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       [rsp+50],rax
        mov       [rsp+58],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L00
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L00
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EDF0
+       mov       rdx,7FF9F6A1F7D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
        call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M02_L08
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],40
        jle       short M02_L02
        mov       r11,[rcx+40]
        test      r11,r11
        je        short M02_L02
        jmp       short M02_L03
 M02_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE10
+       mov       rdx,7FF9F6A1F7F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L03:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       esi,eax
        test      esi,esi
        je        near ptr M02_L15
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],48
        jle       short M02_L04
        mov       rcx,[rcx+48]
        test      rcx,rcx
        je        short M02_L04
        jmp       short M02_L05
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE28
+       mov       rdx,7FF9F6A1F810
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L05:
        movsxd    rdx,esi
        call      CORINFO_HELP_NEWARR_1_OBJ
        mov       rsi,rax
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],50
        jle       short M02_L06
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M02_L06
        jmp       short M02_L07
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EF38
+       mov       rdx,7FF9F6A1F920
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L07:
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L09
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L09
        jmp       short M02_L10
 M02_L09:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE00
+       mov       rdx,7FF9F6A1F7E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A36D18]
+       call      qword ptr [7FF9F6A36D00]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE00
+       mov       rdx,7FF9F6A1F7E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF9F6A36D90]
+       call      qword ptr [7FF9F6A36D78]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE00
+       mov       rdx,7FF9F6A1F7E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A36E20]
+       call      qword ptr [7FF9F6A36E08]
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],58
        jle       short M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M02_L16
        jmp       short M02_L17
 M02_L16:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EF50
+       mov       rdx,7FF9F6A1F938
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
        call      qword ptr [7FF9F626E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 521
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        vzeroupper
        mov       rax,[rcx+8]
        cmp       qword ptr [rax+10],0
        jne       short M03_L01
 M03_L00:
-       jmp       qword ptr [7FF9F6876AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF9F68763A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF9F693E258]
+       vmulss    xmm0,xmm0,dword ptr [7FF9F692D318]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF9F6876A78]
+       jmp       qword ptr [7FF9F6876358]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rsp+28],xmm4
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rbx,rcx
        mov       rsi,[rbx+280]
        test      rsi,rsi
        je        near ptr M00_L02
        mov       rdx,rsi
        mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F68052D8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F68252D8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1F646001FE8
+       mov       rcx,17830C01FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9F6876580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9F6896580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        mov       [rsp+38],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rsi+8],rcx
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       ecx,10
-       call      qword ptr [7FF9F6054F30]
+       call      qword ptr [7FF9F6074F30]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF9F5C80FE0
+       mov       r11,7FF9F5CA0FF0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FF9F5DC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FF9F5DE4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
 ; Total bytes of code 109
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,60
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       [rsp+50],rax
        mov       [rsp+58],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L00
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L00
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EDF0
+       mov       rdx,7FF9F6A3FAA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M02_L08
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],40
        jle       short M02_L02
        mov       r11,[rcx+40]
        test      r11,r11
        je        short M02_L02
        jmp       short M02_L03
 M02_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE10
+       mov       rdx,7FF9F6A3FAC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L03:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       esi,eax
        test      esi,esi
        je        near ptr M02_L15
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],48
        jle       short M02_L04
        mov       rcx,[rcx+48]
        test      rcx,rcx
        je        short M02_L04
        jmp       short M02_L05
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE28
+       mov       rdx,7FF9F6A3FAE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L05:
        movsxd    rdx,esi
        call      CORINFO_HELP_NEWARR_1_OBJ
        mov       rsi,rax
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],50
        jle       short M02_L06
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M02_L06
        jmp       short M02_L07
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EF38
+       mov       rdx,7FF9F6A3FBF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L07:
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L09
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L09
        jmp       short M02_L10
 M02_L09:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE00
+       mov       rdx,7FF9F6A3FAB8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A36D18]
+       call      qword ptr [7FF9F6A56D00]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE00
+       mov       rdx,7FF9F6A3FAB8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF9F6A36D90]
+       call      qword ptr [7FF9F6A56D78]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE00
+       mov       rdx,7FF9F6A3FAB8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A36E20]
+       call      qword ptr [7FF9F6A56E08]
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],58
        jle       short M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M02_L16
        jmp       short M02_L17
 M02_L16:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EF50
+       mov       rdx,7FF9F6A3FC08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9F626E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9F628E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 521
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        vzeroupper
        mov       rax,[rcx+8]
        cmp       qword ptr [rax+10],0
        jne       short M03_L01
 M03_L00:
-       jmp       qword ptr [7FF9F6876AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF9F6896AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF9F693E258]
+       vmulss    xmm0,xmm0,dword ptr [7FF9F695D6F8]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF9F6876A78]
+       jmp       qword ptr [7FF9F6896A78]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rsp+28],xmm4
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rbx,rcx
        mov       rsi,[rbx+280]
        test      rsi,rsi
        je        near ptr M00_L02
        mov       rdx,rsi
        mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F68052D8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F67F59C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1F646001FE8
+       mov       rcx,2E4DC001FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9F6876580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9F68667F0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        mov       [rsp+38],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rsi+8],rcx
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       ecx,10
-       call      qword ptr [7FF9F6054F30]
+       call      qword ptr [7FF9F6044F30]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF9F5C80FE0
+       mov       r11,7FF9F5C70FE0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FF9F5DC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FF9F5DB4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
 ; Total bytes of code 109
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,60
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       [rsp+50],rax
        mov       [rsp+58],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L00
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L00
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EDF0
+       mov       rdx,7FF9F6A0F440
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M02_L08
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],40
        jle       short M02_L02
        mov       r11,[rcx+40]
        test      r11,r11
        je        short M02_L02
        jmp       short M02_L03
 M02_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE10
+       mov       rdx,7FF9F6A0F460
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L03:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       esi,eax
        test      esi,esi
        je        near ptr M02_L15
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],48
        jle       short M02_L04
        mov       rcx,[rcx+48]
        test      rcx,rcx
        je        short M02_L04
        jmp       short M02_L05
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE28
+       mov       rdx,7FF9F6A0F478
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L05:
        movsxd    rdx,esi
        call      CORINFO_HELP_NEWARR_1_OBJ
        mov       rsi,rax
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],50
        jle       short M02_L06
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M02_L06
        jmp       short M02_L07
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EF38
+       mov       rdx,7FF9F6A0F588
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L07:
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L09
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L09
        jmp       short M02_L10
 M02_L09:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE00
+       mov       rdx,7FF9F6A0F450
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A36D18]
+       call      qword ptr [7FF9F6A17288]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE00
+       mov       rdx,7FF9F6A0F450
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF9F6A36D90]
+       call      qword ptr [7FF9F6A17300]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE00
+       mov       rdx,7FF9F6A0F450
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A36E20]
+       call      qword ptr [7FF9F6A17390]
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],58
        jle       short M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M02_L16
        jmp       short M02_L17
 M02_L16:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EF50
+       mov       rdx,7FF9F6A0F5A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9F626E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9F625E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 521
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        vzeroupper
        mov       rax,[rcx+8]
        cmp       qword ptr [rax+10],0
        jne       short M03_L01
 M03_L00:
-       jmp       qword ptr [7FF9F6876AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF9F6866D30]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF9F693E258]
+       vmulss    xmm0,xmm0,dword ptr [7FF9F691D2B8]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF9F6876A78]
+       jmp       qword ptr [7FF9F6866CE8]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rsp+28],xmm4
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rbx,rcx
        mov       rsi,[rbx+280]
        test      rsi,rsi
        je        near ptr M00_L02
        mov       rdx,rsi
        mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F68052D8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6804DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1F646001FE8
+       mov       rcx,2C09F401FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9F6876580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9F6877750]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        mov       [rsp+38],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rsi+8],rcx
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       ecx,10
        call      qword ptr [7FF9F6054F30]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF9F5C80FE0
+       mov       r11,7FF9F5C81098
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        jmp       qword ptr [7FF9F5DC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
 ; Total bytes of code 109
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,60
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       [rsp+50],rax
        mov       [rsp+58],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L00
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L00
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EDF0
+       mov       rdx,7FF9F6A908A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
        call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M02_L08
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],40
        jle       short M02_L02
        mov       r11,[rcx+40]
        test      r11,r11
        je        short M02_L02
        jmp       short M02_L03
 M02_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE10
+       mov       rdx,7FF9F6A908C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L03:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       esi,eax
        test      esi,esi
        je        near ptr M02_L15
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],48
        jle       short M02_L04
        mov       rcx,[rcx+48]
        test      rcx,rcx
        je        short M02_L04
        jmp       short M02_L05
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE28
+       mov       rdx,7FF9F6A908D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L05:
        movsxd    rdx,esi
        call      CORINFO_HELP_NEWARR_1_OBJ
        mov       rsi,rax
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],50
        jle       short M02_L06
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M02_L06
        jmp       short M02_L07
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EF38
+       mov       rdx,7FF9F6A909E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L07:
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L09
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L09
        jmp       short M02_L10
 M02_L09:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE00
+       mov       rdx,7FF9F6A908B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A36D18]
+       call      qword ptr [7FF9F6A66370]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE00
+       mov       rdx,7FF9F6A908B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF9F6A36D90]
+       call      qword ptr [7FF9F6A663E8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE00
+       mov       rdx,7FF9F6A908B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A36E20]
+       call      qword ptr [7FF9F6A66478]
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],58
        jle       short M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M02_L16
        jmp       short M02_L17
 M02_L16:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EF50
+       mov       rdx,7FF9F6A90A00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
        call      qword ptr [7FF9F626E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 521
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        vzeroupper
        mov       rax,[rcx+8]
        cmp       qword ptr [rax+10],0
        jne       short M03_L01
 M03_L00:
-       jmp       qword ptr [7FF9F6876AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF9F6877C90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF9F693E258]
+       vmulss    xmm0,xmm0,dword ptr [7FF9F6940A78]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF9F6876A78]
+       jmp       qword ptr [7FF9F6877C48]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rsp+28],xmm4
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rbx,rcx
        mov       rsi,[rbx+280]
        test      rsi,rsi
        je        near ptr M00_L02
        mov       rdx,rsi
        mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F68052D8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6865530]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1F646001FE8
+       mov       rcx,16AA9C01FF8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9F6876580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9F69D7750]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        mov       [rsp+38],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rsi+8],rcx
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       ecx,10
-       call      qword ptr [7FF9F6054F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF9F5C80FE0
+       mov       r11,7FF9F5C912D8
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
 M00_L04:
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L01
 ; Total bytes of code 207
 ; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       push      rbx
        test      rdx,rdx
-       je        short M01_L01
-       mov       rax,[rdx]
-       movzx     r8d,word ptr [rax+0E]
+       je        short M01_L02
+       mov       rbx,[rdx]
+       movzx     r8d,word ptr [rbx+0E]
        test      r8,r8
-       je        short M01_L04
-       mov       r10,[rax+38]
+       je        short M01_L01
+       mov       r10,[rbx+38]
        cmp       r8,4
-       jl        short M01_L03
+       jl        short M01_L04
 M01_L00:
        cmp       [r10],rcx
-       jne       short M01_L02
-M01_L01:
-       mov       rax,rdx
-       ret
-M01_L02:
+       je        short M01_L02
        cmp       [r10+8],rcx
-       je        short M01_L01
+       je        short M01_L02
        cmp       [r10+10],rcx
-       je        short M01_L01
+       je        short M01_L02
        cmp       [r10+18],rcx
-       je        short M01_L01
+       je        short M01_L02
        add       r10,20
        add       r8,0FFFFFFFFFFFFFFFC
        cmp       r8,4
        jge       short M01_L00
        test      r8,r8
-       je        short M01_L04
+       jne       short M01_L04
+M01_L01:
+       test      dword ptr [rbx],406C0000
+       jne       short M01_L03
+       xor       edx,edx
+M01_L02:
+       mov       rax,rdx
+       pop       rbx
+       ret
 M01_L03:
+       pop       rbx
+       jmp       qword ptr [7FF9F5DD4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+M01_L04:
        cmp       [r10],rcx
-       je        short M01_L01
+       je        short M01_L02
        add       r10,8
        dec       r8
        test      r8,r8
-       jg        short M01_L03
-M01_L04:
-       test      dword ptr [rax],406C0000
-       jne       short M01_L05
-       xor       edx,edx
+       jg        short M01_L04
        jmp       short M01_L01
-M01_L05:
-       jmp       qword ptr [7FF9F5DC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
-; Total bytes of code 109
+; Total bytes of code 112
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,60
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       [rsp+50],rax
        mov       [rsp+58],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L00
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L00
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EDF0
+       mov       rdx,7FF9F6AC7448
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M02_L08
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],40
        jle       short M02_L02
        mov       r11,[rcx+40]
        test      r11,r11
        je        short M02_L02
        jmp       short M02_L03
 M02_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE10
+       mov       rdx,7FF9F6AC7468
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L03:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       esi,eax
        test      esi,esi
        je        near ptr M02_L15
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],48
        jle       short M02_L04
        mov       rcx,[rcx+48]
        test      rcx,rcx
        je        short M02_L04
        jmp       short M02_L05
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE28
+       mov       rdx,7FF9F6AC7480
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L05:
        movsxd    rdx,esi
        call      CORINFO_HELP_NEWARR_1_OBJ
        mov       rsi,rax
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],50
        jle       short M02_L06
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M02_L06
        jmp       short M02_L07
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EF38
+       mov       rdx,7FF9F6AC7590
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L07:
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L09
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L09
        jmp       short M02_L10
 M02_L09:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE00
+       mov       rdx,7FF9F6AC7458
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A36D18]
+       call      qword ptr [7FF9F6AD4180]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE00
+       mov       rdx,7FF9F6AC7458
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF9F6A36D90]
+       call      qword ptr [7FF9F6AD41F8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE00
+       mov       rdx,7FF9F6AC7458
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A36E20]
+       call      qword ptr [7FF9F6AD4288]
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],58
        jle       short M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M02_L16
        jmp       short M02_L17
 M02_L16:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EF50
+       mov       rdx,7FF9F6AC75A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9F626E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9F627E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 521
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        vzeroupper
        mov       rax,[rcx+8]
        cmp       qword ptr [rax+10],0
        jne       short M03_L01
 M03_L00:
-       jmp       qword ptr [7FF9F6876AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF9F69D7C90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF9F693E258]
+       vmulss    xmm0,xmm0,dword ptr [7FF9F6951A58]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF9F6876A78]
+       jmp       qword ptr [7FF9F69D7C48]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rsp+28],xmm4
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rbx,rcx
        mov       rsi,[rbx+280]
        test      rsi,rsi
        je        near ptr M00_L02
        mov       rdx,rsi
        mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F68052D8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F68D7CC0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1F646001FE8
+       mov       rcx,249A28127D0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9F6876580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9F6A7CC00]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        mov       [rsp+38],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rsi+8],rcx
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       ecx,10
        call      qword ptr [7FF9F6054F30]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF9F5C80FE0
+       mov       r11,7FF9F5C81BA0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
 M00_L04:
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L01
 ; Total bytes of code 207
 ; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rdx,rdx
        je        short M01_L01
-       mov       rax,[rdx]
-       movzx     r8d,word ptr [rax+0E]
-       test      r8,r8
-       je        short M01_L04
-       mov       r10,[rax+38]
-       cmp       r8,4
-       jl        short M01_L03
+       mov       r8,[rdx]
+       movzx     r10d,word ptr [r8+0E]
+       test      r10,r10
+       je        short M01_L05
+       mov       r9,[r8+38]
+       cmp       r10,4
+       jl        short M01_L04
 M01_L00:
-       cmp       [r10],rcx
-       jne       short M01_L02
+       cmp       [r9],rcx
+       je        short M01_L01
+       cmp       [r9+8],rcx
+       je        short M01_L01
+       cmp       [r9+10],rcx
+       je        short M01_L01
+       cmp       [r9+18],rcx
+       je        short M01_L01
+       add       r9,20
+       add       r10,0FFFFFFFFFFFFFFFC
+       cmp       r10,4
+       jl        short M01_L03
+       jmp       short M01_L00
 M01_L01:
        mov       rax,rdx
        ret
 M01_L02:
-       cmp       [r10+8],rcx
-       je        short M01_L01
-       cmp       [r10+10],rcx
-       je        short M01_L01
-       cmp       [r10+18],rcx
-       je        short M01_L01
-       add       r10,20
-       add       r8,0FFFFFFFFFFFFFFFC
-       cmp       r8,4
-       jge       short M01_L00
-       test      r8,r8
-       je        short M01_L04
+       jmp       qword ptr [7FF9F5DC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
 M01_L03:
-       cmp       [r10],rcx
-       je        short M01_L01
-       add       r10,8
-       dec       r8
-       test      r8,r8
-       jg        short M01_L03
+       test      r10,r10
+       je        short M01_L05
 M01_L04:
-       test      dword ptr [rax],406C0000
-       jne       short M01_L05
+       cmp       [r9],rcx
+       je        short M01_L01
+       add       r9,8
+       dec       r10
+       test      r10,r10
+       jg        short M01_L04
+M01_L05:
+       test      dword ptr [r8],406C0000
+       jne       short M01_L02
        xor       edx,edx
        jmp       short M01_L01
-M01_L05:
-       jmp       qword ptr [7FF9F5DC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
-; Total bytes of code 109
+; Total bytes of code 112
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,60
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       [rsp+50],rax
        mov       [rsp+58],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L00
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L00
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EDF0
+       mov       rdx,7FF9F6AAE3C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
        call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M02_L08
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],40
        jle       short M02_L02
        mov       r11,[rcx+40]
        test      r11,r11
        je        short M02_L02
        jmp       short M02_L03
 M02_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE10
+       mov       rdx,7FF9F6AAE3E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L03:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       esi,eax
        test      esi,esi
        je        near ptr M02_L15
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],48
        jle       short M02_L04
        mov       rcx,[rcx+48]
        test      rcx,rcx
        je        short M02_L04
        jmp       short M02_L05
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE28
+       mov       rdx,7FF9F6AAE3F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L05:
        movsxd    rdx,esi
        call      CORINFO_HELP_NEWARR_1_OBJ
        mov       rsi,rax
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],50
        jle       short M02_L06
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M02_L06
        jmp       short M02_L07
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EF38
+       mov       rdx,7FF9F6AAE508
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L07:
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L09
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L09
        jmp       short M02_L10
 M02_L09:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE00
+       mov       rdx,7FF9F6AAE3D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A36D18]
+       call      qword ptr [7FF9F6AC5ED8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE00
+       mov       rdx,7FF9F6AAE3D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF9F6A36D90]
+       call      qword ptr [7FF9F6AC5F50]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EE00
+       mov       rdx,7FF9F6AAE3D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A36E20]
+       call      qword ptr [7FF9F6AC5FE0]
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],58
        jle       short M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M02_L16
        jmp       short M02_L17
 M02_L16:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1EF50
+       mov       rdx,7FF9F6AAE520
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
        call      qword ptr [7FF9F626E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 521
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        vzeroupper
        mov       rax,[rcx+8]
        cmp       qword ptr [rax+10],0
        jne       short M03_L01
 M03_L00:
-       jmp       qword ptr [7FF9F6876AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF9F6A7D140]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF9F693E258]
+       vmulss    xmm0,xmm0,dword ptr [7FF9F6AD9B78]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF9F6876A78]
+       jmp       qword ptr [7FF9F6A7D0F8]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rsp+28],xmm4
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rbx,rcx
        mov       rsi,[rbx+280]
        test      rsi,rsi
        je        near ptr M00_L02
        mov       rdx,rsi
        mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F68052D8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F68252D8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,20D2AC01FE8
+       mov       rcx,17830C01FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9F6875E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9F6896580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        mov       [rsp+38],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rsi+8],rcx
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       ecx,10
-       call      qword ptr [7FF9F6054F30]
+       call      qword ptr [7FF9F6074F30]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF9F5C80FE0
+       mov       r11,7FF9F5CA0FF0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FF9F5DC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FF9F5DE4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
 ; Total bytes of code 109
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,60
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       [rsp+50],rax
        mov       [rsp+58],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L00
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L00
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F7D8
+       mov       rdx,7FF9F6A3FAA8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M02_L08
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],40
        jle       short M02_L02
        mov       r11,[rcx+40]
        test      r11,r11
        je        short M02_L02
        jmp       short M02_L03
 M02_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F7F8
+       mov       rdx,7FF9F6A3FAC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L03:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       esi,eax
        test      esi,esi
        je        near ptr M02_L15
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],48
        jle       short M02_L04
        mov       rcx,[rcx+48]
        test      rcx,rcx
        je        short M02_L04
        jmp       short M02_L05
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F810
+       mov       rdx,7FF9F6A3FAE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L05:
        movsxd    rdx,esi
        call      CORINFO_HELP_NEWARR_1_OBJ
        mov       rsi,rax
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],50
        jle       short M02_L06
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M02_L06
        jmp       short M02_L07
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F920
+       mov       rdx,7FF9F6A3FBF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L07:
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L09
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L09
        jmp       short M02_L10
 M02_L09:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F7E8
+       mov       rdx,7FF9F6A3FAB8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A36D00]
+       call      qword ptr [7FF9F6A56D00]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F7E8
+       mov       rdx,7FF9F6A3FAB8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF9F6A36D78]
+       call      qword ptr [7FF9F6A56D78]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F7E8
+       mov       rdx,7FF9F6A3FAB8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A36E08]
+       call      qword ptr [7FF9F6A56E08]
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],58
        jle       short M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M02_L16
        jmp       short M02_L17
 M02_L16:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F938
+       mov       rdx,7FF9F6A3FC08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9F626E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9F628E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 521
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        vzeroupper
        mov       rax,[rcx+8]
        cmp       qword ptr [rax+10],0
        jne       short M03_L01
 M03_L00:
-       jmp       qword ptr [7FF9F68763A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF9F6896AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF9F692D318]
+       vmulss    xmm0,xmm0,dword ptr [7FF9F695D6F8]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF9F6876358]
+       jmp       qword ptr [7FF9F6896A78]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rsp+28],xmm4
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rbx,rcx
        mov       rsi,[rbx+280]
        test      rsi,rsi
        je        near ptr M00_L02
        mov       rdx,rsi
        mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F68052D8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F67F59C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,20D2AC01FE8
+       mov       rcx,2E4DC001FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9F6875E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9F68667F0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        mov       [rsp+38],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rsi+8],rcx
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       ecx,10
-       call      qword ptr [7FF9F6054F30]
+       call      qword ptr [7FF9F6044F30]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF9F5C80FE0
+       mov       r11,7FF9F5C70FE0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FF9F5DC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FF9F5DB4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
 ; Total bytes of code 109
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,60
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       [rsp+50],rax
        mov       [rsp+58],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L00
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L00
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F7D8
+       mov       rdx,7FF9F6A0F440
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M02_L08
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],40
        jle       short M02_L02
        mov       r11,[rcx+40]
        test      r11,r11
        je        short M02_L02
        jmp       short M02_L03
 M02_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F7F8
+       mov       rdx,7FF9F6A0F460
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L03:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       esi,eax
        test      esi,esi
        je        near ptr M02_L15
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],48
        jle       short M02_L04
        mov       rcx,[rcx+48]
        test      rcx,rcx
        je        short M02_L04
        jmp       short M02_L05
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F810
+       mov       rdx,7FF9F6A0F478
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L05:
        movsxd    rdx,esi
        call      CORINFO_HELP_NEWARR_1_OBJ
        mov       rsi,rax
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],50
        jle       short M02_L06
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M02_L06
        jmp       short M02_L07
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F920
+       mov       rdx,7FF9F6A0F588
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L07:
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L09
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L09
        jmp       short M02_L10
 M02_L09:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F7E8
+       mov       rdx,7FF9F6A0F450
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A36D00]
+       call      qword ptr [7FF9F6A17288]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F7E8
+       mov       rdx,7FF9F6A0F450
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF9F6A36D78]
+       call      qword ptr [7FF9F6A17300]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F7E8
+       mov       rdx,7FF9F6A0F450
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A36E08]
+       call      qword ptr [7FF9F6A17390]
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],58
        jle       short M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M02_L16
        jmp       short M02_L17
 M02_L16:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F938
+       mov       rdx,7FF9F6A0F5A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9F626E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9F625E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 521
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        vzeroupper
        mov       rax,[rcx+8]
        cmp       qword ptr [rax+10],0
        jne       short M03_L01
 M03_L00:
-       jmp       qword ptr [7FF9F68763A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF9F6866D30]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF9F692D318]
+       vmulss    xmm0,xmm0,dword ptr [7FF9F691D2B8]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF9F6876358]
+       jmp       qword ptr [7FF9F6866CE8]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rsp+28],xmm4
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rbx,rcx
        mov       rsi,[rbx+280]
        test      rsi,rsi
        je        near ptr M00_L02
        mov       rdx,rsi
        mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F68052D8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6804DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,20D2AC01FE8
+       mov       rcx,2C09F401FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9F6875E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9F6877750]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        mov       [rsp+38],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rsi+8],rcx
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       ecx,10
        call      qword ptr [7FF9F6054F30]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF9F5C80FE0
+       mov       r11,7FF9F5C81098
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        jmp       qword ptr [7FF9F5DC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
 ; Total bytes of code 109
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,60
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       [rsp+50],rax
        mov       [rsp+58],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L00
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L00
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F7D8
+       mov       rdx,7FF9F6A908A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
        call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M02_L08
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],40
        jle       short M02_L02
        mov       r11,[rcx+40]
        test      r11,r11
        je        short M02_L02
        jmp       short M02_L03
 M02_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F7F8
+       mov       rdx,7FF9F6A908C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L03:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       esi,eax
        test      esi,esi
        je        near ptr M02_L15
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],48
        jle       short M02_L04
        mov       rcx,[rcx+48]
        test      rcx,rcx
        je        short M02_L04
        jmp       short M02_L05
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F810
+       mov       rdx,7FF9F6A908D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L05:
        movsxd    rdx,esi
        call      CORINFO_HELP_NEWARR_1_OBJ
        mov       rsi,rax
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],50
        jle       short M02_L06
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M02_L06
        jmp       short M02_L07
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F920
+       mov       rdx,7FF9F6A909E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L07:
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L09
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L09
        jmp       short M02_L10
 M02_L09:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F7E8
+       mov       rdx,7FF9F6A908B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A36D00]
+       call      qword ptr [7FF9F6A66370]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F7E8
+       mov       rdx,7FF9F6A908B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF9F6A36D78]
+       call      qword ptr [7FF9F6A663E8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F7E8
+       mov       rdx,7FF9F6A908B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A36E08]
+       call      qword ptr [7FF9F6A66478]
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],58
        jle       short M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M02_L16
        jmp       short M02_L17
 M02_L16:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F938
+       mov       rdx,7FF9F6A90A00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
        call      qword ptr [7FF9F626E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 521
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        vzeroupper
        mov       rax,[rcx+8]
        cmp       qword ptr [rax+10],0
        jne       short M03_L01
 M03_L00:
-       jmp       qword ptr [7FF9F68763A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF9F6877C90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF9F692D318]
+       vmulss    xmm0,xmm0,dword ptr [7FF9F6940A78]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF9F6876358]
+       jmp       qword ptr [7FF9F6877C48]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rsp+28],xmm4
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rbx,rcx
        mov       rsi,[rbx+280]
        test      rsi,rsi
        je        near ptr M00_L02
        mov       rdx,rsi
        mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F68052D8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6865530]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,20D2AC01FE8
+       mov       rcx,16AA9C01FF8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9F6875E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9F69D7750]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        mov       [rsp+38],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rsi+8],rcx
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       ecx,10
-       call      qword ptr [7FF9F6054F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF9F5C80FE0
+       mov       r11,7FF9F5C912D8
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
 M00_L04:
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L01
 ; Total bytes of code 207
 ; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       push      rbx
        test      rdx,rdx
-       je        short M01_L01
-       mov       rax,[rdx]
-       movzx     r8d,word ptr [rax+0E]
+       je        short M01_L02
+       mov       rbx,[rdx]
+       movzx     r8d,word ptr [rbx+0E]
        test      r8,r8
-       je        short M01_L04
-       mov       r10,[rax+38]
+       je        short M01_L01
+       mov       r10,[rbx+38]
        cmp       r8,4
-       jl        short M01_L03
+       jl        short M01_L04
 M01_L00:
        cmp       [r10],rcx
-       jne       short M01_L02
-M01_L01:
-       mov       rax,rdx
-       ret
-M01_L02:
+       je        short M01_L02
        cmp       [r10+8],rcx
-       je        short M01_L01
+       je        short M01_L02
        cmp       [r10+10],rcx
-       je        short M01_L01
+       je        short M01_L02
        cmp       [r10+18],rcx
-       je        short M01_L01
+       je        short M01_L02
        add       r10,20
        add       r8,0FFFFFFFFFFFFFFFC
        cmp       r8,4
        jge       short M01_L00
        test      r8,r8
-       je        short M01_L04
+       jne       short M01_L04
+M01_L01:
+       test      dword ptr [rbx],406C0000
+       jne       short M01_L03
+       xor       edx,edx
+M01_L02:
+       mov       rax,rdx
+       pop       rbx
+       ret
 M01_L03:
+       pop       rbx
+       jmp       qword ptr [7FF9F5DD4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+M01_L04:
        cmp       [r10],rcx
-       je        short M01_L01
+       je        short M01_L02
        add       r10,8
        dec       r8
        test      r8,r8
-       jg        short M01_L03
-M01_L04:
-       test      dword ptr [rax],406C0000
-       jne       short M01_L05
-       xor       edx,edx
+       jg        short M01_L04
        jmp       short M01_L01
-M01_L05:
-       jmp       qword ptr [7FF9F5DC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
-; Total bytes of code 109
+; Total bytes of code 112
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,60
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       [rsp+50],rax
        mov       [rsp+58],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L00
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L00
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F7D8
+       mov       rdx,7FF9F6AC7448
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M02_L08
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],40
        jle       short M02_L02
        mov       r11,[rcx+40]
        test      r11,r11
        je        short M02_L02
        jmp       short M02_L03
 M02_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F7F8
+       mov       rdx,7FF9F6AC7468
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L03:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       esi,eax
        test      esi,esi
        je        near ptr M02_L15
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],48
        jle       short M02_L04
        mov       rcx,[rcx+48]
        test      rcx,rcx
        je        short M02_L04
        jmp       short M02_L05
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F810
+       mov       rdx,7FF9F6AC7480
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L05:
        movsxd    rdx,esi
        call      CORINFO_HELP_NEWARR_1_OBJ
        mov       rsi,rax
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],50
        jle       short M02_L06
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M02_L06
        jmp       short M02_L07
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F920
+       mov       rdx,7FF9F6AC7590
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L07:
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L09
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L09
        jmp       short M02_L10
 M02_L09:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F7E8
+       mov       rdx,7FF9F6AC7458
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A36D00]
+       call      qword ptr [7FF9F6AD4180]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F7E8
+       mov       rdx,7FF9F6AC7458
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF9F6A36D78]
+       call      qword ptr [7FF9F6AD41F8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F7E8
+       mov       rdx,7FF9F6AC7458
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A36E08]
+       call      qword ptr [7FF9F6AD4288]
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],58
        jle       short M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M02_L16
        jmp       short M02_L17
 M02_L16:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F938
+       mov       rdx,7FF9F6AC75A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9F626E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9F627E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 521
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        vzeroupper
        mov       rax,[rcx+8]
        cmp       qword ptr [rax+10],0
        jne       short M03_L01
 M03_L00:
-       jmp       qword ptr [7FF9F68763A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF9F69D7C90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF9F692D318]
+       vmulss    xmm0,xmm0,dword ptr [7FF9F6951A58]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF9F6876358]
+       jmp       qword ptr [7FF9F69D7C48]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rsp+28],xmm4
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rbx,rcx
        mov       rsi,[rbx+280]
        test      rsi,rsi
        je        near ptr M00_L02
        mov       rdx,rsi
        mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F68052D8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F68D7CC0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,20D2AC01FE8
+       mov       rcx,249A28127D0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9F6875E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9F6A7CC00]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        mov       [rsp+38],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rsi+8],rcx
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       ecx,10
        call      qword ptr [7FF9F6054F30]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF9F5C80FE0
+       mov       r11,7FF9F5C81BA0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
 M00_L04:
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L01
 ; Total bytes of code 207
 ; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rdx,rdx
        je        short M01_L01
-       mov       rax,[rdx]
-       movzx     r8d,word ptr [rax+0E]
-       test      r8,r8
-       je        short M01_L04
-       mov       r10,[rax+38]
-       cmp       r8,4
-       jl        short M01_L03
+       mov       r8,[rdx]
+       movzx     r10d,word ptr [r8+0E]
+       test      r10,r10
+       je        short M01_L05
+       mov       r9,[r8+38]
+       cmp       r10,4
+       jl        short M01_L04
 M01_L00:
-       cmp       [r10],rcx
-       jne       short M01_L02
+       cmp       [r9],rcx
+       je        short M01_L01
+       cmp       [r9+8],rcx
+       je        short M01_L01
+       cmp       [r9+10],rcx
+       je        short M01_L01
+       cmp       [r9+18],rcx
+       je        short M01_L01
+       add       r9,20
+       add       r10,0FFFFFFFFFFFFFFFC
+       cmp       r10,4
+       jl        short M01_L03
+       jmp       short M01_L00
 M01_L01:
        mov       rax,rdx
        ret
 M01_L02:
-       cmp       [r10+8],rcx
-       je        short M01_L01
-       cmp       [r10+10],rcx
-       je        short M01_L01
-       cmp       [r10+18],rcx
-       je        short M01_L01
-       add       r10,20
-       add       r8,0FFFFFFFFFFFFFFFC
-       cmp       r8,4
-       jge       short M01_L00
-       test      r8,r8
-       je        short M01_L04
+       jmp       qword ptr [7FF9F5DC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
 M01_L03:
-       cmp       [r10],rcx
-       je        short M01_L01
-       add       r10,8
-       dec       r8
-       test      r8,r8
-       jg        short M01_L03
+       test      r10,r10
+       je        short M01_L05
 M01_L04:
-       test      dword ptr [rax],406C0000
-       jne       short M01_L05
+       cmp       [r9],rcx
+       je        short M01_L01
+       add       r9,8
+       dec       r10
+       test      r10,r10
+       jg        short M01_L04
+M01_L05:
+       test      dword ptr [r8],406C0000
+       jne       short M01_L02
        xor       edx,edx
        jmp       short M01_L01
-M01_L05:
-       jmp       qword ptr [7FF9F5DC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
-; Total bytes of code 109
+; Total bytes of code 112
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,60
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       [rsp+50],rax
        mov       [rsp+58],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L00
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L00
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F7D8
+       mov       rdx,7FF9F6AAE3C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
        call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M02_L08
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],40
        jle       short M02_L02
        mov       r11,[rcx+40]
        test      r11,r11
        je        short M02_L02
        jmp       short M02_L03
 M02_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F7F8
+       mov       rdx,7FF9F6AAE3E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L03:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       esi,eax
        test      esi,esi
        je        near ptr M02_L15
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],48
        jle       short M02_L04
        mov       rcx,[rcx+48]
        test      rcx,rcx
        je        short M02_L04
        jmp       short M02_L05
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F810
+       mov       rdx,7FF9F6AAE3F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L05:
        movsxd    rdx,esi
        call      CORINFO_HELP_NEWARR_1_OBJ
        mov       rsi,rax
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],50
        jle       short M02_L06
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M02_L06
        jmp       short M02_L07
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F920
+       mov       rdx,7FF9F6AAE508
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L07:
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L09
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L09
        jmp       short M02_L10
 M02_L09:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F7E8
+       mov       rdx,7FF9F6AAE3D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A36D00]
+       call      qword ptr [7FF9F6AC5ED8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F7E8
+       mov       rdx,7FF9F6AAE3D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF9F6A36D78]
+       call      qword ptr [7FF9F6AC5F50]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F7E8
+       mov       rdx,7FF9F6AAE3D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A36E08]
+       call      qword ptr [7FF9F6AC5FE0]
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],58
        jle       short M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M02_L16
        jmp       short M02_L17
 M02_L16:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A1F938
+       mov       rdx,7FF9F6AAE520
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
        call      qword ptr [7FF9F626E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 521
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        vzeroupper
        mov       rax,[rcx+8]
        cmp       qword ptr [rax+10],0
        jne       short M03_L01
 M03_L00:
-       jmp       qword ptr [7FF9F68763A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF9F6A7D140]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF9F692D318]
+       vmulss    xmm0,xmm0,dword ptr [7FF9F6AD9B78]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF9F6876358]
+       jmp       qword ptr [7FF9F6A7D0F8]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rsp+28],xmm4
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rbx,rcx
        mov       rsi,[rbx+280]
        test      rsi,rsi
        je        near ptr M00_L02
        mov       rdx,rsi
        mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F68252D8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F67F59C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,17830C01FE8
+       mov       rcx,2E4DC001FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9F6896580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9F68667F0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        mov       [rsp+38],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rsi+8],rcx
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       ecx,10
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6044F30]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF9F5CA0FF0
+       mov       r11,7FF9F5C70FE0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FF9F5DE4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FF9F5DB4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
 ; Total bytes of code 109
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,60
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       [rsp+50],rax
        mov       [rsp+58],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L00
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L00
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FAA8
+       mov       rdx,7FF9F6A0F440
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M02_L08
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],40
        jle       short M02_L02
        mov       r11,[rcx+40]
        test      r11,r11
        je        short M02_L02
        jmp       short M02_L03
 M02_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FAC8
+       mov       rdx,7FF9F6A0F460
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L03:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       esi,eax
        test      esi,esi
        je        near ptr M02_L15
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],48
        jle       short M02_L04
        mov       rcx,[rcx+48]
        test      rcx,rcx
        je        short M02_L04
        jmp       short M02_L05
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FAE0
+       mov       rdx,7FF9F6A0F478
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L05:
        movsxd    rdx,esi
        call      CORINFO_HELP_NEWARR_1_OBJ
        mov       rsi,rax
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],50
        jle       short M02_L06
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M02_L06
        jmp       short M02_L07
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FBF0
+       mov       rdx,7FF9F6A0F588
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L07:
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L09
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L09
        jmp       short M02_L10
 M02_L09:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FAB8
+       mov       rdx,7FF9F6A0F450
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A56D00]
+       call      qword ptr [7FF9F6A17288]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FAB8
+       mov       rdx,7FF9F6A0F450
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF9F6A56D78]
+       call      qword ptr [7FF9F6A17300]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FAB8
+       mov       rdx,7FF9F6A0F450
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A56E08]
+       call      qword ptr [7FF9F6A17390]
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],58
        jle       short M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M02_L16
        jmp       short M02_L17
 M02_L16:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FC08
+       mov       rdx,7FF9F6A0F5A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9F628E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9F625E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 521
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        vzeroupper
        mov       rax,[rcx+8]
        cmp       qword ptr [rax+10],0
        jne       short M03_L01
 M03_L00:
-       jmp       qword ptr [7FF9F6896AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF9F6866D30]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF9F695D6F8]
+       vmulss    xmm0,xmm0,dword ptr [7FF9F691D2B8]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF9F6896A78]
+       jmp       qword ptr [7FF9F6866CE8]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rsp+28],xmm4
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rbx,rcx
        mov       rsi,[rbx+280]
        test      rsi,rsi
        je        near ptr M00_L02
        mov       rdx,rsi
        mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F68252D8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6804DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,17830C01FE8
+       mov       rcx,2C09F401FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9F6896580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9F6877750]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        mov       [rsp+38],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rsi+8],rcx
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       ecx,10
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6054F30]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF9F5CA0FF0
+       mov       r11,7FF9F5C81098
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FF9F5DE4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FF9F5DC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
 ; Total bytes of code 109
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,60
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       [rsp+50],rax
        mov       [rsp+58],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L00
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L00
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FAA8
+       mov       rdx,7FF9F6A908A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M02_L08
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],40
        jle       short M02_L02
        mov       r11,[rcx+40]
        test      r11,r11
        je        short M02_L02
        jmp       short M02_L03
 M02_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FAC8
+       mov       rdx,7FF9F6A908C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L03:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       esi,eax
        test      esi,esi
        je        near ptr M02_L15
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],48
        jle       short M02_L04
        mov       rcx,[rcx+48]
        test      rcx,rcx
        je        short M02_L04
        jmp       short M02_L05
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FAE0
+       mov       rdx,7FF9F6A908D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L05:
        movsxd    rdx,esi
        call      CORINFO_HELP_NEWARR_1_OBJ
        mov       rsi,rax
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],50
        jle       short M02_L06
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M02_L06
        jmp       short M02_L07
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FBF0
+       mov       rdx,7FF9F6A909E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L07:
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L09
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L09
        jmp       short M02_L10
 M02_L09:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FAB8
+       mov       rdx,7FF9F6A908B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A56D00]
+       call      qword ptr [7FF9F6A66370]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FAB8
+       mov       rdx,7FF9F6A908B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF9F6A56D78]
+       call      qword ptr [7FF9F6A663E8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FAB8
+       mov       rdx,7FF9F6A908B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A56E08]
+       call      qword ptr [7FF9F6A66478]
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],58
        jle       short M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M02_L16
        jmp       short M02_L17
 M02_L16:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FC08
+       mov       rdx,7FF9F6A90A00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9F628E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9F626E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 521
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        vzeroupper
        mov       rax,[rcx+8]
        cmp       qword ptr [rax+10],0
        jne       short M03_L01
 M03_L00:
-       jmp       qword ptr [7FF9F6896AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF9F6877C90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF9F695D6F8]
+       vmulss    xmm0,xmm0,dword ptr [7FF9F6940A78]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF9F6896A78]
+       jmp       qword ptr [7FF9F6877C48]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rsp+28],xmm4
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rbx,rcx
        mov       rsi,[rbx+280]
        test      rsi,rsi
        je        near ptr M00_L02
        mov       rdx,rsi
        mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F68252D8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6865530]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,17830C01FE8
+       mov       rcx,16AA9C01FF8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9F6896580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9F69D7750]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        mov       [rsp+38],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rsi+8],rcx
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       ecx,10
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF9F5CA0FF0
+       mov       r11,7FF9F5C912D8
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
 M00_L04:
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L01
 ; Total bytes of code 207
 ; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       push      rbx
        test      rdx,rdx
-       je        short M01_L01
-       mov       rax,[rdx]
-       movzx     r8d,word ptr [rax+0E]
+       je        short M01_L02
+       mov       rbx,[rdx]
+       movzx     r8d,word ptr [rbx+0E]
        test      r8,r8
-       je        short M01_L04
-       mov       r10,[rax+38]
+       je        short M01_L01
+       mov       r10,[rbx+38]
        cmp       r8,4
-       jl        short M01_L03
+       jl        short M01_L04
 M01_L00:
        cmp       [r10],rcx
-       jne       short M01_L02
-M01_L01:
-       mov       rax,rdx
-       ret
-M01_L02:
+       je        short M01_L02
        cmp       [r10+8],rcx
-       je        short M01_L01
+       je        short M01_L02
        cmp       [r10+10],rcx
-       je        short M01_L01
+       je        short M01_L02
        cmp       [r10+18],rcx
-       je        short M01_L01
+       je        short M01_L02
        add       r10,20
        add       r8,0FFFFFFFFFFFFFFFC
        cmp       r8,4
        jge       short M01_L00
        test      r8,r8
-       je        short M01_L04
+       jne       short M01_L04
+M01_L01:
+       test      dword ptr [rbx],406C0000
+       jne       short M01_L03
+       xor       edx,edx
+M01_L02:
+       mov       rax,rdx
+       pop       rbx
+       ret
 M01_L03:
+       pop       rbx
+       jmp       qword ptr [7FF9F5DD4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+M01_L04:
        cmp       [r10],rcx
-       je        short M01_L01
+       je        short M01_L02
        add       r10,8
        dec       r8
        test      r8,r8
-       jg        short M01_L03
-M01_L04:
-       test      dword ptr [rax],406C0000
-       jne       short M01_L05
-       xor       edx,edx
+       jg        short M01_L04
        jmp       short M01_L01
-M01_L05:
-       jmp       qword ptr [7FF9F5DE4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
-; Total bytes of code 109
+; Total bytes of code 112
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,60
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       [rsp+50],rax
        mov       [rsp+58],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L00
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L00
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FAA8
+       mov       rdx,7FF9F6AC7448
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M02_L08
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],40
        jle       short M02_L02
        mov       r11,[rcx+40]
        test      r11,r11
        je        short M02_L02
        jmp       short M02_L03
 M02_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FAC8
+       mov       rdx,7FF9F6AC7468
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L03:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       esi,eax
        test      esi,esi
        je        near ptr M02_L15
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],48
        jle       short M02_L04
        mov       rcx,[rcx+48]
        test      rcx,rcx
        je        short M02_L04
        jmp       short M02_L05
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FAE0
+       mov       rdx,7FF9F6AC7480
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L05:
        movsxd    rdx,esi
        call      CORINFO_HELP_NEWARR_1_OBJ
        mov       rsi,rax
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],50
        jle       short M02_L06
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M02_L06
        jmp       short M02_L07
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FBF0
+       mov       rdx,7FF9F6AC7590
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L07:
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L09
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L09
        jmp       short M02_L10
 M02_L09:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FAB8
+       mov       rdx,7FF9F6AC7458
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A56D00]
+       call      qword ptr [7FF9F6AD4180]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FAB8
+       mov       rdx,7FF9F6AC7458
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF9F6A56D78]
+       call      qword ptr [7FF9F6AD41F8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FAB8
+       mov       rdx,7FF9F6AC7458
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A56E08]
+       call      qword ptr [7FF9F6AD4288]
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],58
        jle       short M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M02_L16
        jmp       short M02_L17
 M02_L16:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FC08
+       mov       rdx,7FF9F6AC75A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9F628E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9F627E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 521
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        vzeroupper
        mov       rax,[rcx+8]
        cmp       qword ptr [rax+10],0
        jne       short M03_L01
 M03_L00:
-       jmp       qword ptr [7FF9F6896AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF9F69D7C90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF9F695D6F8]
+       vmulss    xmm0,xmm0,dword ptr [7FF9F6951A58]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF9F6896A78]
+       jmp       qword ptr [7FF9F69D7C48]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rsp+28],xmm4
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rbx,rcx
        mov       rsi,[rbx+280]
        test      rsi,rsi
        je        near ptr M00_L02
        mov       rdx,rsi
        mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F68252D8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F68D7CC0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,17830C01FE8
+       mov       rcx,249A28127D0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9F6896580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9F6A7CC00]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        mov       [rsp+38],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rsi+8],rcx
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       ecx,10
-       call      qword ptr [7FF9F6074F30]
+       call      qword ptr [7FF9F6054F30]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF9F5CA0FF0
+       mov       r11,7FF9F5C81BA0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
 M00_L04:
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L01
 ; Total bytes of code 207
 ; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rdx,rdx
        je        short M01_L01
-       mov       rax,[rdx]
-       movzx     r8d,word ptr [rax+0E]
-       test      r8,r8
-       je        short M01_L04
-       mov       r10,[rax+38]
-       cmp       r8,4
-       jl        short M01_L03
+       mov       r8,[rdx]
+       movzx     r10d,word ptr [r8+0E]
+       test      r10,r10
+       je        short M01_L05
+       mov       r9,[r8+38]
+       cmp       r10,4
+       jl        short M01_L04
 M01_L00:
-       cmp       [r10],rcx
-       jne       short M01_L02
+       cmp       [r9],rcx
+       je        short M01_L01
+       cmp       [r9+8],rcx
+       je        short M01_L01
+       cmp       [r9+10],rcx
+       je        short M01_L01
+       cmp       [r9+18],rcx
+       je        short M01_L01
+       add       r9,20
+       add       r10,0FFFFFFFFFFFFFFFC
+       cmp       r10,4
+       jl        short M01_L03
+       jmp       short M01_L00
 M01_L01:
        mov       rax,rdx
        ret
 M01_L02:
-       cmp       [r10+8],rcx
-       je        short M01_L01
-       cmp       [r10+10],rcx
-       je        short M01_L01
-       cmp       [r10+18],rcx
-       je        short M01_L01
-       add       r10,20
-       add       r8,0FFFFFFFFFFFFFFFC
-       cmp       r8,4
-       jge       short M01_L00
-       test      r8,r8
-       je        short M01_L04
+       jmp       qword ptr [7FF9F5DC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
 M01_L03:
-       cmp       [r10],rcx
-       je        short M01_L01
-       add       r10,8
-       dec       r8
-       test      r8,r8
-       jg        short M01_L03
+       test      r10,r10
+       je        short M01_L05
 M01_L04:
-       test      dword ptr [rax],406C0000
-       jne       short M01_L05
+       cmp       [r9],rcx
+       je        short M01_L01
+       add       r9,8
+       dec       r10
+       test      r10,r10
+       jg        short M01_L04
+M01_L05:
+       test      dword ptr [r8],406C0000
+       jne       short M01_L02
        xor       edx,edx
        jmp       short M01_L01
-M01_L05:
-       jmp       qword ptr [7FF9F5DE4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
-; Total bytes of code 109
+; Total bytes of code 112
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,60
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       [rsp+50],rax
        mov       [rsp+58],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L00
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L00
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FAA8
+       mov       rdx,7FF9F6AAE3C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M02_L08
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],40
        jle       short M02_L02
        mov       r11,[rcx+40]
        test      r11,r11
        je        short M02_L02
        jmp       short M02_L03
 M02_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FAC8
+       mov       rdx,7FF9F6AAE3E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L03:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       esi,eax
        test      esi,esi
        je        near ptr M02_L15
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],48
        jle       short M02_L04
        mov       rcx,[rcx+48]
        test      rcx,rcx
        je        short M02_L04
        jmp       short M02_L05
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FAE0
+       mov       rdx,7FF9F6AAE3F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L05:
        movsxd    rdx,esi
        call      CORINFO_HELP_NEWARR_1_OBJ
        mov       rsi,rax
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],50
        jle       short M02_L06
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M02_L06
        jmp       short M02_L07
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FBF0
+       mov       rdx,7FF9F6AAE508
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L07:
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L09
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L09
        jmp       short M02_L10
 M02_L09:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FAB8
+       mov       rdx,7FF9F6AAE3D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A56D00]
+       call      qword ptr [7FF9F6AC5ED8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FAB8
+       mov       rdx,7FF9F6AAE3D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF9F6A56D78]
+       call      qword ptr [7FF9F6AC5F50]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FAB8
+       mov       rdx,7FF9F6AAE3D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A56E08]
+       call      qword ptr [7FF9F6AC5FE0]
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],58
        jle       short M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M02_L16
        jmp       short M02_L17
 M02_L16:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A3FC08
+       mov       rdx,7FF9F6AAE520
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9F628E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9F626E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 521
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        vzeroupper
        mov       rax,[rcx+8]
        cmp       qword ptr [rax+10],0
        jne       short M03_L01
 M03_L00:
-       jmp       qword ptr [7FF9F6896AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF9F6A7D140]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF9F695D6F8]
+       vmulss    xmm0,xmm0,dword ptr [7FF9F6AD9B78]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF9F6896A78]
+       jmp       qword ptr [7FF9F6A7D0F8]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rsp+28],xmm4
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rbx,rcx
        mov       rsi,[rbx+280]
        test      rsi,rsi
        je        near ptr M00_L02
        mov       rdx,rsi
        mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F67F59C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6804DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,2E4DC001FE8
+       mov       rcx,2C09F401FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9F68667F0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9F6877750]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        mov       [rsp+38],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rsi+8],rcx
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       ecx,10
-       call      qword ptr [7FF9F6044F30]
+       call      qword ptr [7FF9F6054F30]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF9F5C70FE0
+       mov       r11,7FF9F5C81098
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FF9F5DB4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FF9F5DC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
 ; Total bytes of code 109
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,60
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       [rsp+50],rax
        mov       [rsp+58],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L00
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L00
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A0F440
+       mov       rdx,7FF9F6A908A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M02_L08
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],40
        jle       short M02_L02
        mov       r11,[rcx+40]
        test      r11,r11
        je        short M02_L02
        jmp       short M02_L03
 M02_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A0F460
+       mov       rdx,7FF9F6A908C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L03:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       esi,eax
        test      esi,esi
        je        near ptr M02_L15
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],48
        jle       short M02_L04
        mov       rcx,[rcx+48]
        test      rcx,rcx
        je        short M02_L04
        jmp       short M02_L05
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A0F478
+       mov       rdx,7FF9F6A908D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L05:
        movsxd    rdx,esi
        call      CORINFO_HELP_NEWARR_1_OBJ
        mov       rsi,rax
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],50
        jle       short M02_L06
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M02_L06
        jmp       short M02_L07
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A0F588
+       mov       rdx,7FF9F6A909E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L07:
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L09
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L09
        jmp       short M02_L10
 M02_L09:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A0F450
+       mov       rdx,7FF9F6A908B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A17288]
+       call      qword ptr [7FF9F6A66370]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A0F450
+       mov       rdx,7FF9F6A908B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF9F6A17300]
+       call      qword ptr [7FF9F6A663E8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A0F450
+       mov       rdx,7FF9F6A908B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A17390]
+       call      qword ptr [7FF9F6A66478]
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],58
        jle       short M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M02_L16
        jmp       short M02_L17
 M02_L16:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A0F5A0
+       mov       rdx,7FF9F6A90A00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9F625E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9F626E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 521
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        vzeroupper
        mov       rax,[rcx+8]
        cmp       qword ptr [rax+10],0
        jne       short M03_L01
 M03_L00:
-       jmp       qword ptr [7FF9F6866D30]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF9F6877C90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF9F691D2B8]
+       vmulss    xmm0,xmm0,dword ptr [7FF9F6940A78]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF9F6866CE8]
+       jmp       qword ptr [7FF9F6877C48]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rsp+28],xmm4
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rbx,rcx
        mov       rsi,[rbx+280]
        test      rsi,rsi
        je        near ptr M00_L02
        mov       rdx,rsi
        mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F67F59C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6865530]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,2E4DC001FE8
+       mov       rcx,16AA9C01FF8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9F68667F0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9F69D7750]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        mov       [rsp+38],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rsi+8],rcx
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       ecx,10
-       call      qword ptr [7FF9F6044F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF9F5C70FE0
+       mov       r11,7FF9F5C912D8
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
 M00_L04:
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L01
 ; Total bytes of code 207
 ; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       push      rbx
        test      rdx,rdx
-       je        short M01_L01
-       mov       rax,[rdx]
-       movzx     r8d,word ptr [rax+0E]
+       je        short M01_L02
+       mov       rbx,[rdx]
+       movzx     r8d,word ptr [rbx+0E]
        test      r8,r8
-       je        short M01_L04
-       mov       r10,[rax+38]
+       je        short M01_L01
+       mov       r10,[rbx+38]
        cmp       r8,4
-       jl        short M01_L03
+       jl        short M01_L04
 M01_L00:
        cmp       [r10],rcx
-       jne       short M01_L02
-M01_L01:
-       mov       rax,rdx
-       ret
-M01_L02:
+       je        short M01_L02
        cmp       [r10+8],rcx
-       je        short M01_L01
+       je        short M01_L02
        cmp       [r10+10],rcx
-       je        short M01_L01
+       je        short M01_L02
        cmp       [r10+18],rcx
-       je        short M01_L01
+       je        short M01_L02
        add       r10,20
        add       r8,0FFFFFFFFFFFFFFFC
        cmp       r8,4
        jge       short M01_L00
        test      r8,r8
-       je        short M01_L04
+       jne       short M01_L04
+M01_L01:
+       test      dword ptr [rbx],406C0000
+       jne       short M01_L03
+       xor       edx,edx
+M01_L02:
+       mov       rax,rdx
+       pop       rbx
+       ret
 M01_L03:
+       pop       rbx
+       jmp       qword ptr [7FF9F5DD4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+M01_L04:
        cmp       [r10],rcx
-       je        short M01_L01
+       je        short M01_L02
        add       r10,8
        dec       r8
        test      r8,r8
-       jg        short M01_L03
-M01_L04:
-       test      dword ptr [rax],406C0000
-       jne       short M01_L05
-       xor       edx,edx
+       jg        short M01_L04
        jmp       short M01_L01
-M01_L05:
-       jmp       qword ptr [7FF9F5DB4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
-; Total bytes of code 109
+; Total bytes of code 112
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,60
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       [rsp+50],rax
        mov       [rsp+58],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L00
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L00
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A0F440
+       mov       rdx,7FF9F6AC7448
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M02_L08
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],40
        jle       short M02_L02
        mov       r11,[rcx+40]
        test      r11,r11
        je        short M02_L02
        jmp       short M02_L03
 M02_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A0F460
+       mov       rdx,7FF9F6AC7468
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L03:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       esi,eax
        test      esi,esi
        je        near ptr M02_L15
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],48
        jle       short M02_L04
        mov       rcx,[rcx+48]
        test      rcx,rcx
        je        short M02_L04
        jmp       short M02_L05
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A0F478
+       mov       rdx,7FF9F6AC7480
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L05:
        movsxd    rdx,esi
        call      CORINFO_HELP_NEWARR_1_OBJ
        mov       rsi,rax
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],50
        jle       short M02_L06
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M02_L06
        jmp       short M02_L07
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A0F588
+       mov       rdx,7FF9F6AC7590
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L07:
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L09
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L09
        jmp       short M02_L10
 M02_L09:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A0F450
+       mov       rdx,7FF9F6AC7458
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A17288]
+       call      qword ptr [7FF9F6AD4180]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A0F450
+       mov       rdx,7FF9F6AC7458
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF9F6A17300]
+       call      qword ptr [7FF9F6AD41F8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A0F450
+       mov       rdx,7FF9F6AC7458
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A17390]
+       call      qword ptr [7FF9F6AD4288]
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],58
        jle       short M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M02_L16
        jmp       short M02_L17
 M02_L16:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A0F5A0
+       mov       rdx,7FF9F6AC75A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9F625E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9F627E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 521
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        vzeroupper
        mov       rax,[rcx+8]
        cmp       qword ptr [rax+10],0
        jne       short M03_L01
 M03_L00:
-       jmp       qword ptr [7FF9F6866D30]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF9F69D7C90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF9F691D2B8]
+       vmulss    xmm0,xmm0,dword ptr [7FF9F6951A58]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF9F6866CE8]
+       jmp       qword ptr [7FF9F69D7C48]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rsp+28],xmm4
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rbx,rcx
        mov       rsi,[rbx+280]
        test      rsi,rsi
        je        near ptr M00_L02
        mov       rdx,rsi
        mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F67F59C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F68D7CC0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,2E4DC001FE8
+       mov       rcx,249A28127D0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9F68667F0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9F6A7CC00]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        mov       [rsp+38],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rsi+8],rcx
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       ecx,10
-       call      qword ptr [7FF9F6044F30]
+       call      qword ptr [7FF9F6054F30]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF9F5C70FE0
+       mov       r11,7FF9F5C81BA0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
 M00_L04:
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L01
 ; Total bytes of code 207
 ; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rdx,rdx
        je        short M01_L01
-       mov       rax,[rdx]
-       movzx     r8d,word ptr [rax+0E]
-       test      r8,r8
-       je        short M01_L04
-       mov       r10,[rax+38]
-       cmp       r8,4
-       jl        short M01_L03
+       mov       r8,[rdx]
+       movzx     r10d,word ptr [r8+0E]
+       test      r10,r10
+       je        short M01_L05
+       mov       r9,[r8+38]
+       cmp       r10,4
+       jl        short M01_L04
 M01_L00:
-       cmp       [r10],rcx
-       jne       short M01_L02
+       cmp       [r9],rcx
+       je        short M01_L01
+       cmp       [r9+8],rcx
+       je        short M01_L01
+       cmp       [r9+10],rcx
+       je        short M01_L01
+       cmp       [r9+18],rcx
+       je        short M01_L01
+       add       r9,20
+       add       r10,0FFFFFFFFFFFFFFFC
+       cmp       r10,4
+       jl        short M01_L03
+       jmp       short M01_L00
 M01_L01:
        mov       rax,rdx
        ret
 M01_L02:
-       cmp       [r10+8],rcx
-       je        short M01_L01
-       cmp       [r10+10],rcx
-       je        short M01_L01
-       cmp       [r10+18],rcx
-       je        short M01_L01
-       add       r10,20
-       add       r8,0FFFFFFFFFFFFFFFC
-       cmp       r8,4
-       jge       short M01_L00
-       test      r8,r8
-       je        short M01_L04
+       jmp       qword ptr [7FF9F5DC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
 M01_L03:
-       cmp       [r10],rcx
-       je        short M01_L01
-       add       r10,8
-       dec       r8
-       test      r8,r8
-       jg        short M01_L03
+       test      r10,r10
+       je        short M01_L05
 M01_L04:
-       test      dword ptr [rax],406C0000
-       jne       short M01_L05
+       cmp       [r9],rcx
+       je        short M01_L01
+       add       r9,8
+       dec       r10
+       test      r10,r10
+       jg        short M01_L04
+M01_L05:
+       test      dword ptr [r8],406C0000
+       jne       short M01_L02
        xor       edx,edx
        jmp       short M01_L01
-M01_L05:
-       jmp       qword ptr [7FF9F5DB4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
-; Total bytes of code 109
+; Total bytes of code 112
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,60
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       [rsp+50],rax
        mov       [rsp+58],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L00
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L00
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A0F440
+       mov       rdx,7FF9F6AAE3C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M02_L08
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],40
        jle       short M02_L02
        mov       r11,[rcx+40]
        test      r11,r11
        je        short M02_L02
        jmp       short M02_L03
 M02_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A0F460
+       mov       rdx,7FF9F6AAE3E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L03:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       esi,eax
        test      esi,esi
        je        near ptr M02_L15
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],48
        jle       short M02_L04
        mov       rcx,[rcx+48]
        test      rcx,rcx
        je        short M02_L04
        jmp       short M02_L05
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A0F478
+       mov       rdx,7FF9F6AAE3F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L05:
        movsxd    rdx,esi
        call      CORINFO_HELP_NEWARR_1_OBJ
        mov       rsi,rax
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],50
        jle       short M02_L06
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M02_L06
        jmp       short M02_L07
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A0F588
+       mov       rdx,7FF9F6AAE508
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L07:
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L09
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L09
        jmp       short M02_L10
 M02_L09:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A0F450
+       mov       rdx,7FF9F6AAE3D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A17288]
+       call      qword ptr [7FF9F6AC5ED8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A0F450
+       mov       rdx,7FF9F6AAE3D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF9F6A17300]
+       call      qword ptr [7FF9F6AC5F50]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A0F450
+       mov       rdx,7FF9F6AAE3D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A17390]
+       call      qword ptr [7FF9F6AC5FE0]
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],58
        jle       short M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M02_L16
        jmp       short M02_L17
 M02_L16:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A0F5A0
+       mov       rdx,7FF9F6AAE520
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9F625E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9F626E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 521
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        vzeroupper
        mov       rax,[rcx+8]
        cmp       qword ptr [rax+10],0
        jne       short M03_L01
 M03_L00:
-       jmp       qword ptr [7FF9F6866D30]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF9F6A7D140]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF9F691D2B8]
+       vmulss    xmm0,xmm0,dword ptr [7FF9F6AD9B78]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF9F6866CE8]
+       jmp       qword ptr [7FF9F6A7D0F8]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rsp+28],xmm4
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rbx,rcx
        mov       rsi,[rbx+280]
        test      rsi,rsi
        je        near ptr M00_L02
        mov       rdx,rsi
        mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6804DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F6865530]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,2C09F401FE8
+       mov       rcx,16AA9C01FF8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9F6877750]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9F69D7750]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        mov       [rsp+38],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rsi+8],rcx
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       ecx,10
-       call      qword ptr [7FF9F6054F30]
+       call      qword ptr [7FF9F6064F30]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF9F5C81098
+       mov       r11,7FF9F5C912D8
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
 M00_L04:
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L01
 ; Total bytes of code 207
 ; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       push      rbx
        test      rdx,rdx
-       je        short M01_L01
-       mov       rax,[rdx]
-       movzx     r8d,word ptr [rax+0E]
+       je        short M01_L02
+       mov       rbx,[rdx]
+       movzx     r8d,word ptr [rbx+0E]
        test      r8,r8
-       je        short M01_L04
-       mov       r10,[rax+38]
+       je        short M01_L01
+       mov       r10,[rbx+38]
        cmp       r8,4
-       jl        short M01_L03
+       jl        short M01_L04
 M01_L00:
        cmp       [r10],rcx
-       jne       short M01_L02
-M01_L01:
-       mov       rax,rdx
-       ret
-M01_L02:
+       je        short M01_L02
        cmp       [r10+8],rcx
-       je        short M01_L01
+       je        short M01_L02
        cmp       [r10+10],rcx
-       je        short M01_L01
+       je        short M01_L02
        cmp       [r10+18],rcx
-       je        short M01_L01
+       je        short M01_L02
        add       r10,20
        add       r8,0FFFFFFFFFFFFFFFC
        cmp       r8,4
        jge       short M01_L00
        test      r8,r8
-       je        short M01_L04
+       jne       short M01_L04
+M01_L01:
+       test      dword ptr [rbx],406C0000
+       jne       short M01_L03
+       xor       edx,edx
+M01_L02:
+       mov       rax,rdx
+       pop       rbx
+       ret
 M01_L03:
+       pop       rbx
+       jmp       qword ptr [7FF9F5DD4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+M01_L04:
        cmp       [r10],rcx
-       je        short M01_L01
+       je        short M01_L02
        add       r10,8
        dec       r8
        test      r8,r8
-       jg        short M01_L03
-M01_L04:
-       test      dword ptr [rax],406C0000
-       jne       short M01_L05
-       xor       edx,edx
+       jg        short M01_L04
        jmp       short M01_L01
-M01_L05:
-       jmp       qword ptr [7FF9F5DC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
-; Total bytes of code 109
+; Total bytes of code 112
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,60
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       [rsp+50],rax
        mov       [rsp+58],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L00
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L00
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A908A0
+       mov       rdx,7FF9F6AC7448
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M02_L08
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],40
        jle       short M02_L02
        mov       r11,[rcx+40]
        test      r11,r11
        je        short M02_L02
        jmp       short M02_L03
 M02_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A908C0
+       mov       rdx,7FF9F6AC7468
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L03:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       esi,eax
        test      esi,esi
        je        near ptr M02_L15
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],48
        jle       short M02_L04
        mov       rcx,[rcx+48]
        test      rcx,rcx
        je        short M02_L04
        jmp       short M02_L05
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A908D8
+       mov       rdx,7FF9F6AC7480
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L05:
        movsxd    rdx,esi
        call      CORINFO_HELP_NEWARR_1_OBJ
        mov       rsi,rax
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],50
        jle       short M02_L06
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M02_L06
        jmp       short M02_L07
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A909E8
+       mov       rdx,7FF9F6AC7590
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L07:
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L09
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L09
        jmp       short M02_L10
 M02_L09:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A908B0
+       mov       rdx,7FF9F6AC7458
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A66370]
+       call      qword ptr [7FF9F6AD4180]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A908B0
+       mov       rdx,7FF9F6AC7458
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF9F6A663E8]
+       call      qword ptr [7FF9F6AD41F8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A908B0
+       mov       rdx,7FF9F6AC7458
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A66478]
+       call      qword ptr [7FF9F6AD4288]
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],58
        jle       short M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M02_L16
        jmp       short M02_L17
 M02_L16:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A90A00
+       mov       rdx,7FF9F6AC75A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9F626E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9F627E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 521
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        vzeroupper
        mov       rax,[rcx+8]
        cmp       qword ptr [rax+10],0
        jne       short M03_L01
 M03_L00:
-       jmp       qword ptr [7FF9F6877C90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF9F69D7C90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF9F6940A78]
+       vmulss    xmm0,xmm0,dword ptr [7FF9F6951A58]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF9F6877C48]
+       jmp       qword ptr [7FF9F69D7C48]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rsp+28],xmm4
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rbx,rcx
        mov       rsi,[rbx+280]
        test      rsi,rsi
        je        near ptr M00_L02
        mov       rdx,rsi
        mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6804DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F68D7CC0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,2C09F401FE8
+       mov       rcx,249A28127D0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9F6877750]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9F6A7CC00]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        mov       [rsp+38],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rsi+8],rcx
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       ecx,10
        call      qword ptr [7FF9F6054F30]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF9F5C81098
+       mov       r11,7FF9F5C81BA0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
 M00_L04:
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L01
 ; Total bytes of code 207
 ; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rdx,rdx
        je        short M01_L01
-       mov       rax,[rdx]
-       movzx     r8d,word ptr [rax+0E]
-       test      r8,r8
-       je        short M01_L04
-       mov       r10,[rax+38]
-       cmp       r8,4
-       jl        short M01_L03
+       mov       r8,[rdx]
+       movzx     r10d,word ptr [r8+0E]
+       test      r10,r10
+       je        short M01_L05
+       mov       r9,[r8+38]
+       cmp       r10,4
+       jl        short M01_L04
 M01_L00:
-       cmp       [r10],rcx
-       jne       short M01_L02
+       cmp       [r9],rcx
+       je        short M01_L01
+       cmp       [r9+8],rcx
+       je        short M01_L01
+       cmp       [r9+10],rcx
+       je        short M01_L01
+       cmp       [r9+18],rcx
+       je        short M01_L01
+       add       r9,20
+       add       r10,0FFFFFFFFFFFFFFFC
+       cmp       r10,4
+       jl        short M01_L03
+       jmp       short M01_L00
 M01_L01:
        mov       rax,rdx
        ret
 M01_L02:
-       cmp       [r10+8],rcx
-       je        short M01_L01
-       cmp       [r10+10],rcx
-       je        short M01_L01
-       cmp       [r10+18],rcx
-       je        short M01_L01
-       add       r10,20
-       add       r8,0FFFFFFFFFFFFFFFC
-       cmp       r8,4
-       jge       short M01_L00
-       test      r8,r8
-       je        short M01_L04
+       jmp       qword ptr [7FF9F5DC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
 M01_L03:
-       cmp       [r10],rcx
-       je        short M01_L01
-       add       r10,8
-       dec       r8
-       test      r8,r8
-       jg        short M01_L03
+       test      r10,r10
+       je        short M01_L05
 M01_L04:
-       test      dword ptr [rax],406C0000
-       jne       short M01_L05
+       cmp       [r9],rcx
+       je        short M01_L01
+       add       r9,8
+       dec       r10
+       test      r10,r10
+       jg        short M01_L04
+M01_L05:
+       test      dword ptr [r8],406C0000
+       jne       short M01_L02
        xor       edx,edx
        jmp       short M01_L01
-M01_L05:
-       jmp       qword ptr [7FF9F5DC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
-; Total bytes of code 109
+; Total bytes of code 112
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,60
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       [rsp+50],rax
        mov       [rsp+58],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L00
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L00
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A908A0
+       mov       rdx,7FF9F6AAE3C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
        call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M02_L08
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],40
        jle       short M02_L02
        mov       r11,[rcx+40]
        test      r11,r11
        je        short M02_L02
        jmp       short M02_L03
 M02_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A908C0
+       mov       rdx,7FF9F6AAE3E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L03:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       esi,eax
        test      esi,esi
        je        near ptr M02_L15
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],48
        jle       short M02_L04
        mov       rcx,[rcx+48]
        test      rcx,rcx
        je        short M02_L04
        jmp       short M02_L05
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A908D8
+       mov       rdx,7FF9F6AAE3F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L05:
        movsxd    rdx,esi
        call      CORINFO_HELP_NEWARR_1_OBJ
        mov       rsi,rax
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],50
        jle       short M02_L06
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M02_L06
        jmp       short M02_L07
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A909E8
+       mov       rdx,7FF9F6AAE508
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L07:
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L09
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L09
        jmp       short M02_L10
 M02_L09:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A908B0
+       mov       rdx,7FF9F6AAE3D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A66370]
+       call      qword ptr [7FF9F6AC5ED8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A908B0
+       mov       rdx,7FF9F6AAE3D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF9F6A663E8]
+       call      qword ptr [7FF9F6AC5F50]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A908B0
+       mov       rdx,7FF9F6AAE3D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6A66478]
+       call      qword ptr [7FF9F6AC5FE0]
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],58
        jle       short M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M02_L16
        jmp       short M02_L17
 M02_L16:
        mov       rcx,rbx
-       mov       rdx,7FF9F6A90A00
+       mov       rdx,7FF9F6AAE520
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
        call      qword ptr [7FF9F626E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 521
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        vzeroupper
        mov       rax,[rcx+8]
        cmp       qword ptr [rax+10],0
        jne       short M03_L01
 M03_L00:
-       jmp       qword ptr [7FF9F6877C90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF9F6A7D140]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF9F6940A78]
+       vmulss    xmm0,xmm0,dword ptr [7FF9F6AD9B78]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF9F6877C48]
+       jmp       qword ptr [7FF9F6A7D0F8]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rsp+28],xmm4
        xor       eax,eax
        mov       [rsp+38],rax
        mov       rbx,rcx
        mov       rsi,[rbx+280]
        test      rsi,rsi
        je        near ptr M00_L02
        mov       rdx,rsi
        mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FF9F5DD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF9F6865530]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9F68D7CC0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,16AA9C01FF8
+       mov       rcx,249A28127D0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF9F69D7750]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF9F6A7CC00]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        mov       [rsp+38],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+38]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [rsi+8],rcx
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 M00_L02:
        mov       ecx,10
-       call      qword ptr [7FF9F6064F30]
+       call      qword ptr [7FF9F6054F30]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF9F5C912D8
+       mov       r11,7FF9F5C81BA0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
 M00_L04:
        xor       esi,esi
        xor       edi,edi
        jmp       short M00_L01
 ; Total bytes of code 207
 ; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
-       push      rbx
        test      rdx,rdx
-       je        short M01_L02
-       mov       rbx,[rdx]
-       movzx     r8d,word ptr [rbx+0E]
-       test      r8,r8
        je        short M01_L01
-       mov       r10,[rbx+38]
-       cmp       r8,4
+       mov       r8,[rdx]
+       movzx     r10d,word ptr [r8+0E]
+       test      r10,r10
+       je        short M01_L05
+       mov       r9,[r8+38]
+       cmp       r10,4
        jl        short M01_L04
 M01_L00:
-       cmp       [r10],rcx
-       je        short M01_L02
-       cmp       [r10+8],rcx
-       je        short M01_L02
-       cmp       [r10+10],rcx
-       je        short M01_L02
-       cmp       [r10+18],rcx
-       je        short M01_L02
-       add       r10,20
-       add       r8,0FFFFFFFFFFFFFFFC
-       cmp       r8,4
-       jge       short M01_L00
-       test      r8,r8
-       jne       short M01_L04
+       cmp       [r9],rcx
+       je        short M01_L01
+       cmp       [r9+8],rcx
+       je        short M01_L01
+       cmp       [r9+10],rcx
+       je        short M01_L01
+       cmp       [r9+18],rcx
+       je        short M01_L01
+       add       r9,20
+       add       r10,0FFFFFFFFFFFFFFFC
+       cmp       r10,4
+       jl        short M01_L03
+       jmp       short M01_L00
 M01_L01:
-       test      dword ptr [rbx],406C0000
-       jne       short M01_L03
-       xor       edx,edx
-M01_L02:
        mov       rax,rdx
-       pop       rbx
        ret
+M01_L02:
+       jmp       qword ptr [7FF9F5DC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
 M01_L03:
-       pop       rbx
-       jmp       qword ptr [7FF9F5DD4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       test      r10,r10
+       je        short M01_L05
 M01_L04:
-       cmp       [r10],rcx
-       je        short M01_L02
-       add       r10,8
-       dec       r8
-       test      r8,r8
+       cmp       [r9],rcx
+       je        short M01_L01
+       add       r9,8
+       dec       r10
+       test      r10,r10
        jg        short M01_L04
+M01_L05:
+       test      dword ptr [r8],406C0000
+       jne       short M01_L02
+       xor       edx,edx
        jmp       short M01_L01
 ; Total bytes of code 112
 ; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,60
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       [rsp+50],rax
        mov       [rsp+58],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],30
        jle       short M02_L00
        mov       rcx,[rcx+30]
        test      rcx,rcx
        je        short M02_L00
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       rdx,7FF9F6AC7448
+       mov       rdx,7FF9F6AAE3C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF9F5DD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF9F5DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        mov       rdi,rax
        test      rdi,rdi
        je        near ptr M02_L08
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],40
        jle       short M02_L02
        mov       r11,[rcx+40]
        test      r11,r11
        je        short M02_L02
        jmp       short M02_L03
 M02_L02:
        mov       rcx,rbx
-       mov       rdx,7FF9F6AC7468
+       mov       rdx,7FF9F6AAE3E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L03:
        mov       rcx,rdi
        call      qword ptr [r11]
        mov       esi,eax
        test      esi,esi
        je        near ptr M02_L15
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],48
        jle       short M02_L04
        mov       rcx,[rcx+48]
        test      rcx,rcx
        je        short M02_L04
        jmp       short M02_L05
 M02_L04:
        mov       rcx,rbx
-       mov       rdx,7FF9F6AC7480
+       mov       rdx,7FF9F6AAE3F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L05:
        movsxd    rdx,esi
        call      CORINFO_HELP_NEWARR_1_OBJ
        mov       rsi,rax
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],50
        jle       short M02_L06
        mov       r11,[rcx+50]
        test      r11,r11
        je        short M02_L06
        jmp       short M02_L07
 M02_L06:
        mov       rcx,rbx
-       mov       rdx,7FF9F6AC7590
+       mov       rdx,7FF9F6AAE508
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
 M02_L07:
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L09
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L09
        jmp       short M02_L10
 M02_L09:
        mov       rcx,rbx
-       mov       rdx,7FF9F6AC7458
+       mov       rdx,7FF9F6AAE3D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6AD4180]
+       call      qword ptr [7FF9F6AC5ED8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF9F6AC7458
+       mov       rdx,7FF9F6AAE3D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF9F6AD41F8]
+       call      qword ptr [7FF9F6AC5F50]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF9F6AC7458
+       mov       rdx,7FF9F6AAE3D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF9F6AD4288]
+       call      qword ptr [7FF9F6AC5FE0]
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],58
        jle       short M02_L16
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M02_L16
        jmp       short M02_L17
 M02_L16:
        mov       rcx,rbx
-       mov       rdx,7FF9F6AC75A8
+       mov       rdx,7FF9F6AAE520
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9F627E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9F626E700]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
        nop
        add       rsp,60
        pop       rbx
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 521
 ; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
        vzeroupper
        mov       rax,[rcx+8]
        cmp       qword ptr [rax+10],0
        jne       short M03_L01
 M03_L00:
-       jmp       qword ptr [7FF9F69D7C90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF9F6A7D140]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF9F6951A58]
+       vmulss    xmm0,xmm0,dword ptr [7FF9F6AD9B78]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF9F69D7C48]
+       jmp       qword ptr [7FF9F6A7D0F8]
 ; Total bytes of code 71
```
