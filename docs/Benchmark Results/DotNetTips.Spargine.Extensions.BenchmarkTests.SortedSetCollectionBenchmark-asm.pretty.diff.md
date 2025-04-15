## DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark-20250415-011641
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1F870C0F7E0
+       mov       r8,269AD00F7E0
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
-       call      qword ptr [7FFE3FCA6220]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3FC975D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1F870C0F7D8
+       mov       rdx,269AD00F7D8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        call      qword ptr [7FFE3F254210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1F870C0F7E0
+       mov       rcx,269AD00F7E0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
 M00_L03:
        xor       eax,eax
        jmp       short M00_L01
 ; Total bytes of code 159
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        push      rbp
+       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,40
+       sub       rsp,38
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
-       mov       [rbp-28],rcx
+       mov       [rbp-30],rcx
        mov       rsi,rcx
        mov       rdi,rdx
        mov       rbx,r8
        test      rdi,rdi
        je        near ptr M01_L16
        test      rbx,rbx
        je        near ptr M01_L17
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M01_L13
 M01_L00:
        mov       rcx,rdi
        call      qword ptr [r11]
-       mov       [rbp-30],rax
+       mov       [rbp-38],rax
        test      rax,rax
        je        near ptr M01_L11
        mov       rdi,[rax]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,rdx
+       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rdi,r14
        jne       near ptr M01_L11
        jmp       short M01_L05
 M01_L01:
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
-       mov       rcx,[rbp-30]
+       mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        cmp       [rbx+18],rdx
        jne       short M01_L04
-       mov       r14,[rax+30]
-       test      r14,r14
-       mov       rax,[rbp-30]
+       mov       r15,[rax+30]
+       test      r15,r15
+       mov       rax,[rbp-38]
        je        short M01_L05
-       mov       edx,[r14+8]
+       mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE89DD0
+       mov       rdx,7FFE3FE89E68
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
-       mov       rax,[rbp-30]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE3FCEFE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FD05CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
-       mov       rcx,[rbp-30]
+       mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        cmp       [rbx+18],rdx
        jne       short M01_L10
-       mov       r14,[rax+30]
-       test      r14,r14
-       mov       rax,[rbp-30]
+       mov       r15,[rax+30]
+       test      r15,r15
+       mov       rax,[rbp-38]
        je        short M01_L11
-       mov       edx,[r14+8]
+       mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE89DD0
+       mov       rdx,7FFE3FE89E68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
        mov       rcx,rax
        mov       r11,7FFE3F1110D0
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
-       mov       rax,[rbp-30]
        mov       rdi,[rax]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,rdx
+       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE3FCEFE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FD05CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE89CF8
+       mov       rdx,7FFE3FE89D90
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
 M01_L14:
-       mov       rax,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,rax
+       cmp       rdi,r14
        jne       short M01_L19
 M01_L15:
        mov       eax,1
-       add       rsp,40
+       add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
+       pop       r15
        pop       rbp
        ret
 M01_L16:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,[rbp-30]
+       mov       rcx,rax
        mov       r11,7FFE3F1110D8
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
-       add       rsp,40
+       add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
+       pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
+       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,30
+       sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
-       cmp       qword ptr [rbp-30],0
+       cmp       qword ptr [rbp-38],0
        je        short M01_L22
-       mov       rcx,[rbp-30]
+       mov       rcx,[rbp-38]
        mov       rdi,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,r11
+       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rdi,r14
        je        short M01_L22
+       mov       rcx,[rbp-38]
        mov       r11,7FFE3F1110D8
        call      qword ptr [r11]
 M01_L22:
        nop
-       add       rsp,30
+       add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
+       pop       r15
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1F870C0F7E0
+       mov       r8,1825E00F7E0
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
-       call      qword ptr [7FFE3FCA6220]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3FCA75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1F870C0F7D8
+       mov       rdx,1825E00F7D8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        call      qword ptr [7FFE3F254210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1F870C0F7E0
+       mov       rcx,1825E00F7E0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
 M00_L03:
        xor       eax,eax
        jmp       short M00_L01
 ; Total bytes of code 159
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        push      rbp
+       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,40
+       sub       rsp,38
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
-       mov       [rbp-28],rcx
+       mov       [rbp-30],rcx
        mov       rsi,rcx
        mov       rdi,rdx
        mov       rbx,r8
        test      rdi,rdi
        je        near ptr M01_L16
        test      rbx,rbx
        je        near ptr M01_L17
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M01_L13
 M01_L00:
        mov       rcx,rdi
        call      qword ptr [r11]
-       mov       [rbp-30],rax
+       mov       [rbp-38],rax
        test      rax,rax
        je        near ptr M01_L11
        mov       rdi,[rax]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,rdx
+       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rdi,r14
        jne       near ptr M01_L11
        jmp       short M01_L05
 M01_L01:
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
-       mov       rcx,[rbp-30]
+       mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        cmp       [rbx+18],rdx
        jne       short M01_L04
-       mov       r14,[rax+30]
-       test      r14,r14
-       mov       rax,[rbp-30]
+       mov       r15,[rax+30]
+       test      r15,r15
+       mov       rax,[rbp-38]
        je        short M01_L05
-       mov       edx,[r14+8]
+       mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE89DD0
+       mov       rdx,7FFE3FE99A20
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
-       mov       rax,[rbp-30]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE3FCEFE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FD05CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
-       mov       rcx,[rbp-30]
+       mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        cmp       [rbx+18],rdx
        jne       short M01_L10
-       mov       r14,[rax+30]
-       test      r14,r14
-       mov       rax,[rbp-30]
+       mov       r15,[rax+30]
+       test      r15,r15
+       mov       rax,[rbp-38]
        je        short M01_L11
-       mov       edx,[r14+8]
+       mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE89DD0
+       mov       rdx,7FFE3FE99A20
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
        mov       rcx,rax
        mov       r11,7FFE3F1110D0
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
-       mov       rax,[rbp-30]
        mov       rdi,[rax]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,rdx
+       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE3FCEFE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FD05CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE89CF8
+       mov       rdx,7FFE3FE99948
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
 M01_L14:
-       mov       rax,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,rax
+       cmp       rdi,r14
        jne       short M01_L19
 M01_L15:
        mov       eax,1
-       add       rsp,40
+       add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
+       pop       r15
        pop       rbp
        ret
 M01_L16:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,[rbp-30]
+       mov       rcx,rax
        mov       r11,7FFE3F1110D8
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
-       add       rsp,40
+       add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
+       pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
+       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,30
+       sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
-       cmp       qword ptr [rbp-30],0
+       cmp       qword ptr [rbp-38],0
        je        short M01_L22
-       mov       rcx,[rbp-30]
+       mov       rcx,[rbp-38]
        mov       rdi,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,r11
+       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rdi,r14
        je        short M01_L22
+       mov       rcx,[rbp-38]
        mov       r11,7FFE3F1110D8
        call      qword ptr [r11]
 M01_L22:
        nop
-       add       rsp,30
+       add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
+       pop       r15
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
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1F870C0F7E0
+       mov       r8,1E144C0D7E8
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
-       call      qword ptr [7FFE3FCA6220]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3FCD75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1F870C0F7D8
+       mov       rdx,1E144C0D7E0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE3F254210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1F870C0F7E0
+       call      qword ptr [7FFE3F284210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1E144C0D7E8
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
 M00_L03:
        xor       eax,eax
        jmp       short M00_L01
 ; Total bytes of code 159
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        push      rbp
+       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,40
+       sub       rsp,38
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
-       mov       [rbp-28],rcx
+       mov       [rbp-30],rcx
        mov       rsi,rcx
        mov       rdi,rdx
        mov       rbx,r8
        test      rdi,rdi
        je        near ptr M01_L16
        test      rbx,rbx
        je        near ptr M01_L17
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M01_L13
 M01_L00:
        mov       rcx,rdi
        call      qword ptr [r11]
-       mov       [rbp-30],rax
+       mov       [rbp-38],rax
        test      rax,rax
        je        near ptr M01_L11
        mov       rdi,[rax]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,rdx
+       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rdi,r14
        jne       near ptr M01_L11
        jmp       short M01_L05
 M01_L01:
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
-       mov       rcx,[rbp-30]
+       mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        cmp       [rbx+18],rdx
        jne       short M01_L04
-       mov       r14,[rax+30]
-       test      r14,r14
-       mov       rax,[rbp-30]
+       mov       r15,[rax+30]
+       test      r15,r15
+       mov       rax,[rbp-38]
        je        short M01_L05
-       mov       edx,[r14+8]
+       mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE89DD0
+       mov       rdx,7FFE3FEC9BD0
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
-       mov       rax,[rbp-30]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE3FCEFE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FD35CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
-       mov       rcx,[rbp-30]
+       mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        cmp       [rbx+18],rdx
        jne       short M01_L10
-       mov       r14,[rax+30]
-       test      r14,r14
-       mov       rax,[rbp-30]
+       mov       r15,[rax+30]
+       test      r15,r15
+       mov       rax,[rbp-38]
        je        short M01_L11
-       mov       edx,[r14+8]
+       mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE89DD0
+       mov       rdx,7FFE3FEC9BD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE3F1110D0
+       mov       r11,7FFE3F1410D0
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
-       mov       rax,[rbp-30]
        mov       rdi,[rax]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,rdx
+       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE3FCEFE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FD35CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE89CF8
+       mov       rdx,7FFE3FEC9AF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
 M01_L14:
-       mov       rax,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,rax
+       cmp       rdi,r14
        jne       short M01_L19
 M01_L15:
        mov       eax,1
-       add       rsp,40
+       add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
+       pop       r15
        pop       rbp
        ret
 M01_L16:
        mov       ecx,10
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5F7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5F7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFE3F1110D8
+       mov       rcx,rax
+       mov       r11,7FFE3F1410D8
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
-       add       rsp,40
+       add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
+       pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
+       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,30
+       sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
-       cmp       qword ptr [rbp-30],0
+       cmp       qword ptr [rbp-38],0
        je        short M01_L22
-       mov       rcx,[rbp-30]
+       mov       rcx,[rbp-38]
        mov       rdi,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,r11
+       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rdi,r14
        je        short M01_L22
-       mov       r11,7FFE3F1110D8
+       mov       r11,7FFE3F1410D8
        call      qword ptr [r11]
 M01_L22:
        nop
-       add       rsp,30
+       add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 604
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
-       call      qword ptr [7FFE3F2541F8]
+       call      qword ptr [7FFE3F2841F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1F870C0F7E0
+       mov       r8,1AA0F00F7E0
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
-       call      qword ptr [7FFE3FCA6220]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3FCA75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1F870C0F7D8
+       mov       rdx,1AA0F00F7D8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE3F254210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1F870C0F7E0
+       call      qword ptr [7FFE3F264210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1AA0F00F7E0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
 M00_L03:
        xor       eax,eax
        jmp       short M00_L01
 ; Total bytes of code 159
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        push      rbp
+       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,40
+       sub       rsp,38
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
-       mov       [rbp-28],rcx
+       mov       [rbp-30],rcx
        mov       rsi,rcx
        mov       rdi,rdx
        mov       rbx,r8
        test      rdi,rdi
        je        near ptr M01_L16
        test      rbx,rbx
        je        near ptr M01_L17
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M01_L13
 M01_L00:
        mov       rcx,rdi
        call      qword ptr [r11]
-       mov       [rbp-30],rax
+       mov       [rbp-38],rax
        test      rax,rax
        je        near ptr M01_L11
        mov       rdi,[rax]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,rdx
+       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rdi,r14
        jne       near ptr M01_L11
        jmp       short M01_L05
 M01_L01:
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
-       mov       rcx,[rbp-30]
+       mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        cmp       [rbx+18],rdx
        jne       short M01_L04
-       mov       r14,[rax+30]
-       test      r14,r14
-       mov       rax,[rbp-30]
+       mov       r15,[rax+30]
+       test      r15,r15
+       mov       rax,[rbp-38]
        je        short M01_L05
-       mov       edx,[r14+8]
+       mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE89DD0
+       mov       rdx,7FFE3FE9A170
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        jne       near ptr M01_L14
 M01_L05:
-       mov       rax,[rbp-30]
+       mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE3FCEFE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FD15CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
-       mov       rcx,[rbp-30]
+       mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        cmp       [rbx+18],rdx
        jne       short M01_L10
-       mov       r14,[rax+30]
-       test      r14,r14
-       mov       rax,[rbp-30]
+       mov       r15,[rax+30]
+       test      r15,r15
+       mov       rax,[rbp-38]
        je        short M01_L11
-       mov       edx,[r14+8]
+       mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE89DD0
+       mov       rdx,7FFE3FE9A170
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE3F1110D0
+       mov       r11,7FFE3F1210D0
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        jne       short M01_L14
 M01_L11:
-       mov       rax,[rbp-30]
+       mov       rax,[rbp-38]
        mov       rdi,[rax]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,rdx
+       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE3FCEFE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FD15CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE89CF8
+       mov       rdx,7FFE3FE9A098
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
 M01_L14:
-       mov       rax,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,rax
+       cmp       rdi,r14
        jne       short M01_L19
 M01_L15:
        mov       eax,1
-       add       rsp,40
+       add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
+       pop       r15
        pop       rbp
        ret
 M01_L16:
        mov       ecx,10
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5D7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5D7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFE3F1110D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE3F1210D8
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
-       add       rsp,40
+       add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
+       pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
+       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,30
+       sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
-       cmp       qword ptr [rbp-30],0
+       cmp       qword ptr [rbp-38],0
        je        short M01_L22
-       mov       rcx,[rbp-30]
+       mov       rcx,[rbp-38]
        mov       rdi,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,r11
+       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rdi,r14
        je        short M01_L22
-       mov       r11,7FFE3F1110D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE3F1210D8
        call      qword ptr [r11]
 M01_L22:
        nop
-       add       rsp,30
+       add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 604
+; Total bytes of code 608
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
-       call      qword ptr [7FFE3F2541F8]
+       call      qword ptr [7FFE3F2641F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1F870C0F7E0
+       mov       r8,12FAF40D7E8
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
-       call      qword ptr [7FFE3FCA6220]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3FCD75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1F870C0F7D8
+       mov       rdx,12FAF40D7E0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE3F254210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1F870C0F7E0
+       call      qword ptr [7FFE3F284210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,12FAF40D7E8
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
 M00_L03:
        xor       eax,eax
        jmp       short M00_L01
 ; Total bytes of code 159
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        push      rbp
+       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,40
+       sub       rsp,38
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
-       mov       [rbp-28],rcx
+       mov       [rbp-30],rcx
        mov       rsi,rcx
        mov       rdi,rdx
        mov       rbx,r8
        test      rdi,rdi
        je        near ptr M01_L16
        test      rbx,rbx
        je        near ptr M01_L17
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M01_L13
 M01_L00:
        mov       rcx,rdi
        call      qword ptr [r11]
-       mov       [rbp-30],rax
+       mov       [rbp-38],rax
        test      rax,rax
        je        near ptr M01_L11
        mov       rdi,[rax]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,rdx
+       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rdi,r14
        jne       near ptr M01_L11
        jmp       short M01_L05
 M01_L01:
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
-       mov       rcx,[rbp-30]
+       mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        cmp       [rbx+18],rdx
        jne       short M01_L04
-       mov       r14,[rax+30]
-       test      r14,r14
-       mov       rax,[rbp-30]
+       mov       r15,[rax+30]
+       test      r15,r15
+       mov       rax,[rbp-38]
        je        short M01_L05
-       mov       edx,[r14+8]
+       mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE89DD0
+       mov       rdx,7FFE3FEC9D08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        jne       near ptr M01_L14
 M01_L05:
-       mov       rax,[rbp-30]
+       mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE3FCEFE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FD35CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
-       mov       rcx,[rbp-30]
+       mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        cmp       [rbx+18],rdx
        jne       short M01_L10
-       mov       r14,[rax+30]
-       test      r14,r14
-       mov       rax,[rbp-30]
+       mov       r15,[rax+30]
+       test      r15,r15
+       mov       rax,[rbp-38]
        je        short M01_L11
-       mov       edx,[r14+8]
+       mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE89DD0
+       mov       rdx,7FFE3FEC9D08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE3F1110D0
+       mov       r11,7FFE3F1410D0
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        jne       short M01_L14
 M01_L11:
-       mov       rax,[rbp-30]
+       mov       rax,[rbp-38]
        mov       rdi,[rax]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,rdx
+       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE3FCEFE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FD35CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE89CF8
+       mov       rdx,7FFE3FEC9C30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
 M01_L14:
-       mov       rax,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,rax
+       cmp       rdi,r14
        jne       short M01_L19
 M01_L15:
        mov       eax,1
-       add       rsp,40
+       add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
+       pop       r15
        pop       rbp
        ret
 M01_L16:
        mov       ecx,10
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5F7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5F7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFE3F1110D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE3F1410D8
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
-       add       rsp,40
+       add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
+       pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
+       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,30
+       sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
-       cmp       qword ptr [rbp-30],0
+       cmp       qword ptr [rbp-38],0
        je        short M01_L22
-       mov       rcx,[rbp-30]
+       mov       rcx,[rbp-38]
        mov       rdi,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,r11
+       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rdi,r14
        je        short M01_L22
-       mov       r11,7FFE3F1110D8
+       mov       r11,7FFE3F1410D8
        call      qword ptr [r11]
 M01_L22:
        nop
-       add       rsp,30
+       add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
+       pop       r15
        pop       rbp
        ret
 ; Total bytes of code 604
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
-       call      qword ptr [7FFE3F2541F8]
+       call      qword ptr [7FFE3F2841F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1F870C0F7E0
+       mov       r8,1E2F1402250
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
-       call      qword ptr [7FFE3FCA6220]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3FD8D5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1F870C0F7D8
+       mov       rdx,1E2F1402248
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE3F254210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1F870C0F7E0
+       mov       r8,7FFE3FE72AF0
+       call      qword ptr [7FFE3F274210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1E2F1402250
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
 M00_L03:
        xor       eax,eax
        jmp       short M00_L01
 ; Total bytes of code 159
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        push      rbp
+       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,40
+       sub       rsp,38
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
-       mov       [rbp-28],rcx
+       mov       [rbp-30],rcx
        mov       rsi,rcx
        mov       rdi,rdx
        mov       rbx,r8
        test      rdi,rdi
        je        near ptr M01_L16
        test      rbx,rbx
        je        near ptr M01_L17
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M01_L13
 M01_L00:
        mov       rcx,rdi
        call      qword ptr [r11]
-       mov       [rbp-30],rax
+       mov       [rbp-38],rax
        test      rax,rax
        je        near ptr M01_L11
        mov       rdi,[rax]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,rdx
+       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rdi,r14
        jne       near ptr M01_L11
        jmp       short M01_L05
 M01_L01:
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
-       mov       rcx,[rbp-30]
+       mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       rdx,7FFE3FE72AF0
        cmp       [rbx+18],rdx
        jne       short M01_L04
-       mov       r14,[rax+30]
-       test      r14,r14
-       mov       rax,[rbp-30]
+       mov       r15,[rax+30]
+       test      r15,r15
+       mov       rax,[rbp-38]
        je        short M01_L05
-       mov       edx,[r14+8]
+       mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE89DD0
+       mov       rdx,7FFE3FF37120
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        jne       near ptr M01_L14
 M01_L05:
-       mov       rax,[rbp-30]
+       mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE3FCEFE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FE76E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
-       mov       rcx,[rbp-30]
+       mov       rcx,[rbp-38]
        call      qword ptr [r11]
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       rdx,7FFE3FE72AF0
        cmp       [rbx+18],rdx
        jne       short M01_L10
-       mov       r14,[rax+30]
-       test      r14,r14
-       mov       rax,[rbp-30]
+       mov       r15,[rax+30]
+       test      r15,r15
+       mov       rax,[rbp-38]
        je        short M01_L11
-       mov       edx,[r14+8]
+       mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE89DD0
+       mov       rdx,7FFE3FF37120
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE3F1110D0
+       mov       r11,7FFE3F1312A0
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        jne       short M01_L14
 M01_L11:
-       mov       rax,[rbp-30]
+       mov       rax,[rbp-38]
        mov       rdi,[rax]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,rdx
+       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE3FCEFE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FE76E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE89CF8
+       mov       rdx,7FFE3FF37048
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
 M01_L14:
-       mov       rax,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,rax
+       cmp       rdi,r14
        jne       short M01_L19
 M01_L15:
        mov       eax,1
-       add       rsp,40
+       add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
+       pop       r15
        pop       rbp
        ret
 M01_L16:
        mov       ecx,10
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFE3F1110D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE3F1312A8
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
-       add       rsp,40
+       add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
+       pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
+       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,30
+       sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
-       cmp       qword ptr [rbp-30],0
+       cmp       qword ptr [rbp-38],0
        je        short M01_L22
-       mov       rcx,[rbp-30]
+       mov       rcx,[rbp-38]
        mov       rdi,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,r11
+       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rdi,r14
        je        short M01_L22
-       mov       r11,7FFE3F1110D8
+       mov       r11,7FFE3F1312A8
        call      qword ptr [r11]
 M01_L22:
        nop
-       add       rsp,30
+       add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
+       pop       r15
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
-       call      qword ptr [7FFE3F2541F8]
+M02_L00:
+       call      qword ptr [7FFE3F2741F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1F870C0F7E0
+       mov       r8,1E117C0D7E8
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
-       call      qword ptr [7FFE3FCA6220]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3FECEF40]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1F870C0F7D8
+       mov       rdx,1E117C0D7E0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE3F254210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1F870C0F7E0
+       call      qword ptr [7FFE3F274210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1E117C0D7E8
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        test      rsi,rsi
        jne       short M00_L00
 M00_L03:
        xor       eax,eax
        jmp       short M00_L01
 ; Total bytes of code 159
 ; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        push      rbp
+       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,40
+       sub       rsp,38
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
-       mov       [rbp-28],rcx
+       mov       [rbp-30],rcx
        mov       rsi,rcx
        mov       rdi,rdx
        mov       rbx,r8
        test      rdi,rdi
        je        near ptr M01_L16
        test      rbx,rbx
        je        near ptr M01_L17
        mov       rcx,[rsi+10]
        mov       r11,[rcx+20]
        test      r11,r11
        je        near ptr M01_L13
 M01_L00:
        mov       rcx,rdi
        call      qword ptr [r11]
-       mov       [rbp-30],rax
+       mov       [rbp-38],rax
        test      rax,rax
        je        near ptr M01_L11
        mov       rdi,[rax]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,rdx
+       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rdi,r14
        jne       near ptr M01_L11
        jmp       short M01_L05
 M01_L01:
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
-       mov       rcx,[rbp-30]
+       mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        cmp       [rbx+18],rdx
        jne       short M01_L04
-       mov       r14,[rax+30]
-       test      r14,r14
-       mov       rax,[rbp-30]
+       mov       r15,[rax+30]
+       test      r15,r15
+       mov       rax,[rbp-38]
        je        short M01_L05
-       mov       edx,[r14+8]
+       mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE89DD0
+       mov       rdx,7FFE3FF4B9C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        jne       near ptr M01_L14
 M01_L05:
-       mov       rax,[rbp-30]
+       mov       rax,[rbp-38]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE3FCEFE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FF264F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
-       mov       rcx,[rbp-30]
+       mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        cmp       [rbx+18],rdx
        jne       short M01_L10
-       mov       r14,[rax+30]
-       test      r14,r14
-       mov       rax,[rbp-30]
+       mov       r15,[rax+30]
+       test      r15,r15
+       mov       rax,[rbp-38]
        je        short M01_L11
-       mov       edx,[r14+8]
+       mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE89DD0
+       mov       rdx,7FFE3FF4B9C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE3F1110D0
+       mov       r11,7FFE3F131B68
        call      qword ptr [r11]
        jmp       short M01_L12
 M01_L10:
        mov       rdx,rax
        mov       rcx,[rbx+8]
        call      qword ptr [rbx+18]
        test      eax,eax
        jne       short M01_L14
 M01_L11:
-       mov       rax,[rbp-30]
+       mov       rax,[rbp-38]
        mov       rdi,[rax]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,rdx
+       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rdi,r14
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFE3FCEFE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FF264F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE89CF8
+       mov       rdx,7FFE3FF4B8E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
 M01_L14:
-       mov       rax,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,rax
+       cmp       rdi,r14
        jne       short M01_L19
 M01_L15:
        mov       eax,1
-       add       rsp,40
+       add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
+       pop       r15
        pop       rbp
        ret
 M01_L16:
        mov       ecx,10
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFE3F1110D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE3F131B70
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
-       add       rsp,40
+       add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
+       pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
+       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,30
+       sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
-       cmp       qword ptr [rbp-30],0
+       cmp       qword ptr [rbp-38],0
        je        short M01_L22
-       mov       rcx,[rbp-30]
+       mov       rcx,[rbp-38]
        mov       rdi,[rcx]
-       mov       r11,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,r11
+       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rdi,r14
        je        short M01_L22
-       mov       r11,7FFE3F1110D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE3F131B70
        call      qword ptr [r11]
 M01_L22:
        nop
-       add       rsp,30
+       add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 604
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
-       call      qword ptr [7FFE3F2541F8]
+       call      qword ptr [7FFE3F2741F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,269AD00F7E0
+       mov       r8,1825E00F7E0
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
-       call      qword ptr [7FFE3FC975D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3FCA75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,269AD00F7D8
+       mov       rdx,1825E00F7D8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        call      qword ptr [7FFE3F254210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,269AD00F7E0
+       mov       rcx,1825E00F7E0
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
-       mov       rdx,7FFE3FE89E68
+       mov       rdx,7FFE3FE99A20
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L02
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
-       mov       rdx,7FFE3FE89E68
+       mov       rdx,7FFE3FE99A20
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE89D90
+       mov       rdx,7FFE3FE99948
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,269AD00F7E0
+       mov       r8,1E144C0D7E8
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
-       call      qword ptr [7FFE3FC975D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3FCD75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,269AD00F7D8
+       mov       rdx,1E144C0D7E0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE3F254210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,269AD00F7E0
+       call      qword ptr [7FFE3F284210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1E144C0D7E8
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
-       mov       rdx,7FFE3FE89E68
+       mov       rdx,7FFE3FEC9BD0
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
-       call      qword ptr [7FFE3FD05CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FD35CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFE3FE89E68
+       mov       rdx,7FFE3FEC9BD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE3F1110D0
+       mov       r11,7FFE3F1410D0
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
-       call      qword ptr [7FFE3FD05CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FD35CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE89D90
+       mov       rdx,7FFE3FEC9AF8
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
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5F7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5F7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,rax
-       mov       r11,7FFE3F1110D8
+       mov       r11,7FFE3F1410D8
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
-       mov       r11,7FFE3F1110D8
+       mov       r11,7FFE3F1410D8
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
-       call      qword ptr [7FFE3F2541F8]
+       call      qword ptr [7FFE3F2841F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,269AD00F7E0
+       mov       r8,1AA0F00F7E0
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
-       call      qword ptr [7FFE3FC975D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3FCA75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,269AD00F7D8
+       mov       rdx,1AA0F00F7D8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE3F254210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,269AD00F7E0
+       call      qword ptr [7FFE3F264210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1AA0F00F7E0
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
-       mov       rdx,7FFE3FE89E68
+       mov       rdx,7FFE3FE9A170
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
-       call      qword ptr [7FFE3FD05CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FD15CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFE3FE89E68
+       mov       rdx,7FFE3FE9A170
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE3F1110D0
+       mov       r11,7FFE3F1210D0
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
-       call      qword ptr [7FFE3FD05CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FD15CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE89D90
+       mov       rdx,7FFE3FE9A098
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
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5D7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5D7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFE3F1110D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE3F1210D8
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
-       mov       r11,7FFE3F1110D8
+       mov       r11,7FFE3F1210D8
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
-       call      qword ptr [7FFE3F2541F8]
+       call      qword ptr [7FFE3F2641F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,269AD00F7E0
+       mov       r8,12FAF40D7E8
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
-       call      qword ptr [7FFE3FC975D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3FCD75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,269AD00F7D8
+       mov       rdx,12FAF40D7E0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE3F254210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,269AD00F7E0
+       call      qword ptr [7FFE3F284210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,12FAF40D7E8
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
-       mov       rdx,7FFE3FE89E68
+       mov       rdx,7FFE3FEC9D08
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
-       call      qword ptr [7FFE3FD05CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FD35CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFE3FE89E68
+       mov       rdx,7FFE3FEC9D08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE3F1110D0
+       mov       r11,7FFE3F1410D0
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
-       call      qword ptr [7FFE3FD05CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FD35CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE89D90
+       mov       rdx,7FFE3FEC9C30
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
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5F7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5F7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFE3F1110D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE3F1410D8
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
-       mov       r11,7FFE3F1110D8
+       mov       r11,7FFE3F1410D8
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
-       call      qword ptr [7FFE3F2541F8]
+       call      qword ptr [7FFE3F2841F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,269AD00F7E0
+       mov       r8,1E2F1402250
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
-       call      qword ptr [7FFE3FC975D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3FD8D5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,269AD00F7D8
+       mov       rdx,1E2F1402248
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE3F254210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,269AD00F7E0
+       mov       r8,7FFE3FE72AF0
+       call      qword ptr [7FFE3F274210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1E2F1402250
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
+       mov       rdx,7FFE3FE72AF0
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
-       mov       rdx,7FFE3FE89E68
+       mov       rdx,7FFE3FF37120
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
-       call      qword ptr [7FFE3FD05CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FE76E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FFE3FE72AF0
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
-       mov       rdx,7FFE3FE89E68
+       mov       rdx,7FFE3FF37120
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE3F1110D0
+       mov       r11,7FFE3F1312A0
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
-       call      qword ptr [7FFE3FD05CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FE76E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE89D90
+       mov       rdx,7FFE3FF37048
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
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFE3F1110D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE3F1312A8
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
-       mov       r11,7FFE3F1110D8
+       mov       r11,7FFE3F1312A8
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
-       call      qword ptr [7FFE3F2541F8]
+M02_L00:
+       call      qword ptr [7FFE3F2741F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,269AD00F7E0
+       mov       r8,1E117C0D7E8
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
-       call      qword ptr [7FFE3FC975D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3FECEF40]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,269AD00F7D8
+       mov       rdx,1E117C0D7E0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE3F254210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,269AD00F7E0
+       call      qword ptr [7FFE3F274210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1E117C0D7E8
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
-       mov       rdx,7FFE3FE89E68
+       mov       rdx,7FFE3FF4B9C0
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
-       call      qword ptr [7FFE3FD05CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FF264F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFE3FE89E68
+       mov       rdx,7FFE3FF4B9C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE3F1110D0
+       mov       r11,7FFE3F131B68
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
-       call      qword ptr [7FFE3FD05CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FF264F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE89D90
+       mov       rdx,7FFE3FF4B8E8
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
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFE3F1110D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE3F131B70
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
-       mov       r11,7FFE3F1110D8
+       mov       r11,7FFE3F131B70
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
-       call      qword ptr [7FFE3F2541F8]
+       call      qword ptr [7FFE3F2741F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1825E00F7E0
+       mov       r8,1E144C0D7E8
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
-       call      qword ptr [7FFE3FCA75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3FCD75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1825E00F7D8
+       mov       rdx,1E144C0D7E0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE3F254210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1825E00F7E0
+       call      qword ptr [7FFE3F284210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1E144C0D7E8
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
-       mov       rdx,7FFE3FE99A20
+       mov       rdx,7FFE3FEC9BD0
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
-       call      qword ptr [7FFE3FD05CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FD35CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFE3FE99A20
+       mov       rdx,7FFE3FEC9BD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE3F1110D0
+       mov       r11,7FFE3F1410D0
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
-       call      qword ptr [7FFE3FD05CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FD35CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE99948
+       mov       rdx,7FFE3FEC9AF8
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
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5F7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5F7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,rax
-       mov       r11,7FFE3F1110D8
+       mov       r11,7FFE3F1410D8
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
-       mov       r11,7FFE3F1110D8
+       mov       r11,7FFE3F1410D8
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
-       call      qword ptr [7FFE3F2541F8]
+       call      qword ptr [7FFE3F2841F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1825E00F7E0
+       mov       r8,1AA0F00F7E0
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
-       mov       rdx,1825E00F7D8
+       mov       rdx,1AA0F00F7D8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE3F254210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1825E00F7E0
+       call      qword ptr [7FFE3F264210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1AA0F00F7E0
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
-       mov       rdx,7FFE3FE99A20
+       mov       rdx,7FFE3FE9A170
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
-       call      qword ptr [7FFE3FD05CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FD15CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFE3FE99A20
+       mov       rdx,7FFE3FE9A170
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE3F1110D0
+       mov       r11,7FFE3F1210D0
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
-       call      qword ptr [7FFE3FD05CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FD15CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE99948
+       mov       rdx,7FFE3FE9A098
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
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5D7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5D7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFE3F1110D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE3F1210D8
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
-       mov       r11,7FFE3F1110D8
+       mov       r11,7FFE3F1210D8
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
-       call      qword ptr [7FFE3F2541F8]
+       call      qword ptr [7FFE3F2641F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1825E00F7E0
+       mov       r8,12FAF40D7E8
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
-       call      qword ptr [7FFE3FCA75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3FCD75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1825E00F7D8
+       mov       rdx,12FAF40D7E0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE3F254210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1825E00F7E0
+       call      qword ptr [7FFE3F284210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,12FAF40D7E8
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
-       mov       rdx,7FFE3FE99A20
+       mov       rdx,7FFE3FEC9D08
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
-       call      qword ptr [7FFE3FD05CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FD35CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFE3FE99A20
+       mov       rdx,7FFE3FEC9D08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE3F1110D0
+       mov       r11,7FFE3F1410D0
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
-       call      qword ptr [7FFE3FD05CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FD35CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE99948
+       mov       rdx,7FFE3FEC9C30
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
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5F7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5F7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFE3F1110D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE3F1410D8
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
-       mov       r11,7FFE3F1110D8
+       mov       r11,7FFE3F1410D8
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
-       call      qword ptr [7FFE3F2541F8]
+       call      qword ptr [7FFE3F2841F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1825E00F7E0
+       mov       r8,1E2F1402250
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
-       call      qword ptr [7FFE3FCA75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3FD8D5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1825E00F7D8
+       mov       rdx,1E2F1402248
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE3F254210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1825E00F7E0
+       mov       r8,7FFE3FE72AF0
+       call      qword ptr [7FFE3F274210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1E2F1402250
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
+       mov       rdx,7FFE3FE72AF0
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
-       mov       rdx,7FFE3FE99A20
+       mov       rdx,7FFE3FF37120
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
-       call      qword ptr [7FFE3FD05CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FE76E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FFE3FE72AF0
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
-       mov       rdx,7FFE3FE99A20
+       mov       rdx,7FFE3FF37120
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE3F1110D0
+       mov       r11,7FFE3F1312A0
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
-       call      qword ptr [7FFE3FD05CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FE76E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE99948
+       mov       rdx,7FFE3FF37048
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
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFE3F1110D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE3F1312A8
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
-       mov       r11,7FFE3F1110D8
+       mov       r11,7FFE3F1312A8
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
-       call      qword ptr [7FFE3F2541F8]
+M02_L00:
+       call      qword ptr [7FFE3F2741F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1825E00F7E0
+       mov       r8,1E117C0D7E8
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
-       call      qword ptr [7FFE3FCA75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3FECEF40]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1825E00F7D8
+       mov       rdx,1E117C0D7E0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE3F254210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1825E00F7E0
+       call      qword ptr [7FFE3F274210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1E117C0D7E8
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
-       mov       rdx,7FFE3FE99A20
+       mov       rdx,7FFE3FF4B9C0
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
-       call      qword ptr [7FFE3FD05CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FF264F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFE3FE99A20
+       mov       rdx,7FFE3FF4B9C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE3F1110D0
+       mov       r11,7FFE3F131B68
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
-       call      qword ptr [7FFE3FD05CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FF264F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE99948
+       mov       rdx,7FFE3FF4B8E8
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
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFE3F1110D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE3F131B70
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
-       mov       r11,7FFE3F1110D8
+       mov       r11,7FFE3F131B70
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
-       call      qword ptr [7FFE3F2541F8]
+       call      qword ptr [7FFE3F2741F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1E144C0D7E8
+       mov       r8,1AA0F00F7E0
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
-       call      qword ptr [7FFE3FCD75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3FCA75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1E144C0D7E0
+       mov       rdx,1AA0F00F7D8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE3F284210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1E144C0D7E8
+       call      qword ptr [7FFE3F264210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1AA0F00F7E0
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
-       mov       rdx,7FFE3FEC9BD0
+       mov       rdx,7FFE3FE9A170
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
-       call      qword ptr [7FFE3FD35CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FD15CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFE3FEC9BD0
+       mov       rdx,7FFE3FE9A170
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE3F1410D0
+       mov       r11,7FFE3F1210D0
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
-       call      qword ptr [7FFE3FD35CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FD15CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE3FEC9AF8
+       mov       rdx,7FFE3FE9A098
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
-       call      qword ptr [7FFE3F5F7A38]
+       call      qword ptr [7FFE3F5D7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE3F5F7A38]
+       call      qword ptr [7FFE3F5D7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFE3F1410D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE3F1210D8
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
-       mov       r11,7FFE3F1410D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE3F1210D8
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
-       call      qword ptr [7FFE3F2841F8]
+       call      qword ptr [7FFE3F2641F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1E144C0D7E8
+       mov       r8,12FAF40D7E8
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
-       mov       rdx,1E144C0D7E0
+       mov       rdx,12FAF40D7E0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        call      qword ptr [7FFE3F284210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1E144C0D7E8
+       mov       rcx,12FAF40D7E8
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
-       mov       rdx,7FFE3FEC9BD0
+       mov       rdx,7FFE3FEC9D08
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
        call      qword ptr [7FFE3FD35CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFE3FEC9BD0
+       mov       rdx,7FFE3FEC9D08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
        mov       rcx,rax
        mov       r11,7FFE3F1410D0
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
        call      qword ptr [7FFE3FD35CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE3FEC9AF8
+       mov       rdx,7FFE3FEC9C30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
+       mov       rcx,[rbp-38]
        mov       r11,7FFE3F1410D8
        call      qword ptr [r11]
        jmp       short M01_L15
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
        mov       r11,7FFE3F1410D8
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
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1E144C0D7E8
+       mov       r8,1E2F1402250
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
-       call      qword ptr [7FFE3FCD75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3FD8D5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1E144C0D7E0
+       mov       rdx,1E2F1402248
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE3F284210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1E144C0D7E8
+       mov       r8,7FFE3FE72AF0
+       call      qword ptr [7FFE3F274210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1E2F1402250
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
+       mov       rdx,7FFE3FE72AF0
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
-       mov       rdx,7FFE3FEC9BD0
+       mov       rdx,7FFE3FF37120
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
-       call      qword ptr [7FFE3FD35CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FE76E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FFE3FE72AF0
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
-       mov       rdx,7FFE3FEC9BD0
+       mov       rdx,7FFE3FF37120
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE3F1410D0
+       mov       r11,7FFE3F1312A0
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
-       call      qword ptr [7FFE3FD35CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FE76E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE3FEC9AF8
+       mov       rdx,7FFE3FF37048
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
-       call      qword ptr [7FFE3F5F7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE3F5F7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFE3F1410D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE3F1312A8
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
-       mov       r11,7FFE3F1410D8
+       mov       r11,7FFE3F1312A8
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
-       call      qword ptr [7FFE3F2841F8]
+M02_L00:
+       call      qword ptr [7FFE3F2741F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1E144C0D7E8
+       mov       r8,1E117C0D7E8
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
-       call      qword ptr [7FFE3FCD75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3FECEF40]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1E144C0D7E0
+       mov       rdx,1E117C0D7E0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE3F284210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1E144C0D7E8
+       call      qword ptr [7FFE3F274210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1E117C0D7E8
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
-       mov       rdx,7FFE3FEC9BD0
+       mov       rdx,7FFE3FF4B9C0
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
-       call      qword ptr [7FFE3FD35CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FF264F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFE3FEC9BD0
+       mov       rdx,7FFE3FF4B9C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE3F1410D0
+       mov       r11,7FFE3F131B68
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
-       call      qword ptr [7FFE3FD35CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FF264F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE3FEC9AF8
+       mov       rdx,7FFE3FF4B8E8
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
-       call      qword ptr [7FFE3F5F7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE3F5F7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFE3F1410D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE3F131B70
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
-       mov       r11,7FFE3F1410D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE3F131B70
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
-       call      qword ptr [7FFE3F2841F8]
+       call      qword ptr [7FFE3F2741F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1AA0F00F7E0
+       mov       r8,12FAF40D7E8
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
-       call      qword ptr [7FFE3FCA75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3FCD75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1AA0F00F7D8
+       mov       rdx,12FAF40D7E0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE3F264210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1AA0F00F7E0
+       call      qword ptr [7FFE3F284210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,12FAF40D7E8
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
-       mov       rdx,7FFE3FE9A170
+       mov       rdx,7FFE3FEC9D08
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
-       call      qword ptr [7FFE3FD15CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FD35CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFE3FE9A170
+       mov       rdx,7FFE3FEC9D08
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE3F1210D0
+       mov       r11,7FFE3F1410D0
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
-       call      qword ptr [7FFE3FD15CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FD35CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE9A098
+       mov       rdx,7FFE3FEC9C30
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
-       call      qword ptr [7FFE3F5D7A38]
+       call      qword ptr [7FFE3F5F7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE3F5D7A38]
+       call      qword ptr [7FFE3F5F7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE3F1210D8
+       mov       r11,7FFE3F1410D8
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
-       mov       r11,7FFE3F1210D8
+       mov       r11,7FFE3F1410D8
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
-       call      qword ptr [7FFE3F2641F8]
+       call      qword ptr [7FFE3F2841F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1AA0F00F7E0
+       mov       r8,1E2F1402250
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
-       call      qword ptr [7FFE3FCA75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3FD8D5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1AA0F00F7D8
+       mov       rdx,1E2F1402248
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE3F264210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1AA0F00F7E0
+       mov       r8,7FFE3FE72AF0
+       call      qword ptr [7FFE3F274210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1E2F1402250
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
+       mov       rdx,7FFE3FE72AF0
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
-       mov       rdx,7FFE3FE9A170
+       mov       rdx,7FFE3FF37120
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
-       call      qword ptr [7FFE3FD15CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FE76E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FFE3FE72AF0
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
-       mov       rdx,7FFE3FE9A170
+       mov       rdx,7FFE3FF37120
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE3F1210D0
+       mov       r11,7FFE3F1312A0
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
-       call      qword ptr [7FFE3FD15CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FE76E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE9A098
+       mov       rdx,7FFE3FF37048
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
-       call      qword ptr [7FFE3F5D7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE3F5D7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE3F1210D8
+       mov       r11,7FFE3F1312A8
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
-       mov       r11,7FFE3F1210D8
+       mov       r11,7FFE3F1312A8
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
-       call      qword ptr [7FFE3F2641F8]
+M02_L00:
+       call      qword ptr [7FFE3F2741F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1AA0F00F7E0
+       mov       r8,1E117C0D7E8
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
-       call      qword ptr [7FFE3FCA75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3FECEF40]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1AA0F00F7D8
+       mov       rdx,1E117C0D7E0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE3F264210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1AA0F00F7E0
+       call      qword ptr [7FFE3F274210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1E117C0D7E8
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
-       mov       rdx,7FFE3FE9A170
+       mov       rdx,7FFE3FF4B9C0
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
-       call      qword ptr [7FFE3FD15CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FF264F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFE3FE9A170
+       mov       rdx,7FFE3FF4B9C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE3F1210D0
+       mov       r11,7FFE3F131B68
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
-       call      qword ptr [7FFE3FD15CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FF264F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE3FE9A098
+       mov       rdx,7FFE3FF4B8E8
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
-       call      qword ptr [7FFE3F5D7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE3F5D7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE3F1210D8
+       mov       r11,7FFE3F131B70
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
-       mov       r11,7FFE3F1210D8
+       mov       r11,7FFE3F131B70
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
 ; Total bytes of code 608
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
-       call      qword ptr [7FFE3F2641F8]
+       call      qword ptr [7FFE3F2741F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,12FAF40D7E8
+       mov       r8,1E2F1402250
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
-       call      qword ptr [7FFE3FCD75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3FD8D5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,12FAF40D7E0
+       mov       rdx,1E2F1402248
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE3F284210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,12FAF40D7E8
+       mov       r8,7FFE3FE72AF0
+       call      qword ptr [7FFE3F274210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1E2F1402250
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
+       mov       rdx,7FFE3FE72AF0
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
-       mov       rdx,7FFE3FEC9D08
+       mov       rdx,7FFE3FF37120
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
-       call      qword ptr [7FFE3FD35CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FE76E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FFE3FE72AF0
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
-       mov       rdx,7FFE3FEC9D08
+       mov       rdx,7FFE3FF37120
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE3F1410D0
+       mov       r11,7FFE3F1312A0
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
-       call      qword ptr [7FFE3FD35CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FE76E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE3FEC9C30
+       mov       rdx,7FFE3FF37048
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
-       call      qword ptr [7FFE3F5F7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE3F5F7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE3F1410D8
+       mov       r11,7FFE3F1312A8
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
-       mov       r11,7FFE3F1410D8
+       mov       r11,7FFE3F1312A8
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
-       call      qword ptr [7FFE3F2841F8]
+M02_L00:
+       call      qword ptr [7FFE3F2741F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,12FAF40D7E8
+       mov       r8,1E117C0D7E8
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
-       call      qword ptr [7FFE3FCD75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3FECEF40]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,12FAF40D7E0
+       mov       rdx,1E117C0D7E0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE3F284210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,12FAF40D7E8
+       call      qword ptr [7FFE3F274210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1E117C0D7E8
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
-       mov       rdx,7FFE3FEC9D08
+       mov       rdx,7FFE3FF4B9C0
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
-       call      qword ptr [7FFE3FD35CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FF264F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFE3FEC9D08
+       mov       rdx,7FFE3FF4B9C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE3F1410D0
+       mov       r11,7FFE3F131B68
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
-       call      qword ptr [7FFE3FD35CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FF264F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE3FEC9C30
+       mov       rdx,7FFE3FF4B8E8
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
-       call      qword ptr [7FFE3F5F7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFE3F5F7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE3F1410D8
+       mov       r11,7FFE3F131B70
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
-       mov       r11,7FFE3F1410D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE3F131B70
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
-       call      qword ptr [7FFE3F2841F8]
+       call      qword ptr [7FFE3F2741F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+280]
-       mov       r8,1E2F1402250
+       mov       r8,1E117C0D7E8
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
-       call      qword ptr [7FFE3FD8D5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3FECEF40]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1E2F1402248
+       mov       rdx,1E117C0D7E0
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE3FE72AF0
+       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        call      qword ptr [7FFE3F274210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1E2F1402250
+       mov       rcx,1E117C0D7E8
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
-       mov       rdx,7FFE3FE72AF0
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
-       mov       rdx,7FFE3FF37120
+       mov       rdx,7FFE3FF4B9C0
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
-       call      qword ptr [7FFE3FE76E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FF264F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFE3FE72AF0
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
-       mov       rdx,7FFE3FF37120
+       mov       rdx,7FFE3FF4B9C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFE3F1312A0
+       mov       r11,7FFE3F131B68
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
-       call      qword ptr [7FFE3FE76E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFE3FF264F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFE3FF37048
+       mov       rdx,7FFE3FF4B8E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFE3F1312A8
+       mov       r11,7FFE3F131B70
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
-       mov       r11,7FFE3F1312A8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFE3F131B70
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
+M03_L00:
        call      qword ptr [7FFE3F2741F8]
        int       3
 ; Total bytes of code 44
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```diff

```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE3F264348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE3FC5F648]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3FCC4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1ACC9C01FE8
+       mov       rcx,19CB6401FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFE3FD24C00]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE3FD25E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFE3F5D7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFE3F121100
+       mov       r11,7FFE3F131100
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FFE3F264378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FFE3F274378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFE3FEBF060
+       mov       rdx,7FFE3FECF370
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFE3F264348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFE3FEBF080
+       mov       rdx,7FFE3FECF390
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
-       mov       rdx,7FFE3FEBF098
+       mov       rdx,7FFE3FECF3A8
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
-       mov       rdx,7FFE3FEBF1A8
+       mov       rdx,7FFE3FECF4B8
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
-       mov       rdx,7FFE3FEBF070
+       mov       rdx,7FFE3FECF380
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEC6CD0]
+       call      qword ptr [7FFE3FEE6D18]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEBF070
+       mov       rdx,7FFE3FECF380
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFE3FEC6D48]
+       call      qword ptr [7FFE3FEE6D90]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEBF070
+       mov       rdx,7FFE3FECF380
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEC6DD8]
+       call      qword ptr [7FFE3FEE6E20]
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
-       mov       rdx,7FFE3FEBF1C0
+       mov       rdx,7FFE3FECF4D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFE3F70D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFE3F71D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFE3FD25140]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFE3FD263A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFE3FDCFE38]
+       vmulss    xmm0,xmm0,dword ptr [7FFE3FDF0F78]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFE3FD250F8]
+       jmp       qword ptr [7FFE3FD26358]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE3F264348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE3FC5F648]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3FCB4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1ACC9C01FE8
+       mov       rcx,27B7B401FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFE3FD24C00]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE3FD26190]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFE3F5D7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFE3F121100
+       mov       r11,7FFE3F130FE0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FFE3F264378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FFE3F274378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFE3FEBF060
+       mov       rdx,7FFE3FECF858
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFE3F264348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFE3FEBF080
+       mov       rdx,7FFE3FECF878
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
-       mov       rdx,7FFE3FEBF098
+       mov       rdx,7FFE3FECF890
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
-       mov       rdx,7FFE3FEBF1A8
+       mov       rdx,7FFE3FECF9A0
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
-       mov       rdx,7FFE3FEBF070
+       mov       rdx,7FFE3FECF868
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEC6CD0]
+       call      qword ptr [7FFE3FEE6D00]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEBF070
+       mov       rdx,7FFE3FECF868
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFE3FEC6D48]
+       call      qword ptr [7FFE3FEE6D78]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEBF070
+       mov       rdx,7FFE3FECF868
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEC6DD8]
+       call      qword ptr [7FFE3FEE6E08]
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
-       mov       rdx,7FFE3FEBF1C0
+       mov       rdx,7FFE3FECF9B8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFE3F70D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFE3F71D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFE3FD25140]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFE3FD266D0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFE3FDCFE38]
+       vmulss    xmm0,xmm0,dword ptr [7FFE3FDDD1D8]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFE3FD250F8]
+       jmp       qword ptr [7FFE3FD26688]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE3F264348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F254348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE3FC5F648]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3FC94DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1ACC9C01FE8
+       mov       rcx,2B428801FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFE3FD24C00]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE3FD05E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFE3F5D7A38]
+       call      qword ptr [7FFE3F5C7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFE3F121100
+       mov       r11,7FFE3F110FE0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FFE3F264378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FFE3F254378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFE3FEBF060
+       mov       rdx,7FFE3FEAF8E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFE3F264348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F254348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFE3FEBF080
+       mov       rdx,7FFE3FEAF908
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
-       mov       rdx,7FFE3FEBF098
+       mov       rdx,7FFE3FEAF920
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
-       mov       rdx,7FFE3FEBF1A8
+       mov       rdx,7FFE3FEAFA30
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
-       mov       rdx,7FFE3FEBF070
+       mov       rdx,7FFE3FEAF8F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEC6CD0]
+       call      qword ptr [7FFE3FEC6D18]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEBF070
+       mov       rdx,7FFE3FEAF8F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFE3FEC6D48]
+       call      qword ptr [7FFE3FEC6D90]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEBF070
+       mov       rdx,7FFE3FEAF8F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEC6DD8]
+       call      qword ptr [7FFE3FEC6E20]
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
-       mov       rdx,7FFE3FEBF1C0
+       mov       rdx,7FFE3FEAFA48
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFE3F70D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFE3F6FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFE3FD25140]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFE3FD063A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFE3FDCFE38]
+       vmulss    xmm0,xmm0,dword ptr [7FFE3FDBD158]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFE3FD250F8]
+       jmp       qword ptr [7FFE3FD06358]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE3F264348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F284348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE3FC5F648]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3FCD4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1ACC9C01FE8
+       mov       rcx,22C86C01FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFE3FD24C00]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE3FD36580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFE3F5D7A38]
+       call      qword ptr [7FFE3F5F7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFE3F121100
+       mov       r11,7FFE3F140FE0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FFE3F264378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FFE3F284378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFE3FEBF060
+       mov       rdx,7FFE3FEDF378
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFE3F264348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F284348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFE3FEBF080
+       mov       rdx,7FFE3FEDF398
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
-       mov       rdx,7FFE3FEBF098
+       mov       rdx,7FFE3FEDF3B0
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
-       mov       rdx,7FFE3FEBF1A8
+       mov       rdx,7FFE3FEDF4C0
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
-       mov       rdx,7FFE3FEBF070
+       mov       rdx,7FFE3FEDF388
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEC6CD0]
+       call      qword ptr [7FFE3FEF6D00]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEBF070
+       mov       rdx,7FFE3FEDF388
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFE3FEC6D48]
+       call      qword ptr [7FFE3FEF6D78]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEBF070
+       mov       rdx,7FFE3FEDF388
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEC6DD8]
+       call      qword ptr [7FFE3FEF6E08]
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
-       mov       rdx,7FFE3FEBF1C0
+       mov       rdx,7FFE3FEDF4D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFE3F70D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFE3F72D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFE3FD25140]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFE3FD36AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFE3FDCFE38]
+       vmulss    xmm0,xmm0,dword ptr [7FFE3FDFD198]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFE3FD250F8]
+       jmp       qword ptr [7FFE3FD36A78]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        call      qword ptr [7FFE3F264348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE3FC5F648]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3FCA4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1ACC9C01FE8
+       mov       rcx,2409E001FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFE3FD24C00]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE3FD179A8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
        call      qword ptr [7FFE3F5D7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFE3F121100
+       mov       r11,7FFE3F121010
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        jmp       qword ptr [7FFE3F264378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFE3FEBF060
+       mov       rdx,7FFE3FEE2008
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
        call      qword ptr [7FFE3F264348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFE3FEBF080
+       mov       rdx,7FFE3FEE2028
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
-       mov       rdx,7FFE3FEBF098
+       mov       rdx,7FFE3FEE2040
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
-       mov       rdx,7FFE3FEBF1A8
+       mov       rdx,7FFE3FEE2150
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
-       mov       rdx,7FFE3FEBF070
+       mov       rdx,7FFE3FEE2018
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEC6CD0]
+       call      qword ptr [7FFE3FED72A0]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEBF070
+       mov       rdx,7FFE3FEE2018
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFE3FEC6D48]
+       call      qword ptr [7FFE3FED7318]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEBF070
+       mov       rdx,7FFE3FEE2018
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEC6DD8]
+       call      qword ptr [7FFE3FED73A8]
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
-       mov       rdx,7FFE3FEBF1C0
+       mov       rdx,7FFE3FEE2168
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
        call      qword ptr [7FFE3F70D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFE3FD25140]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFE3FD17EE8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFE3FDCFE38]
+       vmulss    xmm0,xmm0,dword ptr [7FFE3FDD6738]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFE3FD250F8]
+       jmp       qword ptr [7FFE3FD17EA0]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE3F264348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE3FC5F648]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3FD04498]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1ACC9C01FE8
+       mov       rcx,1E42D001FF8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFE3FD24C00]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE3FE77750]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFE3F5D7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFE3F121100
+       mov       r11,7FFE3F1312D8
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
+       jmp       qword ptr [7FFE3F274378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FFE3F264378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFE3FEBF060
+       mov       rdx,7FFE3FF57410
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFE3F264348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFE3FEBF080
+       mov       rdx,7FFE3FF57430
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
-       mov       rdx,7FFE3FEBF098
+       mov       rdx,7FFE3FF57448
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
-       mov       rdx,7FFE3FEBF1A8
+       mov       rdx,7FFE3FF57558
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
-       mov       rdx,7FFE3FEBF070
+       mov       rdx,7FFE3FF57420
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEC6CD0]
+       call      qword ptr [7FFE3FF74390]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEBF070
+       mov       rdx,7FFE3FF57420
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFE3FEC6D48]
+       call      qword ptr [7FFE3FF74408]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEBF070
+       mov       rdx,7FFE3FF57420
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEC6DD8]
+       call      qword ptr [7FFE3FF74498]
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
-       mov       rdx,7FFE3FEBF1C0
+       mov       rdx,7FFE3FF57570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFE3F70D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFE3F71D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFE3FD25140]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFE3FE77C90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFE3FDCFE38]
+       vmulss    xmm0,xmm0,dword ptr [7FFE3FDF1AB8]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFE3FD250F8]
+       jmp       qword ptr [7FFE3FE77C48]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE3F264348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F254348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE3FC5F648]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3FD66B98]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1ACC9C01FE8
+       mov       rcx,15A12C12BD0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFE3FD24C00]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE3FF06DC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFE3F5D7A38]
+       call      qword ptr [7FFE3F5C7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFE3F121100
+       mov       r11,7FFE3F111B10
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
+       jmp       qword ptr [7FFE3F254378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FFE3F264378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFE3FEBF060
+       mov       rdx,7FFE3FF3C688
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFE3F264348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F254348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFE3FEBF080
+       mov       rdx,7FFE3FF3C6A8
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
-       mov       rdx,7FFE3FEBF098
+       mov       rdx,7FFE3FF3C6C0
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
-       mov       rdx,7FFE3FEBF1A8
+       mov       rdx,7FFE3FF3C7D0
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
-       mov       rdx,7FFE3FEBF070
+       mov       rdx,7FFE3FF3C698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEC6CD0]
+       call      qword ptr [7FFE3FF0FE40]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEBF070
+       mov       rdx,7FFE3FF3C698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFE3FEC6D48]
+       call      qword ptr [7FFE3FF0FEB8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEBF070
+       mov       rdx,7FFE3FF3C698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEC6DD8]
+       call      qword ptr [7FFE3FF0FF48]
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
-       mov       rdx,7FFE3FEBF1C0
+       mov       rdx,7FFE3FF3C7E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFE3F70D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFE3F6FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFE3FD25140]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFE3FF07300]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFE3FDCFE38]
+       vmulss    xmm0,xmm0,dword ptr [7FFE3FDEBF78]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFE3FD250F8]
+       jmp       qword ptr [7FFE3FF072B8]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE3FCC4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3FCB4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,19CB6401FE8
+       mov       rcx,27B7B401FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFE3FD25E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE3FD26190]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
        call      qword ptr [7FFE3F5E7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFE3F131100
+       mov       r11,7FFE3F130FE0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        jmp       qword ptr [7FFE3F274378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFE3FECF370
+       mov       rdx,7FFE3FECF858
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
        call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFE3FECF390
+       mov       rdx,7FFE3FECF878
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
-       mov       rdx,7FFE3FECF3A8
+       mov       rdx,7FFE3FECF890
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
-       mov       rdx,7FFE3FECF4B8
+       mov       rdx,7FFE3FECF9A0
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
-       mov       rdx,7FFE3FECF380
+       mov       rdx,7FFE3FECF868
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEE6D18]
+       call      qword ptr [7FFE3FEE6D00]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFE3FECF380
+       mov       rdx,7FFE3FECF868
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFE3FEE6D90]
+       call      qword ptr [7FFE3FEE6D78]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFE3FECF380
+       mov       rdx,7FFE3FECF868
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEE6E20]
+       call      qword ptr [7FFE3FEE6E08]
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
-       mov       rdx,7FFE3FECF4D0
+       mov       rdx,7FFE3FECF9B8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
        call      qword ptr [7FFE3F71D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFE3FD263A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFE3FD266D0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFE3FDF0F78]
+       vmulss    xmm0,xmm0,dword ptr [7FFE3FDDD1D8]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFE3FD26358]
+       jmp       qword ptr [7FFE3FD26688]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F254348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE3FCC4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3FC94DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,19CB6401FE8
+       mov       rcx,2B428801FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFE3FD25E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE3FD05E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFE3F5E7A38]
+       call      qword ptr [7FFE3F5C7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFE3F131100
+       mov       r11,7FFE3F110FE0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FFE3F274378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FFE3F254378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFE3FECF370
+       mov       rdx,7FFE3FEAF8E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F254348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFE3FECF390
+       mov       rdx,7FFE3FEAF908
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
-       mov       rdx,7FFE3FECF3A8
+       mov       rdx,7FFE3FEAF920
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
-       mov       rdx,7FFE3FECF4B8
+       mov       rdx,7FFE3FEAFA30
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
-       mov       rdx,7FFE3FECF380
+       mov       rdx,7FFE3FEAF8F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEE6D18]
+       call      qword ptr [7FFE3FEC6D18]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFE3FECF380
+       mov       rdx,7FFE3FEAF8F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFE3FEE6D90]
+       call      qword ptr [7FFE3FEC6D90]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFE3FECF380
+       mov       rdx,7FFE3FEAF8F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEE6E20]
+       call      qword ptr [7FFE3FEC6E20]
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
-       mov       rdx,7FFE3FECF4D0
+       mov       rdx,7FFE3FEAFA48
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFE3F71D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFE3F6FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFE3FD263A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFE3FD063A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFE3FDF0F78]
+       vmulss    xmm0,xmm0,dword ptr [7FFE3FDBD158]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFE3FD26358]
+       jmp       qword ptr [7FFE3FD06358]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F284348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE3FCC4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3FCD4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,19CB6401FE8
+       mov       rcx,22C86C01FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFE3FD25E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE3FD36580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFE3F5E7A38]
+       call      qword ptr [7FFE3F5F7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFE3F131100
+       mov       r11,7FFE3F140FE0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FFE3F274378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FFE3F284378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFE3FECF370
+       mov       rdx,7FFE3FEDF378
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F284348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFE3FECF390
+       mov       rdx,7FFE3FEDF398
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
-       mov       rdx,7FFE3FECF3A8
+       mov       rdx,7FFE3FEDF3B0
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
-       mov       rdx,7FFE3FECF4B8
+       mov       rdx,7FFE3FEDF4C0
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
-       mov       rdx,7FFE3FECF380
+       mov       rdx,7FFE3FEDF388
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEE6D18]
+       call      qword ptr [7FFE3FEF6D00]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFE3FECF380
+       mov       rdx,7FFE3FEDF388
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFE3FEE6D90]
+       call      qword ptr [7FFE3FEF6D78]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFE3FECF380
+       mov       rdx,7FFE3FEDF388
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEE6E20]
+       call      qword ptr [7FFE3FEF6E08]
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
-       mov       rdx,7FFE3FECF4D0
+       mov       rdx,7FFE3FEDF4D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFE3F71D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFE3F72D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFE3FD263A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFE3FD36AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFE3FDF0F78]
+       vmulss    xmm0,xmm0,dword ptr [7FFE3FDFD198]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFE3FD26358]
+       jmp       qword ptr [7FFE3FD36A78]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F264348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE3FCC4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3FCA4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,19CB6401FE8
+       mov       rcx,2409E001FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFE3FD25E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE3FD179A8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFE3F5E7A38]
+       call      qword ptr [7FFE3F5D7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFE3F131100
+       mov       r11,7FFE3F121010
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FFE3F274378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FFE3F264378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFE3FECF370
+       mov       rdx,7FFE3FEE2008
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F264348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFE3FECF390
+       mov       rdx,7FFE3FEE2028
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
-       mov       rdx,7FFE3FECF3A8
+       mov       rdx,7FFE3FEE2040
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
-       mov       rdx,7FFE3FECF4B8
+       mov       rdx,7FFE3FEE2150
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
-       mov       rdx,7FFE3FECF380
+       mov       rdx,7FFE3FEE2018
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEE6D18]
+       call      qword ptr [7FFE3FED72A0]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFE3FECF380
+       mov       rdx,7FFE3FEE2018
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFE3FEE6D90]
+       call      qword ptr [7FFE3FED7318]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFE3FECF380
+       mov       rdx,7FFE3FEE2018
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEE6E20]
+       call      qword ptr [7FFE3FED73A8]
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
-       mov       rdx,7FFE3FECF4D0
+       mov       rdx,7FFE3FEE2168
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFE3F71D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFE3F70D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFE3FD263A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFE3FD17EE8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFE3FDF0F78]
+       vmulss    xmm0,xmm0,dword ptr [7FFE3FDD6738]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFE3FD26358]
+       jmp       qword ptr [7FFE3FD17EA0]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE3FCC4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3FD04498]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,19CB6401FE8
+       mov       rcx,1E42D001FF8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFE3FD25E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE3FE77750]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
        call      qword ptr [7FFE3F5E7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFE3F131100
+       mov       r11,7FFE3F1312D8
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
+       jmp       qword ptr [7FFE3F274378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FFE3F274378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFE3FECF370
+       mov       rdx,7FFE3FF57410
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
        call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFE3FECF390
+       mov       rdx,7FFE3FF57430
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
-       mov       rdx,7FFE3FECF3A8
+       mov       rdx,7FFE3FF57448
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
-       mov       rdx,7FFE3FECF4B8
+       mov       rdx,7FFE3FF57558
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
-       mov       rdx,7FFE3FECF380
+       mov       rdx,7FFE3FF57420
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEE6D18]
+       call      qword ptr [7FFE3FF74390]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFE3FECF380
+       mov       rdx,7FFE3FF57420
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFE3FEE6D90]
+       call      qword ptr [7FFE3FF74408]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFE3FECF380
+       mov       rdx,7FFE3FF57420
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEE6E20]
+       call      qword ptr [7FFE3FF74498]
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
-       mov       rdx,7FFE3FECF4D0
+       mov       rdx,7FFE3FF57570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
        call      qword ptr [7FFE3F71D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFE3FD263A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFE3FE77C90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFE3FDF0F78]
+       vmulss    xmm0,xmm0,dword ptr [7FFE3FDF1AB8]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFE3FD26358]
+       jmp       qword ptr [7FFE3FE77C48]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F254348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE3FCC4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3FD66B98]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,19CB6401FE8
+       mov       rcx,15A12C12BD0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFE3FD25E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE3FF06DC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFE3F5E7A38]
+       call      qword ptr [7FFE3F5C7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFE3F131100
+       mov       r11,7FFE3F111B10
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
+       jmp       qword ptr [7FFE3F254378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FFE3F274378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFE3FECF370
+       mov       rdx,7FFE3FF3C688
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F254348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFE3FECF390
+       mov       rdx,7FFE3FF3C6A8
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
-       mov       rdx,7FFE3FECF3A8
+       mov       rdx,7FFE3FF3C6C0
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
-       mov       rdx,7FFE3FECF4B8
+       mov       rdx,7FFE3FF3C7D0
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
-       mov       rdx,7FFE3FECF380
+       mov       rdx,7FFE3FF3C698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEE6D18]
+       call      qword ptr [7FFE3FF0FE40]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFE3FECF380
+       mov       rdx,7FFE3FF3C698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFE3FEE6D90]
+       call      qword ptr [7FFE3FF0FEB8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFE3FECF380
+       mov       rdx,7FFE3FF3C698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEE6E20]
+       call      qword ptr [7FFE3FF0FF48]
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
-       mov       rdx,7FFE3FECF4D0
+       mov       rdx,7FFE3FF3C7E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFE3F71D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFE3F6FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFE3FD263A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFE3FF07300]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFE3FDF0F78]
+       vmulss    xmm0,xmm0,dword ptr [7FFE3FDEBF78]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFE3FD26358]
+       jmp       qword ptr [7FFE3FF072B8]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F254348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE3FCB4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3FC94DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,27B7B401FE8
+       mov       rcx,2B428801FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFE3FD26190]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE3FD05E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFE3F5E7A38]
+       call      qword ptr [7FFE3F5C7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFE3F130FE0
+       mov       r11,7FFE3F110FE0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FFE3F274378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FFE3F254378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFE3FECF858
+       mov       rdx,7FFE3FEAF8E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F254348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFE3FECF878
+       mov       rdx,7FFE3FEAF908
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
-       mov       rdx,7FFE3FECF890
+       mov       rdx,7FFE3FEAF920
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
-       mov       rdx,7FFE3FECF9A0
+       mov       rdx,7FFE3FEAFA30
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
-       mov       rdx,7FFE3FECF868
+       mov       rdx,7FFE3FEAF8F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEE6D00]
+       call      qword ptr [7FFE3FEC6D18]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFE3FECF868
+       mov       rdx,7FFE3FEAF8F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFE3FEE6D78]
+       call      qword ptr [7FFE3FEC6D90]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFE3FECF868
+       mov       rdx,7FFE3FEAF8F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEE6E08]
+       call      qword ptr [7FFE3FEC6E20]
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
-       mov       rdx,7FFE3FECF9B8
+       mov       rdx,7FFE3FEAFA48
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFE3F71D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFE3F6FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFE3FD266D0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFE3FD063A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFE3FDDD1D8]
+       vmulss    xmm0,xmm0,dword ptr [7FFE3FDBD158]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFE3FD26688]
+       jmp       qword ptr [7FFE3FD06358]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F284348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE3FCB4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3FCD4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,27B7B401FE8
+       mov       rcx,22C86C01FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFE3FD26190]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE3FD36580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFE3F5E7A38]
+       call      qword ptr [7FFE3F5F7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFE3F130FE0
+       mov       r11,7FFE3F140FE0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FFE3F274378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FFE3F284378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFE3FECF858
+       mov       rdx,7FFE3FEDF378
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F284348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFE3FECF878
+       mov       rdx,7FFE3FEDF398
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
-       mov       rdx,7FFE3FECF890
+       mov       rdx,7FFE3FEDF3B0
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
-       mov       rdx,7FFE3FECF9A0
+       mov       rdx,7FFE3FEDF4C0
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
-       mov       rdx,7FFE3FECF868
+       mov       rdx,7FFE3FEDF388
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEE6D00]
+       call      qword ptr [7FFE3FEF6D00]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFE3FECF868
+       mov       rdx,7FFE3FEDF388
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFE3FEE6D78]
+       call      qword ptr [7FFE3FEF6D78]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFE3FECF868
+       mov       rdx,7FFE3FEDF388
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEE6E08]
+       call      qword ptr [7FFE3FEF6E08]
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
-       mov       rdx,7FFE3FECF9B8
+       mov       rdx,7FFE3FEDF4D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFE3F71D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFE3F72D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFE3FD266D0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFE3FD36AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFE3FDDD1D8]
+       vmulss    xmm0,xmm0,dword ptr [7FFE3FDFD198]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFE3FD26688]
+       jmp       qword ptr [7FFE3FD36A78]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F264348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE3FCB4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3FCA4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,27B7B401FE8
+       mov       rcx,2409E001FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFE3FD26190]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE3FD179A8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFE3F5E7A38]
+       call      qword ptr [7FFE3F5D7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFE3F130FE0
+       mov       r11,7FFE3F121010
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FFE3F274378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FFE3F264378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFE3FECF858
+       mov       rdx,7FFE3FEE2008
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F264348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFE3FECF878
+       mov       rdx,7FFE3FEE2028
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
-       mov       rdx,7FFE3FECF890
+       mov       rdx,7FFE3FEE2040
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
-       mov       rdx,7FFE3FECF9A0
+       mov       rdx,7FFE3FEE2150
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
-       mov       rdx,7FFE3FECF868
+       mov       rdx,7FFE3FEE2018
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEE6D00]
+       call      qword ptr [7FFE3FED72A0]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFE3FECF868
+       mov       rdx,7FFE3FEE2018
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFE3FEE6D78]
+       call      qword ptr [7FFE3FED7318]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFE3FECF868
+       mov       rdx,7FFE3FEE2018
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEE6E08]
+       call      qword ptr [7FFE3FED73A8]
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
-       mov       rdx,7FFE3FECF9B8
+       mov       rdx,7FFE3FEE2168
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFE3F71D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFE3F70D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFE3FD266D0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFE3FD17EE8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFE3FDDD1D8]
+       vmulss    xmm0,xmm0,dword ptr [7FFE3FDD6738]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFE3FD26688]
+       jmp       qword ptr [7FFE3FD17EA0]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE3FCB4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3FD04498]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,27B7B401FE8
+       mov       rcx,1E42D001FF8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFE3FD26190]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE3FE77750]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
        call      qword ptr [7FFE3F5E7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFE3F130FE0
+       mov       r11,7FFE3F1312D8
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
+       jmp       qword ptr [7FFE3F274378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FFE3F274378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFE3FECF858
+       mov       rdx,7FFE3FF57410
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
        call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFE3FECF878
+       mov       rdx,7FFE3FF57430
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
-       mov       rdx,7FFE3FECF890
+       mov       rdx,7FFE3FF57448
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
-       mov       rdx,7FFE3FECF9A0
+       mov       rdx,7FFE3FF57558
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
-       mov       rdx,7FFE3FECF868
+       mov       rdx,7FFE3FF57420
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEE6D00]
+       call      qword ptr [7FFE3FF74390]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFE3FECF868
+       mov       rdx,7FFE3FF57420
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFE3FEE6D78]
+       call      qword ptr [7FFE3FF74408]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFE3FECF868
+       mov       rdx,7FFE3FF57420
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEE6E08]
+       call      qword ptr [7FFE3FF74498]
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
-       mov       rdx,7FFE3FECF9B8
+       mov       rdx,7FFE3FF57570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
        call      qword ptr [7FFE3F71D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFE3FD266D0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFE3FE77C90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFE3FDDD1D8]
+       vmulss    xmm0,xmm0,dword ptr [7FFE3FDF1AB8]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFE3FD26688]
+       jmp       qword ptr [7FFE3FE77C48]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F254348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE3FCB4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3FD66B98]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,27B7B401FE8
+       mov       rcx,15A12C12BD0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFE3FD26190]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE3FF06DC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFE3F5E7A38]
+       call      qword ptr [7FFE3F5C7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFE3F130FE0
+       mov       r11,7FFE3F111B10
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
+       jmp       qword ptr [7FFE3F254378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FFE3F274378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFE3FECF858
+       mov       rdx,7FFE3FF3C688
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F254348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFE3FECF878
+       mov       rdx,7FFE3FF3C6A8
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
-       mov       rdx,7FFE3FECF890
+       mov       rdx,7FFE3FF3C6C0
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
-       mov       rdx,7FFE3FECF9A0
+       mov       rdx,7FFE3FF3C7D0
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
-       mov       rdx,7FFE3FECF868
+       mov       rdx,7FFE3FF3C698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEE6D00]
+       call      qword ptr [7FFE3FF0FE40]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFE3FECF868
+       mov       rdx,7FFE3FF3C698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFE3FEE6D78]
+       call      qword ptr [7FFE3FF0FEB8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFE3FECF868
+       mov       rdx,7FFE3FF3C698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEE6E08]
+       call      qword ptr [7FFE3FF0FF48]
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
-       mov       rdx,7FFE3FECF9B8
+       mov       rdx,7FFE3FF3C7E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFE3F71D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFE3F6FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFE3FD266D0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFE3FF07300]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFE3FDDD1D8]
+       vmulss    xmm0,xmm0,dword ptr [7FFE3FDEBF78]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFE3FD26688]
+       jmp       qword ptr [7FFE3FF072B8]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE3F254348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F284348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE3FC94DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3FCD4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,2B428801FE8
+       mov       rcx,22C86C01FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFE3FD05E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE3FD36580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5F7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFE3F110FE0
+       mov       r11,7FFE3F140FE0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FFE3F254378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FFE3F284378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFE3FEAF8E8
+       mov       rdx,7FFE3FEDF378
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFE3F254348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F284348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFE3FEAF908
+       mov       rdx,7FFE3FEDF398
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
-       mov       rdx,7FFE3FEAF920
+       mov       rdx,7FFE3FEDF3B0
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
-       mov       rdx,7FFE3FEAFA30
+       mov       rdx,7FFE3FEDF4C0
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
-       mov       rdx,7FFE3FEAF8F8
+       mov       rdx,7FFE3FEDF388
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEC6D18]
+       call      qword ptr [7FFE3FEF6D00]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEAF8F8
+       mov       rdx,7FFE3FEDF388
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFE3FEC6D90]
+       call      qword ptr [7FFE3FEF6D78]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEAF8F8
+       mov       rdx,7FFE3FEDF388
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEC6E20]
+       call      qword ptr [7FFE3FEF6E08]
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
-       mov       rdx,7FFE3FEAFA48
+       mov       rdx,7FFE3FEDF4D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFE3F6FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFE3F72D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFE3FD063A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFE3FD36AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFE3FDBD158]
+       vmulss    xmm0,xmm0,dword ptr [7FFE3FDFD198]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFE3FD06358]
+       jmp       qword ptr [7FFE3FD36A78]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE3F254348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F264348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE3FC94DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3FCA4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,2B428801FE8
+       mov       rcx,2409E001FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFE3FD05E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE3FD179A8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5D7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFE3F110FE0
+       mov       r11,7FFE3F121010
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FFE3F254378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FFE3F264378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFE3FEAF8E8
+       mov       rdx,7FFE3FEE2008
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFE3F254348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F264348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFE3FEAF908
+       mov       rdx,7FFE3FEE2028
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
-       mov       rdx,7FFE3FEAF920
+       mov       rdx,7FFE3FEE2040
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
-       mov       rdx,7FFE3FEAFA30
+       mov       rdx,7FFE3FEE2150
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
-       mov       rdx,7FFE3FEAF8F8
+       mov       rdx,7FFE3FEE2018
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEC6D18]
+       call      qword ptr [7FFE3FED72A0]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEAF8F8
+       mov       rdx,7FFE3FEE2018
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFE3FEC6D90]
+       call      qword ptr [7FFE3FED7318]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEAF8F8
+       mov       rdx,7FFE3FEE2018
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEC6E20]
+       call      qword ptr [7FFE3FED73A8]
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
-       mov       rdx,7FFE3FEAFA48
+       mov       rdx,7FFE3FEE2168
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFE3F6FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFE3F70D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFE3FD063A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFE3FD17EE8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFE3FDBD158]
+       vmulss    xmm0,xmm0,dword ptr [7FFE3FDD6738]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFE3FD06358]
+       jmp       qword ptr [7FFE3FD17EA0]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE3F254348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE3FC94DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3FD04498]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,2B428801FE8
+       mov       rcx,1E42D001FF8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFE3FD05E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE3FE77750]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFE3F5C7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFE3F110FE0
+       mov       r11,7FFE3F1312D8
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
+       jmp       qword ptr [7FFE3F274378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FFE3F254378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFE3FEAF8E8
+       mov       rdx,7FFE3FF57410
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFE3F254348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFE3FEAF908
+       mov       rdx,7FFE3FF57430
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
-       mov       rdx,7FFE3FEAF920
+       mov       rdx,7FFE3FF57448
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
-       mov       rdx,7FFE3FEAFA30
+       mov       rdx,7FFE3FF57558
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
-       mov       rdx,7FFE3FEAF8F8
+       mov       rdx,7FFE3FF57420
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEC6D18]
+       call      qword ptr [7FFE3FF74390]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEAF8F8
+       mov       rdx,7FFE3FF57420
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFE3FEC6D90]
+       call      qword ptr [7FFE3FF74408]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEAF8F8
+       mov       rdx,7FFE3FF57420
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEC6E20]
+       call      qword ptr [7FFE3FF74498]
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
-       mov       rdx,7FFE3FEAFA48
+       mov       rdx,7FFE3FF57570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFE3F6FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFE3F71D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFE3FD063A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFE3FE77C90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFE3FDBD158]
+       vmulss    xmm0,xmm0,dword ptr [7FFE3FDF1AB8]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFE3FD06358]
+       jmp       qword ptr [7FFE3FE77C48]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
        call      qword ptr [7FFE3F254348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE3FC94DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3FD66B98]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,2B428801FE8
