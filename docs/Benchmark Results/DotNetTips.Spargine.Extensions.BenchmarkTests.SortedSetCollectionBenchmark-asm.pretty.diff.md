## DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark-20250421-050551
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
-       mov       r8,197AB002250
+       mov       r8,18B68C02250
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
-       call      qword ptr [7FFBE6BA6220]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFBE6B875D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,197AB002248
+       mov       rdx,18B68C02248
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFBE6154210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,197AB002250
+       call      qword ptr [7FFBE6144210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,18B68C02250
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
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,38
+       sub       rsp,40
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
-       mov       [rbp-30],rcx
+       mov       [rbp-28],rcx
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
-       mov       [rbp-38],rax
+       mov       [rbp-30],rax
        test      rax,rax
        je        near ptr M01_L11
        mov       rdi,[rax]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,r14
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rdi,rdx
        jne       near ptr M01_L11
        jmp       short M01_L05
 M01_L01:
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L03
 M01_L02:
-       mov       rcx,[rbp-38]
+       mov       rcx,[rbp-30]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        cmp       [rbx+18],rdx
        jne       short M01_L04
-       mov       r15,[rax+30]
-       test      r15,r15
-       mov       rax,[rbp-38]
+       mov       r14,[rax+30]
+       test      r14,r14
+       mov       rax,[rbp-30]
        je        short M01_L05
-       mov       edx,[r15+8]
+       mov       edx,[r14+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFBE6D89EA8
+       mov       rdx,7FFBE6D799E8
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
+       mov       rax,[rbp-30]
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFBE6BDFE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6BF5CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rsi+10]
        mov       r11,[rcx+28]
        test      r11,r11
        je        short M01_L08
 M01_L07:
-       mov       rcx,[rbp-38]
+       mov       rcx,[rbp-30]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        cmp       [rbx+18],rdx
        jne       short M01_L10
-       mov       r15,[rax+30]
-       test      r15,r15
-       mov       rax,[rbp-38]
+       mov       r14,[rax+30]
+       test      r14,r14
+       mov       rax,[rbp-30]
        je        short M01_L11
-       mov       edx,[r15+8]
+       mov       edx,[r14+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFBE6D89EA8
+       mov       rdx,7FFBE6D799E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFBE60110D0
+       mov       r11,7FFBE60010D0
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
+       mov       rax,[rbp-30]
        mov       rdi,[rax]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,r14
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rdi,rdx
        jne       short M01_L09
        mov       rdx,rdi
        lea       rcx,[rax+8]
-       call      qword ptr [7FFBE6BDFE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6BF5CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFBE6D89DD0
+       mov       rdx,7FFBE6D79910
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
 M01_L14:
-       cmp       rdi,r14
+       mov       rax,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rdi,rax
        jne       short M01_L19
 M01_L15:
        mov       eax,1
-       add       rsp,38
+       add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        pop       rbp
        ret
 M01_L16:
        mov       ecx,10
-       call      qword ptr [7FFBE64C7A38]
+       call      qword ptr [7FFBE64B7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFBE64C7A38]
+       call      qword ptr [7FFBE64B7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFBE60110D8
+       mov       rcx,[rbp-30]
+       mov       r11,7FFBE60010D8
        call      qword ptr [r11]
        jmp       short M01_L15
 M01_L20:
        xor       eax,eax
-       add       rsp,38
+       add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        pop       rbp
        ret
 M01_L21:
        push      rbp
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,28
+       sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
-       cmp       qword ptr [rbp-38],0
+       cmp       qword ptr [rbp-30],0
        je        short M01_L22
-       mov       rcx,[rbp-38]
+       mov       rcx,[rbp-30]
        mov       rdi,[rcx]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rdi,r14
+       mov       r11,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rdi,r11
        je        short M01_L22
-       mov       rcx,[rbp-38]
-       mov       r11,7FFBE60110D8
+       mov       r11,7FFBE60010D8
        call      qword ptr [r11]
 M01_L22:
        nop
-       add       rsp,28
+       add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
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
-       call      qword ptr [7FFBE61541F8]
+       call      qword ptr [7FFBE61441F8]
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
-       mov       r8,197AB002250
+       mov       r8,177B980F7F8
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
-       call      qword ptr [7FFBE6BA6220]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFBE6B875D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,197AB002248
+       mov       rdx,177B980F7F0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFBE6154210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,197AB002250
+       call      qword ptr [7FFBE6134210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,177B980F7F8
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
-       mov       rdx,7FFBE6D89EA8
+       mov       rdx,7FFBE6D79950
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
-       call      qword ptr [7FFBE6BDFE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6BE58C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFBE6D89EA8
+       mov       rdx,7FFBE6D79950
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFBE60110D0
+       mov       r11,7FFBE5FF10D0
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
-       call      qword ptr [7FFBE6BDFE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6BE58C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFBE6D89DD0
+       mov       rdx,7FFBE6D79878
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
-       call      qword ptr [7FFBE64C7A38]
+       call      qword ptr [7FFBE64A7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFBE64C7A38]
+       call      qword ptr [7FFBE64A7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFBE60110D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFBE5FF10D8
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
-       mov       r11,7FFBE60110D8
+       mov       r11,7FFBE5FF10D8
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
-       call      qword ptr [7FFBE61541F8]
+       call      qword ptr [7FFBE61341F8]
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
-       mov       r8,197AB002250
+       mov       r8,1EEC3C0F7F8
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
-       call      qword ptr [7FFBE6BA6220]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFBE6BA75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,197AB002248
+       mov       rdx,1EEC3C0F7F0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        call      qword ptr [7FFBE6154210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,197AB002250
+       mov       rcx,1EEC3C0F7F8
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
-       mov       rdx,7FFBE6D89EA8
+       mov       rdx,7FFBE6D99B18
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
-       call      qword ptr [7FFBE6BDFE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6C05590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFBE6D89EA8
+       mov       rdx,7FFBE6D99B18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
        mov       rcx,rax
        mov       r11,7FFBE60110D0
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
-       call      qword ptr [7FFBE6BDFE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6C05590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFBE6D89DD0
+       mov       rdx,7FFBE6D99A40
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
+       mov       rcx,[rbp-38]
        mov       r11,7FFBE60110D8
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
        mov       r11,7FFBE60110D8
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
-       mov       r8,197AB002250
+       mov       r8,1DE1200D800
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
-       call      qword ptr [7FFBE6BA6220]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFBE6BB75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,197AB002248
+       mov       rdx,1DE1200D7F8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFBE6154210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,197AB002250
+       call      qword ptr [7FFBE6164210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1DE1200D800
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
-       mov       rdx,7FFBE6D89EA8
+       mov       rdx,7FFBE6DAA0D0
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
-       call      qword ptr [7FFBE6BDFE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6C15CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFBE6D89EA8
+       mov       rdx,7FFBE6DAA0D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFBE60110D0
+       mov       r11,7FFBE60210D0
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
-       call      qword ptr [7FFBE6BDFE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6C15CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFBE6D89DD0
+       mov       rdx,7FFBE6DA9FF8
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
-       call      qword ptr [7FFBE64C7A38]
+       call      qword ptr [7FFBE64D7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFBE64C7A38]
+       call      qword ptr [7FFBE64D7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,rax
-       mov       r11,7FFBE60110D8
+       mov       r11,7FFBE60210D8
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
-       mov       r11,7FFBE60110D8
+       mov       r11,7FFBE60210D8
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
-       call      qword ptr [7FFBE61541F8]
+       call      qword ptr [7FFBE61641F8]
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
-       mov       r8,197AB002250
+       mov       r8,2814240F7F8
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
-       call      qword ptr [7FFBE6BA6220]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFBE6B875D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,197AB002248
+       mov       rdx,2814240F7F0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFBE6154210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,197AB002250
+       call      qword ptr [7FFBE6134210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,2814240F7F8
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
-       mov       rdx,7FFBE6D89EA8
+       mov       rdx,7FFBE6D79C50
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
-       call      qword ptr [7FFBE6BDFE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6BE5CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFBE6D89EA8
+       mov       rdx,7FFBE6D79C50
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFBE60110D0
+       mov       r11,7FFBE5FF10D0
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
-       call      qword ptr [7FFBE6BDFE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6BE5CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFBE6D89DD0
+       mov       rdx,7FFBE6D79B78
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
-       call      qword ptr [7FFBE64C7A38]
+       call      qword ptr [7FFBE64A7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFBE64C7A38]
+       call      qword ptr [7FFBE64A7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFBE60110D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFBE5FF10D8
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
-       mov       r11,7FFBE60110D8
+       mov       r11,7FFBE5FF10D8
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
-       call      qword ptr [7FFBE61541F8]
+       call      qword ptr [7FFBE61341F8]
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
-       mov       r8,197AB002250
+       mov       r8,2735C40F7F8
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
-       call      qword ptr [7FFBE6BA6220]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFBE6C5D5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,197AB002248
+       mov       rdx,2735C40F7F0
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFBE6154210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,197AB002250
+       mov       r8,7FFBE6D42AF0
+       call      qword ptr [7FFBE6144210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,2735C40F7F8
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
+       mov       rdx,7FFBE6D42AF0
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
-       mov       rdx,7FFBE6D89EA8
+       mov       rdx,7FFBE6E07120
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
-       call      qword ptr [7FFBE6BDFE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6D46E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FFBE6D42AF0
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
-       mov       rdx,7FFBE6D89EA8
+       mov       rdx,7FFBE6E07120
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFBE60110D0
+       mov       r11,7FFBE60012A0
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
-       call      qword ptr [7FFBE6BDFE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6D46E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFBE6D89DD0
+       mov       rdx,7FFBE6E07048
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
-       call      qword ptr [7FFBE64C7A38]
+       call      qword ptr [7FFBE64B7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFBE64C7A38]
+       call      qword ptr [7FFBE64B7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFBE60110D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFBE60012A8
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
-       mov       r11,7FFBE60110D8
+       mov       r11,7FFBE60012A8
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
-       call      qword ptr [7FFBE61541F8]
+M02_L00:
+       call      qword ptr [7FFBE61441F8]
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
-       mov       r8,197AB002250
+       mov       r8,237F0002250
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
-       call      qword ptr [7FFBE6BA6220]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFBE6D7EF40]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,197AB002248
+       mov       rdx,237F0002248
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFBE6154210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,197AB002250
+       call      qword ptr [7FFBE6124210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,237F0002250
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
-       mov       rdx,7FFBE6D89EA8
+       mov       rdx,7FFBE6DFE758
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
-       call      qword ptr [7FFBE6BDFE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6DE64F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFBE6D89EA8
+       mov       rdx,7FFBE6DFE758
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFBE60110D0
+       mov       r11,7FFBE5FE1B68
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
-       call      qword ptr [7FFBE6BDFE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6DE64F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFBE6D89DD0
+       mov       rdx,7FFBE6DFE680
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
-       call      qword ptr [7FFBE64C7A38]
+       call      qword ptr [7FFBE6497A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFBE64C7A38]
+       call      qword ptr [7FFBE6497A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFBE60110D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFBE5FE1B70
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
-       mov       r11,7FFBE60110D8
+       mov       r11,7FFBE5FE1B70
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
-       call      qword ptr [7FFBE61541F8]
+       call      qword ptr [7FFBE61241F8]
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
-       mov       r8,18B68C02250
+       mov       r8,177B980F7F8
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
-       mov       rdx,18B68C02248
+       mov       rdx,177B980F7F0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFBE6144210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,18B68C02250
+       call      qword ptr [7FFBE6134210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,177B980F7F8
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
-       mov       rdx,7FFBE6D799E8
+       mov       rdx,7FFBE6D79950
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
-       call      qword ptr [7FFBE6BF5CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6BE58C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFBE6D799E8
+       mov       rdx,7FFBE6D79950
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFBE60010D0
+       mov       r11,7FFBE5FF10D0
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
-       call      qword ptr [7FFBE6BF5CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6BE58C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFBE6D79910
+       mov       rdx,7FFBE6D79878
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
-       call      qword ptr [7FFBE64B7A38]
+       call      qword ptr [7FFBE64A7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFBE64B7A38]
+       call      qword ptr [7FFBE64A7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFBE60010D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFBE5FF10D8
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
-       mov       r11,7FFBE60010D8
+       mov       r11,7FFBE5FF10D8
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
-       call      qword ptr [7FFBE61441F8]
+       call      qword ptr [7FFBE61341F8]
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
-       mov       r8,18B68C02250
+       mov       r8,1EEC3C0F7F8
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
-       call      qword ptr [7FFBE6B875D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFBE6BA75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,18B68C02248
+       mov       rdx,1EEC3C0F7F0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFBE6144210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,18B68C02250
+       call      qword ptr [7FFBE6154210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1EEC3C0F7F8
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
-       mov       rdx,7FFBE6D799E8
+       mov       rdx,7FFBE6D99B18
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
-       call      qword ptr [7FFBE6BF5CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6C05590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFBE6D799E8
+       mov       rdx,7FFBE6D99B18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFBE60010D0
+       mov       r11,7FFBE60110D0
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
-       call      qword ptr [7FFBE6BF5CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6C05590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFBE6D79910
+       mov       rdx,7FFBE6D99A40
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
-       call      qword ptr [7FFBE64B7A38]
+       call      qword ptr [7FFBE64C7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFBE64B7A38]
+       call      qword ptr [7FFBE64C7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFBE60010D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFBE60110D8
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
-       mov       r11,7FFBE60010D8
+       mov       r11,7FFBE60110D8
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
-       call      qword ptr [7FFBE61441F8]
+       call      qword ptr [7FFBE61541F8]
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
-       mov       r8,18B68C02250
+       mov       r8,1DE1200D800
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
-       call      qword ptr [7FFBE6B875D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFBE6BB75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,18B68C02248
+       mov       rdx,1DE1200D7F8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFBE6144210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,18B68C02250
+       call      qword ptr [7FFBE6164210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1DE1200D800
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
-       mov       rdx,7FFBE6D799E8
+       mov       rdx,7FFBE6DAA0D0
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
-       call      qword ptr [7FFBE6BF5CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6C15CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFBE6D799E8
+       mov       rdx,7FFBE6DAA0D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFBE60010D0
+       mov       r11,7FFBE60210D0
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
-       call      qword ptr [7FFBE6BF5CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6C15CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFBE6D79910
+       mov       rdx,7FFBE6DA9FF8
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
-       call      qword ptr [7FFBE64B7A38]
+       call      qword ptr [7FFBE64D7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFBE64B7A38]
+       call      qword ptr [7FFBE64D7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFBE60010D8
+       mov       rcx,rax
+       mov       r11,7FFBE60210D8
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
-       mov       r11,7FFBE60010D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFBE60210D8
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
-       call      qword ptr [7FFBE61441F8]
+       call      qword ptr [7FFBE61641F8]
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
-       mov       r8,18B68C02250
+       mov       r8,2814240F7F8
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
-       mov       rdx,18B68C02248
+       mov       rdx,2814240F7F0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFBE6144210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,18B68C02250
+       call      qword ptr [7FFBE6134210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,2814240F7F8
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
-       mov       rdx,7FFBE6D799E8
+       mov       rdx,7FFBE6D79C50
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
-       call      qword ptr [7FFBE6BF5CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6BE5CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFBE6D799E8
+       mov       rdx,7FFBE6D79C50
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFBE60010D0
+       mov       r11,7FFBE5FF10D0
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
-       call      qword ptr [7FFBE6BF5CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6BE5CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFBE6D79910
+       mov       rdx,7FFBE6D79B78
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
-       call      qword ptr [7FFBE64B7A38]
+       call      qword ptr [7FFBE64A7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFBE64B7A38]
+       call      qword ptr [7FFBE64A7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFBE60010D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFBE5FF10D8
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
-       mov       r11,7FFBE60010D8
+       mov       r11,7FFBE5FF10D8
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
-       call      qword ptr [7FFBE61441F8]
+       call      qword ptr [7FFBE61341F8]
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
-       mov       r8,18B68C02250
+       mov       r8,2735C40F7F8
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
-       call      qword ptr [7FFBE6B875D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFBE6C5D5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,18B68C02248
+       mov       rdx,2735C40F7F0
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       r8,7FFBE6D42AF0
        call      qword ptr [7FFBE6144210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,18B68C02250
+       mov       rcx,2735C40F7F8
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
+       mov       rdx,7FFBE6D42AF0
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
-       mov       rdx,7FFBE6D799E8
+       mov       rdx,7FFBE6E07120
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
-       call      qword ptr [7FFBE6BF5CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6D46E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FFBE6D42AF0
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
-       mov       rdx,7FFBE6D799E8
+       mov       rdx,7FFBE6E07120
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFBE60010D0
+       mov       r11,7FFBE60012A0
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
-       call      qword ptr [7FFBE6BF5CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6D46E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFBE6D79910
+       mov       rdx,7FFBE6E07048
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
-       mov       r11,7FFBE60010D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFBE60012A8
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
-       mov       r11,7FFBE60010D8
+       mov       r11,7FFBE60012A8
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
+M02_L00:
        call      qword ptr [7FFBE61441F8]
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
-       mov       r8,18B68C02250
+       mov       r8,237F0002250
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
-       call      qword ptr [7FFBE6B875D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFBE6D7EF40]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,18B68C02248
+       mov       rdx,237F0002248
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFBE6144210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,18B68C02250
+       call      qword ptr [7FFBE6124210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,237F0002250
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
-       mov       rdx,7FFBE6D799E8
+       mov       rdx,7FFBE6DFE758
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
-       call      qword ptr [7FFBE6BF5CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6DE64F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFBE6D799E8
+       mov       rdx,7FFBE6DFE758
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFBE60010D0
+       mov       r11,7FFBE5FE1B68
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
-       call      qword ptr [7FFBE6BF5CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6DE64F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFBE6D79910
+       mov       rdx,7FFBE6DFE680
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
-       call      qword ptr [7FFBE64B7A38]
+       call      qword ptr [7FFBE6497A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFBE64B7A38]
+       call      qword ptr [7FFBE6497A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFBE60010D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFBE5FE1B70
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
-       mov       r11,7FFBE60010D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFBE5FE1B70
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
-       call      qword ptr [7FFBE61441F8]
+       call      qword ptr [7FFBE61241F8]
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
-       mov       r8,177B980F7F8
+       mov       r8,1EEC3C0F7F8
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
-       call      qword ptr [7FFBE6B875D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFBE6BA75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,177B980F7F0
+       mov       rdx,1EEC3C0F7F0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFBE6134210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,177B980F7F8
+       call      qword ptr [7FFBE6154210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1EEC3C0F7F8
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
-       mov       rdx,7FFBE6D79950
+       mov       rdx,7FFBE6D99B18
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
-       call      qword ptr [7FFBE6BE58C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6C05590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFBE6D79950
+       mov       rdx,7FFBE6D99B18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFBE5FF10D0
+       mov       r11,7FFBE60110D0
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
-       call      qword ptr [7FFBE6BE58C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6C05590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFBE6D79878
+       mov       rdx,7FFBE6D99A40
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
-       call      qword ptr [7FFBE64A7A38]
+       call      qword ptr [7FFBE64C7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFBE64A7A38]
+       call      qword ptr [7FFBE64C7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFBE5FF10D8
+       mov       r11,7FFBE60110D8
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
-       mov       r11,7FFBE5FF10D8
+       mov       r11,7FFBE60110D8
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
-       call      qword ptr [7FFBE61341F8]
+       call      qword ptr [7FFBE61541F8]
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
-       mov       r8,177B980F7F8
+       mov       r8,1DE1200D800
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
-       call      qword ptr [7FFBE6B875D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFBE6BB75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,177B980F7F0
+       mov       rdx,1DE1200D7F8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFBE6134210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,177B980F7F8
+       call      qword ptr [7FFBE6164210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1DE1200D800
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
-       mov       rdx,7FFBE6D79950
+       mov       rdx,7FFBE6DAA0D0
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
-       call      qword ptr [7FFBE6BE58C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6C15CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFBE6D79950
+       mov       rdx,7FFBE6DAA0D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFBE5FF10D0
+       mov       r11,7FFBE60210D0
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
-       call      qword ptr [7FFBE6BE58C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6C15CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFBE6D79878
+       mov       rdx,7FFBE6DA9FF8
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
-       call      qword ptr [7FFBE64A7A38]
+       call      qword ptr [7FFBE64D7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFBE64A7A38]
+       call      qword ptr [7FFBE64D7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,[rbp-38]
-       mov       r11,7FFBE5FF10D8
+       mov       rcx,rax
+       mov       r11,7FFBE60210D8
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
-       mov       r11,7FFBE5FF10D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFBE60210D8
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
-       call      qword ptr [7FFBE61341F8]
+       call      qword ptr [7FFBE61641F8]
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
-       mov       r8,177B980F7F8
+       mov       r8,2814240F7F8
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
-       mov       rdx,177B980F7F0
+       mov       rdx,2814240F7F0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        call      qword ptr [7FFBE6134210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,177B980F7F8
+       mov       rcx,2814240F7F8
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
-       mov       rdx,7FFBE6D79950
+       mov       rdx,7FFBE6D79C50
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
-       call      qword ptr [7FFBE6BE58C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6BE5CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFBE6D79950
+       mov       rdx,7FFBE6D79C50
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
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
-       call      qword ptr [7FFBE6BE58C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6BE5CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFBE6D79878
+       mov       rdx,7FFBE6D79B78
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
-       mov       r8,177B980F7F8
+       mov       r8,2735C40F7F8
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
-       call      qword ptr [7FFBE6B875D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFBE6C5D5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,177B980F7F0
+       mov       rdx,2735C40F7F0
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFBE6134210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,177B980F7F8
+       mov       r8,7FFBE6D42AF0
+       call      qword ptr [7FFBE6144210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,2735C40F7F8
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
+       mov       rdx,7FFBE6D42AF0
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
-       mov       rdx,7FFBE6D79950
+       mov       rdx,7FFBE6E07120
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
-       call      qword ptr [7FFBE6BE58C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6D46E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FFBE6D42AF0
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
-       mov       rdx,7FFBE6D79950
+       mov       rdx,7FFBE6E07120
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFBE5FF10D0
+       mov       r11,7FFBE60012A0
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
-       call      qword ptr [7FFBE6BE58C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6D46E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFBE6D79878
+       mov       rdx,7FFBE6E07048
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
-       call      qword ptr [7FFBE64A7A38]
+       call      qword ptr [7FFBE64B7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFBE64A7A38]
+       call      qword ptr [7FFBE64B7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFBE5FF10D8
+       mov       r11,7FFBE60012A8
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
-       mov       r11,7FFBE5FF10D8
+       mov       r11,7FFBE60012A8
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
-       call      qword ptr [7FFBE61341F8]
+M02_L00:
+       call      qword ptr [7FFBE61441F8]
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
-       mov       r8,177B980F7F8
+       mov       r8,237F0002250
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
-       call      qword ptr [7FFBE6B875D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFBE6D7EF40]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,177B980F7F0
+       mov       rdx,237F0002248
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFBE6134210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,177B980F7F8
+       call      qword ptr [7FFBE6124210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,237F0002250
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
-       mov       rdx,7FFBE6D79950
+       mov       rdx,7FFBE6DFE758
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
-       call      qword ptr [7FFBE6BE58C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6DE64F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFBE6D79950
+       mov       rdx,7FFBE6DFE758
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFBE5FF10D0
+       mov       r11,7FFBE5FE1B68
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
-       call      qword ptr [7FFBE6BE58C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6DE64F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFBE6D79878
+       mov       rdx,7FFBE6DFE680
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
-       call      qword ptr [7FFBE64A7A38]
+       call      qword ptr [7FFBE6497A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFBE64A7A38]
+       call      qword ptr [7FFBE6497A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFBE5FF10D8
+       mov       r11,7FFBE5FE1B70
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
-       mov       r11,7FFBE5FF10D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFBE5FE1B70
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
-       call      qword ptr [7FFBE61341F8]
+       call      qword ptr [7FFBE61241F8]
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
-       mov       r8,1EEC3C0F7F8
+       mov       r8,1DE1200D800
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
-       call      qword ptr [7FFBE6BA75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFBE6BB75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1EEC3C0F7F0
+       mov       rdx,1DE1200D7F8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFBE6154210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1EEC3C0F7F8
+       call      qword ptr [7FFBE6164210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1DE1200D800
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
-       mov       rdx,7FFBE6D99B18
+       mov       rdx,7FFBE6DAA0D0
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
-       call      qword ptr [7FFBE6C05590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6C15CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFBE6D99B18
+       mov       rdx,7FFBE6DAA0D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFBE60110D0
+       mov       r11,7FFBE60210D0
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
-       call      qword ptr [7FFBE6C05590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6C15CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFBE6D99A40
+       mov       rdx,7FFBE6DA9FF8
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
-       call      qword ptr [7FFBE64C7A38]
+       call      qword ptr [7FFBE64D7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFBE64C7A38]
+       call      qword ptr [7FFBE64D7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,[rbp-38]
-       mov       r11,7FFBE60110D8
+       mov       rcx,rax
+       mov       r11,7FFBE60210D8
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
-       mov       r11,7FFBE60110D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFBE60210D8
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
-       call      qword ptr [7FFBE61541F8]
+       call      qword ptr [7FFBE61641F8]
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
-       mov       r8,1EEC3C0F7F8
+       mov       r8,2814240F7F8
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
-       call      qword ptr [7FFBE6BA75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFBE6B875D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1EEC3C0F7F0
+       mov       rdx,2814240F7F0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFBE6154210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1EEC3C0F7F8
+       call      qword ptr [7FFBE6134210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,2814240F7F8
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
-       mov       rdx,7FFBE6D99B18
+       mov       rdx,7FFBE6D79C50
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
-       call      qword ptr [7FFBE6C05590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6BE5CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFBE6D99B18
+       mov       rdx,7FFBE6D79C50
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFBE60110D0
+       mov       r11,7FFBE5FF10D0
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
-       call      qword ptr [7FFBE6C05590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6BE5CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFBE6D99A40
+       mov       rdx,7FFBE6D79B78
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
-       call      qword ptr [7FFBE64C7A38]
+       call      qword ptr [7FFBE64A7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFBE64C7A38]
+       call      qword ptr [7FFBE64A7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFBE60110D8
+       mov       r11,7FFBE5FF10D8
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
-       mov       r11,7FFBE60110D8
+       mov       r11,7FFBE5FF10D8
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
-       call      qword ptr [7FFBE61541F8]
+       call      qword ptr [7FFBE61341F8]
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
-       mov       r8,1EEC3C0F7F8
+       mov       r8,2735C40F7F8
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
-       call      qword ptr [7FFBE6BA75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFBE6C5D5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1EEC3C0F7F0
+       mov       rdx,2735C40F7F0
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFBE6154210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1EEC3C0F7F8
+       mov       r8,7FFBE6D42AF0
+       call      qword ptr [7FFBE6144210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,2735C40F7F8
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
+       mov       rdx,7FFBE6D42AF0
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
-       mov       rdx,7FFBE6D99B18
+       mov       rdx,7FFBE6E07120
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
-       call      qword ptr [7FFBE6C05590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6D46E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FFBE6D42AF0
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
-       mov       rdx,7FFBE6D99B18
+       mov       rdx,7FFBE6E07120
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFBE60110D0
+       mov       r11,7FFBE60012A0
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
-       call      qword ptr [7FFBE6C05590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6D46E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFBE6D99A40
+       mov       rdx,7FFBE6E07048
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
-       call      qword ptr [7FFBE64C7A38]
+       call      qword ptr [7FFBE64B7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFBE64C7A38]
+       call      qword ptr [7FFBE64B7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFBE60110D8
+       mov       r11,7FFBE60012A8
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
-       mov       r11,7FFBE60110D8
+       mov       r11,7FFBE60012A8
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
-       call      qword ptr [7FFBE61541F8]
+M02_L00:
+       call      qword ptr [7FFBE61441F8]
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
-       mov       r8,1EEC3C0F7F8
+       mov       r8,237F0002250
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
-       call      qword ptr [7FFBE6BA75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFBE6D7EF40]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1EEC3C0F7F0
+       mov       rdx,237F0002248
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFBE6154210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1EEC3C0F7F8
+       call      qword ptr [7FFBE6124210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,237F0002250
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
-       mov       rdx,7FFBE6D99B18
+       mov       rdx,7FFBE6DFE758
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
-       call      qword ptr [7FFBE6C05590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6DE64F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFBE6D99B18
+       mov       rdx,7FFBE6DFE758
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFBE60110D0
+       mov       r11,7FFBE5FE1B68
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
-       call      qword ptr [7FFBE6C05590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6DE64F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFBE6D99A40
+       mov       rdx,7FFBE6DFE680
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
-       call      qword ptr [7FFBE64C7A38]
+       call      qword ptr [7FFBE6497A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFBE64C7A38]
+       call      qword ptr [7FFBE6497A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFBE60110D8
+       mov       r11,7FFBE5FE1B70
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
-       mov       r11,7FFBE60110D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFBE5FE1B70
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
-       call      qword ptr [7FFBE61541F8]
+       call      qword ptr [7FFBE61241F8]
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
-       mov       r8,1DE1200D800
+       mov       r8,2814240F7F8
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
-       call      qword ptr [7FFBE6BB75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFBE6B875D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1DE1200D7F8
+       mov       rdx,2814240F7F0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFBE6164210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1DE1200D800
+       call      qword ptr [7FFBE6134210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,2814240F7F8
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
-       mov       rdx,7FFBE6DAA0D0
+       mov       rdx,7FFBE6D79C50
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
-       call      qword ptr [7FFBE6C15CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6BE5CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFBE6DAA0D0
+       mov       rdx,7FFBE6D79C50
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFBE60210D0
+       mov       r11,7FFBE5FF10D0
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
-       call      qword ptr [7FFBE6C15CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6BE5CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFBE6DA9FF8
+       mov       rdx,7FFBE6D79B78
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
-       call      qword ptr [7FFBE64D7A38]
+       call      qword ptr [7FFBE64A7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFBE64D7A38]
+       call      qword ptr [7FFBE64A7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFBE60210D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFBE5FF10D8
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
-       mov       r11,7FFBE60210D8
+       mov       r11,7FFBE5FF10D8
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
-       call      qword ptr [7FFBE61641F8]
+       call      qword ptr [7FFBE61341F8]
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
-       mov       r8,1DE1200D800
+       mov       r8,2735C40F7F8
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
-       call      qword ptr [7FFBE6BB75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFBE6C5D5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1DE1200D7F8
+       mov       rdx,2735C40F7F0
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFBE6164210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1DE1200D800
+       mov       r8,7FFBE6D42AF0
+       call      qword ptr [7FFBE6144210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,2735C40F7F8
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
+       mov       rdx,7FFBE6D42AF0
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
-       mov       rdx,7FFBE6DAA0D0
+       mov       rdx,7FFBE6E07120
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
-       call      qword ptr [7FFBE6C15CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6D46E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FFBE6D42AF0
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
-       mov       rdx,7FFBE6DAA0D0
+       mov       rdx,7FFBE6E07120
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFBE60210D0
+       mov       r11,7FFBE60012A0
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
-       call      qword ptr [7FFBE6C15CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6D46E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFBE6DA9FF8
+       mov       rdx,7FFBE6E07048
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
-       call      qword ptr [7FFBE64D7A38]
+       call      qword ptr [7FFBE64B7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFBE64D7A38]
+       call      qword ptr [7FFBE64B7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFBE60210D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFBE60012A8
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
-       mov       r11,7FFBE60210D8
+       mov       r11,7FFBE60012A8
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
-       call      qword ptr [7FFBE61641F8]
+M02_L00:
+       call      qword ptr [7FFBE61441F8]
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
-       mov       r8,1DE1200D800
+       mov       r8,237F0002250
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
-       call      qword ptr [7FFBE6BB75D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFBE6D7EF40]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1DE1200D7F8
+       mov       rdx,237F0002248
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFBE6164210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1DE1200D800
+       call      qword ptr [7FFBE6124210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,237F0002250
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
-       mov       rdx,7FFBE6DAA0D0
+       mov       rdx,7FFBE6DFE758
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
-       call      qword ptr [7FFBE6C15CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6DE64F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFBE6DAA0D0
+       mov       rdx,7FFBE6DFE758
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFBE60210D0
+       mov       r11,7FFBE5FE1B68
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
-       call      qword ptr [7FFBE6C15CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6DE64F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFBE6DA9FF8
+       mov       rdx,7FFBE6DFE680
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
-       call      qword ptr [7FFBE64D7A38]
+       call      qword ptr [7FFBE6497A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFBE64D7A38]
+       call      qword ptr [7FFBE6497A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFBE60210D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFBE5FE1B70
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
-       mov       r11,7FFBE60210D8
+       mov       r11,7FFBE5FE1B70
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
-       call      qword ptr [7FFBE61641F8]
+       call      qword ptr [7FFBE61241F8]
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
-       mov       r8,2814240F7F8
+       mov       r8,2735C40F7F8
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
-       call      qword ptr [7FFBE6B875D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFBE6C5D5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,2814240F7F0
+       mov       rdx,2735C40F7F0
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFBE6134210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2814240F7F8
+       mov       r8,7FFBE6D42AF0
+       call      qword ptr [7FFBE6144210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,2735C40F7F8
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
+       mov       rdx,7FFBE6D42AF0
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
-       mov       rdx,7FFBE6D79C50
+       mov       rdx,7FFBE6E07120
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
-       call      qword ptr [7FFBE6BE5CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6D46E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FFBE6D42AF0
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
-       mov       rdx,7FFBE6D79C50
+       mov       rdx,7FFBE6E07120
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFBE5FF10D0
+       mov       r11,7FFBE60012A0
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
-       call      qword ptr [7FFBE6BE5CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6D46E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFBE6D79B78
+       mov       rdx,7FFBE6E07048
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
-       call      qword ptr [7FFBE64A7A38]
+       call      qword ptr [7FFBE64B7A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFBE64A7A38]
+       call      qword ptr [7FFBE64B7A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFBE5FF10D8
+       mov       r11,7FFBE60012A8
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
-       mov       r11,7FFBE5FF10D8
+       mov       r11,7FFBE60012A8
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
-       call      qword ptr [7FFBE61341F8]
+M02_L00:
+       call      qword ptr [7FFBE61441F8]
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
-       mov       r8,2814240F7F8
+       mov       r8,237F0002250
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
-       call      qword ptr [7FFBE6B875D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFBE6D7EF40]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,2814240F7F0
+       mov       rdx,237F0002248
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFBE6134210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2814240F7F8
+       call      qword ptr [7FFBE6124210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,237F0002250
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
-       mov       rdx,7FFBE6D79C50
+       mov       rdx,7FFBE6DFE758
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
-       call      qword ptr [7FFBE6BE5CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6DE64F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFBE6D79C50
+       mov       rdx,7FFBE6DFE758
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFBE5FF10D0
+       mov       r11,7FFBE5FE1B68
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
-       call      qword ptr [7FFBE6BE5CB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6DE64F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFBE6D79B78
+       mov       rdx,7FFBE6DFE680
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
-       call      qword ptr [7FFBE64A7A38]
+       call      qword ptr [7FFBE6497A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFBE64A7A38]
+       call      qword ptr [7FFBE6497A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFBE5FF10D8
+       mov       r11,7FFBE5FE1B70
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
-       mov       r11,7FFBE5FF10D8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFBE5FE1B70
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
-       call      qword ptr [7FFBE61341F8]
+       call      qword ptr [7FFBE61241F8]
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
-       mov       r8,2735C40F7F8
+       mov       r8,237F0002250
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
-       call      qword ptr [7FFBE6C5D5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFBE6D7EF40]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,2735C40F7F0
+       mov       rdx,237F0002248
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFBE6D42AF0
-       call      qword ptr [7FFBE6144210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2735C40F7F8
+       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       call      qword ptr [7FFBE6124210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,237F0002250
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
-       mov       rdx,7FFBE6D42AF0
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
-       mov       rdx,7FFBE6E07120
+       mov       rdx,7FFBE6DFE758
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
-       call      qword ptr [7FFBE6D46E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6DE64F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFBE6D42AF0
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
-       mov       rdx,7FFBE6E07120
+       mov       rdx,7FFBE6DFE758
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFBE60012A0
+       mov       r11,7FFBE5FE1B68
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
-       call      qword ptr [7FFBE6D46E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFBE6DE64F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFBE6E07048
+       mov       rdx,7FFBE6DFE680
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
-       call      qword ptr [7FFBE64B7A38]
+       call      qword ptr [7FFBE6497A38]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFBE64B7A38]
+       call      qword ptr [7FFBE6497A38]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFBE60012A8
+       mov       r11,7FFBE5FE1B70
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
-       mov       r11,7FFBE60012A8
+       mov       rcx,[rbp-38]
+       mov       r11,7FFBE5FE1B70
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
-       call      qword ptr [7FFBE61441F8]
+M03_L00:
+       call      qword ptr [7FFBE61241F8]
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
        call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFBE6B3F648]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFBE6B84DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,15D5D801FE8
+       mov       rcx,1E77FC01FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFBE6C04C00]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFBE6BF6580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
        jmp       qword ptr [7FFBE6144378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9F198
+       mov       rdx,7FFBE6D9EDC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
        call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9F1B8
+       mov       rdx,7FFBE6D9EDE8
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
-       mov       rdx,7FFBE6D9F1D0
+       mov       rdx,7FFBE6D9EE00
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
-       mov       rdx,7FFBE6D9F2E0
+       mov       rdx,7FFBE6D9EF10
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
-       mov       rdx,7FFBE6D9F1A8
+       mov       rdx,7FFBE6D9EDD8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DB60D0]
+       call      qword ptr [7FFBE6DA7288]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9F1A8
+       mov       rdx,7FFBE6D9EDD8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFBE6DB6148]
+       call      qword ptr [7FFBE6DA7300]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9F1A8
+       mov       rdx,7FFBE6D9EDD8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DB61D8]
+       call      qword ptr [7FFBE6DA7390]
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
-       mov       rdx,7FFBE6D9F2F8
+       mov       rdx,7FFBE6D9EF28
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
        call      qword ptr [7FFBE65ED578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFBE6C05140]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFBE6BF6AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFBE6CC0118]
+       vmulss    xmm0,xmm0,dword ptr [7FFBE6CB0D98]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFBE6C050F8]
+       jmp       qword ptr [7FFBE6BF6A78]
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
-       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6134348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFBE6B3F648]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFBE6B84DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,15D5D801FE8
+       mov       rcx,10608001FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFBE6C04C00]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFBE6BE6580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFBE64B7A38]
+       call      qword ptr [7FFBE64A7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFBE6001100
+       mov       r11,7FFBE5FF0FE0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FFBE6144378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FFBE6134378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9F198
+       mov       rdx,7FFBE6D8F8F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6134348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9F1B8
+       mov       rdx,7FFBE6D8F918
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
-       mov       rdx,7FFBE6D9F1D0
+       mov       rdx,7FFBE6D8F930
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
-       mov       rdx,7FFBE6D9F2E0
+       mov       rdx,7FFBE6D8FA40
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
-       mov       rdx,7FFBE6D9F1A8
+       mov       rdx,7FFBE6D8F908
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DB60D0]
+       call      qword ptr [7FFBE6DA6D18]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9F1A8
+       mov       rdx,7FFBE6D8F908
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFBE6DB6148]
+       call      qword ptr [7FFBE6DA6D90]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9F1A8
+       mov       rdx,7FFBE6D8F908
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DB61D8]
+       call      qword ptr [7FFBE6DA6E20]
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
-       mov       rdx,7FFBE6D9F2F8
+       mov       rdx,7FFBE6D8FA58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFBE65ED578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFBE65DD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFBE6C05140]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFBE6BE6AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFBE6CC0118]
+       vmulss    xmm0,xmm0,dword ptr [7FFBE6CAD158]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFBE6C050F8]
+       jmp       qword ptr [7FFBE6BE6A78]
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
        call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFBE6B3F648]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFBE6B94DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,15D5D801FE8
+       mov       rcx,2D005401FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFBE6C04C00]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFBE6BF5E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
        call      qword ptr [7FFBE64B7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFBE6001100
+       mov       r11,7FFBE6000FE0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        jmp       qword ptr [7FFBE6144378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9F198
+       mov       rdx,7FFBE6D9F8D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
        call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9F1B8
+       mov       rdx,7FFBE6D9F8F0
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
-       mov       rdx,7FFBE6D9F1D0
+       mov       rdx,7FFBE6D9F908
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
-       mov       rdx,7FFBE6D9F2E0
+       mov       rdx,7FFBE6D9FA18
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
-       mov       rdx,7FFBE6D9F1A8
+       mov       rdx,7FFBE6D9F8E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DB60D0]
+       call      qword ptr [7FFBE6DB6D18]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9F1A8
+       mov       rdx,7FFBE6D9F8E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFBE6DB6148]
+       call      qword ptr [7FFBE6DB6D90]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9F1A8
+       mov       rdx,7FFBE6D9F8E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DB61D8]
+       call      qword ptr [7FFBE6DB6E20]
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
-       mov       rdx,7FFBE6D9F2F8
+       mov       rdx,7FFBE6D9FA30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
        call      qword ptr [7FFBE65ED578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFBE6C05140]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFBE6BF63A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFBE6CC0118]
+       vmulss    xmm0,xmm0,dword ptr [7FFBE6CBD478]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFBE6C050F8]
+       jmp       qword ptr [7FFBE6BF6358]
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
-       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFBE6B3F648]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFBE6BA4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,15D5D801FE8
+       mov       rcx,20946001FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFBE6C04C00]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFBE6C06580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFBE64B7A38]
+       call      qword ptr [7FFBE64C7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFBE6001100
+       mov       r11,7FFBE6010FE0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FFBE6144378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FFBE6154378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9F198
+       mov       rdx,7FFBE6DAF8D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9F1B8
+       mov       rdx,7FFBE6DAF8F0
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
-       mov       rdx,7FFBE6D9F1D0
+       mov       rdx,7FFBE6DAF908
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
-       mov       rdx,7FFBE6D9F2E0
+       mov       rdx,7FFBE6DAFA18
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
-       mov       rdx,7FFBE6D9F1A8
+       mov       rdx,7FFBE6DAF8E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DB60D0]
+       call      qword ptr [7FFBE6DC6D18]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9F1A8
+       mov       rdx,7FFBE6DAF8E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFBE6DB6148]
+       call      qword ptr [7FFBE6DC6D90]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9F1A8
+       mov       rdx,7FFBE6DAF8E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DB61D8]
+       call      qword ptr [7FFBE6DC6E20]
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
-       mov       rdx,7FFBE6D9F2F8
+       mov       rdx,7FFBE6DAFA30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFBE65ED578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFBE65FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFBE6C05140]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFBE6C06AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFBE6CC0118]
+       vmulss    xmm0,xmm0,dword ptr [7FFBE6CCD0B8]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFBE6C050F8]
+       jmp       qword ptr [7FFBE6C06A78]
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
-       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6134348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFBE6B3F648]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFBE6B74DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,15D5D801FE8
+       mov       rcx,20D10001FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFBE6C04C00]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFBE6BE5E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFBE64B7A38]
+       call      qword ptr [7FFBE64A7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFBE6001100
+       mov       r11,7FFBE5FF0FE0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FFBE6144378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FFBE6134378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9F198
+       mov       rdx,7FFBE6D8F400
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6134348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9F1B8
+       mov       rdx,7FFBE6D8F420
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
-       mov       rdx,7FFBE6D9F1D0
+       mov       rdx,7FFBE6D8F438
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
-       mov       rdx,7FFBE6D9F2E0
+       mov       rdx,7FFBE6D8F548
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
-       mov       rdx,7FFBE6D9F1A8
+       mov       rdx,7FFBE6D8F410
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DB60D0]
+       call      qword ptr [7FFBE6DA6D00]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9F1A8
+       mov       rdx,7FFBE6D8F410
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFBE6DB6148]
+       call      qword ptr [7FFBE6DA6D78]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9F1A8
+       mov       rdx,7FFBE6D8F410
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DB61D8]
+       call      qword ptr [7FFBE6DA6E08]
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
-       mov       rdx,7FFBE6D9F2F8
+       mov       rdx,7FFBE6D8F560
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFBE65ED578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFBE65DD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFBE6C05140]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFBE6BE63A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFBE6CC0118]
+       vmulss    xmm0,xmm0,dword ptr [7FFBE6C9D118]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFBE6C050F8]
+       jmp       qword ptr [7FFBE6BE6358]
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
-       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFBE6B3F648]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFBE6BA6B80]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,15D5D801FE8
+       mov       rcx,1DC8B002000
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFBE6C04C00]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFBE6DB5110]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFBE64B7A38]
+       call      qword ptr [7FFBE64C7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFBE6001100
+       mov       r11,7FFBE6011300
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
+       jmp       qword ptr [7FFBE6154378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FFBE6144378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9F198
+       mov       rdx,7FFBE6E2C0E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9F1B8
+       mov       rdx,7FFBE6E2C100
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
-       mov       rdx,7FFBE6D9F1D0
+       mov       rdx,7FFBE6E2C118
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
-       mov       rdx,7FFBE6D9F2E0
+       mov       rdx,7FFBE6E2C228
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
-       mov       rdx,7FFBE6D9F1A8
+       mov       rdx,7FFBE6E2C0F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DB60D0]
+       call      qword ptr [7FFBE6E44A08]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9F1A8
+       mov       rdx,7FFBE6E2C0F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFBE6DB6148]
+       call      qword ptr [7FFBE6E44A80]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9F1A8
+       mov       rdx,7FFBE6E2C0F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DB61D8]
+       call      qword ptr [7FFBE6E44B10]
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
-       mov       rdx,7FFBE6D9F2F8
+       mov       rdx,7FFBE6E2C240
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFBE65ED578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFBE65FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFBE6C05140]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFBE6DB5650]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFBE6CC0118]
+       vmulss    xmm0,xmm0,dword ptr [7FFBE6CD4578]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFBE6C050F8]
+       jmp       qword ptr [7FFBE6DB5608]
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
-       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFBE6B3F648]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFBE6C652C0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,15D5D801FE8
+       mov       rcx,1AD8EC14BE0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFBE6C04C00]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFBE6E16A90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFBE64B7A38]
+       call      qword ptr [7FFBE64C7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFBE6001100
+       mov       r11,7FFBE6011A90
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
+       jmp       qword ptr [7FFBE6154378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FFBE6144378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9F198
+       mov       rdx,7FFBE6E3E368
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9F1B8
+       mov       rdx,7FFBE6E3E388
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
-       mov       rdx,7FFBE6D9F1D0
+       mov       rdx,7FFBE6E3E3A0
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
-       mov       rdx,7FFBE6D9F2E0
+       mov       rdx,7FFBE6E3E4B0
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
-       mov       rdx,7FFBE6D9F1A8
+       mov       rdx,7FFBE6E3E378
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DB60D0]
+       call      qword ptr [7FFBE6E545B8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9F1A8
+       mov       rdx,7FFBE6E3E378
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFBE6DB6148]
+       call      qword ptr [7FFBE6E54630]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9F1A8
+       mov       rdx,7FFBE6E3E378
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DB61D8]
+       call      qword ptr [7FFBE6E546C0]
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
-       mov       rdx,7FFBE6D9F2F8
+       mov       rdx,7FFBE6E3E4C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFBE65ED578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFBE65FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFBE6C05140]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFBE6E16FD0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFBE6CC0118]
+       vmulss    xmm0,xmm0,dword ptr [7FFBE6E69618]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFBE6C050F8]
+       jmp       qword ptr [7FFBE6E16F88]
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
-       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6134348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        call      qword ptr [7FFBE6B84DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1E77FC01FE8
+       mov       rcx,10608001FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFBE6BF6580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFBE6BE6580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFBE64B7A38]
+       call      qword ptr [7FFBE64A7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFBE6001100
+       mov       r11,7FFBE5FF0FE0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FFBE6144378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FFBE6134378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9EDC8
+       mov       rdx,7FFBE6D8F8F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6134348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9EDE8
+       mov       rdx,7FFBE6D8F918
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
-       mov       rdx,7FFBE6D9EE00
+       mov       rdx,7FFBE6D8F930
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
-       mov       rdx,7FFBE6D9EF10
+       mov       rdx,7FFBE6D8FA40
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
-       mov       rdx,7FFBE6D9EDD8
+       mov       rdx,7FFBE6D8F908
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DA7288]
+       call      qword ptr [7FFBE6DA6D18]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9EDD8
+       mov       rdx,7FFBE6D8F908
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFBE6DA7300]
+       call      qword ptr [7FFBE6DA6D90]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9EDD8
+       mov       rdx,7FFBE6D8F908
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DA7390]
+       call      qword ptr [7FFBE6DA6E20]
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
-       mov       rdx,7FFBE6D9EF28
+       mov       rdx,7FFBE6D8FA58
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFBE65ED578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFBE65DD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFBE6BF6AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFBE6BE6AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFBE6CB0D98]
+       vmulss    xmm0,xmm0,dword ptr [7FFBE6CAD158]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFBE6BF6A78]
+       jmp       qword ptr [7FFBE6BE6A78]
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
        call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFBE6B84DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFBE6B94DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1E77FC01FE8
+       mov       rcx,2D005401FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFBE6BF6580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFBE6BF5E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
        call      qword ptr [7FFBE64B7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFBE6001100
+       mov       r11,7FFBE6000FE0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        jmp       qword ptr [7FFBE6144378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9EDC8
+       mov       rdx,7FFBE6D9F8D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
        call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9EDE8
+       mov       rdx,7FFBE6D9F8F0
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
-       mov       rdx,7FFBE6D9EE00
+       mov       rdx,7FFBE6D9F908
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
-       mov       rdx,7FFBE6D9EF10
+       mov       rdx,7FFBE6D9FA18
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
-       mov       rdx,7FFBE6D9EDD8
+       mov       rdx,7FFBE6D9F8E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DA7288]
+       call      qword ptr [7FFBE6DB6D18]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9EDD8
+       mov       rdx,7FFBE6D9F8E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFBE6DA7300]
+       call      qword ptr [7FFBE6DB6D90]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9EDD8
+       mov       rdx,7FFBE6D9F8E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DA7390]
+       call      qword ptr [7FFBE6DB6E20]
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
-       mov       rdx,7FFBE6D9EF28
+       mov       rdx,7FFBE6D9FA30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
        call      qword ptr [7FFBE65ED578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFBE6BF6AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFBE6BF63A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFBE6CB0D98]
+       vmulss    xmm0,xmm0,dword ptr [7FFBE6CBD478]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFBE6BF6A78]
+       jmp       qword ptr [7FFBE6BF6358]
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
-       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFBE6B84DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFBE6BA4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1E77FC01FE8
+       mov       rcx,20946001FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFBE6BF6580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFBE6C06580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFBE64B7A38]
+       call      qword ptr [7FFBE64C7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFBE6001100
+       mov       r11,7FFBE6010FE0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FFBE6144378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FFBE6154378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9EDC8
+       mov       rdx,7FFBE6DAF8D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9EDE8
+       mov       rdx,7FFBE6DAF8F0
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
-       mov       rdx,7FFBE6D9EE00
+       mov       rdx,7FFBE6DAF908
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
-       mov       rdx,7FFBE6D9EF10
+       mov       rdx,7FFBE6DAFA18
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
-       mov       rdx,7FFBE6D9EDD8
+       mov       rdx,7FFBE6DAF8E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DA7288]
+       call      qword ptr [7FFBE6DC6D18]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9EDD8
+       mov       rdx,7FFBE6DAF8E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFBE6DA7300]
+       call      qword ptr [7FFBE6DC6D90]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9EDD8
+       mov       rdx,7FFBE6DAF8E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DA7390]
+       call      qword ptr [7FFBE6DC6E20]
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
-       mov       rdx,7FFBE6D9EF28
+       mov       rdx,7FFBE6DAFA30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFBE65ED578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFBE65FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFBE6BF6AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFBE6C06AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFBE6CB0D98]
+       vmulss    xmm0,xmm0,dword ptr [7FFBE6CCD0B8]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFBE6BF6A78]
+       jmp       qword ptr [7FFBE6C06A78]
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
-       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6134348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFBE6B84DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFBE6B74DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1E77FC01FE8
+       mov       rcx,20D10001FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFBE6BF6580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFBE6BE5E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFBE64B7A38]
+       call      qword ptr [7FFBE64A7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFBE6001100
+       mov       r11,7FFBE5FF0FE0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FFBE6144378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FFBE6134378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9EDC8
+       mov       rdx,7FFBE6D8F400
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6134348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9EDE8
+       mov       rdx,7FFBE6D8F420
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
-       mov       rdx,7FFBE6D9EE00
+       mov       rdx,7FFBE6D8F438
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
-       mov       rdx,7FFBE6D9EF10
+       mov       rdx,7FFBE6D8F548
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
-       mov       rdx,7FFBE6D9EDD8
+       mov       rdx,7FFBE6D8F410
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DA7288]
+       call      qword ptr [7FFBE6DA6D00]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9EDD8
+       mov       rdx,7FFBE6D8F410
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFBE6DA7300]
+       call      qword ptr [7FFBE6DA6D78]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9EDD8
+       mov       rdx,7FFBE6D8F410
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DA7390]
+       call      qword ptr [7FFBE6DA6E08]
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
-       mov       rdx,7FFBE6D9EF28
+       mov       rdx,7FFBE6D8F560
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFBE65ED578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFBE65DD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFBE6BF6AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFBE6BE63A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFBE6CB0D98]
+       vmulss    xmm0,xmm0,dword ptr [7FFBE6C9D118]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFBE6BF6A78]
+       jmp       qword ptr [7FFBE6BE6358]
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
-       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFBE6B84DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFBE6BA6B80]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1E77FC01FE8
+       mov       rcx,1DC8B002000
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFBE6BF6580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFBE6DB5110]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFBE64B7A38]
+       call      qword ptr [7FFBE64C7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFBE6001100
+       mov       r11,7FFBE6011300
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
+       jmp       qword ptr [7FFBE6154378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FFBE6144378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9EDC8
+       mov       rdx,7FFBE6E2C0E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9EDE8
+       mov       rdx,7FFBE6E2C100
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
-       mov       rdx,7FFBE6D9EE00
+       mov       rdx,7FFBE6E2C118
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
-       mov       rdx,7FFBE6D9EF10
+       mov       rdx,7FFBE6E2C228
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
-       mov       rdx,7FFBE6D9EDD8
+       mov       rdx,7FFBE6E2C0F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DA7288]
+       call      qword ptr [7FFBE6E44A08]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9EDD8
+       mov       rdx,7FFBE6E2C0F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFBE6DA7300]
+       call      qword ptr [7FFBE6E44A80]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9EDD8
+       mov       rdx,7FFBE6E2C0F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DA7390]
+       call      qword ptr [7FFBE6E44B10]
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
-       mov       rdx,7FFBE6D9EF28
+       mov       rdx,7FFBE6E2C240
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFBE65ED578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFBE65FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFBE6BF6AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFBE6DB5650]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFBE6CB0D98]
+       vmulss    xmm0,xmm0,dword ptr [7FFBE6CD4578]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFBE6BF6A78]
+       jmp       qword ptr [7FFBE6DB5608]
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
-       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFBE6B84DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFBE6C652C0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1E77FC01FE8
+       mov       rcx,1AD8EC14BE0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFBE6BF6580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFBE6E16A90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFBE64B7A38]
+       call      qword ptr [7FFBE64C7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFBE6001100
+       mov       r11,7FFBE6011A90
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
+       jmp       qword ptr [7FFBE6154378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FFBE6144378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9EDC8
+       mov       rdx,7FFBE6E3E368
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9EDE8
+       mov       rdx,7FFBE6E3E388
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
-       mov       rdx,7FFBE6D9EE00
+       mov       rdx,7FFBE6E3E3A0
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
-       mov       rdx,7FFBE6D9EF10
+       mov       rdx,7FFBE6E3E4B0
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
-       mov       rdx,7FFBE6D9EDD8
+       mov       rdx,7FFBE6E3E378
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DA7288]
+       call      qword ptr [7FFBE6E545B8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9EDD8
+       mov       rdx,7FFBE6E3E378
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFBE6DA7300]
+       call      qword ptr [7FFBE6E54630]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9EDD8
+       mov       rdx,7FFBE6E3E378
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DA7390]
+       call      qword ptr [7FFBE6E546C0]
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
-       mov       rdx,7FFBE6D9EF28
+       mov       rdx,7FFBE6E3E4C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFBE65ED578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFBE65FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFBE6BF6AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFBE6E16FD0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFBE6CB0D98]
+       vmulss    xmm0,xmm0,dword ptr [7FFBE6E69618]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFBE6BF6A78]
+       jmp       qword ptr [7FFBE6E16F88]
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
-       call      qword ptr [7FFBE6134348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFBE6B84DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFBE6B94DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,10608001FE8
+       mov       rcx,2D005401FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFBE6BE6580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFBE6BF5E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFBE64A7A38]
+       call      qword ptr [7FFBE64B7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFBE5FF0FE0
+       mov       r11,7FFBE6000FE0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FFBE6134378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FFBE6144378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFBE6D8F8F8
+       mov       rdx,7FFBE6D9F8D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFBE6134348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFBE6D8F918
+       mov       rdx,7FFBE6D9F8F0
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
-       mov       rdx,7FFBE6D8F930
+       mov       rdx,7FFBE6D9F908
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
-       mov       rdx,7FFBE6D8FA40
+       mov       rdx,7FFBE6D9FA18
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
-       mov       rdx,7FFBE6D8F908
+       mov       rdx,7FFBE6D9F8E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DA6D18]
+       call      qword ptr [7FFBE6DB6D18]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D8F908
+       mov       rdx,7FFBE6D9F8E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFBE6DA6D90]
+       call      qword ptr [7FFBE6DB6D90]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D8F908
+       mov       rdx,7FFBE6D9F8E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DA6E20]
+       call      qword ptr [7FFBE6DB6E20]
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
-       mov       rdx,7FFBE6D8FA58
+       mov       rdx,7FFBE6D9FA30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFBE65DD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFBE65ED578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFBE6BE6AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFBE6BF63A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFBE6CAD158]
+       vmulss    xmm0,xmm0,dword ptr [7FFBE6CBD478]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFBE6BE6A78]
+       jmp       qword ptr [7FFBE6BF6358]
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
-       call      qword ptr [7FFBE6134348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFBE6B84DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFBE6BA4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,10608001FE8
+       mov       rcx,20946001FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFBE6BE6580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFBE6C06580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFBE64A7A38]
+       call      qword ptr [7FFBE64C7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFBE5FF0FE0
+       mov       r11,7FFBE6010FE0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FFBE6134378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FFBE6154378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFBE6D8F8F8
+       mov       rdx,7FFBE6DAF8D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFBE6134348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFBE6D8F918
+       mov       rdx,7FFBE6DAF8F0
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
-       mov       rdx,7FFBE6D8F930
+       mov       rdx,7FFBE6DAF908
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
-       mov       rdx,7FFBE6D8FA40
+       mov       rdx,7FFBE6DAFA18
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
-       mov       rdx,7FFBE6D8F908
+       mov       rdx,7FFBE6DAF8E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DA6D18]
+       call      qword ptr [7FFBE6DC6D18]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D8F908
+       mov       rdx,7FFBE6DAF8E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFBE6DA6D90]
+       call      qword ptr [7FFBE6DC6D90]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D8F908
+       mov       rdx,7FFBE6DAF8E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DA6E20]
+       call      qword ptr [7FFBE6DC6E20]
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
-       mov       rdx,7FFBE6D8FA58
+       mov       rdx,7FFBE6DAFA30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFBE65DD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFBE65FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFBE6BE6AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFBE6C06AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFBE6CAD158]
+       vmulss    xmm0,xmm0,dword ptr [7FFBE6CCD0B8]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFBE6BE6A78]
+       jmp       qword ptr [7FFBE6C06A78]
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
        call      qword ptr [7FFBE6134348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFBE6B84DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFBE6B74DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,10608001FE8
+       mov       rcx,20D10001FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFBE6BE6580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFBE6BE5E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
        jmp       qword ptr [7FFBE6134378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFBE6D8F8F8
+       mov       rdx,7FFBE6D8F400
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
        call      qword ptr [7FFBE6134348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFBE6D8F918
+       mov       rdx,7FFBE6D8F420
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
-       mov       rdx,7FFBE6D8F930
+       mov       rdx,7FFBE6D8F438
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
-       mov       rdx,7FFBE6D8FA40
+       mov       rdx,7FFBE6D8F548
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
-       mov       rdx,7FFBE6D8F908
+       mov       rdx,7FFBE6D8F410
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DA6D18]
+       call      qword ptr [7FFBE6DA6D00]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D8F908
+       mov       rdx,7FFBE6D8F410
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFBE6DA6D90]
+       call      qword ptr [7FFBE6DA6D78]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D8F908
+       mov       rdx,7FFBE6D8F410
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DA6E20]
+       call      qword ptr [7FFBE6DA6E08]
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
-       mov       rdx,7FFBE6D8FA58
+       mov       rdx,7FFBE6D8F560
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
        call      qword ptr [7FFBE65DD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFBE6BE6AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFBE6BE63A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFBE6CAD158]
+       vmulss    xmm0,xmm0,dword ptr [7FFBE6C9D118]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFBE6BE6A78]
+       jmp       qword ptr [7FFBE6BE6358]
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
-       call      qword ptr [7FFBE6134348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFBE6B84DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFBE6BA6B80]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,10608001FE8
+       mov       rcx,1DC8B002000
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFBE6BE6580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFBE6DB5110]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFBE64A7A38]
+       call      qword ptr [7FFBE64C7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFBE5FF0FE0
+       mov       r11,7FFBE6011300
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
+       jmp       qword ptr [7FFBE6154378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FFBE6134378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFBE6D8F8F8
+       mov       rdx,7FFBE6E2C0E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFBE6134348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFBE6D8F918
+       mov       rdx,7FFBE6E2C100
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
-       mov       rdx,7FFBE6D8F930
+       mov       rdx,7FFBE6E2C118
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
-       mov       rdx,7FFBE6D8FA40
+       mov       rdx,7FFBE6E2C228
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
-       mov       rdx,7FFBE6D8F908
+       mov       rdx,7FFBE6E2C0F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DA6D18]
+       call      qword ptr [7FFBE6E44A08]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D8F908
+       mov       rdx,7FFBE6E2C0F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFBE6DA6D90]
+       call      qword ptr [7FFBE6E44A80]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D8F908
+       mov       rdx,7FFBE6E2C0F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DA6E20]
+       call      qword ptr [7FFBE6E44B10]
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
-       mov       rdx,7FFBE6D8FA58
+       mov       rdx,7FFBE6E2C240
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFBE65DD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFBE65FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFBE6BE6AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFBE6DB5650]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFBE6CAD158]
+       vmulss    xmm0,xmm0,dword ptr [7FFBE6CD4578]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFBE6BE6A78]
+       jmp       qword ptr [7FFBE6DB5608]
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
-       call      qword ptr [7FFBE6134348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFBE6B84DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFBE6C652C0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,10608001FE8
+       mov       rcx,1AD8EC14BE0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFBE6BE6580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFBE6E16A90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFBE64A7A38]
+       call      qword ptr [7FFBE64C7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFBE5FF0FE0
+       mov       r11,7FFBE6011A90
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
+       jmp       qword ptr [7FFBE6154378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FFBE6134378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFBE6D8F8F8
+       mov       rdx,7FFBE6E3E368
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFBE6134348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFBE6D8F918
+       mov       rdx,7FFBE6E3E388
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
-       mov       rdx,7FFBE6D8F930
+       mov       rdx,7FFBE6E3E3A0
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
-       mov       rdx,7FFBE6D8FA40
+       mov       rdx,7FFBE6E3E4B0
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
-       mov       rdx,7FFBE6D8F908
+       mov       rdx,7FFBE6E3E378
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DA6D18]
+       call      qword ptr [7FFBE6E545B8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D8F908
+       mov       rdx,7FFBE6E3E378
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFBE6DA6D90]
+       call      qword ptr [7FFBE6E54630]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D8F908
+       mov       rdx,7FFBE6E3E378
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DA6E20]
+       call      qword ptr [7FFBE6E546C0]
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
-       mov       rdx,7FFBE6D8FA58
+       mov       rdx,7FFBE6E3E4C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFBE65DD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFBE65FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFBE6BE6AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFBE6E16FD0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFBE6CAD158]
+       vmulss    xmm0,xmm0,dword ptr [7FFBE6E69618]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFBE6BE6A78]
+       jmp       qword ptr [7FFBE6E16F88]
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
-       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFBE6B94DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFBE6BA4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,2D005401FE8
+       mov       rcx,20946001FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFBE6BF5E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFBE6C06580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFBE64B7A38]
+       call      qword ptr [7FFBE64C7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFBE6000FE0
+       mov       r11,7FFBE6010FE0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FFBE6144378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FFBE6154378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9F8D0
+       mov       rdx,7FFBE6DAF8D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9F8F0
+       mov       rdx,7FFBE6DAF8F0
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
-       mov       rdx,7FFBE6D9F908
+       mov       rdx,7FFBE6DAF908
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
-       mov       rdx,7FFBE6D9FA18
+       mov       rdx,7FFBE6DAFA18
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
-       mov       rdx,7FFBE6D9F8E0
+       mov       rdx,7FFBE6DAF8E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DB6D18]
+       call      qword ptr [7FFBE6DC6D18]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9F8E0
+       mov       rdx,7FFBE6DAF8E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFBE6DB6D90]
+       call      qword ptr [7FFBE6DC6D90]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9F8E0
+       mov       rdx,7FFBE6DAF8E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DB6E20]
+       call      qword ptr [7FFBE6DC6E20]
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
-       mov       rdx,7FFBE6D9FA30
+       mov       rdx,7FFBE6DAFA30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFBE65ED578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFBE65FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFBE6BF63A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFBE6C06AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFBE6CBD478]
+       vmulss    xmm0,xmm0,dword ptr [7FFBE6CCD0B8]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFBE6BF6358]
+       jmp       qword ptr [7FFBE6C06A78]
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
-       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6134348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFBE6B94DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFBE6B74DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,2D005401FE8
+       mov       rcx,20D10001FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFBE6BF5E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFBE6BE5E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFBE64B7A38]
+       call      qword ptr [7FFBE64A7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFBE6000FE0
+       mov       r11,7FFBE5FF0FE0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FFBE6144378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FFBE6134378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9F8D0
+       mov       rdx,7FFBE6D8F400
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6134348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9F8F0
+       mov       rdx,7FFBE6D8F420
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
-       mov       rdx,7FFBE6D9F908
+       mov       rdx,7FFBE6D8F438
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
-       mov       rdx,7FFBE6D9FA18
+       mov       rdx,7FFBE6D8F548
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
-       mov       rdx,7FFBE6D9F8E0
+       mov       rdx,7FFBE6D8F410
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DB6D18]
+       call      qword ptr [7FFBE6DA6D00]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9F8E0
+       mov       rdx,7FFBE6D8F410
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFBE6DB6D90]
+       call      qword ptr [7FFBE6DA6D78]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9F8E0
+       mov       rdx,7FFBE6D8F410
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DB6E20]
+       call      qword ptr [7FFBE6DA6E08]
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
-       mov       rdx,7FFBE6D9FA30
+       mov       rdx,7FFBE6D8F560
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFBE65ED578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFBE65DD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFBE6BF63A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFBE6BE63A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFBE6CBD478]
+       vmulss    xmm0,xmm0,dword ptr [7FFBE6C9D118]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFBE6BF6358]
+       jmp       qword ptr [7FFBE6BE6358]
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
-       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFBE6B94DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFBE6BA6B80]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,2D005401FE8
+       mov       rcx,1DC8B002000
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFBE6BF5E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFBE6DB5110]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFBE64B7A38]
+       call      qword ptr [7FFBE64C7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFBE6000FE0
+       mov       r11,7FFBE6011300
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
+       jmp       qword ptr [7FFBE6154378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FFBE6144378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9F8D0
+       mov       rdx,7FFBE6E2C0E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9F8F0
+       mov       rdx,7FFBE6E2C100
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
-       mov       rdx,7FFBE6D9F908
+       mov       rdx,7FFBE6E2C118
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
-       mov       rdx,7FFBE6D9FA18
+       mov       rdx,7FFBE6E2C228
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
-       mov       rdx,7FFBE6D9F8E0
+       mov       rdx,7FFBE6E2C0F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DB6D18]
+       call      qword ptr [7FFBE6E44A08]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9F8E0
+       mov       rdx,7FFBE6E2C0F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFBE6DB6D90]
+       call      qword ptr [7FFBE6E44A80]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9F8E0
+       mov       rdx,7FFBE6E2C0F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DB6E20]
+       call      qword ptr [7FFBE6E44B10]
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
-       mov       rdx,7FFBE6D9FA30
+       mov       rdx,7FFBE6E2C240
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFBE65ED578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFBE65FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFBE6BF63A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFBE6DB5650]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFBE6CBD478]
+       vmulss    xmm0,xmm0,dword ptr [7FFBE6CD4578]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFBE6BF6358]
+       jmp       qword ptr [7FFBE6DB5608]
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
-       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFBE6B94DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFBE6C652C0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,2D005401FE8
+       mov       rcx,1AD8EC14BE0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFBE6BF5E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFBE6E16A90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFBE64B7A38]
+       call      qword ptr [7FFBE64C7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFBE6000FE0
+       mov       r11,7FFBE6011A90
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
+       jmp       qword ptr [7FFBE6154378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FFBE6144378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9F8D0
+       mov       rdx,7FFBE6E3E368
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFBE6144348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFBE6D9F8F0
+       mov       rdx,7FFBE6E3E388
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
-       mov       rdx,7FFBE6D9F908
+       mov       rdx,7FFBE6E3E3A0
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
-       mov       rdx,7FFBE6D9FA18
+       mov       rdx,7FFBE6E3E4B0
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
-       mov       rdx,7FFBE6D9F8E0
+       mov       rdx,7FFBE6E3E378
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DB6D18]
+       call      qword ptr [7FFBE6E545B8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9F8E0
+       mov       rdx,7FFBE6E3E378
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFBE6DB6D90]
+       call      qword ptr [7FFBE6E54630]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D9F8E0
+       mov       rdx,7FFBE6E3E378
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DB6E20]
+       call      qword ptr [7FFBE6E546C0]
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
-       mov       rdx,7FFBE6D9FA30
+       mov       rdx,7FFBE6E3E4C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFBE65ED578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFBE65FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFBE6BF63A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFBE6E16FD0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFBE6CBD478]
+       vmulss    xmm0,xmm0,dword ptr [7FFBE6E69618]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFBE6BF6358]
+       jmp       qword ptr [7FFBE6E16F88]
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
-       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6134348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFBE6BA4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFBE6B74DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,20946001FE8
+       mov       rcx,20D10001FE8
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFBE6C06580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFBE6BE5E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFBE64C7A38]
+       call      qword ptr [7FFBE64A7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFBE6010FE0
+       mov       r11,7FFBE5FF0FE0
        call      qword ptr [r11]
        test      rax,rax
        jne       short M00_L00
        test      dword ptr [rax],406C0000
        jne       short M01_L05
        xor       edx,edx
        jmp       short M01_L01
 M01_L05:
-       jmp       qword ptr [7FFBE6154378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+       jmp       qword ptr [7FFBE6134378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFBE6DAF8D0
+       mov       rdx,7FFBE6D8F400
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6134348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFBE6DAF8F0
+       mov       rdx,7FFBE6D8F420
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
-       mov       rdx,7FFBE6DAF908
+       mov       rdx,7FFBE6D8F438
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
-       mov       rdx,7FFBE6DAFA18
+       mov       rdx,7FFBE6D8F548
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
-       mov       rdx,7FFBE6DAF8E0
+       mov       rdx,7FFBE6D8F410
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DC6D18]
+       call      qword ptr [7FFBE6DA6D00]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFBE6DAF8E0
+       mov       rdx,7FFBE6D8F410
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFBE6DC6D90]
+       call      qword ptr [7FFBE6DA6D78]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFBE6DAF8E0
+       mov       rdx,7FFBE6D8F410
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DC6E20]
+       call      qword ptr [7FFBE6DA6E08]
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
-       mov       rdx,7FFBE6DAFA30
+       mov       rdx,7FFBE6D8F560
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFBE65FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFBE65DD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFBE6C06AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFBE6BE63A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFBE6CCD0B8]
+       vmulss    xmm0,xmm0,dword ptr [7FFBE6C9D118]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFBE6C06A78]
+       jmp       qword ptr [7FFBE6BE6358]
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
        call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFBE6BA4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFBE6BA6B80]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,20946001FE8
+       mov       rcx,1DC8B002000
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFBE6C06580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFBE6DB5110]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
        call      qword ptr [7FFBE64C7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFBE6010FE0
+       mov       r11,7FFBE6011300
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
+       jmp       qword ptr [7FFBE6154378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FFBE6154378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFBE6DAF8D0
+       mov       rdx,7FFBE6E2C0E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
        call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFBE6DAF8F0
+       mov       rdx,7FFBE6E2C100
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
-       mov       rdx,7FFBE6DAF908
+       mov       rdx,7FFBE6E2C118
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
-       mov       rdx,7FFBE6DAFA18
+       mov       rdx,7FFBE6E2C228
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
-       mov       rdx,7FFBE6DAF8E0
+       mov       rdx,7FFBE6E2C0F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DC6D18]
+       call      qword ptr [7FFBE6E44A08]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFBE6DAF8E0
+       mov       rdx,7FFBE6E2C0F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFBE6DC6D90]
+       call      qword ptr [7FFBE6E44A80]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFBE6DAF8E0
+       mov       rdx,7FFBE6E2C0F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DC6E20]
+       call      qword ptr [7FFBE6E44B10]
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
-       mov       rdx,7FFBE6DAFA30
+       mov       rdx,7FFBE6E2C240
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
        call      qword ptr [7FFBE65FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFBE6C06AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFBE6DB5650]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFBE6CCD0B8]
