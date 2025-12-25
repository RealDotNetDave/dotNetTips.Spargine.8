## DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark-20250831-061915
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,28EBE00F840
+       mov       r8,1E69880F840
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900AB8ED8
-       call      qword ptr [7FF900A66CE8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       mov       rcx,7FF900ACCE20
+       call      qword ptr [7FF900A6C288]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,28EBE00F838
+       mov       rdx,1E69880F838
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF900014210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,28EBE00F840
+       call      qword ptr [7FF900024210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1E69880F840
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
-       mov       rdx,7FF900C4DC40
+       mov       rdx,7FF900C5FA40
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
-       call      qword ptr [7FF900AD6148]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AE71F8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF900C4DC40
+       mov       rdx,7FF900C5FA40
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF8FFED1058
+       mov       r11,7FF8FFEE1058
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FF900AD6148]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AE71F8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF900C4DB68
+       mov       rdx,7FF900C5F968
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
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900397A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900397A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,rax
-       mov       r11,7FF8FFED1060
+       mov       r11,7FF8FFEE1060
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        je        short M01_L22
        mov       rcx,[rbp-38]
-       mov       r11,7FF8FFED1060
+       mov       r11,7FF8FFEE1060
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
-       call      qword ptr [7FF9000141F8]
+       call      qword ptr [7FF9000241F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,28EBE00F840
+       mov       r8,15EE540F840
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900AB8ED8
-       call      qword ptr [7FF900A66CE8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       mov       rcx,7FF900AAC968
+       call      qword ptr [7FF900A47798]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,28EBE00F838
+       mov       rdx,15EE540F838
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF900014210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,28EBE00F840
+       call      qword ptr [7FF900004210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,15EE540F840
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
-       mov       rdx,7FF900C4DC40
+       mov       rdx,7FF900C3F758
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
-       call      qword ptr [7FF900AD6148]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AC69A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF900C4DC40
+       mov       rdx,7FF900C3F758
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF8FFED1058
+       mov       r11,7FF8FFEC1058
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FF900AD6148]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AC69A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF900C4DB68
+       mov       rdx,7FF900C3F680
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
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900377A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900377A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,rax
-       mov       r11,7FF8FFED1060
+       mov       r11,7FF8FFEC1060
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        je        short M01_L22
        mov       rcx,[rbp-38]
-       mov       r11,7FF8FFED1060
+       mov       r11,7FF8FFEC1060
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
-       call      qword ptr [7FF9000141F8]
+       call      qword ptr [7FF9000041F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,28EBE00F840
+       mov       r8,1E02B40F840
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900AB8ED8
-       call      qword ptr [7FF900A66CE8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       mov       rcx,7FF900ABC968
+       call      qword ptr [7FF900A57798]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,28EBE00F838
+       mov       rdx,1E02B40F838
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        call      qword ptr [7FF900014210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,28EBE00F840
+       mov       rcx,1E02B40F840
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
-       mov       rdx,7FF900C4DC40
+       mov       rdx,7FF900C5E828
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
-       call      qword ptr [7FF900AD6148]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AD69A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF900C4DC40
+       mov       rdx,7FF900C5E828
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FF900AD6148]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AD69A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF900C4DB68
+       mov       rdx,7FF900C5E750
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,28EBE00F840
+       mov       r8,2633DC0F840
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900AB8ED8
-       call      qword ptr [7FF900A66CE8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       mov       rcx,7FF900ABC968
+       call      qword ptr [7FF900A5C288]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,28EBE00F838
+       mov       rdx,2633DC0F838
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        call      qword ptr [7FF900014210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,28EBE00F840
+       mov       rcx,2633DC0F840
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
-       mov       rdx,7FF900C4DC40
+       mov       rdx,7FF900C5F038
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
-       call      qword ptr [7FF900AD6148]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AD7048]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF900C4DC40
+       mov       rdx,7FF900C5F038
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FF900AD6148]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AD7048]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF900C4DB68
+       mov       rdx,7FF900C5EF60
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,28EBE00F840
+       mov       r8,1B91B80F840
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900AB8ED8
-       call      qword ptr [7FF900A66CE8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       mov       rcx,7FF900A9CBE8
+       call      qword ptr [7FF900A3C288]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,28EBE00F838
+       mov       rdx,1B91B80F838
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF900014210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,28EBE00F840
+       call      qword ptr [7FF8FFFF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1B91B80F840
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
-       mov       rdx,7FF900C4DC40
+       mov       rdx,7FF900C2F008
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
-       call      qword ptr [7FF900AD6148]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AB70C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF900C4DC40
+       mov       rdx,7FF900C2F008
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF8FFED1058
+       mov       r11,7FF8FFEB1060
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FF900AD6148]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AB70C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF900C4DB68
+       mov       rdx,7FF900C2EF30
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
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900367A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900367A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,rax
-       mov       r11,7FF8FFED1060
+       mov       r11,7FF8FFEB1068
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        je        short M01_L22
-       mov       rcx,[rbp-38]
-       mov       r11,7FF8FFED1060
+       mov       r11,7FF8FFEB1068
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
-       call      qword ptr [7FF9000141F8]
+       call      qword ptr [7FF8FFFF41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,28EBE00F840
+       mov       r8,20B03C0F840
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900AB8ED8
-       call      qword ptr [7FF900A66CE8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       mov       rcx,7FF900C14EA8
+       call      qword ptr [7FF900B1E538]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,28EBE00F838
+       mov       rdx,20B03C0F838
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF900014210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,28EBE00F840
+       call      qword ptr [7FF900004210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,20B03C0F840
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
-       mov       rdx,7FF900C4DC40
+       mov       rdx,7FF900CC96F8
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
-       call      qword ptr [7FF900AD6148]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900C0D5A8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF900C4DC40
+       mov       rdx,7FF900CC96F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF8FFED1058
+       mov       r11,7FF8FFEC1228
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FF900AD6148]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900C0D5A8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF900C4DB68
+       mov       rdx,7FF900CC9620
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
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900377A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900377A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF8FFED1060
+       mov       rcx,[rbp-38]
+       mov       r11,7FF8FFEC1230
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        je        short M01_L22
        mov       rcx,[rbp-38]
-       mov       r11,7FF8FFED1060
+       mov       r11,7FF8FFEC1230
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
-       call      qword ptr [7FF9000141F8]
+       call      qword ptr [7FF9000041F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,28EBE00F840
+       mov       r8,1965A40F840
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900AB8ED8
-       call      qword ptr [7FF900A66CE8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       mov       rcx,7FF900CDA558
+       call      qword ptr [7FF900C6F618]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,28EBE00F838
+       mov       rdx,1965A40F838
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        call      qword ptr [7FF900014210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,28EBE00F840
+       mov       rcx,1965A40F840
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
-       mov       rdx,7FF900C4DC40
+       mov       rdx,7FF900D83518
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
-       call      qword ptr [7FF900AD6148]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900CCC840]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF900C4DC40
+       mov       rdx,7FF900D83518
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF8FFED1058
+       mov       r11,7FF8FFED1AF8
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FF900AD6148]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900CCC840]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF900C4DB68
+       mov       rdx,7FF900D83440
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF8FFED1060
+       mov       rcx,[rbp-38]
+       mov       r11,7FF8FFED1B00
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        je        short M01_L22
        mov       rcx,[rbp-38]
-       mov       r11,7FF8FFED1060
+       mov       r11,7FF8FFED1B00
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
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1E69880F840
+       mov       r8,15EE540F840
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900ACCE20
-       call      qword ptr [7FF900A6C288]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       mov       rcx,7FF900AAC968
+       call      qword ptr [7FF900A47798]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1E69880F838
+       mov       rdx,15EE540F838
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF900024210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1E69880F840
+       call      qword ptr [7FF900004210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,15EE540F840
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
-       mov       rdx,7FF900C5FA40
+       mov       rdx,7FF900C3F758
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
-       call      qword ptr [7FF900AE71F8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AC69A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF900C5FA40
+       mov       rdx,7FF900C3F758
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF8FFEE1058
+       mov       r11,7FF8FFEC1058
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FF900AE71F8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AC69A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF900C5F968
+       mov       rdx,7FF900C3F680
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
-       call      qword ptr [7FF900397A38]
+       call      qword ptr [7FF900377A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF900397A38]
+       call      qword ptr [7FF900377A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,rax
-       mov       r11,7FF8FFEE1060
+       mov       r11,7FF8FFEC1060
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        je        short M01_L22
        mov       rcx,[rbp-38]
-       mov       r11,7FF8FFEE1060
+       mov       r11,7FF8FFEC1060
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
-       call      qword ptr [7FF9000241F8]
+       call      qword ptr [7FF9000041F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1E69880F840
+       mov       r8,1E02B40F840
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900ACCE20
-       call      qword ptr [7FF900A6C288]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       mov       rcx,7FF900ABC968
+       call      qword ptr [7FF900A57798]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1E69880F838
+       mov       rdx,1E02B40F838
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF900024210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1E69880F840
+       call      qword ptr [7FF900014210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1E02B40F840
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
-       mov       rdx,7FF900C5FA40
+       mov       rdx,7FF900C5E828
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
-       call      qword ptr [7FF900AE71F8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AD69A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF900C5FA40
+       mov       rdx,7FF900C5E828
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF8FFEE1058
+       mov       r11,7FF8FFED1058
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FF900AE71F8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AD69A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF900C5F968
+       mov       rdx,7FF900C5E750
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
-       call      qword ptr [7FF900397A38]
+       call      qword ptr [7FF900387A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF900397A38]
+       call      qword ptr [7FF900387A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,rax
-       mov       r11,7FF8FFEE1060
+       mov       r11,7FF8FFED1060
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        je        short M01_L22
        mov       rcx,[rbp-38]
-       mov       r11,7FF8FFEE1060
+       mov       r11,7FF8FFED1060
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
-       call      qword ptr [7FF9000241F8]
+       call      qword ptr [7FF9000141F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1E69880F840
+       mov       r8,2633DC0F840
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900ACCE20
-       call      qword ptr [7FF900A6C288]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       mov       rcx,7FF900ABC968
+       call      qword ptr [7FF900A5C288]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1E69880F838
+       mov       rdx,2633DC0F838
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF900024210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1E69880F840
+       call      qword ptr [7FF900014210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,2633DC0F840
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
-       mov       rdx,7FF900C5FA40
+       mov       rdx,7FF900C5F038
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
-       call      qword ptr [7FF900AE71F8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AD7048]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF900C5FA40
+       mov       rdx,7FF900C5F038
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF8FFEE1058
+       mov       r11,7FF8FFED1058
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FF900AE71F8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AD7048]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF900C5F968
+       mov       rdx,7FF900C5EF60
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
-       call      qword ptr [7FF900397A38]
+       call      qword ptr [7FF900387A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF900397A38]
+       call      qword ptr [7FF900387A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,rax
-       mov       r11,7FF8FFEE1060
+       mov       r11,7FF8FFED1060
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        je        short M01_L22
        mov       rcx,[rbp-38]
-       mov       r11,7FF8FFEE1060
+       mov       r11,7FF8FFED1060
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
-       call      qword ptr [7FF9000241F8]
+       call      qword ptr [7FF9000141F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1E69880F840
+       mov       r8,1B91B80F840
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900ACCE20
-       call      qword ptr [7FF900A6C288]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       mov       rcx,7FF900A9CBE8
+       call      qword ptr [7FF900A3C288]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1E69880F838
+       mov       rdx,1B91B80F838
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF900024210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1E69880F840
+       call      qword ptr [7FF8FFFF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1B91B80F840
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
-       mov       rdx,7FF900C5FA40
+       mov       rdx,7FF900C2F008
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
-       call      qword ptr [7FF900AE71F8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AB70C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF900C5FA40
+       mov       rdx,7FF900C2F008
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF8FFEE1058
+       mov       r11,7FF8FFEB1060
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FF900AE71F8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AB70C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF900C5F968
+       mov       rdx,7FF900C2EF30
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
-       call      qword ptr [7FF900397A38]
+       call      qword ptr [7FF900367A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF900397A38]
+       call      qword ptr [7FF900367A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,rax
-       mov       r11,7FF8FFEE1060
+       mov       r11,7FF8FFEB1068
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        je        short M01_L22
-       mov       rcx,[rbp-38]
-       mov       r11,7FF8FFEE1060
+       mov       r11,7FF8FFEB1068
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
-       call      qword ptr [7FF9000241F8]
+       call      qword ptr [7FF8FFFF41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1E69880F840
+       mov       r8,20B03C0F840
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900ACCE20
-       call      qword ptr [7FF900A6C288]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       mov       rcx,7FF900C14EA8
+       call      qword ptr [7FF900B1E538]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1E69880F838
+       mov       rdx,20B03C0F838
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF900024210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1E69880F840
+       call      qword ptr [7FF900004210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,20B03C0F840
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
-       mov       rdx,7FF900C5FA40
+       mov       rdx,7FF900CC96F8
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
-       call      qword ptr [7FF900AE71F8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900C0D5A8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF900C5FA40
+       mov       rdx,7FF900CC96F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF8FFEE1058
+       mov       r11,7FF8FFEC1228
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FF900AE71F8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900C0D5A8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF900C5F968
+       mov       rdx,7FF900CC9620
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
-       call      qword ptr [7FF900397A38]
+       call      qword ptr [7FF900377A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF900397A38]
+       call      qword ptr [7FF900377A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF8FFEE1060
+       mov       rcx,[rbp-38]
+       mov       r11,7FF8FFEC1230
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        je        short M01_L22
        mov       rcx,[rbp-38]
-       mov       r11,7FF8FFEE1060
+       mov       r11,7FF8FFEC1230
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
-       call      qword ptr [7FF9000241F8]
+       call      qword ptr [7FF9000041F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1E69880F840
+       mov       r8,1965A40F840
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900ACCE20
-       call      qword ptr [7FF900A6C288]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       mov       rcx,7FF900CDA558
+       call      qword ptr [7FF900C6F618]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1E69880F838
+       mov       rdx,1965A40F838
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF900024210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1E69880F840
+       call      qword ptr [7FF900014210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1965A40F840
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
-       mov       rdx,7FF900C5FA40
+       mov       rdx,7FF900D83518
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
-       call      qword ptr [7FF900AE71F8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900CCC840]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF900C5FA40
+       mov       rdx,7FF900D83518
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF8FFEE1058
+       mov       r11,7FF8FFED1AF8
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FF900AE71F8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900CCC840]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF900C5F968
+       mov       rdx,7FF900D83440
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
-       call      qword ptr [7FF900397A38]
+       call      qword ptr [7FF900387A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF900397A38]
+       call      qword ptr [7FF900387A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF8FFEE1060
+       mov       rcx,[rbp-38]
+       mov       r11,7FF8FFED1B00
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        je        short M01_L22
        mov       rcx,[rbp-38]
-       mov       r11,7FF8FFEE1060
+       mov       r11,7FF8FFED1B00
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
-       call      qword ptr [7FF9000241F8]
+       call      qword ptr [7FF9000141F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,15EE540F840
+       mov       r8,1E02B40F840
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900AAC968
-       call      qword ptr [7FF900A47798]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       mov       rcx,7FF900ABC968
+       call      qword ptr [7FF900A57798]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,15EE540F838
+       mov       rdx,1E02B40F838
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF900004210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,15EE540F840
+       call      qword ptr [7FF900014210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1E02B40F840
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
-       mov       rdx,7FF900C3F758
+       mov       rdx,7FF900C5E828
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
-       call      qword ptr [7FF900AC69A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AD69A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF900C3F758
+       mov       rdx,7FF900C5E828
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF8FFEC1058
+       mov       r11,7FF8FFED1058
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FF900AC69A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AD69A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF900C3F680
+       mov       rdx,7FF900C5E750
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
-       call      qword ptr [7FF900377A38]
+       call      qword ptr [7FF900387A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF900377A38]
+       call      qword ptr [7FF900387A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,rax
-       mov       r11,7FF8FFEC1060
+       mov       r11,7FF8FFED1060
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        je        short M01_L22
        mov       rcx,[rbp-38]
-       mov       r11,7FF8FFEC1060
+       mov       r11,7FF8FFED1060
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
-       call      qword ptr [7FF9000041F8]
+       call      qword ptr [7FF9000141F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,15EE540F840
+       mov       r8,2633DC0F840
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900AAC968
-       call      qword ptr [7FF900A47798]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       mov       rcx,7FF900ABC968
+       call      qword ptr [7FF900A5C288]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,15EE540F838
+       mov       rdx,2633DC0F838
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF900004210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,15EE540F840
+       call      qword ptr [7FF900014210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,2633DC0F840
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
-       mov       rdx,7FF900C3F758
+       mov       rdx,7FF900C5F038
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
-       call      qword ptr [7FF900AC69A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AD7048]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF900C3F758
+       mov       rdx,7FF900C5F038
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF8FFEC1058
+       mov       r11,7FF8FFED1058
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FF900AC69A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AD7048]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF900C3F680
+       mov       rdx,7FF900C5EF60
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
-       call      qword ptr [7FF900377A38]
+       call      qword ptr [7FF900387A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF900377A38]
+       call      qword ptr [7FF900387A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,rax
-       mov       r11,7FF8FFEC1060
+       mov       r11,7FF8FFED1060
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        je        short M01_L22
        mov       rcx,[rbp-38]
-       mov       r11,7FF8FFEC1060
+       mov       r11,7FF8FFED1060
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
-       call      qword ptr [7FF9000041F8]
+       call      qword ptr [7FF9000141F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,15EE540F840
+       mov       r8,1B91B80F840
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900AAC968
-       call      qword ptr [7FF900A47798]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       mov       rcx,7FF900A9CBE8
+       call      qword ptr [7FF900A3C288]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,15EE540F838
+       mov       rdx,1B91B80F838
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF900004210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,15EE540F840
+       call      qword ptr [7FF8FFFF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1B91B80F840
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
-       mov       rdx,7FF900C3F758
+       mov       rdx,7FF900C2F008
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
-       call      qword ptr [7FF900AC69A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AB70C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF900C3F758
+       mov       rdx,7FF900C2F008
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF8FFEC1058
+       mov       r11,7FF8FFEB1060
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FF900AC69A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AB70C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF900C3F680
+       mov       rdx,7FF900C2EF30
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
-       call      qword ptr [7FF900377A38]
+       call      qword ptr [7FF900367A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF900377A38]
+       call      qword ptr [7FF900367A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,rax
-       mov       r11,7FF8FFEC1060
+       mov       r11,7FF8FFEB1068
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        je        short M01_L22
-       mov       rcx,[rbp-38]
-       mov       r11,7FF8FFEC1060
+       mov       r11,7FF8FFEB1068
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
-       call      qword ptr [7FF9000041F8]
+       call      qword ptr [7FF8FFFF41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,15EE540F840
+       mov       r8,20B03C0F840
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900AAC968
-       call      qword ptr [7FF900A47798]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       mov       rcx,7FF900C14EA8
+       call      qword ptr [7FF900B1E538]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,15EE540F838
+       mov       rdx,20B03C0F838
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        call      qword ptr [7FF900004210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,15EE540F840
+       mov       rcx,20B03C0F840
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
-       mov       rdx,7FF900C3F758
+       mov       rdx,7FF900CC96F8
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
-       call      qword ptr [7FF900AC69A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900C0D5A8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF900C3F758
+       mov       rdx,7FF900CC96F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF8FFEC1058
+       mov       r11,7FF8FFEC1228
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FF900AC69A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900C0D5A8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF900C3F680
+       mov       rdx,7FF900CC9620
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF8FFEC1060
+       mov       rcx,[rbp-38]
+       mov       r11,7FF8FFEC1230
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        je        short M01_L22
        mov       rcx,[rbp-38]
-       mov       r11,7FF8FFEC1060
+       mov       r11,7FF8FFEC1230
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
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,15EE540F840
+       mov       r8,1965A40F840
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900AAC968
-       call      qword ptr [7FF900A47798]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       mov       rcx,7FF900CDA558
+       call      qword ptr [7FF900C6F618]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,15EE540F838
+       mov       rdx,1965A40F838
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF900004210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,15EE540F840
+       call      qword ptr [7FF900014210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1965A40F840
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
-       mov       rdx,7FF900C3F758
+       mov       rdx,7FF900D83518
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
-       call      qword ptr [7FF900AC69A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900CCC840]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF900C3F758
+       mov       rdx,7FF900D83518
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF8FFEC1058
+       mov       r11,7FF8FFED1AF8
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FF900AC69A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900CCC840]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF900C3F680
+       mov       rdx,7FF900D83440
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
-       call      qword ptr [7FF900377A38]
+       call      qword ptr [7FF900387A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF900377A38]
+       call      qword ptr [7FF900387A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF8FFEC1060
+       mov       rcx,[rbp-38]
+       mov       r11,7FF8FFED1B00
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        je        short M01_L22
        mov       rcx,[rbp-38]
-       mov       r11,7FF8FFEC1060
+       mov       r11,7FF8FFED1B00
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
-       call      qword ptr [7FF9000041F8]
+       call      qword ptr [7FF9000141F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1E02B40F840
+       mov       r8,2633DC0F840
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
        mov       rcx,7FF900ABC968
-       call      qword ptr [7FF900A57798]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF900A5C288]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1E02B40F838
+       mov       rdx,2633DC0F838
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        call      qword ptr [7FF900014210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1E02B40F840
+       mov       rcx,2633DC0F840
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
-       mov       rdx,7FF900C5E828
+       mov       rdx,7FF900C5F038
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
-       call      qword ptr [7FF900AD69A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AD7048]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF900C5E828
+       mov       rdx,7FF900C5F038
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FF900AD69A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AD7048]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF900C5E750
+       mov       rdx,7FF900C5EF60
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1E02B40F840
+       mov       r8,1B91B80F840
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900ABC968
-       call      qword ptr [7FF900A57798]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       mov       rcx,7FF900A9CBE8
+       call      qword ptr [7FF900A3C288]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1E02B40F838
+       mov       rdx,1B91B80F838
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF900014210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1E02B40F840
+       call      qword ptr [7FF8FFFF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1B91B80F840
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
-       mov       rdx,7FF900C5E828
+       mov       rdx,7FF900C2F008
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
-       call      qword ptr [7FF900AD69A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AB70C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF900C5E828
+       mov       rdx,7FF900C2F008
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF8FFED1058
+       mov       r11,7FF8FFEB1060
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FF900AD69A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AB70C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF900C5E750
+       mov       rdx,7FF900C2EF30
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
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900367A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900367A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,rax
-       mov       r11,7FF8FFED1060
+       mov       r11,7FF8FFEB1068
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        je        short M01_L22
-       mov       rcx,[rbp-38]
-       mov       r11,7FF8FFED1060
+       mov       r11,7FF8FFEB1068
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
-       call      qword ptr [7FF9000141F8]
+       call      qword ptr [7FF8FFFF41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1E02B40F840
+       mov       r8,20B03C0F840
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900ABC968
-       call      qword ptr [7FF900A57798]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       mov       rcx,7FF900C14EA8
+       call      qword ptr [7FF900B1E538]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1E02B40F838
+       mov       rdx,20B03C0F838
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF900014210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1E02B40F840
+       call      qword ptr [7FF900004210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,20B03C0F840
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
-       mov       rdx,7FF900C5E828
+       mov       rdx,7FF900CC96F8
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
-       call      qword ptr [7FF900AD69A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900C0D5A8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF900C5E828
+       mov       rdx,7FF900CC96F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF8FFED1058
+       mov       r11,7FF8FFEC1228
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FF900AD69A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900C0D5A8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF900C5E750
+       mov       rdx,7FF900CC9620
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
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900377A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900377A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF8FFED1060
+       mov       rcx,[rbp-38]
+       mov       r11,7FF8FFEC1230
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        je        short M01_L22
        mov       rcx,[rbp-38]
-       mov       r11,7FF8FFED1060
+       mov       r11,7FF8FFEC1230
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
-       call      qword ptr [7FF9000141F8]
+       call      qword ptr [7FF9000041F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1E02B40F840
+       mov       r8,1965A40F840
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900ABC968
-       call      qword ptr [7FF900A57798]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       mov       rcx,7FF900CDA558
+       call      qword ptr [7FF900C6F618]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1E02B40F838
+       mov       rdx,1965A40F838
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        call      qword ptr [7FF900014210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1E02B40F840
+       mov       rcx,1965A40F840
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
-       mov       rdx,7FF900C5E828
+       mov       rdx,7FF900D83518
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
-       call      qword ptr [7FF900AD69A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900CCC840]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF900C5E828
+       mov       rdx,7FF900D83518
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF8FFED1058
+       mov       r11,7FF8FFED1AF8
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FF900AD69A0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900CCC840]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF900C5E750
+       mov       rdx,7FF900D83440
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF8FFED1060
+       mov       rcx,[rbp-38]
+       mov       r11,7FF8FFED1B00
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        je        short M01_L22
        mov       rcx,[rbp-38]
-       mov       r11,7FF8FFED1060
+       mov       r11,7FF8FFED1B00
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
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,2633DC0F840
+       mov       r8,1B91B80F840
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900ABC968
-       call      qword ptr [7FF900A5C288]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       mov       rcx,7FF900A9CBE8
+       call      qword ptr [7FF900A3C288]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2633DC0F838
+       mov       rdx,1B91B80F838
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF900014210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2633DC0F840
+       call      qword ptr [7FF8FFFF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1B91B80F840
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
-       mov       rdx,7FF900C5F038
+       mov       rdx,7FF900C2F008
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
-       call      qword ptr [7FF900AD7048]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AB70C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF900C5F038
+       mov       rdx,7FF900C2F008
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF8FFED1058
+       mov       r11,7FF8FFEB1060
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FF900AD7048]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900AB70C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF900C5EF60
+       mov       rdx,7FF900C2EF30
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
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900367A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900367A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,rax
-       mov       r11,7FF8FFED1060
+       mov       r11,7FF8FFEB1068
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        je        short M01_L22
-       mov       rcx,[rbp-38]
-       mov       r11,7FF8FFED1060
+       mov       r11,7FF8FFEB1068
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
-       call      qword ptr [7FF9000141F8]
+       call      qword ptr [7FF8FFFF41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,2633DC0F840
+       mov       r8,20B03C0F840
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900ABC968
-       call      qword ptr [7FF900A5C288]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       mov       rcx,7FF900C14EA8
+       call      qword ptr [7FF900B1E538]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2633DC0F838
+       mov       rdx,20B03C0F838
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF900014210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2633DC0F840
+       call      qword ptr [7FF900004210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,20B03C0F840
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
-       mov       rdx,7FF900C5F038
+       mov       rdx,7FF900CC96F8
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
-       call      qword ptr [7FF900AD7048]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900C0D5A8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF900C5F038
+       mov       rdx,7FF900CC96F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF8FFED1058
+       mov       r11,7FF8FFEC1228
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FF900AD7048]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900C0D5A8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF900C5EF60
+       mov       rdx,7FF900CC9620
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
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900377A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900377A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF8FFED1060
+       mov       rcx,[rbp-38]
+       mov       r11,7FF8FFEC1230
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        je        short M01_L22
        mov       rcx,[rbp-38]
-       mov       r11,7FF8FFED1060
+       mov       r11,7FF8FFEC1230
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
-       call      qword ptr [7FF9000141F8]
+       call      qword ptr [7FF9000041F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,2633DC0F840
+       mov       r8,1965A40F840
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900ABC968
-       call      qword ptr [7FF900A5C288]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       mov       rcx,7FF900CDA558
+       call      qword ptr [7FF900C6F618]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2633DC0F838
+       mov       rdx,1965A40F838
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        call      qword ptr [7FF900014210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2633DC0F840
+       mov       rcx,1965A40F840
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
-       mov       rdx,7FF900C5F038
+       mov       rdx,7FF900D83518
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
-       call      qword ptr [7FF900AD7048]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900CCC840]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF900C5F038
+       mov       rdx,7FF900D83518
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF8FFED1058
+       mov       r11,7FF8FFED1AF8
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FF900AD7048]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900CCC840]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF900C5EF60
+       mov       rdx,7FF900D83440
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF8FFED1060
+       mov       rcx,[rbp-38]
+       mov       r11,7FF8FFED1B00
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        je        short M01_L22
        mov       rcx,[rbp-38]
-       mov       r11,7FF8FFED1060
+       mov       r11,7FF8FFED1B00
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
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1B91B80F840
+       mov       r8,20B03C0F840
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A9CBE8
-       call      qword ptr [7FF900A3C288]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       mov       rcx,7FF900C14EA8
+       call      qword ptr [7FF900B1E538]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1B91B80F838
+       mov       rdx,20B03C0F838
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF8FFFF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1B91B80F840
+       call      qword ptr [7FF900004210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,20B03C0F840
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
-       mov       rdx,7FF900C2F008
+       mov       rdx,7FF900CC96F8
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
-       call      qword ptr [7FF900AB70C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900C0D5A8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF900C2F008
+       mov       rdx,7FF900CC96F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF8FFEB1060
+       mov       r11,7FF8FFEC1228
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FF900AB70C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900C0D5A8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF900C2EF30
+       mov       rdx,7FF900CC9620
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
-       call      qword ptr [7FF900367A38]
+       call      qword ptr [7FF900377A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF900367A38]
+       call      qword ptr [7FF900377A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF8FFEB1068
+       mov       rcx,[rbp-38]
+       mov       r11,7FF8FFEC1230
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        je        short M01_L22
-       mov       r11,7FF8FFEB1068
+       mov       rcx,[rbp-38]
+       mov       r11,7FF8FFEC1230
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
+; Total bytes of code 608
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
-       call      qword ptr [7FF8FFFF41F8]
+       call      qword ptr [7FF9000041F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1B91B80F840
+       mov       r8,1965A40F840
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A9CBE8
-       call      qword ptr [7FF900A3C288]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       mov       rcx,7FF900CDA558
+       call      qword ptr [7FF900C6F618]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1B91B80F838
+       mov       rdx,1965A40F838
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF8FFFF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1B91B80F840
+       call      qword ptr [7FF900014210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1965A40F840
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
-       mov       rdx,7FF900C2F008
+       mov       rdx,7FF900D83518
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
-       call      qword ptr [7FF900AB70C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900CCC840]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF900C2F008
+       mov       rdx,7FF900D83518
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF8FFEB1060
+       mov       r11,7FF8FFED1AF8
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FF900AB70C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900CCC840]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF900C2EF30
+       mov       rdx,7FF900D83440
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
-       call      qword ptr [7FF900367A38]
+       call      qword ptr [7FF900387A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF900367A38]
+       call      qword ptr [7FF900387A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF8FFEB1068
+       mov       rcx,[rbp-38]
+       mov       r11,7FF8FFED1B00
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        je        short M01_L22
-       mov       r11,7FF8FFEB1068
+       mov       rcx,[rbp-38]
+       mov       r11,7FF8FFED1B00
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
+; Total bytes of code 608
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
-       call      qword ptr [7FF8FFFF41F8]
+       call      qword ptr [7FF9000141F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,20B03C0F840
+       mov       r8,1965A40F840
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L02
        test      rsi,rsi
        je        short M00_L03
 M00_L00:
        test      r8,r8
        je        short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900C14EA8
-       call      qword ptr [7FF900B1E538]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       mov       rcx,7FF900CDA558
+       call      qword ptr [7FF900C6F618]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,20B03C0F838
+       mov       rdx,1965A40F838
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF900004210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,20B03C0F840
+       call      qword ptr [7FF900014210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1965A40F840
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
-       mov       rdx,7FF900CC96F8
+       mov       rdx,7FF900D83518
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
-       call      qword ptr [7FF900C0D5A8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900CCC840]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF900CC96F8
+       mov       rdx,7FF900D83518
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF8FFEC1228
+       mov       r11,7FF8FFED1AF8
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FF900C0D5A8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF900CCC840]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF900CC9620
+       mov       rdx,7FF900D83440
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
-       call      qword ptr [7FF900377A38]
+       call      qword ptr [7FF900387A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF900377A38]
+       call      qword ptr [7FF900387A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FF8FFEC1230
+       mov       r11,7FF8FFED1B00
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
        mov       r14,offset MT_System.Collections.Generic.SortedSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>+Enumerator
        cmp       rdi,r14
        je        short M01_L22
        mov       rcx,[rbp-38]
-       mov       r11,7FF8FFEC1230
+       mov       r11,7FF8FFED1B00
        call      qword ptr [r11]
 M01_L22:
        nop
        test      eax,eax
        sete      al
        movzx     eax,al
        ret
 ; Total bytes of code 35
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
-       call      qword ptr [7FF9000041F8]
+       call      qword ptr [7FF9000141F8]
        int       3
 ; Total bytes of code 44
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff

```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
        mov       rcx,offset MT_System.Linq.IIListProvider<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
        call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A385E0
-       call      qword ptr [7FF9009EF858]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900A4C6F8
+       call      qword ptr [7FF900A34F18]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,20026C01FF0
+       mov       rcx,22061801FF0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF900AB5E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF900AB7420]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
        call      qword ptr [7FF900367A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF8FFEB0F78
+       mov       r11,7FF8FFEB0F68
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        jmp       qword ptr [7FF8FFFF4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FF900C84670
+       mov       rdx,7FF900C84170
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
        call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C84690
+       mov       rdx,7FF900C84190
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
-       mov       rdx,7FF900C846A8
+       mov       rdx,7FF900C841A8
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
-       mov       rdx,7FF900C847B8
+       mov       rdx,7FF900C842B8
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
-       mov       rdx,7FF900C84680
+       mov       rdx,7FF900C84180
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C2D2A8]
+       call      qword ptr [7FF900C3E8F8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF900C84680
+       mov       rdx,7FF900C84180
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF900C2D320]
+       call      qword ptr [7FF900C3E970]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF900C84680
+       mov       rdx,7FF900C84180
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C2D3B0]
+       call      qword ptr [7FF900C3EA00]
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
-       mov       rdx,7FF900C847D0
+       mov       rdx,7FF900C842D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
        call      qword ptr [7FF90049E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FF900AB63A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF900AB7960]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF900B7F098]
+       vmulss    xmm0,xmm0,dword ptr [7FF900B7F898]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF900AB6358]
+       jmp       qword ptr [7FF900AB7918]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
        mov       rcx,offset MT_System.Linq.IIListProvider<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A385E0
-       call      qword ptr [7FF9009EF858]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900A6C6F8
+       call      qword ptr [7FF900A559F8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,20026C01FF0
+       mov       rcx,1A299801FF0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF900AB5E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF900ADC1C8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FF900367A38]
+       call      qword ptr [7FF900387A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF8FFEB0F78
+       mov       r11,7FF8FFED0F68
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FF8FFFF4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FF900014378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FF900C84670
+       mov       rdx,7FF900CA48F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C84690
+       mov       rdx,offset System.ReadOnlySpan`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon[])
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
-       mov       rdx,7FF900C846A8
+       mov       rdx,7FF900CA4930
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
-       mov       rdx,7FF900C847B8
+       mov       rdx,7FF900CA4A40
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
-       mov       rdx,7FF900C84680
+       mov       rdx,7FF900CA4908
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C2D2A8]
+       call      qword ptr [7FF900C5EF28]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF900C84680
+       mov       rdx,7FF900CA4908
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF900C2D320]
+       call      qword ptr [7FF900C5EFA0]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF900C84680
+       mov       rdx,7FF900CA4908
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C2D3B0]
+       call      qword ptr [7FF900C5F030]
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
-       mov       rdx,7FF900C847D0
+       mov       rdx,7FF900CA4A58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF90049E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9004BE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FF900AB63A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF900ADC708]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF900B7F098]
+       vmulss    xmm0,xmm0,dword ptr [7FF900B9EE18]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF900AB6358]
+       jmp       qword ptr [7FF900ADC6C0]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
        mov       rcx,offset MT_System.Linq.IIListProvider<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A385E0
-       call      qword ptr [7FF9009EF858]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900A5C6F8
+       call      qword ptr [7FF900A44F18]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,20026C01FF0
+       mov       rcx,2BC4DC01FF0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF900AB5E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF900AC7120]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FF900367A38]
+       call      qword ptr [7FF900377A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF8FFEB0F78
+       mov       r11,7FF8FFEC0F68
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FF8FFFF4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FF900004378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FF900C84670
+       mov       rdx,7FF900C94280
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C84690
+       mov       rdx,7FF900C942A0
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
-       mov       rdx,7FF900C846A8
+       mov       rdx,7FF900C942B8
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
-       mov       rdx,7FF900C847B8
+       mov       rdx,7FF900C943C8
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
-       mov       rdx,7FF900C84680
+       mov       rdx,7FF900C94290
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C2D2A8]
+       call      qword ptr [7FF900C4E8F8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF900C84680
+       mov       rdx,7FF900C94290
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF900C2D320]
+       call      qword ptr [7FF900C4E970]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF900C84680
+       mov       rdx,7FF900C94290
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C2D3B0]
+       call      qword ptr [7FF900C4EA00]
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
-       mov       rdx,7FF900C847D0
+       mov       rdx,7FF900C943E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF90049E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9004AE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FF900AB63A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF900AC7660]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF900B7F098]
+       vmulss    xmm0,xmm0,dword ptr [7FF900B8E958]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF900AB6358]
+       jmp       qword ptr [7FF900AC7618]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
        mov       rcx,offset MT_System.Linq.IIListProvider<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A385E0
-       call      qword ptr [7FF9009EF858]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900A5C6F8
+       call      qword ptr [7FF900A44F18]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,20026C01FF0
+       mov       rcx,1615E401FF0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF900AB5E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF900AC7420]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FF900367A38]
+       call      qword ptr [7FF900377A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF8FFEB0F78
+       mov       r11,7FF8FFEC0F68
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FF8FFFF4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FF900004378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FF900C84670
+       mov       rdx,7FF900C94360
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C84690
+       mov       rdx,7FF900C94380
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
-       mov       rdx,7FF900C846A8
+       mov       rdx,7FF900C94398
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
-       mov       rdx,7FF900C847B8
+       mov       rdx,7FF900C944A8
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
-       mov       rdx,7FF900C84680
+       mov       rdx,7FF900C94370
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C2D2A8]
+       call      qword ptr [7FF900C4EAF0]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF900C84680
+       mov       rdx,7FF900C94370
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF900C2D320]
+       call      qword ptr [7FF900C4EB68]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF900C84680
+       mov       rdx,7FF900C94370
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C2D3B0]
+       call      qword ptr [7FF900C4EBF8]
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
-       mov       rdx,7FF900C847D0
+       mov       rdx,7FF900C944C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF90049E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9004AE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FF900AB63A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF900AC7960]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF900B7F098]
+       vmulss    xmm0,xmm0,dword ptr [7FF900B8E898]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF900AB6358]
+       jmp       qword ptr [7FF900AC7918]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
        mov       rcx,offset MT_System.Linq.IIListProvider<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A385E0
-       call      qword ptr [7FF9009EF858]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900A7C6F8
+       call      qword ptr [7FF900A64F18]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,20026C01FF0
+       mov       rcx,18B46801FF0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF900AB5E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF900AE7120]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FF900367A38]
+       call      qword ptr [7FF900397A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF8FFEB0F78
+       mov       r11,7FF8FFEE0F68
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FF8FFFF4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FF900024378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FF900C84670
+       mov       rdx,7FF900CB51A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C84690
+       mov       rdx,7FF900CB51C8
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
-       mov       rdx,7FF900C846A8
+       mov       rdx,7FF900CB51E0
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
-       mov       rdx,7FF900C847B8
+       mov       rdx,7FF900CB52F0
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
-       mov       rdx,7FF900C84680
+       mov       rdx,7FF900CB51B8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C2D2A8]
+       call      qword ptr [7FF900C6E8F8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF900C84680
+       mov       rdx,7FF900CB51B8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF900C2D320]
+       call      qword ptr [7FF900C6E970]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF900C84680
+       mov       rdx,7FF900CB51B8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C2D3B0]
+       call      qword ptr [7FF900C6EA00]
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
-       mov       rdx,7FF900C847D0
+       mov       rdx,7FF900CB5308
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF90049E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9004CE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FF900AB63A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF900AE7660]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF900B7F098]
+       vmulss    xmm0,xmm0,dword ptr [7FF900BAE798]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF900AB6358]
+       jmp       qword ptr [7FF900AE7618]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
        mov       rcx,offset MT_System.Linq.IIListProvider<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A385E0
-       call      qword ptr [7FF9009EF858]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900A70D98
+       call      qword ptr [7FF900A4C528]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,20026C01FF0
+       mov       rcx,206C3402008
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF900AB5E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF900C1EA18]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FF900367A38]
+       call      qword ptr [7FF900377A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF8FFEB0F78
+       mov       r11,7FF8FFEC1260
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
-       je        short M01_L01
+       je        short M01_L03
        mov       rax,[rdx]
        movzx     r8d,word ptr [rax+0E]
        test      r8,r8
-       je        short M01_L04
+       je        short M01_L02
        mov       r10,[rax+38]
        cmp       r8,4
-       jl        short M01_L03
+       jl        short M01_L01
 M01_L00:
        cmp       [r10],rcx
-       jne       short M01_L02
-M01_L01:
-       mov       rax,rdx
-       ret
-M01_L02:
+       je        short M01_L03
        cmp       [r10+8],rcx
-       je        short M01_L01
+       je        short M01_L03
        cmp       [r10+10],rcx
-       je        short M01_L01
+       je        short M01_L03
        cmp       [r10+18],rcx
-       je        short M01_L01
+       je        short M01_L03
        add       r10,20
        add       r8,0FFFFFFFFFFFFFFFC
        cmp       r8,4
        jge       short M01_L00
        test      r8,r8
-       je        short M01_L04
-M01_L03:
+       je        short M01_L02
+M01_L01:
        cmp       [r10],rcx
-       je        short M01_L01
+       je        short M01_L03
        add       r10,8
        dec       r8
        test      r8,r8
-       jg        short M01_L03
-M01_L04:
+       jg        short M01_L01
+M01_L02:
        test      dword ptr [rax],406C0000
-       jne       short M01_L05
+       jne       short M01_L04
        xor       edx,edx
-       jmp       short M01_L01
-M01_L05:
-       jmp       qword ptr [7FF8FFFF4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
-; Total bytes of code 109
+M01_L03:
+       mov       rax,rdx
+       ret
+M01_L04:
+       jmp       qword ptr [7FF900004378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+; Total bytes of code 107
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
-       mov       rdx,7FF900C84670
+       mov       rdx,7FF900CDC6D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C84690
+       mov       rdx,7FF900CDC6F0
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
-       mov       rdx,7FF900C846A8
+       mov       rdx,7FF900CDC708
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
-       mov       rdx,7FF900C847B8
+       mov       rdx,7FF900CDC818
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
-       mov       rdx,7FF900C84680
+       mov       rdx,7FF900CDC6E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C2D2A8]
+       call      qword ptr [7FF900CF65E0]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF900C84680
+       mov       rdx,7FF900CDC6E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF900C2D320]
+       call      qword ptr [7FF900CF6658]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF900C84680
+       mov       rdx,7FF900CDC6E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C2D3B0]
+       call      qword ptr [7FF900CF66E8]
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
-       mov       rdx,7FF900C847D0
+       mov       rdx,7FF900CDC830
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF90049E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9004AE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FF900AB63A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF900C1EF58]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF900B7F098]
+       vmulss    xmm0,xmm0,dword ptr [7FF900B92758]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF900AB6358]
+       jmp       qword ptr [7FF900C1EF10]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
        mov       rcx,offset MT_System.Linq.IIListProvider<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A385E0
-       call      qword ptr [7FF9009EF858]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900AFFED0
+       call      qword ptr [7FF900B177C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,20026C01FF0
+       mov       rcx,223FA014DF8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF900AB5E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF900CBD110]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FF900367A38]
+       call      qword ptr [7FF900377A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF8FFEB0F78
+       mov       r11,7FF8FFEC1B28
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
+       jmp       qword ptr [7FF900004378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FF8FFFF4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FF900C84670
+       mov       rdx,7FF900D13878
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C84690
+       mov       rdx,7FF900D13898
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
-       mov       rdx,7FF900C846A8
+       mov       rdx,7FF900D138B0
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
-       mov       rdx,7FF900C847B8
+       mov       rdx,7FF900D139C0
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
-       mov       rdx,7FF900C84680
+       mov       rdx,7FF900D13888
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C2D2A8]
+       call      qword ptr [7FF900D06E38]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF900C84680
+       mov       rdx,7FF900D13888
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF900C2D320]
+       call      qword ptr [7FF900D06EB0]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF900C84680
+       mov       rdx,7FF900D13888
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C2D3B0]
+       call      qword ptr [7FF900D06F40]
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
-       mov       rdx,7FF900C847D0
+       mov       rdx,7FF900D139D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF90049E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9004AE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FF900AB63A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF900CBD650]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF900B7F098]
+       vmulss    xmm0,xmm0,dword ptr [7FF900D2ADF8]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF900AB6358]
+       jmp       qword ptr [7FF900CBD608]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
        mov       rcx,offset MT_System.Linq.IIListProvider<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A4C6F8
-       call      qword ptr [7FF900A34F18]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900A6C6F8
+       call      qword ptr [7FF900A559F8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,22061801FF0
+       mov       rcx,1A299801FF0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF900AB7420]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF900ADC1C8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FF900367A38]
+       call      qword ptr [7FF900387A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF8FFEB0F68
+       mov       r11,7FF8FFED0F68
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FF8FFFF4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FF900014378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FF900C84170
+       mov       rdx,7FF900CA48F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C84190
+       mov       rdx,offset System.ReadOnlySpan`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon[])
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
-       mov       rdx,7FF900C841A8
+       mov       rdx,7FF900CA4930
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
-       mov       rdx,7FF900C842B8
+       mov       rdx,7FF900CA4A40
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
-       mov       rdx,7FF900C84180
+       mov       rdx,7FF900CA4908
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C3E8F8]
+       call      qword ptr [7FF900C5EF28]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF900C84180
+       mov       rdx,7FF900CA4908
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF900C3E970]
+       call      qword ptr [7FF900C5EFA0]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF900C84180
+       mov       rdx,7FF900CA4908
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C3EA00]
+       call      qword ptr [7FF900C5F030]
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
-       mov       rdx,7FF900C842D0
+       mov       rdx,7FF900CA4A58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF90049E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9004BE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FF900AB7960]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF900ADC708]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF900B7F898]
+       vmulss    xmm0,xmm0,dword ptr [7FF900B9EE18]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF900AB7918]
+       jmp       qword ptr [7FF900ADC6C0]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
        mov       rcx,offset MT_System.Linq.IIListProvider<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A4C6F8
-       call      qword ptr [7FF900A34F18]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900A5C6F8
+       call      qword ptr [7FF900A44F18]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,22061801FF0
+       mov       rcx,2BC4DC01FF0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF900AB7420]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF900AC7120]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FF900367A38]
+       call      qword ptr [7FF900377A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF8FFEB0F68
+       mov       r11,7FF8FFEC0F68
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FF8FFFF4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FF900004378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FF900C84170
+       mov       rdx,7FF900C94280
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C84190
+       mov       rdx,7FF900C942A0
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
-       mov       rdx,7FF900C841A8
+       mov       rdx,7FF900C942B8
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
-       mov       rdx,7FF900C842B8
+       mov       rdx,7FF900C943C8
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
-       mov       rdx,7FF900C84180
+       mov       rdx,7FF900C94290
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C3E8F8]
+       call      qword ptr [7FF900C4E8F8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF900C84180
+       mov       rdx,7FF900C94290
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF900C3E970]
+       call      qword ptr [7FF900C4E970]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF900C84180
+       mov       rdx,7FF900C94290
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C3EA00]
+       call      qword ptr [7FF900C4EA00]
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
-       mov       rdx,7FF900C842D0
+       mov       rdx,7FF900C943E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF90049E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9004AE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FF900AB7960]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF900AC7660]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF900B7F898]
+       vmulss    xmm0,xmm0,dword ptr [7FF900B8E958]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF900AB7918]
+       jmp       qword ptr [7FF900AC7618]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
        mov       rcx,offset MT_System.Linq.IIListProvider<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A4C6F8
-       call      qword ptr [7FF900A34F18]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900A5C6F8
+       call      qword ptr [7FF900A44F18]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,22061801FF0
+       mov       rcx,1615E401FF0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF900AB7420]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF900AC7420]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FF900367A38]
+       call      qword ptr [7FF900377A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF8FFEB0F68
+       mov       r11,7FF8FFEC0F68
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FF8FFFF4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FF900004378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FF900C84170
+       mov       rdx,7FF900C94360
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C84190
+       mov       rdx,7FF900C94380
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
-       mov       rdx,7FF900C841A8
+       mov       rdx,7FF900C94398
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
-       mov       rdx,7FF900C842B8
+       mov       rdx,7FF900C944A8
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
-       mov       rdx,7FF900C84180
+       mov       rdx,7FF900C94370
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C3E8F8]
+       call      qword ptr [7FF900C4EAF0]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF900C84180
+       mov       rdx,7FF900C94370
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF900C3E970]
+       call      qword ptr [7FF900C4EB68]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF900C84180
+       mov       rdx,7FF900C94370
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C3EA00]
+       call      qword ptr [7FF900C4EBF8]
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
-       mov       rdx,7FF900C842D0
+       mov       rdx,7FF900C944C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF90049E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9004AE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FF900AB7960]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF900AC7960]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF900B7F898]
+       vmulss    xmm0,xmm0,dword ptr [7FF900B8E898]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF900AB7918]
+       jmp       qword ptr [7FF900AC7918]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
        mov       rcx,offset MT_System.Linq.IIListProvider<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A4C6F8
-       call      qword ptr [7FF900A34F18]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900A7C6F8
+       call      qword ptr [7FF900A64F18]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,22061801FF0
+       mov       rcx,18B46801FF0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF900AB7420]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF900AE7120]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FF900367A38]
+       call      qword ptr [7FF900397A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF8FFEB0F68
+       mov       r11,7FF8FFEE0F68
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FF8FFFF4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FF900024378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FF900C84170
+       mov       rdx,7FF900CB51A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C84190
+       mov       rdx,7FF900CB51C8
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
-       mov       rdx,7FF900C841A8
+       mov       rdx,7FF900CB51E0
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
-       mov       rdx,7FF900C842B8
+       mov       rdx,7FF900CB52F0
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
-       mov       rdx,7FF900C84180
+       mov       rdx,7FF900CB51B8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C3E8F8]
+       call      qword ptr [7FF900C6E8F8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF900C84180
+       mov       rdx,7FF900CB51B8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF900C3E970]
+       call      qword ptr [7FF900C6E970]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF900C84180
+       mov       rdx,7FF900CB51B8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C3EA00]
+       call      qword ptr [7FF900C6EA00]
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
-       mov       rdx,7FF900C842D0
+       mov       rdx,7FF900CB5308
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF90049E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9004CE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FF900AB7960]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF900AE7660]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF900B7F898]
+       vmulss    xmm0,xmm0,dword ptr [7FF900BAE798]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF900AB7918]
+       jmp       qword ptr [7FF900AE7618]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
        mov       rcx,offset MT_System.Linq.IIListProvider<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A4C6F8
-       call      qword ptr [7FF900A34F18]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900A70D98
+       call      qword ptr [7FF900A4C528]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,22061801FF0
+       mov       rcx,206C3402008
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF900AB7420]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF900C1EA18]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FF900367A38]
+       call      qword ptr [7FF900377A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF8FFEB0F68
+       mov       r11,7FF8FFEC1260
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
-       je        short M01_L01
+       je        short M01_L03
        mov       rax,[rdx]
        movzx     r8d,word ptr [rax+0E]
        test      r8,r8
-       je        short M01_L04
+       je        short M01_L02
        mov       r10,[rax+38]
        cmp       r8,4
-       jl        short M01_L03
+       jl        short M01_L01
 M01_L00:
        cmp       [r10],rcx
-       jne       short M01_L02
-M01_L01:
-       mov       rax,rdx
-       ret
-M01_L02:
+       je        short M01_L03
        cmp       [r10+8],rcx
-       je        short M01_L01
+       je        short M01_L03
        cmp       [r10+10],rcx
-       je        short M01_L01
+       je        short M01_L03
        cmp       [r10+18],rcx
-       je        short M01_L01
+       je        short M01_L03
        add       r10,20
        add       r8,0FFFFFFFFFFFFFFFC
        cmp       r8,4
        jge       short M01_L00
        test      r8,r8
-       je        short M01_L04
-M01_L03:
+       je        short M01_L02
+M01_L01:
        cmp       [r10],rcx
-       je        short M01_L01
+       je        short M01_L03
        add       r10,8
        dec       r8
        test      r8,r8
-       jg        short M01_L03
-M01_L04:
+       jg        short M01_L01
+M01_L02:
        test      dword ptr [rax],406C0000
-       jne       short M01_L05
+       jne       short M01_L04
        xor       edx,edx
-       jmp       short M01_L01
-M01_L05:
-       jmp       qword ptr [7FF8FFFF4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
-; Total bytes of code 109
+M01_L03:
+       mov       rax,rdx
+       ret
+M01_L04:
+       jmp       qword ptr [7FF900004378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+; Total bytes of code 107
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
-       mov       rdx,7FF900C84170
+       mov       rdx,7FF900CDC6D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C84190
+       mov       rdx,7FF900CDC6F0
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
-       mov       rdx,7FF900C841A8
+       mov       rdx,7FF900CDC708
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
-       mov       rdx,7FF900C842B8
+       mov       rdx,7FF900CDC818
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
-       mov       rdx,7FF900C84180
+       mov       rdx,7FF900CDC6E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C3E8F8]
+       call      qword ptr [7FF900CF65E0]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF900C84180
+       mov       rdx,7FF900CDC6E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF900C3E970]
+       call      qword ptr [7FF900CF6658]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF900C84180
+       mov       rdx,7FF900CDC6E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C3EA00]
+       call      qword ptr [7FF900CF66E8]
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
-       mov       rdx,7FF900C842D0
+       mov       rdx,7FF900CDC830
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF90049E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9004AE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FF900AB7960]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF900C1EF58]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF900B7F898]
+       vmulss    xmm0,xmm0,dword ptr [7FF900B92758]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF900AB7918]
+       jmp       qword ptr [7FF900C1EF10]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
        mov       rcx,offset MT_System.Linq.IIListProvider<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A4C6F8
-       call      qword ptr [7FF900A34F18]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900AFFED0
+       call      qword ptr [7FF900B177C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,22061801FF0
+       mov       rcx,223FA014DF8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF900AB7420]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF900CBD110]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FF900367A38]
+       call      qword ptr [7FF900377A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF8FFEB0F68
+       mov       r11,7FF8FFEC1B28
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
+       jmp       qword ptr [7FF900004378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FF8FFFF4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FF900C84170
+       mov       rdx,7FF900D13878
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF8FFFF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C84190
+       mov       rdx,7FF900D13898
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
-       mov       rdx,7FF900C841A8
+       mov       rdx,7FF900D138B0
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
-       mov       rdx,7FF900C842B8
+       mov       rdx,7FF900D139C0
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
-       mov       rdx,7FF900C84180
+       mov       rdx,7FF900D13888
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C3E8F8]
+       call      qword ptr [7FF900D06E38]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF900C84180
+       mov       rdx,7FF900D13888
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF900C3E970]
+       call      qword ptr [7FF900D06EB0]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF900C84180
+       mov       rdx,7FF900D13888
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C3EA00]
+       call      qword ptr [7FF900D06F40]
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
-       mov       rdx,7FF900C842D0
+       mov       rdx,7FF900D139D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF90049E058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9004AE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FF900AB7960]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF900CBD650]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF900B7F898]
+       vmulss    xmm0,xmm0,dword ptr [7FF900D2ADF8]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF900AB7918]
+       jmp       qword ptr [7FF900CBD608]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
        mov       rcx,offset MT_System.Linq.IIListProvider<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
-       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A6C6F8
-       call      qword ptr [7FF900A559F8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900A5C6F8
+       call      qword ptr [7FF900A44F18]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1A299801FF0
+       mov       rcx,2BC4DC01FF0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF900ADC1C8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF900AC7120]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900377A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF8FFED0F68
+       mov       r11,7FF8FFEC0F68
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FF900014378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FF900004378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FF900CA48F8
+       mov       rdx,7FF900C94280
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,offset System.ReadOnlySpan`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon[])
+       mov       rdx,7FF900C942A0
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
-       mov       rdx,7FF900CA4930
+       mov       rdx,7FF900C942B8
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
-       mov       rdx,7FF900CA4A40
+       mov       rdx,7FF900C943C8
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
-       mov       rdx,7FF900CA4908
+       mov       rdx,7FF900C94290
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C5EF28]
+       call      qword ptr [7FF900C4E8F8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF900CA4908
+       mov       rdx,7FF900C94290
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF900C5EFA0]
+       call      qword ptr [7FF900C4E970]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF900CA4908
+       mov       rdx,7FF900C94290
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C5F030]
+       call      qword ptr [7FF900C4EA00]
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
-       mov       rdx,7FF900CA4A58
+       mov       rdx,7FF900C943E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9004BE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9004AE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FF900ADC708]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF900AC7660]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF900B9EE18]
+       vmulss    xmm0,xmm0,dword ptr [7FF900B8E958]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF900ADC6C0]
+       jmp       qword ptr [7FF900AC7618]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
        mov       rcx,offset MT_System.Linq.IIListProvider<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
-       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A6C6F8
-       call      qword ptr [7FF900A559F8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900A5C6F8
+       call      qword ptr [7FF900A44F18]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1A299801FF0
+       mov       rcx,1615E401FF0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF900ADC1C8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF900AC7420]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900377A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF8FFED0F68
+       mov       r11,7FF8FFEC0F68
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FF900014378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FF900004378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FF900CA48F8
+       mov       rdx,7FF900C94360
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,offset System.ReadOnlySpan`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon[])
+       mov       rdx,7FF900C94380
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
-       mov       rdx,7FF900CA4930
+       mov       rdx,7FF900C94398
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
-       mov       rdx,7FF900CA4A40
+       mov       rdx,7FF900C944A8
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
-       mov       rdx,7FF900CA4908
+       mov       rdx,7FF900C94370
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C5EF28]
+       call      qword ptr [7FF900C4EAF0]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF900CA4908
+       mov       rdx,7FF900C94370
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF900C5EFA0]
+       call      qword ptr [7FF900C4EB68]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF900CA4908
+       mov       rdx,7FF900C94370
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C5F030]
+       call      qword ptr [7FF900C4EBF8]
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
-       mov       rdx,7FF900CA4A58
+       mov       rdx,7FF900C944C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9004BE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9004AE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FF900ADC708]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF900AC7960]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF900B9EE18]
+       vmulss    xmm0,xmm0,dword ptr [7FF900B8E898]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF900ADC6C0]
+       jmp       qword ptr [7FF900AC7918]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
        mov       rcx,offset MT_System.Linq.IIListProvider<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
-       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A6C6F8
-       call      qword ptr [7FF900A559F8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900A7C6F8
+       call      qword ptr [7FF900A64F18]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1A299801FF0
+       mov       rcx,18B46801FF0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF900ADC1C8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF900AE7120]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900397A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF8FFED0F68
+       mov       r11,7FF8FFEE0F68
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FF900014378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FF900024378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FF900CA48F8
+       mov       rdx,7FF900CB51A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,offset System.ReadOnlySpan`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon[])
+       mov       rdx,7FF900CB51C8
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
-       mov       rdx,7FF900CA4930
+       mov       rdx,7FF900CB51E0
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
-       mov       rdx,7FF900CA4A40
+       mov       rdx,7FF900CB52F0
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
-       mov       rdx,7FF900CA4908
+       mov       rdx,7FF900CB51B8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C5EF28]
+       call      qword ptr [7FF900C6E8F8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF900CA4908
+       mov       rdx,7FF900CB51B8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF900C5EFA0]
+       call      qword ptr [7FF900C6E970]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF900CA4908
+       mov       rdx,7FF900CB51B8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C5F030]
+       call      qword ptr [7FF900C6EA00]
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
-       mov       rdx,7FF900CA4A58
+       mov       rdx,7FF900CB5308
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9004BE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9004CE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FF900ADC708]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF900AE7660]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF900B9EE18]
+       vmulss    xmm0,xmm0,dword ptr [7FF900BAE798]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF900ADC6C0]
+       jmp       qword ptr [7FF900AE7618]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
        mov       rcx,offset MT_System.Linq.IIListProvider<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
-       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A6C6F8
-       call      qword ptr [7FF900A559F8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900A70D98
+       call      qword ptr [7FF900A4C528]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1A299801FF0
+       mov       rcx,206C3402008
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF900ADC1C8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF900C1EA18]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900377A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF8FFED0F68
+       mov       r11,7FF8FFEC1260
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
-       je        short M01_L01
+       je        short M01_L03
        mov       rax,[rdx]
        movzx     r8d,word ptr [rax+0E]
        test      r8,r8
-       je        short M01_L04
+       je        short M01_L02
        mov       r10,[rax+38]
        cmp       r8,4
-       jl        short M01_L03
+       jl        short M01_L01
 M01_L00:
        cmp       [r10],rcx
-       jne       short M01_L02
-M01_L01:
-       mov       rax,rdx
-       ret
-M01_L02:
+       je        short M01_L03
        cmp       [r10+8],rcx
-       je        short M01_L01
+       je        short M01_L03
        cmp       [r10+10],rcx
-       je        short M01_L01
+       je        short M01_L03
        cmp       [r10+18],rcx
-       je        short M01_L01
+       je        short M01_L03
        add       r10,20
        add       r8,0FFFFFFFFFFFFFFFC
        cmp       r8,4
        jge       short M01_L00
        test      r8,r8
-       je        short M01_L04
-M01_L03:
+       je        short M01_L02
+M01_L01:
        cmp       [r10],rcx
-       je        short M01_L01
+       je        short M01_L03
        add       r10,8
        dec       r8
        test      r8,r8
-       jg        short M01_L03
-M01_L04:
+       jg        short M01_L01
+M01_L02:
        test      dword ptr [rax],406C0000
-       jne       short M01_L05
+       jne       short M01_L04
        xor       edx,edx
-       jmp       short M01_L01
-M01_L05:
-       jmp       qword ptr [7FF900014378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
-; Total bytes of code 109
+M01_L03:
+       mov       rax,rdx
+       ret
+M01_L04:
+       jmp       qword ptr [7FF900004378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+; Total bytes of code 107
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
-       mov       rdx,7FF900CA48F8
+       mov       rdx,7FF900CDC6D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,offset System.ReadOnlySpan`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon[])
+       mov       rdx,7FF900CDC6F0
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
-       mov       rdx,7FF900CA4930
+       mov       rdx,7FF900CDC708
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
-       mov       rdx,7FF900CA4A40
+       mov       rdx,7FF900CDC818
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
-       mov       rdx,7FF900CA4908
+       mov       rdx,7FF900CDC6E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C5EF28]
+       call      qword ptr [7FF900CF65E0]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF900CA4908
+       mov       rdx,7FF900CDC6E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF900C5EFA0]
+       call      qword ptr [7FF900CF6658]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF900CA4908
+       mov       rdx,7FF900CDC6E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C5F030]
+       call      qword ptr [7FF900CF66E8]
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
-       mov       rdx,7FF900CA4A58
+       mov       rdx,7FF900CDC830
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9004BE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9004AE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FF900ADC708]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF900C1EF58]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF900B9EE18]
+       vmulss    xmm0,xmm0,dword ptr [7FF900B92758]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF900ADC6C0]
+       jmp       qword ptr [7FF900C1EF10]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
        mov       rcx,offset MT_System.Linq.IIListProvider<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
-       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A6C6F8
-       call      qword ptr [7FF900A559F8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900AFFED0
+       call      qword ptr [7FF900B177C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1A299801FF0
+       mov       rcx,223FA014DF8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF900ADC1C8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF900CBD110]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FF900387A38]
+       call      qword ptr [7FF900377A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF8FFED0F68
+       mov       r11,7FF8FFEC1B28
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
+       jmp       qword ptr [7FF900004378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FF900014378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FF900CA48F8
+       mov       rdx,7FF900D13878
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF900014348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,offset System.ReadOnlySpan`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon[])
+       mov       rdx,7FF900D13898
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
-       mov       rdx,7FF900CA4930
+       mov       rdx,7FF900D138B0
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
-       mov       rdx,7FF900CA4A40
+       mov       rdx,7FF900D139C0
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
-       mov       rdx,7FF900CA4908
+       mov       rdx,7FF900D13888
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C5EF28]
+       call      qword ptr [7FF900D06E38]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF900CA4908
+       mov       rdx,7FF900D13888
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF900C5EFA0]
+       call      qword ptr [7FF900D06EB0]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF900CA4908
+       mov       rdx,7FF900D13888
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C5F030]
+       call      qword ptr [7FF900D06F40]
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
-       mov       rdx,7FF900CA4A58
+       mov       rdx,7FF900D139D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9004BE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9004AE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FF900ADC708]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF900CBD650]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF900B9EE18]
+       vmulss    xmm0,xmm0,dword ptr [7FF900D2ADF8]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF900ADC6C0]
+       jmp       qword ptr [7FF900CBD608]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```diff
lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,2BC4DC01FF0
+       mov       rcx,1615E401FF0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF900AC7120]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF900AC7420]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
        jmp       qword ptr [7FF900004378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FF900C94280
+       mov       rdx,7FF900C94360
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
        call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C942A0
+       mov       rdx,7FF900C94380
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
-       mov       rdx,7FF900C942B8
+       mov       rdx,7FF900C94398
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
-       mov       rdx,7FF900C943C8
+       mov       rdx,7FF900C944A8
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
-       mov       rdx,7FF900C94290
+       mov       rdx,7FF900C94370
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C4E8F8]
+       call      qword ptr [7FF900C4EAF0]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF900C94290
+       mov       rdx,7FF900C94370
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF900C4E970]
+       call      qword ptr [7FF900C4EB68]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF900C94290
+       mov       rdx,7FF900C94370
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C4EA00]
+       call      qword ptr [7FF900C4EBF8]
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
-       mov       rdx,7FF900C943E0
+       mov       rdx,7FF900C944C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
        call      qword ptr [7FF9004AE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FF900AC7660]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF900AC7960]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF900B8E958]
+       vmulss    xmm0,xmm0,dword ptr [7FF900B8E898]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF900AC7618]
+       jmp       qword ptr [7FF900AC7918]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
        mov       rcx,offset MT_System.Linq.IIListProvider<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
-       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A5C6F8
-       call      qword ptr [7FF900A44F18]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900A7C6F8
+       call      qword ptr [7FF900A64F18]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,2BC4DC01FF0
+       mov       rcx,18B46801FF0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF900AC7120]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF900AE7120]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FF900377A38]
+       call      qword ptr [7FF900397A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF8FFEC0F68
+       mov       r11,7FF8FFEE0F68
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FF900004378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FF900024378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FF900C94280
+       mov       rdx,7FF900CB51A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C942A0
+       mov       rdx,7FF900CB51C8
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
-       mov       rdx,7FF900C942B8
+       mov       rdx,7FF900CB51E0
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
-       mov       rdx,7FF900C943C8
+       mov       rdx,7FF900CB52F0
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
-       mov       rdx,7FF900C94290
+       mov       rdx,7FF900CB51B8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C4E8F8]
+       call      qword ptr [7FF900C6E8F8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF900C94290
+       mov       rdx,7FF900CB51B8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF900C4E970]
+       call      qword ptr [7FF900C6E970]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF900C94290
+       mov       rdx,7FF900CB51B8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C4EA00]
+       call      qword ptr [7FF900C6EA00]
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
-       mov       rdx,7FF900C943E0
+       mov       rdx,7FF900CB5308
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9004AE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9004CE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FF900AC7660]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF900AE7660]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF900B8E958]
+       vmulss    xmm0,xmm0,dword ptr [7FF900BAE798]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF900AC7618]
+       jmp       qword ptr [7FF900AE7618]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
        mov       rcx,offset MT_System.Linq.IIListProvider<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
        call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A5C6F8
-       call      qword ptr [7FF900A44F18]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900A70D98
+       call      qword ptr [7FF900A4C528]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,2BC4DC01FF0
+       mov       rcx,206C3402008
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF900AC7120]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF900C1EA18]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
        call      qword ptr [7FF900377A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF8FFEC0F68
+       mov       r11,7FF8FFEC1260
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
-       je        short M01_L01
+       je        short M01_L03
        mov       rax,[rdx]
        movzx     r8d,word ptr [rax+0E]
        test      r8,r8
-       je        short M01_L04
+       je        short M01_L02
        mov       r10,[rax+38]
        cmp       r8,4
-       jl        short M01_L03
+       jl        short M01_L01
 M01_L00:
        cmp       [r10],rcx
-       jne       short M01_L02
-M01_L01:
-       mov       rax,rdx
-       ret
-M01_L02:
+       je        short M01_L03
        cmp       [r10+8],rcx
-       je        short M01_L01
+       je        short M01_L03
        cmp       [r10+10],rcx
-       je        short M01_L01
+       je        short M01_L03
        cmp       [r10+18],rcx
-       je        short M01_L01
+       je        short M01_L03
        add       r10,20
        add       r8,0FFFFFFFFFFFFFFFC
        cmp       r8,4
        jge       short M01_L00
        test      r8,r8
-       je        short M01_L04
-M01_L03:
+       je        short M01_L02
+M01_L01:
        cmp       [r10],rcx
-       je        short M01_L01
+       je        short M01_L03
        add       r10,8
        dec       r8
        test      r8,r8
-       jg        short M01_L03
-M01_L04:
+       jg        short M01_L01
+M01_L02:
        test      dword ptr [rax],406C0000
-       jne       short M01_L05
+       jne       short M01_L04
        xor       edx,edx
-       jmp       short M01_L01
-M01_L05:
+M01_L03:
+       mov       rax,rdx
+       ret
+M01_L04:
        jmp       qword ptr [7FF900004378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
-; Total bytes of code 109
+; Total bytes of code 107
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
-       mov       rdx,7FF900C94280
+       mov       rdx,7FF900CDC6D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
        call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C942A0
+       mov       rdx,7FF900CDC6F0
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
-       mov       rdx,7FF900C942B8
+       mov       rdx,7FF900CDC708
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
-       mov       rdx,7FF900C943C8
+       mov       rdx,7FF900CDC818
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
-       mov       rdx,7FF900C94290
+       mov       rdx,7FF900CDC6E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C4E8F8]
+       call      qword ptr [7FF900CF65E0]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF900C94290
+       mov       rdx,7FF900CDC6E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF900C4E970]
+       call      qword ptr [7FF900CF6658]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF900C94290
+       mov       rdx,7FF900CDC6E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C4EA00]
+       call      qword ptr [7FF900CF66E8]
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
-       mov       rdx,7FF900C943E0
+       mov       rdx,7FF900CDC830
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
        call      qword ptr [7FF9004AE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FF900AC7660]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF900C1EF58]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF900B8E958]
+       vmulss    xmm0,xmm0,dword ptr [7FF900B92758]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF900AC7618]
+       jmp       qword ptr [7FF900C1EF10]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
        mov       rcx,offset MT_System.Linq.IIListProvider<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
        call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A5C6F8
-       call      qword ptr [7FF900A44F18]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900AFFED0
+       call      qword ptr [7FF900B177C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,2BC4DC01FF0
+       mov       rcx,223FA014DF8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF900AC7120]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF900CBD110]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
        call      qword ptr [7FF900377A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF8FFEC0F68
+       mov       r11,7FF8FFEC1B28
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
+       jmp       qword ptr [7FF900004378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FF900004378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FF900C94280
+       mov       rdx,7FF900D13878
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
        call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C942A0
+       mov       rdx,7FF900D13898
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
-       mov       rdx,7FF900C942B8
+       mov       rdx,7FF900D138B0
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
-       mov       rdx,7FF900C943C8
+       mov       rdx,7FF900D139C0
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
-       mov       rdx,7FF900C94290
+       mov       rdx,7FF900D13888
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C4E8F8]
+       call      qword ptr [7FF900D06E38]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF900C94290
+       mov       rdx,7FF900D13888
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF900C4E970]
+       call      qword ptr [7FF900D06EB0]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF900C94290
+       mov       rdx,7FF900D13888
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C4EA00]
+       call      qword ptr [7FF900D06F40]
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
-       mov       rdx,7FF900C943E0
+       mov       rdx,7FF900D139D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
        call      qword ptr [7FF9004AE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FF900AC7660]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF900CBD650]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF900B8E958]
+       vmulss    xmm0,xmm0,dword ptr [7FF900D2ADF8]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF900AC7618]
+       jmp       qword ptr [7FF900CBD608]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
        mov       rcx,offset MT_System.Linq.IIListProvider<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
-       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A5C6F8
-       call      qword ptr [7FF900A44F18]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900A7C6F8
+       call      qword ptr [7FF900A64F18]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1615E401FF0
+       mov       rcx,18B46801FF0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF900AC7420]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF900AE7120]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FF900377A38]
+       call      qword ptr [7FF900397A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF8FFEC0F68
+       mov       r11,7FF8FFEE0F68
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FF900004378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FF900024378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FF900C94360
+       mov       rdx,7FF900CB51A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C94380
+       mov       rdx,7FF900CB51C8
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
-       mov       rdx,7FF900C94398
+       mov       rdx,7FF900CB51E0
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
-       mov       rdx,7FF900C944A8
+       mov       rdx,7FF900CB52F0
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
-       mov       rdx,7FF900C94370
+       mov       rdx,7FF900CB51B8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C4EAF0]
+       call      qword ptr [7FF900C6E8F8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF900C94370
+       mov       rdx,7FF900CB51B8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF900C4EB68]
+       call      qword ptr [7FF900C6E970]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF900C94370
+       mov       rdx,7FF900CB51B8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C4EBF8]
+       call      qword ptr [7FF900C6EA00]
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
-       mov       rdx,7FF900C944C0
+       mov       rdx,7FF900CB5308
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9004AE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9004CE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FF900AC7960]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF900AE7660]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF900B8E898]
+       vmulss    xmm0,xmm0,dword ptr [7FF900BAE798]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF900AC7918]
+       jmp       qword ptr [7FF900AE7618]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
        mov       rcx,offset MT_System.Linq.IIListProvider<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
        call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A5C6F8
-       call      qword ptr [7FF900A44F18]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900A70D98
+       call      qword ptr [7FF900A4C528]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1615E401FF0
+       mov       rcx,206C3402008
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF900AC7420]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF900C1EA18]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
        call      qword ptr [7FF900377A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF8FFEC0F68
+       mov       r11,7FF8FFEC1260
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
-       je        short M01_L01
+       je        short M01_L03
        mov       rax,[rdx]
        movzx     r8d,word ptr [rax+0E]
        test      r8,r8
-       je        short M01_L04
+       je        short M01_L02
        mov       r10,[rax+38]
        cmp       r8,4
-       jl        short M01_L03
+       jl        short M01_L01
 M01_L00:
        cmp       [r10],rcx
-       jne       short M01_L02
-M01_L01:
-       mov       rax,rdx
-       ret
-M01_L02:
+       je        short M01_L03
        cmp       [r10+8],rcx
-       je        short M01_L01
+       je        short M01_L03
        cmp       [r10+10],rcx
-       je        short M01_L01
+       je        short M01_L03
        cmp       [r10+18],rcx
-       je        short M01_L01
+       je        short M01_L03
        add       r10,20
        add       r8,0FFFFFFFFFFFFFFFC
        cmp       r8,4
        jge       short M01_L00
        test      r8,r8
-       je        short M01_L04
-M01_L03:
+       je        short M01_L02
+M01_L01:
        cmp       [r10],rcx
-       je        short M01_L01
+       je        short M01_L03
        add       r10,8
        dec       r8
        test      r8,r8
-       jg        short M01_L03
-M01_L04:
+       jg        short M01_L01
+M01_L02:
        test      dword ptr [rax],406C0000
-       jne       short M01_L05
+       jne       short M01_L04
        xor       edx,edx
-       jmp       short M01_L01
-M01_L05:
+M01_L03:
+       mov       rax,rdx
+       ret
+M01_L04:
        jmp       qword ptr [7FF900004378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
-; Total bytes of code 109
+; Total bytes of code 107
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
-       mov       rdx,7FF900C94360
+       mov       rdx,7FF900CDC6D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
        call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C94380
+       mov       rdx,7FF900CDC6F0
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
-       mov       rdx,7FF900C94398
+       mov       rdx,7FF900CDC708
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
-       mov       rdx,7FF900C944A8
+       mov       rdx,7FF900CDC818
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
-       mov       rdx,7FF900C94370
+       mov       rdx,7FF900CDC6E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C4EAF0]
+       call      qword ptr [7FF900CF65E0]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF900C94370
+       mov       rdx,7FF900CDC6E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF900C4EB68]
+       call      qword ptr [7FF900CF6658]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF900C94370
+       mov       rdx,7FF900CDC6E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C4EBF8]
+       call      qword ptr [7FF900CF66E8]
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
-       mov       rdx,7FF900C944C0
+       mov       rdx,7FF900CDC830
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
        call      qword ptr [7FF9004AE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FF900AC7960]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF900C1EF58]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF900B8E898]
+       vmulss    xmm0,xmm0,dword ptr [7FF900B92758]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF900AC7918]
+       jmp       qword ptr [7FF900C1EF10]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
        mov       rcx,offset MT_System.Linq.IIListProvider<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
        call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A5C6F8
-       call      qword ptr [7FF900A44F18]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900AFFED0
+       call      qword ptr [7FF900B177C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1615E401FF0
+       mov       rcx,223FA014DF8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF900AC7420]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF900CBD110]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
        call      qword ptr [7FF900377A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF8FFEC0F68
+       mov       r11,7FF8FFEC1B28
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
+       jmp       qword ptr [7FF900004378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FF900004378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FF900C94360
+       mov       rdx,7FF900D13878
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
        call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900C94380
+       mov       rdx,7FF900D13898
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
-       mov       rdx,7FF900C94398
+       mov       rdx,7FF900D138B0
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
-       mov       rdx,7FF900C944A8
+       mov       rdx,7FF900D139C0
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
-       mov       rdx,7FF900C94370
+       mov       rdx,7FF900D13888
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C4EAF0]
+       call      qword ptr [7FF900D06E38]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF900C94370
+       mov       rdx,7FF900D13888
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF900C4EB68]
+       call      qword ptr [7FF900D06EB0]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF900C94370
+       mov       rdx,7FF900D13888
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C4EBF8]
+       call      qword ptr [7FF900D06F40]
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
-       mov       rdx,7FF900C944C0
+       mov       rdx,7FF900D139D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
        call      qword ptr [7FF9004AE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FF900AC7960]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF900CBD650]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF900B8E898]
+       vmulss    xmm0,xmm0,dword ptr [7FF900D2ADF8]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF900AC7918]
+       jmp       qword ptr [7FF900CBD608]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
        mov       rcx,offset MT_System.Linq.IIListProvider<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
-       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A7C6F8
-       call      qword ptr [7FF900A64F18]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900A70D98
+       call      qword ptr [7FF900A4C528]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,18B46801FF0
+       mov       rcx,206C3402008
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF900AE7120]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF900C1EA18]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FF900397A38]
+       call      qword ptr [7FF900377A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF8FFEE0F68
+       mov       r11,7FF8FFEC1260
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
-       je        short M01_L01
+       je        short M01_L03
        mov       rax,[rdx]
        movzx     r8d,word ptr [rax+0E]
        test      r8,r8
-       je        short M01_L04
+       je        short M01_L02
        mov       r10,[rax+38]
        cmp       r8,4
-       jl        short M01_L03
+       jl        short M01_L01
 M01_L00:
        cmp       [r10],rcx
-       jne       short M01_L02
-M01_L01:
-       mov       rax,rdx
-       ret
-M01_L02:
+       je        short M01_L03
        cmp       [r10+8],rcx
-       je        short M01_L01
+       je        short M01_L03
        cmp       [r10+10],rcx
-       je        short M01_L01
+       je        short M01_L03
        cmp       [r10+18],rcx
-       je        short M01_L01
+       je        short M01_L03
        add       r10,20
        add       r8,0FFFFFFFFFFFFFFFC
        cmp       r8,4
        jge       short M01_L00
        test      r8,r8
-       je        short M01_L04
-M01_L03:
+       je        short M01_L02
+M01_L01:
        cmp       [r10],rcx
-       je        short M01_L01
+       je        short M01_L03
        add       r10,8
        dec       r8
        test      r8,r8
-       jg        short M01_L03
-M01_L04:
+       jg        short M01_L01
+M01_L02:
        test      dword ptr [rax],406C0000
-       jne       short M01_L05
+       jne       short M01_L04
        xor       edx,edx
-       jmp       short M01_L01
-M01_L05:
-       jmp       qword ptr [7FF900024378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
-; Total bytes of code 109
+M01_L03:
+       mov       rax,rdx
+       ret
+M01_L04:
+       jmp       qword ptr [7FF900004378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+; Total bytes of code 107
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
-       mov       rdx,7FF900CB51A8
+       mov       rdx,7FF900CDC6D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900CB51C8
+       mov       rdx,7FF900CDC6F0
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
-       mov       rdx,7FF900CB51E0
+       mov       rdx,7FF900CDC708
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
-       mov       rdx,7FF900CB52F0
+       mov       rdx,7FF900CDC818
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
-       mov       rdx,7FF900CB51B8
+       mov       rdx,7FF900CDC6E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C6E8F8]
+       call      qword ptr [7FF900CF65E0]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF900CB51B8
+       mov       rdx,7FF900CDC6E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF900C6E970]
+       call      qword ptr [7FF900CF6658]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF900CB51B8
+       mov       rdx,7FF900CDC6E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C6EA00]
+       call      qword ptr [7FF900CF66E8]
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
-       mov       rdx,7FF900CB5308
+       mov       rdx,7FF900CDC830
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9004CE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9004AE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FF900AE7660]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF900C1EF58]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF900BAE798]
+       vmulss    xmm0,xmm0,dword ptr [7FF900B92758]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF900AE7618]
+       jmp       qword ptr [7FF900C1EF10]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
        mov       rcx,offset MT_System.Linq.IIListProvider<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
-       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A7C6F8
-       call      qword ptr [7FF900A64F18]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900AFFED0
+       call      qword ptr [7FF900B177C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,18B46801FF0
+       mov       rcx,223FA014DF8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF900AE7120]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF900CBD110]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FF900397A38]
+       call      qword ptr [7FF900377A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF8FFEE0F68
+       mov       r11,7FF8FFEC1B28
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
+       jmp       qword ptr [7FF900004378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FF900024378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FF900CB51A8
+       mov       rdx,7FF900D13878
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF900024348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900CB51C8
+       mov       rdx,7FF900D13898
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
-       mov       rdx,7FF900CB51E0
+       mov       rdx,7FF900D138B0
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
-       mov       rdx,7FF900CB52F0
+       mov       rdx,7FF900D139C0
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
-       mov       rdx,7FF900CB51B8
+       mov       rdx,7FF900D13888
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C6E8F8]
+       call      qword ptr [7FF900D06E38]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF900CB51B8
+       mov       rdx,7FF900D13888
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF900C6E970]
+       call      qword ptr [7FF900D06EB0]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF900CB51B8
+       mov       rdx,7FF900D13888
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900C6EA00]
+       call      qword ptr [7FF900D06F40]
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
-       mov       rdx,7FF900CB5308
+       mov       rdx,7FF900D139D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FF9004CE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FF9004AE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FF900AE7660]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF900CBD650]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF900BAE798]
+       vmulss    xmm0,xmm0,dword ptr [7FF900D2ADF8]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF900AE7618]
+       jmp       qword ptr [7FF900CBD608]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
.NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
        mov       rcx,offset MT_System.Linq.IIListProvider<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
        call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
-       mov       rcx,7FF900A70D98
-       call      qword ptr [7FF900A4C528]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       mov       rcx,7FF900AFFED0
+       call      qword ptr [7FF900B177C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,206C3402008
+       mov       rcx,223FA014DF8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FF900C1EA18]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FF900CBD110]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
        call      qword ptr [7FF900377A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FF8FFEC1260
+       mov       r11,7FF8FFEC1B28
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
-       je        short M01_L03
-       mov       rax,[rdx]
-       movzx     r8d,word ptr [rax+0E]
-       test      r8,r8
-       je        short M01_L02
-       mov       r10,[rax+38]
-       cmp       r8,4
-       jl        short M01_L01
+       je        short M01_L01
+       mov       r8,[rdx]
+       movzx     r10d,word ptr [r8+0E]
+       test      r10,r10
+       je        short M01_L05
+       mov       r9,[r8+38]
+       cmp       r10,4
+       jl        short M01_L04
 M01_L00:
-       cmp       [r10],rcx
-       je        short M01_L03
-       cmp       [r10+8],rcx
-       je        short M01_L03
-       cmp       [r10+10],rcx
-       je        short M01_L03
-       cmp       [r10+18],rcx
-       je        short M01_L03
-       add       r10,20
-       add       r8,0FFFFFFFFFFFFFFFC
-       cmp       r8,4
-       jge       short M01_L00
-       test      r8,r8
-       je        short M01_L02
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
-       cmp       [r10],rcx
-       je        short M01_L03
-       add       r10,8
-       dec       r8
-       test      r8,r8
-       jg        short M01_L01
-M01_L02:
-       test      dword ptr [rax],406C0000
-       jne       short M01_L04
-       xor       edx,edx
-M01_L03:
        mov       rax,rdx
        ret
-M01_L04:
+M01_L02:
        jmp       qword ptr [7FF900004378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
-; Total bytes of code 107
+M01_L03:
+       test      r10,r10
+       je        short M01_L05
+M01_L04:
+       cmp       [r9],rcx
+       je        short M01_L01
+       add       r9,8
+       dec       r10
+       test      r10,r10
+       jg        short M01_L04
+M01_L05:
+       test      dword ptr [r8],406C0000
+       jne       short M01_L02
+       xor       edx,edx
+       jmp       short M01_L01
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
-       mov       rdx,7FF900CDC6D0
+       mov       rdx,7FF900D13878
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
        call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FF900CDC6F0
+       mov       rdx,7FF900D13898
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
-       mov       rdx,7FF900CDC708
+       mov       rdx,7FF900D138B0
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
-       mov       rdx,7FF900CDC818
+       mov       rdx,7FF900D139C0
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
-       mov       rdx,7FF900CDC6E0
+       mov       rdx,7FF900D13888
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900CF65E0]
+       call      qword ptr [7FF900D06E38]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FF900CDC6E0
+       mov       rdx,7FF900D13888
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FF900CF6658]
+       call      qword ptr [7FF900D06EB0]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FF900CDC6E0
+       mov       rdx,7FF900D13888
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FF900CF66E8]
+       call      qword ptr [7FF900D06F40]
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
-       mov       rdx,7FF900CDC830
+       mov       rdx,7FF900D139D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
        call      qword ptr [7FF9004AE058]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FF900C1EF58]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FF900CBD650]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FF900B92758]
+       vmulss    xmm0,xmm0,dword ptr [7FF900D2ADF8]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FF900C1EF10]
+       jmp       qword ptr [7FF900CBD608]
 ; Total bytes of code 71
```