+       mov       rcx,15A12C12BD0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFE3FD05E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE3FF06DC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
        call      qword ptr [7FFE3F5C7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFE3F110FE0
+       mov       r11,7FFE3F111B10
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
+       jmp       qword ptr [7FFE3F254378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FFE3F254378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFE3FEAF8E8
+       mov       rdx,7FFE3FF3C688
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
        call      qword ptr [7FFE3F254348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFE3FEAF908
+       mov       rdx,7FFE3FF3C6A8
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
-       mov       rdx,7FFE3FEAF920
+       mov       rdx,7FFE3FF3C6C0
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
-       mov       rdx,7FFE3FEAFA30
+       mov       rdx,7FFE3FF3C7D0
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
-       mov       rdx,7FFE3FEAF8F8
+       mov       rdx,7FFE3FF3C698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEC6D18]
+       call      qword ptr [7FFE3FF0FE40]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEAF8F8
+       mov       rdx,7FFE3FF3C698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFE3FEC6D90]
+       call      qword ptr [7FFE3FF0FEB8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEAF8F8
+       mov       rdx,7FFE3FF3C698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEC6E20]
+       call      qword ptr [7FFE3FF0FF48]
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
-       mov       rdx,7FFE3FEAFA48
+       mov       rdx,7FFE3FF3C7E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
        call      qword ptr [7FFE3F6FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFE3FD063A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFE3FF07300]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFE3FDBD158]