+       vmulss    xmm0,xmm0,dword ptr [7FFBE6CD4578]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFBE6C06A78]
+       jmp       qword ptr [7FFBE6DB5608]
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
        call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFBE6BA4DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFBE6C652C0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,20946001FE8
+       mov       rcx,1AD8EC14BE0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFBE6C06580]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFBE6E16A90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
        call      qword ptr [7FFBE64C7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFBE6010FE0
+       mov       r11,7FFBE6011A90
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
+       jmp       qword ptr [7FFBE6154378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FFBE6154378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFBE6DAF8D0
+       mov       rdx,7FFBE6E3E368
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
        call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFBE6DAF8F0
+       mov       rdx,7FFBE6E3E388
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
-       mov       rdx,7FFBE6DAF908
+       mov       rdx,7FFBE6E3E3A0
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
-       mov       rdx,7FFBE6DAFA18
+       mov       rdx,7FFBE6E3E4B0
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
-       mov       rdx,7FFBE6DAF8E0
+       mov       rdx,7FFBE6E3E378
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DC6D18]
+       call      qword ptr [7FFBE6E545B8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFBE6DAF8E0
+       mov       rdx,7FFBE6E3E378
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFBE6DC6D90]
+       call      qword ptr [7FFBE6E54630]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFBE6DAF8E0
+       mov       rdx,7FFBE6E3E378
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DC6E20]
+       call      qword ptr [7FFBE6E546C0]
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
-       mov       rdx,7FFBE6DAFA30
+       mov       rdx,7FFBE6E3E4C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
        call      qword ptr [7FFBE65FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFBE6C06AC0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFBE6E16FD0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFBE6CCD0B8]