+       vmulss    xmm0,xmm0,dword ptr [7FFE3FDEBF78]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFE3FD06358]
+       jmp       qword ptr [7FFE3FF072B8]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE3F284348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F264348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE3FCD4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3FCA4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,22C86C01FE8
+       mov       rcx,2409E001FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFE3FD36580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE3FD179A8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFE3F5F7A38]
+       call      qword ptr [7FFE3F5D7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFE3F140FE0
+       mov       r11,7FFE3F121010
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FFE3F284378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FFE3F264378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFE3FEDF378
+       mov       rdx,7FFE3FEE2008
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFE3F284348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F264348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFE3FEDF398
+       mov       rdx,7FFE3FEE2028
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
-       mov       rdx,7FFE3FEDF3B0
+       mov       rdx,7FFE3FEE2040
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
-       mov       rdx,7FFE3FEDF4C0
+       mov       rdx,7FFE3FEE2150
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
-       mov       rdx,7FFE3FEDF388
+       mov       rdx,7FFE3FEE2018
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEF6D00]
+       call      qword ptr [7FFE3FED72A0]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEDF388
+       mov       rdx,7FFE3FEE2018
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFE3FEF6D78]
+       call      qword ptr [7FFE3FED7318]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEDF388
+       mov       rdx,7FFE3FEE2018
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEF6E08]
+       call      qword ptr [7FFE3FED73A8]
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
-       mov       rdx,7FFE3FEDF4D8
+       mov       rdx,7FFE3FEE2168
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFE3F72D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFE3F70D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFE3FD36AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFE3FD17EE8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFE3FDFD198]
+       vmulss    xmm0,xmm0,dword ptr [7FFE3FDD6738]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFE3FD36A78]
+       jmp       qword ptr [7FFE3FD17EA0]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE3F284348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE3FCD4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3FD04498]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,22C86C01FE8
+       mov       rcx,1E42D001FF8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFE3FD36580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE3FE77750]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFE3F5F7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFE3F140FE0
+       mov       r11,7FFE3F1312D8
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
+       jmp       qword ptr [7FFE3F274378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FFE3F284378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFE3FEDF378
+       mov       rdx,7FFE3FF57410
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFE3F284348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFE3FEDF398
+       mov       rdx,7FFE3FF57430
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
-       mov       rdx,7FFE3FEDF3B0
+       mov       rdx,7FFE3FF57448
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
-       mov       rdx,7FFE3FEDF4C0
+       mov       rdx,7FFE3FF57558
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
-       mov       rdx,7FFE3FEDF388
+       mov       rdx,7FFE3FF57420
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEF6D00]
+       call      qword ptr [7FFE3FF74390]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEDF388
+       mov       rdx,7FFE3FF57420
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFE3FEF6D78]
+       call      qword ptr [7FFE3FF74408]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEDF388
+       mov       rdx,7FFE3FF57420
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEF6E08]
+       call      qword ptr [7FFE3FF74498]
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
-       mov       rdx,7FFE3FEDF4D8
+       mov       rdx,7FFE3FF57570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFE3F72D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFE3F71D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFE3FD36AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFE3FE77C90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFE3FDFD198]
+       vmulss    xmm0,xmm0,dword ptr [7FFE3FDF1AB8]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFE3FD36A78]
+       jmp       qword ptr [7FFE3FE77C48]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE3F284348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F254348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE3FCD4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3FD66B98]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,22C86C01FE8
+       mov       rcx,15A12C12BD0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFE3FD36580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE3FF06DC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFE3F5F7A38]
+       call      qword ptr [7FFE3F5C7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFE3F140FE0
+       mov       r11,7FFE3F111B10
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
+       jmp       qword ptr [7FFE3F254378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FFE3F284378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFE3FEDF378
+       mov       rdx,7FFE3FF3C688
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFE3F284348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F254348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFE3FEDF398
+       mov       rdx,7FFE3FF3C6A8
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
-       mov       rdx,7FFE3FEDF3B0
+       mov       rdx,7FFE3FF3C6C0
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
-       mov       rdx,7FFE3FEDF4C0
+       mov       rdx,7FFE3FF3C7D0
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
-       mov       rdx,7FFE3FEDF388
+       mov       rdx,7FFE3FF3C698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEF6D00]
+       call      qword ptr [7FFE3FF0FE40]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEDF388
+       mov       rdx,7FFE3FF3C698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFE3FEF6D78]
+       call      qword ptr [7FFE3FF0FEB8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEDF388
+       mov       rdx,7FFE3FF3C698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FEF6E08]
+       call      qword ptr [7FFE3FF0FF48]
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
-       mov       rdx,7FFE3FEDF4D8
+       mov       rdx,7FFE3FF3C7E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFE3F72D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFE3F6FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFE3FD36AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFE3FF07300]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFE3FDFD198]
+       vmulss    xmm0,xmm0,dword ptr [7FFE3FDEBF78]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFE3FD36A78]
+       jmp       qword ptr [7FFE3FF072B8]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE3F264348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE3FCA4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3FD04498]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,2409E001FE8
+       mov       rcx,1E42D001FF8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFE3FD179A8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE3FE77750]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFE3F5D7A38]
+       call      qword ptr [7FFE3F5E7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFE3F121010
+       mov       r11,7FFE3F1312D8
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
+       jmp       qword ptr [7FFE3F274378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FFE3F264378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFE3FEE2008
+       mov       rdx,7FFE3FF57410
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFE3F264348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFE3FEE2028
+       mov       rdx,7FFE3FF57430
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
-       mov       rdx,7FFE3FEE2040
+       mov       rdx,7FFE3FF57448
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
-       mov       rdx,7FFE3FEE2150
+       mov       rdx,7FFE3FF57558
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
-       mov       rdx,7FFE3FEE2018
+       mov       rdx,7FFE3FF57420
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FED72A0]
+       call      qword ptr [7FFE3FF74390]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEE2018
+       mov       rdx,7FFE3FF57420
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFE3FED7318]
+       call      qword ptr [7FFE3FF74408]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEE2018
+       mov       rdx,7FFE3FF57420
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FED73A8]
+       call      qword ptr [7FFE3FF74498]
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
-       mov       rdx,7FFE3FEE2168
+       mov       rdx,7FFE3FF57570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFE3F70D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFE3F71D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFE3FD17EE8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFE3FE77C90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFE3FDD6738]
+       vmulss    xmm0,xmm0,dword ptr [7FFE3FDF1AB8]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFE3FD17EA0]
+       jmp       qword ptr [7FFE3FE77C48]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE3F264348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F254348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE3FCA4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3FD66B98]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,2409E001FE8
+       mov       rcx,15A12C12BD0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFE3FD179A8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE3FF06DC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFE3F5D7A38]
+       call      qword ptr [7FFE3F5C7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFE3F121010
+       mov       r11,7FFE3F111B10
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
+       jmp       qword ptr [7FFE3F254378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FFE3F264378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFE3FEE2008
+       mov       rdx,7FFE3FF3C688
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFE3F264348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F254348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFE3FEE2028
+       mov       rdx,7FFE3FF3C6A8
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
-       mov       rdx,7FFE3FEE2040
+       mov       rdx,7FFE3FF3C6C0
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
-       mov       rdx,7FFE3FEE2150
+       mov       rdx,7FFE3FF3C7D0
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
-       mov       rdx,7FFE3FEE2018
+       mov       rdx,7FFE3FF3C698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FED72A0]
+       call      qword ptr [7FFE3FF0FE40]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEE2018
+       mov       rdx,7FFE3FF3C698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFE3FED7318]
+       call      qword ptr [7FFE3FF0FEB8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFE3FEE2018
+       mov       rdx,7FFE3FF3C698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FED73A8]
+       call      qword ptr [7FFE3FF0FF48]
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
-       mov       rdx,7FFE3FEE2168
+       mov       rdx,7FFE3FF3C7E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFE3F70D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFE3F6FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFE3FD17EE8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFE3FF07300]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFE3FDD6738]
+       vmulss    xmm0,xmm0,dword ptr [7FFE3FDEBF78]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFE3FD17EA0]
+       jmp       qword ptr [7FFE3FF072B8]
 ; Total bytes of code 71