+       vmulss    xmm0,xmm0,dword ptr [7FFBE6E69618]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFBE6C06A78]
+       jmp       qword ptr [7FFBE6E16F88]
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
-       call      qword ptr [7FFBE6134348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFBE6B74DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFBE6BA6B80]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,20D10001FE8
+       mov       rcx,1DC8B002000
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFBE6BE5E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFBE6DB5110]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFBE64A7A38]
+       call      qword ptr [7FFBE64C7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFBE5FF0FE0
+       mov       r11,7FFBE6011300
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
+       jmp       qword ptr [7FFBE6154378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FFBE6134378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFBE6D8F400
+       mov       rdx,7FFBE6E2C0E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFBE6134348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFBE6D8F420
+       mov       rdx,7FFBE6E2C100
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
-       mov       rdx,7FFBE6D8F438
+       mov       rdx,7FFBE6E2C118
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
-       mov       rdx,7FFBE6D8F548
+       mov       rdx,7FFBE6E2C228
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
-       mov       rdx,7FFBE6D8F410
+       mov       rdx,7FFBE6E2C0F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DA6D00]
+       call      qword ptr [7FFBE6E44A08]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D8F410
+       mov       rdx,7FFBE6E2C0F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFBE6DA6D78]
+       call      qword ptr [7FFBE6E44A80]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D8F410
+       mov       rdx,7FFBE6E2C0F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DA6E08]
+       call      qword ptr [7FFBE6E44B10]
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
-       mov       rdx,7FFBE6D8F560
+       mov       rdx,7FFBE6E2C240
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFBE65DD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFBE65FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFBE6BE63A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFBE6DB5650]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFBE6C9D118]
+       vmulss    xmm0,xmm0,dword ptr [7FFBE6CD4578]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFBE6BE6358]
+       jmp       qword ptr [7FFBE6DB5608]
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
-       call      qword ptr [7FFBE6134348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFBE6B74DC8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFBE6C652C0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,20D10001FE8
+       mov       rcx,1AD8EC14BE0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFBE6BE5E60]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFBE6E16A90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
-       call      qword ptr [7FFBE64A7A38]
+       call      qword ptr [7FFBE64C7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFBE5FF0FE0
+       mov       r11,7FFBE6011A90
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
+       jmp       qword ptr [7FFBE6154378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       jmp       qword ptr [7FFBE6134378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
-       mov       rdx,7FFBE6D8F400
+       mov       rdx,7FFBE6E3E368
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFBE6134348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
+       call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFBE6D8F420
+       mov       rdx,7FFBE6E3E388
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
-       mov       rdx,7FFBE6D8F438
+       mov       rdx,7FFBE6E3E3A0
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
-       mov       rdx,7FFBE6D8F548
+       mov       rdx,7FFBE6E3E4B0
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
-       mov       rdx,7FFBE6D8F410
+       mov       rdx,7FFBE6E3E378
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DA6D00]
+       call      qword ptr [7FFBE6E545B8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D8F410
+       mov       rdx,7FFBE6E3E378
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFBE6DA6D78]
+       call      qword ptr [7FFBE6E54630]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFBE6D8F410
+       mov       rdx,7FFBE6E3E378
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6DA6E08]
+       call      qword ptr [7FFBE6E546C0]
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
-       mov       rdx,7FFBE6D8F560
+       mov       rdx,7FFBE6E3E4C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
-       call      qword ptr [7FFBE65DD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
+       call      qword ptr [7FFBE65FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFBE6BE63A0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFBE6E16FD0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFBE6C9D118]
+       vmulss    xmm0,xmm0,dword ptr [7FFBE6E69618]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFBE6BE6358]
+       jmp       qword ptr [7FFBE6E16F88]
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
        call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        jne       short M00_L03
        mov       rdx,rsi
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFBE6BA6B80]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFBE6C652C0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        test      rax,rax
        je        short M00_L04
 M00_L00:
        lea       rsi,[rax+10]
        mov       edi,[rax+8]
 M00_L01:
-       mov       rcx,1DC8B002000
+       mov       rcx,1AD8EC14BE0
        mov       rcx,[rcx]
        mov       [rsp+28],rsi
        mov       [rsp+30],edi
        lea       rdx,[rsp+28]
-       call      qword ptr [7FFBE6DB5110]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
+       call      qword ptr [7FFBE6E16A90]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.ReadOnlySpan`1<System.__Canon>)
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
        call      qword ptr [7FFBE64C7A38]
        int       3
 M00_L03:
        mov       rcx,rax
-       mov       r11,7FFBE6011300
+       mov       r11,7FFBE6011A90
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
-M01_L03:
-       pop       rbx
+M01_L02:
        jmp       qword ptr [7FFBE6154378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
+M01_L03:
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
-       mov       rdx,7FFBE6E2C0E0
+       mov       rdx,7FFBE6E3E368
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L01:
        mov       rdx,rsi
        call      qword ptr [7FFBE6154348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
-       mov       rdx,7FFBE6E2C100
+       mov       rdx,7FFBE6E3E388
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
-       mov       rdx,7FFBE6E2C118
+       mov       rdx,7FFBE6E3E3A0
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
-       mov       rdx,7FFBE6E2C228
+       mov       rdx,7FFBE6E3E4B0
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
-       mov       rdx,7FFBE6E2C0F0
+       mov       rdx,7FFBE6E3E378
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L10:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6E44A08]
+       call      qword ptr [7FFBE6E545B8]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L11
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L11
        jmp       short M02_L12
 M02_L11:
        mov       rcx,rbx
-       mov       rdx,7FFBE6E2C0F0
+       mov       rdx,7FFBE6E3E378
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L12:
        lea       rcx,[rsp+28]
        mov       r8,rsi
-       call      qword ptr [7FFBE6E44A80]
+       call      qword ptr [7FFBE6E54630]
        mov       rcx,[rbx+10]
        cmp       qword ptr [rcx+8],38
        jle       short M02_L13
        mov       rdx,[rcx+38]
        test      rdx,rdx
        je        short M02_L13
        jmp       short M02_L14
 M02_L13:
        mov       rcx,rbx
-       mov       rdx,7FFBE6E2C0F0
+       mov       rdx,7FFBE6E3E378
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M02_L14:
        lea       rcx,[rsp+28]
-       call      qword ptr [7FFBE6E44B10]
+       call      qword ptr [7FFBE6E546C0]
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
-       mov       rdx,7FFBE6E2C240
+       mov       rdx,7FFBE6E3E4C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M02_L17:
        call      qword ptr [7FFBE65FD578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
-       jmp       qword ptr [7FFBE6DB5650]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
+       jmp       qword ptr [7FFBE6E16FD0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.ReadOnlySpan`1<System.__Canon>)
 M03_L01:
        mov       rax,[rcx+8]
        mov       eax,[rax+20]
        add       eax,[rdx+8]
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2ss xmm0,xmm0,eax
-       vmulss    xmm0,xmm0,dword ptr [7FFBE6CD4578]
+       vmulss    xmm0,xmm0,dword ptr [7FFBE6E69618]
        mov       rax,[rcx+8]
        vxorps    xmm1,xmm1,xmm1
        vcvtsi2ss xmm1,xmm1,dword ptr [rax+20]
        vucomiss  xmm0,xmm1
        ja        short M03_L00
-       jmp       qword ptr [7FFBE6DB5608]
+       jmp       qword ptr [7FFBE6E16F88]
 ; Total bytes of code 71
```