```
**Diff for ToImmutableSortedSet method between:**
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
.NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F254348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE3FD04498]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3FD66B98]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1E42D001FF8
+       mov       rcx,15A12C12BD0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFE3FE77750]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFE3FF06DC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFE3F5E7A38]
+       call      qword ptr [7FFE3F5C7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFE3F1312D8
+       mov       r11,7FFE3F111B10
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
+       jmp       qword ptr [7FFE3F254378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
 M01_L03:
-       pop       rbx
-       jmp       qword ptr [7FFE3F274378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFE3FF57410
+       mov       rdx,7FFE3FF3C688
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFE3F274348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFE3F254348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFE3FF57430
+       mov       rdx,7FFE3FF3C6A8
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
-       mov       rdx,7FFE3FF57448
+       mov       rdx,7FFE3FF3C6C0
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
-       mov       rdx,7FFE3FF57558
+       mov       rdx,7FFE3FF3C7D0
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
-       mov       rdx,7FFE3FF57420
+       mov       rdx,7FFE3FF3C698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FF74390]
+       call      qword ptr [7FFE3FF0FE40]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFE3FF57420
+       mov       rdx,7FFE3FF3C698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFE3FF74408]
+       call      qword ptr [7FFE3FF0FEB8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFE3FF57420
+       mov       rdx,7FFE3FF3C698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFE3FF74498]
+       call      qword ptr [7FFE3FF0FF48]
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
-       mov       rdx,7FFE3FF57570
+       mov       rdx,7FFE3FF3C7E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFE3F71D578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFE3F6FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFE3FE77C90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFE3FF07300]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFE3FDF1AB8]
+       vmulss    xmm0,xmm0,dword ptr [7FFE3FDEBF78]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFE3FE77C48]
+       jmp       qword ptr [7FFE3FF072B8]
 ; Total bytes of code 71
```
